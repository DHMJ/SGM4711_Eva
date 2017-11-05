namespace SGM4711_Eva
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_Open_Excel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_Open_proj = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFile_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile_ExitWithoutSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools_I2CAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTools_selectDongle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools_ScriptWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView_BD = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView_RegMap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemI2CMode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemI2CMode_GPIO = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemI2CMode_HW = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.myTips = new System.Windows.Forms.ToolTip(this.components);
            this.numUP_OpVoltage = new System.Windows.Forms.NumericUpDown();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBar_DeviceConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_FWVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_VID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_PID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_BoardType = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabCtrl_MainGUI = new System.Windows.Forms.TabControl();
            this.tabP_systemConfig = new System.Windows.Forms.TabPage();
            this.txt_MasterVol = new System.Windows.Forms.TextBox();
            this.lbl_MasterVol = new System.Windows.Forms.Label();
            this.chb_Enable = new System.Windows.Forms.CheckBox();
            this.btn_backToDefault = new System.Windows.Forms.Button();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.btn_OutputMux_GUI = new System.Windows.Forms.Button();
            this.btn_AudioEngine_GUI = new System.Windows.Forms.Button();
            this.btn_InputMux_GUI = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_OutputMux = new System.Windows.Forms.Button();
            this.chb_MuteMasterVolume = new System.Windows.Forms.CheckBox();
            this.trb_MasterVolume = new System.Windows.Forms.TrackBar();
            this.btn_AudioEngine = new System.Windows.Forms.Button();
            this.btn_InputMux = new System.Windows.Forms.Button();
            this.grb_OpeStatus = new System.Windows.Forms.GroupBox();
            this.cmb_SampleRate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_RefreshStatus = new System.Windows.Forms.Button();
            this.btn_ClearStatus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_InterfaceConfig = new System.Windows.Forms.ComboBox();
            this.cmb_ModeConfig = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_MasterVolume = new System.Windows.Forms.Button();
            this.tabP_AudioEngine = new System.Windows.Forms.TabPage();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.chb_PostHPF_EN = new System.Windows.Forms.CheckBox();
            this.txt_MasterVol_1 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.chb_MuteMasterVolume_1 = new System.Windows.Forms.CheckBox();
            this.trb_MasterVolume_1 = new System.Windows.Forms.TrackBar();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_DRCAuto_LP_1_0 = new System.Windows.Forms.RadioButton();
            this.rbt_DRCAuto_LP_1_1 = new System.Windows.Forms.RadioButton();
            this.pl_LFBSwitch = new System.Windows.Forms.Panel();
            this.rbt_DRCAuto_LP_0_0 = new System.Windows.Forms.RadioButton();
            this.rbt_DRCAuto_LP_0_1 = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chb_PreHPF_EN = new System.Windows.Forms.CheckBox();
            this.chb_v4Source = new System.Windows.Forms.CheckBox();
            this.chb_v3Source = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabCtrl_SingleRegSetting = new System.Windows.Forms.TabControl();
            this.tabP_SingleCtrl = new System.Windows.Forms.TabPage();
            this.tabP_RegRW = new System.Windows.Forms.TabPage();
            this.tabP_IICMemTool = new System.Windows.Forms.TabPage();
            this.tabCtrl_Output = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.line14 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line9 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line13 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line15 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line12 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line10 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line11 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line6 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line7 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line8 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line5 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line3 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line4 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line2 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line1 = new SGM4711_Eva.MDUserCtrls.Line();
            this.indicator_OTW = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_PSG = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_Clip = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_FrameSlip = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_WS = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_BCLK = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_PLLLock = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_MCLK = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.line147 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line146 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line144 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line145 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line142 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line143 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line140 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line141 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line139 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line138 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_NG = new SGM4711_Eva.MDUserCtrls.myButton();
            this.M_OutputPostScale_0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_OutputPostScale_1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_OutputPreScale_0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_OutputPreScale_1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.dot13 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot12 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot11 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot10 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot9 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot8 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot7 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot6 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot5 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot4 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot3 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot2 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.dot1 = new SGM4711_Eva.MDUserCtrls.Dot();
            this.line137 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line136 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line134 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line135 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line133 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH1_Output_Mix2 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line122 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line120 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line111 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line129 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line132 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line131 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line130 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line128 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line123 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line124 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add10 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line125 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line126 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line127 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH4_Output_Mix0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH4_Output_Mix1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line121 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line114 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH2_Output_Mix1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line115 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line116 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add9 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line117 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line118 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line119 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH2_Output_Mix0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH2_Output_Mix2 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line113 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line112 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line110 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line108 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line109 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line107 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line106 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line100 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH1_Output_Mix1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line101 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line102 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add8 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line103 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line104 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line105 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH1_Output_Mix0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.btn_DRC2 = new SGM4711_Eva.MDUserCtrls.myButton();
            this.btn_DRC1 = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line99 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_MasterVOL = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line95 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line98 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_VOL4 = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line97 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_2BQ_Out = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line96 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_VOL3 = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line92 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line94 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line93 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line87 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line76 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line90 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line91 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line89 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line88 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line86 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line83 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line84 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line85 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line82 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line81 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line80 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line79 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line77 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line78 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line26 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line75 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH3_Input_Mix0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line69 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_1BQ_SubOut = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line70 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line71 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add7 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line72 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line73 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line74 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH3_Input_Mix1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH3_Input_Mix2 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line68 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line67 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line66 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line65 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line64 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line49 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line63 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line42 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line43 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line44 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add4 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line45 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line46 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line47 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line48 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_VOL2 = new SGM4711_Eva.MDUserCtrls.myButton();
            this.btn_1BQ_ROut = new SGM4711_Eva.MDUserCtrls.myButton();
            this.linearGain2 = new SGM4711_Eva.MDUserCtrls.LinearGain();
            this.line50 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_6EQ_R = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line51 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line52 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add5 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line53 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line54 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line55 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH2_Input_Mix0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH2_Input_Mix1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line56 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_1BQ_LRMix_R = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line57 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line58 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add6 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line59 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line60 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line61 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line62 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH2_Input_Mix2 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH2_Input_Mix3 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.line41 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line40 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line39 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add3 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line38 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line37 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line36 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line35 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_VOL1 = new SGM4711_Eva.MDUserCtrls.myButton();
            this.btn_1BQ_LOut = new SGM4711_Eva.MDUserCtrls.myButton();
            this.linearGain1 = new SGM4711_Eva.MDUserCtrls.LinearGain();
            this.line32 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line34 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line33 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_6EQ_L = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line27 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line28 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add2 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line29 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line30 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line31 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH1_Input_Mix0 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH1_Input_Mix1 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.btn_1BQ_LRMix_L = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line25 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line21 = new SGM4711_Eva.MDUserCtrls.Line();
            this.add1 = new SGM4711_Eva.MDUserCtrls.Add();
            this.line23 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line24 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line22 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line20 = new SGM4711_Eva.MDUserCtrls.Line();
            this.M_CH1_Input_Mix2 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.M_CH1_Input_Mix3 = new SGM4711_Eva.MDUserCtrls.Multiply();
            this.btn_1BQ_RIn = new SGM4711_Eva.MDUserCtrls.myButton();
            this.btn_1BQ_LIn = new SGM4711_Eva.MDUserCtrls.myButton();
            this.line18 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line19 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line17 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line16 = new SGM4711_Eva.MDUserCtrls.Line();
            this.outputLogCtrl = new SGM4711_Eva.MDUserCtrls.OutputLogCtrl();
            this.menu_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_OpVoltage)).BeginInit();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabCtrl_MainGUI.SuspendLayout();
            this.tabP_systemConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MasterVolume)).BeginInit();
            this.grb_OpeStatus.SuspendLayout();
            this.tabP_AudioEngine.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MasterVolume_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pl_LFBSwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabCtrl_SingleRegSetting.SuspendLayout();
            this.tabCtrl_Output.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.BackColor = System.Drawing.SystemColors.Menu;
            this.menu_main.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.toolsToolStripMenuItem,
            this.MenuItemView,
            this.MenuItemWindow,
            this.MenuItemI2CMode,
            this.MenuItemHelp});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(1124, 24);
            this.menu_main.TabIndex = 5;
            this.menu_main.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile_Open,
            this.MenuItemFile_Save,
            this.MenuItemFile_SaveAs,
            this.MenuItemFile_Close,
            this.toolStripSeparator1,
            this.MenuItemFile_Import,
            this.MenuItemFile_Export,
            this.toolStripSeparator2,
            this.MenuItemFile_Exit,
            this.MenuItemFile_ExitWithoutSave});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(39, 20);
            this.MenuItemFile.Text = "&File";
            this.MenuItemFile.ToolTipText = "File";
            // 
            // MenuItemFile_Open
            // 
            this.MenuItemFile_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile_Open_Excel,
            this.MenuItemFile_Open_proj});
            this.MenuItemFile_Open.Name = "MenuItemFile_Open";
            this.MenuItemFile_Open.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_Open.Text = "&Open";
            this.MenuItemFile_Open.ToolTipText = "Add";
            // 
            // MenuItemFile_Open_Excel
            // 
            this.MenuItemFile_Open_Excel.Name = "MenuItemFile_Open_Excel";
            this.MenuItemFile_Open_Excel.Size = new System.Drawing.Size(133, 22);
            this.MenuItemFile_Open_Excel.Text = "Excel";
            this.MenuItemFile_Open_Excel.Click += new System.EventHandler(this.MenuItemFile_Open_Excel_Click);
            // 
            // MenuItemFile_Open_proj
            // 
            this.MenuItemFile_Open_proj.Name = "MenuItemFile_Open_proj";
            this.MenuItemFile_Open_proj.Size = new System.Drawing.Size(133, 22);
            this.MenuItemFile_Open_proj.Text = "MD Project";
            this.MenuItemFile_Open_proj.Click += new System.EventHandler(this.MenuItemFile_Open_proj_Click);
            // 
            // MenuItemFile_Save
            // 
            this.MenuItemFile_Save.Name = "MenuItemFile_Save";
            this.MenuItemFile_Save.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_Save.Text = "&Save";
            this.MenuItemFile_Save.Click += new System.EventHandler(this.MenuItemFile_Save_Click);
            // 
            // MenuItemFile_SaveAs
            // 
            this.MenuItemFile_SaveAs.Name = "MenuItemFile_SaveAs";
            this.MenuItemFile_SaveAs.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_SaveAs.Text = "S&ave as..";
            this.MenuItemFile_SaveAs.Click += new System.EventHandler(this.MenuItemFile_SaveAs_Click);
            // 
            // MenuItemFile_Close
            // 
            this.MenuItemFile_Close.Name = "MenuItemFile_Close";
            this.MenuItemFile_Close.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_Close.Text = "&Close";
            this.MenuItemFile_Close.ToolTipText = "Close current project";
            this.MenuItemFile_Close.Click += new System.EventHandler(this.MenuItemFile_Close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // MenuItemFile_Import
            // 
            this.MenuItemFile_Import.Name = "MenuItemFile_Import";
            this.MenuItemFile_Import.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_Import.Text = "&Import";
            this.MenuItemFile_Import.ToolTipText = "Import register configurations from *.mdcfg file";
            this.MenuItemFile_Import.Click += new System.EventHandler(this.MenuItemFile_Import_Click);
            // 
            // MenuItemFile_Export
            // 
            this.MenuItemFile_Export.Name = "MenuItemFile_Export";
            this.MenuItemFile_Export.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_Export.Text = "&Export";
            this.MenuItemFile_Export.ToolTipText = "Export register configurations to *.mdcfg file";
            this.MenuItemFile_Export.Click += new System.EventHandler(this.MenuItemFile_Export_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // MenuItemFile_Exit
            // 
            this.MenuItemFile_Exit.Name = "MenuItemFile_Exit";
            this.MenuItemFile_Exit.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_Exit.Text = "E&xit";
            this.MenuItemFile_Exit.ToolTipText = "Exit and save form register settings to project file";
            this.MenuItemFile_Exit.Click += new System.EventHandler(this.MenuItemFile_Exit_Click);
            // 
            // MenuItemFile_ExitWithoutSave
            // 
            this.MenuItemFile_ExitWithoutSave.Name = "MenuItemFile_ExitWithoutSave";
            this.MenuItemFile_ExitWithoutSave.Size = new System.Drawing.Size(177, 22);
            this.MenuItemFile_ExitWithoutSave.Text = "Exit &Without Saving";
            this.MenuItemFile_ExitWithoutSave.Click += new System.EventHandler(this.MenuItemFile_ExitWithoutSave_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTools_I2CAddress,
            this.toolStripSeparator3,
            this.MenuItemTools_selectDongle,
            this.MenuItemTools_ScriptWrite});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // MenuItemTools_I2CAddress
            // 
            this.MenuItemTools_I2CAddress.Name = "MenuItemTools_I2CAddress";
            this.MenuItemTools_I2CAddress.Size = new System.Drawing.Size(100, 23);
            this.MenuItemTools_I2CAddress.Text = "0x1A";
            this.MenuItemTools_I2CAddress.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuItemTools_I2CAddress.ToolTipText = "I2C Device Address";
            this.MenuItemTools_I2CAddress.TextChanged += new System.EventHandler(this.MenuItemTools_I2CAddress_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTools_selectDongle
            // 
            this.MenuItemTools_selectDongle.Name = "MenuItemTools_selectDongle";
            this.MenuItemTools_selectDongle.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTools_selectDongle.Text = "Select Dongle";
            this.MenuItemTools_selectDongle.MouseEnter += new System.EventHandler(this.MenuItemTools_selectDongle_MouseEnter);
            // 
            // MenuItemTools_ScriptWrite
            // 
            this.MenuItemTools_ScriptWrite.Name = "MenuItemTools_ScriptWrite";
            this.MenuItemTools_ScriptWrite.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTools_ScriptWrite.Text = "Script Write";
            // 
            // MenuItemView
            // 
            this.MenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemView_BD,
            this.MenuItemView_RegMap});
            this.MenuItemView.Name = "MenuItemView";
            this.MenuItemView.Size = new System.Drawing.Size(45, 20);
            this.MenuItemView.Text = "&View";
            this.MenuItemView.ToolTipText = "View";
            // 
            // MenuItemView_BD
            // 
            this.MenuItemView_BD.Checked = true;
            this.MenuItemView_BD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemView_BD.Name = "MenuItemView_BD";
            this.MenuItemView_BD.Size = new System.Drawing.Size(155, 22);
            this.MenuItemView_BD.Text = "Block &Diagram";
            this.MenuItemView_BD.ToolTipText = "Block Diagram Mode";
            this.MenuItemView_BD.Click += new System.EventHandler(this.MenuItemView_BD_Click);
            // 
            // MenuItemView_RegMap
            // 
            this.MenuItemView_RegMap.Name = "MenuItemView_RegMap";
            this.MenuItemView_RegMap.Size = new System.Drawing.Size(155, 22);
            this.MenuItemView_RegMap.Text = "Register &Map";
            this.MenuItemView_RegMap.ToolTipText = "Product List";
            this.MenuItemView_RegMap.Click += new System.EventHandler(this.MenuItemView_RegMap_Click);
            // 
            // MenuItemWindow
            // 
            this.MenuItemWindow.Name = "MenuItemWindow";
            this.MenuItemWindow.Size = new System.Drawing.Size(63, 20);
            this.MenuItemWindow.Text = "&Window";
            this.MenuItemWindow.ToolTipText = "Window";
            this.MenuItemWindow.Visible = false;
            // 
            // MenuItemI2CMode
            // 
            this.MenuItemI2CMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemI2CMode_GPIO,
            this.MenuItemI2CMode_HW});
            this.MenuItemI2CMode.Name = "MenuItemI2CMode";
            this.MenuItemI2CMode.Size = new System.Drawing.Size(71, 20);
            this.MenuItemI2CMode.Text = "I2C Mode";
            this.MenuItemI2CMode.Visible = false;
            // 
            // MenuItemI2CMode_GPIO
            // 
            this.MenuItemI2CMode_GPIO.Name = "MenuItemI2CMode_GPIO";
            this.MenuItemI2CMode_GPIO.Size = new System.Drawing.Size(162, 22);
            this.MenuItemI2CMode_GPIO.Text = "GPIO Simulated";
            // 
            // MenuItemI2CMode_HW
            // 
            this.MenuItemI2CMode_HW.Checked = true;
            this.MenuItemI2CMode_HW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemI2CMode_HW.Name = "MenuItemI2CMode_HW";
            this.MenuItemI2CMode_HW.Size = new System.Drawing.Size(162, 22);
            this.MenuItemI2CMode_HW.Text = "I2C Hardware";
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelp_About});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(45, 20);
            this.MenuItemHelp.Text = "&Help";
            this.MenuItemHelp.ToolTipText = "Help";
            // 
            // MenuItemHelp_About
            // 
            this.MenuItemHelp_About.Name = "MenuItemHelp_About";
            this.MenuItemHelp_About.Size = new System.Drawing.Size(105, 22);
            this.MenuItemHelp_About.Text = "&About";
            this.MenuItemHelp_About.ToolTipText = "About";
            // 
            // numUP_OpVoltage
            // 
            this.numUP_OpVoltage.DecimalPlaces = 1;
            this.numUP_OpVoltage.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUP_OpVoltage.Location = new System.Drawing.Point(18, 64);
            this.numUP_OpVoltage.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUP_OpVoltage.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUP_OpVoltage.Name = "numUP_OpVoltage";
            this.numUP_OpVoltage.Size = new System.Drawing.Size(80, 33);
            this.numUP_OpVoltage.TabIndex = 0;
            this.numUP_OpVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.myTips.SetToolTip(this.numUP_OpVoltage, "b00: 24V(default)\r\nb01: 18V\r\nb10: 12V\r\nb11: 8V");
            this.numUP_OpVoltage.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUP_OpVoltage.ValueChanged += new System.EventHandler(this.numUP_OpVoltage_ValueChanged);
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar_DeviceConnected,
            this.statusBar_FWVersion,
            this.statusBar_VID,
            this.statusBar_PID,
            this.statusBar_BoardType});
            this.statusBar.Location = new System.Drawing.Point(0, 734);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1124, 24);
            this.statusBar.TabIndex = 8;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBar_DeviceConnected
            // 
            this.statusBar_DeviceConnected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusBar_DeviceConnected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusBar_DeviceConnected.Name = "statusBar_DeviceConnected";
            this.statusBar_DeviceConnected.Size = new System.Drawing.Size(127, 19);
            this.statusBar_DeviceConnected.Text = "Device Disconnected";
            this.statusBar_DeviceConnected.ToolTipText = "Devices Disconnected or Connected?";
            // 
            // statusBar_FWVersion
            // 
            this.statusBar_FWVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusBar_FWVersion.Name = "statusBar_FWVersion";
            this.statusBar_FWVersion.Size = new System.Drawing.Size(96, 19);
            this.statusBar_FWVersion.Text = "FW Version: 1.0";
            this.statusBar_FWVersion.ToolTipText = "Firmware Version:";
            // 
            // statusBar_VID
            // 
            this.statusBar_VID.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusBar_VID.Name = "statusBar_VID";
            this.statusBar_VID.Size = new System.Drawing.Size(33, 19);
            this.statusBar_VID.Text = "VID:";
            this.statusBar_VID.ToolTipText = "VID";
            this.statusBar_VID.Visible = false;
            // 
            // statusBar_PID
            // 
            this.statusBar_PID.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusBar_PID.Name = "statusBar_PID";
            this.statusBar_PID.Size = new System.Drawing.Size(34, 19);
            this.statusBar_PID.Text = "PID:";
            this.statusBar_PID.ToolTipText = "PID";
            this.statusBar_PID.Visible = false;
            // 
            // statusBar_BoardType
            // 
            this.statusBar_BoardType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusBar_BoardType.Name = "statusBar_BoardType";
            this.statusBar_BoardType.Size = new System.Drawing.Size(131, 19);
            this.statusBar_BoardType.Text = "Board Type: SGM4711";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.tabCtrl_MainGUI);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 710);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 9;
            // 
            // tabCtrl_MainGUI
            // 
            this.tabCtrl_MainGUI.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrl_MainGUI.Controls.Add(this.tabP_systemConfig);
            this.tabCtrl_MainGUI.Controls.Add(this.tabP_AudioEngine);
            this.tabCtrl_MainGUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl_MainGUI.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl_MainGUI.Name = "tabCtrl_MainGUI";
            this.tabCtrl_MainGUI.SelectedIndex = 0;
            this.tabCtrl_MainGUI.Size = new System.Drawing.Size(1124, 460);
            this.tabCtrl_MainGUI.TabIndex = 1;
            // 
            // tabP_systemConfig
            // 
            this.tabP_systemConfig.BackColor = System.Drawing.Color.White;
            this.tabP_systemConfig.Controls.Add(this.txt_MasterVol);
            this.tabP_systemConfig.Controls.Add(this.lbl_MasterVol);
            this.tabP_systemConfig.Controls.Add(this.chb_Enable);
            this.tabP_systemConfig.Controls.Add(this.btn_backToDefault);
            this.tabP_systemConfig.Controls.Add(this.btn_Sync);
            this.tabP_systemConfig.Controls.Add(this.btn_OutputMux_GUI);
            this.tabP_systemConfig.Controls.Add(this.btn_AudioEngine_GUI);
            this.tabP_systemConfig.Controls.Add(this.btn_InputMux_GUI);
            this.tabP_systemConfig.Controls.Add(this.label16);
            this.tabP_systemConfig.Controls.Add(this.label28);
            this.tabP_systemConfig.Controls.Add(this.label25);
            this.tabP_systemConfig.Controls.Add(this.label26);
            this.tabP_systemConfig.Controls.Add(this.label27);
            this.tabP_systemConfig.Controls.Add(this.label22);
            this.tabP_systemConfig.Controls.Add(this.label23);
            this.tabP_systemConfig.Controls.Add(this.label14);
            this.tabP_systemConfig.Controls.Add(this.label18);
            this.tabP_systemConfig.Controls.Add(this.label17);
            this.tabP_systemConfig.Controls.Add(this.label5);
            this.tabP_systemConfig.Controls.Add(this.line14);
            this.tabP_systemConfig.Controls.Add(this.line9);
            this.tabP_systemConfig.Controls.Add(this.line13);
            this.tabP_systemConfig.Controls.Add(this.line15);
            this.tabP_systemConfig.Controls.Add(this.line12);
            this.tabP_systemConfig.Controls.Add(this.line10);
            this.tabP_systemConfig.Controls.Add(this.line11);
            this.tabP_systemConfig.Controls.Add(this.btn_OutputMux);
            this.tabP_systemConfig.Controls.Add(this.chb_MuteMasterVolume);
            this.tabP_systemConfig.Controls.Add(this.trb_MasterVolume);
            this.tabP_systemConfig.Controls.Add(this.line6);
            this.tabP_systemConfig.Controls.Add(this.line7);
            this.tabP_systemConfig.Controls.Add(this.line8);
            this.tabP_systemConfig.Controls.Add(this.line5);
            this.tabP_systemConfig.Controls.Add(this.line3);
            this.tabP_systemConfig.Controls.Add(this.line4);
            this.tabP_systemConfig.Controls.Add(this.btn_AudioEngine);
            this.tabP_systemConfig.Controls.Add(this.btn_InputMux);
            this.tabP_systemConfig.Controls.Add(this.line2);
            this.tabP_systemConfig.Controls.Add(this.line1);
            this.tabP_systemConfig.Controls.Add(this.grb_OpeStatus);
            this.tabP_systemConfig.Controls.Add(this.cmb_InterfaceConfig);
            this.tabP_systemConfig.Controls.Add(this.cmb_ModeConfig);
            this.tabP_systemConfig.Controls.Add(this.label4);
            this.tabP_systemConfig.Controls.Add(this.label3);
            this.tabP_systemConfig.Controls.Add(this.label2);
            this.tabP_systemConfig.Controls.Add(this.label1);
            this.tabP_systemConfig.Controls.Add(this.numUP_OpVoltage);
            this.tabP_systemConfig.Controls.Add(this.label24);
            this.tabP_systemConfig.Controls.Add(this.btn_MasterVolume);
            this.tabP_systemConfig.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.tabP_systemConfig.Location = new System.Drawing.Point(4, 25);
            this.tabP_systemConfig.Name = "tabP_systemConfig";
            this.tabP_systemConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_systemConfig.Size = new System.Drawing.Size(1116, 431);
            this.tabP_systemConfig.TabIndex = 0;
            this.tabP_systemConfig.Text = "System Configuration";
            // 
            // txt_MasterVol
            // 
            this.txt_MasterVol.ForeColor = System.Drawing.Color.Red;
            this.txt_MasterVol.Location = new System.Drawing.Point(555, 304);
            this.txt_MasterVol.Name = "txt_MasterVol";
            this.txt_MasterVol.Size = new System.Drawing.Size(58, 24);
            this.txt_MasterVol.TabIndex = 43;
            this.txt_MasterVol.Text = "Muted";
            this.txt_MasterVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MasterVol.TextChanged += new System.EventHandler(this.txt_MasterVol_TextChanged);
            // 
            // lbl_MasterVol
            // 
            this.lbl_MasterVol.AutoSize = true;
            this.lbl_MasterVol.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_MasterVol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MasterVol.Location = new System.Drawing.Point(615, 308);
            this.lbl_MasterVol.Name = "lbl_MasterVol";
            this.lbl_MasterVol.Size = new System.Drawing.Size(23, 16);
            this.lbl_MasterVol.TabIndex = 42;
            this.lbl_MasterVol.Text = "dB";
            // 
            // chb_Enable
            // 
            this.chb_Enable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_Enable.BackColor = System.Drawing.Color.IndianRed;
            this.chb_Enable.Checked = true;
            this.chb_Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chb_Enable.Location = new System.Drawing.Point(67, 365);
            this.chb_Enable.Name = "chb_Enable";
            this.chb_Enable.Size = new System.Drawing.Size(100, 29);
            this.chb_Enable.TabIndex = 41;
            this.chb_Enable.Text = "Powered Down";
            this.chb_Enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_Enable.UseVisualStyleBackColor = false;
            this.chb_Enable.CheckedChanged += new System.EventHandler(this.chb_Enable_CheckedChanged);
            // 
            // btn_backToDefault
            // 
            this.btn_backToDefault.AutoSize = true;
            this.btn_backToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backToDefault.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_backToDefault.Location = new System.Drawing.Point(345, 365);
            this.btn_backToDefault.Name = "btn_backToDefault";
            this.btn_backToDefault.Size = new System.Drawing.Size(100, 29);
            this.btn_backToDefault.TabIndex = 40;
            this.btn_backToDefault.Text = "Back to Default";
            this.btn_backToDefault.UseVisualStyleBackColor = true;
            this.btn_backToDefault.Click += new System.EventHandler(this.btn_backToDefault_Click);
            // 
            // btn_Sync
            // 
            this.btn_Sync.AutoSize = true;
            this.btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sync.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Sync.Location = new System.Drawing.Point(206, 365);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(100, 29);
            this.btn_Sync.TabIndex = 39;
            this.btn_Sync.Text = "Sync";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_OutputMux_GUI
            // 
            this.btn_OutputMux_GUI.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_OutputMux_GUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OutputMux_GUI.Location = new System.Drawing.Point(753, 263);
            this.btn_OutputMux_GUI.Name = "btn_OutputMux_GUI";
            this.btn_OutputMux_GUI.Size = new System.Drawing.Size(62, 23);
            this.btn_OutputMux_GUI.TabIndex = 38;
            this.btn_OutputMux_GUI.Text = "Config";
            this.btn_OutputMux_GUI.UseVisualStyleBackColor = false;
            this.btn_OutputMux_GUI.Click += new System.EventHandler(this.btn_OutputMux_GUI_Click);
            // 
            // btn_AudioEngine_GUI
            // 
            this.btn_AudioEngine_GUI.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_AudioEngine_GUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AudioEngine_GUI.Location = new System.Drawing.Point(382, 263);
            this.btn_AudioEngine_GUI.Name = "btn_AudioEngine_GUI";
            this.btn_AudioEngine_GUI.Size = new System.Drawing.Size(62, 23);
            this.btn_AudioEngine_GUI.TabIndex = 37;
            this.btn_AudioEngine_GUI.Text = "Config";
            this.btn_AudioEngine_GUI.UseVisualStyleBackColor = false;
            this.btn_AudioEngine_GUI.Click += new System.EventHandler(this.btn_AudioEngine_GUI_Click);
            // 
            // btn_InputMux_GUI
            // 
            this.btn_InputMux_GUI.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_InputMux_GUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InputMux_GUI.Location = new System.Drawing.Point(198, 263);
            this.btn_InputMux_GUI.Name = "btn_InputMux_GUI";
            this.btn_InputMux_GUI.Size = new System.Drawing.Size(62, 23);
            this.btn_InputMux_GUI.TabIndex = 36;
            this.btn_InputMux_GUI.Text = "Config";
            this.btn_InputMux_GUI.UseVisualStyleBackColor = false;
            this.btn_InputMux_GUI.Click += new System.EventHandler(this.btn_InputMux_GUI_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 9F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(292, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 14);
            this.label16.TabIndex = 35;
            this.label16.Text = "SubCH IN";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Cambria", 9F);
            this.label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label28.Location = new System.Drawing.Point(851, 295);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 14);
            this.label28.TabIndex = 34;
            this.label28.Text = "PWM D";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Cambria", 9F);
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(851, 163);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 14);
            this.label25.TabIndex = 33;
            this.label25.Text = "PWM A";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Cambria", 9F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.Location = new System.Drawing.Point(851, 207);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 14);
            this.label26.TabIndex = 32;
            this.label26.Text = "PWM B";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cambria", 9F);
            this.label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label27.Location = new System.Drawing.Point(851, 251);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 14);
            this.label27.TabIndex = 31;
            this.label27.Text = "PWM C";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 9F);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(660, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 14);
            this.label22.TabIndex = 30;
            this.label22.Text = "CHL OUT";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 9F);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(660, 228);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 14);
            this.label23.TabIndex = 29;
            this.label23.Text = "CHR OUT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 9F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(103, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "Source R";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 9F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(292, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 14);
            this.label18.TabIndex = 24;
            this.label18.Text = "CHL IN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 9F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(292, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 14);
            this.label17.TabIndex = 24;
            this.label17.Text = "CHR IN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(103, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Source L";
            // 
            // btn_OutputMux
            // 
            this.btn_OutputMux.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_OutputMux.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OutputMux.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_OutputMux.Location = new System.Drawing.Point(724, 158);
            this.btn_OutputMux.Name = "btn_OutputMux";
            this.btn_OutputMux.Size = new System.Drawing.Size(121, 176);
            this.btn_OutputMux.TabIndex = 20;
            this.btn_OutputMux.Text = "Output Mux\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.btn_OutputMux.UseVisualStyleBackColor = false;
            this.btn_OutputMux.Click += new System.EventHandler(this.btn_OutputMux_Click);
            // 
            // chb_MuteMasterVolume
            // 
            this.chb_MuteMasterVolume.AutoSize = true;
            this.chb_MuteMasterVolume.BackColor = System.Drawing.Color.AliceBlue;
            this.chb_MuteMasterVolume.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chb_MuteMasterVolume.Location = new System.Drawing.Point(611, 263);
            this.chb_MuteMasterVolume.Name = "chb_MuteMasterVolume";
            this.chb_MuteMasterVolume.Size = new System.Drawing.Size(39, 34);
            this.chb_MuteMasterVolume.TabIndex = 19;
            this.chb_MuteMasterVolume.Text = "Mute";
            this.chb_MuteMasterVolume.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chb_MuteMasterVolume.UseVisualStyleBackColor = false;
            this.chb_MuteMasterVolume.CheckedChanged += new System.EventHandler(this.chb_MuteMasterVolume_CheckedChanged);
            // 
            // trb_MasterVolume
            // 
            this.trb_MasterVolume.BackColor = System.Drawing.Color.AliceBlue;
            this.trb_MasterVolume.Location = new System.Drawing.Point(557, 182);
            this.trb_MasterVolume.Maximum = 255;
            this.trb_MasterVolume.Name = "trb_MasterVolume";
            this.trb_MasterVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_MasterVolume.Size = new System.Drawing.Size(45, 126);
            this.trb_MasterVolume.TabIndex = 18;
            this.trb_MasterVolume.TickFrequency = 25;
            this.trb_MasterVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_MasterVolume.Scroll += new System.EventHandler(this.trb_MasterVolume_Scroll);
            // 
            // btn_AudioEngine
            // 
            this.btn_AudioEngine.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_AudioEngine.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AudioEngine.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_AudioEngine.Location = new System.Drawing.Point(354, 158);
            this.btn_AudioEngine.Name = "btn_AudioEngine";
            this.btn_AudioEngine.Size = new System.Drawing.Size(121, 176);
            this.btn_AudioEngine.TabIndex = 10;
            this.btn_AudioEngine.Text = "Audio Process\r\nEngine\r\n\r\n\r\n\r\n\r\n\r\n";
            this.btn_AudioEngine.UseVisualStyleBackColor = false;
            // 
            // btn_InputMux
            // 
            this.btn_InputMux.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_InputMux.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_InputMux.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_InputMux.Location = new System.Drawing.Point(169, 158);
            this.btn_InputMux.Name = "btn_InputMux";
            this.btn_InputMux.Size = new System.Drawing.Size(121, 176);
            this.btn_InputMux.TabIndex = 9;
            this.btn_InputMux.Text = "Input Mux\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.btn_InputMux.UseVisualStyleBackColor = false;
            this.btn_InputMux.Click += new System.EventHandler(this.btn_InputMux_Click);
            // 
            // grb_OpeStatus
            // 
            this.grb_OpeStatus.Controls.Add(this.cmb_SampleRate);
            this.grb_OpeStatus.Controls.Add(this.label15);
            this.grb_OpeStatus.Controls.Add(this.label13);
            this.grb_OpeStatus.Controls.Add(this.label12);
            this.grb_OpeStatus.Controls.Add(this.label11);
            this.grb_OpeStatus.Controls.Add(this.label10);
            this.grb_OpeStatus.Controls.Add(this.label9);
            this.grb_OpeStatus.Controls.Add(this.label8);
            this.grb_OpeStatus.Controls.Add(this.label7);
            this.grb_OpeStatus.Controls.Add(this.indicator_OTW);
            this.grb_OpeStatus.Controls.Add(this.indicator_PSG);
            this.grb_OpeStatus.Controls.Add(this.indicator_Clip);
            this.grb_OpeStatus.Controls.Add(this.indicator_FrameSlip);
            this.grb_OpeStatus.Controls.Add(this.indicator_WS);
            this.grb_OpeStatus.Controls.Add(this.indicator_BCLK);
            this.grb_OpeStatus.Controls.Add(this.indicator_PLLLock);
            this.grb_OpeStatus.Controls.Add(this.indicator_MCLK);
            this.grb_OpeStatus.Controls.Add(this.btn_RefreshStatus);
            this.grb_OpeStatus.Controls.Add(this.btn_ClearStatus);
            this.grb_OpeStatus.Controls.Add(this.label6);
            this.grb_OpeStatus.Font = new System.Drawing.Font("Arial Unicode MS", 10.5F);
            this.grb_OpeStatus.Location = new System.Drawing.Point(501, 6);
            this.grb_OpeStatus.Name = "grb_OpeStatus";
            this.grb_OpeStatus.Size = new System.Drawing.Size(526, 123);
            this.grb_OpeStatus.TabIndex = 7;
            this.grb_OpeStatus.TabStop = false;
            this.grb_OpeStatus.Text = "Operation Status";
            // 
            // cmb_SampleRate
            // 
            this.cmb_SampleRate.Enabled = false;
            this.cmb_SampleRate.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.cmb_SampleRate.FormattingEnabled = true;
            this.cmb_SampleRate.Items.AddRange(new object[] {
            "32k",
            "192k",
            "96k",
            "44.1k/48k",
            "16k",
            "22.05k/24k",
            "8k",
            "11.025k/12k"});
            this.cmb_SampleRate.Location = new System.Drawing.Point(10, 62);
            this.cmb_SampleRate.Name = "cmb_SampleRate";
            this.cmb_SampleRate.Size = new System.Drawing.Size(93, 24);
            this.cmb_SampleRate.TabIndex = 44;
            this.cmb_SampleRate.Text = "11.025k/12k";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(480, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "OTW";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(431, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "PSG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(380, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "Clip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(314, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Frame_Slip";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(280, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "WS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(224, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "BCLK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(163, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "PLL_LOCK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(121, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "MCLK";
            // 
            // btn_RefreshStatus
            // 
            this.btn_RefreshStatus.AutoSize = true;
            this.btn_RefreshStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RefreshStatus.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RefreshStatus.Location = new System.Drawing.Point(433, 21);
            this.btn_RefreshStatus.Name = "btn_RefreshStatus";
            this.btn_RefreshStatus.Size = new System.Drawing.Size(75, 29);
            this.btn_RefreshStatus.TabIndex = 5;
            this.btn_RefreshStatus.Text = "Refresh";
            this.btn_RefreshStatus.UseVisualStyleBackColor = true;
            this.btn_RefreshStatus.Click += new System.EventHandler(this.btn_RefreshStatus_Click);
            // 
            // btn_ClearStatus
            // 
            this.btn_ClearStatus.AutoSize = true;
            this.btn_ClearStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClearStatus.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClearStatus.Location = new System.Drawing.Point(330, 21);
            this.btn_ClearStatus.Name = "btn_ClearStatus";
            this.btn_ClearStatus.Size = new System.Drawing.Size(75, 29);
            this.btn_ClearStatus.TabIndex = 5;
            this.btn_ClearStatus.Text = "Clear";
            this.btn_ClearStatus.UseVisualStyleBackColor = true;
            this.btn_ClearStatus.Click += new System.EventHandler(this.btn_ClearStatus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(27, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sample Rate";
            // 
            // cmb_InterfaceConfig
            // 
            this.cmb_InterfaceConfig.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_InterfaceConfig.FormattingEnabled = true;
            this.cmb_InterfaceConfig.Items.AddRange(new object[] {
            "Right-Justified 16bit",
            "Right-Justified 20bit",
            "Right-Justified 24bit",
            "I2S-Justified 16bit",
            "I2S-Justified 20bit",
            "I2S-Justified 24bit",
            "Left-Justified 16bit",
            "Left-Justified 20bit",
            "Left-Justified 24bit"});
            this.cmb_InterfaceConfig.Location = new System.Drawing.Point(274, 64);
            this.cmb_InterfaceConfig.Name = "cmb_InterfaceConfig";
            this.cmb_InterfaceConfig.Size = new System.Drawing.Size(195, 33);
            this.cmb_InterfaceConfig.TabIndex = 6;
            this.cmb_InterfaceConfig.SelectedIndexChanged += new System.EventHandler(this.cmb_InterfaceConfig_SelectedIndexChanged);
            // 
            // cmb_ModeConfig
            // 
            this.cmb_ModeConfig.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_ModeConfig.FormattingEnabled = true;
            this.cmb_ModeConfig.Items.AddRange(new object[] {
            "2.0 CH",
            "2.1 CH",
            "PBTL"});
            this.cmb_ModeConfig.Location = new System.Drawing.Point(146, 64);
            this.cmb_ModeConfig.Name = "cmb_ModeConfig";
            this.cmb_ModeConfig.Size = new System.Drawing.Size(82, 33);
            this.cmb_ModeConfig.TabIndex = 5;
            this.cmb_ModeConfig.SelectedIndexChanged += new System.EventHandler(this.cmb_ModeConfig_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(274, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interface Config";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(146, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operation Voltage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(104, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 9F);
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(660, 281);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 14);
            this.label24.TabIndex = 28;
            this.label24.Text = "SubCH OUT";
            // 
            // btn_MasterVolume
            // 
            this.btn_MasterVolume.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_MasterVolume.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MasterVolume.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_MasterVolume.Location = new System.Drawing.Point(539, 158);
            this.btn_MasterVolume.Name = "btn_MasterVolume";
            this.btn_MasterVolume.Size = new System.Drawing.Size(121, 176);
            this.btn_MasterVolume.TabIndex = 14;
            this.btn_MasterVolume.Text = "Master Volume\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.btn_MasterVolume.UseVisualStyleBackColor = false;
            // 
            // tabP_AudioEngine
            // 
            this.tabP_AudioEngine.Controls.Add(this.pnl_Main);
            this.tabP_AudioEngine.Location = new System.Drawing.Point(4, 25);
            this.tabP_AudioEngine.Name = "tabP_AudioEngine";
            this.tabP_AudioEngine.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_AudioEngine.Size = new System.Drawing.Size(1116, 431);
            this.tabP_AudioEngine.TabIndex = 1;
            this.tabP_AudioEngine.Text = "Audio Engine";
            this.tabP_AudioEngine.UseVisualStyleBackColor = true;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Main.Controls.Add(this.line147);
            this.pnl_Main.Controls.Add(this.line146);
            this.pnl_Main.Controls.Add(this.line144);
            this.pnl_Main.Controls.Add(this.line145);
            this.pnl_Main.Controls.Add(this.line142);
            this.pnl_Main.Controls.Add(this.line143);
            this.pnl_Main.Controls.Add(this.line140);
            this.pnl_Main.Controls.Add(this.line141);
            this.pnl_Main.Controls.Add(this.line139);
            this.pnl_Main.Controls.Add(this.label33);
            this.pnl_Main.Controls.Add(this.line138);
            this.pnl_Main.Controls.Add(this.label32);
            this.pnl_Main.Controls.Add(this.btn_NG);
            this.pnl_Main.Controls.Add(this.M_OutputPostScale_0);
            this.pnl_Main.Controls.Add(this.M_OutputPostScale_1);
            this.pnl_Main.Controls.Add(this.M_OutputPreScale_0);
            this.pnl_Main.Controls.Add(this.chb_PostHPF_EN);
            this.pnl_Main.Controls.Add(this.M_OutputPreScale_1);
            this.pnl_Main.Controls.Add(this.dot13);
            this.pnl_Main.Controls.Add(this.dot12);
            this.pnl_Main.Controls.Add(this.dot11);
            this.pnl_Main.Controls.Add(this.dot10);
            this.pnl_Main.Controls.Add(this.dot9);
            this.pnl_Main.Controls.Add(this.dot8);
            this.pnl_Main.Controls.Add(this.dot7);
            this.pnl_Main.Controls.Add(this.dot6);
            this.pnl_Main.Controls.Add(this.dot5);
            this.pnl_Main.Controls.Add(this.dot4);
            this.pnl_Main.Controls.Add(this.dot3);
            this.pnl_Main.Controls.Add(this.dot2);
            this.pnl_Main.Controls.Add(this.dot1);
            this.pnl_Main.Controls.Add(this.line137);
            this.pnl_Main.Controls.Add(this.line136);
            this.pnl_Main.Controls.Add(this.line134);
            this.pnl_Main.Controls.Add(this.line135);
            this.pnl_Main.Controls.Add(this.line133);
            this.pnl_Main.Controls.Add(this.M_CH1_Output_Mix2);
            this.pnl_Main.Controls.Add(this.line122);
            this.pnl_Main.Controls.Add(this.line120);
            this.pnl_Main.Controls.Add(this.line111);
            this.pnl_Main.Controls.Add(this.line129);
            this.pnl_Main.Controls.Add(this.line132);
            this.pnl_Main.Controls.Add(this.line131);
            this.pnl_Main.Controls.Add(this.line130);
            this.pnl_Main.Controls.Add(this.line128);
            this.pnl_Main.Controls.Add(this.line123);
            this.pnl_Main.Controls.Add(this.line124);
            this.pnl_Main.Controls.Add(this.add10);
            this.pnl_Main.Controls.Add(this.line125);
            this.pnl_Main.Controls.Add(this.line126);
            this.pnl_Main.Controls.Add(this.line127);
            this.pnl_Main.Controls.Add(this.M_CH4_Output_Mix0);
            this.pnl_Main.Controls.Add(this.M_CH4_Output_Mix1);
            this.pnl_Main.Controls.Add(this.line121);
            this.pnl_Main.Controls.Add(this.line114);
            this.pnl_Main.Controls.Add(this.M_CH2_Output_Mix1);
            this.pnl_Main.Controls.Add(this.line115);
            this.pnl_Main.Controls.Add(this.line116);
            this.pnl_Main.Controls.Add(this.add9);
            this.pnl_Main.Controls.Add(this.line117);
            this.pnl_Main.Controls.Add(this.line118);
            this.pnl_Main.Controls.Add(this.line119);
            this.pnl_Main.Controls.Add(this.M_CH2_Output_Mix0);
            this.pnl_Main.Controls.Add(this.M_CH2_Output_Mix2);
            this.pnl_Main.Controls.Add(this.line113);
            this.pnl_Main.Controls.Add(this.line112);
            this.pnl_Main.Controls.Add(this.line110);
            this.pnl_Main.Controls.Add(this.line108);
            this.pnl_Main.Controls.Add(this.line109);
            this.pnl_Main.Controls.Add(this.line107);
            this.pnl_Main.Controls.Add(this.line106);
            this.pnl_Main.Controls.Add(this.line100);
            this.pnl_Main.Controls.Add(this.M_CH1_Output_Mix1);
            this.pnl_Main.Controls.Add(this.line101);
            this.pnl_Main.Controls.Add(this.line102);
            this.pnl_Main.Controls.Add(this.add8);
            this.pnl_Main.Controls.Add(this.line103);
            this.pnl_Main.Controls.Add(this.line104);
            this.pnl_Main.Controls.Add(this.line105);
            this.pnl_Main.Controls.Add(this.M_CH1_Output_Mix0);
            this.pnl_Main.Controls.Add(this.btn_DRC2);
            this.pnl_Main.Controls.Add(this.btn_DRC1);
            this.pnl_Main.Controls.Add(this.txt_MasterVol_1);
            this.pnl_Main.Controls.Add(this.label31);
            this.pnl_Main.Controls.Add(this.chb_MuteMasterVolume_1);
            this.pnl_Main.Controls.Add(this.trb_MasterVolume_1);
            this.pnl_Main.Controls.Add(this.label30);
            this.pnl_Main.Controls.Add(this.line99);
            this.pnl_Main.Controls.Add(this.btn_MasterVOL);
            this.pnl_Main.Controls.Add(this.line95);
            this.pnl_Main.Controls.Add(this.line98);
            this.pnl_Main.Controls.Add(this.btn_VOL4);
            this.pnl_Main.Controls.Add(this.line97);
            this.pnl_Main.Controls.Add(this.btn_2BQ_Out);
            this.pnl_Main.Controls.Add(this.line96);
            this.pnl_Main.Controls.Add(this.btn_VOL3);
            this.pnl_Main.Controls.Add(this.line92);
            this.pnl_Main.Controls.Add(this.line94);
            this.pnl_Main.Controls.Add(this.line93);
            this.pnl_Main.Controls.Add(this.line87);
            this.pnl_Main.Controls.Add(this.line76);
            this.pnl_Main.Controls.Add(this.line90);
            this.pnl_Main.Controls.Add(this.line91);
            this.pnl_Main.Controls.Add(this.line89);
            this.pnl_Main.Controls.Add(this.line88);
            this.pnl_Main.Controls.Add(this.line86);
            this.pnl_Main.Controls.Add(this.line83);
            this.pnl_Main.Controls.Add(this.line84);
            this.pnl_Main.Controls.Add(this.line85);
            this.pnl_Main.Controls.Add(this.label29);
            this.pnl_Main.Controls.Add(this.line82);
            this.pnl_Main.Controls.Add(this.label21);
            this.pnl_Main.Controls.Add(this.line81);
            this.pnl_Main.Controls.Add(this.line80);
            this.pnl_Main.Controls.Add(this.line79);
            this.pnl_Main.Controls.Add(this.line77);
            this.pnl_Main.Controls.Add(this.line78);
            this.pnl_Main.Controls.Add(this.line26);
            this.pnl_Main.Controls.Add(this.line75);
            this.pnl_Main.Controls.Add(this.M_CH3_Input_Mix0);
            this.pnl_Main.Controls.Add(this.line69);
            this.pnl_Main.Controls.Add(this.btn_1BQ_SubOut);
            this.pnl_Main.Controls.Add(this.line70);
            this.pnl_Main.Controls.Add(this.line71);
            this.pnl_Main.Controls.Add(this.add7);
            this.pnl_Main.Controls.Add(this.line72);
            this.pnl_Main.Controls.Add(this.line73);
            this.pnl_Main.Controls.Add(this.line74);
            this.pnl_Main.Controls.Add(this.M_CH3_Input_Mix1);
            this.pnl_Main.Controls.Add(this.M_CH3_Input_Mix2);
            this.pnl_Main.Controls.Add(this.line68);
            this.pnl_Main.Controls.Add(this.line67);
            this.pnl_Main.Controls.Add(this.line66);
            this.pnl_Main.Controls.Add(this.line65);
            this.pnl_Main.Controls.Add(this.line64);
            this.pnl_Main.Controls.Add(this.line49);
            this.pnl_Main.Controls.Add(this.line63);
            this.pnl_Main.Controls.Add(this.line42);
            this.pnl_Main.Controls.Add(this.line43);
            this.pnl_Main.Controls.Add(this.line44);
            this.pnl_Main.Controls.Add(this.add4);
            this.pnl_Main.Controls.Add(this.line45);
            this.pnl_Main.Controls.Add(this.line46);
            this.pnl_Main.Controls.Add(this.line47);
            this.pnl_Main.Controls.Add(this.line48);
            this.pnl_Main.Controls.Add(this.btn_VOL2);
            this.pnl_Main.Controls.Add(this.btn_1BQ_ROut);
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Controls.Add(this.linearGain2);
            this.pnl_Main.Controls.Add(this.line50);
            this.pnl_Main.Controls.Add(this.btn_6EQ_R);
            this.pnl_Main.Controls.Add(this.line51);
            this.pnl_Main.Controls.Add(this.line52);
            this.pnl_Main.Controls.Add(this.add5);
            this.pnl_Main.Controls.Add(this.line53);
            this.pnl_Main.Controls.Add(this.line54);
            this.pnl_Main.Controls.Add(this.line55);
            this.pnl_Main.Controls.Add(this.M_CH2_Input_Mix0);
            this.pnl_Main.Controls.Add(this.M_CH2_Input_Mix1);
            this.pnl_Main.Controls.Add(this.line56);
            this.pnl_Main.Controls.Add(this.btn_1BQ_LRMix_R);
            this.pnl_Main.Controls.Add(this.line57);
            this.pnl_Main.Controls.Add(this.line58);
            this.pnl_Main.Controls.Add(this.add6);
            this.pnl_Main.Controls.Add(this.line59);
            this.pnl_Main.Controls.Add(this.line60);
            this.pnl_Main.Controls.Add(this.line61);
            this.pnl_Main.Controls.Add(this.line62);
            this.pnl_Main.Controls.Add(this.M_CH2_Input_Mix2);
            this.pnl_Main.Controls.Add(this.M_CH2_Input_Mix3);
            this.pnl_Main.Controls.Add(this.line41);
            this.pnl_Main.Controls.Add(this.line40);
            this.pnl_Main.Controls.Add(this.line39);
            this.pnl_Main.Controls.Add(this.add3);
            this.pnl_Main.Controls.Add(this.line38);
            this.pnl_Main.Controls.Add(this.line37);
            this.pnl_Main.Controls.Add(this.line36);
            this.pnl_Main.Controls.Add(this.line35);
            this.pnl_Main.Controls.Add(this.btn_VOL1);
            this.pnl_Main.Controls.Add(this.btn_1BQ_LOut);
            this.pnl_Main.Controls.Add(this.pl_LFBSwitch);
            this.pnl_Main.Controls.Add(this.linearGain1);
            this.pnl_Main.Controls.Add(this.line32);
            this.pnl_Main.Controls.Add(this.line34);
            this.pnl_Main.Controls.Add(this.line33);
            this.pnl_Main.Controls.Add(this.btn_6EQ_L);
            this.pnl_Main.Controls.Add(this.line27);
            this.pnl_Main.Controls.Add(this.line28);
            this.pnl_Main.Controls.Add(this.add2);
            this.pnl_Main.Controls.Add(this.line29);
            this.pnl_Main.Controls.Add(this.line30);
            this.pnl_Main.Controls.Add(this.line31);
            this.pnl_Main.Controls.Add(this.M_CH1_Input_Mix0);
            this.pnl_Main.Controls.Add(this.M_CH1_Input_Mix1);
            this.pnl_Main.Controls.Add(this.btn_1BQ_LRMix_L);
            this.pnl_Main.Controls.Add(this.line25);
            this.pnl_Main.Controls.Add(this.line21);
            this.pnl_Main.Controls.Add(this.add1);
            this.pnl_Main.Controls.Add(this.line23);
            this.pnl_Main.Controls.Add(this.line24);
            this.pnl_Main.Controls.Add(this.line22);
            this.pnl_Main.Controls.Add(this.line20);
            this.pnl_Main.Controls.Add(this.M_CH1_Input_Mix2);
            this.pnl_Main.Controls.Add(this.M_CH1_Input_Mix3);
            this.pnl_Main.Controls.Add(this.btn_1BQ_RIn);
            this.pnl_Main.Controls.Add(this.btn_1BQ_LIn);
            this.pnl_Main.Controls.Add(this.line18);
            this.pnl_Main.Controls.Add(this.line19);
            this.pnl_Main.Controls.Add(this.label20);
            this.pnl_Main.Controls.Add(this.label19);
            this.pnl_Main.Controls.Add(this.chb_PreHPF_EN);
            this.pnl_Main.Controls.Add(this.line17);
            this.pnl_Main.Controls.Add(this.line16);
            this.pnl_Main.Controls.Add(this.chb_v4Source);
            this.pnl_Main.Controls.Add(this.chb_v3Source);
            this.pnl_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(3, 3);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1110, 425);
            this.pnl_Main.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label33.Location = new System.Drawing.Point(888, 193);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 12);
            this.label33.TabIndex = 251;
            this.label33.Text = "Clipper";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label32.Location = new System.Drawing.Point(888, 75);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 12);
            this.label32.TabIndex = 249;
            this.label32.Text = "Clipper";
            // 
            // chb_PostHPF_EN
            // 
            this.chb_PostHPF_EN.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_PostHPF_EN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chb_PostHPF_EN.Checked = true;
            this.chb_PostHPF_EN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_PostHPF_EN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_PostHPF_EN.Location = new System.Drawing.Point(972, 43);
            this.chb_PostHPF_EN.Name = "chb_PostHPF_EN";
            this.chb_PostHPF_EN.Size = new System.Drawing.Size(33, 361);
            this.chb_PostHPF_EN.TabIndex = 243;
            this.chb_PostHPF_EN.Text = "HPF";
            this.chb_PostHPF_EN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_PostHPF_EN.UseVisualStyleBackColor = false;
            this.chb_PostHPF_EN.CheckedChanged += new System.EventHandler(this.chb_PostHPF_EN_CheckedChanged);
            // 
            // txt_MasterVol_1
            // 
            this.txt_MasterVol_1.ForeColor = System.Drawing.Color.Red;
            this.txt_MasterVol_1.Location = new System.Drawing.Point(608, 317);
            this.txt_MasterVol_1.Name = "txt_MasterVol_1";
            this.txt_MasterVol_1.Size = new System.Drawing.Size(43, 21);
            this.txt_MasterVol_1.TabIndex = 177;
            this.txt_MasterVol_1.Text = "-103.5";
            this.txt_MasterVol_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.LavenderBlush;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(610, 302);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 12);
            this.label31.TabIndex = 176;
            this.label31.Text = "In dB";
            // 
            // chb_MuteMasterVolume_1
            // 
            this.chb_MuteMasterVolume_1.AutoSize = true;
            this.chb_MuteMasterVolume_1.BackColor = System.Drawing.Color.LavenderBlush;
            this.chb_MuteMasterVolume_1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chb_MuteMasterVolume_1.Location = new System.Drawing.Point(614, 354);
            this.chb_MuteMasterVolume_1.Name = "chb_MuteMasterVolume_1";
            this.chb_MuteMasterVolume_1.Size = new System.Drawing.Size(33, 30);
            this.chb_MuteMasterVolume_1.TabIndex = 175;
            this.chb_MuteMasterVolume_1.Text = "Mute";
            this.chb_MuteMasterVolume_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chb_MuteMasterVolume_1.UseVisualStyleBackColor = false;
            this.chb_MuteMasterVolume_1.CheckedChanged += new System.EventHandler(this.chb_MuteMasterVolume_CheckedChanged);
            // 
            // trb_MasterVolume_1
            // 
            this.trb_MasterVolume_1.BackColor = System.Drawing.Color.LavenderBlush;
            this.trb_MasterVolume_1.Location = new System.Drawing.Point(608, 45);
            this.trb_MasterVolume_1.Maximum = 255;
            this.trb_MasterVolume_1.Name = "trb_MasterVolume_1";
            this.trb_MasterVolume_1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_MasterVolume_1.Size = new System.Drawing.Size(45, 251);
            this.trb_MasterVolume_1.TabIndex = 174;
            this.trb_MasterVolume_1.TickFrequency = 25;
            this.trb_MasterVolume_1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_MasterVolume_1.Scroll += new System.EventHandler(this.trb_MasterVolume_Scroll);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label30.Location = new System.Drawing.Point(597, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 12);
            this.label30.TabIndex = 173;
            this.label30.Text = "Master VOL";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(521, 219);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(11, 12);
            this.label29.TabIndex = 150;
            this.label29.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(521, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 148;
            this.label21.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbt_DRCAuto_LP_1_0);
            this.panel1.Controls.Add(this.rbt_DRCAuto_LP_1_1);
            this.panel1.Location = new System.Drawing.Point(483, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 36);
            this.panel1.TabIndex = 113;
            // 
            // rbt_DRCAuto_LP_1_0
            // 
            this.rbt_DRCAuto_LP_1_0.AutoSize = true;
            this.rbt_DRCAuto_LP_1_0.Checked = true;
            this.rbt_DRCAuto_LP_1_0.Location = new System.Drawing.Point(2, 20);
            this.rbt_DRCAuto_LP_1_0.Name = "rbt_DRCAuto_LP_1_0";
            this.rbt_DRCAuto_LP_1_0.Size = new System.Drawing.Size(14, 13);
            this.rbt_DRCAuto_LP_1_0.TabIndex = 1;
            this.rbt_DRCAuto_LP_1_0.TabStop = true;
            this.rbt_DRCAuto_LP_1_0.UseVisualStyleBackColor = true;
            // 
            // rbt_DRCAuto_LP_1_1
            // 
            this.rbt_DRCAuto_LP_1_1.AutoSize = true;
            this.rbt_DRCAuto_LP_1_1.Location = new System.Drawing.Point(2, 2);
            this.rbt_DRCAuto_LP_1_1.Name = "rbt_DRCAuto_LP_1_1";
            this.rbt_DRCAuto_LP_1_1.Size = new System.Drawing.Size(14, 13);
            this.rbt_DRCAuto_LP_1_1.TabIndex = 0;
            this.rbt_DRCAuto_LP_1_1.UseVisualStyleBackColor = true;
            this.rbt_DRCAuto_LP_1_1.CheckedChanged += new System.EventHandler(this.rbt_DRCAuto_LP_CheckedChanged);
            // 
            // pl_LFBSwitch
            // 
            this.pl_LFBSwitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_LFBSwitch.Controls.Add(this.rbt_DRCAuto_LP_0_0);
            this.pl_LFBSwitch.Controls.Add(this.rbt_DRCAuto_LP_0_1);
            this.pl_LFBSwitch.Location = new System.Drawing.Point(483, 79);
            this.pl_LFBSwitch.Name = "pl_LFBSwitch";
            this.pl_LFBSwitch.Size = new System.Drawing.Size(17, 36);
            this.pl_LFBSwitch.TabIndex = 78;
            // 
            // rbt_DRCAuto_LP_0_0
            // 
            this.rbt_DRCAuto_LP_0_0.AutoSize = true;
            this.rbt_DRCAuto_LP_0_0.Checked = true;
            this.rbt_DRCAuto_LP_0_0.Location = new System.Drawing.Point(2, 20);
            this.rbt_DRCAuto_LP_0_0.Name = "rbt_DRCAuto_LP_0_0";
            this.rbt_DRCAuto_LP_0_0.Size = new System.Drawing.Size(14, 13);
            this.rbt_DRCAuto_LP_0_0.TabIndex = 1;
            this.rbt_DRCAuto_LP_0_0.TabStop = true;
            this.rbt_DRCAuto_LP_0_0.UseVisualStyleBackColor = true;
            // 
            // rbt_DRCAuto_LP_0_1
            // 
            this.rbt_DRCAuto_LP_0_1.AutoSize = true;
            this.rbt_DRCAuto_LP_0_1.Location = new System.Drawing.Point(2, 2);
            this.rbt_DRCAuto_LP_0_1.Name = "rbt_DRCAuto_LP_0_1";
            this.rbt_DRCAuto_LP_0_1.Size = new System.Drawing.Size(14, 13);
            this.rbt_DRCAuto_LP_0_1.TabIndex = 0;
            this.rbt_DRCAuto_LP_0_1.UseVisualStyleBackColor = true;
            this.rbt_DRCAuto_LP_0_1.CheckedChanged += new System.EventHandler(this.rbt_DRCAuto_LP_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(18, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 12);
            this.label20.TabIndex = 48;
            this.label20.Text = "R";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(18, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 12);
            this.label19.TabIndex = 47;
            this.label19.Text = "L";
            // 
            // chb_PreHPF_EN
            // 
            this.chb_PreHPF_EN.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_PreHPF_EN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chb_PreHPF_EN.Checked = true;
            this.chb_PreHPF_EN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_PreHPF_EN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_PreHPF_EN.Location = new System.Drawing.Point(37, 35);
            this.chb_PreHPF_EN.Name = "chb_PreHPF_EN";
            this.chb_PreHPF_EN.Size = new System.Drawing.Size(33, 198);
            this.chb_PreHPF_EN.TabIndex = 46;
            this.chb_PreHPF_EN.Text = "HPF";
            this.chb_PreHPF_EN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_PreHPF_EN.UseVisualStyleBackColor = false;
            this.chb_PreHPF_EN.CheckedChanged += new System.EventHandler(this.chb_PreHPF_EN_CheckedChanged);
            // 
            // chb_v4Source
            // 
            this.chb_v4Source.AutoSize = true;
            this.chb_v4Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_v4Source.Font = new System.Drawing.Font("SimSun", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_v4Source.Location = new System.Drawing.Point(526, 356);
            this.chb_v4Source.Name = "chb_v4Source";
            this.chb_v4Source.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_v4Source.Size = new System.Drawing.Size(66, 13);
            this.chb_v4Source.TabIndex = 43;
            this.chb_v4Source.Text = "From 0x09";
            this.chb_v4Source.UseVisualStyleBackColor = true;
            this.chb_v4Source.CheckedChanged += new System.EventHandler(this.chb_v4Source_CheckedChanged);
            // 
            // chb_v3Source
            // 
            this.chb_v3Source.AutoSize = true;
            this.chb_v3Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_v3Source.Font = new System.Drawing.Font("SimSun", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_v3Source.Location = new System.Drawing.Point(530, 263);
            this.chb_v3Source.Name = "chb_v3Source";
            this.chb_v3Source.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_v3Source.Size = new System.Drawing.Size(66, 13);
            this.chb_v3Source.TabIndex = 42;
            this.chb_v3Source.Text = "From 0x08";
            this.chb_v3Source.UseVisualStyleBackColor = true;
            this.chb_v3Source.CheckedChanged += new System.EventHandler(this.chb_v3Source_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.tabCtrl_SingleRegSetting);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabCtrl_Output);
            this.splitContainer2.Size = new System.Drawing.Size(1124, 246);
            this.splitContainer2.SplitterDistance = 521;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabCtrl_SingleRegSetting
            // 
            this.tabCtrl_SingleRegSetting.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrl_SingleRegSetting.Controls.Add(this.tabP_SingleCtrl);
            this.tabCtrl_SingleRegSetting.Controls.Add(this.tabP_RegRW);
            this.tabCtrl_SingleRegSetting.Controls.Add(this.tabP_IICMemTool);
            this.tabCtrl_SingleRegSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl_SingleRegSetting.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl_SingleRegSetting.Name = "tabCtrl_SingleRegSetting";
            this.tabCtrl_SingleRegSetting.SelectedIndex = 0;
            this.tabCtrl_SingleRegSetting.Size = new System.Drawing.Size(521, 246);
            this.tabCtrl_SingleRegSetting.TabIndex = 0;
            // 
            // tabP_SingleCtrl
            // 
            this.tabP_SingleCtrl.BackColor = System.Drawing.Color.White;
            this.tabP_SingleCtrl.Location = new System.Drawing.Point(4, 25);
            this.tabP_SingleCtrl.Name = "tabP_SingleCtrl";
            this.tabP_SingleCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_SingleCtrl.Size = new System.Drawing.Size(513, 217);
            this.tabP_SingleCtrl.TabIndex = 0;
            this.tabP_SingleCtrl.Text = "Single Control";
            // 
            // tabP_RegRW
            // 
            this.tabP_RegRW.BackColor = System.Drawing.Color.White;
            this.tabP_RegRW.Location = new System.Drawing.Point(4, 25);
            this.tabP_RegRW.Name = "tabP_RegRW";
            this.tabP_RegRW.Size = new System.Drawing.Size(513, 217);
            this.tabP_RegRW.TabIndex = 2;
            this.tabP_RegRW.Text = "Register R/W";
            // 
            // tabP_IICMemTool
            // 
            this.tabP_IICMemTool.BackColor = System.Drawing.Color.White;
            this.tabP_IICMemTool.Location = new System.Drawing.Point(4, 25);
            this.tabP_IICMemTool.Name = "tabP_IICMemTool";
            this.tabP_IICMemTool.Size = new System.Drawing.Size(513, 217);
            this.tabP_IICMemTool.TabIndex = 3;
            this.tabP_IICMemTool.Text = "IIC Memory Tool";
            // 
            // tabCtrl_Output
            // 
            this.tabCtrl_Output.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrl_Output.Controls.Add(this.tabPage1);
            this.tabCtrl_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl_Output.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl_Output.Name = "tabCtrl_Output";
            this.tabCtrl_Output.SelectedIndex = 0;
            this.tabCtrl_Output.Size = new System.Drawing.Size(599, 246);
            this.tabCtrl_Output.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.outputLogCtrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
            // 
            // line14
            // 
            this.line14.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line14.BackColor = System.Drawing.Color.Transparent;
            this.line14.Horizontal = true;
            this.line14.LeftOrUpArrow = false;
            this.line14.LineColor = System.Drawing.Color.SteelBlue;
            this.line14.LineWidth = 2;
            this.line14.Location = new System.Drawing.Point(845, 219);
            this.line14.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.line14.Name = "line14";
            this.line14.RightOrBelowArrow = true;
            this.line14.Size = new System.Drawing.Size(66, 11);
            this.line14.TabIndex = 23;
            // 
            // line9
            // 
            this.line9.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line9.BackColor = System.Drawing.Color.Transparent;
            this.line9.Horizontal = true;
            this.line9.LeftOrUpArrow = false;
            this.line9.LineColor = System.Drawing.Color.SteelBlue;
            this.line9.LineWidth = 2;
            this.line9.Location = new System.Drawing.Point(659, 240);
            this.line9.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.line9.Name = "line9";
            this.line9.RightOrBelowArrow = true;
            this.line9.Size = new System.Drawing.Size(66, 11);
            this.line9.TabIndex = 23;
            // 
            // line13
            // 
            this.line13.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line13.BackColor = System.Drawing.Color.Transparent;
            this.line13.Horizontal = true;
            this.line13.LeftOrUpArrow = false;
            this.line13.LineColor = System.Drawing.Color.SteelBlue;
            this.line13.LineWidth = 2;
            this.line13.Location = new System.Drawing.Point(845, 263);
            this.line13.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.line13.Name = "line13";
            this.line13.RightOrBelowArrow = true;
            this.line13.Size = new System.Drawing.Size(66, 11);
            this.line13.TabIndex = 22;
            // 
            // line15
            // 
            this.line15.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line15.BackColor = System.Drawing.Color.Transparent;
            this.line15.Horizontal = true;
            this.line15.LeftOrUpArrow = false;
            this.line15.LineColor = System.Drawing.Color.SteelBlue;
            this.line15.LineWidth = 2;
            this.line15.Location = new System.Drawing.Point(845, 307);
            this.line15.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.line15.Name = "line15";
            this.line15.RightOrBelowArrow = true;
            this.line15.Size = new System.Drawing.Size(66, 11);
            this.line15.TabIndex = 21;
            // 
            // line12
            // 
            this.line12.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line12.BackColor = System.Drawing.Color.Transparent;
            this.line12.Horizontal = true;
            this.line12.LeftOrUpArrow = false;
            this.line12.LineColor = System.Drawing.Color.SteelBlue;
            this.line12.LineWidth = 2;
            this.line12.Location = new System.Drawing.Point(845, 175);
            this.line12.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.line12.Name = "line12";
            this.line12.RightOrBelowArrow = true;
            this.line12.Size = new System.Drawing.Size(66, 11);
            this.line12.TabIndex = 21;
            // 
            // line10
            // 
            this.line10.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line10.BackColor = System.Drawing.Color.Transparent;
            this.line10.Horizontal = true;
            this.line10.LeftOrUpArrow = false;
            this.line10.LineColor = System.Drawing.Color.SteelBlue;
            this.line10.LineWidth = 2;
            this.line10.Location = new System.Drawing.Point(659, 293);
            this.line10.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.line10.Name = "line10";
            this.line10.RightOrBelowArrow = true;
            this.line10.Size = new System.Drawing.Size(66, 11);
            this.line10.TabIndex = 22;
            // 
            // line11
            // 
            this.line11.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line11.BackColor = System.Drawing.Color.Transparent;
            this.line11.Horizontal = true;
            this.line11.LeftOrUpArrow = false;
            this.line11.LineColor = System.Drawing.Color.SteelBlue;
            this.line11.LineWidth = 2;
            this.line11.Location = new System.Drawing.Point(659, 187);
            this.line11.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.line11.Name = "line11";
            this.line11.RightOrBelowArrow = true;
            this.line11.Size = new System.Drawing.Size(66, 11);
            this.line11.TabIndex = 21;
            // 
            // line6
            // 
            this.line6.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line6.BackColor = System.Drawing.Color.Transparent;
            this.line6.Horizontal = true;
            this.line6.LeftOrUpArrow = false;
            this.line6.LineColor = System.Drawing.Color.SteelBlue;
            this.line6.LineWidth = 2;
            this.line6.Location = new System.Drawing.Point(474, 240);
            this.line6.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.line6.Name = "line6";
            this.line6.RightOrBelowArrow = true;
            this.line6.Size = new System.Drawing.Size(66, 11);
            this.line6.TabIndex = 17;
            // 
            // line7
            // 
            this.line7.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line7.BackColor = System.Drawing.Color.Transparent;
            this.line7.Horizontal = true;
            this.line7.LeftOrUpArrow = false;
            this.line7.LineColor = System.Drawing.Color.SteelBlue;
            this.line7.LineWidth = 2;
            this.line7.Location = new System.Drawing.Point(474, 293);
            this.line7.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.line7.Name = "line7";
            this.line7.RightOrBelowArrow = true;
            this.line7.Size = new System.Drawing.Size(66, 11);
            this.line7.TabIndex = 16;
            // 
            // line8
            // 
            this.line8.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line8.BackColor = System.Drawing.Color.Transparent;
            this.line8.Horizontal = true;
            this.line8.LeftOrUpArrow = false;
            this.line8.LineColor = System.Drawing.Color.SteelBlue;
            this.line8.LineWidth = 2;
            this.line8.Location = new System.Drawing.Point(474, 187);
            this.line8.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.line8.Name = "line8";
            this.line8.RightOrBelowArrow = true;
            this.line8.Size = new System.Drawing.Size(66, 11);
            this.line8.TabIndex = 15;
            // 
            // line5
            // 
            this.line5.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line5.BackColor = System.Drawing.Color.Transparent;
            this.line5.Horizontal = true;
            this.line5.LeftOrUpArrow = false;
            this.line5.LineColor = System.Drawing.Color.SteelBlue;
            this.line5.LineWidth = 2;
            this.line5.Location = new System.Drawing.Point(289, 240);
            this.line5.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.line5.Name = "line5";
            this.line5.RightOrBelowArrow = true;
            this.line5.Size = new System.Drawing.Size(66, 11);
            this.line5.TabIndex = 13;
            // 
            // line3
            // 
            this.line3.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line3.BackColor = System.Drawing.Color.Transparent;
            this.line3.Horizontal = true;
            this.line3.LeftOrUpArrow = false;
            this.line3.LineColor = System.Drawing.Color.SteelBlue;
            this.line3.LineWidth = 2;
            this.line3.Location = new System.Drawing.Point(289, 293);
            this.line3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.line3.Name = "line3";
            this.line3.RightOrBelowArrow = true;
            this.line3.Size = new System.Drawing.Size(66, 11);
            this.line3.TabIndex = 12;
            // 
            // line4
            // 
            this.line4.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line4.BackColor = System.Drawing.Color.Transparent;
            this.line4.Horizontal = true;
            this.line4.LeftOrUpArrow = false;
            this.line4.LineColor = System.Drawing.Color.SteelBlue;
            this.line4.LineWidth = 2;
            this.line4.Location = new System.Drawing.Point(289, 187);
            this.line4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.line4.Name = "line4";
            this.line4.RightOrBelowArrow = true;
            this.line4.Size = new System.Drawing.Size(66, 11);
            this.line4.TabIndex = 11;
            // 
            // line2
            // 
            this.line2.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Horizontal = true;
            this.line2.LeftOrUpArrow = false;
            this.line2.LineColor = System.Drawing.Color.SteelBlue;
            this.line2.LineWidth = 2;
            this.line2.Location = new System.Drawing.Point(103, 272);
            this.line2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.line2.Name = "line2";
            this.line2.RightOrBelowArrow = true;
            this.line2.Size = new System.Drawing.Size(66, 11);
            this.line2.TabIndex = 8;
            // 
            // line1
            // 
            this.line1.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Horizontal = true;
            this.line1.LeftOrUpArrow = false;
            this.line1.LineColor = System.Drawing.Color.SteelBlue;
            this.line1.LineWidth = 2;
            this.line1.Location = new System.Drawing.Point(103, 211);
            this.line1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line1.Name = "line1";
            this.line1.RightOrBelowArrow = true;
            this.line1.Size = new System.Drawing.Size(66, 11);
            this.line1.TabIndex = 8;
            // 
            // indicator_OTW
            // 
            this.indicator_OTW.BackColor = System.Drawing.Color.Transparent;
            this.indicator_OTW.IndicatorColorReverse = true;
            this.indicator_OTW.Location = new System.Drawing.Point(481, 62);
            this.indicator_OTW.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_OTW.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_OTW.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_OTW.Name = "indicator_OTW";
            this.indicator_OTW.Size = new System.Drawing.Size(25, 25);
            this.indicator_OTW.TabIndex = 6;
            // 
            // indicator_PSG
            // 
            this.indicator_PSG.BackColor = System.Drawing.Color.Transparent;
            this.indicator_PSG.IndicatorColorReverse = true;
            this.indicator_PSG.Location = new System.Drawing.Point(429, 62);
            this.indicator_PSG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_PSG.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_PSG.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_PSG.Name = "indicator_PSG";
            this.indicator_PSG.Size = new System.Drawing.Size(25, 25);
            this.indicator_PSG.TabIndex = 6;
            // 
            // indicator_Clip
            // 
            this.indicator_Clip.BackColor = System.Drawing.Color.Transparent;
            this.indicator_Clip.IndicatorColorReverse = true;
            this.indicator_Clip.Location = new System.Drawing.Point(379, 62);
            this.indicator_Clip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_Clip.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_Clip.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_Clip.Name = "indicator_Clip";
            this.indicator_Clip.Size = new System.Drawing.Size(25, 25);
            this.indicator_Clip.TabIndex = 6;
            // 
            // indicator_FrameSlip
            // 
            this.indicator_FrameSlip.BackColor = System.Drawing.Color.Transparent;
            this.indicator_FrameSlip.IndicatorColorReverse = true;
            this.indicator_FrameSlip.Location = new System.Drawing.Point(328, 62);
            this.indicator_FrameSlip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_FrameSlip.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_FrameSlip.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_FrameSlip.Name = "indicator_FrameSlip";
            this.indicator_FrameSlip.Size = new System.Drawing.Size(25, 25);
            this.indicator_FrameSlip.TabIndex = 6;
            // 
            // indicator_WS
            // 
            this.indicator_WS.BackColor = System.Drawing.Color.Transparent;
            this.indicator_WS.IndicatorColorReverse = true;
            this.indicator_WS.Location = new System.Drawing.Point(277, 62);
            this.indicator_WS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_WS.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_WS.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_WS.Name = "indicator_WS";
            this.indicator_WS.Size = new System.Drawing.Size(25, 25);
            this.indicator_WS.TabIndex = 6;
            // 
            // indicator_BCLK
            // 
            this.indicator_BCLK.BackColor = System.Drawing.Color.Transparent;
            this.indicator_BCLK.IndicatorColorReverse = true;
            this.indicator_BCLK.Location = new System.Drawing.Point(227, 62);
            this.indicator_BCLK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_BCLK.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_BCLK.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_BCLK.Name = "indicator_BCLK";
            this.indicator_BCLK.Size = new System.Drawing.Size(25, 25);
            this.indicator_BCLK.TabIndex = 6;
            // 
            // indicator_PLLLock
            // 
            this.indicator_PLLLock.BackColor = System.Drawing.Color.Transparent;
            this.indicator_PLLLock.IndicatorColorReverse = true;
            this.indicator_PLLLock.Location = new System.Drawing.Point(175, 62);
            this.indicator_PLLLock.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_PLLLock.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_PLLLock.MinimumSize = new System.Drawing.Size(13, 17);
            this.indicator_PLLLock.Name = "indicator_PLLLock";
            this.indicator_PLLLock.Size = new System.Drawing.Size(25, 25);
            this.indicator_PLLLock.TabIndex = 6;
            // 
            // indicator_MCLK
            // 
            this.indicator_MCLK.BackColor = System.Drawing.Color.Transparent;
            this.indicator_MCLK.IndicatorColorReverse = true;
            this.indicator_MCLK.Location = new System.Drawing.Point(124, 62);
            this.indicator_MCLK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_MCLK.MaximumSize = new System.Drawing.Size(117, 133);
            this.indicator_MCLK.MinimumSize = new System.Drawing.Size(12, 13);
            this.indicator_MCLK.Name = "indicator_MCLK";
            this.indicator_MCLK.Size = new System.Drawing.Size(25, 25);
            this.indicator_MCLK.TabIndex = 6;
            // 
            // line147
            // 
            this.line147.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line147.BackColor = System.Drawing.Color.Transparent;
            this.line147.Horizontal = true;
            this.line147.LeftOrUpArrow = false;
            this.line147.LineColor = System.Drawing.Color.Black;
            this.line147.LineWidth = 1;
            this.line147.Location = new System.Drawing.Point(1059, 348);
            this.line147.Name = "line147";
            this.line147.RightOrBelowArrow = true;
            this.line147.Size = new System.Drawing.Size(19, 10);
            this.line147.TabIndex = 260;
            // 
            // line146
            // 
            this.line146.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line146.BackColor = System.Drawing.Color.Transparent;
            this.line146.Horizontal = true;
            this.line146.LeftOrUpArrow = false;
            this.line146.LineColor = System.Drawing.Color.Black;
            this.line146.LineWidth = 1;
            this.line146.Location = new System.Drawing.Point(1005, 348);
            this.line146.Name = "line146";
            this.line146.RightOrBelowArrow = true;
            this.line146.Size = new System.Drawing.Size(19, 10);
            this.line146.TabIndex = 259;
            // 
            // line144
            // 
            this.line144.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line144.BackColor = System.Drawing.Color.Transparent;
            this.line144.Horizontal = true;
            this.line144.LeftOrUpArrow = false;
            this.line144.LineColor = System.Drawing.Color.Black;
            this.line144.LineWidth = 1;
            this.line144.Location = new System.Drawing.Point(1059, 206);
            this.line144.Name = "line144";
            this.line144.RightOrBelowArrow = true;
            this.line144.Size = new System.Drawing.Size(19, 10);
            this.line144.TabIndex = 258;
            // 
            // line145
            // 
            this.line145.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line145.BackColor = System.Drawing.Color.Transparent;
            this.line145.Horizontal = true;
            this.line145.LeftOrUpArrow = false;
            this.line145.LineColor = System.Drawing.Color.Black;
            this.line145.LineWidth = 1;
            this.line145.Location = new System.Drawing.Point(1059, 88);
            this.line145.Name = "line145";
            this.line145.RightOrBelowArrow = true;
            this.line145.Size = new System.Drawing.Size(19, 10);
            this.line145.TabIndex = 257;
            // 
            // line142
            // 
            this.line142.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line142.BackColor = System.Drawing.Color.Transparent;
            this.line142.Horizontal = true;
            this.line142.LeftOrUpArrow = false;
            this.line142.LineColor = System.Drawing.Color.Black;
            this.line142.LineWidth = 1;
            this.line142.Location = new System.Drawing.Point(1005, 206);
            this.line142.Name = "line142";
            this.line142.RightOrBelowArrow = true;
            this.line142.Size = new System.Drawing.Size(19, 10);
            this.line142.TabIndex = 256;
            // 
            // line143
            // 
            this.line143.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line143.BackColor = System.Drawing.Color.Transparent;
            this.line143.Horizontal = true;
            this.line143.LeftOrUpArrow = false;
            this.line143.LineColor = System.Drawing.Color.Black;
            this.line143.LineWidth = 1;
            this.line143.Location = new System.Drawing.Point(1005, 88);
            this.line143.Name = "line143";
            this.line143.RightOrBelowArrow = true;
            this.line143.Size = new System.Drawing.Size(19, 10);
            this.line143.TabIndex = 255;
            // 
            // line140
            // 
            this.line140.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line140.BackColor = System.Drawing.Color.Transparent;
            this.line140.Horizontal = true;
            this.line140.LeftOrUpArrow = false;
            this.line140.LineColor = System.Drawing.Color.Black;
            this.line140.LineWidth = 1;
            this.line140.Location = new System.Drawing.Point(952, 206);
            this.line140.Name = "line140";
            this.line140.RightOrBelowArrow = true;
            this.line140.Size = new System.Drawing.Size(19, 10);
            this.line140.TabIndex = 254;
            // 
            // line141
            // 
            this.line141.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line141.BackColor = System.Drawing.Color.Transparent;
            this.line141.Horizontal = true;
            this.line141.LeftOrUpArrow = false;
            this.line141.LineColor = System.Drawing.Color.Black;
            this.line141.LineWidth = 1;
            this.line141.Location = new System.Drawing.Point(952, 88);
            this.line141.Name = "line141";
            this.line141.RightOrBelowArrow = true;
            this.line141.Size = new System.Drawing.Size(19, 10);
            this.line141.TabIndex = 253;
            // 
            // line139
            // 
            this.line139.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line139.BackColor = System.Drawing.Color.Transparent;
            this.line139.Horizontal = true;
            this.line139.LeftOrUpArrow = false;
            this.line139.LineColor = System.Drawing.Color.Black;
            this.line139.LineWidth = 1;
            this.line139.Location = new System.Drawing.Point(885, 206);
            this.line139.Name = "line139";
            this.line139.RightOrBelowArrow = false;
            this.line139.Size = new System.Drawing.Size(40, 10);
            this.line139.TabIndex = 252;
            // 
            // line138
            // 
            this.line138.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line138.BackColor = System.Drawing.Color.Transparent;
            this.line138.Horizontal = true;
            this.line138.LeftOrUpArrow = false;
            this.line138.LineColor = System.Drawing.Color.Black;
            this.line138.LineWidth = 1;
            this.line138.Location = new System.Drawing.Point(885, 88);
            this.line138.Name = "line138";
            this.line138.RightOrBelowArrow = false;
            this.line138.Size = new System.Drawing.Size(40, 10);
            this.line138.TabIndex = 250;
            // 
            // btn_NG
            // 
            this.btn_NG.BackColor = System.Drawing.Color.LightYellow;
            this.btn_NG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NG.Location = new System.Drawing.Point(1025, 43);
            this.btn_NG.Name = "btn_NG";
            this.btn_NG.Size = new System.Drawing.Size(33, 361);
            this.btn_NG.TabIndex = 248;
            this.btn_NG.Text = "NG";
            this.btn_NG.UseVisualStyleBackColor = false;
            this.btn_NG.Click += new System.EventHandler(this.btn_NGLOut_Click);
            // 
            // M_OutputPostScale_0
            // 
            this.M_OutputPostScale_0.BackColor = System.Drawing.Color.White;
            this.M_OutputPostScale_0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_OutputPostScale_0.Location = new System.Drawing.Point(924, 197);
            this.M_OutputPostScale_0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_OutputPostScale_0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_OutputPostScale_0.Name = "M_OutputPostScale_0";
            this.M_OutputPostScale_0.Size = new System.Drawing.Size(28, 28);
            this.M_OutputPostScale_0.TabIndex = 246;
            this.M_OutputPostScale_0.Click += new System.EventHandler(this.M_OutputPostScale_Click);
            // 
            // M_OutputPostScale_1
            // 
            this.M_OutputPostScale_1.BackColor = System.Drawing.Color.White;
            this.M_OutputPostScale_1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_OutputPostScale_1.Location = new System.Drawing.Point(924, 79);
            this.M_OutputPostScale_1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_OutputPostScale_1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_OutputPostScale_1.Name = "M_OutputPostScale_1";
            this.M_OutputPostScale_1.Size = new System.Drawing.Size(28, 28);
            this.M_OutputPostScale_1.TabIndex = 245;
            this.M_OutputPostScale_1.Click += new System.EventHandler(this.M_OutputPostScale_Click);
            // 
            // M_OutputPreScale_0
            // 
            this.M_OutputPreScale_0.BackColor = System.Drawing.Color.White;
            this.M_OutputPreScale_0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_OutputPreScale_0.Location = new System.Drawing.Point(857, 197);
            this.M_OutputPreScale_0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_OutputPreScale_0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_OutputPreScale_0.Name = "M_OutputPreScale_0";
            this.M_OutputPreScale_0.Size = new System.Drawing.Size(28, 28);
            this.M_OutputPreScale_0.TabIndex = 244;
            this.M_OutputPreScale_0.Click += new System.EventHandler(this.M_OutputPreScale_Click);
            // 
            // M_OutputPreScale_1
            // 
            this.M_OutputPreScale_1.BackColor = System.Drawing.Color.White;
            this.M_OutputPreScale_1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_OutputPreScale_1.Location = new System.Drawing.Point(857, 79);
            this.M_OutputPreScale_1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_OutputPreScale_1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_OutputPreScale_1.Name = "M_OutputPreScale_1";
            this.M_OutputPreScale_1.Size = new System.Drawing.Size(28, 28);
            this.M_OutputPreScale_1.TabIndex = 242;
            this.M_OutputPreScale_1.Click += new System.EventHandler(this.M_OutputPreScale_Click);
            // 
            // dot13
            // 
            this.dot13.BackColor = System.Drawing.Color.White;
            this.dot13.Location = new System.Drawing.Point(762, 382);
            this.dot13.Name = "dot13";
            this.dot13.Size = new System.Drawing.Size(4, 4);
            this.dot13.TabIndex = 241;
            // 
            // dot12
            // 
            this.dot12.BackColor = System.Drawing.Color.White;
            this.dot12.Location = new System.Drawing.Point(762, 240);
            this.dot12.Name = "dot12";
            this.dot12.Size = new System.Drawing.Size(4, 4);
            this.dot12.TabIndex = 240;
            // 
            // dot11
            // 
            this.dot11.BackColor = System.Drawing.Color.White;
            this.dot11.Location = new System.Drawing.Point(730, 178);
            this.dot11.Name = "dot11";
            this.dot11.Size = new System.Drawing.Size(4, 4);
            this.dot11.TabIndex = 239;
            // 
            // dot10
            // 
            this.dot10.BackColor = System.Drawing.Color.White;
            this.dot10.Location = new System.Drawing.Point(541, 289);
            this.dot10.Name = "dot10";
            this.dot10.Size = new System.Drawing.Size(4, 4);
            this.dot10.TabIndex = 238;
            // 
            // dot9
            // 
            this.dot9.BackColor = System.Drawing.Color.White;
            this.dot9.Location = new System.Drawing.Point(541, 178);
            this.dot9.Name = "dot9";
            this.dot9.Size = new System.Drawing.Size(4, 4);
            this.dot9.TabIndex = 237;
            // 
            // dot8
            // 
            this.dot8.BackColor = System.Drawing.Color.White;
            this.dot8.Location = new System.Drawing.Point(541, 60);
            this.dot8.Name = "dot8";
            this.dot8.Size = new System.Drawing.Size(4, 4);
            this.dot8.TabIndex = 236;
            // 
            // dot7
            // 
            this.dot7.BackColor = System.Drawing.Color.White;
            this.dot7.Location = new System.Drawing.Point(454, 178);
            this.dot7.Name = "dot7";
            this.dot7.Size = new System.Drawing.Size(4, 4);
            this.dot7.TabIndex = 235;
            // 
            // dot6
            // 
            this.dot6.BackColor = System.Drawing.Color.White;
            this.dot6.Location = new System.Drawing.Point(454, 60);
            this.dot6.Name = "dot6";
            this.dot6.Size = new System.Drawing.Size(4, 4);
            this.dot6.TabIndex = 234;
            // 
            // dot5
            // 
            this.dot5.BackColor = System.Drawing.Color.White;
            this.dot5.Location = new System.Drawing.Point(176, 240);
            this.dot5.Name = "dot5";
            this.dot5.Size = new System.Drawing.Size(4, 4);
            this.dot5.TabIndex = 233;
            // 
            // dot4
            // 
            this.dot4.BackColor = System.Drawing.Color.White;
            this.dot4.Location = new System.Drawing.Point(159, 178);
            this.dot4.Name = "dot4";
            this.dot4.Size = new System.Drawing.Size(4, 4);
            this.dot4.TabIndex = 232;
            // 
            // dot3
            // 
            this.dot3.BackColor = System.Drawing.Color.White;
            this.dot3.Location = new System.Drawing.Point(141, 60);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(4, 4);
            this.dot3.TabIndex = 231;
            // 
            // dot2
            // 
            this.dot2.BackColor = System.Drawing.Color.White;
            this.dot2.Location = new System.Drawing.Point(81, 178);
            this.dot2.Name = "dot2";
            this.dot2.Size = new System.Drawing.Size(4, 4);
            this.dot2.TabIndex = 230;
            // 
            // dot1
            // 
            this.dot1.BackColor = System.Drawing.Color.White;
            this.dot1.Location = new System.Drawing.Point(81, 60);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(4, 4);
            this.dot1.TabIndex = 229;
            // 
            // line137
            // 
            this.line137.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line137.BackColor = System.Drawing.Color.Transparent;
            this.line137.Horizontal = true;
            this.line137.LeftOrUpArrow = false;
            this.line137.LineColor = System.Drawing.Color.Black;
            this.line137.LineWidth = 1;
            this.line137.Location = new System.Drawing.Point(765, 237);
            this.line137.Name = "line137";
            this.line137.RightOrBelowArrow = false;
            this.line137.Size = new System.Drawing.Size(18, 10);
            this.line137.TabIndex = 228;
            // 
            // line136
            // 
            this.line136.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line136.BackColor = System.Drawing.Color.Transparent;
            this.line136.Horizontal = true;
            this.line136.LeftOrUpArrow = false;
            this.line136.LineColor = System.Drawing.Color.Black;
            this.line136.LineWidth = 1;
            this.line136.Location = new System.Drawing.Point(765, 317);
            this.line136.Name = "line136";
            this.line136.RightOrBelowArrow = false;
            this.line136.Size = new System.Drawing.Size(18, 10);
            this.line136.TabIndex = 227;
            // 
            // line134
            // 
            this.line134.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line134.BackColor = System.Drawing.Color.Transparent;
            this.line134.Horizontal = false;
            this.line134.LeftOrUpArrow = false;
            this.line134.LineColor = System.Drawing.Color.Black;
            this.line134.LineWidth = 1;
            this.line134.Location = new System.Drawing.Point(759, 125);
            this.line134.Name = "line134";
            this.line134.RightOrBelowArrow = false;
            this.line134.Size = new System.Drawing.Size(10, 55);
            this.line134.TabIndex = 225;
            // 
            // line135
            // 
            this.line135.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line135.BackColor = System.Drawing.Color.Transparent;
            this.line135.Horizontal = true;
            this.line135.LeftOrUpArrow = false;
            this.line135.LineColor = System.Drawing.Color.Black;
            this.line135.LineWidth = 1;
            this.line135.Location = new System.Drawing.Point(764, 119);
            this.line135.Name = "line135";
            this.line135.RightOrBelowArrow = false;
            this.line135.Size = new System.Drawing.Size(18, 10);
            this.line135.TabIndex = 226;
            // 
            // line133
            // 
            this.line133.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line133.BackColor = System.Drawing.Color.Transparent;
            this.line133.Horizontal = false;
            this.line133.LeftOrUpArrow = false;
            this.line133.LineColor = System.Drawing.Color.Black;
            this.line133.LineWidth = 1;
            this.line133.Location = new System.Drawing.Point(759, 181);
            this.line133.Name = "line133";
            this.line133.RightOrBelowArrow = false;
            this.line133.Size = new System.Drawing.Size(10, 30);
            this.line133.TabIndex = 224;
            // 
            // M_CH1_Output_Mix2
            // 
            this.M_CH1_Output_Mix2.BackColor = System.Drawing.Color.White;
            this.M_CH1_Output_Mix2.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Output_Mix2.Location = new System.Drawing.Point(782, 52);
            this.M_CH1_Output_Mix2.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Output_Mix2.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Output_Mix2.Name = "M_CH1_Output_Mix2";
            this.M_CH1_Output_Mix2.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Output_Mix2.TabIndex = 180;
            this.M_CH1_Output_Mix2.Click += new System.EventHandler(this.M_CH1_Output_Mix2_Click);
            // 
            // line122
            // 
            this.line122.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line122.BackColor = System.Drawing.Color.Transparent;
            this.line122.Horizontal = false;
            this.line122.LeftOrUpArrow = false;
            this.line122.LineColor = System.Drawing.Color.Black;
            this.line122.LineWidth = 1;
            this.line122.Location = new System.Drawing.Point(727, 181);
            this.line122.Name = "line122";
            this.line122.RightOrBelowArrow = false;
            this.line122.Size = new System.Drawing.Size(10, 110);
            this.line122.TabIndex = 218;
            // 
            // line120
            // 
            this.line120.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line120.BackColor = System.Drawing.Color.Transparent;
            this.line120.Horizontal = false;
            this.line120.LeftOrUpArrow = false;
            this.line120.LineColor = System.Drawing.Color.Black;
            this.line120.LineWidth = 1;
            this.line120.Location = new System.Drawing.Point(727, 94);
            this.line120.Name = "line120";
            this.line120.RightOrBelowArrow = false;
            this.line120.Size = new System.Drawing.Size(10, 86);
            this.line120.TabIndex = 208;
            // 
            // line111
            // 
            this.line111.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line111.BackColor = System.Drawing.Color.Transparent;
            this.line111.Horizontal = true;
            this.line111.LeftOrUpArrow = false;
            this.line111.LineColor = System.Drawing.Color.Black;
            this.line111.LineWidth = 1;
            this.line111.Location = new System.Drawing.Point(721, 175);
            this.line111.Name = "line111";
            this.line111.RightOrBelowArrow = false;
            this.line111.Size = new System.Drawing.Size(61, 10);
            this.line111.TabIndex = 195;
            // 
            // line129
            // 
            this.line129.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line129.BackColor = System.Drawing.Color.Transparent;
            this.line129.Horizontal = true;
            this.line129.LeftOrUpArrow = false;
            this.line129.LineColor = System.Drawing.Color.Black;
            this.line129.LineWidth = 1;
            this.line129.Location = new System.Drawing.Point(733, 317);
            this.line129.Name = "line129";
            this.line129.RightOrBelowArrow = false;
            this.line129.Size = new System.Drawing.Size(31, 10);
            this.line129.TabIndex = 220;
            // 
            // line132
            // 
            this.line132.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line132.BackColor = System.Drawing.Color.Transparent;
            this.line132.Horizontal = false;
            this.line132.LeftOrUpArrow = false;
            this.line132.LineColor = System.Drawing.Color.Black;
            this.line132.LineWidth = 1;
            this.line132.Location = new System.Drawing.Point(759, 212);
            this.line132.Name = "line132";
            this.line132.RightOrBelowArrow = false;
            this.line132.Size = new System.Drawing.Size(10, 172);
            this.line132.TabIndex = 223;
            // 
            // line131
            // 
            this.line131.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line131.BackColor = System.Drawing.Color.Transparent;
            this.line131.Horizontal = true;
            this.line131.LeftOrUpArrow = false;
            this.line131.LineColor = System.Drawing.Color.Black;
            this.line131.LineWidth = 1;
            this.line131.Location = new System.Drawing.Point(749, 206);
            this.line131.Name = "line131";
            this.line131.RightOrBelowArrow = false;
            this.line131.Size = new System.Drawing.Size(34, 10);
            this.line131.TabIndex = 222;
            // 
            // line130
            // 
            this.line130.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line130.BackColor = System.Drawing.Color.Transparent;
            this.line130.Horizontal = false;
            this.line130.LeftOrUpArrow = false;
            this.line130.LineColor = System.Drawing.Color.Black;
            this.line130.LineWidth = 1;
            this.line130.Location = new System.Drawing.Point(743, 211);
            this.line130.Name = "line130";
            this.line130.RightOrBelowArrow = false;
            this.line130.Size = new System.Drawing.Size(10, 80);
            this.line130.TabIndex = 221;
            // 
            // line128
            // 
            this.line128.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line128.BackColor = System.Drawing.Color.Transparent;
            this.line128.Horizontal = false;
            this.line128.LeftOrUpArrow = false;
            this.line128.LineColor = System.Drawing.Color.Black;
            this.line128.LineWidth = 1;
            this.line128.Location = new System.Drawing.Point(727, 292);
            this.line128.Name = "line128";
            this.line128.RightOrBelowArrow = false;
            this.line128.Size = new System.Drawing.Size(10, 31);
            this.line128.TabIndex = 219;
            // 
            // line123
            // 
            this.line123.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line123.BackColor = System.Drawing.Color.Transparent;
            this.line123.Horizontal = true;
            this.line123.LeftOrUpArrow = false;
            this.line123.LineColor = System.Drawing.Color.Black;
            this.line123.LineWidth = 1;
            this.line123.Location = new System.Drawing.Point(839, 348);
            this.line123.Name = "line123";
            this.line123.RightOrBelowArrow = true;
            this.line123.Size = new System.Drawing.Size(132, 10);
            this.line123.TabIndex = 217;
            // 
            // line124
            // 
            this.line124.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line124.BackColor = System.Drawing.Color.Transparent;
            this.line124.Horizontal = true;
            this.line124.LeftOrUpArrow = false;
            this.line124.LineColor = System.Drawing.Color.Black;
            this.line124.LineWidth = 1;
            this.line124.Location = new System.Drawing.Point(802, 317);
            this.line124.Name = "line124";
            this.line124.RightOrBelowArrow = false;
            this.line124.Size = new System.Drawing.Size(27, 10);
            this.line124.TabIndex = 212;
            // 
            // add10
            // 
            this.add10.BackColor = System.Drawing.Color.Transparent;
            this.add10.DrawColor = System.Drawing.Color.SteelBlue;
            this.add10.Location = new System.Drawing.Point(819, 343);
            this.add10.MaximumSize = new System.Drawing.Size(100, 100);
            this.add10.MinimumSize = new System.Drawing.Size(10, 10);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(20, 20);
            this.add10.TabIndex = 216;
            // 
            // line125
            // 
            this.line125.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line125.BackColor = System.Drawing.Color.Transparent;
            this.line125.Horizontal = false;
            this.line125.LeftOrUpArrow = true;
            this.line125.LineColor = System.Drawing.Color.Black;
            this.line125.LineWidth = 1;
            this.line125.Location = new System.Drawing.Point(824, 364);
            this.line125.Name = "line125";
            this.line125.RightOrBelowArrow = false;
            this.line125.Size = new System.Drawing.Size(10, 20);
            this.line125.TabIndex = 215;
            // 
            // line126
            // 
            this.line126.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line126.BackColor = System.Drawing.Color.Transparent;
            this.line126.Horizontal = false;
            this.line126.LeftOrUpArrow = false;
            this.line126.LineColor = System.Drawing.Color.Black;
            this.line126.LineWidth = 1;
            this.line126.Location = new System.Drawing.Point(824, 322);
            this.line126.Name = "line126";
            this.line126.RightOrBelowArrow = true;
            this.line126.Size = new System.Drawing.Size(10, 20);
            this.line126.TabIndex = 214;
            // 
            // line127
            // 
            this.line127.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line127.BackColor = System.Drawing.Color.Transparent;
            this.line127.Horizontal = true;
            this.line127.LeftOrUpArrow = false;
            this.line127.LineColor = System.Drawing.Color.Black;
            this.line127.LineWidth = 1;
            this.line127.Location = new System.Drawing.Point(802, 379);
            this.line127.Name = "line127";
            this.line127.RightOrBelowArrow = false;
            this.line127.Size = new System.Drawing.Size(28, 10);
            this.line127.TabIndex = 213;
            // 
            // M_CH4_Output_Mix0
            // 
            this.M_CH4_Output_Mix0.BackColor = System.Drawing.Color.White;
            this.M_CH4_Output_Mix0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH4_Output_Mix0.Location = new System.Drawing.Point(782, 374);
            this.M_CH4_Output_Mix0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH4_Output_Mix0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH4_Output_Mix0.Name = "M_CH4_Output_Mix0";
            this.M_CH4_Output_Mix0.Size = new System.Drawing.Size(20, 20);
            this.M_CH4_Output_Mix0.TabIndex = 211;
            this.M_CH4_Output_Mix0.Click += new System.EventHandler(this.M_CH4_Output_Mix0_Click);
            // 
            // M_CH4_Output_Mix1
            // 
            this.M_CH4_Output_Mix1.BackColor = System.Drawing.Color.White;
            this.M_CH4_Output_Mix1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH4_Output_Mix1.Location = new System.Drawing.Point(782, 312);
            this.M_CH4_Output_Mix1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH4_Output_Mix1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH4_Output_Mix1.Name = "M_CH4_Output_Mix1";
            this.M_CH4_Output_Mix1.Size = new System.Drawing.Size(20, 20);
            this.M_CH4_Output_Mix1.TabIndex = 210;
            this.M_CH4_Output_Mix1.Click += new System.EventHandler(this.M_CH4_Output_Mix1_Click);
            // 
            // line121
            // 
            this.line121.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line121.BackColor = System.Drawing.Color.Transparent;
            this.line121.Horizontal = true;
            this.line121.LeftOrUpArrow = false;
            this.line121.LineColor = System.Drawing.Color.Black;
            this.line121.LineWidth = 1;
            this.line121.Location = new System.Drawing.Point(732, 88);
            this.line121.Name = "line121";
            this.line121.RightOrBelowArrow = false;
            this.line121.Size = new System.Drawing.Size(50, 10);
            this.line121.TabIndex = 209;
            // 
            // line114
            // 
            this.line114.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line114.BackColor = System.Drawing.Color.Transparent;
            this.line114.Horizontal = true;
            this.line114.LeftOrUpArrow = false;
            this.line114.LineColor = System.Drawing.Color.Black;
            this.line114.LineWidth = 1;
            this.line114.Location = new System.Drawing.Point(802, 206);
            this.line114.Name = "line114";
            this.line114.RightOrBelowArrow = true;
            this.line114.Size = new System.Drawing.Size(18, 10);
            this.line114.TabIndex = 207;
            // 
            // M_CH2_Output_Mix1
            // 
            this.M_CH2_Output_Mix1.BackColor = System.Drawing.Color.White;
            this.M_CH2_Output_Mix1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Output_Mix1.Location = new System.Drawing.Point(782, 201);
            this.M_CH2_Output_Mix1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Output_Mix1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Output_Mix1.Name = "M_CH2_Output_Mix1";
            this.M_CH2_Output_Mix1.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Output_Mix1.TabIndex = 206;
            this.M_CH2_Output_Mix1.Click += new System.EventHandler(this.M_CH2_Output_Mix1_Click);
            // 
            // line115
            // 
            this.line115.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line115.BackColor = System.Drawing.Color.Transparent;
            this.line115.Horizontal = true;
            this.line115.LeftOrUpArrow = false;
            this.line115.LineColor = System.Drawing.Color.Black;
            this.line115.LineWidth = 1;
            this.line115.Location = new System.Drawing.Point(839, 206);
            this.line115.Name = "line115";
            this.line115.RightOrBelowArrow = true;
            this.line115.Size = new System.Drawing.Size(18, 10);
            this.line115.TabIndex = 205;
            // 
            // line116
            // 
            this.line116.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line116.BackColor = System.Drawing.Color.Transparent;
            this.line116.Horizontal = true;
            this.line116.LeftOrUpArrow = false;
            this.line116.LineColor = System.Drawing.Color.Black;
            this.line116.LineWidth = 1;
            this.line116.Location = new System.Drawing.Point(802, 175);
            this.line116.Name = "line116";
            this.line116.RightOrBelowArrow = false;
            this.line116.Size = new System.Drawing.Size(27, 10);
            this.line116.TabIndex = 200;
            // 
            // add9
            // 
            this.add9.BackColor = System.Drawing.Color.Transparent;
            this.add9.DrawColor = System.Drawing.Color.SteelBlue;
            this.add9.Location = new System.Drawing.Point(819, 201);
            this.add9.MaximumSize = new System.Drawing.Size(100, 100);
            this.add9.MinimumSize = new System.Drawing.Size(10, 10);
            this.add9.Name = "add9";
            this.add9.Size = new System.Drawing.Size(20, 20);
            this.add9.TabIndex = 204;
            // 
            // line117
            // 
            this.line117.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line117.BackColor = System.Drawing.Color.Transparent;
            this.line117.Horizontal = false;
            this.line117.LeftOrUpArrow = true;
            this.line117.LineColor = System.Drawing.Color.Black;
            this.line117.LineWidth = 1;
            this.line117.Location = new System.Drawing.Point(824, 222);
            this.line117.Name = "line117";
            this.line117.RightOrBelowArrow = false;
            this.line117.Size = new System.Drawing.Size(10, 20);
            this.line117.TabIndex = 203;
            // 
            // line118
            // 
            this.line118.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line118.BackColor = System.Drawing.Color.Transparent;
            this.line118.Horizontal = false;
            this.line118.LeftOrUpArrow = false;
            this.line118.LineColor = System.Drawing.Color.Black;
            this.line118.LineWidth = 1;
            this.line118.Location = new System.Drawing.Point(824, 180);
            this.line118.Name = "line118";
            this.line118.RightOrBelowArrow = true;
            this.line118.Size = new System.Drawing.Size(10, 20);
            this.line118.TabIndex = 202;
            // 
            // line119
            // 
            this.line119.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line119.BackColor = System.Drawing.Color.Transparent;
            this.line119.Horizontal = true;
            this.line119.LeftOrUpArrow = false;
            this.line119.LineColor = System.Drawing.Color.Black;
            this.line119.LineWidth = 1;
            this.line119.Location = new System.Drawing.Point(802, 237);
            this.line119.Name = "line119";
            this.line119.RightOrBelowArrow = false;
            this.line119.Size = new System.Drawing.Size(28, 10);
            this.line119.TabIndex = 201;
            // 
            // M_CH2_Output_Mix0
            // 
            this.M_CH2_Output_Mix0.BackColor = System.Drawing.Color.White;
            this.M_CH2_Output_Mix0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Output_Mix0.Location = new System.Drawing.Point(782, 232);
            this.M_CH2_Output_Mix0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Output_Mix0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Output_Mix0.Name = "M_CH2_Output_Mix0";
            this.M_CH2_Output_Mix0.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Output_Mix0.TabIndex = 199;
            this.M_CH2_Output_Mix0.Click += new System.EventHandler(this.M_CH2_Output_Mix0_Click);
            // 
            // M_CH2_Output_Mix2
            // 
            this.M_CH2_Output_Mix2.BackColor = System.Drawing.Color.White;
            this.M_CH2_Output_Mix2.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Output_Mix2.Location = new System.Drawing.Point(782, 170);
            this.M_CH2_Output_Mix2.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Output_Mix2.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Output_Mix2.Name = "M_CH2_Output_Mix2";
            this.M_CH2_Output_Mix2.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Output_Mix2.TabIndex = 198;
            this.M_CH2_Output_Mix2.Click += new System.EventHandler(this.M_CH2_Output_Mix2_Click);
            // 
            // line113
            // 
            this.line113.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line113.BackColor = System.Drawing.Color.Transparent;
            this.line113.Horizontal = true;
            this.line113.LeftOrUpArrow = false;
            this.line113.LineColor = System.Drawing.Color.Black;
            this.line113.LineWidth = 1;
            this.line113.Location = new System.Drawing.Point(721, 286);
            this.line113.Name = "line113";
            this.line113.RightOrBelowArrow = false;
            this.line113.Size = new System.Drawing.Size(28, 10);
            this.line113.TabIndex = 197;
            // 
            // line112
            // 
            this.line112.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line112.BackColor = System.Drawing.Color.Transparent;
            this.line112.Horizontal = true;
            this.line112.LeftOrUpArrow = false;
            this.line112.LineColor = System.Drawing.Color.Black;
            this.line112.LineWidth = 1;
            this.line112.Location = new System.Drawing.Point(721, 379);
            this.line112.Name = "line112";
            this.line112.RightOrBelowArrow = false;
            this.line112.Size = new System.Drawing.Size(62, 10);
            this.line112.TabIndex = 196;
            // 
            // line110
            // 
            this.line110.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line110.BackColor = System.Drawing.Color.Transparent;
            this.line110.Horizontal = true;
            this.line110.LeftOrUpArrow = false;
            this.line110.LineColor = System.Drawing.Color.Black;
            this.line110.LineWidth = 1;
            this.line110.Location = new System.Drawing.Point(721, 57);
            this.line110.Name = "line110";
            this.line110.RightOrBelowArrow = false;
            this.line110.Size = new System.Drawing.Size(61, 10);
            this.line110.TabIndex = 194;
            // 
            // line108
            // 
            this.line108.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line108.BackColor = System.Drawing.Color.Transparent;
            this.line108.Horizontal = true;
            this.line108.LeftOrUpArrow = false;
            this.line108.LineColor = System.Drawing.Color.Black;
            this.line108.LineWidth = 1;
            this.line108.Location = new System.Drawing.Point(654, 378);
            this.line108.Name = "line108";
            this.line108.RightOrBelowArrow = false;
            this.line108.Size = new System.Drawing.Size(16, 10);
            this.line108.TabIndex = 193;
            // 
            // line109
            // 
            this.line109.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line109.BackColor = System.Drawing.Color.Transparent;
            this.line109.Horizontal = true;
            this.line109.LeftOrUpArrow = false;
            this.line109.LineColor = System.Drawing.Color.Black;
            this.line109.LineWidth = 1;
            this.line109.Location = new System.Drawing.Point(654, 285);
            this.line109.Name = "line109";
            this.line109.RightOrBelowArrow = false;
            this.line109.Size = new System.Drawing.Size(16, 10);
            this.line109.TabIndex = 192;
            // 
            // line107
            // 
            this.line107.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line107.BackColor = System.Drawing.Color.Transparent;
            this.line107.Horizontal = true;
            this.line107.LeftOrUpArrow = false;
            this.line107.LineColor = System.Drawing.Color.Black;
            this.line107.LineWidth = 1;
            this.line107.Location = new System.Drawing.Point(654, 175);
            this.line107.Name = "line107";
            this.line107.RightOrBelowArrow = false;
            this.line107.Size = new System.Drawing.Size(16, 10);
            this.line107.TabIndex = 191;
            // 
            // line106
            // 
            this.line106.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line106.BackColor = System.Drawing.Color.Transparent;
            this.line106.Horizontal = true;
            this.line106.LeftOrUpArrow = false;
            this.line106.LineColor = System.Drawing.Color.Black;
            this.line106.LineWidth = 1;
            this.line106.Location = new System.Drawing.Point(654, 57);
            this.line106.Name = "line106";
            this.line106.RightOrBelowArrow = false;
            this.line106.Size = new System.Drawing.Size(16, 10);
            this.line106.TabIndex = 190;
            // 
            // line100
            // 
            this.line100.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line100.BackColor = System.Drawing.Color.Transparent;
            this.line100.Horizontal = true;
            this.line100.LeftOrUpArrow = false;
            this.line100.LineColor = System.Drawing.Color.Black;
            this.line100.LineWidth = 1;
            this.line100.Location = new System.Drawing.Point(802, 88);
            this.line100.Name = "line100";
            this.line100.RightOrBelowArrow = true;
            this.line100.Size = new System.Drawing.Size(18, 10);
            this.line100.TabIndex = 189;
            // 
            // M_CH1_Output_Mix1
            // 
            this.M_CH1_Output_Mix1.BackColor = System.Drawing.Color.White;
            this.M_CH1_Output_Mix1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Output_Mix1.Location = new System.Drawing.Point(782, 83);
            this.M_CH1_Output_Mix1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Output_Mix1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Output_Mix1.Name = "M_CH1_Output_Mix1";
            this.M_CH1_Output_Mix1.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Output_Mix1.TabIndex = 188;
            this.M_CH1_Output_Mix1.Click += new System.EventHandler(this.M_CH1_Output_Mix1_Click);
            // 
            // line101
            // 
            this.line101.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line101.BackColor = System.Drawing.Color.Transparent;
            this.line101.Horizontal = true;
            this.line101.LeftOrUpArrow = false;
            this.line101.LineColor = System.Drawing.Color.Black;
            this.line101.LineWidth = 1;
            this.line101.Location = new System.Drawing.Point(839, 88);
            this.line101.Name = "line101";
            this.line101.RightOrBelowArrow = true;
            this.line101.Size = new System.Drawing.Size(18, 10);
            this.line101.TabIndex = 187;
            // 
            // line102
            // 
            this.line102.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line102.BackColor = System.Drawing.Color.Transparent;
            this.line102.Horizontal = true;
            this.line102.LeftOrUpArrow = false;
            this.line102.LineColor = System.Drawing.Color.Black;
            this.line102.LineWidth = 1;
            this.line102.Location = new System.Drawing.Point(802, 57);
            this.line102.Name = "line102";
            this.line102.RightOrBelowArrow = false;
            this.line102.Size = new System.Drawing.Size(27, 10);
            this.line102.TabIndex = 182;
            // 
            // add8
            // 
            this.add8.BackColor = System.Drawing.Color.Transparent;
            this.add8.DrawColor = System.Drawing.Color.SteelBlue;
            this.add8.Location = new System.Drawing.Point(819, 83);
            this.add8.MaximumSize = new System.Drawing.Size(100, 100);
            this.add8.MinimumSize = new System.Drawing.Size(10, 10);
            this.add8.Name = "add8";
            this.add8.Size = new System.Drawing.Size(20, 20);
            this.add8.TabIndex = 186;
            // 
            // line103
            // 
            this.line103.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line103.BackColor = System.Drawing.Color.Transparent;
            this.line103.Horizontal = false;
            this.line103.LeftOrUpArrow = true;
            this.line103.LineColor = System.Drawing.Color.Black;
            this.line103.LineWidth = 1;
            this.line103.Location = new System.Drawing.Point(824, 104);
            this.line103.Name = "line103";
            this.line103.RightOrBelowArrow = false;
            this.line103.Size = new System.Drawing.Size(10, 20);
            this.line103.TabIndex = 185;
            // 
            // line104
            // 
            this.line104.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line104.BackColor = System.Drawing.Color.Transparent;
            this.line104.Horizontal = false;
            this.line104.LeftOrUpArrow = false;
            this.line104.LineColor = System.Drawing.Color.Black;
            this.line104.LineWidth = 1;
            this.line104.Location = new System.Drawing.Point(824, 62);
            this.line104.Name = "line104";
            this.line104.RightOrBelowArrow = true;
            this.line104.Size = new System.Drawing.Size(10, 20);
            this.line104.TabIndex = 184;
            // 
            // line105
            // 
            this.line105.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line105.BackColor = System.Drawing.Color.Transparent;
            this.line105.Horizontal = true;
            this.line105.LeftOrUpArrow = false;
            this.line105.LineColor = System.Drawing.Color.Black;
            this.line105.LineWidth = 1;
            this.line105.Location = new System.Drawing.Point(802, 119);
            this.line105.Name = "line105";
            this.line105.RightOrBelowArrow = false;
            this.line105.Size = new System.Drawing.Size(28, 10);
            this.line105.TabIndex = 183;
            // 
            // M_CH1_Output_Mix0
            // 
            this.M_CH1_Output_Mix0.BackColor = System.Drawing.Color.White;
            this.M_CH1_Output_Mix0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Output_Mix0.Location = new System.Drawing.Point(782, 114);
            this.M_CH1_Output_Mix0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Output_Mix0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Output_Mix0.Name = "M_CH1_Output_Mix0";
            this.M_CH1_Output_Mix0.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Output_Mix0.TabIndex = 181;
            this.M_CH1_Output_Mix0.Click += new System.EventHandler(this.M_CH1_Output_Mix0_Click);
            // 
            // btn_DRC2
            // 
            this.btn_DRC2.BackColor = System.Drawing.Color.LightGreen;
            this.btn_DRC2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DRC2.Location = new System.Drawing.Point(670, 266);
            this.btn_DRC2.Name = "btn_DRC2";
            this.btn_DRC2.Size = new System.Drawing.Size(51, 138);
            this.btn_DRC2.TabIndex = 179;
            this.btn_DRC2.Text = "DRC2";
            this.btn_DRC2.UseVisualStyleBackColor = false;
            this.btn_DRC2.Click += new System.EventHandler(this.btn_DRC2_Click);
            // 
            // btn_DRC1
            // 
            this.btn_DRC1.BackColor = System.Drawing.Color.LightGreen;
            this.btn_DRC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DRC1.Location = new System.Drawing.Point(670, 43);
            this.btn_DRC1.Name = "btn_DRC1";
            this.btn_DRC1.Size = new System.Drawing.Size(51, 157);
            this.btn_DRC1.TabIndex = 178;
            this.btn_DRC1.Text = "DRC1";
            this.btn_DRC1.UseVisualStyleBackColor = false;
            this.btn_DRC1.Click += new System.EventHandler(this.btn_DRC1_Click);
            // 
            // line99
            // 
            this.line99.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line99.BackColor = System.Drawing.Color.Transparent;
            this.line99.Horizontal = true;
            this.line99.LeftOrUpArrow = false;
            this.line99.LineColor = System.Drawing.Color.Black;
            this.line99.LineWidth = 1;
            this.line99.Location = new System.Drawing.Point(592, 378);
            this.line99.Name = "line99";
            this.line99.RightOrBelowArrow = false;
            this.line99.Size = new System.Drawing.Size(14, 10);
            this.line99.TabIndex = 172;
            // 
            // btn_MasterVOL
            // 
            this.btn_MasterVOL.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_MasterVOL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MasterVOL.Location = new System.Drawing.Point(606, 43);
            this.btn_MasterVOL.Name = "btn_MasterVOL";
            this.btn_MasterVOL.Size = new System.Drawing.Size(48, 361);
            this.btn_MasterVOL.TabIndex = 171;
            this.btn_MasterVOL.Text = "VOL1";
            this.btn_MasterVOL.UseVisualStyleBackColor = false;
            this.btn_MasterVOL.Click += new System.EventHandler(this.btn_MasterVOL_Click);
            // 
            // line95
            // 
            this.line95.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line95.BackColor = System.Drawing.Color.Transparent;
            this.line95.Horizontal = false;
            this.line95.LeftOrUpArrow = false;
            this.line95.LineColor = System.Drawing.Color.Black;
            this.line95.LineWidth = 1;
            this.line95.Location = new System.Drawing.Point(400, 354);
            this.line95.Name = "line95";
            this.line95.RightOrBelowArrow = false;
            this.line95.Size = new System.Drawing.Size(10, 30);
            this.line95.TabIndex = 164;
            // 
            // line98
            // 
            this.line98.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line98.BackColor = System.Drawing.Color.Transparent;
            this.line98.Horizontal = true;
            this.line98.LeftOrUpArrow = false;
            this.line98.LineColor = System.Drawing.Color.Black;
            this.line98.LineWidth = 1;
            this.line98.Location = new System.Drawing.Point(405, 379);
            this.line98.Name = "line98";
            this.line98.RightOrBelowArrow = false;
            this.line98.Size = new System.Drawing.Size(88, 10);
            this.line98.TabIndex = 170;
            // 
            // btn_VOL4
            // 
            this.btn_VOL4.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_VOL4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VOL4.Location = new System.Drawing.Point(555, 374);
            this.btn_VOL4.Name = "btn_VOL4";
            this.btn_VOL4.Size = new System.Drawing.Size(37, 19);
            this.btn_VOL4.TabIndex = 169;
            this.btn_VOL4.Text = "VOL4";
            this.btn_VOL4.UseVisualStyleBackColor = false;
            this.btn_VOL4.Click += new System.EventHandler(this.btn_VOL4_Click);
            // 
            // line97
            // 
            this.line97.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line97.BackColor = System.Drawing.Color.Transparent;
            this.line97.Horizontal = true;
            this.line97.LeftOrUpArrow = false;
            this.line97.LineColor = System.Drawing.Color.Black;
            this.line97.LineWidth = 1;
            this.line97.Location = new System.Drawing.Point(529, 379);
            this.line97.Name = "line97";
            this.line97.RightOrBelowArrow = false;
            this.line97.Size = new System.Drawing.Size(26, 10);
            this.line97.TabIndex = 168;
            // 
            // btn_2BQ_Out
            // 
            this.btn_2BQ_Out.BackColor = System.Drawing.Color.LightCyan;
            this.btn_2BQ_Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2BQ_Out.Location = new System.Drawing.Point(493, 375);
            this.btn_2BQ_Out.Name = "btn_2BQ_Out";
            this.btn_2BQ_Out.Size = new System.Drawing.Size(36, 19);
            this.btn_2BQ_Out.TabIndex = 167;
            this.btn_2BQ_Out.Text = "2BQ";
            this.btn_2BQ_Out.UseVisualStyleBackColor = false;
            this.btn_2BQ_Out.Click += new System.EventHandler(this.btn_2BQ_Out_Click);
            // 
            // line96
            // 
            this.line96.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line96.BackColor = System.Drawing.Color.Transparent;
            this.line96.Horizontal = true;
            this.line96.LeftOrUpArrow = false;
            this.line96.LineColor = System.Drawing.Color.Black;
            this.line96.LineWidth = 1;
            this.line96.Location = new System.Drawing.Point(592, 285);
            this.line96.Name = "line96";
            this.line96.RightOrBelowArrow = false;
            this.line96.Size = new System.Drawing.Size(14, 10);
            this.line96.TabIndex = 166;
            // 
            // btn_VOL3
            // 
            this.btn_VOL3.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_VOL3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VOL3.Location = new System.Drawing.Point(555, 281);
            this.btn_VOL3.Name = "btn_VOL3";
            this.btn_VOL3.Size = new System.Drawing.Size(37, 19);
            this.btn_VOL3.TabIndex = 165;
            this.btn_VOL3.Text = "VOL3";
            this.btn_VOL3.UseVisualStyleBackColor = false;
            this.btn_VOL3.Click += new System.EventHandler(this.btn_VOL3_Click);
            // 
            // line92
            // 
            this.line92.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line92.BackColor = System.Drawing.Color.Transparent;
            this.line92.Horizontal = false;
            this.line92.LeftOrUpArrow = false;
            this.line92.LineColor = System.Drawing.Color.Black;
            this.line92.LineWidth = 1;
            this.line92.Location = new System.Drawing.Point(400, 323);
            this.line92.Name = "line92";
            this.line92.RightOrBelowArrow = false;
            this.line92.Size = new System.Drawing.Size(10, 30);
            this.line92.TabIndex = 161;
            // 
            // line94
            // 
            this.line94.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line94.BackColor = System.Drawing.Color.Transparent;
            this.line94.Horizontal = false;
            this.line94.LeftOrUpArrow = false;
            this.line94.LineColor = System.Drawing.Color.Black;
            this.line94.LineWidth = 1;
            this.line94.Location = new System.Drawing.Point(538, 292);
            this.line94.Name = "line94";
            this.line94.RightOrBelowArrow = false;
            this.line94.Size = new System.Drawing.Size(10, 61);
            this.line94.TabIndex = 163;
            // 
            // line93
            // 
            this.line93.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line93.BackColor = System.Drawing.Color.Transparent;
            this.line93.Horizontal = true;
            this.line93.LeftOrUpArrow = false;
            this.line93.LineColor = System.Drawing.Color.Black;
            this.line93.LineWidth = 1;
            this.line93.Location = new System.Drawing.Point(179, 348);
            this.line93.Name = "line93";
            this.line93.RightOrBelowArrow = false;
            this.line93.Size = new System.Drawing.Size(365, 10);
            this.line93.TabIndex = 162;
            // 
            // line87
            // 
            this.line87.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line87.BackColor = System.Drawing.Color.Transparent;
            this.line87.Horizontal = false;
            this.line87.LeftOrUpArrow = false;
            this.line87.LineColor = System.Drawing.Color.Black;
            this.line87.LineWidth = 1;
            this.line87.Location = new System.Drawing.Point(400, 292);
            this.line87.Name = "line87";
            this.line87.RightOrBelowArrow = false;
            this.line87.Size = new System.Drawing.Size(10, 30);
            this.line87.TabIndex = 160;
            // 
            // line76
            // 
            this.line76.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line76.BackColor = System.Drawing.Color.Transparent;
            this.line76.Horizontal = false;
            this.line76.LeftOrUpArrow = false;
            this.line76.LineColor = System.Drawing.Color.Black;
            this.line76.LineWidth = 1;
            this.line76.Location = new System.Drawing.Point(400, 181);
            this.line76.Name = "line76";
            this.line76.RightOrBelowArrow = false;
            this.line76.Size = new System.Drawing.Size(10, 110);
            this.line76.TabIndex = 142;
            // 
            // line90
            // 
            this.line90.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line90.BackColor = System.Drawing.Color.Transparent;
            this.line90.Horizontal = true;
            this.line90.LeftOrUpArrow = false;
            this.line90.LineColor = System.Drawing.Color.Black;
            this.line90.LineWidth = 1;
            this.line90.Location = new System.Drawing.Point(144, 317);
            this.line90.Name = "line90";
            this.line90.RightOrBelowArrow = false;
            this.line90.Size = new System.Drawing.Size(34, 10);
            this.line90.TabIndex = 159;
            // 
            // line91
            // 
            this.line91.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line91.BackColor = System.Drawing.Color.Transparent;
            this.line91.Horizontal = true;
            this.line91.LeftOrUpArrow = false;
            this.line91.LineColor = System.Drawing.Color.Black;
            this.line91.LineWidth = 1;
            this.line91.Location = new System.Drawing.Point(179, 317);
            this.line91.Name = "line91";
            this.line91.RightOrBelowArrow = false;
            this.line91.Size = new System.Drawing.Size(246, 10);
            this.line91.TabIndex = 158;
            // 
            // line89
            // 
            this.line89.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line89.BackColor = System.Drawing.Color.Transparent;
            this.line89.Horizontal = true;
            this.line89.LeftOrUpArrow = false;
            this.line89.LineColor = System.Drawing.Color.Black;
            this.line89.LineWidth = 1;
            this.line89.Location = new System.Drawing.Point(162, 286);
            this.line89.Name = "line89";
            this.line89.RightOrBelowArrow = false;
            this.line89.Size = new System.Drawing.Size(16, 10);
            this.line89.TabIndex = 157;
            // 
            // line88
            // 
            this.line88.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line88.BackColor = System.Drawing.Color.Transparent;
            this.line88.Horizontal = true;
            this.line88.LeftOrUpArrow = false;
            this.line88.LineColor = System.Drawing.Color.Black;
            this.line88.LineWidth = 1;
            this.line88.Location = new System.Drawing.Point(179, 286);
            this.line88.Name = "line88";
            this.line88.RightOrBelowArrow = false;
            this.line88.Size = new System.Drawing.Size(246, 10);
            this.line88.TabIndex = 156;
            // 
            // line86
            // 
            this.line86.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line86.BackColor = System.Drawing.Color.Transparent;
            this.line86.Horizontal = false;
            this.line86.LeftOrUpArrow = false;
            this.line86.LineColor = System.Drawing.Color.Black;
            this.line86.LineWidth = 1;
            this.line86.Location = new System.Drawing.Point(156, 181);
            this.line86.Name = "line86";
            this.line86.RightOrBelowArrow = false;
            this.line86.Size = new System.Drawing.Size(10, 111);
            this.line86.TabIndex = 154;
            // 
            // line83
            // 
            this.line83.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line83.BackColor = System.Drawing.Color.Transparent;
            this.line83.Horizontal = false;
            this.line83.LeftOrUpArrow = false;
            this.line83.LineColor = System.Drawing.Color.Black;
            this.line83.LineWidth = 1;
            this.line83.Location = new System.Drawing.Point(138, 181);
            this.line83.Name = "line83";
            this.line83.RightOrBelowArrow = false;
            this.line83.Size = new System.Drawing.Size(10, 142);
            this.line83.TabIndex = 153;
            // 
            // line84
            // 
            this.line84.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line84.BackColor = System.Drawing.Color.Transparent;
            this.line84.Horizontal = false;
            this.line84.LeftOrUpArrow = false;
            this.line84.LineColor = System.Drawing.Color.Black;
            this.line84.LineWidth = 1;
            this.line84.Location = new System.Drawing.Point(138, 150);
            this.line84.Name = "line84";
            this.line84.RightOrBelowArrow = false;
            this.line84.Size = new System.Drawing.Size(10, 30);
            this.line84.TabIndex = 152;
            // 
            // line85
            // 
            this.line85.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line85.BackColor = System.Drawing.Color.Transparent;
            this.line85.Horizontal = false;
            this.line85.LeftOrUpArrow = false;
            this.line85.LineColor = System.Drawing.Color.Black;
            this.line85.LineWidth = 1;
            this.line85.Location = new System.Drawing.Point(138, 63);
            this.line85.Name = "line85";
            this.line85.RightOrBelowArrow = false;
            this.line85.Size = new System.Drawing.Size(10, 86);
            this.line85.TabIndex = 151;
            // 
            // line82
            // 
            this.line82.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line82.BackColor = System.Drawing.Color.Transparent;
            this.line82.Horizontal = true;
            this.line82.LeftOrUpArrow = false;
            this.line82.LineColor = System.Drawing.Color.Black;
            this.line82.LineWidth = 1;
            this.line82.Location = new System.Drawing.Point(501, 220);
            this.line82.Name = "line82";
            this.line82.RightOrBelowArrow = false;
            this.line82.Size = new System.Drawing.Size(18, 10);
            this.line82.TabIndex = 149;
            // 
            // line81
            // 
            this.line81.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line81.BackColor = System.Drawing.Color.Transparent;
            this.line81.Horizontal = true;
            this.line81.LeftOrUpArrow = false;
            this.line81.LineColor = System.Drawing.Color.Black;
            this.line81.LineWidth = 1;
            this.line81.Location = new System.Drawing.Point(501, 101);
            this.line81.Name = "line81";
            this.line81.RightOrBelowArrow = false;
            this.line81.Size = new System.Drawing.Size(18, 10);
            this.line81.TabIndex = 147;
            // 
            // line80
            // 
            this.line80.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line80.BackColor = System.Drawing.Color.Transparent;
            this.line80.Horizontal = false;
            this.line80.LeftOrUpArrow = false;
            this.line80.LineColor = System.Drawing.Color.Black;
            this.line80.LineWidth = 1;
            this.line80.Location = new System.Drawing.Point(429, 216);
            this.line80.Name = "line80";
            this.line80.RightOrBelowArrow = false;
            this.line80.Size = new System.Drawing.Size(10, 34);
            this.line80.TabIndex = 146;
            // 
            // line79
            // 
            this.line79.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line79.BackColor = System.Drawing.Color.Transparent;
            this.line79.Horizontal = true;
            this.line79.LeftOrUpArrow = false;
            this.line79.LineColor = System.Drawing.Color.Black;
            this.line79.LineWidth = 1;
            this.line79.Location = new System.Drawing.Point(434, 210);
            this.line79.Name = "line79";
            this.line79.RightOrBelowArrow = false;
            this.line79.Size = new System.Drawing.Size(12, 10);
            this.line79.TabIndex = 145;
            // 
            // line77
            // 
            this.line77.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line77.BackColor = System.Drawing.Color.Transparent;
            this.line77.Horizontal = false;
            this.line77.LeftOrUpArrow = false;
            this.line77.LineColor = System.Drawing.Color.Black;
            this.line77.LineWidth = 1;
            this.line77.Location = new System.Drawing.Point(400, 98);
            this.line77.Name = "line77";
            this.line77.RightOrBelowArrow = false;
            this.line77.Size = new System.Drawing.Size(10, 82);
            this.line77.TabIndex = 143;
            // 
            // line78
            // 
            this.line78.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line78.BackColor = System.Drawing.Color.Transparent;
            this.line78.Horizontal = true;
            this.line78.LeftOrUpArrow = false;
            this.line78.LineColor = System.Drawing.Color.Black;
            this.line78.LineWidth = 1;
            this.line78.Location = new System.Drawing.Point(405, 89);
            this.line78.Name = "line78";
            this.line78.RightOrBelowArrow = false;
            this.line78.Size = new System.Drawing.Size(42, 17);
            this.line78.TabIndex = 144;
            // 
            // line26
            // 
            this.line26.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line26.BackColor = System.Drawing.Color.Transparent;
            this.line26.Horizontal = true;
            this.line26.LeftOrUpArrow = false;
            this.line26.LineColor = System.Drawing.Color.Black;
            this.line26.LineWidth = 1;
            this.line26.Location = new System.Drawing.Point(284, 88);
            this.line26.Name = "line26";
            this.line26.RightOrBelowArrow = false;
            this.line26.Size = new System.Drawing.Size(12, 10);
            this.line26.TabIndex = 64;
            // 
            // line75
            // 
            this.line75.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line75.BackColor = System.Drawing.Color.Transparent;
            this.line75.Horizontal = true;
            this.line75.LeftOrUpArrow = false;
            this.line75.LineColor = System.Drawing.Color.Black;
            this.line75.LineWidth = 1;
            this.line75.Location = new System.Drawing.Point(444, 286);
            this.line75.Name = "line75";
            this.line75.RightOrBelowArrow = true;
            this.line75.Size = new System.Drawing.Size(18, 10);
            this.line75.TabIndex = 141;
            // 
            // M_CH3_Input_Mix0
            // 
            this.M_CH3_Input_Mix0.BackColor = System.Drawing.Color.White;
            this.M_CH3_Input_Mix0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH3_Input_Mix0.Location = new System.Drawing.Point(424, 281);
            this.M_CH3_Input_Mix0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH3_Input_Mix0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH3_Input_Mix0.Name = "M_CH3_Input_Mix0";
            this.M_CH3_Input_Mix0.Size = new System.Drawing.Size(20, 20);
            this.M_CH3_Input_Mix0.TabIndex = 140;
            this.M_CH3_Input_Mix0.Click += new System.EventHandler(this.M_CH3_Input_Mix0_Click);
            // 
            // line69
            // 
            this.line69.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line69.BackColor = System.Drawing.Color.Transparent;
            this.line69.Horizontal = true;
            this.line69.LeftOrUpArrow = false;
            this.line69.LineColor = System.Drawing.Color.Black;
            this.line69.LineWidth = 1;
            this.line69.Location = new System.Drawing.Point(530, 286);
            this.line69.Name = "line69";
            this.line69.RightOrBelowArrow = false;
            this.line69.Size = new System.Drawing.Size(26, 10);
            this.line69.TabIndex = 139;
            // 
            // btn_1BQ_SubOut
            // 
            this.btn_1BQ_SubOut.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_SubOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_SubOut.Location = new System.Drawing.Point(494, 282);
            this.btn_1BQ_SubOut.Name = "btn_1BQ_SubOut";
            this.btn_1BQ_SubOut.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_SubOut.TabIndex = 138;
            this.btn_1BQ_SubOut.Text = "1BQ";
            this.btn_1BQ_SubOut.UseVisualStyleBackColor = false;
            this.btn_1BQ_SubOut.Click += new System.EventHandler(this.btn_1BQ_SubOut_Click);
            // 
            // line70
            // 
            this.line70.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line70.BackColor = System.Drawing.Color.Transparent;
            this.line70.Horizontal = true;
            this.line70.LeftOrUpArrow = false;
            this.line70.LineColor = System.Drawing.Color.Black;
            this.line70.LineWidth = 1;
            this.line70.Location = new System.Drawing.Point(481, 286);
            this.line70.Name = "line70";
            this.line70.RightOrBelowArrow = false;
            this.line70.Size = new System.Drawing.Size(13, 10);
            this.line70.TabIndex = 137;
            // 
            // line71
            // 
            this.line71.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line71.BackColor = System.Drawing.Color.Transparent;
            this.line71.Horizontal = true;
            this.line71.LeftOrUpArrow = false;
            this.line71.LineColor = System.Drawing.Color.Black;
            this.line71.LineWidth = 1;
            this.line71.Location = new System.Drawing.Point(444, 255);
            this.line71.Name = "line71";
            this.line71.RightOrBelowArrow = false;
            this.line71.Size = new System.Drawing.Size(27, 10);
            this.line71.TabIndex = 132;
            // 
            // add7
            // 
            this.add7.BackColor = System.Drawing.Color.Transparent;
            this.add7.DrawColor = System.Drawing.Color.SteelBlue;
            this.add7.Location = new System.Drawing.Point(461, 281);
            this.add7.MaximumSize = new System.Drawing.Size(100, 100);
            this.add7.MinimumSize = new System.Drawing.Size(10, 10);
            this.add7.Name = "add7";
            this.add7.Size = new System.Drawing.Size(20, 20);
            this.add7.TabIndex = 136;
            // 
            // line72
            // 
            this.line72.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line72.BackColor = System.Drawing.Color.Transparent;
            this.line72.Horizontal = false;
            this.line72.LeftOrUpArrow = true;
            this.line72.LineColor = System.Drawing.Color.Black;
            this.line72.LineWidth = 1;
            this.line72.Location = new System.Drawing.Point(466, 302);
            this.line72.Name = "line72";
            this.line72.RightOrBelowArrow = false;
            this.line72.Size = new System.Drawing.Size(10, 20);
            this.line72.TabIndex = 135;
            // 
            // line73
            // 
            this.line73.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line73.BackColor = System.Drawing.Color.Transparent;
            this.line73.Horizontal = false;
            this.line73.LeftOrUpArrow = false;
            this.line73.LineColor = System.Drawing.Color.Black;
            this.line73.LineWidth = 1;
            this.line73.Location = new System.Drawing.Point(466, 260);
            this.line73.Name = "line73";
            this.line73.RightOrBelowArrow = true;
            this.line73.Size = new System.Drawing.Size(10, 20);
            this.line73.TabIndex = 134;
            // 
            // line74
            // 
            this.line74.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line74.BackColor = System.Drawing.Color.Transparent;
            this.line74.Horizontal = true;
            this.line74.LeftOrUpArrow = false;
            this.line74.LineColor = System.Drawing.Color.Black;
            this.line74.LineWidth = 1;
            this.line74.Location = new System.Drawing.Point(444, 317);
            this.line74.Name = "line74";
            this.line74.RightOrBelowArrow = false;
            this.line74.Size = new System.Drawing.Size(28, 10);
            this.line74.TabIndex = 133;
            // 
            // M_CH3_Input_Mix1
            // 
            this.M_CH3_Input_Mix1.BackColor = System.Drawing.Color.White;
            this.M_CH3_Input_Mix1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH3_Input_Mix1.Location = new System.Drawing.Point(424, 312);
            this.M_CH3_Input_Mix1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH3_Input_Mix1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH3_Input_Mix1.Name = "M_CH3_Input_Mix1";
            this.M_CH3_Input_Mix1.Size = new System.Drawing.Size(20, 20);
            this.M_CH3_Input_Mix1.TabIndex = 131;
            this.M_CH3_Input_Mix1.Click += new System.EventHandler(this.M_CH3_Input_Mix1_Click);
            // 
            // M_CH3_Input_Mix2
            // 
            this.M_CH3_Input_Mix2.BackColor = System.Drawing.Color.White;
            this.M_CH3_Input_Mix2.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH3_Input_Mix2.Location = new System.Drawing.Point(424, 250);
            this.M_CH3_Input_Mix2.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH3_Input_Mix2.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH3_Input_Mix2.Name = "M_CH3_Input_Mix2";
            this.M_CH3_Input_Mix2.Size = new System.Drawing.Size(20, 20);
            this.M_CH3_Input_Mix2.TabIndex = 130;
            this.M_CH3_Input_Mix2.Click += new System.EventHandler(this.M_CH3_Input_Mix2_Click);
            // 
            // line68
            // 
            this.line68.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line68.BackColor = System.Drawing.Color.Transparent;
            this.line68.Horizontal = true;
            this.line68.LeftOrUpArrow = false;
            this.line68.LineColor = System.Drawing.Color.Black;
            this.line68.LineWidth = 1;
            this.line68.Location = new System.Drawing.Point(179, 237);
            this.line68.Name = "line68";
            this.line68.RightOrBelowArrow = false;
            this.line68.Size = new System.Drawing.Size(12, 10);
            this.line68.TabIndex = 129;
            // 
            // line67
            // 
            this.line67.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line67.BackColor = System.Drawing.Color.Transparent;
            this.line67.Horizontal = false;
            this.line67.LeftOrUpArrow = false;
            this.line67.LineColor = System.Drawing.Color.Black;
            this.line67.LineWidth = 1;
            this.line67.Location = new System.Drawing.Point(173, 181);
            this.line67.Name = "line67";
            this.line67.RightOrBelowArrow = false;
            this.line67.Size = new System.Drawing.Size(10, 173);
            this.line67.TabIndex = 128;
            // 
            // line66
            // 
            this.line66.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line66.BackColor = System.Drawing.Color.Transparent;
            this.line66.Horizontal = false;
            this.line66.LeftOrUpArrow = false;
            this.line66.LineColor = System.Drawing.Color.Black;
            this.line66.LineWidth = 1;
            this.line66.Location = new System.Drawing.Point(173, 150);
            this.line66.Name = "line66";
            this.line66.RightOrBelowArrow = false;
            this.line66.Size = new System.Drawing.Size(10, 30);
            this.line66.TabIndex = 127;
            // 
            // line65
            // 
            this.line65.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line65.BackColor = System.Drawing.Color.Transparent;
            this.line65.Horizontal = true;
            this.line65.LeftOrUpArrow = false;
            this.line65.LineColor = System.Drawing.Color.Black;
            this.line65.LineWidth = 1;
            this.line65.Location = new System.Drawing.Point(179, 119);
            this.line65.Name = "line65";
            this.line65.RightOrBelowArrow = false;
            this.line65.Size = new System.Drawing.Size(12, 10);
            this.line65.TabIndex = 126;
            // 
            // line64
            // 
            this.line64.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line64.BackColor = System.Drawing.Color.Transparent;
            this.line64.Horizontal = false;
            this.line64.LeftOrUpArrow = false;
            this.line64.LineColor = System.Drawing.Color.Black;
            this.line64.LineWidth = 1;
            this.line64.Location = new System.Drawing.Point(173, 124);
            this.line64.Name = "line64";
            this.line64.RightOrBelowArrow = false;
            this.line64.Size = new System.Drawing.Size(10, 25);
            this.line64.TabIndex = 125;
            // 
            // line49
            // 
            this.line49.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line49.BackColor = System.Drawing.Color.Transparent;
            this.line49.Horizontal = true;
            this.line49.LeftOrUpArrow = false;
            this.line49.LineColor = System.Drawing.Color.Black;
            this.line49.LineWidth = 1;
            this.line49.Location = new System.Drawing.Point(84, 144);
            this.line49.Name = "line49";
            this.line49.RightOrBelowArrow = false;
            this.line49.Size = new System.Drawing.Size(212, 10);
            this.line49.TabIndex = 103;
            // 
            // line63
            // 
            this.line63.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line63.BackColor = System.Drawing.Color.Transparent;
            this.line63.Horizontal = false;
            this.line63.LeftOrUpArrow = false;
            this.line63.LineColor = System.Drawing.Color.Black;
            this.line63.LineWidth = 1;
            this.line63.Location = new System.Drawing.Point(78, 149);
            this.line63.Name = "line63";
            this.line63.RightOrBelowArrow = false;
            this.line63.Size = new System.Drawing.Size(10, 31);
            this.line63.TabIndex = 124;
            // 
            // line42
            // 
            this.line42.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line42.BackColor = System.Drawing.Color.Transparent;
            this.line42.Horizontal = true;
            this.line42.LeftOrUpArrow = false;
            this.line42.LineColor = System.Drawing.Color.Black;
            this.line42.LineWidth = 1;
            this.line42.Location = new System.Drawing.Point(592, 175);
            this.line42.Name = "line42";
            this.line42.RightOrBelowArrow = false;
            this.line42.Size = new System.Drawing.Size(14, 10);
            this.line42.TabIndex = 123;
            // 
            // line43
            // 
            this.line43.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line43.BackColor = System.Drawing.Color.Transparent;
            this.line43.Horizontal = false;
            this.line43.LeftOrUpArrow = false;
            this.line43.LineColor = System.Drawing.Color.Black;
            this.line43.LineWidth = 1;
            this.line43.Location = new System.Drawing.Point(451, 181);
            this.line43.Name = "line43";
            this.line43.RightOrBelowArrow = false;
            this.line43.Size = new System.Drawing.Size(10, 25);
            this.line43.TabIndex = 122;
            // 
            // line44
            // 
            this.line44.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line44.BackColor = System.Drawing.Color.Transparent;
            this.line44.Horizontal = true;
            this.line44.LeftOrUpArrow = false;
            this.line44.LineColor = System.Drawing.Color.Black;
            this.line44.LineWidth = 1;
            this.line44.Location = new System.Drawing.Point(466, 210);
            this.line44.Name = "line44";
            this.line44.RightOrBelowArrow = false;
            this.line44.Size = new System.Drawing.Size(16, 10);
            this.line44.TabIndex = 121;
            // 
            // add4
            // 
            this.add4.BackColor = System.Drawing.Color.Transparent;
            this.add4.DrawColor = System.Drawing.Color.SteelBlue;
            this.add4.Location = new System.Drawing.Point(446, 205);
            this.add4.MaximumSize = new System.Drawing.Size(100, 100);
            this.add4.MinimumSize = new System.Drawing.Size(10, 10);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(20, 20);
            this.add4.TabIndex = 120;
            // 
            // line45
            // 
            this.line45.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line45.BackColor = System.Drawing.Color.Transparent;
            this.line45.Horizontal = true;
            this.line45.LeftOrUpArrow = false;
            this.line45.LineColor = System.Drawing.Color.Black;
            this.line45.LineWidth = 1;
            this.line45.Location = new System.Drawing.Point(501, 201);
            this.line45.Name = "line45";
            this.line45.RightOrBelowArrow = false;
            this.line45.Size = new System.Drawing.Size(13, 10);
            this.line45.TabIndex = 119;
            // 
            // line46
            // 
            this.line46.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line46.BackColor = System.Drawing.Color.Transparent;
            this.line46.Horizontal = true;
            this.line46.LeftOrUpArrow = false;
            this.line46.LineColor = System.Drawing.Color.Black;
            this.line46.LineWidth = 1;
            this.line46.Location = new System.Drawing.Point(533, 201);
            this.line46.Name = "line46";
            this.line46.RightOrBelowArrow = false;
            this.line46.Size = new System.Drawing.Size(10, 10);
            this.line46.TabIndex = 118;
            // 
            // line47
            // 
            this.line47.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line47.BackColor = System.Drawing.Color.Transparent;
            this.line47.Horizontal = false;
            this.line47.LeftOrUpArrow = false;
            this.line47.LineColor = System.Drawing.Color.Black;
            this.line47.LineWidth = 1;
            this.line47.Location = new System.Drawing.Point(538, 181);
            this.line47.Name = "line47";
            this.line47.RightOrBelowArrow = false;
            this.line47.Size = new System.Drawing.Size(10, 26);
            this.line47.TabIndex = 117;
            // 
            // line48
            // 
            this.line48.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line48.BackColor = System.Drawing.Color.Transparent;
            this.line48.Horizontal = true;
            this.line48.LeftOrUpArrow = false;
            this.line48.LineColor = System.Drawing.Color.Black;
            this.line48.LineWidth = 1;
            this.line48.Location = new System.Drawing.Point(529, 175);
            this.line48.Name = "line48";
            this.line48.RightOrBelowArrow = false;
            this.line48.Size = new System.Drawing.Size(26, 10);
            this.line48.TabIndex = 116;
            // 
            // btn_VOL2
            // 
            this.btn_VOL2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_VOL2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VOL2.Location = new System.Drawing.Point(555, 171);
            this.btn_VOL2.Name = "btn_VOL2";
            this.btn_VOL2.Size = new System.Drawing.Size(37, 19);
            this.btn_VOL2.TabIndex = 115;
            this.btn_VOL2.Text = "VOL2";
            this.btn_VOL2.UseVisualStyleBackColor = false;
            this.btn_VOL2.Click += new System.EventHandler(this.btn_VOL2_Click);
            // 
            // btn_1BQ_ROut
            // 
            this.btn_1BQ_ROut.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_ROut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_ROut.Location = new System.Drawing.Point(493, 171);
            this.btn_1BQ_ROut.Name = "btn_1BQ_ROut";
            this.btn_1BQ_ROut.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_ROut.TabIndex = 114;
            this.btn_1BQ_ROut.Text = "1BQ";
            this.btn_1BQ_ROut.UseVisualStyleBackColor = false;
            this.btn_1BQ_ROut.Click += new System.EventHandler(this.btn_1BQ_ROut_Click);
            // 
            // linearGain2
            // 
            this.linearGain2.ArrowDirection = SGM4711_Eva.MDUserCtrls.LinearGain.EnumArrowDirection.Left;
            this.linearGain2.BackColor = System.Drawing.Color.White;
            this.linearGain2.FrameColor = System.Drawing.Color.Black;
            this.linearGain2.Gain = -1;
            this.linearGain2.Location = new System.Drawing.Point(513, 196);
            this.linearGain2.Name = "linearGain2";
            this.linearGain2.Size = new System.Drawing.Size(20, 20);
            this.linearGain2.TabIndex = 112;
            // 
            // line50
            // 
            this.line50.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line50.BackColor = System.Drawing.Color.Transparent;
            this.line50.Horizontal = true;
            this.line50.LeftOrUpArrow = false;
            this.line50.LineColor = System.Drawing.Color.Black;
            this.line50.LineWidth = 1;
            this.line50.Location = new System.Drawing.Point(395, 175);
            this.line50.Name = "line50";
            this.line50.RightOrBelowArrow = false;
            this.line50.Size = new System.Drawing.Size(98, 10);
            this.line50.TabIndex = 111;
            // 
            // btn_6EQ_R
            // 
            this.btn_6EQ_R.BackColor = System.Drawing.Color.LightCyan;
            this.btn_6EQ_R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6EQ_R.Location = new System.Drawing.Point(359, 171);
            this.btn_6EQ_R.Name = "btn_6EQ_R";
            this.btn_6EQ_R.Size = new System.Drawing.Size(36, 19);
            this.btn_6EQ_R.TabIndex = 110;
            this.btn_6EQ_R.Text = "6BQ";
            this.btn_6EQ_R.UseVisualStyleBackColor = false;
            this.btn_6EQ_R.Click += new System.EventHandler(this.btn_6EQ_R_Click);
            // 
            // line51
            // 
            this.line51.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line51.BackColor = System.Drawing.Color.Transparent;
            this.line51.Horizontal = true;
            this.line51.LeftOrUpArrow = false;
            this.line51.LineColor = System.Drawing.Color.Black;
            this.line51.LineWidth = 1;
            this.line51.Location = new System.Drawing.Point(341, 175);
            this.line51.Name = "line51";
            this.line51.RightOrBelowArrow = false;
            this.line51.Size = new System.Drawing.Size(18, 10);
            this.line51.TabIndex = 109;
            // 
            // line52
            // 
            this.line52.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line52.BackColor = System.Drawing.Color.Transparent;
            this.line52.Horizontal = true;
            this.line52.LeftOrUpArrow = false;
            this.line52.LineColor = System.Drawing.Color.Black;
            this.line52.LineWidth = 1;
            this.line52.Location = new System.Drawing.Point(316, 144);
            this.line52.Name = "line52";
            this.line52.RightOrBelowArrow = false;
            this.line52.Size = new System.Drawing.Size(15, 10);
            this.line52.TabIndex = 104;
            // 
            // add5
            // 
            this.add5.BackColor = System.Drawing.Color.Transparent;
            this.add5.DrawColor = System.Drawing.Color.SteelBlue;
            this.add5.Location = new System.Drawing.Point(321, 170);
            this.add5.MaximumSize = new System.Drawing.Size(100, 100);
            this.add5.MinimumSize = new System.Drawing.Size(10, 10);
            this.add5.Name = "add5";
            this.add5.Size = new System.Drawing.Size(20, 20);
            this.add5.TabIndex = 108;
            // 
            // line53
            // 
            this.line53.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line53.BackColor = System.Drawing.Color.Transparent;
            this.line53.Horizontal = false;
            this.line53.LeftOrUpArrow = true;
            this.line53.LineColor = System.Drawing.Color.Black;
            this.line53.LineWidth = 1;
            this.line53.Location = new System.Drawing.Point(326, 191);
            this.line53.Name = "line53";
            this.line53.RightOrBelowArrow = false;
            this.line53.Size = new System.Drawing.Size(10, 20);
            this.line53.TabIndex = 107;
            // 
            // line54
            // 
            this.line54.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line54.BackColor = System.Drawing.Color.Transparent;
            this.line54.Horizontal = false;
            this.line54.LeftOrUpArrow = false;
            this.line54.LineColor = System.Drawing.Color.Black;
            this.line54.LineWidth = 1;
            this.line54.Location = new System.Drawing.Point(326, 149);
            this.line54.Name = "line54";
            this.line54.RightOrBelowArrow = true;
            this.line54.Size = new System.Drawing.Size(10, 20);
            this.line54.TabIndex = 106;
            // 
            // line55
            // 
            this.line55.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line55.BackColor = System.Drawing.Color.Transparent;
            this.line55.Horizontal = true;
            this.line55.LeftOrUpArrow = false;
            this.line55.LineColor = System.Drawing.Color.Black;
            this.line55.LineWidth = 1;
            this.line55.Location = new System.Drawing.Point(316, 206);
            this.line55.Name = "line55";
            this.line55.RightOrBelowArrow = false;
            this.line55.Size = new System.Drawing.Size(15, 10);
            this.line55.TabIndex = 105;
            // 
            // M_CH2_Input_Mix0
            // 
            this.M_CH2_Input_Mix0.BackColor = System.Drawing.Color.White;
            this.M_CH2_Input_Mix0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Input_Mix0.Location = new System.Drawing.Point(295, 201);
            this.M_CH2_Input_Mix0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Input_Mix0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Input_Mix0.Name = "M_CH2_Input_Mix0";
            this.M_CH2_Input_Mix0.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Input_Mix0.TabIndex = 102;
            this.M_CH2_Input_Mix0.Click += new System.EventHandler(this.M_CH2_Input_Mix0_Click);
            // 
            // M_CH2_Input_Mix1
            // 
            this.M_CH2_Input_Mix1.BackColor = System.Drawing.Color.White;
            this.M_CH2_Input_Mix1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Input_Mix1.Location = new System.Drawing.Point(295, 139);
            this.M_CH2_Input_Mix1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Input_Mix1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Input_Mix1.Name = "M_CH2_Input_Mix1";
            this.M_CH2_Input_Mix1.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Input_Mix1.TabIndex = 101;
            this.M_CH2_Input_Mix1.Click += new System.EventHandler(this.M_CH2_Input_Mix1_Click);
            // 
            // line56
            // 
            this.line56.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line56.BackColor = System.Drawing.Color.Transparent;
            this.line56.Horizontal = true;
            this.line56.LeftOrUpArrow = false;
            this.line56.LineColor = System.Drawing.Color.Black;
            this.line56.LineWidth = 1;
            this.line56.Location = new System.Drawing.Point(284, 206);
            this.line56.Name = "line56";
            this.line56.RightOrBelowArrow = false;
            this.line56.Size = new System.Drawing.Size(12, 10);
            this.line56.TabIndex = 100;
            // 
            // btn_1BQ_LRMix_R
            // 
            this.btn_1BQ_LRMix_R.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_LRMix_R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_LRMix_R.Location = new System.Drawing.Point(248, 202);
            this.btn_1BQ_LRMix_R.Name = "btn_1BQ_LRMix_R";
            this.btn_1BQ_LRMix_R.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_LRMix_R.TabIndex = 99;
            this.btn_1BQ_LRMix_R.Text = "1BQ";
            this.btn_1BQ_LRMix_R.UseVisualStyleBackColor = false;
            this.btn_1BQ_LRMix_R.Click += new System.EventHandler(this.btn_1BQ_LRMix_R_Click);
            // 
            // line57
            // 
            this.line57.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line57.BackColor = System.Drawing.Color.Transparent;
            this.line57.Horizontal = true;
            this.line57.LeftOrUpArrow = false;
            this.line57.LineColor = System.Drawing.Color.Black;
            this.line57.LineWidth = 1;
            this.line57.Location = new System.Drawing.Point(236, 206);
            this.line57.Name = "line57";
            this.line57.RightOrBelowArrow = false;
            this.line57.Size = new System.Drawing.Size(12, 10);
            this.line57.TabIndex = 98;
            // 
            // line58
            // 
            this.line58.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line58.BackColor = System.Drawing.Color.Transparent;
            this.line58.Horizontal = true;
            this.line58.LeftOrUpArrow = false;
            this.line58.LineColor = System.Drawing.Color.Black;
            this.line58.LineWidth = 1;
            this.line58.Location = new System.Drawing.Point(211, 175);
            this.line58.Name = "line58";
            this.line58.RightOrBelowArrow = false;
            this.line58.Size = new System.Drawing.Size(15, 10);
            this.line58.TabIndex = 93;
            // 
            // add6
            // 
            this.add6.BackColor = System.Drawing.Color.Transparent;
            this.add6.DrawColor = System.Drawing.Color.SteelBlue;
            this.add6.Location = new System.Drawing.Point(216, 201);
            this.add6.MaximumSize = new System.Drawing.Size(100, 100);
            this.add6.MinimumSize = new System.Drawing.Size(10, 10);
            this.add6.Name = "add6";
            this.add6.Size = new System.Drawing.Size(20, 20);
            this.add6.TabIndex = 97;
            // 
            // line59
            // 
            this.line59.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line59.BackColor = System.Drawing.Color.Transparent;
            this.line59.Horizontal = false;
            this.line59.LeftOrUpArrow = true;
            this.line59.LineColor = System.Drawing.Color.Black;
            this.line59.LineWidth = 1;
            this.line59.Location = new System.Drawing.Point(221, 222);
            this.line59.Name = "line59";
            this.line59.RightOrBelowArrow = false;
            this.line59.Size = new System.Drawing.Size(10, 20);
            this.line59.TabIndex = 96;
            // 
            // line60
            // 
            this.line60.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line60.BackColor = System.Drawing.Color.Transparent;
            this.line60.Horizontal = false;
            this.line60.LeftOrUpArrow = false;
            this.line60.LineColor = System.Drawing.Color.Black;
            this.line60.LineWidth = 1;
            this.line60.Location = new System.Drawing.Point(221, 180);
            this.line60.Name = "line60";
            this.line60.RightOrBelowArrow = true;
            this.line60.Size = new System.Drawing.Size(10, 20);
            this.line60.TabIndex = 95;
            // 
            // line61
            // 
            this.line61.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line61.BackColor = System.Drawing.Color.Transparent;
            this.line61.Horizontal = true;
            this.line61.LeftOrUpArrow = false;
            this.line61.LineColor = System.Drawing.Color.Black;
            this.line61.LineWidth = 1;
            this.line61.Location = new System.Drawing.Point(211, 237);
            this.line61.Name = "line61";
            this.line61.RightOrBelowArrow = false;
            this.line61.Size = new System.Drawing.Size(15, 10);
            this.line61.TabIndex = 94;
            // 
            // line62
            // 
            this.line62.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line62.BackColor = System.Drawing.Color.Transparent;
            this.line62.Horizontal = true;
            this.line62.LeftOrUpArrow = false;
            this.line62.LineColor = System.Drawing.Color.Black;
            this.line62.LineWidth = 1;
            this.line62.Location = new System.Drawing.Point(132, 172);
            this.line62.Name = "line62";
            this.line62.RightOrBelowArrow = false;
            this.line62.Size = new System.Drawing.Size(59, 17);
            this.line62.TabIndex = 92;
            // 
            // M_CH2_Input_Mix2
            // 
            this.M_CH2_Input_Mix2.BackColor = System.Drawing.Color.White;
            this.M_CH2_Input_Mix2.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Input_Mix2.Location = new System.Drawing.Point(190, 232);
            this.M_CH2_Input_Mix2.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Input_Mix2.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Input_Mix2.Name = "M_CH2_Input_Mix2";
            this.M_CH2_Input_Mix2.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Input_Mix2.TabIndex = 91;
            this.M_CH2_Input_Mix2.Click += new System.EventHandler(this.M_CH2_Input_Mix2_Click);
            // 
            // M_CH2_Input_Mix3
            // 
            this.M_CH2_Input_Mix3.BackColor = System.Drawing.Color.White;
            this.M_CH2_Input_Mix3.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH2_Input_Mix3.Location = new System.Drawing.Point(190, 170);
            this.M_CH2_Input_Mix3.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH2_Input_Mix3.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH2_Input_Mix3.Name = "M_CH2_Input_Mix3";
            this.M_CH2_Input_Mix3.Size = new System.Drawing.Size(20, 20);
            this.M_CH2_Input_Mix3.TabIndex = 90;
            this.M_CH2_Input_Mix3.Click += new System.EventHandler(this.M_CH2_Input_Mix3_Click);
            // 
            // line41
            // 
            this.line41.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line41.BackColor = System.Drawing.Color.Transparent;
            this.line41.Horizontal = true;
            this.line41.LeftOrUpArrow = false;
            this.line41.LineColor = System.Drawing.Color.Black;
            this.line41.LineWidth = 1;
            this.line41.Location = new System.Drawing.Point(592, 57);
            this.line41.Name = "line41";
            this.line41.RightOrBelowArrow = false;
            this.line41.Size = new System.Drawing.Size(14, 10);
            this.line41.TabIndex = 89;
            // 
            // line40
            // 
            this.line40.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line40.BackColor = System.Drawing.Color.Transparent;
            this.line40.Horizontal = false;
            this.line40.LeftOrUpArrow = false;
            this.line40.LineColor = System.Drawing.Color.Black;
            this.line40.LineWidth = 1;
            this.line40.Location = new System.Drawing.Point(451, 63);
            this.line40.Name = "line40";
            this.line40.RightOrBelowArrow = false;
            this.line40.Size = new System.Drawing.Size(10, 25);
            this.line40.TabIndex = 88;
            // 
            // line39
            // 
            this.line39.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line39.BackColor = System.Drawing.Color.Transparent;
            this.line39.Horizontal = true;
            this.line39.LeftOrUpArrow = false;
            this.line39.LineColor = System.Drawing.Color.Black;
            this.line39.LineWidth = 1;
            this.line39.Location = new System.Drawing.Point(466, 92);
            this.line39.Name = "line39";
            this.line39.RightOrBelowArrow = false;
            this.line39.Size = new System.Drawing.Size(16, 10);
            this.line39.TabIndex = 87;
            // 
            // add3
            // 
            this.add3.BackColor = System.Drawing.Color.Transparent;
            this.add3.DrawColor = System.Drawing.Color.SteelBlue;
            this.add3.Location = new System.Drawing.Point(446, 87);
            this.add3.MaximumSize = new System.Drawing.Size(100, 100);
            this.add3.MinimumSize = new System.Drawing.Size(10, 10);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(20, 20);
            this.add3.TabIndex = 86;
            // 
            // line38
            // 
            this.line38.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line38.BackColor = System.Drawing.Color.Transparent;
            this.line38.Horizontal = true;
            this.line38.LeftOrUpArrow = false;
            this.line38.LineColor = System.Drawing.Color.Black;
            this.line38.LineWidth = 1;
            this.line38.Location = new System.Drawing.Point(501, 83);
            this.line38.Name = "line38";
            this.line38.RightOrBelowArrow = false;
            this.line38.Size = new System.Drawing.Size(13, 10);
            this.line38.TabIndex = 85;
            // 
            // line37
            // 
            this.line37.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line37.BackColor = System.Drawing.Color.Transparent;
            this.line37.Horizontal = true;
            this.line37.LeftOrUpArrow = false;
            this.line37.LineColor = System.Drawing.Color.Black;
            this.line37.LineWidth = 1;
            this.line37.Location = new System.Drawing.Point(533, 83);
            this.line37.Name = "line37";
            this.line37.RightOrBelowArrow = false;
            this.line37.Size = new System.Drawing.Size(10, 10);
            this.line37.TabIndex = 83;
            // 
            // line36
            // 
            this.line36.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line36.BackColor = System.Drawing.Color.Transparent;
            this.line36.Horizontal = false;
            this.line36.LeftOrUpArrow = false;
            this.line36.LineColor = System.Drawing.Color.Black;
            this.line36.LineWidth = 1;
            this.line36.Location = new System.Drawing.Point(538, 63);
            this.line36.Name = "line36";
            this.line36.RightOrBelowArrow = false;
            this.line36.Size = new System.Drawing.Size(10, 26);
            this.line36.TabIndex = 82;
            // 
            // line35
            // 
            this.line35.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line35.BackColor = System.Drawing.Color.Transparent;
            this.line35.Horizontal = true;
            this.line35.LeftOrUpArrow = false;
            this.line35.LineColor = System.Drawing.Color.Black;
            this.line35.LineWidth = 1;
            this.line35.Location = new System.Drawing.Point(529, 57);
            this.line35.Name = "line35";
            this.line35.RightOrBelowArrow = false;
            this.line35.Size = new System.Drawing.Size(26, 10);
            this.line35.TabIndex = 81;
            // 
            // btn_VOL1
            // 
            this.btn_VOL1.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_VOL1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VOL1.Location = new System.Drawing.Point(555, 53);
            this.btn_VOL1.Name = "btn_VOL1";
            this.btn_VOL1.Size = new System.Drawing.Size(37, 19);
            this.btn_VOL1.TabIndex = 80;
            this.btn_VOL1.Text = "VOL1";
            this.btn_VOL1.UseVisualStyleBackColor = false;
            this.btn_VOL1.Click += new System.EventHandler(this.btn_VOL1_Click);
            // 
            // btn_1BQ_LOut
            // 
            this.btn_1BQ_LOut.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_LOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_LOut.Location = new System.Drawing.Point(493, 53);
            this.btn_1BQ_LOut.Name = "btn_1BQ_LOut";
            this.btn_1BQ_LOut.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_LOut.TabIndex = 79;
            this.btn_1BQ_LOut.Text = "1BQ";
            this.btn_1BQ_LOut.UseVisualStyleBackColor = false;
            this.btn_1BQ_LOut.Click += new System.EventHandler(this.btn_1BQ_LOut_Click);
            // 
            // linearGain1
            // 
            this.linearGain1.ArrowDirection = SGM4711_Eva.MDUserCtrls.LinearGain.EnumArrowDirection.Left;
            this.linearGain1.BackColor = System.Drawing.Color.White;
            this.linearGain1.FrameColor = System.Drawing.Color.Black;
            this.linearGain1.Gain = -1;
            this.linearGain1.Location = new System.Drawing.Point(513, 78);
            this.linearGain1.Name = "linearGain1";
            this.linearGain1.Size = new System.Drawing.Size(20, 20);
            this.linearGain1.TabIndex = 77;
            // 
            // line32
            // 
            this.line32.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line32.BackColor = System.Drawing.Color.Transparent;
            this.line32.Horizontal = true;
            this.line32.LeftOrUpArrow = false;
            this.line32.LineColor = System.Drawing.Color.Black;
            this.line32.LineWidth = 1;
            this.line32.Location = new System.Drawing.Point(84, 26);
            this.line32.Name = "line32";
            this.line32.RightOrBelowArrow = false;
            this.line32.Size = new System.Drawing.Size(212, 10);
            this.line32.TabIndex = 67;
            // 
            // line34
            // 
            this.line34.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line34.BackColor = System.Drawing.Color.Transparent;
            this.line34.Horizontal = false;
            this.line34.LeftOrUpArrow = false;
            this.line34.LineColor = System.Drawing.Color.Black;
            this.line34.LineWidth = 1;
            this.line34.Location = new System.Drawing.Point(78, 31);
            this.line34.Name = "line34";
            this.line34.RightOrBelowArrow = false;
            this.line34.Size = new System.Drawing.Size(10, 31);
            this.line34.TabIndex = 76;
            // 
            // line33
            // 
            this.line33.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line33.BackColor = System.Drawing.Color.Transparent;
            this.line33.Horizontal = true;
            this.line33.LeftOrUpArrow = false;
            this.line33.LineColor = System.Drawing.Color.Black;
            this.line33.LineWidth = 1;
            this.line33.Location = new System.Drawing.Point(395, 57);
            this.line33.Name = "line33";
            this.line33.RightOrBelowArrow = false;
            this.line33.Size = new System.Drawing.Size(98, 10);
            this.line33.TabIndex = 75;
            // 
            // btn_6EQ_L
            // 
            this.btn_6EQ_L.BackColor = System.Drawing.Color.LightCyan;
            this.btn_6EQ_L.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6EQ_L.Location = new System.Drawing.Point(359, 53);
            this.btn_6EQ_L.Name = "btn_6EQ_L";
            this.btn_6EQ_L.Size = new System.Drawing.Size(36, 19);
            this.btn_6EQ_L.TabIndex = 74;
            this.btn_6EQ_L.Text = "6BQ";
            this.btn_6EQ_L.UseVisualStyleBackColor = false;
            this.btn_6EQ_L.Click += new System.EventHandler(this.btn_6EQ_L_Click);
            // 
            // line27
            // 
            this.line27.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line27.BackColor = System.Drawing.Color.Transparent;
            this.line27.Horizontal = true;
            this.line27.LeftOrUpArrow = false;
            this.line27.LineColor = System.Drawing.Color.Black;
            this.line27.LineWidth = 1;
            this.line27.Location = new System.Drawing.Point(341, 57);
            this.line27.Name = "line27";
            this.line27.RightOrBelowArrow = false;
            this.line27.Size = new System.Drawing.Size(18, 10);
            this.line27.TabIndex = 73;
            // 
            // line28
            // 
            this.line28.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line28.BackColor = System.Drawing.Color.Transparent;
            this.line28.Horizontal = true;
            this.line28.LeftOrUpArrow = false;
            this.line28.LineColor = System.Drawing.Color.Black;
            this.line28.LineWidth = 1;
            this.line28.Location = new System.Drawing.Point(316, 26);
            this.line28.Name = "line28";
            this.line28.RightOrBelowArrow = false;
            this.line28.Size = new System.Drawing.Size(15, 10);
            this.line28.TabIndex = 68;
            // 
            // add2
            // 
            this.add2.BackColor = System.Drawing.Color.Transparent;
            this.add2.DrawColor = System.Drawing.Color.SteelBlue;
            this.add2.Location = new System.Drawing.Point(321, 52);
            this.add2.MaximumSize = new System.Drawing.Size(100, 100);
            this.add2.MinimumSize = new System.Drawing.Size(10, 10);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(20, 20);
            this.add2.TabIndex = 72;
            // 
            // line29
            // 
            this.line29.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line29.BackColor = System.Drawing.Color.Transparent;
            this.line29.Horizontal = false;
            this.line29.LeftOrUpArrow = true;
            this.line29.LineColor = System.Drawing.Color.Black;
            this.line29.LineWidth = 1;
            this.line29.Location = new System.Drawing.Point(326, 73);
            this.line29.Name = "line29";
            this.line29.RightOrBelowArrow = false;
            this.line29.Size = new System.Drawing.Size(10, 20);
            this.line29.TabIndex = 71;
            // 
            // line30
            // 
            this.line30.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line30.BackColor = System.Drawing.Color.Transparent;
            this.line30.Horizontal = false;
            this.line30.LeftOrUpArrow = false;
            this.line30.LineColor = System.Drawing.Color.Black;
            this.line30.LineWidth = 1;
            this.line30.Location = new System.Drawing.Point(326, 31);
            this.line30.Name = "line30";
            this.line30.RightOrBelowArrow = true;
            this.line30.Size = new System.Drawing.Size(10, 20);
            this.line30.TabIndex = 70;
            // 
            // line31
            // 
            this.line31.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line31.BackColor = System.Drawing.Color.Transparent;
            this.line31.Horizontal = true;
            this.line31.LeftOrUpArrow = false;
            this.line31.LineColor = System.Drawing.Color.Black;
            this.line31.LineWidth = 1;
            this.line31.Location = new System.Drawing.Point(316, 88);
            this.line31.Name = "line31";
            this.line31.RightOrBelowArrow = false;
            this.line31.Size = new System.Drawing.Size(15, 10);
            this.line31.TabIndex = 69;
            // 
            // M_CH1_Input_Mix0
            // 
            this.M_CH1_Input_Mix0.BackColor = System.Drawing.Color.White;
            this.M_CH1_Input_Mix0.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Input_Mix0.Location = new System.Drawing.Point(295, 83);
            this.M_CH1_Input_Mix0.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Input_Mix0.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Input_Mix0.Name = "M_CH1_Input_Mix0";
            this.M_CH1_Input_Mix0.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Input_Mix0.TabIndex = 66;
            this.M_CH1_Input_Mix0.Click += new System.EventHandler(this.M_CH1_Input_Mix0_Click);
            // 
            // M_CH1_Input_Mix1
            // 
            this.M_CH1_Input_Mix1.BackColor = System.Drawing.Color.White;
            this.M_CH1_Input_Mix1.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Input_Mix1.Location = new System.Drawing.Point(295, 21);
            this.M_CH1_Input_Mix1.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Input_Mix1.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Input_Mix1.Name = "M_CH1_Input_Mix1";
            this.M_CH1_Input_Mix1.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Input_Mix1.TabIndex = 65;
            this.M_CH1_Input_Mix1.Click += new System.EventHandler(this.M_CH1_Input_Mix1_Click);
            // 
            // btn_1BQ_LRMix_L
            // 
            this.btn_1BQ_LRMix_L.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_LRMix_L.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_LRMix_L.Location = new System.Drawing.Point(248, 84);
            this.btn_1BQ_LRMix_L.Name = "btn_1BQ_LRMix_L";
            this.btn_1BQ_LRMix_L.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_LRMix_L.TabIndex = 63;
            this.btn_1BQ_LRMix_L.Text = "1BQ";
            this.btn_1BQ_LRMix_L.UseVisualStyleBackColor = false;
            this.btn_1BQ_LRMix_L.Click += new System.EventHandler(this.btn_1BQ_LRMix_L_Click);
            // 
            // line25
            // 
            this.line25.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line25.BackColor = System.Drawing.Color.Transparent;
            this.line25.Horizontal = true;
            this.line25.LeftOrUpArrow = false;
            this.line25.LineColor = System.Drawing.Color.Black;
            this.line25.LineWidth = 1;
            this.line25.Location = new System.Drawing.Point(236, 88);
            this.line25.Name = "line25";
            this.line25.RightOrBelowArrow = false;
            this.line25.Size = new System.Drawing.Size(12, 10);
            this.line25.TabIndex = 62;
            // 
            // line21
            // 
            this.line21.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line21.BackColor = System.Drawing.Color.Transparent;
            this.line21.Horizontal = true;
            this.line21.LeftOrUpArrow = false;
            this.line21.LineColor = System.Drawing.Color.Black;
            this.line21.LineWidth = 1;
            this.line21.Location = new System.Drawing.Point(211, 57);
            this.line21.Name = "line21";
            this.line21.RightOrBelowArrow = false;
            this.line21.Size = new System.Drawing.Size(15, 10);
            this.line21.TabIndex = 57;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.Transparent;
            this.add1.DrawColor = System.Drawing.Color.SteelBlue;
            this.add1.Location = new System.Drawing.Point(216, 83);
            this.add1.MaximumSize = new System.Drawing.Size(100, 100);
            this.add1.MinimumSize = new System.Drawing.Size(10, 10);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(20, 20);
            this.add1.TabIndex = 61;
            // 
            // line23
            // 
            this.line23.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line23.BackColor = System.Drawing.Color.Transparent;
            this.line23.Horizontal = false;
            this.line23.LeftOrUpArrow = true;
            this.line23.LineColor = System.Drawing.Color.Black;
            this.line23.LineWidth = 1;
            this.line23.Location = new System.Drawing.Point(221, 104);
            this.line23.Name = "line23";
            this.line23.RightOrBelowArrow = false;
            this.line23.Size = new System.Drawing.Size(10, 20);
            this.line23.TabIndex = 60;
            // 
            // line24
            // 
            this.line24.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.small;
            this.line24.BackColor = System.Drawing.Color.Transparent;
            this.line24.Horizontal = false;
            this.line24.LeftOrUpArrow = false;
            this.line24.LineColor = System.Drawing.Color.Black;
            this.line24.LineWidth = 1;
            this.line24.Location = new System.Drawing.Point(221, 62);
            this.line24.Name = "line24";
            this.line24.RightOrBelowArrow = true;
            this.line24.Size = new System.Drawing.Size(10, 20);
            this.line24.TabIndex = 59;
            // 
            // line22
            // 
            this.line22.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line22.BackColor = System.Drawing.Color.Transparent;
            this.line22.Horizontal = true;
            this.line22.LeftOrUpArrow = false;
            this.line22.LineColor = System.Drawing.Color.Black;
            this.line22.LineWidth = 1;
            this.line22.Location = new System.Drawing.Point(211, 119);
            this.line22.Name = "line22";
            this.line22.RightOrBelowArrow = false;
            this.line22.Size = new System.Drawing.Size(15, 10);
            this.line22.TabIndex = 58;
            // 
            // line20
            // 
            this.line20.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line20.BackColor = System.Drawing.Color.Transparent;
            this.line20.Horizontal = true;
            this.line20.LeftOrUpArrow = false;
            this.line20.LineColor = System.Drawing.Color.Black;
            this.line20.LineWidth = 1;
            this.line20.Location = new System.Drawing.Point(132, 54);
            this.line20.Name = "line20";
            this.line20.RightOrBelowArrow = false;
            this.line20.Size = new System.Drawing.Size(59, 17);
            this.line20.TabIndex = 56;
            // 
            // M_CH1_Input_Mix2
            // 
            this.M_CH1_Input_Mix2.BackColor = System.Drawing.Color.White;
            this.M_CH1_Input_Mix2.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Input_Mix2.Location = new System.Drawing.Point(190, 114);
            this.M_CH1_Input_Mix2.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Input_Mix2.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Input_Mix2.Name = "M_CH1_Input_Mix2";
            this.M_CH1_Input_Mix2.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Input_Mix2.TabIndex = 55;
            this.M_CH1_Input_Mix2.Click += new System.EventHandler(this.M_CH1_Imnut_Mix2_Click);
            // 
            // M_CH1_Input_Mix3
            // 
            this.M_CH1_Input_Mix3.BackColor = System.Drawing.Color.White;
            this.M_CH1_Input_Mix3.DrawColor = System.Drawing.Color.SteelBlue;
            this.M_CH1_Input_Mix3.Location = new System.Drawing.Point(190, 52);
            this.M_CH1_Input_Mix3.MaximumSize = new System.Drawing.Size(100, 100);
            this.M_CH1_Input_Mix3.MinimumSize = new System.Drawing.Size(10, 10);
            this.M_CH1_Input_Mix3.Name = "M_CH1_Input_Mix3";
            this.M_CH1_Input_Mix3.Size = new System.Drawing.Size(20, 20);
            this.M_CH1_Input_Mix3.TabIndex = 54;
            this.M_CH1_Input_Mix3.Click += new System.EventHandler(this.M_CH1_Input_Mix3_Click);
            // 
            // btn_1BQ_RIn
            // 
            this.btn_1BQ_RIn.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_RIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_RIn.Location = new System.Drawing.Point(96, 171);
            this.btn_1BQ_RIn.Name = "btn_1BQ_RIn";
            this.btn_1BQ_RIn.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_RIn.TabIndex = 53;
            this.btn_1BQ_RIn.Text = "1BQ";
            this.btn_1BQ_RIn.UseVisualStyleBackColor = false;
            this.btn_1BQ_RIn.Click += new System.EventHandler(this.btn_1BQ_RIn_Click);
            // 
            // btn_1BQ_LIn
            // 
            this.btn_1BQ_LIn.BackColor = System.Drawing.Color.LightCyan;
            this.btn_1BQ_LIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1BQ_LIn.Location = new System.Drawing.Point(96, 53);
            this.btn_1BQ_LIn.Name = "btn_1BQ_LIn";
            this.btn_1BQ_LIn.Size = new System.Drawing.Size(36, 19);
            this.btn_1BQ_LIn.TabIndex = 53;
            this.btn_1BQ_LIn.Text = "1BQ";
            this.btn_1BQ_LIn.UseVisualStyleBackColor = false;
            this.btn_1BQ_LIn.Click += new System.EventHandler(this.btn_1BQ_LIn_Click);
            // 
            // line18
            // 
            this.line18.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line18.BackColor = System.Drawing.Color.Transparent;
            this.line18.Horizontal = true;
            this.line18.LeftOrUpArrow = false;
            this.line18.LineColor = System.Drawing.Color.Black;
            this.line18.LineWidth = 1;
            this.line18.Location = new System.Drawing.Point(70, 175);
            this.line18.Name = "line18";
            this.line18.RightOrBelowArrow = false;
            this.line18.Size = new System.Drawing.Size(26, 10);
            this.line18.TabIndex = 52;
            // 
            // line19
            // 
            this.line19.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line19.BackColor = System.Drawing.Color.Transparent;
            this.line19.Horizontal = true;
            this.line19.LeftOrUpArrow = false;
            this.line19.LineColor = System.Drawing.Color.Black;
            this.line19.LineWidth = 1;
            this.line19.Location = new System.Drawing.Point(70, 57);
            this.line19.Name = "line19";
            this.line19.RightOrBelowArrow = false;
            this.line19.Size = new System.Drawing.Size(26, 10);
            this.line19.TabIndex = 51;
            // 
            // line17
            // 
            this.line17.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line17.BackColor = System.Drawing.Color.Transparent;
            this.line17.Horizontal = true;
            this.line17.LeftOrUpArrow = false;
            this.line17.LineColor = System.Drawing.Color.Black;
            this.line17.LineWidth = 1;
            this.line17.Location = new System.Drawing.Point(21, 187);
            this.line17.Name = "line17";
            this.line17.RightOrBelowArrow = false;
            this.line17.Size = new System.Drawing.Size(15, 10);
            this.line17.TabIndex = 45;
            // 
            // line16
            // 
            this.line16.ArrowSize = SGM4711_Eva.MDUserCtrls.Line.EnumArrowSize.medium;
            this.line16.BackColor = System.Drawing.Color.Transparent;
            this.line16.Horizontal = true;
            this.line16.LeftOrUpArrow = false;
            this.line16.LineColor = System.Drawing.Color.Black;
            this.line16.LineWidth = 1;
            this.line16.Location = new System.Drawing.Point(21, 72);
            this.line16.Name = "line16";
            this.line16.RightOrBelowArrow = false;
            this.line16.Size = new System.Drawing.Size(15, 10);
            this.line16.TabIndex = 44;
            // 
            // outputLogCtrl
            // 
            this.outputLogCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLogCtrl.Location = new System.Drawing.Point(3, 3);
            this.outputLogCtrl.Name = "outputLogCtrl";
            this.outputLogCtrl.Size = new System.Drawing.Size(585, 211);
            this.outputLogCtrl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 758);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu_main);
            this.MinimumSize = new System.Drawing.Size(1010, 630);
            this.Name = "MainForm";
            this.Text = "SGM4711 Eva_v0.42";
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_OpVoltage)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabCtrl_MainGUI.ResumeLayout(false);
            this.tabP_systemConfig.ResumeLayout(false);
            this.tabP_systemConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MasterVolume)).EndInit();
            this.grb_OpeStatus.ResumeLayout(false);
            this.grb_OpeStatus.PerformLayout();
            this.tabP_AudioEngine.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MasterVolume_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pl_LFBSwitch.ResumeLayout(false);
            this.pl_LFBSwitch.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabCtrl_SingleRegSetting.ResumeLayout(false);
            this.tabCtrl_Output.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Open;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Open_Excel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Open_proj;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Save;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Import;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile_ExitWithoutSave;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools_selectDongle;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools_ScriptWrite;
        private System.Windows.Forms.ToolStripMenuItem MenuItemView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemView_RegMap;
        private System.Windows.Forms.ToolStripMenuItem MenuItemView_BD;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemI2CMode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemI2CMode_GPIO;
        private System.Windows.Forms.ToolStripMenuItem MenuItemI2CMode_HW;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp_About;
        private System.Windows.Forms.ToolTip myTips;
        private System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.ToolStripStatusLabel statusBar_DeviceConnected;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_FWVersion;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_VID;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_PID;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_BoardType;
        private System.Windows.Forms.ToolStripTextBox MenuItemTools_I2CAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabCtrl_MainGUI;
        private System.Windows.Forms.TabPage tabP_systemConfig;
        private System.Windows.Forms.TextBox txt_MasterVol;
        private System.Windows.Forms.Label lbl_MasterVol;
        private System.Windows.Forms.CheckBox chb_Enable;
        private System.Windows.Forms.Button btn_backToDefault;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Button btn_OutputMux_GUI;
        private System.Windows.Forms.Button btn_AudioEngine_GUI;
        private System.Windows.Forms.Button btn_InputMux_GUI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private MDUserCtrls.Line line14;
        private MDUserCtrls.Line line9;
        private MDUserCtrls.Line line13;
        private MDUserCtrls.Line line15;
        private MDUserCtrls.Line line12;
        private MDUserCtrls.Line line10;
        private MDUserCtrls.Line line11;
        private System.Windows.Forms.Button btn_OutputMux;
        private System.Windows.Forms.CheckBox chb_MuteMasterVolume;
        private System.Windows.Forms.TrackBar trb_MasterVolume;
        private MDUserCtrls.Line line6;
        private MDUserCtrls.Line line7;
        private MDUserCtrls.Line line8;
        private MDUserCtrls.Line line5;
        private MDUserCtrls.Line line3;
        private MDUserCtrls.Line line4;
        private System.Windows.Forms.Button btn_AudioEngine;
        private System.Windows.Forms.Button btn_InputMux;
        private MDUserCtrls.Line line2;
        private MDUserCtrls.Line line1;
        private System.Windows.Forms.GroupBox grb_OpeStatus;
        private System.Windows.Forms.ComboBox cmb_SampleRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MDUserCtrls.Indicator indicator_OTW;
        private MDUserCtrls.Indicator indicator_PSG;
        private MDUserCtrls.Indicator indicator_Clip;
        private MDUserCtrls.Indicator indicator_FrameSlip;
        private MDUserCtrls.Indicator indicator_WS;
        private MDUserCtrls.Indicator indicator_BCLK;
        private MDUserCtrls.Indicator indicator_PLLLock;
        private MDUserCtrls.Indicator indicator_MCLK;
        private System.Windows.Forms.Button btn_RefreshStatus;
        private System.Windows.Forms.Button btn_ClearStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_InterfaceConfig;
        private System.Windows.Forms.ComboBox cmb_ModeConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUP_OpVoltage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_MasterVolume;
        private System.Windows.Forms.TabPage tabP_AudioEngine;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabCtrl_SingleRegSetting;
        private System.Windows.Forms.TabPage tabP_SingleCtrl;
        private System.Windows.Forms.TabPage tabP_RegRW;
        private System.Windows.Forms.TabPage tabP_IICMemTool;
        private System.Windows.Forms.TabControl tabCtrl_Output;
        private System.Windows.Forms.TabPage tabPage1;
        private MDUserCtrls.OutputLogCtrl outputLogCtrl;
        private System.Windows.Forms.Panel pnl_Main;
        private MDUserCtrls.Line line21;
        private MDUserCtrls.Line line20;
        private MDUserCtrls.Multiply M_CH1_Input_Mix2;
        private MDUserCtrls.Multiply M_CH1_Input_Mix3;
        private MDUserCtrls.myButton btn_1BQ_RIn;
        private MDUserCtrls.myButton btn_1BQ_LIn;
        private MDUserCtrls.Line line18;
        private MDUserCtrls.Line line19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chb_PreHPF_EN;
        private MDUserCtrls.Line line17;
        private MDUserCtrls.Line line16;
        private System.Windows.Forms.CheckBox chb_v4Source;
        private System.Windows.Forms.CheckBox chb_v3Source;
        private MDUserCtrls.Line line22;
        private MDUserCtrls.Add add1;
        private MDUserCtrls.Line line23;
        private MDUserCtrls.Line line24;
        private MDUserCtrls.myButton btn_1BQ_LRMix_L;
        private MDUserCtrls.Line line25;
        private MDUserCtrls.Line line33;
        private MDUserCtrls.myButton btn_6EQ_L;
        private MDUserCtrls.Line line27;
        private MDUserCtrls.Line line28;
        private MDUserCtrls.Add add2;
        private MDUserCtrls.Line line29;
        private MDUserCtrls.Line line30;
        private MDUserCtrls.Line line31;
        private MDUserCtrls.Line line32;
        private MDUserCtrls.Multiply M_CH1_Input_Mix0;
        private MDUserCtrls.Multiply M_CH1_Input_Mix1;
        private MDUserCtrls.Line line26;
        private MDUserCtrls.Line line34;
        private MDUserCtrls.LinearGain linearGain1;
        private System.Windows.Forms.Panel pl_LFBSwitch;
        private System.Windows.Forms.RadioButton rbt_DRCAuto_LP_0_0;
        private System.Windows.Forms.RadioButton rbt_DRCAuto_LP_0_1;
        private MDUserCtrls.myButton btn_1BQ_LOut;
        private MDUserCtrls.myButton btn_VOL1;
        private MDUserCtrls.Line line35;
        private MDUserCtrls.Line line37;
        private MDUserCtrls.Line line36;
        private MDUserCtrls.Line line38;
        private MDUserCtrls.Add add3;
        private MDUserCtrls.Line line39;
        private MDUserCtrls.Line line40;
        private MDUserCtrls.Line line41;
        private MDUserCtrls.Line line42;
        private MDUserCtrls.Line line43;
        private MDUserCtrls.Line line44;
        private MDUserCtrls.Add add4;
        private MDUserCtrls.Line line45;
        private MDUserCtrls.Line line46;
        private MDUserCtrls.Line line47;
        private MDUserCtrls.Line line48;
        private MDUserCtrls.myButton btn_VOL2;
        private MDUserCtrls.myButton btn_1BQ_ROut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_DRCAuto_LP_1_0;
        private System.Windows.Forms.RadioButton rbt_DRCAuto_LP_1_1;
        private MDUserCtrls.LinearGain linearGain2;
        private MDUserCtrls.Line line49;
        private MDUserCtrls.Line line50;
        private MDUserCtrls.myButton btn_6EQ_R;
        private MDUserCtrls.Line line51;
        private MDUserCtrls.Line line52;
        private MDUserCtrls.Add add5;
        private MDUserCtrls.Line line53;
        private MDUserCtrls.Line line54;
        private MDUserCtrls.Line line55;
        private MDUserCtrls.Multiply M_CH2_Input_Mix0;
        private MDUserCtrls.Multiply M_CH2_Input_Mix1;
        private MDUserCtrls.Line line56;
        private MDUserCtrls.myButton btn_1BQ_LRMix_R;
        private MDUserCtrls.Line line57;
        private MDUserCtrls.Line line58;
        private MDUserCtrls.Add add6;
        private MDUserCtrls.Line line59;
        private MDUserCtrls.Line line60;
        private MDUserCtrls.Line line61;
        private MDUserCtrls.Line line62;
        private MDUserCtrls.Multiply M_CH2_Input_Mix2;
        private MDUserCtrls.Multiply M_CH2_Input_Mix3;
        private MDUserCtrls.Line line63;
        private MDUserCtrls.Line line65;
        private MDUserCtrls.Line line64;
        private MDUserCtrls.Line line66;
        private MDUserCtrls.Line line67;
        private MDUserCtrls.Line line68;
        private MDUserCtrls.Line line77;
        private MDUserCtrls.Line line76;
        private MDUserCtrls.Line line75;
        private MDUserCtrls.Multiply M_CH3_Input_Mix0;
        private MDUserCtrls.Line line69;
        private MDUserCtrls.myButton btn_1BQ_SubOut;
        private MDUserCtrls.Line line70;
        private MDUserCtrls.Line line71;
        private MDUserCtrls.Add add7;
        private MDUserCtrls.Line line72;
        private MDUserCtrls.Line line73;
        private MDUserCtrls.Line line74;
        private MDUserCtrls.Multiply M_CH3_Input_Mix1;
        private MDUserCtrls.Multiply M_CH3_Input_Mix2;
        private MDUserCtrls.Line line78;
        private MDUserCtrls.Line line80;
        private MDUserCtrls.Line line79;
        private MDUserCtrls.Line line81;
        private System.Windows.Forms.Label label29;
        private MDUserCtrls.Line line82;
        private System.Windows.Forms.Label label21;
        private MDUserCtrls.Line line83;
        private MDUserCtrls.Line line84;
        private MDUserCtrls.Line line85;
        private MDUserCtrls.Line line86;
        private MDUserCtrls.Line line88;
        private MDUserCtrls.Line line89;
        private MDUserCtrls.Line line90;
        private MDUserCtrls.Line line91;
        private MDUserCtrls.Line line92;
        private MDUserCtrls.Line line87;
        private MDUserCtrls.Line line93;
        private MDUserCtrls.Line line94;
        private MDUserCtrls.Line line96;
        private MDUserCtrls.myButton btn_VOL3;
        private MDUserCtrls.Line line95;
        private MDUserCtrls.Line line98;
        private MDUserCtrls.myButton btn_VOL4;
        private MDUserCtrls.Line line97;
        private MDUserCtrls.myButton btn_2BQ_Out;
        private MDUserCtrls.myButton btn_MasterVOL;
        private MDUserCtrls.Line line99;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TrackBar trb_MasterVolume_1;
        private System.Windows.Forms.TextBox txt_MasterVol_1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox chb_MuteMasterVolume_1;
        private MDUserCtrls.myButton btn_DRC1;
        private MDUserCtrls.myButton btn_DRC2;
        private MDUserCtrls.Line line100;
        private MDUserCtrls.Multiply M_CH1_Output_Mix1;
        private MDUserCtrls.Line line101;
        private MDUserCtrls.Line line102;
        private MDUserCtrls.Add add8;
        private MDUserCtrls.Line line103;
        private MDUserCtrls.Line line104;
        private MDUserCtrls.Line line105;
        private MDUserCtrls.Multiply M_CH1_Output_Mix0;
        private MDUserCtrls.Multiply M_CH1_Output_Mix2;
        private MDUserCtrls.Line line108;
        private MDUserCtrls.Line line109;
        private MDUserCtrls.Line line107;
        private MDUserCtrls.Line line106;
        private MDUserCtrls.Line line113;
        private MDUserCtrls.Line line112;
        private MDUserCtrls.Line line111;
        private MDUserCtrls.Line line110;
        private MDUserCtrls.Line line114;
        private MDUserCtrls.Multiply M_CH2_Output_Mix1;
        private MDUserCtrls.Line line115;
        private MDUserCtrls.Line line116;
        private MDUserCtrls.Add add9;
        private MDUserCtrls.Line line117;
        private MDUserCtrls.Line line118;
        private MDUserCtrls.Line line119;
        private MDUserCtrls.Multiply M_CH2_Output_Mix0;
        private MDUserCtrls.Multiply M_CH2_Output_Mix2;
        private MDUserCtrls.Line line120;
        private MDUserCtrls.Line line121;
        private MDUserCtrls.Line line123;
        private MDUserCtrls.Line line124;
        private MDUserCtrls.Add add10;
        private MDUserCtrls.Line line125;
        private MDUserCtrls.Line line126;
        private MDUserCtrls.Line line127;
        private MDUserCtrls.Multiply M_CH4_Output_Mix0;
        private MDUserCtrls.Multiply M_CH4_Output_Mix1;
        private MDUserCtrls.Line line129;
        private MDUserCtrls.Line line128;
        private MDUserCtrls.Line line122;
        private MDUserCtrls.Line line131;
        private MDUserCtrls.Line line130;
        private MDUserCtrls.Line line132;
        private MDUserCtrls.Line line133;
        private MDUserCtrls.Line line134;
        private MDUserCtrls.Line line135;
        private MDUserCtrls.Line line136;
        private MDUserCtrls.Line line137;
        private MDUserCtrls.Dot dot1;
        private MDUserCtrls.Dot dot2;
        private MDUserCtrls.Dot dot4;
        private MDUserCtrls.Dot dot3;
        private MDUserCtrls.Dot dot5;
        private MDUserCtrls.Dot dot6;
        private MDUserCtrls.Dot dot7;
        private MDUserCtrls.Dot dot8;
        private MDUserCtrls.Dot dot9;
        private MDUserCtrls.Dot dot10;
        private MDUserCtrls.Dot dot11;
        private MDUserCtrls.Dot dot12;
        private MDUserCtrls.Dot dot13;
        private System.Windows.Forms.CheckBox chb_PostHPF_EN;
        private MDUserCtrls.Multiply M_OutputPreScale_1;
        private MDUserCtrls.Multiply M_OutputPreScale_0;
        private MDUserCtrls.Multiply M_OutputPostScale_0;
        private MDUserCtrls.Multiply M_OutputPostScale_1;
        private MDUserCtrls.myButton btn_NG;
        private MDUserCtrls.Line line139;
        private System.Windows.Forms.Label label33;
        private MDUserCtrls.Line line138;
        private System.Windows.Forms.Label label32;
        private MDUserCtrls.Line line140;
        private MDUserCtrls.Line line141;
        private MDUserCtrls.Line line142;
        private MDUserCtrls.Line line143;
        private MDUserCtrls.Line line147;
        private MDUserCtrls.Line line146;
        private MDUserCtrls.Line line144;
        private MDUserCtrls.Line line145;

    }
}

