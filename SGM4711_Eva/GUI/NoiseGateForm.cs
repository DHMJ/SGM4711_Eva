using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;
using System.IO;

namespace SGM4711_Eva.GUI
{
    public partial class NoiseGateForm : Form
    {
        RegisterMap regMap;
        IRegOperation myRegOp;
        double FS = 48000;
        public NoiseGateForm(RegisterMap _regMap, IRegOperation _myRegOp)
        {
            InitializeComponent();
            regMap = _regMap;
            myRegOp = _myRegOp;

            InitDVG();
        }

        private void InitDVG()
        {
            // Init NG_TH CH0
            cmb_NG_TH_CH0.Items.Clear();
            cmb_NG_TH_CH0.Items.Add("Disabled");
            cmb_NG_TH_CH0.Items.Add("-114 dB");
            cmb_NG_TH_CH0.Items.Add("-108 dB");
            cmb_NG_TH_CH0.Items.Add("-102 dB");
            cmb_NG_TH_CH0.Items.Add("-96 dB");
            cmb_NG_TH_CH0.Items.Add("-90 dB");
            cmb_NG_TH_CH0.Items.Add("-84 dB");
            cmb_NG_TH_CH0.Items.Add("-78 dB");

            // Init NG_TH CH1
            cmb_NG_TH_CH1.Items.Clear();
            cmb_NG_TH_CH1.Items.Add("Disabled");
            cmb_NG_TH_CH1.Items.Add("-114 dB");
            cmb_NG_TH_CH1.Items.Add("-108 dB");
            cmb_NG_TH_CH1.Items.Add("-102 dB");
            cmb_NG_TH_CH1.Items.Add("-96 dB");
            cmb_NG_TH_CH1.Items.Add("-90 dB");
            cmb_NG_TH_CH1.Items.Add("-84 dB");
            cmb_NG_TH_CH1.Items.Add("-78 dB");

            // Init NG_TH SubCH
            cmb_NG_TH_SubCH.Items.Clear();
            cmb_NG_TH_SubCH.Items.Add("Disabled");
            cmb_NG_TH_SubCH.Items.Add("-114 dB");
            cmb_NG_TH_SubCH.Items.Add("-108 dB");
            cmb_NG_TH_SubCH.Items.Add("-102 dB");
            cmb_NG_TH_SubCH.Items.Add("-96 dB");
            cmb_NG_TH_SubCH.Items.Add("-90 dB");
            cmb_NG_TH_SubCH.Items.Add("-84 dB");
            cmb_NG_TH_SubCH.Items.Add("-78 dB");

            // Init Release time combobox
            cmb_NG_RT.Items.Clear();
            double time = 0;
            for (int ix = 0; ix <= 10; ix++)
            {
                //Console.WriteLine(Math.E);
                //Console.WriteLine(Math.Pow(2, -(ix + 5)));
                //Console.WriteLine(Math.Log(Math.E, 1 - Math.Pow(2, -(ix + 5))));
                time = -2.2 * 1000 /(Math.Log(1 - Math.Pow(2, -(ix + 5)), Math.E) * FS);

                if(time >= 1000)
                    cmb_NG_RT.Items.Add(String.Format("{0} s",(time / 1000d).ToString("F2")));
                else
                    cmb_NG_RT.Items.Add(String.Format("{0} ms", time.ToString("F2")));
            }

            // Init Hold time combobox
            cmb_NG_HT.Items.Clear();
            for (int ix = 0; ix <= 10; ix++)
            {
                time = 1000 * Math.Pow(2, (ix + 8)) / FS;                

                if (time >= 1000)
                    cmb_NG_HT.Items.Add(String.Format("{0} s", (time / 1000d).ToString("F2")));
                else
                    cmb_NG_HT.Items.Add(String.Format("{0} ms", time.ToString("F2")));
            }

            // Init Attach time combobox
            cmb_NG_AT.Items.Clear();
            for (int ix = 0; ix <= 10; ix++)
            {
                time = -2.2 * 1000 / (Math.Log(1 - Math.Pow(2, -(ix + 8)), Math.E) * FS);

                if (time >= 1000)
                    cmb_NG_AT.Items.Add(String.Format("{0} s", (time / 1000d).ToString("F2")));
                else
                    cmb_NG_AT.Items.Add(String.Format("{0} ms", time.ToString("F2")));
            }

            // Init Combox Selected Item
            if (regMap == null) return;

            cmb_NG_TH_CH0.SelectedIndexChanged -= cmb_NG_SelectedIndexChanged;
            cmb_NG_TH_CH1.SelectedIndexChanged -= cmb_NG_SelectedIndexChanged;
            cmb_NG_TH_SubCH.SelectedIndexChanged -= cmb_NG_SelectedIndexChanged;
            cmb_NG_RT.SelectedIndexChanged -= cmb_NG_SelectedIndexChanged;
            cmb_NG_HT.SelectedIndexChanged -= cmb_NG_SelectedIndexChanged;
            cmb_NG_AT.SelectedIndexChanged -= cmb_NG_SelectedIndexChanged;

            /* Channel Threshold AttacheTime ReleaseTime HoldTime */
            Register NGCtrl0 = regMap[0x63];
            cmb_NG_TH_CH0.SelectedIndex = (int)NGCtrl0["NG_CH0_NT[2:0]"].BFValue;
            cmb_NG_TH_CH1.SelectedIndex = (int)NGCtrl0["NG_CH1_NT[2:0]"].BFValue;
            cmb_NG_TH_SubCH.SelectedIndex = (int)NGCtrl0["NG_SUB_NT[2:0]"].BFValue;

            Register NGCtrl1 = regMap[0x64];
            cmb_NG_RT.SelectedIndex = (int)NGCtrl1["NG_RT[3:0]"].BFValue;
            cmb_NG_HT.SelectedIndex = (int)NGCtrl1["NG_HT[3:0]"].BFValue;
            cmb_NG_AT.SelectedIndex = (int)NGCtrl1["NG_AT[3:0]"].BFValue;

            cmb_NG_TH_CH0.SelectedIndexChanged += cmb_NG_SelectedIndexChanged;
            cmb_NG_TH_CH1.SelectedIndexChanged += cmb_NG_SelectedIndexChanged;
            cmb_NG_TH_SubCH.SelectedIndexChanged += cmb_NG_SelectedIndexChanged;
            cmb_NG_RT.SelectedIndexChanged += cmb_NG_SelectedIndexChanged;
            cmb_NG_HT.SelectedIndexChanged += cmb_NG_SelectedIndexChanged;
            cmb_NG_AT.SelectedIndexChanged += cmb_NG_SelectedIndexChanged;
        }

