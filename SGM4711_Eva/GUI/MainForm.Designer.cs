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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.line14 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line9 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line13 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line15 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line12 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line10 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line11 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_OutputMux = new System.Windows.Forms.Button();
            this.chb_MuteMasterVolume = new System.Windows.Forms.CheckBox();
            this.trb_MasterVolume = new System.Windows.Forms.TrackBar();
            this.line6 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line7 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line8 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line5 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line3 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line4 = new SGM4711_Eva.MDUserCtrls.Line();
            this.btn_AudioEngine = new System.Windows.Forms.Button();
            this.btn_InputMux = new System.Windows.Forms.Button();
            this.line2 = new SGM4711_Eva.MDUserCtrls.Line();
            this.line1 = new SGM4711_Eva.MDUserCtrls.Line();
            this.grb_OpeStatus = new System.Windows.Forms.GroupBox();
            this.txt_SampleRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.indicator_OTW = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_PSG = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_Clip = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_FrameSlip = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_WS = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_BCLK = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_PLLLock = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.indicator_MCLK = new SGM4711_Eva.MDUserCtrls.Indicator();
            this.btn_RefreshStatus = new System.Windows.Forms.Button();
            this.btn_ClearStatus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_InterfaceConfig = new System.Windows.Forms.ComboBox();
            this.cmb_ModeConfig = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUP_OpVoltage = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_MasterVolume = new System.Windows.Forms.Button();
            this.tabP_AudioEngine = new System.Windows.Forms.TabPage();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.chb_v4Source = new System.Windows.Forms.CheckBox();
            this.pl_SubReverb = new System.Windows.Forms.Panel();
            this.pl_RReverb = new System.Windows.Forms.Panel();
            this.pl_LReverb = new System.Windows.Forms.Panel();
            this.pl_SubOutMixGain = new System.Windows.Forms.Panel();
            this.pl_ROutMixGain = new System.Windows.Forms.Panel();
            this.pl_LOutMixGain = new System.Windows.Forms.Panel();
            this.pl_MidMixGain = new System.Windows.Forms.Panel();
            this.pl_LRMixGain_Sub = new System.Windows.Forms.Panel();
            this.pl_LRMixGain_R = new System.Windows.Forms.Panel();
            this.pl_LRPreMixGain_R = new System.Windows.Forms.Panel();
            this.pl_LRMixGain_L = new System.Windows.Forms.Panel();
            this.pl_LRPreMixGain_L = new System.Windows.Forms.Panel();
            this.pl_GainAfterClipper = new System.Windows.Forms.Panel();
            this.pl_GainBeforeClipper = new System.Windows.Forms.Panel();
            this.pl_DRC2 = new System.Windows.Forms.Panel();
            this.pl_DRC1 = new System.Windows.Forms.Panel();
            this.pl_MasterVOL = new System.Windows.Forms.Panel();
            this.pl_VOL4 = new System.Windows.Forms.Panel();
            this.pl_VOL3 = new System.Windows.Forms.Panel();
            this.pl_VOL2 = new System.Windows.Forms.Panel();
            this.pl_VOL1 = new System.Windows.Forms.Panel();
            this.pl_2BQ = new System.Windows.Forms.Panel();
            this.pl_1BQ_Sub = new System.Windows.Forms.Panel();
            this.pl_1BQ_ROut = new System.Windows.Forms.Panel();
            this.pl_1BQ_LOut = new System.Windows.Forms.Panel();
            this.pl_1BQ_LRMix_R = new System.Windows.Forms.Panel();
            this.pl_1BQ_LRMix_L = new System.Windows.Forms.Panel();
            this.pl_1BQ_RIn = new System.Windows.Forms.Panel();
            this.pl_1BQ_LIn = new System.Windows.Forms.Panel();
            this.pl_NGSubOut = new System.Windows.Forms.Panel();
            this.pl_NGROut = new System.Windows.Forms.Panel();
            this.pl_NGLOut = new System.Windows.Forms.Panel();
            this.pl_HPFSubOut = new System.Windows.Forms.Panel();
            this.pl_HPFROut = new System.Windows.Forms.Panel();
            this.pl_HPFLOut = new System.Windows.Forms.Panel();
            this.pl_HPF_RIn = new System.Windows.Forms.Panel();
            this.pl_6EQ_R = new System.Windows.Forms.Panel();
            this.pl_HPF_LIn = new System.Windows.Forms.Panel();
            this.pl_6EQ_L = new System.Windows.Forms.Panel();
            this.chb_v3Source = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabCtrl_SingleRegSetting = new System.Windows.Forms.TabControl();
            this.tabP_SingleCtrl = new System.Windows.Forms.TabPage();
            this.tabP_RegRW = new System.Windows.Forms.TabPage();
            this.tabP_IICMemTool = new System.Windows.Forms.TabPage();
            this.tabCtrl_Output = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myTips = new System.Windows.Forms.ToolTip(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBar_DeviceConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_FWVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_VID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_PID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_BoardType = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabCtrl_MainGUI.SuspendLayout();
            this.tabP_systemConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MasterVolume)).BeginInit();
            this.grb_OpeStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_OpVoltage)).BeginInit();
            this.tabP_AudioEngine.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabCtrl_SingleRegSetting.SuspendLayout();
            this.tabCtrl_Output.SuspendLayout();
            this.statusBar.SuspendLayout();
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
            this.menu_main.Size = new System.Drawing.Size(1080, 24);
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
            this.splitContainer1.Size = new System.Drawing.Size(1080, 734);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 6;
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
            this.tabCtrl_MainGUI.Size = new System.Drawing.Size(1080, 460);
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
            this.tabP_systemConfig.Size = new System.Drawing.Size(1072, 431);
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
            this.txt_MasterVol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MasterVol_KeyPress);
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
            // line14
            // 
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
            // line6
            // 
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
            this.btn_AudioEngine.Click += new System.EventHandler(this.btn_AudioEngine_Click);
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
            // line2
            // 
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
            // grb_OpeStatus
            // 
            this.grb_OpeStatus.Controls.Add(this.txt_SampleRate);
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
            // txt_SampleRate
            // 
            this.txt_SampleRate.Enabled = false;
            this.txt_SampleRate.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.txt_SampleRate.Location = new System.Drawing.Point(18, 62);
            this.txt_SampleRate.Name = "txt_SampleRate";
            this.txt_SampleRate.Size = new System.Drawing.Size(76, 24);
            this.txt_SampleRate.TabIndex = 8;
            this.txt_SampleRate.Text = "11.025k/12k";
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
            // indicator_OTW
            // 
            this.indicator_OTW.BackColor = System.Drawing.Color.Transparent;
            this.indicator_OTW.IndicatorColorReverse = true;
            this.indicator_OTW.Location = new System.Drawing.Point(481, 62);
            this.indicator_OTW.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_OTW.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_OTW.MinimumSize = new System.Drawing.Size(14, 17);
            this.indicator_OTW.Name = "indicator_OTW";
            this.indicator_OTW.Size = new System.Drawing.Size(25, 25);
            this.indicator_OTW.TabIndex = 6;
            // 
            // indicator_PSG
            // 
            this.indicator_PSG.BackColor = System.Drawing.Color.Transparent;
            this.indicator_PSG.IndicatorColorReverse = true;
            this.indicator_PSG.Location = new System.Drawing.Point(430, 62);
            this.indicator_PSG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_PSG.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_PSG.MinimumSize = new System.Drawing.Size(14, 17);
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
            this.indicator_Clip.MinimumSize = new System.Drawing.Size(14, 17);
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
            this.indicator_FrameSlip.MinimumSize = new System.Drawing.Size(14, 17);
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
            this.indicator_WS.MinimumSize = new System.Drawing.Size(14, 17);
            this.indicator_WS.Name = "indicator_WS";
            this.indicator_WS.Size = new System.Drawing.Size(25, 25);
            this.indicator_WS.TabIndex = 6;
            // 
            // indicator_BCLK
            // 
            this.indicator_BCLK.BackColor = System.Drawing.Color.Transparent;
            this.indicator_BCLK.IndicatorColorReverse = true;
            this.indicator_BCLK.Location = new System.Drawing.Point(226, 62);
            this.indicator_BCLK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indicator_BCLK.MaximumSize = new System.Drawing.Size(136, 177);
            this.indicator_BCLK.MinimumSize = new System.Drawing.Size(14, 17);
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
            this.indicator_PLLLock.MinimumSize = new System.Drawing.Size(14, 17);
            this.indicator_PLLLock.Name = "indicator_PLLLock";
            this.indicator_PLLLock.Size = new System.Drawing.Size(25, 25);
            this.indicator_PLLLock.TabIndex = 6;
            // 
            // indicator_MCLK
            // 
            this.indicator_MCLK.BackColor = System.Drawing.Color.Transparent;
            this.indicator_MCLK.IndicatorColorReverse = true;
            this.indicator_MCLK.Location = new System.Drawing.Point(124, 62);
            this.indicator_MCLK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.indicator_MCLK.MaximumSize = new System.Drawing.Size(117, 133);
            this.indicator_MCLK.MinimumSize = new System.Drawing.Size(12, 13);
            this.indicator_MCLK.Name = "indicator_MCLK";
            this.indicator_MCLK.Size = new System.Drawing.Size(25, 25);
            this.indicator_MCLK.TabIndex = 6;
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
            this.cmb_InterfaceConfig.DropDown += new System.EventHandler(this.cmbx_DropDownResize);
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
            18,
            0,
            0,
            0});
            this.numUP_OpVoltage.ValueChanged += new System.EventHandler(this.numUP_OpVoltage_ValueChanged);
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
            this.tabP_AudioEngine.Size = new System.Drawing.Size(1072, 431);
            this.tabP_AudioEngine.TabIndex = 1;
            this.tabP_AudioEngine.Text = "Audio Engine";
            this.tabP_AudioEngine.UseVisualStyleBackColor = true;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Main.BackgroundImage")));
            this.pnl_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Main.Controls.Add(this.chb_v4Source);
            this.pnl_Main.Controls.Add(this.pl_SubReverb);
            this.pnl_Main.Controls.Add(this.pl_RReverb);
            this.pnl_Main.Controls.Add(this.pl_LReverb);
            this.pnl_Main.Controls.Add(this.pl_SubOutMixGain);
            this.pnl_Main.Controls.Add(this.pl_ROutMixGain);
            this.pnl_Main.Controls.Add(this.pl_LOutMixGain);
            this.pnl_Main.Controls.Add(this.pl_MidMixGain);
            this.pnl_Main.Controls.Add(this.pl_LRMixGain_Sub);
            this.pnl_Main.Controls.Add(this.pl_LRMixGain_R);
            this.pnl_Main.Controls.Add(this.pl_LRPreMixGain_R);
            this.pnl_Main.Controls.Add(this.pl_LRMixGain_L);
            this.pnl_Main.Controls.Add(this.pl_LRPreMixGain_L);
            this.pnl_Main.Controls.Add(this.pl_GainAfterClipper);
            this.pnl_Main.Controls.Add(this.pl_GainBeforeClipper);
            this.pnl_Main.Controls.Add(this.pl_DRC2);
            this.pnl_Main.Controls.Add(this.pl_DRC1);
            this.pnl_Main.Controls.Add(this.pl_MasterVOL);
            this.pnl_Main.Controls.Add(this.pl_VOL4);
            this.pnl_Main.Controls.Add(this.pl_VOL3);
            this.pnl_Main.Controls.Add(this.pl_VOL2);
            this.pnl_Main.Controls.Add(this.pl_VOL1);
            this.pnl_Main.Controls.Add(this.pl_2BQ);
            this.pnl_Main.Controls.Add(this.pl_1BQ_Sub);
            this.pnl_Main.Controls.Add(this.pl_1BQ_ROut);
            this.pnl_Main.Controls.Add(this.pl_1BQ_LOut);
            this.pnl_Main.Controls.Add(this.pl_1BQ_LRMix_R);
            this.pnl_Main.Controls.Add(this.pl_1BQ_LRMix_L);
            this.pnl_Main.Controls.Add(this.pl_1BQ_RIn);
            this.pnl_Main.Controls.Add(this.pl_1BQ_LIn);
            this.pnl_Main.Controls.Add(this.pl_NGSubOut);
            this.pnl_Main.Controls.Add(this.pl_NGROut);
            this.pnl_Main.Controls.Add(this.pl_NGLOut);
            this.pnl_Main.Controls.Add(this.pl_HPFSubOut);
            this.pnl_Main.Controls.Add(this.pl_HPFROut);
            this.pnl_Main.Controls.Add(this.pl_HPFLOut);
            this.pnl_Main.Controls.Add(this.pl_HPF_RIn);
            this.pnl_Main.Controls.Add(this.pl_6EQ_R);
            this.pnl_Main.Controls.Add(this.pl_HPF_LIn);
            this.pnl_Main.Controls.Add(this.pl_6EQ_L);
            this.pnl_Main.Controls.Add(this.chb_v3Source);
            this.pnl_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(3, 3);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1066, 425);
            this.pnl_Main.TabIndex = 0;
            // 
            // chb_v4Source
            // 
            this.chb_v4Source.AutoSize = true;
            this.chb_v4Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_v4Source.Font = new System.Drawing.Font("SimSun", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_v4Source.Location = new System.Drawing.Point(455, 268);
            this.chb_v4Source.Name = "chb_v4Source";
            this.chb_v4Source.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_v4Source.Size = new System.Drawing.Size(66, 13);
            this.chb_v4Source.TabIndex = 43;
            this.chb_v4Source.Text = "From 0x09";
            this.chb_v4Source.UseVisualStyleBackColor = true;
            this.chb_v4Source.CheckedChanged += new System.EventHandler(this.chb_v4Source_CheckedChanged);
            // 
            // pl_SubReverb
            // 
            this.pl_SubReverb.BackColor = System.Drawing.Color.Transparent;
            this.pl_SubReverb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_SubReverb.Location = new System.Drawing.Point(397, 269);
            this.pl_SubReverb.Name = "pl_SubReverb";
            this.pl_SubReverb.Size = new System.Drawing.Size(13, 52);
            this.pl_SubReverb.TabIndex = 41;
            this.pl_SubReverb.Click += new System.EventHandler(this.pl_SubReverb_Click);
            // 
            // pl_RReverb
            // 
            this.pl_RReverb.BackColor = System.Drawing.Color.Transparent;
            this.pl_RReverb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_RReverb.Location = new System.Drawing.Point(420, 141);
            this.pl_RReverb.Name = "pl_RReverb";
            this.pl_RReverb.Size = new System.Drawing.Size(14, 26);
            this.pl_RReverb.TabIndex = 40;
            this.pl_RReverb.Click += new System.EventHandler(this.pl_LReverb_Click);
            // 
            // pl_LReverb
            // 
            this.pl_LReverb.BackColor = System.Drawing.Color.Transparent;
            this.pl_LReverb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LReverb.Location = new System.Drawing.Point(418, 56);
            this.pl_LReverb.Name = "pl_LReverb";
            this.pl_LReverb.Size = new System.Drawing.Size(14, 26);
            this.pl_LReverb.TabIndex = 39;
            this.pl_LReverb.Click += new System.EventHandler(this.pl_LReverb_Click);
            // 
            // pl_SubOutMixGain
            // 
            this.pl_SubOutMixGain.BackColor = System.Drawing.Color.Transparent;
            this.pl_SubOutMixGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_SubOutMixGain.Location = new System.Drawing.Point(697, 249);
            this.pl_SubOutMixGain.Name = "pl_SubOutMixGain";
            this.pl_SubOutMixGain.Size = new System.Drawing.Size(23, 56);
            this.pl_SubOutMixGain.TabIndex = 38;
            this.pl_SubOutMixGain.Click += new System.EventHandler(this.pl_SubOutMixGain_Click);
            // 
            // pl_ROutMixGain
            // 
            this.pl_ROutMixGain.BackColor = System.Drawing.Color.Transparent;
            this.pl_ROutMixGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_ROutMixGain.Location = new System.Drawing.Point(695, 122);
            this.pl_ROutMixGain.Name = "pl_ROutMixGain";
            this.pl_ROutMixGain.Size = new System.Drawing.Size(23, 63);
            this.pl_ROutMixGain.TabIndex = 37;
            this.pl_ROutMixGain.Click += new System.EventHandler(this.pl_ROutMixGain_Click);
            // 
            // pl_LOutMixGain
            // 
            this.pl_LOutMixGain.BackColor = System.Drawing.Color.Transparent;
            this.pl_LOutMixGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LOutMixGain.Location = new System.Drawing.Point(696, 34);
            this.pl_LOutMixGain.Name = "pl_LOutMixGain";
            this.pl_LOutMixGain.Size = new System.Drawing.Size(23, 63);
            this.pl_LOutMixGain.TabIndex = 36;
            this.pl_LOutMixGain.Click += new System.EventHandler(this.pl_LOutMixGain_Click);
            // 
            // pl_MidMixGain
            // 
            this.pl_MidMixGain.BackColor = System.Drawing.Color.Transparent;
            this.pl_MidMixGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_MidMixGain.Location = new System.Drawing.Point(378, 176);
            this.pl_MidMixGain.Name = "pl_MidMixGain";
            this.pl_MidMixGain.Size = new System.Drawing.Size(23, 59);
            this.pl_MidMixGain.TabIndex = 35;
            this.pl_MidMixGain.Click += new System.EventHandler(this.pl_MidMixGain_Click);
            // 
            // pl_LRMixGain_Sub
            // 
            this.pl_LRMixGain_Sub.BackColor = System.Drawing.Color.Transparent;
            this.pl_LRMixGain_Sub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LRMixGain_Sub.Location = new System.Drawing.Point(101, 276);
            this.pl_LRMixGain_Sub.Name = "pl_LRMixGain_Sub";
            this.pl_LRMixGain_Sub.Size = new System.Drawing.Size(23, 59);
            this.pl_LRMixGain_Sub.TabIndex = 34;
            this.pl_LRMixGain_Sub.Click += new System.EventHandler(this.pl_LRMixGain_Sub_Click);
            // 
            // pl_LRMixGain_R
            // 
            this.pl_LRMixGain_R.BackColor = System.Drawing.Color.Transparent;
            this.pl_LRMixGain_R.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LRMixGain_R.Location = new System.Drawing.Point(253, 107);
            this.pl_LRMixGain_R.Name = "pl_LRMixGain_R";
            this.pl_LRMixGain_R.Size = new System.Drawing.Size(23, 59);
            this.pl_LRMixGain_R.TabIndex = 33;
            this.pl_LRMixGain_R.Click += new System.EventHandler(this.pl_LRMixGain_R_Click);
            // 
            // pl_LRPreMixGain_R
            // 
            this.pl_LRPreMixGain_R.BackColor = System.Drawing.Color.Transparent;
            this.pl_LRPreMixGain_R.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LRPreMixGain_R.Location = new System.Drawing.Point(164, 123);
            this.pl_LRPreMixGain_R.Name = "pl_LRPreMixGain_R";
            this.pl_LRPreMixGain_R.Size = new System.Drawing.Size(23, 59);
            this.pl_LRPreMixGain_R.TabIndex = 32;
            this.pl_LRPreMixGain_R.Click += new System.EventHandler(this.pl_LRPreMixGain_R_Click);
            // 
            // pl_LRMixGain_L
            // 
            this.pl_LRMixGain_L.BackColor = System.Drawing.Color.Transparent;
            this.pl_LRMixGain_L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LRMixGain_L.Location = new System.Drawing.Point(253, 15);
            this.pl_LRMixGain_L.Name = "pl_LRMixGain_L";
            this.pl_LRMixGain_L.Size = new System.Drawing.Size(23, 59);
            this.pl_LRMixGain_L.TabIndex = 31;
            this.pl_LRMixGain_L.Click += new System.EventHandler(this.pl_LRMixGain_L_Click);
            // 
            // pl_LRPreMixGain_L
            // 
            this.pl_LRPreMixGain_L.BackColor = System.Drawing.Color.Transparent;
            this.pl_LRPreMixGain_L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_LRPreMixGain_L.Location = new System.Drawing.Point(162, 31);
            this.pl_LRPreMixGain_L.Name = "pl_LRPreMixGain_L";
            this.pl_LRPreMixGain_L.Size = new System.Drawing.Size(23, 59);
            this.pl_LRPreMixGain_L.TabIndex = 30;
            this.pl_LRPreMixGain_L.Click += new System.EventHandler(this.pl_LRPreMixGain_L_Click);
            // 
            // pl_GainAfterClipper
            // 
            this.pl_GainAfterClipper.BackColor = System.Drawing.Color.Transparent;
            this.pl_GainAfterClipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_GainAfterClipper.Location = new System.Drawing.Point(824, 35);
            this.pl_GainAfterClipper.Name = "pl_GainAfterClipper";
            this.pl_GainAfterClipper.Size = new System.Drawing.Size(31, 155);
            this.pl_GainAfterClipper.TabIndex = 29;
            this.pl_GainAfterClipper.Click += new System.EventHandler(this.pl_GainAfterClipper_Click);
            // 
            // pl_GainBeforeClipper
            // 
            this.pl_GainBeforeClipper.BackColor = System.Drawing.Color.Transparent;
            this.pl_GainBeforeClipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_GainBeforeClipper.Location = new System.Drawing.Point(741, 34);
            this.pl_GainBeforeClipper.Name = "pl_GainBeforeClipper";
            this.pl_GainBeforeClipper.Size = new System.Drawing.Size(31, 155);
            this.pl_GainBeforeClipper.TabIndex = 28;
            this.pl_GainBeforeClipper.Click += new System.EventHandler(this.pl_GainBeforeClipper_Click);
            // 
            // pl_DRC2
            // 
            this.pl_DRC2.BackColor = System.Drawing.Color.Transparent;
            this.pl_DRC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_DRC2.Location = new System.Drawing.Point(590, 193);
            this.pl_DRC2.Name = "pl_DRC2";
            this.pl_DRC2.Size = new System.Drawing.Size(51, 112);
            this.pl_DRC2.TabIndex = 27;
            this.pl_DRC2.Click += new System.EventHandler(this.pl_DRC2_Click);
            this.pl_DRC2.DoubleClick += new System.EventHandler(this.pl_DRC2_DoubleClick);
            // 
            // pl_DRC1
            // 
            this.pl_DRC1.BackColor = System.Drawing.Color.Transparent;
            this.pl_DRC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_DRC1.Location = new System.Drawing.Point(590, 34);
            this.pl_DRC1.Name = "pl_DRC1";
            this.pl_DRC1.Size = new System.Drawing.Size(51, 112);
            this.pl_DRC1.TabIndex = 26;
            this.pl_DRC1.Click += new System.EventHandler(this.pl_DRC1_Click);
            this.pl_DRC1.DoubleClick += new System.EventHandler(this.pl_DRC1_DoubleClick);
            // 
            // pl_MasterVOL
            // 
            this.pl_MasterVOL.BackColor = System.Drawing.Color.Transparent;
            this.pl_MasterVOL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_MasterVOL.Location = new System.Drawing.Point(530, 31);
            this.pl_MasterVOL.Name = "pl_MasterVOL";
            this.pl_MasterVOL.Size = new System.Drawing.Size(41, 272);
            this.pl_MasterVOL.TabIndex = 25;
            this.pl_MasterVOL.Click += new System.EventHandler(this.pl_MasterVOL_Click);
            // 
            // pl_VOL4
            // 
            this.pl_VOL4.BackColor = System.Drawing.Color.Transparent;
            this.pl_VOL4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_VOL4.Location = new System.Drawing.Point(484, 284);
            this.pl_VOL4.Name = "pl_VOL4";
            this.pl_VOL4.Size = new System.Drawing.Size(32, 19);
            this.pl_VOL4.TabIndex = 24;
            this.pl_VOL4.Click += new System.EventHandler(this.pl_VOL4_Click);
            // 
            // pl_VOL3
            // 
            this.pl_VOL3.BackColor = System.Drawing.Color.Transparent;
            this.pl_VOL3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_VOL3.Location = new System.Drawing.Point(484, 195);
            this.pl_VOL3.Name = "pl_VOL3";
            this.pl_VOL3.Size = new System.Drawing.Size(32, 19);
            this.pl_VOL3.TabIndex = 23;
            this.pl_VOL3.Click += new System.EventHandler(this.pl_VOL3_Click);
            // 
            // pl_VOL2
            // 
            this.pl_VOL2.BackColor = System.Drawing.Color.Transparent;
            this.pl_VOL2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_VOL2.Location = new System.Drawing.Point(484, 126);
            this.pl_VOL2.Name = "pl_VOL2";
            this.pl_VOL2.Size = new System.Drawing.Size(31, 19);
            this.pl_VOL2.TabIndex = 22;
            this.pl_VOL2.Click += new System.EventHandler(this.pl_VOL2_Click);
            // 
            // pl_VOL1
            // 
            this.pl_VOL1.BackColor = System.Drawing.Color.Transparent;
            this.pl_VOL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_VOL1.Location = new System.Drawing.Point(484, 37);
            this.pl_VOL1.Name = "pl_VOL1";
            this.pl_VOL1.Size = new System.Drawing.Size(35, 19);
            this.pl_VOL1.TabIndex = 21;
            this.pl_VOL1.Click += new System.EventHandler(this.pl_VOL1_Click);
            // 
            // pl_2BQ
            // 
            this.pl_2BQ.BackColor = System.Drawing.Color.Transparent;
            this.pl_2BQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_2BQ.Location = new System.Drawing.Point(435, 284);
            this.pl_2BQ.Name = "pl_2BQ";
            this.pl_2BQ.Size = new System.Drawing.Size(36, 19);
            this.pl_2BQ.TabIndex = 20;
            this.pl_2BQ.Click += new System.EventHandler(this.pl_2BQ_Click);
            this.pl_2BQ.DoubleClick += new System.EventHandler(this.pl_2BQ_DoubleClick);
            // 
            // pl_1BQ_Sub
            // 
            this.pl_1BQ_Sub.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_Sub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_Sub.Location = new System.Drawing.Point(435, 195);
            this.pl_1BQ_Sub.Name = "pl_1BQ_Sub";
            this.pl_1BQ_Sub.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_Sub.TabIndex = 19;
            this.pl_1BQ_Sub.Click += new System.EventHandler(this.pl_1BQ_Sub_Click);
            this.pl_1BQ_Sub.DoubleClick += new System.EventHandler(this.pl_1BQ_Sub_DoubleClick);
            // 
            // pl_1BQ_ROut
            // 
            this.pl_1BQ_ROut.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_ROut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_ROut.Location = new System.Drawing.Point(435, 127);
            this.pl_1BQ_ROut.Name = "pl_1BQ_ROut";
            this.pl_1BQ_ROut.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_ROut.TabIndex = 18;
            this.pl_1BQ_ROut.Click += new System.EventHandler(this.pl_1BQ_ROut_Click);
            this.pl_1BQ_ROut.DoubleClick += new System.EventHandler(this.pl_1BQ_ROut_DoubleClick);
            // 
            // pl_1BQ_LOut
            // 
            this.pl_1BQ_LOut.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_LOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_LOut.Location = new System.Drawing.Point(434, 36);
            this.pl_1BQ_LOut.Name = "pl_1BQ_LOut";
            this.pl_1BQ_LOut.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LOut.TabIndex = 17;
            this.pl_1BQ_LOut.Click += new System.EventHandler(this.pl_1BQ_LOut_Click);
            this.pl_1BQ_LOut.DoubleClick += new System.EventHandler(this.pl_1BQ_LOut_DoubleClick);
            // 
            // pl_1BQ_LRMix_R
            // 
            this.pl_1BQ_LRMix_R.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_LRMix_R.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_LRMix_R.Location = new System.Drawing.Point(212, 141);
            this.pl_1BQ_LRMix_R.Name = "pl_1BQ_LRMix_R";
            this.pl_1BQ_LRMix_R.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LRMix_R.TabIndex = 16;
            this.pl_1BQ_LRMix_R.Click += new System.EventHandler(this.pl_1BQ_LRMix_R_Click);
            this.pl_1BQ_LRMix_R.DoubleClick += new System.EventHandler(this.pl_1BQ_LRMix_R_DoubleClick);
            // 
            // pl_1BQ_LRMix_L
            // 
            this.pl_1BQ_LRMix_L.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_LRMix_L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_LRMix_L.Location = new System.Drawing.Point(212, 50);
            this.pl_1BQ_LRMix_L.Name = "pl_1BQ_LRMix_L";
            this.pl_1BQ_LRMix_L.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LRMix_L.TabIndex = 15;
            this.pl_1BQ_LRMix_L.Click += new System.EventHandler(this.pl_1BQ_LRMix_L_Click);
            this.pl_1BQ_LRMix_L.DoubleClick += new System.EventHandler(this.pl_1BQ_LRMix_L_DoubleClick);
            // 
            // pl_1BQ_RIn
            // 
            this.pl_1BQ_RIn.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_RIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_RIn.Location = new System.Drawing.Point(96, 127);
            this.pl_1BQ_RIn.Name = "pl_1BQ_RIn";
            this.pl_1BQ_RIn.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_RIn.TabIndex = 14;
            this.pl_1BQ_RIn.Click += new System.EventHandler(this.pl_1BQ_RIn_Click);
            this.pl_1BQ_RIn.DoubleClick += new System.EventHandler(this.pl_1BQ_RIn_DoubleClick);
            // 
            // pl_1BQ_LIn
            // 
            this.pl_1BQ_LIn.BackColor = System.Drawing.Color.Transparent;
            this.pl_1BQ_LIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_1BQ_LIn.Location = new System.Drawing.Point(96, 36);
            this.pl_1BQ_LIn.Name = "pl_1BQ_LIn";
            this.pl_1BQ_LIn.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LIn.TabIndex = 13;
            this.pl_1BQ_LIn.Click += new System.EventHandler(this.pl_1BQ_LIn_Click);
            this.pl_1BQ_LIn.DoubleClick += new System.EventHandler(this.pl_1BQ_LIn_DoubleClick);
            // 
            // pl_NGSubOut
            // 
            this.pl_NGSubOut.BackColor = System.Drawing.Color.Transparent;
            this.pl_NGSubOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_NGSubOut.Location = new System.Drawing.Point(927, 268);
            this.pl_NGSubOut.Name = "pl_NGSubOut";
            this.pl_NGSubOut.Size = new System.Drawing.Size(33, 19);
            this.pl_NGSubOut.TabIndex = 12;
            this.pl_NGSubOut.Click += new System.EventHandler(this.pl_NGLOut_Click);
            // 
            // pl_NGROut
            // 
            this.pl_NGROut.BackColor = System.Drawing.Color.Transparent;
            this.pl_NGROut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_NGROut.Location = new System.Drawing.Point(931, 145);
            this.pl_NGROut.Name = "pl_NGROut";
            this.pl_NGROut.Size = new System.Drawing.Size(33, 19);
            this.pl_NGROut.TabIndex = 11;
            this.pl_NGROut.Click += new System.EventHandler(this.pl_NGLOut_Click);
            // 
            // pl_NGLOut
            // 
            this.pl_NGLOut.BackColor = System.Drawing.Color.Transparent;
            this.pl_NGLOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_NGLOut.Location = new System.Drawing.Point(931, 57);
            this.pl_NGLOut.Name = "pl_NGLOut";
            this.pl_NGLOut.Size = new System.Drawing.Size(33, 19);
            this.pl_NGLOut.TabIndex = 10;
            this.pl_NGLOut.Click += new System.EventHandler(this.pl_NGLOut_Click);
            // 
            // pl_HPFSubOut
            // 
            this.pl_HPFSubOut.BackColor = System.Drawing.Color.Transparent;
            this.pl_HPFSubOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_HPFSubOut.Location = new System.Drawing.Point(872, 268);
            this.pl_HPFSubOut.Name = "pl_HPFSubOut";
            this.pl_HPFSubOut.Size = new System.Drawing.Size(33, 19);
            this.pl_HPFSubOut.TabIndex = 9;
            this.pl_HPFSubOut.Click += new System.EventHandler(this.pl_HPFLOut_Click);
            // 
            // pl_HPFROut
            // 
            this.pl_HPFROut.BackColor = System.Drawing.Color.Transparent;
            this.pl_HPFROut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_HPFROut.Location = new System.Drawing.Point(875, 145);
            this.pl_HPFROut.Name = "pl_HPFROut";
            this.pl_HPFROut.Size = new System.Drawing.Size(33, 19);
            this.pl_HPFROut.TabIndex = 8;
            this.pl_HPFROut.Click += new System.EventHandler(this.pl_HPFLOut_Click);
            // 
            // pl_HPFLOut
            // 
            this.pl_HPFLOut.BackColor = System.Drawing.Color.Transparent;
            this.pl_HPFLOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_HPFLOut.Location = new System.Drawing.Point(875, 57);
            this.pl_HPFLOut.Name = "pl_HPFLOut";
            this.pl_HPFLOut.Size = new System.Drawing.Size(33, 19);
            this.pl_HPFLOut.TabIndex = 7;
            this.pl_HPFLOut.Click += new System.EventHandler(this.pl_HPFLOut_Click);
            // 
            // pl_HPF_RIn
            // 
            this.pl_HPF_RIn.BackColor = System.Drawing.Color.Transparent;
            this.pl_HPF_RIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_HPF_RIn.Location = new System.Drawing.Point(22, 127);
            this.pl_HPF_RIn.Name = "pl_HPF_RIn";
            this.pl_HPF_RIn.Size = new System.Drawing.Size(36, 21);
            this.pl_HPF_RIn.TabIndex = 3;
            this.pl_HPF_RIn.Click += new System.EventHandler(this.pl_HPFInput_Click);
            // 
            // pl_6EQ_R
            // 
            this.pl_6EQ_R.Location = new System.Drawing.Point(315, 126);
            this.pl_6EQ_R.Name = "pl_6EQ_R";
            this.pl_6EQ_R.Size = new System.Drawing.Size(35, 20);
            this.pl_6EQ_R.TabIndex = 2;
            this.pl_6EQ_R.Click += new System.EventHandler(this.pl_6EQ_R_Click);
            this.pl_6EQ_R.DoubleClick += new System.EventHandler(this.pl_6EQ_R_DoubleClick);
            // 
            // pl_HPF_LIn
            // 
            this.pl_HPF_LIn.BackColor = System.Drawing.Color.Transparent;
            this.pl_HPF_LIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_HPF_LIn.Location = new System.Drawing.Point(22, 35);
            this.pl_HPF_LIn.Name = "pl_HPF_LIn";
            this.pl_HPF_LIn.Size = new System.Drawing.Size(36, 21);
            this.pl_HPF_LIn.TabIndex = 1;
            this.pl_HPF_LIn.Click += new System.EventHandler(this.pl_HPFInput_Click);
            // 
            // pl_6EQ_L
            // 
            this.pl_6EQ_L.BackColor = System.Drawing.Color.Transparent;
            this.pl_6EQ_L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_6EQ_L.Location = new System.Drawing.Point(315, 36);
            this.pl_6EQ_L.Name = "pl_6EQ_L";
            this.pl_6EQ_L.Size = new System.Drawing.Size(35, 20);
            this.pl_6EQ_L.TabIndex = 0;
            this.pl_6EQ_L.Click += new System.EventHandler(this.pl_6EQ_L_Click);
            this.pl_6EQ_L.DoubleClick += new System.EventHandler(this.pl_6EQ_L_DoubleClick);
            // 
            // chb_v3Source
            // 
            this.chb_v3Source.AutoSize = true;
            this.chb_v3Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_v3Source.Font = new System.Drawing.Font("SimSun", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_v3Source.Location = new System.Drawing.Point(455, 179);
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
            this.splitContainer2.Size = new System.Drawing.Size(1080, 270);
            this.splitContainer2.SplitterDistance = 501;
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
            this.tabCtrl_SingleRegSetting.Size = new System.Drawing.Size(501, 270);
            this.tabCtrl_SingleRegSetting.TabIndex = 0;
            // 
            // tabP_SingleCtrl
            // 
            this.tabP_SingleCtrl.BackColor = System.Drawing.Color.White;
            this.tabP_SingleCtrl.Location = new System.Drawing.Point(4, 25);
            this.tabP_SingleCtrl.Name = "tabP_SingleCtrl";
            this.tabP_SingleCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_SingleCtrl.Size = new System.Drawing.Size(493, 241);
            this.tabP_SingleCtrl.TabIndex = 0;
            this.tabP_SingleCtrl.Text = "Single Control";
            // 
            // tabP_RegRW
            // 
            this.tabP_RegRW.BackColor = System.Drawing.Color.White;
            this.tabP_RegRW.Location = new System.Drawing.Point(4, 25);
            this.tabP_RegRW.Name = "tabP_RegRW";
            this.tabP_RegRW.Size = new System.Drawing.Size(493, 241);
            this.tabP_RegRW.TabIndex = 2;
            this.tabP_RegRW.Text = "Register R/W";
            // 
            // tabP_IICMemTool
            // 
            this.tabP_IICMemTool.BackColor = System.Drawing.Color.White;
            this.tabP_IICMemTool.Location = new System.Drawing.Point(4, 25);
            this.tabP_IICMemTool.Name = "tabP_IICMemTool";
            this.tabP_IICMemTool.Size = new System.Drawing.Size(493, 241);
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
            this.tabCtrl_Output.Size = new System.Drawing.Size(575, 270);
            this.tabCtrl_Output.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
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
            this.statusBar.Size = new System.Drawing.Size(1080, 24);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 758);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menu_main);
            this.MinimumSize = new System.Drawing.Size(1010, 630);
            this.Name = "MainForm";
            this.Text = "SGM4711 Eva_v0.38";
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.numUP_OpVoltage)).EndInit();
            this.tabP_AudioEngine.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabCtrl_SingleRegSetting.ResumeLayout(false);
            this.tabCtrl_Output.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabCtrl_SingleRegSetting;
        private System.Windows.Forms.TabPage tabP_SingleCtrl;
        private System.Windows.Forms.TabPage tabP_RegRW;
        private System.Windows.Forms.Panel pl_6EQ_L;
        private System.Windows.Forms.TabControl tabCtrl_Output;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pl_HPF_LIn;
        private System.Windows.Forms.Panel pl_6EQ_R;
        private System.Windows.Forms.Panel pl_HPF_RIn;
        private System.Windows.Forms.Panel pl_GainAfterClipper;
        private System.Windows.Forms.Panel pl_GainBeforeClipper;
        private System.Windows.Forms.Panel pl_DRC2;
        private System.Windows.Forms.Panel pl_DRC1;
        private System.Windows.Forms.Panel pl_MasterVOL;
        private System.Windows.Forms.Panel pl_VOL4;
        private System.Windows.Forms.Panel pl_VOL3;
        private System.Windows.Forms.Panel pl_VOL2;
        private System.Windows.Forms.Panel pl_VOL1;
        private System.Windows.Forms.Panel pl_2BQ;
        private System.Windows.Forms.Panel pl_1BQ_Sub;
        private System.Windows.Forms.Panel pl_1BQ_ROut;
        private System.Windows.Forms.Panel pl_1BQ_LOut;
        private System.Windows.Forms.Panel pl_1BQ_LRMix_R;
        private System.Windows.Forms.Panel pl_1BQ_LRMix_L;
        private System.Windows.Forms.Panel pl_1BQ_RIn;
        private System.Windows.Forms.Panel pl_1BQ_LIn;
        private System.Windows.Forms.Panel pl_NGSubOut;
        private System.Windows.Forms.Panel pl_NGROut;
        private System.Windows.Forms.Panel pl_NGLOut;
        private System.Windows.Forms.Panel pl_HPFSubOut;
        private System.Windows.Forms.Panel pl_HPFROut;
        private System.Windows.Forms.Panel pl_HPFLOut;
        private System.Windows.Forms.Panel pl_SubOutMixGain;
        private System.Windows.Forms.Panel pl_ROutMixGain;
        private System.Windows.Forms.Panel pl_LOutMixGain;
        private System.Windows.Forms.Panel pl_MidMixGain;
        private System.Windows.Forms.Panel pl_LRMixGain_Sub;
        private System.Windows.Forms.Panel pl_LRMixGain_R;
        private System.Windows.Forms.Panel pl_LRPreMixGain_R;
        private System.Windows.Forms.Panel pl_LRMixGain_L;
        private System.Windows.Forms.Panel pl_LRPreMixGain_L;
        private System.Windows.Forms.Panel pl_SubReverb;
        private System.Windows.Forms.Panel pl_RReverb;
        private System.Windows.Forms.Panel pl_LReverb;
        private System.Windows.Forms.TabControl tabCtrl_MainGUI;
        private System.Windows.Forms.TabPage tabP_systemConfig;
        private System.Windows.Forms.TabPage tabP_AudioEngine;
        private System.Windows.Forms.NumericUpDown numUP_OpVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ModeConfig;
        private System.Windows.Forms.ComboBox cmb_InterfaceConfig;
        private System.Windows.Forms.GroupBox grb_OpeStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_RefreshStatus;
        private System.Windows.Forms.Button btn_ClearStatus;
        private MDUserCtrls.Indicator indicator_MCLK;
        private MDUserCtrls.Indicator indicator_OTW;
        private MDUserCtrls.Indicator indicator_PSG;
        private MDUserCtrls.Indicator indicator_Clip;
        private MDUserCtrls.Indicator indicator_FrameSlip;
        private MDUserCtrls.Indicator indicator_WS;
        private MDUserCtrls.Indicator indicator_BCLK;
        private MDUserCtrls.Indicator indicator_PLLLock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SampleRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MDUserCtrls.Line line1;
        private MDUserCtrls.Line line2;
        private System.Windows.Forms.Button btn_InputMux;
        private System.Windows.Forms.Button btn_AudioEngine;
        private MDUserCtrls.Line line5;
        private MDUserCtrls.Line line3;
        private MDUserCtrls.Line line4;
        private MDUserCtrls.Line line6;
        private MDUserCtrls.Line line7;
        private MDUserCtrls.Line line8;
        private System.Windows.Forms.Button btn_MasterVolume;
        private System.Windows.Forms.TrackBar trb_MasterVolume;
        private System.Windows.Forms.CheckBox chb_MuteMasterVolume;
        private MDUserCtrls.Line line9;
        private MDUserCtrls.Line line10;
        private MDUserCtrls.Line line11;
        private System.Windows.Forms.Button btn_OutputMux;
        private MDUserCtrls.Line line14;
        private MDUserCtrls.Line line13;
        private MDUserCtrls.Line line15;
        private MDUserCtrls.Line line12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip myTips;
        private System.Windows.Forms.Button btn_InputMux_GUI;
        private System.Windows.Forms.Button btn_AudioEngine_GUI;
        private System.Windows.Forms.Button btn_OutputMux_GUI;
        private System.Windows.Forms.Button btn_backToDefault;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.CheckBox chb_Enable;
        private System.Windows.Forms.TabPage tabP_IICMemTool;
        private System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.ToolStripStatusLabel statusBar_DeviceConnected;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_FWVersion;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_VID;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_PID;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_BoardType;
        private System.Windows.Forms.ToolStripTextBox MenuItemTools_I2CAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.CheckBox chb_v3Source;
        private System.Windows.Forms.CheckBox chb_v4Source;
        private System.Windows.Forms.Label lbl_MasterVol;
        private System.Windows.Forms.TextBox txt_MasterVol;

    }
}

