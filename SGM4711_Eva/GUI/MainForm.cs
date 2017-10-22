using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MDRegTool;
using System.Runtime.InteropServices;
using GeneralRegConfigPlatform.MDDataBase;
using MD.MDCommon;
using GeneralRegConfigPlatform.MDGUI;
using DMCommunication;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using SGM4711_Eva.GUI;
using SGM4711_Eva.MDUserCtrls;

namespace SGM4711_Eva
{
    [Serializable]
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitGUI();
        }

        #region Params
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        bool blockDiagramMode = true;

        DataSet DS_Excel;
        MDDataSet DataSet;
        RegisterMap regMap;
        List<MDRegisterViewTab> AllTables = new List<MDRegisterViewTab> { };
        DMDongle myDongle = new DMDongle();
        List<String> historyProjPath = new List<string> { };
        int maxHistProjPathCount = 10;
        String currentProjPath = "";

        TabControl tabCtrlRegMapView = new TabControl();
        #endregion Params

        #region Funcs
        private void InitGUI()
        {
            singleRegCtrl = new RegSettingCtrl();
            singleRegCtrl.Dock = DockStyle.Fill;
            this.tabP_SingleCtrl.Controls.Add(singleRegCtrl);
            freeRegCtrl = new FreeRegRWCtrl();
            freeRegCtrl.Dock = DockStyle.Fill;
            this.tabP_RegRW.Controls.Add(freeRegCtrl);

            // init Mian GUI commbox
            this.cmb_ModeConfig.SelectedIndex = 0;
            this.cmb_InterfaceConfig.SelectedIndex = 0;
        }

        private void CreateTabs(DataSet _ds)
        {
            this.tabCtrlRegMapView.TabPages.Clear();
            AllTables.Clear();
            for (int ix_tab = 0; ix_tab < _ds.Tables.Count; ix_tab++)
            {
                this.tabCtrlRegMapView.TabPages.Add(_ds.Tables[ix_tab].TableName);
                MDRegisterViewTab newTab = new MDRegisterViewTab(_ds.Tables[ix_tab], _ds.Tables["Customer"], DataSet.RegMap, myDongle);
                this.tabCtrlRegMapView.TabPages[ix_tab].Controls.Add(newTab);
                AllTables.Add(newTab);
                newTab.Dock = DockStyle.Fill;
                newTab.BorderStyle = BorderStyle.Fixed3D;
            }

            //Create script tab
            this.tabCtrlRegMapView.TabPages.Add("Script");
            FormScript frm_script = new FormScript(myDongle);
            this.tabCtrlRegMapView.TabPages[tabCtrlRegMapView.TabPages.Count - 1].Controls.Add(frm_script);
            //AllTables.Add(frm_script);
            frm_script.Dock = DockStyle.Fill;
            frm_script.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ShowModeChanging(bool _blockDiagram)
        {
            this.splitContainer1.Panel1Collapsed = !blockDiagramMode;
            this.splitContainer2.Panel2Collapsed = !blockDiagramMode;

            this.splitContainer2.Panel1.Controls.Clear();
            if (!_blockDiagram)
            {
                //this.tabCtrl_SingleRegSetting.Visible = false;
                //this.splitContainer2.Panel1.Controls.Clear();
                this.splitContainer2.Panel1.Controls.Add(tabCtrlRegMapView);
                tabCtrlRegMapView.Dock = DockStyle.Fill;
            }
            else
            {
                this.splitContainer2.Panel1.Controls.Add(tabCtrl_SingleRegSetting);
                tabCtrl_SingleRegSetting.Dock = DockStyle.Fill;
            }
        }

        private void SerializeMethod(string path)
        {
            //创建一个格式化程序的实例
            IFormatter formatter = new BinaryFormatter();             //创建一个文件流
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, DataSet);
            stream.Close();
        }

        private void DeserializeMethod(string path)
        {
            //创建一个文件流
            IFormatter formatter = new BinaryFormatter();
            Stream destream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            DataSet = formatter.Deserialize(destream) as MDDataSet;
            destream.Close();

            //To DO: Add create taps on GUI with dataset
        }

        private void UpdateChildGUI()
        {
            //Transfer regmap to other classes
            this.singleRegCtrl.UpdateRegMap(regMap);
            this.freeRegCtrl.UpdateRegMap(regMap);
        }

        private void ReadAllAndUpdateGUI()
        {
            if (regMap != null && myDongle.IsOpen)
            {
                foreach(Register tempReg in regMap.RegList)
                {
                    myDongle.readRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);
                }                                
            }

            // Update GUI
        }

        #endregion Funcs

        private void tabP_DoubleClick(object sender, EventArgs e)
        {
            blockDiagramMode = !blockDiagramMode;
            this.splitContainer1.Panel1Collapsed = blockDiagramMode;
            this.splitContainer2.Panel2Collapsed = blockDiagramMode;
        }

        private void tabCtrl_RegSetting_DrawItem(object sender, DrawItemEventArgs e)
        {
            //SolidBrush lightGray = new SolidBrush(Color.White);
            //e.Graphics.FillRectangle(lightGray, tabCtrl_RegSetting.GetTabRect(0));
            //Rectangle rec_tab = new Rectangle(tabCtrl_RegSetting.Location, new Size(tabCtrl_RegSetting.Size.Width, tabCtrl_RegSetting.GetTabRect(0).Size.Height));
            //e.Graphics.FillRectangle(lightGray, rec_tab);
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //for (int i = 0; i < tabCtrl_RegSetting.TabPages.Count; i++)
            //{
            //    Rectangle rec = tabCtrl_RegSetting.GetTabRect(i);
            //    rec.Y += 5;
            //    e.Graphics.DrawString(tabCtrl_RegSetting.TabPages[i].Text, new Font("SimSun", 9), new SolidBrush(Color.Black), rec, stringFormat);
            //}
        }
        
        #region GUI control
        BindingList<RegProperty> regCtrlList = new BindingList<RegProperty> { };
        RegSettingCtrl singleRegCtrl = null;
        FreeRegRWCtrl freeRegCtrl = null;
        
        private void UpdateRegSettingSource(byte _regAddr)
        {
            if (regMap == null)
            {
                MessageBox.Show("Please open excel or project first.");
                return;
            }

            regCtrlList.Clear();
            RegProperty tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, regMap[_regAddr].RegValue.ToString("X")) { };
            regCtrlList.Add(tempReg);

            this.singleRegCtrl.UpdateDataSource(regCtrlList);
        }

        private void UpdateRegSettingSource(byte[] _regList)
        {
            if (regMap == null)
            {
                MessageBox.Show("Please open excel or project first.");
                return;
            }

            byte tempAddr = 0;
            regCtrlList.Clear();
            for (int ix = 0; ix < _regList.Length; ix++)
            {
                tempAddr = _regList[ix];
                RegProperty tempReg = new RegProperty(tempAddr.ToString("X2"), regMap[tempAddr].RegName, regMap[tempAddr].RegValue.ToString("X")) { };
                regCtrlList.Add(tempReg);
            }
            this.singleRegCtrl.UpdateDataSource(regCtrlList);
        }

        private void UpdateRegSettingSource(byte _regAddr, string[] bf_nameList)
        {
            if (regMap == null)
            {
                MessageBox.Show("Please open excel or project first.");
                return;
            }

            regCtrlList.Clear();
            RegProperty tempReg;
            if(regMap[_regAddr].ByteCount <= 4)
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, regMap[_regAddr].RegValue.ToString("X")) { };
            else
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, "") { };

            regCtrlList.Add(tempReg);

            for (int ix = 0; ix < bf_nameList.Length; ix++)
            {
                //tempReg = new RegProperty("", bf_nameList[ix], regMap[_regAddr][bf_nameList[ix]].BFValue.ToString("X")) { };
                tempReg = new RegProperty("", bf_nameList[ix], regMap[_regAddr][bf_nameList[ix]].BFValue.ToString("X")) { };
                regCtrlList.Add(tempReg);
            }

            this.singleRegCtrl.UpdateDataSource(regCtrlList);
        }

        private void UpdateRegSettingSource(byte _regAddr, string[] bf_nameList, bool append)
        {
            if (regMap == null)
            {
                MessageBox.Show("Please open excel or project first.");
                return;
            }

            if(!append)
                regCtrlList.Clear();

            RegProperty tempReg;
            if (regMap[_regAddr].ByteCount <= 4)
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, regMap[_regAddr].RegValue.ToString("X")) { };
            else
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, "") { };

            regCtrlList.Add(tempReg);

            for (int ix = 0; ix < bf_nameList.Length; ix++)
            {
                //tempReg = new RegProperty("", bf_nameList[ix], regMap[_regAddr][bf_nameList[ix]].BFValue.ToString("X")) { };
                tempReg = new RegProperty("", bf_nameList[ix], regMap[_regAddr][bf_nameList[ix]].BFValue.ToString("X")) { };
                regCtrlList.Add(tempReg);
            }

            this.singleRegCtrl.UpdateDataSource(regCtrlList);
        }

        private void pl_HPFInput_Click(object sender, EventArgs e)
        {
            /* 0x03 bit7*/
            UpdateRegSettingSource(0x03, new string[] { "PRE_HPF_EN" });
        }

        private void pl_1BQ_LIn_Click(object sender, EventArgs e)
        {
            /* 0x29 */
            UpdateRegSettingSource(0x29);
        }

        private void pl_1BQ_LIn_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x29 });
            myEQ.ShowDialog();
        }

        private void pl_1BQ_RIn_Click(object sender, EventArgs e)
        {
            /* 0x30 */
            UpdateRegSettingSource(0x30);
        }

        private void pl_1BQ_RIn_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x30 });
            myEQ.ShowDialog();
        }

        private void pl_LRMixGain_Sub_Click(object sender, EventArgs e)
        {
            /* 1. 0x61 BF[31: 16] */
            /* 2. 0x61 BF[15: 0] */
            UpdateRegSettingSource(0x61, new string[] { "CH4_INPUT_MIXER_1[25:0]", "CH4_INPUT_MIXER_0[25:0]" });
        }

        private void pl_LRPreMixGain_L_Click(object sender, EventArgs e)
        {
            /* 1. 0x53 BF[127: 96] */
            /* 2. 0x53 BF[95: 64] */
            UpdateRegSettingSource(0x53, new string[] { "CH1_INPUT_MIXER_3[25:0]", "CH1_INPUT_MIXER_2[25:0]" });
        }

        private void pl_LRPreMixGain_R_Click(object sender, EventArgs e)
        {
            /* 1. 0x54 BF[127: 96] */
            /* 2. 0x54 BF[95: 64] */
            UpdateRegSettingSource(0x54, new string[] { "CH2_INPUT_MIXER_3[25:0]", "CH2_INPUT_MIXER_2[25:0]" });
        }

        private void pl_1BQ_LRMix_L_Click(object sender, EventArgs e)
        {
            /* 0x2A */
            UpdateRegSettingSource(0x2A);
        }

        private void pl_1BQ_LRMix_L_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x2A });
            myEQ.ShowDialog();
        }

        private void pl_1BQ_LRMix_R_Click(object sender, EventArgs e)
        {
            /* 0x31 */
            UpdateRegSettingSource(0x31);
        }

        private void pl_1BQ_LRMix_R_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x31 });
            myEQ.ShowDialog();
        }

        private void pl_LRMixGain_L_Click(object sender, EventArgs e)
        {
            /* 1. 0x53 BF[63: 32] */
            /* 2. 0x53 BF[31: 0] */
            UpdateRegSettingSource(0x53, new string[] { "CH1_INPUT_MIXER_1[25:0]", "CH1_INPUT_MIXER_0[25:0]" });
        }

        private void pl_LRMixGain_R_Click(object sender, EventArgs e)
        {
            /* 1. 0x54 BF[63: 32] */
            /* 2. 0x54 BF[31: 0] */
            UpdateRegSettingSource(0x54, new string[] { "CH2_INPUT_MIXER_1[25:0]", "CH2_INPUT_MIXER_0[25:0]" });
        }

        private void pl_6EQ_L_Click(object sender, EventArgs e)
        {
            /* 0x2B-0x2F, 0x58*/
            byte[] regList = new byte[] {0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x58};
            UpdateRegSettingSource(regList);
        }

        private void pl_6EQ_L_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(6, regMap, new byte[] { 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x58 });
            myEQ.ShowDialog();
        }

         private void pl_6EQ_R_Click(object sender, EventArgs e)
        {
            /* 0x32-0x36, 0x5C*/
            byte[] regList = new byte[] { 0x32, 0x33, 0x34, 0x35, 0x36, 0x5C };
            UpdateRegSettingSource(regList);
        }

        private void pl_6EQ_R_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(6, regMap, new byte[] { 0x32, 0x33, 0x34, 0x35, 0x36, 0x5C });
            myEQ.ShowDialog();
        }

        private void pl_MidMixGain_Click(object sender, EventArgs e)
        {
            /* 1. 0x55 BF[95: 64] */
            /* 1. 0x55 BF[63: 32] */
            /* 2. 0x55 BF[31: 0] */
            UpdateRegSettingSource(0x55, new string[] { "CH3_INPUT_MIXER_2[25:0]", "CH3_INPUT_MIXER_1[25:0]", "CH3_INPUT_MIXER_0[25:0]" });
        }

        private void pl_LReverb_Click(object sender, EventArgs e)
        {
            /* 0x46 bit5 */
            UpdateRegSettingSource(0x46, new string[] { "DRC_AUTO_LP" });
        }

        private void pl_SubReverb_Click(object sender, EventArgs e)
        {
            /* 0x21 bit8 */
            UpdateRegSettingSource(0x21, new string[] { "CH4_SOURCE_SEL" });
        }

        private void pl_1BQ_LOut_Click(object sender, EventArgs e)
        {
            /* 0x59 */
            UpdateRegSettingSource(0x59);
        }

        private void pl_1BQ_LOut_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x59});
            myEQ.ShowDialog();
        }

        private void pl_1BQ_ROut_Click(object sender, EventArgs e)
        {
            /* 0x5D */
            UpdateRegSettingSource(0x5D);
        }

        private void pl_1BQ_ROut_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x5D });
            myEQ.ShowDialog();
        }

        private void pl_1BQ_Sub_Click(object sender, EventArgs e)
        {
            /* 0x5E */
            UpdateRegSettingSource(0x5E);
        }

        private void pl_1BQ_Sub_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(1, regMap, new byte[] { 0x5E });
            myEQ.ShowDialog();
        }

        private void pl_2BQ_Click(object sender, EventArgs e)
        {
            /* 0x5A, 0x5B */
            UpdateRegSettingSource(new byte[] { 0x5A, 0x5B });
        }

        private void pl_2BQ_DoubleClick(object sender, EventArgs e)
        {
            ParameterEQCtrl myEQ = new ParameterEQCtrl(2, regMap, new byte[] { 0x5A, 0x5B });
            myEQ.ShowDialog();
        }

        private void pl_VOL1_Click(object sender, EventArgs e)
        {
            /* 0x08 */
            UpdateRegSettingSource(0x08);
        }

        private void pl_VOL2_Click(object sender, EventArgs e)
        {
            /* 0x09 */
            UpdateRegSettingSource(0x09);
        }

        private void pl_VOL3_Click(object sender, EventArgs e)
        {
            /* if(0x0E bit6 == 1) then = 0x0A, else 0x08 */
            uint mask = 1 << 6;
            if ((regMap[0x0E].RegValue & mask) > 0)
                UpdateRegSettingSource(0x0A);
            else
                UpdateRegSettingSource(0x08);
        }

        private void pl_VOL4_Click(object sender, EventArgs e)
        {
            /* if(0x0E bit5 == 1) then = 0x0A, else 0x09 */
            uint mask = 1 << 5;
            if ((regMap[0x0E].RegValue & mask) > 0)
                UpdateRegSettingSource(0x0A);
            else
                UpdateRegSettingSource(0x09);
        }

        private void pl_MasterVOL_Click(object sender, EventArgs e)
        {
            /* 0x07 */
            UpdateRegSettingSource(0x07);
        }

        private void pl_DRC1_Click(object sender, EventArgs e)
        {
            /* 0x3A-0x3C, 0x40-0x42,0x46[0] */
            byte[] regList = new byte[] { 0x3A, 0x3B, 0x3C, 0x40, 0x41, 0x42 };
            UpdateRegSettingSource(regList);
            UpdateRegSettingSource(0x46, new string[] { "DRC1_EN" }, true);
        }

        private void pl_DRC1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pl_DRC2_Click(object sender, EventArgs e)
        {
            /* 0x3D-0x3F, 0x43-0x45,0x46[1] */
            byte[] regList = new byte[] { 0x3D, 0x3E, 0x3F, 0x43, 0x44, 0x45 };
            UpdateRegSettingSource(regList);
            UpdateRegSettingSource(0x46, new string[] { "DRC2_EN" }, true);
        }

        private void pl_DRC2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pl_LOutMixGain_Click(object sender, EventArgs e)
        {
            /* 1. 0x51 BF[95: 64] */
            /* 1. 0x51 BF[63: 32] */
            /* 2. 0x51 BF[31: 0] */
            UpdateRegSettingSource(0x51, new string[] { "CH1_OUTPUT_MIXER_2[25:0]", "CH1_OUTPUT_MIXER_1[25:0]", 
                "CH1_OUTPUT_MIXER_0[25:0]" });
        }

        private void pl_ROutMixGain_Click(object sender, EventArgs e)
        {
            /* 1. 0x52 BF[95: 64] */
            /* 1. 0x52 BF[63: 32] */
            /* 2. 0x52 BF[31: 0] */
            UpdateRegSettingSource(0x52, new string[] { "CH2_OUTPUT_MIXER_2[25:0]", "CH2_OUTPUT_MIXER_1[25:0]", 
                "CH2_OUTPUT_MIXER_0[25:0]" });
        }

        private void pl_SubOutMixGain_Click(object sender, EventArgs e)
        {
            /* 1. 0x60 BF[63: 32] */
            /* 2. 0x60 BF[31: 0] */
            UpdateRegSettingSource(0x60, new string[] { "CH4_OUTPUT_MIXER_1[25:0]", "CH4_OUTPUT_MIXER_0[25:0]" });
        }

        private void pl_GainBeforeClipper_Click(object sender, EventArgs e)
        {
            /* 0x56 */
            UpdateRegSettingSource(0x56);
        }

        private void pl_GainAfterClipper_Click(object sender, EventArgs e)
        {
            /* 0x57 */
            UpdateRegSettingSource(0x57);
        }

        private void pl_HPFLOut_Click(object sender, EventArgs e)
        {
            /* 0x03 bit6 */
            UpdateRegSettingSource(0x03, new string[] { "POST_HPF_EN" });
        }

        private void pl_NGLOut_Click(object sender, EventArgs e)
        {
            /* 0x63, 0x64 */
            UpdateRegSettingSource(new byte[] { 0x63, 0x64 });

        }
        #endregion GUI control
        
        #region Menu Event
        private void MenuItemFile_Open_Excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select regmap excel file...";
            ofd.Filter = "xlsx(*.xlsx)|*.xlsx|xls(*.xls)|*.xls|All Files(*.*)|*.*";
            //ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImportRegFromExcel tool = new MDRegTool.ImportRegFromExcel(ofd.FileName);
                DS_Excel = tool.ImportExcel();
                if (DS_Excel == null)
                    return;

                DataSet = new MDDataSet(DS_Excel);
                regMap = DataSet.RegMap;
                // Init tabs with created data tables
                CreateTabs(DataSet.DS_Display);
            }
            else
                return; 
  
            //Transfer regmap to other child GUIs
            UpdateChildGUI();
            //this.singleRegCtrl.UpdateRegMap(regMap);
            //this.freeRegCtrl.UpdateRegMap(regMap);
        }

        private void MenuItemFile_Open_proj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openProj = new OpenFileDialog();
            openProj.Title = "open an project file and update infomations to GUI...";
            openProj.Filter = "MDPROJ(.mdproj)|*.mdproj";
            //importFile.RestoreDirectory = true;
            if (openProj.ShowDialog() == DialogResult.OK)
            {
                currentProjPath = openProj.FileName;
                DeserializeMethod(currentProjPath);

                regMap = DataSet.RegMap;
                // Init tabs with created data tables
                CreateTabs(DataSet.DS_Display);
            }

            // Transfer regmap to other child GUIs 
            UpdateChildGUI();
        }

        private void MenuItemFile_Save_Click(object sender, EventArgs e)
        {
            // Examine path, if no, then open save file dialog.
            if (!File.Exists(currentProjPath))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "save project file...";
                sfd.Filter = "MDPROJ(.mdproj)|*.mdproj";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentProjPath = sfd.FileName;
                    historyProjPath.Add(currentProjPath);
                    if (historyProjPath.Count > maxHistProjPathCount)
                        historyProjPath.RemoveAt(0);
                }
            }

            SerializeMethod(currentProjPath);
        }

        private void MenuItemFile_SaveAs_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemFile_Close_Click(object sender, EventArgs e)
        {
            tabCtrlRegMapView.TabPages.Clear();
            this.DataSet = null;
            this.DS_Excel = null;
        }

        private void MenuItemFile_Import_Click(object sender, EventArgs e)
        {
            if (AllTables.Count == 0)
            {
                MessageBox.Show("Please open project first!!!");
                return;
            }

            StringBuilder tempValue = new StringBuilder(255);
            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Title = "Import registe setting and update to GUI...";
            importFile.Filter = "MDCFG(.mdcfg)|*.mdcfg|All File(*.*)|*.*";
            //importFile.RestoreDirectory = true;
            if (importFile.ShowDialog() == DialogResult.OK)
            {
                string filename = importFile.FileName;
                foreach (Register reg in regMap.RegList)
                {
                    GetPrivateProfileString(reg.RegName, "Value", "00", tempValue, 256, filename);
                    reg.RegValue = byte.Parse(tempValue.ToString().Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
                }
            }
            //todo update GUI 
            for (int ix = 0; ix < AllTables.Count; ix++)
            {
                AllTables[ix].UpdateAllGUI_Tab();
            }

            // Transfer regmap to other child GUIs 
            UpdateChildGUI();
        }

        private void MenuItemFile_Export_Click(object sender, EventArgs e)
        {
            if (AllTables.Count == 0)
            {
                MessageBox.Show("Please open project first!!!");
                return;
            }

            SaveFileDialog exportFile = new SaveFileDialog();
            exportFile.Title = "Export all the register setting to local file...";
            exportFile.Filter = "MDCFG(.mdcfg)|*.mdcfg|All File(*.*)|*.*";
            //exportFile.RestoreDirectory = true;
            if (exportFile.ShowDialog() == DialogResult.OK)
            {
                string filename = exportFile.FileName;
                foreach (Register reg in regMap.RegList)
                {
                    WritePrivateProfileString(reg.RegName, "Address", "0x" + reg.RegAddress.ToString("X2"), filename);
                    WritePrivateProfileString(reg.RegName, "Value", "0x" + reg.RegValue.ToString("X2"), filename);
                }
            }
        }

        private void MenuItemFile_Exit_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemFile_ExitWithoutSave_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemView_RegMap_Click(object sender, EventArgs e)
        {
            blockDiagramMode = false;
            this.MenuItemView_RegMap.Checked = !blockDiagramMode;
            this.MenuItemView_BD.Checked = blockDiagramMode;
            ShowModeChanging(blockDiagramMode);
        }

        private void MenuItemView_BD_Click(object sender, EventArgs e)
        {
            blockDiagramMode = true;
            this.MenuItemView_RegMap.Checked = !blockDiagramMode;
            this.MenuItemView_BD.Checked = blockDiagramMode;
            ShowModeChanging(blockDiagramMode);
        }
        #endregion Menu Event

        #region Main GUI Tab
        List<Register> regAddrList = new List<Register> { };
        private void numUP_OpVoltage_ValueChanged(object sender, EventArgs e)
        {
            /* *****************************************
             * Reg0x0C bit[3:2] Operation Voltage[1:0] 
             * operation voltage
             * 00:24V(default)
             * 01:18V
             * 10:12V
             * 11:8V
             * *****************************************/
            byte tempAddr = 0x0C;
            byte tempData = 0;
            if(regMap != null)
            {
                tempData = (byte)this.numUP_OpVoltage.Value;
                tempData = (byte)((tempData >= 24) ? 0x0 : ((tempData >= 18) ? 0x01 :
                    ((tempData >= 12) ? 0x02 : 0x03)));
                regMap[tempAddr]["Operation Voltage[1:0]"].BFValue = tempData;
                if(myDongle.IsOpen)
                    myDongle.writeRegSingle(0x0C, tempData);
            }
        }

        private void cmb_ModeConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* **********************************************************************************
             * 2.0: reg05 [2]=0; reg20 byte1[7] = 1; reg20 byte1[3] = 1; reg1A [7] = 1; 
             * reg11=0xb8;reg12=0x60;reg13=0xa0;reg14=0x48;
             * 
             * 2.1: reg05 [2]=1; reg05 [3]=1; reg1A [7] = 1; reg11=0xb8;reg12=0x60;reg13=0xa0;reg14=0x48;
             * 
             * PBTL: reg05 [2]=0; reg20 byte1[7] = 1; reg20 byte1[3] = 1; reg1A [7] = 1; 
             * eg11=0xb8;reg12=0x60;reg13=0xa0;reg14=0x48;
             * **********************************************************************************/
            if (regMap == null)
                return;

            regAddrList.Clear();
            Register tempReg;
            switch (this.cmb_ModeConfig.SelectedIndex)
            {
                case 0:
                    #region 2.0
                    tempReg = regMap[0x05];
                    tempReg["MODE_SEL"].BFValue = 0x0;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x20];
                    tempReg["???"].BFValue = 0x01;          // ?? need confirm
                    tempReg["CH2_MOD"].BFValue = 0x01;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x1A];
                    tempReg["SSTIMER_DIS"].BFValue = 0x1;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x11];
                    tempReg.RegValue = 0xB8;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x12];
                    tempReg.RegValue = 0x60;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x13];
                    tempReg.RegValue = 0xA0;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x14];
                    tempReg.RegValue = 0x48;
                    regAddrList.Add(tempReg);
                    #endregion
                    break;

                case 1:
                    #region 2.1
                    tempReg = regMap[0x05];
                    tempReg["MODE_SEL"].BFValue = 0x1;
                    tempReg["SUB_CH_MOD"].BFValue = 0x1;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x1A];
                    tempReg["SSTIMER_DIS"].BFValue = 0x1;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x11];
                    tempReg.RegValue = 0xB8;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x12];
                    tempReg.RegValue = 0x60;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x13];
                    tempReg.RegValue = 0xA0;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x14];
                    tempReg.RegValue = 0x48;
                    regAddrList.Add(tempReg);
                    #endregion

                    break;

                case 2:
                    #region PBTL
                    tempReg = regMap[0x05];
                    tempReg["MODE_SEL"].BFValue = 0x0;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x20];
                    tempReg["???"].BFValue = 0x01;          // ?? need confirm
                    tempReg["CH2_MOD"].BFValue = 0x01;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x1A];
                    tempReg["SSTIMER_DIS"].BFValue = 0x1;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x11];
                    tempReg.RegValue = 0xB8;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x12];
                    tempReg.RegValue = 0x60;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x13];
                    tempReg.RegValue = 0xA0;
                    regAddrList.Add(tempReg);

                    tempReg = regMap[0x14];
                    tempReg.RegValue = 0x48;
                    regAddrList.Add(tempReg);
                    #endregion

                    break;

                default:
                    break;
            }

            if (myDongle.IsOpen)
            {
                for (int ix = 0; ix < regAddrList.Count; ix++)
                {
                    tempReg = regAddrList[ix];
                    myDongle.writeRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);
                }
            }
        }

        private void cmb_InterfaceConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* *****************************************
             * Reg0x04 bit[3:0] AIF_FORMAT[3:0]
             * *****************************************/
            if (regMap == null)
                return;

            Register tempReg = regMap[0x04];
            tempReg["AIF_FORMAT[3:0]"].BFValue = (uint)this.cmb_InterfaceConfig.SelectedIndex;
            if(myDongle.IsOpen)
                myDongle.writeRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);

        }

        private void btn_ClearStatus_Click(object sender, EventArgs e)
        {
            /* Reg0x02 write 0x00 */
            Register tempReg = regMap[0x02];
            tempReg.RegValue = 0x00;
            if (myDongle.IsOpen)
                myDongle.writeRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);
        }

        private void btn_RefreshStatus_Click(object sender, EventArgs e)
        {
            /* Read Reg0x02 */
            if (regMap == null)
                return;

            if (myDongle.IsOpen)
            {
                Register tempReg = regMap[0x02];
                myDongle.readRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);

                // Update indicators
                UpdateIndicator((byte)tempReg.RegValue);
            }
        }

        private void UpdateIndicator(byte regValue)
        {
            /* ********
             * MCLK_ERR
             * PLL_LOCK_ERR
             * BCLK_ERR
             * WS_ERR
             * FRAME_SLIP
             * CLIP_INDICATOR
             * OC_OT_OV_UV
             * OTW
             * ********/
            this.indicator_OTW.IndicatorValue = ((regValue & 0x01) > 0) ?               true : false;
            this.indicator_PSG.IndicatorValue = (((regValue >> 1) & 0x01) > 0) ?        true : false;
            this.indicator_Clip.IndicatorValue = (((regValue >> 2) & 0x01) > 0) ?       true : false;
            this.indicator_FrameSlip.IndicatorValue = (((regValue >> 3) & 0x01) > 0) ?  true : false;
            this.indicator_WS.IndicatorValue = (((regValue >> 4) & 0x01) > 0) ?         true : false;
            this.indicator_BCLK.IndicatorValue = (((regValue >> 5) & 0x01) > 0) ?       true : false;
            this.indicator_PLLLock.IndicatorValue = (((regValue >> 6) & 0x01) > 0) ?    true : false;
            this.indicator_MCLK.IndicatorValue = (((regValue >> 7) & 0x01) > 0) ?       true : false;
        }

        private void btn_InputMux_Click(object sender, EventArgs e)
        {
            /* 0x20 byte1[6:4], 0x20 byte1[2:0], 0x21 */
            UpdateRegSettingSource(0x20, new string[] { "SDIN_TO_CH1", "SDIN_TO_CH2" });
            UpdateRegSettingSource(0x21, new string[] { "CH4_SOURCE_SEL" }, true);
        }

        private void btn_InputMux_GUI_Click(object sender, EventArgs e)
        {
            InputMux inputConfig = new InputMux();
            inputConfig.FormClosed += new FormClosedEventHandler(inputConfig_FormClosed);
            inputConfig.ShowDialog();
        }

        private void inputConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update register table displaying
            btn_InputMux_Click(sender, e);
        }

        private void btn_AudioEngine_Click(object sender, EventArgs e)
        {

        }

        private void btn_AudioEngine_GUI_Click(object sender, EventArgs e)
        {
            this.tabCtrl_MainGUI.SelectedIndex = 1;
        }

        private void trb_MasterVolume_Scroll(object sender, EventArgs e)
        {
            /* 0x07 */
            if (regMap != null)
            {
                regMap[0x07].RegValue = (uint)this.trb_MasterVolume.Value;
                UpdateRegSettingSource(0x07);
            }
        }

        private void chb_MuteMasterVolume_CheckedChanged(object sender, EventArgs e)
        {
            /* write 0xFF to 0x07 */
            if (regMap != null)
            {
                regMap[0x07].RegValue = 0xFF;
                UpdateRegSettingSource(0x07);
            }
        }

        private void btn_OutputMux_Click(object sender, EventArgs e)
        {
            /* 0x25 */
            UpdateRegSettingSource(0x25, new string[] { "MUX_TO_OUT_A", "MUX_TO_OUT_B",
                "MUX_TO_OUT_C", "MUX_TO_OUT_D"});
        }
        
        private void btn_OutputMux_GUI_Click(object sender, EventArgs e)
        {
            Output_Mux outputMux = new Output_Mux(this.regMap, this.cmb_ModeConfig.SelectedIndex);
            outputMux.FormClosed += new FormClosedEventHandler(outputMux_FormClosed);
            outputMux.ShowDialog();
        }

        private void outputMux_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_OutputMux_Click(sender, e);
        }

        #endregion Main GUI Tab


        private void cmbx_DropDownResize(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int width = comboBox.DropDownWidth;
            Graphics g = comboBox.CreateGraphics();
            Font font = comboBox.Font;
            int vertScrollBarWidth = 0;
            if (comboBox.Items.Count > comboBox.MaxDropDownItems)
            {
                vertScrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            }
            int newWidth;
            foreach (object item in ((ComboBox)sender).Items)
            {
                string s = comboBox.GetItemText(item);
                newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            comboBox.DropDownWidth = width;
        }

        private void btn_Enable_Click(object sender, EventArgs e)
        {
            /* reg 0x05  bit6*/
            if (regMap == null)
                return;

            regMap[0x05]["ALL_CH_PD"].BFValue = 0x0;
            UpdateRegSettingSource(0x05, new string[] { "ALL_CH_PD" });
        }

        private void btn_backToDefault_Click(object sender, EventArgs e)
        {
            /* write 0 to reg 0xFF */
            if (regMap == null)
                return;

            regMap[0xFF].RegValue = 0x0;
            UpdateRegSettingSource(0x00);

            ReadAllAndUpdateGUI();
        }



    }
}