        private void cmb_NG_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox currentCmb = (sender as ComboBox);
            
            //Register NGCtrl0 = regMap[0x63];
            //Register NGCtrl1 = regMap[0x64];
            //if(currentCmb == cmb_NG_TH_CH0)
            //    NGCtrl0["NG_CH0_NT[2:0]"].BFValue = (uint)currentCmb.SelectedIndex;
            //else if(currentCmb == cmb_NG_TH_CH1)
            //    NGCtrl0["NG_CH1_NT[2:0]"].BFValue = (uint)currentCmb.SelectedIndex;
            //else if(currentCmb == cmb_NG_TH_SubCH)
            //    NGCtrl0["NG_SUB_NT[2:0]"].BFValue = (uint)currentCmb.SelectedIndex;
            //else if(currentCmb == cmb_NG_RT)
            //    NGCtrl1["NG_RT[3:0]"].BFValue = (uint)currentCmb.SelectedIndex;
            //else if(currentCmb == cmb_NG_HT)
            //    NGCtrl1["NG_HT[3:0]"].BFValue = (uint)currentCmb.SelectedIndex;
            //else if(currentCmb == cmb_NG_AT)
            //    NGCtrl1["NG_AT[3:0]"].BFValue = (uint)currentCmb.SelectedIndex;

            //this.myRegOp.RegWrite(new Register[]{NGCtrl0, NGCtrl1});
            //this.myRegOp.UpdateRegSettingSource();
        }

