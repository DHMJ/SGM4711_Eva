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
            this.selectDongleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptWriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pnl_Main = new System.Windows.Forms.Panel();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabCtrl_SingleRegSetting = new System.Windows.Forms.TabControl();
            this.tabP_SingleCtrl = new System.Windows.Forms.TabPage();
            this.tabP_RegRW = new System.Windows.Forms.TabPage();
            this.tabCtrl_Output = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menu_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabCtrl_SingleRegSetting.SuspendLayout();
            this.tabCtrl_Output.SuspendLayout();
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
            this.menu_main.Size = new System.Drawing.Size(994, 24);
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
            this.selectDongleToolStripMenuItem,
            this.scriptWriteToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // selectDongleToolStripMenuItem
            // 
            this.selectDongleToolStripMenuItem.Name = "selectDongleToolStripMenuItem";
            this.selectDongleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.selectDongleToolStripMenuItem.Text = "Select Dongle";
            // 
            // scriptWriteToolStripMenuItem
            // 
            this.scriptWriteToolStripMenuItem.Name = "scriptWriteToolStripMenuItem";
            this.scriptWriteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.scriptWriteToolStripMenuItem.Text = "Script Write";
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
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(994, 554);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 6;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Transparent;
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
            this.pnl_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(994, 352);
            this.pnl_Main.TabIndex = 0;
            // 
            // pl_SubReverb
            // 
            this.pl_SubReverb.Location = new System.Drawing.Point(397, 269);
            this.pl_SubReverb.Name = "pl_SubReverb";
            this.pl_SubReverb.Size = new System.Drawing.Size(13, 52);
            this.pl_SubReverb.TabIndex = 41;
            this.pl_SubReverb.Click += new System.EventHandler(this.pl_SubReverb_Click);
            // 
            // pl_RReverb
            // 
            this.pl_RReverb.Location = new System.Drawing.Point(420, 141);
            this.pl_RReverb.Name = "pl_RReverb";
            this.pl_RReverb.Size = new System.Drawing.Size(14, 26);
            this.pl_RReverb.TabIndex = 40;
            this.pl_RReverb.Click += new System.EventHandler(this.pl_LReverb_Click);
            // 
            // pl_LReverb
            // 
            this.pl_LReverb.Location = new System.Drawing.Point(418, 56);
            this.pl_LReverb.Name = "pl_LReverb";
            this.pl_LReverb.Size = new System.Drawing.Size(14, 26);
            this.pl_LReverb.TabIndex = 39;
            this.pl_LReverb.Click += new System.EventHandler(this.pl_LReverb_Click);
            // 
            // pl_SubOutMixGain
            // 
            this.pl_SubOutMixGain.Location = new System.Drawing.Point(697, 249);
            this.pl_SubOutMixGain.Name = "pl_SubOutMixGain";
            this.pl_SubOutMixGain.Size = new System.Drawing.Size(23, 56);
            this.pl_SubOutMixGain.TabIndex = 38;
            this.pl_SubOutMixGain.Click += new System.EventHandler(this.pl_SubOutMixGain_Click);
            // 
            // pl_ROutMixGain
            // 
            this.pl_ROutMixGain.Location = new System.Drawing.Point(695, 122);
            this.pl_ROutMixGain.Name = "pl_ROutMixGain";
            this.pl_ROutMixGain.Size = new System.Drawing.Size(23, 63);
            this.pl_ROutMixGain.TabIndex = 37;
            this.pl_ROutMixGain.Click += new System.EventHandler(this.pl_ROutMixGain_Click);
            // 
            // pl_LOutMixGain
            // 
            this.pl_LOutMixGain.Location = new System.Drawing.Point(696, 34);
            this.pl_LOutMixGain.Name = "pl_LOutMixGain";
            this.pl_LOutMixGain.Size = new System.Drawing.Size(23, 63);
            this.pl_LOutMixGain.TabIndex = 36;
            this.pl_LOutMixGain.Click += new System.EventHandler(this.pl_LOutMixGain_Click);
            // 
            // pl_MidMixGain
            // 
            this.pl_MidMixGain.Location = new System.Drawing.Point(378, 176);
            this.pl_MidMixGain.Name = "pl_MidMixGain";
            this.pl_MidMixGain.Size = new System.Drawing.Size(23, 59);
            this.pl_MidMixGain.TabIndex = 35;
            this.pl_MidMixGain.Click += new System.EventHandler(this.pl_MidMixGain_Click);
            // 
            // pl_LRMixGain_Sub
            // 
            this.pl_LRMixGain_Sub.Location = new System.Drawing.Point(101, 276);
            this.pl_LRMixGain_Sub.Name = "pl_LRMixGain_Sub";
            this.pl_LRMixGain_Sub.Size = new System.Drawing.Size(23, 59);
            this.pl_LRMixGain_Sub.TabIndex = 34;
            this.pl_LRMixGain_Sub.Click += new System.EventHandler(this.pl_LRMixGain_Sub_Click);
            // 
            // pl_LRMixGain_R
            // 
            this.pl_LRMixGain_R.Location = new System.Drawing.Point(253, 107);
            this.pl_LRMixGain_R.Name = "pl_LRMixGain_R";
            this.pl_LRMixGain_R.Size = new System.Drawing.Size(23, 59);
            this.pl_LRMixGain_R.TabIndex = 33;
            this.pl_LRMixGain_R.Click += new System.EventHandler(this.pl_LRMixGain_R_Click);
            // 
            // pl_LRPreMixGain_R
            // 
            this.pl_LRPreMixGain_R.Location = new System.Drawing.Point(164, 123);
            this.pl_LRPreMixGain_R.Name = "pl_LRPreMixGain_R";
            this.pl_LRPreMixGain_R.Size = new System.Drawing.Size(23, 59);
            this.pl_LRPreMixGain_R.TabIndex = 32;
            this.pl_LRPreMixGain_R.Click += new System.EventHandler(this.pl_LRPreMixGain_R_Click);
            // 
            // pl_LRMixGain_L
            // 
            this.pl_LRMixGain_L.Location = new System.Drawing.Point(253, 15);
            this.pl_LRMixGain_L.Name = "pl_LRMixGain_L";
            this.pl_LRMixGain_L.Size = new System.Drawing.Size(23, 59);
            this.pl_LRMixGain_L.TabIndex = 31;
            this.pl_LRMixGain_L.Click += new System.EventHandler(this.pl_LRMixGain_L_Click);
            // 
            // pl_LRPreMixGain_L
            // 
            this.pl_LRPreMixGain_L.Location = new System.Drawing.Point(162, 31);
            this.pl_LRPreMixGain_L.Name = "pl_LRPreMixGain_L";
            this.pl_LRPreMixGain_L.Size = new System.Drawing.Size(23, 59);
            this.pl_LRPreMixGain_L.TabIndex = 30;
            this.pl_LRPreMixGain_L.Click += new System.EventHandler(this.pl_LRPreMixGain_L_Click);
            // 
            // pl_GainAfterClipper
            // 
            this.pl_GainAfterClipper.Location = new System.Drawing.Point(824, 35);
            this.pl_GainAfterClipper.Name = "pl_GainAfterClipper";
            this.pl_GainAfterClipper.Size = new System.Drawing.Size(31, 155);
            this.pl_GainAfterClipper.TabIndex = 29;
            this.pl_GainAfterClipper.Click += new System.EventHandler(this.pl_GainAfterClipper_Click);
            // 
            // pl_GainBeforeClipper
            // 
            this.pl_GainBeforeClipper.Location = new System.Drawing.Point(741, 34);
            this.pl_GainBeforeClipper.Name = "pl_GainBeforeClipper";
            this.pl_GainBeforeClipper.Size = new System.Drawing.Size(31, 155);
            this.pl_GainBeforeClipper.TabIndex = 28;
            this.pl_GainBeforeClipper.Click += new System.EventHandler(this.pl_GainBeforeClipper_Click);
            // 
            // pl_DRC2
            // 
            this.pl_DRC2.Location = new System.Drawing.Point(590, 193);
            this.pl_DRC2.Name = "pl_DRC2";
            this.pl_DRC2.Size = new System.Drawing.Size(51, 112);
            this.pl_DRC2.TabIndex = 27;
            this.pl_DRC2.Click += new System.EventHandler(this.pl_DRC2_Click);
            this.pl_DRC2.DoubleClick += new System.EventHandler(this.pl_DRC2_DoubleClick);
            // 
            // pl_DRC1
            // 
            this.pl_DRC1.Location = new System.Drawing.Point(590, 34);
            this.pl_DRC1.Name = "pl_DRC1";
            this.pl_DRC1.Size = new System.Drawing.Size(51, 112);
            this.pl_DRC1.TabIndex = 26;
            this.pl_DRC1.Click += new System.EventHandler(this.pl_DRC1_Click);
            this.pl_DRC1.DoubleClick += new System.EventHandler(this.pl_DRC1_DoubleClick);
            // 
            // pl_MasterVOL
            // 
            this.pl_MasterVOL.Location = new System.Drawing.Point(530, 31);
            this.pl_MasterVOL.Name = "pl_MasterVOL";
            this.pl_MasterVOL.Size = new System.Drawing.Size(41, 272);
            this.pl_MasterVOL.TabIndex = 25;
            this.pl_MasterVOL.Click += new System.EventHandler(this.pl_MasterVOL_Click);
            // 
            // pl_VOL4
            // 
            this.pl_VOL4.Location = new System.Drawing.Point(484, 284);
            this.pl_VOL4.Name = "pl_VOL4";
            this.pl_VOL4.Size = new System.Drawing.Size(32, 19);
            this.pl_VOL4.TabIndex = 24;
            this.pl_VOL4.Click += new System.EventHandler(this.pl_VOL4_Click);
            // 
            // pl_VOL3
            // 
            this.pl_VOL3.Location = new System.Drawing.Point(484, 195);
            this.pl_VOL3.Name = "pl_VOL3";
            this.pl_VOL3.Size = new System.Drawing.Size(32, 19);
            this.pl_VOL3.TabIndex = 23;
            this.pl_VOL3.Click += new System.EventHandler(this.pl_VOL3_Click);
            // 
            // pl_VOL2
            // 
            this.pl_VOL2.Location = new System.Drawing.Point(484, 126);
            this.pl_VOL2.Name = "pl_VOL2";
            this.pl_VOL2.Size = new System.Drawing.Size(31, 19);
            this.pl_VOL2.TabIndex = 22;
            this.pl_VOL2.Click += new System.EventHandler(this.pl_VOL2_Click);
            // 
            // pl_VOL1
            // 
            this.pl_VOL1.Location = new System.Drawing.Point(484, 37);
            this.pl_VOL1.Name = "pl_VOL1";
            this.pl_VOL1.Size = new System.Drawing.Size(35, 19);
            this.pl_VOL1.TabIndex = 21;
            this.pl_VOL1.Click += new System.EventHandler(this.pl_VOL1_Click);
            // 
            // pl_2BQ
            // 
            this.pl_2BQ.Location = new System.Drawing.Point(435, 284);
            this.pl_2BQ.Name = "pl_2BQ";
            this.pl_2BQ.Size = new System.Drawing.Size(36, 19);
            this.pl_2BQ.TabIndex = 20;
            this.pl_2BQ.Click += new System.EventHandler(this.pl_2BQ_Click);
            this.pl_2BQ.DoubleClick += new System.EventHandler(this.pl_2BQ_DoubleClick);
            // 
            // pl_1BQ_Sub
            // 
            this.pl_1BQ_Sub.Location = new System.Drawing.Point(435, 195);
            this.pl_1BQ_Sub.Name = "pl_1BQ_Sub";
            this.pl_1BQ_Sub.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_Sub.TabIndex = 19;
            this.pl_1BQ_Sub.Click += new System.EventHandler(this.pl_1BQ_Sub_Click);
            this.pl_1BQ_Sub.DoubleClick += new System.EventHandler(this.pl_1BQ_Sub_DoubleClick);
            // 
            // pl_1BQ_ROut
            // 
            this.pl_1BQ_ROut.Location = new System.Drawing.Point(435, 127);
            this.pl_1BQ_ROut.Name = "pl_1BQ_ROut";
            this.pl_1BQ_ROut.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_ROut.TabIndex = 18;
            this.pl_1BQ_ROut.Click += new System.EventHandler(this.pl_1BQ_ROut_Click);
            this.pl_1BQ_ROut.DoubleClick += new System.EventHandler(this.pl_1BQ_ROut_DoubleClick);
            // 
            // pl_1BQ_LOut
            // 
            this.pl_1BQ_LOut.Location = new System.Drawing.Point(434, 36);
            this.pl_1BQ_LOut.Name = "pl_1BQ_LOut";
            this.pl_1BQ_LOut.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LOut.TabIndex = 17;
            this.pl_1BQ_LOut.Click += new System.EventHandler(this.pl_1BQ_LOut_Click);
            this.pl_1BQ_LOut.DoubleClick += new System.EventHandler(this.pl_1BQ_LOut_DoubleClick);
            // 
            // pl_1BQ_LRMix_R
            // 
            this.pl_1BQ_LRMix_R.Location = new System.Drawing.Point(212, 141);
            this.pl_1BQ_LRMix_R.Name = "pl_1BQ_LRMix_R";
            this.pl_1BQ_LRMix_R.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LRMix_R.TabIndex = 16;
            this.pl_1BQ_LRMix_R.Click += new System.EventHandler(this.pl_1BQ_LRMix_R_Click);
            this.pl_1BQ_LRMix_R.DoubleClick += new System.EventHandler(this.pl_1BQ_LRMix_R_DoubleClick);
            // 
            // pl_1BQ_LRMix_L
            // 
            this.pl_1BQ_LRMix_L.Location = new System.Drawing.Point(212, 50);
            this.pl_1BQ_LRMix_L.Name = "pl_1BQ_LRMix_L";
            this.pl_1BQ_LRMix_L.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LRMix_L.TabIndex = 15;
            this.pl_1BQ_LRMix_L.Click += new System.EventHandler(this.pl_1BQ_LRMix_L_Click);
            this.pl_1BQ_LRMix_L.DoubleClick += new System.EventHandler(this.pl_1BQ_LRMix_L_DoubleClick);
            // 
            // pl_1BQ_RIn
            // 
            this.pl_1BQ_RIn.Location = new System.Drawing.Point(96, 127);
            this.pl_1BQ_RIn.Name = "pl_1BQ_RIn";
            this.pl_1BQ_RIn.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_RIn.TabIndex = 14;
            this.pl_1BQ_RIn.Click += new System.EventHandler(this.pl_1BQ_RIn_Click);
            this.pl_1BQ_RIn.DoubleClick += new System.EventHandler(this.pl_1BQ_RIn_DoubleClick);
            // 
            // pl_1BQ_LIn
            // 
            this.pl_1BQ_LIn.Location = new System.Drawing.Point(96, 36);
            this.pl_1BQ_LIn.Name = "pl_1BQ_LIn";
            this.pl_1BQ_LIn.Size = new System.Drawing.Size(36, 19);
            this.pl_1BQ_LIn.TabIndex = 13;
            this.pl_1BQ_LIn.Click += new System.EventHandler(this.pl_1BQ_LIn_Click);
            this.pl_1BQ_LIn.DoubleClick += new System.EventHandler(this.pl_1BQ_LIn_DoubleClick);
            // 
            // pl_NGSubOut
            // 
            this.pl_NGSubOut.Location = new System.Drawing.Point(927, 268);
            this.pl_NGSubOut.Name = "pl_NGSubOut";
            this.pl_NGSubOut.Size = new System.Drawing.Size(33, 19);
            this.pl_NGSubOut.TabIndex = 12;
            this.pl_NGSubOut.Click += new System.EventHandler(this.pl_NGLOut_Click);
            // 
            // pl_NGROut
            // 
            this.pl_NGROut.Location = new System.Drawing.Point(931, 145);
            this.pl_NGROut.Name = "pl_NGROut";
            this.pl_NGROut.Size = new System.Drawing.Size(33, 19);
            this.pl_NGROut.TabIndex = 11;
            this.pl_NGROut.Click += new System.EventHandler(this.pl_NGLOut_Click);
            // 
            // pl_NGLOut
            // 
            this.pl_NGLOut.Location = new System.Drawing.Point(931, 57);
            this.pl_NGLOut.Name = "pl_NGLOut";
            this.pl_NGLOut.Size = new System.Drawing.Size(33, 19);
            this.pl_NGLOut.TabIndex = 10;
            this.pl_NGLOut.Click += new System.EventHandler(this.pl_NGLOut_Click);
            // 
            // pl_HPFSubOut
            // 
            this.pl_HPFSubOut.Location = new System.Drawing.Point(872, 268);
            this.pl_HPFSubOut.Name = "pl_HPFSubOut";
            this.pl_HPFSubOut.Size = new System.Drawing.Size(33, 19);
            this.pl_HPFSubOut.TabIndex = 9;
            this.pl_HPFSubOut.Click += new System.EventHandler(this.pl_HPFLOut_Click);
            // 
            // pl_HPFROut
            // 
            this.pl_HPFROut.Location = new System.Drawing.Point(875, 145);
            this.pl_HPFROut.Name = "pl_HPFROut";
            this.pl_HPFROut.Size = new System.Drawing.Size(33, 19);
            this.pl_HPFROut.TabIndex = 8;
            this.pl_HPFROut.Click += new System.EventHandler(this.pl_HPFLOut_Click);
            // 
            // pl_HPFLOut
            // 
            this.pl_HPFLOut.Location = new System.Drawing.Point(875, 57);
            this.pl_HPFLOut.Name = "pl_HPFLOut";
            this.pl_HPFLOut.Size = new System.Drawing.Size(33, 19);
            this.pl_HPFLOut.TabIndex = 7;
            this.pl_HPFLOut.Click += new System.EventHandler(this.pl_HPFLOut_Click);
            // 
            // pl_HPF_RIn
            // 
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
            this.pl_HPF_LIn.Location = new System.Drawing.Point(22, 35);
            this.pl_HPF_LIn.Name = "pl_HPF_LIn";
            this.pl_HPF_LIn.Size = new System.Drawing.Size(36, 21);
            this.pl_HPF_LIn.TabIndex = 1;
            this.pl_HPF_LIn.Click += new System.EventHandler(this.pl_HPFInput_Click);
            // 
            // pl_6EQ_L
            // 
            this.pl_6EQ_L.Location = new System.Drawing.Point(315, 36);
            this.pl_6EQ_L.Name = "pl_6EQ_L";
            this.pl_6EQ_L.Size = new System.Drawing.Size(35, 20);
            this.pl_6EQ_L.TabIndex = 0;
            this.pl_6EQ_L.Click += new System.EventHandler(this.pl_6EQ_L_Click);
            this.pl_6EQ_L.DoubleClick += new System.EventHandler(this.pl_6EQ_L_DoubleClick);
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
            this.splitContainer2.Size = new System.Drawing.Size(994, 198);
            this.splitContainer2.SplitterDistance = 462;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabCtrl_SingleRegSetting
            // 
            this.tabCtrl_SingleRegSetting.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrl_SingleRegSetting.Controls.Add(this.tabP_SingleCtrl);
            this.tabCtrl_SingleRegSetting.Controls.Add(this.tabP_RegRW);
            this.tabCtrl_SingleRegSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl_SingleRegSetting.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl_SingleRegSetting.Name = "tabCtrl_SingleRegSetting";
            this.tabCtrl_SingleRegSetting.SelectedIndex = 0;
            this.tabCtrl_SingleRegSetting.Size = new System.Drawing.Size(462, 198);
            this.tabCtrl_SingleRegSetting.TabIndex = 0;
            // 
            // tabP_SingleCtrl
            // 
            this.tabP_SingleCtrl.BackColor = System.Drawing.Color.White;
            this.tabP_SingleCtrl.Location = new System.Drawing.Point(4, 25);
            this.tabP_SingleCtrl.Name = "tabP_SingleCtrl";
            this.tabP_SingleCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_SingleCtrl.Size = new System.Drawing.Size(454, 169);
            this.tabP_SingleCtrl.TabIndex = 0;
            this.tabP_SingleCtrl.Text = "Single Control";
            // 
            // tabP_RegRW
            // 
            this.tabP_RegRW.BackColor = System.Drawing.Color.White;
            this.tabP_RegRW.Location = new System.Drawing.Point(4, 25);
            this.tabP_RegRW.Name = "tabP_RegRW";
            this.tabP_RegRW.Size = new System.Drawing.Size(454, 153);
            this.tabP_RegRW.TabIndex = 2;
            this.tabP_RegRW.Text = "Register R/W";
            // 
            // tabCtrl_Output
            // 
            this.tabCtrl_Output.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrl_Output.Controls.Add(this.tabPage1);
            this.tabCtrl_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl_Output.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl_Output.Name = "tabCtrl_Output";
            this.tabCtrl_Output.SelectedIndex = 0;
            this.tabCtrl_Output.Size = new System.Drawing.Size(528, 198);
            this.tabCtrl_Output.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menu_main);
            this.MinimumSize = new System.Drawing.Size(1010, 616);
            this.Name = "MainForm";
            this.Text = "SGM4711 Eva_v0.1";
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabCtrl_SingleRegSetting.ResumeLayout(false);
            this.tabCtrl_Output.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem selectDongleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptWriteToolStripMenuItem;
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

    }
}

