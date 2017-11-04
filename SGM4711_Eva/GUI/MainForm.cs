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
using System.IO.Ports;

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

        // Menu Ctrl
        bool blockDiagramMode = true;
        byte chipAddress = 0x1A;

        // Output Log Ctrl
        Color failedLogColor = Color.Red;

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
            singleRegCtrl = new RegSettingCtrl(myDongle);
            singleRegCtrl.Dock = DockStyle.Fill;
            this.tabP_SingleCtrl.Controls.Add(singleRegCtrl);
            this.singleRegCtrl.btn_ReadReg.Click += new EventHandler(btn_ReadReg_RegSetCtrl_Click);
            this.singleRegCtrl.btn_WriteReg.Click += new EventHandler(btn_WriteReg_RegSetCtrl_Click);
            
            freeRegCtrl = new FreeRegRWCtrl(myDongle);
            freeRegCtrl.Dock = DockStyle.Fill;
            this.tabP_RegRW.Controls.Add(freeRegCtrl);
            freeRegCtrl.btn_ReadAllReg.Click += new EventHandler(btn_ReadAllReg_FreeRegCtrl_Click);
            freeRegCtrl.btn_WriteAllReg.Click += new EventHandler(btn_WriteAllReg_FreeRegCtrl_Click);

            memoryTool = new I2CMemTool(this.regMap, myDongle);
            memoryTool.Dock = DockStyle.Fill;
            this.tabP_IICMemTool.Controls.Add(memoryTool);

            // init Mian GUI commbox
            this.cmb_ModeConfig.SelectedIndex = 0;
            this.cmb_InterfaceConfig.SelectedIndex = 5;
            this.cmb_SampleRate.SelectedIndex = 3;
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

        private bool RegRead(byte _regAddr)
        {
            bool ret = false;
            string log = "I2C Read >> \r\n";
            if (myDongle.IsOpen && regMap != null)
            {
                byte[] tempRegBytes;
                Register tempReg = regMap[_regAddr];
                tempRegBytes = new byte[tempReg.ByteCount];
                if (myDongle.readRegBurst(tempReg.RegAddress, tempRegBytes, tempRegBytes.Length))
                {
                    log += "\tOK\t" + "Address: 0x" + _regAddr.ToString("X2") + "\tData(Hex):";
                    for (int ix = 0; ix < tempRegBytes.Length; ix++)
                    {
                        tempReg.ByteValue[ix] = tempRegBytes[ix];
                        log += " " + tempRegBytes[ix].ToString("X2");
                    }
                    
                    ret = true;
                }
            }

            if (ret)
            {
                this.outputLogCtrl.AppendLog(log);
            }
            else
            {
                log += "\tFailed\t" + "Address: 0x" + _regAddr.ToString("X2");
                this.outputLogCtrl.AppendLog(log, failedLogColor);
            }    
        
            return ret;
        }

        private bool RegRead(byte[] _regAddr)
        {
            bool ret = true;
            string log = "I2C Read >>";
            if (myDongle.IsOpen && regMap != null)
            {
                byte[] tempRegBytes;
                Register tempReg;
                for (int ix_reg = 0; ix_reg < _regAddr.Length; ix_reg++)
                {
                    tempReg = regMap[_regAddr[ix_reg]];
                    tempRegBytes = new byte[tempReg.ByteCount];
                    if (myDongle.readRegBurst(tempReg.RegAddress, tempRegBytes, tempRegBytes.Length))
                    {
                        log += "\r\n\tOK\t" + "Address: 0x" + _regAddr[ix_reg].ToString("X2") + "\tData(Hex):";
                        for (int ix = 0; ix < tempRegBytes.Length; ix++)
                        {
                            tempReg.ByteValue[ix] = tempRegBytes[ix];
                            log += " " + tempRegBytes[ix].ToString("X2");
                        }
                    }
                    else
                    {
                        // if failed during reading, output succeeded log first and reset log.
                        this.outputLogCtrl.AppendLog(log);
                        log = "\tFailed\t" + "Address: 0x" + _regAddr[ix_reg].ToString("X2");
                        ret = false;
                        break;
                    }
                }
                //ret = true;
            }
            else
            {
                ret = false;
                log += "\r\n\tFailed\t" + "Address: 0x" + _regAddr[0].ToString("X2");
            }

            if (ret)
                this.outputLogCtrl.AppendLog(log);
            else
                this.outputLogCtrl.AppendLog(log, failedLogColor);

            return ret;
        }

        private bool RegRead(Register _reg)
        {
            bool ret = false;
            string log = "I2C Read >> \r\n";

            if (myDongle.IsOpen)
            {
                byte[] tempRegBytes;
                tempRegBytes = new byte[_reg.ByteCount];
                if(myDongle.readRegBurst(_reg.RegAddress, tempRegBytes, tempRegBytes.Length))
                {
                    log += "\tOK\t" + "Address: 0x" + _reg.RegAddress.ToString("X2") + "\tData(Hex):";
                    for (int ix = 0; ix < tempRegBytes.Length; ix++)
                    {
                        _reg.ByteValue[ix] = tempRegBytes[ix];
                        log += " " + tempRegBytes[ix].ToString("X2");
                    }

                    ret = true;
                }                
            }

            if (ret)
            {
                this.outputLogCtrl.AppendLog(log);
            }
            else
            {
                log += "\tFailed\t" + "Address: 0x" + _reg.RegAddress.ToString("X2");
                this.outputLogCtrl.AppendLog(log, failedLogColor);
            }

            return ret;
        }

        private bool RegRead(Register[] _reg)
        {
            bool ret = true;
            string log = "I2C Read >>";
            if (myDongle.IsOpen)
            {
                byte[] tempRegBytes;
                for (int ix_reg = 0; ix_reg < _reg.Length; ix_reg++)
                {
                    tempRegBytes = new byte[_reg[ix_reg].ByteCount];
                    if (myDongle.readRegBurst(_reg[ix_reg].RegAddress, tempRegBytes, tempRegBytes.Length))
                    {
                        log += "\r\n\tOK\t" + "Address: 0x" + _reg[ix_reg].RegAddress.ToString("X2") + "\tData(Hex):";
                        for (int ix = 0; ix < tempRegBytes.Length; ix++)
                        {
                            _reg[ix_reg].ByteValue[ix] = tempRegBytes[ix];
                            log += " " + tempRegBytes[ix].ToString("X2");
                        }
                    }
                    else
                    {
                        // if failed during reading, output succeeded log first and reset log.
                        this.outputLogCtrl.AppendLog(log);
                        log = "\tFailed\t" + "Address: 0x" + _reg[ix_reg].RegAddress.ToString("X2");
                        ret = false;
                        break;
                    }
                }
                //ret = true;
            }
            else
            {
                ret = false;
                log += "\r\n\tFailed\t" + "Address: 0x" + _reg[0].RegAddress.ToString("X2");
            }

            if (ret)
                this.outputLogCtrl.AppendLog(log);
            else
                this.outputLogCtrl.AppendLog(log, failedLogColor);

            return ret;
        }

        private bool RegWrite(byte _regAddr)
        {
            bool ret = false;
            string log = "I2C Write >> \r\n";
            if (myDongle.IsOpen && regMap != null)
            {
                Register tempReg = regMap[_regAddr];
                if (myDongle.writeRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount))
                {
                    log += "\tOK\t" + "Address: 0x" + _regAddr.ToString("X2") + "\tData(Hex):";
                    for (int ix = 0; ix < tempReg.ByteCount; ix++)
                    {
                        log += " " + tempReg.ByteValue[ix].ToString("X2");
                    }

                    ret = true;
                }
            }

            if (ret)
            {
                this.outputLogCtrl.AppendLog(log);
            }
            else
            {
                log += "\tFailed\t" + "Address: 0x" + _regAddr.ToString("X2");
                this.outputLogCtrl.AppendLog(log, failedLogColor);
            }
            return ret;
        }

        private bool RegWrite(byte[] _regAddr)
        {
            bool ret = true;
            string log = "I2C Write >>";
            if (myDongle.IsOpen && regMap != null)
            {
                Register tempReg;
                for (int ix = 0; ix < _regAddr.Length; ix++)
                {
                    tempReg = regMap[_regAddr[ix]];
                    if (myDongle.writeRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount))
                    {
                        log += "\r\n\tOK\t" + "Address: 0x" + tempReg.RegAddress.ToString("X2") + "\tData(Hex):";
                        for (int ix_byte = 0; ix_byte < tempReg.ByteCount; ix_byte++)
                        {
                            log += " " + tempReg.ByteValue[ix_byte].ToString("X2");
                        }
                    }
                    else
                    {
                        // if failed during writting, output succeeded log first and reset log.
                        this.outputLogCtrl.AppendLog(log);
                        log = "\tFailed\t" + "Address: 0x" + tempReg.RegAddress.ToString("X2");
                        ret = false;
                        break;
                    }
                }
                //ret = true;
            }
            else
            {
                ret = false;
                log += "\r\n\tFailed\t" + "Address: 0x" + _regAddr[0].ToString("X2");
            }

            if (ret)
                this.outputLogCtrl.AppendLog(log);
            else
                this.outputLogCtrl.AppendLog(log, failedLogColor);
            
            return ret;
        }

        private bool RegWrite(Register _reg)
        {
            bool ret = false;
            string log = "I2C Write >> \r\n";
            if (myDongle.IsOpen)
            {
                if (myDongle.writeRegBurst(_reg.RegAddress, _reg.ByteValue, _reg.ByteCount))
                {
                    log += "\tOK\t" + "Address: 0x" + _reg.RegAddress.ToString("X2") + "\tData(Hex):";
                    for (int ix = 0; ix < _reg.ByteCount; ix++)
                    {
                        log += " " + _reg.ByteValue[ix].ToString("X2");
                    }
                    ret = true;
                }
            }

            if (ret)
            {
                this.outputLogCtrl.AppendLog(log);
            }
            else
            {
                log += "\tFailed\t" + "Address: 0x" + _reg.RegAddress.ToString("X2");
                this.outputLogCtrl.AppendLog(log, failedLogColor);
            }

            return ret;
        }

        private bool RegWrite(Register[] _reg)
        {
            bool ret = true;
            string log = "I2C Write >>";
            if (myDongle.IsOpen)
            {
                for (int ix = 0; ix < _reg.Length; ix++)
                {
                    if (myDongle.writeRegBurst(_reg[ix].RegAddress, _reg[ix].ByteValue, _reg[ix].ByteCount))
                    {
                        log += "\r\n\tOK\t" + "Address: 0x" + _reg[ix].RegAddress.ToString("X2") + "\tData(Hex):";
                        for (int ix_byte = 0; ix_byte < _reg[ix].ByteCount; ix_byte++)
                        {
                            log += " " + _reg[ix].ByteValue[ix_byte].ToString("X2");
                        }
                    }
                    else
                    {
                        // if failed during writting, output succeeded log first and reset log.
                        this.outputLogCtrl.AppendLog(log);
                        log = "\tFailed\t" + "Address: 0x" + _reg[ix].RegAddress.ToString("X2");
                        ret = false;
                        break;
                    }
                }
               //ret = true;
            }
            else
            {
                ret = false;
                log += "\r\n\tFailed\t" + "Address: 0x" + _reg[0].RegAddress.ToString("X2");
            }

            if (ret)
                this.outputLogCtrl.AppendLog(log);
            else
                this.outputLogCtrl.AppendLog(log, failedLogColor);

            return ret;
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
                foreach (Register _reg in regMap.RegList)
                {
                    RegRead(_reg);
                }
            }
            #region Update GUI
            Register tempReg;
            // Operation Voltage; reg 0x0C
            tempReg = regMap[0x0C];
            uint tempBFValue = tempReg["Operation Voltage[1:0]"].BFValue;
            this.numUP_OpVoltage.Value = tempBFValue == 0 ? 24 : (tempBFValue == 1 ? 18 : (tempBFValue == 2 ? 12 : 8));

            // Mode Config

            // Interface Config
            tempReg = regMap[0x04];
            this.cmb_InterfaceConfig.SelectedIndex = (int)tempReg["AIF_FORMAT[3:0]"].BFValue;

            // Status
            UpdateIndicator((byte)regMap[0x02].RegValue);

            // Sample Rate
            tempReg = regMap[0x00];
            this.cmb_SampleRate.SelectedIndex = (int)tempReg["FS_SEL[2:0]"].BFValue;

            // Master Vol
            tempReg = regMap[0x07];
            this.trb_MasterVolume.Value = (int)tempReg.RegValue;
            #endregion 
        }

        #endregion Funcs

        private void tabP_DoubleClick(object sender, EventArgs e)
        {
            blockDiagramMode = !blockDiagramMode;
            this.splitContainer1.Panel1Collapsed = blockDiagramMode;
            this.splitContainer2.Panel2Collapsed = blockDiagramMode;
        }

        #region Other Child Controls Evnet
        void btn_WriteReg_RegSetCtrl_Click(object sender, EventArgs e)
        {
            RegWrite(this.regCtrl_AddrList.ToArray());
        }

        void btn_ReadReg_RegSetCtrl_Click(object sender, EventArgs e)
        {
            RegRead(this.regCtrl_AddrList.ToArray());
            UpdateRegSettingSource();
        }

        void btn_WriteAllReg_FreeRegCtrl_Click(object sender, EventArgs e)
        {
            for (int ix = 0; ix < freeRegCtrl.RegAddrList.Count; ix++)
            {
                if(freeRegCtrl.ActivedEnList[ix])
                    RegWrite(freeRegCtrl.RegAddrList[ix]);
            }
            //RegWrite(this.freeRegCtrl.RegAddrList.ToArray());
        }

        void btn_ReadAllReg_FreeRegCtrl_Click(object sender, EventArgs e)
        {
            for (int ix = 0; ix < freeRegCtrl.RegAddrList.Count; ix++)
            {
                if (freeRegCtrl.ActivedEnList[ix])
                    RegRead(freeRegCtrl.RegAddrList[ix]);
            }
            //RegRead(this.freeRegCtrl.RegAddrList.ToArray());
        }

        #endregion Other Child Controls Evnet

        #region GUI control
        BindingList<RegProperty> regCtrlList = new BindingList<RegProperty> { };    // Will be used to refresh regSettingCtrl display
        List<byte> regCtrl_AddrList = new List<byte> { };                           // Will be used to get R/W reglist of regSettingCtrl
        RegSettingCtrl singleRegCtrl = null;
        FreeRegRWCtrl freeRegCtrl = null;
        I2CMemTool memoryTool = null;

        private void UpdateRegSettingSource()
        {
            this.singleRegCtrl.UpdateDataSource(regCtrlList);
        }

        private void UpdateRegSettingSource(byte _regAddr)
        {
            if (regMap == null)
            {
                MessageBox.Show("Please open excel or project first.");
                return;
            }

            regCtrlList.Clear();
            regCtrl_AddrList.Clear();
            RegProperty tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, regMap[_regAddr].RegValue.ToString("X")) { };
            regCtrlList.Add(tempReg);
            regCtrl_AddrList.Add(_regAddr);

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
            regCtrl_AddrList.Clear();
            for (int ix = 0; ix < _regList.Length; ix++)
            {
                tempAddr = _regList[ix];
                RegProperty tempReg = new RegProperty(tempAddr.ToString("X2"), regMap[tempAddr].RegName, regMap[tempAddr].RegValue.ToString("X")) { };
                regCtrlList.Add(tempReg);
                regCtrl_AddrList.Add(_regList[ix]);
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
            regCtrl_AddrList.Clear();
            RegProperty tempReg;
            if(regMap[_regAddr].ByteCount <= 4)
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, regMap[_regAddr].RegValue.ToString("X")) { };
            else
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, "") { };

            regCtrlList.Add(tempReg);
            regCtrl_AddrList.Add(_regAddr);

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

            if (!append)
            {
                regCtrlList.Clear();
                regCtrl_AddrList.Clear();
            }

            RegProperty tempReg;
            if (regMap[_regAddr].ByteCount <= 4)
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, regMap[_regAddr].RegValue.ToString("X")) { };
            else
                tempReg = new RegProperty(_regAddr.ToString("X2"), regMap[_regAddr].RegName, "") { };

            regCtrlList.Add(tempReg);
            regCtrl_AddrList.Add(_regAddr);

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
            // will set in input mux control

            /* 1. 0x61 BF[31: 16] */
            /* 2. 0x61 BF[15: 0] */
            //UpdateRegSettingSource(0x61, new string[] { "CH4_INPUT_MIXER_1[25:0]", "CH4_INPUT_MIXER_0[25:0]" });
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
            // will set in Input Mux control

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

        private void chb_v3Source_CheckedChanged(object sender, EventArgs e)
        {
            /* if(0x0E bit5 == 1) then = 0x0A, else 0x08 */
            if (regMap == null)
                return;
            if (chb_v3Source.Checked)
            {
                regMap[0x0E]["CH3_VOL"].BFValue = 1;
                this.chb_v3Source.Text = "From 0x0A";
            }
            else
            {
                regMap[0x0E]["CH3_VOL"].BFValue = 0;
                this.chb_v3Source.Text = "From 0x08";
            }
            pl_VOL3_Click(null, null);
        }

        private void pl_VOL3_Click(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            /* if(0x0E bit5 == 1) then = 0x0A, else 0x08 */
            if (chb_v3Source.Checked)
                UpdateRegSettingSource(0x0A);
            else
                UpdateRegSettingSource(0x08);
        }

        private void chb_v4Source_CheckedChanged(object sender, EventArgs e)
        {
            /* if(0x0E bit6 == 1) then = 0x0A, else 0x09 */
            if (regMap == null)
                return;

            if (chb_v4Source.Checked)
            {
                regMap[0x0E]["SUB_VOL"].BFValue = 1;
                this.chb_v3Source.Text = "From 0x0A";
            }
            else
            {
                regMap[0x0E]["SUB_VOL"].BFValue = 0;
                this.chb_v3Source.Text = "From 0x09";
            }
            pl_VOL4_Click(null, null);
        }

        private void pl_VOL4_Click(object sender, EventArgs e)
        {
            /* if(0x0E bit6 == 1) then = 0x0A, else 0x09 */
            if (regMap == null)
                return;

            if (chb_v4Source.Checked)                
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
            /* 0x3A-0x3C, 0x40-0x42,0x46[0] */
            //byte[] regList = new byte[] { 0x3A, 0x3B, 0x3C, 0x40, 0x41, 0x42 };
            //UpdateRegSettingSource(regList);
            //UpdateRegSettingSource(0x46, new string[] { "DRC1_EN" }, true);

            List<Register> regList = new List<Register> { };
            if (regMap != null)
            {
                regList.Add(regMap[0x3A]);
                regList.Add(regMap[0x3B]);
                regList.Add(regMap[0x3C]);

                regList.Add(regMap[0x40]);
                regList.Add(regMap[0x41]);
                regList.Add(regMap[0x42]);
            }
            DRCForm myDRCForm = new DRCForm(regList, regMap[0x46]["DRC1_EN"]);
            myDRCForm.ShowDialog();
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
            /* 0x3D-0x3F, 0x43-0x45,0x46[1] */
            List<Register> regList = new List<Register> { };
            if (regMap != null)
            {
                regList.Add(regMap[0x3D]);
                regList.Add(regMap[0x3E]);
                regList.Add(regMap[0x3F]);

                regList.Add(regMap[0x43]);
                regList.Add(regMap[0x44]);
                regList.Add(regMap[0x45]);
            }
            DRCForm myDRCForm = new DRCForm(regList, regMap[0x46]["DRC2_EN"]);
            myDRCForm.ShowDialog();
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

        private void MenuItemTools_I2CAddress_TextChanged(object sender, EventArgs e)
        {
           string i2cString = this.MenuItemTools_I2CAddress.Text;
            byte tempDevAddress;
            bool ifSuccess = byte.TryParse(i2cString.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber, null, out tempDevAddress);

            if (!ifSuccess)
            {
                //this.chipAddress = tempDevAddress;
                MessageBox.Show("Wrong Chip Address");
            }
            else
            {
                this.chipAddress = tempDevAddress;
                if(recordHistoryDongleInit != null)
                    DongleInit(recordHistoryDongleInit.Text, DMDongle.VCPGROUP.I2C, chipAddress, 5);
            }

        }

        private void MenuItemTools_selectDongle_MouseEnter(object sender, EventArgs e)
        {
            this.MenuItemTools_selectDongle.DropDownItems.Clear();

            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                //本机没有串口！
                this.MenuItemTools_selectDongle.DropDownItems.Add("NULL");
                //this.selectDongleToolStripMenuItem.DropDownItems[0].Select();
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    this.MenuItemTools_selectDongle.DropDownItems.Add(str[i]);
                    //this.MenuItemTools_selectDongle.DropDownItems[i]
                    this.MenuItemTools_selectDongle.DropDownItems[i].Click += new EventHandler(DongleItem_Click);
                }

                //this.cbPortName.SelectedIndex = 0;
            }

        }

        ToolStripDropDownItem recordHistoryDongleInit = null;
        public void DongleItem_Click(object sender, EventArgs e)
        {
            recordHistoryDongleInit = (sender as ToolStripDropDownItem);
            (sender as ToolStripDropDownItem).Select();
            //recordHistoryDongleInit.

            DongleInit(recordHistoryDongleInit.Text, DMDongle.VCPGROUP.I2C, chipAddress, 5);
            //if (myDongle.dongleInit((sender as ToolStripDropDownItem).Text, DMDongle.VCPGROUP.I2C, chipAddress, 5))
            //{
            //    statusBar_DeviceConnected.Text = "Dongle Connected";
            //    statusBar_DeviceConnected.BackColor = Color.Green;
            //    //MessageBox.Show("Connected");
            //}
            //else
            //{
            //    statusBar_DeviceConnected.Text = "Dongle Disconnected";
            //    statusBar_DeviceConnected.BackColor = Color.Red;
            //    //MessageBox.Show("Connected Failed");
            //}
        }

        private void DongleInit(string portName, DMDongle.VCPGROUP protocol, byte devAddress, byte pilot)
        {
            if (myDongle.dongleInit(portName, protocol, devAddress, pilot))
            {
                statusBar_DeviceConnected.Text = "Dongle Connected";
                statusBar_DeviceConnected.BackColor = Color.Green;
                //MessageBox.Show("Connected");
            }
            else
            {
                statusBar_DeviceConnected.Text = "Dongle Disconnected";
                statusBar_DeviceConnected.BackColor = Color.Red;
                //MessageBox.Show("Connected Failed");
            } 
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

                RegWrite(tempAddr);
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
                    tempReg["CH1_MOD"].BFValue = 0x01;
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
                    tempReg["CH1_MOD"].BFValue = 0x01;
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
                    RegWrite(regAddrList[ix]);
                    //tempReg = regAddrList[ix];
                    //myDongle.writeRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);
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
            RegWrite(tempReg);
        }

        private void btn_ClearStatus_Click(object sender, EventArgs e)
        {
            /* Reg0x02 write 0x00 */
            if (regMap != null)
            {
                Register tempReg = regMap[0x02];
                tempReg.RegValue = 0x00;
                RegWrite(tempReg);
            }
        }

        private void btn_RefreshStatus_Click(object sender, EventArgs e)
        {
            /* Read Reg0x02 */
            if (RegRead(0x02))
            {
                // Update indicators
                UpdateIndicator((byte)regMap[0x02].RegValue);
            }
            if (RegRead(0x00))
            {
                this.cmb_SampleRate.SelectedIndex = (int)regMap[0x00]["FS_SEL[2:0]"].BFValue;
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
            InputMux inputConfig = new InputMux(regMap);
            inputConfig.FormClosed += new FormClosedEventHandler(inputConfig_FormClosed);
            inputConfig.ShowDialog();
        }

        private void inputConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update register table displaying
            btn_InputMux_Click(sender, e);

            // write to hw
            RegWrite(new byte[]{0x20, 0x21});
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
                uint tempVlaue = 0xFF - (uint)this.trb_MasterVolume.Value;
                regMap[0x07].RegValue = tempVlaue;
                UpdateRegSettingSource(0x07);

                if (tempVlaue == 0xFF)
                {
                    this.txt_MasterVol.Text = string.Format("Muted");
                    this.txt_MasterVol.ForeColor = Color.Red;
                }
                else
                {
                    double tempdBValue = 24 - tempVlaue * 0.5;
                    this.txt_MasterVol.Text = string.Format("{0} dB", tempdBValue.ToString("F1"));
                    this.txt_MasterVol.ForeColor = Color.Black;
                }

                RegWrite(0x07);
            }
        }

        private void txt_MasterVol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MasterVol_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void chb_MuteMasterVolume_CheckedChanged(object sender, EventArgs e)
        {
            /* write 0xFF to 0x07 */
            if (regMap != null)
            {
                if (chb_MuteMasterVolume.Checked)
                {
                    regMap[0x07].RegValue = 0xFF;
                    UpdateRegSettingSource(0x07);

                    RegWrite(0x07);
                }
                else
                {
                    trb_MasterVolume_Scroll(null, null);
                }
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
            RegWrite(0x25);
        }

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

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ReadAllAndUpdateGUI();
            this.Cursor = Cursors.Default;
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

        private void chb_Enable_CheckedChanged(object sender, EventArgs e)
        {
            /* reg 0x05  bit6*/
            if (regMap == null)
                return;

            if (chb_Enable.Checked)
            {
                regMap[0x05]["ALL_CH_PD"].BFValue = 0x1;
                this.chb_Enable.Text = "Powered Down";
                this.chb_Enable.BackColor = Color.IndianRed;
            }
            else
            {
                regMap[0x05]["ALL_CH_PD"].BFValue = 0x0;
                this.chb_Enable.Text = "Powered ON";
                this.chb_Enable.BackColor = Color.GreenYellow;
            }

            UpdateRegSettingSource(0x05, new string[] { "ALL_CH_PD" });
            RegWrite(0x05);
        }

        #endregion Main GUI Tab


    }
}