        private void btn_ImportNG_Click(object sender, EventArgs e)
        {
            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Title = "Import NG setting and update to GUI...";
            importFile.Filter = "MDNG(.mdng)|*.mdng|All File(*.*)|*.*";
            //importFile.RestoreDirectory = true;
            if (importFile.ShowDialog() == DialogResult.OK)
            {
                string filename = importFile.FileName;

                StreamReader sr = new StreamReader(filename);
                int tempData;
                bool retParse = false;
                int lineNum = 1;

                string registerstate = sr.ReadLine();
                while (registerstate != null)
                {
                    if (registerstate.StartsWith("/*") || registerstate.StartsWith("//") || registerstate.Trim() == "")
                    {
                        registerstate = sr.ReadLine(); lineNum++;
                        continue;
                    }
                    try
                    {
                        string[] tempStr = registerstate.TrimStart(' ').TrimEnd(' ').Split(',');  //Trim blank space
                        if (tempStr.Length != 2)
                            throw new Exception(String.Format("Wrong data in line {0}!!", lineNum));

                        switch (tempStr[0])
                        {
                            case "NG_CH0_NT[2:0]":
                                if (retParse = Int32.TryParse(tempStr[1].Trim(), out tempData))
                                {
                                    this.cmb_NG_TH_CH0.SelectedIndex = tempData;
                                }
                                break;

                            case "NG_CH1_NT[2:0]":
                                if (retParse = Int32.TryParse(tempStr[1].Trim(), out tempData))
                                {
                                    this.cmb_NG_TH_CH1.SelectedIndex = tempData;
                                }
                                break;

                            case "NG_SUB_NT[2:0]":
                                if (retParse = Int32.TryParse(tempStr[1].Trim(), out tempData))
                                {
                                    this.cmb_NG_TH_SubCH.SelectedIndex = tempData;
                                }
                                break;
                            case "NG_RT[3:0]":
                                if (retParse = Int32.TryParse(tempStr[1].Trim(), out tempData))
                                {
                                    this.cmb_NG_RT.SelectedIndex = tempData;
                                }
                                break;
                            case "NG_HT[3:0]":
                                if (retParse = Int32.TryParse(tempStr[1].Trim(), out tempData))
                                {
                                    this.cmb_NG_HT.SelectedIndex = tempData;
                                }
                                break;

                            case "NG_AT[3:0]":
                                if (retParse = Int32.TryParse(tempStr[1].Trim(), out tempData))
                                {
                                    this.cmb_NG_AT.SelectedIndex = tempData;
                                }
                                break;

                            default:
                                retParse = false;
                                break;
                        }

                        if (!retParse)
                            throw new Exception(String.Format("Wrong data in line {0}!!", lineNum));
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally { registerstate = sr.ReadLine(); lineNum++; }
                }

                sr.Close();
            }
        }

        private void btn_ExportNG_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportFile = new SaveFileDialog();
            exportFile.Title = "Export all the NG setting to local file...";
            exportFile.Filter = "MDNG(.mdng)|*.mdng|All File(*.*)|*.*";
            //exportFile.RestoreDirectory = true;
            if (exportFile.ShowDialog() == DialogResult.OK)
            {
                string filename = exportFile.FileName;

                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine("/* SGM4711 Noise Gate Settings */");

                sw.WriteLine(String.Format("NG_CH0_NT[2:0], {0}", this.cmb_NG_TH_CH0.SelectedIndex.ToString()));
                sw.WriteLine(String.Format("NG_CH1_NT[2:0], {0}", this.cmb_NG_TH_CH1.SelectedIndex.ToString()));
                sw.WriteLine(String.Format("NG_SUB_NT[2:0], {0}", this.cmb_NG_TH_SubCH.SelectedIndex.ToString()));
                sw.WriteLine(String.Format("NG_RT[3:0], {0}", this.cmb_NG_RT.SelectedIndex.ToString()));
                sw.WriteLine(String.Format("NG_HT[3:0], {0}", this.cmb_NG_HT.SelectedIndex.ToString()));
                sw.WriteLine(String.Format("NG_AT[3:0], {0}", this.cmb_NG_AT.SelectedIndex.ToString()));
                sw.WriteLine();

                sw.Close();
            }

        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            Register NGCtrl0 = regMap[0x63];
            Register NGCtrl1 = regMap[0x64];

            NGCtrl0["NG_CH0_NT[2:0]"].BFValue = (uint)cmb_NG_TH_CH0.SelectedIndex;
            NGCtrl0["NG_CH1_NT[2:0]"].BFValue = (uint)cmb_NG_TH_CH1.SelectedIndex;
            NGCtrl0["NG_SUB_NT[2:0]"].BFValue = (uint)cmb_NG_TH_SubCH.SelectedIndex;

            NGCtrl1["NG_RT[3:0]"].BFValue = (uint)cmb_NG_RT.SelectedIndex;
            NGCtrl1["NG_HT[3:0]"].BFValue = (uint)cmb_NG_HT.SelectedIndex;
            NGCtrl1["NG_AT[3:0]"].BFValue = (uint)cmb_NG_AT.SelectedIndex;

            this.myRegOp.RegWrite(new Register[] { NGCtrl0, NGCtrl1 });
            this.myRegOp.UpdateRegSettingSource();
        }


    }
}
