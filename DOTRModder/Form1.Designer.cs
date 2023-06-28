using System.Data;

namespace DOTRModder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabPage tbMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cbCustomMaps = new CheckBox();
            cb_fastIntro = new CheckBox();
            btn_DefaultSettings = new Button();
            num_LpCap = new NumericUpDown();
            cb_AdditionalSlotRewards = new CheckBox();
            lbl_Options = new Label();
            label1 = new Label();
            btn_Start = new Button();
            lblTeamFirst = new Label();
            CurrentStatus = new Label();
            cbo_ForceStartSide = new ComboBox();
            cb_RemoveNegetiveExp = new CheckBox();
            cb_ForceStartSide = new CheckBox();
            cb_LpCap = new CheckBox();
            cb_SideFirst = new CheckBox();
            cb_RemoveSlotRng = new CheckBox();
            cbo_TeamFirstTurn = new ComboBox();
            cb_ExpandedZoom = new CheckBox();
            num_Terrain = new NumericUpDown();
            cb_AllFusions = new CheckBox();
            cb_Terrain = new CheckBox();
            cb_ChangeMakoBattleTheme = new CheckBox();
            num_Reincarnation = new NumericUpDown();
            cb_AIPassFix = new CheckBox();
            cb_Reincarnation = new CheckBox();
            cb_AllowAllDuels = new CheckBox();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tcMaster = new TabControl();
            tbFusions = new TabPage();
            label2 = new Label();
            tabSlotRewards = new TabPage();
            btnSlotDefault = new Button();
            btn_SaveSlots = new Button();
            SlotRewardsDataGridView = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            threeInARow = new DataGridViewComboBoxColumn();
            Reward = new DataGridViewComboBoxColumn();
            tbEditMap = new TabPage();
            scEditMapMain = new SplitContainer();
            scEditMapToSelect = new SplitContainer();
            lblMapToSelect = new Label();
            lbMapSelection = new ListBox();
            scEditMapTiles = new SplitContainer();
            label3 = new Label();
            LklblGithub = new LinkLabel();
            lblMapCurrentISOResult = new Label();
            lblMapCurrentlyLoadedISO = new Label();
            btnSaveMap = new Button();
            btnMapLoadISo = new Button();
            pbSelectedTile = new PictureBox();
            lblSelectedTile = new Label();
            tbPallete = new TableLayoutPanel();
            pbCrush = new PictureBox();
            pbLab = new PictureBox();
            pbNormal = new PictureBox();
            pbToon = new PictureBox();
            pbYami = new PictureBox();
            pbSea = new PictureBox();
            pbMountain = new PictureBox();
            pbForest = new PictureBox();
            pbMeadow = new PictureBox();
            pbWasteland = new PictureBox();
            lblMapSideWhite = new Label();
            lblMapSideRed = new Label();
            lblMapName = new Label();
            RefreshEditor = new System.Windows.Forms.Timer(components);
            tbMain = new TabPage();
            tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_LpCap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Terrain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Reincarnation).BeginInit();
            menuStrip1.SuspendLayout();
            tcMaster.SuspendLayout();
            tbFusions.SuspendLayout();
            tabSlotRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SlotRewardsDataGridView).BeginInit();
            tbEditMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scEditMapMain).BeginInit();
            scEditMapMain.Panel1.SuspendLayout();
            scEditMapMain.Panel2.SuspendLayout();
            scEditMapMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scEditMapToSelect).BeginInit();
            scEditMapToSelect.Panel1.SuspendLayout();
            scEditMapToSelect.Panel2.SuspendLayout();
            scEditMapToSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scEditMapTiles).BeginInit();
            scEditMapTiles.Panel1.SuspendLayout();
            scEditMapTiles.Panel2.SuspendLayout();
            scEditMapTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSelectedTile).BeginInit();
            tbPallete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCrush).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbToon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYami).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMountain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbForest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMeadow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWasteland).BeginInit();
            SuspendLayout();
            // 
            // tbMain
            // 
            tbMain.BackColor = Color.LightGray;
            tbMain.BackgroundImageLayout = ImageLayout.Stretch;
            tbMain.Controls.Add(cbCustomMaps);
            tbMain.Controls.Add(cb_fastIntro);
            tbMain.Controls.Add(btn_DefaultSettings);
            tbMain.Controls.Add(num_LpCap);
            tbMain.Controls.Add(cb_AdditionalSlotRewards);
            tbMain.Controls.Add(lbl_Options);
            tbMain.Controls.Add(label1);
            tbMain.Controls.Add(btn_Start);
            tbMain.Controls.Add(lblTeamFirst);
            tbMain.Controls.Add(CurrentStatus);
            tbMain.Controls.Add(cbo_ForceStartSide);
            tbMain.Controls.Add(cb_RemoveNegetiveExp);
            tbMain.Controls.Add(cb_ForceStartSide);
            tbMain.Controls.Add(cb_LpCap);
            tbMain.Controls.Add(cb_SideFirst);
            tbMain.Controls.Add(cb_RemoveSlotRng);
            tbMain.Controls.Add(cbo_TeamFirstTurn);
            tbMain.Controls.Add(cb_ExpandedZoom);
            tbMain.Controls.Add(num_Terrain);
            tbMain.Controls.Add(cb_AllFusions);
            tbMain.Controls.Add(cb_Terrain);
            tbMain.Controls.Add(cb_ChangeMakoBattleTheme);
            tbMain.Controls.Add(num_Reincarnation);
            tbMain.Controls.Add(cb_AIPassFix);
            tbMain.Controls.Add(cb_Reincarnation);
            tbMain.Controls.Add(cb_AllowAllDuels);
            tbMain.Controls.Add(panel1);
            tbMain.Location = new Point(4, 32);
            tbMain.Name = "tbMain";
            tbMain.Padding = new Padding(3);
            tbMain.Size = new Size(1008, 671);
            tbMain.TabIndex = 0;
            tbMain.Text = "Main";
            // 
            // cbCustomMaps
            // 
            cbCustomMaps.AutoSize = true;
            cbCustomMaps.Location = new Point(31, 401);
            cbCustomMaps.Name = "cbCustomMaps";
            cbCustomMaps.Size = new Size(149, 24);
            cbCustomMaps.TabIndex = 72;
            cbCustomMaps.Text = "Use Custom Maps";
            cbCustomMaps.UseVisualStyleBackColor = true;
            cbCustomMaps.CheckedChanged += cbCustomMaps_CheckedChanged;
            // 
            // cb_fastIntro
            // 
            cb_fastIntro.AutoSize = true;
            cb_fastIntro.Location = new Point(31, 157);
            cb_fastIntro.Name = "cb_fastIntro";
            cb_fastIntro.Size = new Size(202, 24);
            cb_fastIntro.TabIndex = 71;
            cb_fastIntro.Text = "Fast Intro (recommended)";
            cb_fastIntro.UseVisualStyleBackColor = true;
            cb_fastIntro.CheckedChanged += FastIntro_CheckedChanged;
            // 
            // btn_DefaultSettings
            // 
            btn_DefaultSettings.Location = new Point(31, 582);
            btn_DefaultSettings.Name = "btn_DefaultSettings";
            btn_DefaultSettings.Size = new Size(124, 44);
            btn_DefaultSettings.TabIndex = 70;
            btn_DefaultSettings.Text = "Default Settings";
            btn_DefaultSettings.UseVisualStyleBackColor = true;
            btn_DefaultSettings.Click += btn_DefaultSettings_Click;
            // 
            // num_LpCap
            // 
            num_LpCap.Location = new Point(766, 155);
            num_LpCap.Maximum = new decimal(new int[] { 65000, 0, 0, 0 });
            num_LpCap.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_LpCap.Name = "num_LpCap";
            num_LpCap.Size = new Size(150, 27);
            num_LpCap.TabIndex = 58;
            num_LpCap.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            num_LpCap.ValueChanged += num_LpCap_ValueChanged;
            // 
            // cb_AdditionalSlotRewards
            // 
            cb_AdditionalSlotRewards.AutoSize = true;
            cb_AdditionalSlotRewards.Location = new Point(31, 371);
            cb_AdditionalSlotRewards.Name = "cb_AdditionalSlotRewards";
            cb_AdditionalSlotRewards.Size = new Size(223, 24);
            cb_AdditionalSlotRewards.TabIndex = 69;
            cb_AdditionalSlotRewards.Text = "Add Additional Slot Rewards";
            cb_AdditionalSlotRewards.UseVisualStyleBackColor = true;
            cb_AdditionalSlotRewards.CheckedChanged += cb_AdditionalSlotRewards_CheckedChanged;
            // 
            // lbl_Options
            // 
            lbl_Options.AutoSize = true;
            lbl_Options.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Options.Location = new Point(31, 81);
            lbl_Options.Name = "lbl_Options";
            lbl_Options.Size = new Size(161, 25);
            lbl_Options.TabIndex = 51;
            lbl_Options.Text = "Modding Options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 191);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 68;
            label1.Text = "For new games";
            // 
            // btn_Start
            // 
            btn_Start.BackColor = Color.White;
            btn_Start.Location = new Point(766, 582);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(127, 44);
            btn_Start.TabIndex = 47;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // lblTeamFirst
            // 
            lblTeamFirst.AutoSize = true;
            lblTeamFirst.Location = new Point(457, 86);
            lblTeamFirst.Name = "lblTeamFirst";
            lblTeamFirst.Size = new Size(238, 20);
            lblTeamFirst.TabIndex = 67;
            lblTeamFirst.Text = "Leave unchecked to always go first";
            // 
            // CurrentStatus
            // 
            CurrentStatus.AutoSize = true;
            CurrentStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentStatus.Location = new Point(766, 462);
            CurrentStatus.Name = "CurrentStatus";
            CurrentStatus.Size = new Size(127, 25);
            CurrentStatus.TabIndex = 48;
            CurrentStatus.Text = "Current Status:";
            // 
            // cbo_ForceStartSide
            // 
            cbo_ForceStartSide.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_ForceStartSide.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_ForceStartSide.ImeMode = ImeMode.NoControl;
            cbo_ForceStartSide.Items.AddRange(new object[] { "Red", "White" });
            cbo_ForceStartSide.Location = new Point(457, 244);
            cbo_ForceStartSide.Name = "cbo_ForceStartSide";
            cbo_ForceStartSide.Size = new Size(151, 28);
            cbo_ForceStartSide.TabIndex = 66;
            cbo_ForceStartSide.Text = "Red";
            cbo_ForceStartSide.SelectedIndexChanged += cbo_ForceStartSide_SelectedIndexChanged;
            // 
            // cb_RemoveNegetiveExp
            // 
            cb_RemoveNegetiveExp.AutoSize = true;
            cb_RemoveNegetiveExp.Location = new Point(31, 187);
            cb_RemoveNegetiveExp.Name = "cb_RemoveNegetiveExp";
            cb_RemoveNegetiveExp.Size = new Size(177, 24);
            cb_RemoveNegetiveExp.TabIndex = 49;
            cb_RemoveNegetiveExp.Text = "Remove Negetive Exp";
            cb_RemoveNegetiveExp.UseVisualStyleBackColor = true;
            cb_RemoveNegetiveExp.CheckedChanged += cb_RemoveNegetiveExp_CheckedChanged;
            // 
            // cb_ForceStartSide
            // 
            cb_ForceStartSide.AutoSize = true;
            cb_ForceStartSide.Location = new Point(457, 214);
            cb_ForceStartSide.Name = "cb_ForceStartSide";
            cb_ForceStartSide.Size = new Size(136, 24);
            cb_ForceStartSide.TabIndex = 65;
            cb_ForceStartSide.Text = "Force Rose Side";
            cb_ForceStartSide.UseVisualStyleBackColor = true;
            cb_ForceStartSide.CheckedChanged += cbTeamStart_CheckedChanged;
            // 
            // cb_LpCap
            // 
            cb_LpCap.AutoSize = true;
            cb_LpCap.Location = new Point(766, 114);
            cb_LpCap.Name = "cb_LpCap";
            cb_LpCap.Size = new Size(130, 24);
            cb_LpCap.TabIndex = 50;
            cb_LpCap.Text = "Change LP Cap";
            cb_LpCap.UseVisualStyleBackColor = true;
            cb_LpCap.CheckedChanged += cb_LpCap_CheckedChanged;
            // 
            // cb_SideFirst
            // 
            cb_SideFirst.AutoSize = true;
            cb_SideFirst.Location = new Point(457, 114);
            cb_SideFirst.Name = "cb_SideFirst";
            cb_SideFirst.Size = new Size(173, 24);
            cb_SideFirst.TabIndex = 64;
            cb_SideFirst.Text = "Which Side Goes First";
            cb_SideFirst.UseVisualStyleBackColor = true;
            cb_SideFirst.CheckedChanged += cbTeamFirstTurn_CheckedChanged;
            // 
            // cb_RemoveSlotRng
            // 
            cb_RemoveSlotRng.AutoSize = true;
            cb_RemoveSlotRng.Location = new Point(31, 218);
            cb_RemoveSlotRng.Name = "cb_RemoveSlotRng";
            cb_RemoveSlotRng.Size = new Size(189, 24);
            cb_RemoveSlotRng.TabIndex = 52;
            cb_RemoveSlotRng.Text = "Remove RNG from slots";
            cb_RemoveSlotRng.UseVisualStyleBackColor = true;
            cb_RemoveSlotRng.CheckedChanged += cb_RemoveSlotRng_CheckedChanged;
            // 
            // cbo_TeamFirstTurn
            // 
            cbo_TeamFirstTurn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_TeamFirstTurn.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_TeamFirstTurn.ForeColor = SystemColors.Desktop;
            cbo_TeamFirstTurn.Items.AddRange(new object[] { "Red", "White" });
            cbo_TeamFirstTurn.Location = new Point(457, 144);
            cbo_TeamFirstTurn.Name = "cbo_TeamFirstTurn";
            cbo_TeamFirstTurn.Size = new Size(151, 28);
            cbo_TeamFirstTurn.TabIndex = 63;
            cbo_TeamFirstTurn.Text = "Red";
            cbo_TeamFirstTurn.SelectedIndexChanged += cboTeamFirstTurn_SelectedIndexChanged;
            // 
            // cb_ExpandedZoom
            // 
            cb_ExpandedZoom.AutoSize = true;
            cb_ExpandedZoom.Location = new Point(31, 248);
            cb_ExpandedZoom.Name = "cb_ExpandedZoom";
            cb_ExpandedZoom.Size = new Size(141, 24);
            cb_ExpandedZoom.TabIndex = 53;
            cb_ExpandedZoom.Text = "Expanded Zoom";
            cb_ExpandedZoom.UseVisualStyleBackColor = true;
            cb_ExpandedZoom.CheckedChanged += cb_ExpandedZoom_CheckedChanged;
            // 
            // num_Terrain
            // 
            num_Terrain.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            num_Terrain.Location = new Point(766, 340);
            num_Terrain.Maximum = new decimal(new int[] { 9900, 0, 0, 0 });
            num_Terrain.Name = "num_Terrain";
            num_Terrain.Size = new Size(150, 27);
            num_Terrain.TabIndex = 62;
            num_Terrain.Value = new decimal(new int[] { 500, 0, 0, 0 });
            num_Terrain.ValueChanged += numTerrain_ValueChanged;
            // 
            // cb_AllFusions
            // 
            cb_AllFusions.AutoSize = true;
            cb_AllFusions.Location = new Point(31, 278);
            cb_AllFusions.Name = "cb_AllFusions";
            cb_AllFusions.Size = new Size(208, 24);
            cb_AllFusions.TabIndex = 54;
            cb_AllFusions.Text = "Allow non-monster fusions\r\n";
            cb_AllFusions.UseVisualStyleBackColor = true;
            cb_AllFusions.CheckedChanged += cb_AllFusions_CheckedChanged;
            // 
            // cb_Terrain
            // 
            cb_Terrain.AutoSize = true;
            cb_Terrain.Location = new Point(766, 309);
            cb_Terrain.Name = "cb_Terrain";
            cb_Terrain.Size = new Size(138, 24);
            cb_Terrain.TabIndex = 61;
            cb_Terrain.Text = "TerrainBuff/Nerf";
            cb_Terrain.UseVisualStyleBackColor = true;
            cb_Terrain.CheckedChanged += cbTerrain_CheckedChanged;
            // 
            // cb_ChangeMakoBattleTheme
            // 
            cb_ChangeMakoBattleTheme.AutoSize = true;
            cb_ChangeMakoBattleTheme.Location = new Point(31, 308);
            cb_ChangeMakoBattleTheme.Name = "cb_ChangeMakoBattleTheme";
            cb_ChangeMakoBattleTheme.Size = new Size(214, 24);
            cb_ChangeMakoBattleTheme.TabIndex = 55;
            cb_ChangeMakoBattleTheme.Text = "Change Mako Battle Theme";
            cb_ChangeMakoBattleTheme.UseVisualStyleBackColor = true;
            cb_ChangeMakoBattleTheme.CheckedChanged += cb_ChangeMakoBattleTheme_CheckedChanged;
            // 
            // num_Reincarnation
            // 
            num_Reincarnation.Location = new Point(766, 244);
            num_Reincarnation.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_Reincarnation.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_Reincarnation.Name = "num_Reincarnation";
            num_Reincarnation.Size = new Size(150, 27);
            num_Reincarnation.TabIndex = 60;
            num_Reincarnation.Value = new decimal(new int[] { 5, 0, 0, 0 });
            num_Reincarnation.ValueChanged += numReincarnation_ValueChanged;
            // 
            // cb_AIPassFix
            // 
            cb_AIPassFix.AutoSize = true;
            cb_AIPassFix.Location = new Point(31, 129);
            cb_AIPassFix.Name = "cb_AIPassFix";
            cb_AIPassFix.Size = new Size(335, 24);
            cb_AIPassFix.TabIndex = 56;
            cb_AIPassFix.Text = "AI Passes instead of double X (recommended)";
            cb_AIPassFix.UseVisualStyleBackColor = true;
            cb_AIPassFix.CheckedChanged += cb_AIPassFix_CheckedChanged;
            // 
            // cb_Reincarnation
            // 
            cb_Reincarnation.AutoSize = true;
            cb_Reincarnation.Location = new Point(766, 214);
            cb_Reincarnation.Name = "cb_Reincarnation";
            cb_Reincarnation.Size = new Size(219, 24);
            cb_Reincarnation.TabIndex = 59;
            cb_Reincarnation.Text = "Change Reincarnation Count";
            cb_Reincarnation.UseVisualStyleBackColor = true;
            // 
            // cb_AllowAllDuels
            // 
            cb_AllowAllDuels.AutoSize = true;
            cb_AllowAllDuels.Location = new Point(31, 338);
            cb_AllowAllDuels.Name = "cb_AllowAllDuels";
            cb_AllowAllDuels.Size = new Size(186, 24);
            cb_AllowAllDuels.TabIndex = 57;
            cb_AllowAllDuels.Text = "Allow All Custom Duels";
            cb_AllowAllDuels.UseVisualStyleBackColor = true;
            cb_AllowAllDuels.CheckedChanged += cb_AllowAllDuels_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Location = new Point(66, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 46;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.HighlightText;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1016, 30);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.ShowShortcutKeys = false;
            saveToolStripMenuItem.Size = new Size(177, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.ShowShortcutKeys = false;
            openToolStripMenuItem.Size = new Size(177, 26);
            openToolStripMenuItem.Text = "Load";
            openToolStripMenuItem.Click += ImportToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(174, 6);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(177, 26);
            exitToolStripMenuItem.Text = "Exit Program";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tcMaster
            // 
            tcMaster.Appearance = TabAppearance.FlatButtons;
            tcMaster.Controls.Add(tbMain);
            tcMaster.Controls.Add(tbFusions);
            tcMaster.Controls.Add(tabSlotRewards);
            tcMaster.Controls.Add(tbEditMap);
            tcMaster.Location = new Point(0, 29);
            tcMaster.Name = "tcMaster";
            tcMaster.SelectedIndex = 0;
            tcMaster.Size = new Size(1016, 707);
            tcMaster.TabIndex = 24;
            // 
            // tbFusions
            // 
            tbFusions.BackColor = Color.LightGray;
            tbFusions.Controls.Add(label2);
            tbFusions.Location = new Point(4, 32);
            tbFusions.Name = "tbFusions";
            tbFusions.Padding = new Padding(3);
            tbFusions.Size = new Size(1008, 671);
            tbFusions.TabIndex = 1;
            tbFusions.Text = "Fusions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(355, 259);
            label2.Name = "label2";
            label2.Size = new Size(186, 106);
            label2.TabIndex = 0;
            label2.Text = "WIP";
            // 
            // tabSlotRewards
            // 
            tabSlotRewards.BackColor = Color.White;
            tabSlotRewards.Controls.Add(btnSlotDefault);
            tabSlotRewards.Controls.Add(btn_SaveSlots);
            tabSlotRewards.Controls.Add(SlotRewardsDataGridView);
            tabSlotRewards.Location = new Point(4, 32);
            tabSlotRewards.Name = "tabSlotRewards";
            tabSlotRewards.Padding = new Padding(3);
            tabSlotRewards.Size = new Size(1008, 671);
            tabSlotRewards.TabIndex = 2;
            tabSlotRewards.Text = "Slot Rewards";
            // 
            // btnSlotDefault
            // 
            btnSlotDefault.Location = new Point(6, 8);
            btnSlotDefault.Name = "btnSlotDefault";
            btnSlotDefault.Size = new Size(94, 29);
            btnSlotDefault.TabIndex = 2;
            btnSlotDefault.Text = "Default";
            btnSlotDefault.UseVisualStyleBackColor = true;
            btnSlotDefault.Click += btnSlotDefault_Click;
            // 
            // btn_SaveSlots
            // 
            btn_SaveSlots.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_SaveSlots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_SaveSlots.Location = new Point(899, 7);
            btn_SaveSlots.Name = "btn_SaveSlots";
            btn_SaveSlots.Size = new Size(101, 30);
            btn_SaveSlots.TabIndex = 1;
            btn_SaveSlots.Text = "Save";
            btn_SaveSlots.UseVisualStyleBackColor = true;
            btn_SaveSlots.Click += btn_SaveSlots_Click;
            // 
            // SlotRewardsDataGridView
            // 
            SlotRewardsDataGridView.AllowUserToAddRows = false;
            SlotRewardsDataGridView.AllowUserToDeleteRows = false;
            SlotRewardsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SlotRewardsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SlotRewardsDataGridView.BackgroundColor = Color.LightGray;
            SlotRewardsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SlotRewardsDataGridView.Columns.AddRange(new DataGridViewColumn[] { number, threeInARow, Reward });
            SlotRewardsDataGridView.Location = new Point(3, 42);
            SlotRewardsDataGridView.Name = "SlotRewardsDataGridView";
            SlotRewardsDataGridView.RowHeadersVisible = false;
            SlotRewardsDataGridView.RowHeadersWidth = 51;
            SlotRewardsDataGridView.RowTemplate.Height = 29;
            SlotRewardsDataGridView.Size = new Size(1002, 626);
            SlotRewardsDataGridView.TabIndex = 0;
            SlotRewardsDataGridView.EditingControlShowing += SlotRewardsDataGridView_EditingControlShowing;
            // 
            // number
            // 
            number.Frozen = true;
            number.HeaderText = "Index";
            number.MinimumWidth = 6;
            number.Name = "number";
            number.ReadOnly = true;
            number.Width = 74;
            // 
            // threeInARow
            // 
            threeInARow.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            threeInARow.HeaderText = "Three in a Row";
            threeInARow.Items.AddRange(new object[] { "Blue-Eyes White Dragon", "Seiyaryu", "Blue-Eyes Ultimate Dragon", "Kaiser Dragon", "Blackland Fire Dragon", "Koumori Dragon", "Curse of Dragon", "Red-Eyes B. Dragon", "Darkfire Dragon", "B. Skull Dragon", "Tri-Horned Dragon", "Serpent Night Dragon", "Mikazukinoyaiba", "Yamadron", "Meteor B. Dragon", "Tyhone #2", "Ryu-Ran", "Manga Ryu-Ran", "Crawling Dragon", "Meteor Dragon", "B. Dragon Jungle King", "Baby Dragon", "Winged Dragon, Guardian of the Fortress #1", "Gaia the Dragon Champion", "Thousand Dragon", "Yamatano Dragon Scroll", "Petit Dragon", "One-Eyed Shield Dragon", "Wicked Dragon with the Ersatz Head", "Parrot Dragon", "Harpie's Pet Dragon", "Sky Dragon", "Lesser Dragon", "Fairy Dragon", "Twin-Headed Behemoth", "Mystical Elf", "Time Wizard", "Rogue Doll", "White Magical Hat", "LaMoon", "Lucky Trinket", "Genin", "Fairy's Gift", "Magician of Faith", "Ancient Elf", "Maha Vailo", "Musician King", "Eldeen", "Lady of Faith", "Ill Witch", "Maiden of the Moonlight", "The Stern Mystic", "Neo the Magic Swordsman", "The Unhappy Maiden", "Right Leg of the Forbidden One", "Left Leg of the Forbidden One", "Right Arm of the Forbidden One", "Left Arm of the Forbidden One", "Exodia the Forbidden One", "Saggi the Dark Clown", "Dark Magician", "Illusionist Faceless Mage", "Curtain of the Dark Ones", "Kamionwizard", "Nemuriko", "Necrolancer the Timelord", "The Bewitching Phantom Thief", "Phantom Dewan", "Akakieisu", "Masked Sorcerer", "Fairywitch", "Ancient Sorcerer", "Sectarian of Secrets", "Mystic Lamp", "Boo Koo", "Skull Knight", "Cosmo Queen", "Mask of Shine & Dark", "Magician of Black Chaos", "Dark Elf", "Witch of the Black Forest", "Witch's Apprentice", "Sorcerer of the Doomed", "Lord of D.", "Invitation to a Dark Sleep", "Hannibal Necromancer", "The Illusory Gentleman", "Dark Magician Girl", "Flame Manipulator", "Dryad", "Tao the Chanter", "Spirit of the Mountain", "Gemini Elf", "Leo Wizard", "Rock Spirit", "Injection Fairy Lily", "Spirit of the Winds", "Djinn the Watcher of the Wind", "Hurricail", "Kazejin", "Aqua Madoor", "Shadow Specter", "Skull Servant", "Zombie Warrior", "The Snake Hair", "Armored Zombie", "Dragon Zombie", "Clown Zombie", "Pumpking the King of Ghosts", "Graveyard and the Hand of Invitation", "The 13th Grave", "Fiend's Hand", "Blue-Eyed Silver Zombie", "Temple of Skulls", "Dokuroizo the Grim Reaper", "Fire Reaper", "Mech Mole Zombie", "Phantom Ghost", "Flame Ghost", "Wood Remains", "Dark Assailant", "Yaranzo", "Three-Legged Zombies", "Shadow Ghoul", "Magical Ghost", "Corroding Shark", "Skelgon", "Bone Mouse", "Dokurorider", "The Wandering Doomed", "Great Mammoth of Goldfine", "Ghoul with an Appetite", "Patrician of Darkness", "Moon Envoy", "Giltia the D. Knight", "Skull Guardian", "Luminous Soldier", "Kageningen", "Masked Clown", "Fiend Sword", "Skull Stalker", "Vishwar Randi", "Unknown Warrior of Fiend", "Black Luster Soldier", "Wall Shadow", "Gate Guardian", "Swordstalker", "Hungry Burger", "Garma Sword", "Greenkappa", "Succubus Knight", "Flame Swordsman", "Tactical Warrior", "Swamp Battleguard", "Judge Man", "Gaia The Fierce Knight", "Celtic Guardian", "Karbonala Warrior", "Kojikocy", "Axe Raider", "Zanki", "Battle Warrior", "Hero of the East", "Supporter in the Shadows", "Dream Clown", "Ansatsu", "Dragon Statue", "Monster Egg", "Rhaimundos of the Red Sword", "Hard Armor", "M-Warrior #1", "M-Warrior #2", "The Judgement Hand", "Mysterious Puppeteer", "Armaill", "Eyearmor", "Doron", "Kagemusha of the Blue Flame", "Trap Master", "Wood Clown", "Beautiful Headhuntress", "Wodan the Resident of the Forest", "Guardian of the Labyrinth", "Dimensional Warrior", "Protector of the Throne", "Masaki the Legendary Swordsman", "Sonic Maid", "Kanan the Swordmistress", "Stuffed Animal", "Millennium Shield", "Monster Tamer", "Swordsman from a Foreign Land", "Beautiful Beast Trainer", "Armed Ninja", "D. Human", "Performance of Sword", "Mushroom Man #2", "Lava Battleguard", "Oscillo Hero", "Empress Judge", "Warrior of Tradition", "Queen's Double", "Invader of the Throne", "Hibikime", "Princess of Tsurugi", "Dragoness the Wicked Knight", "Hyo", "The Little Swordsman of Aile", "Garoozis", "Hitotsu-Me Giant", "Battle Steer", "Battle Ox", "Beaver Warrior", "Mountain Warrior", "Tiger Axe", "Rabid Horseman", "Solitude", "One Who Hunts Souls", "Ogre of the Black Shadow", "Rude Kaiser", "Sengenjin", "Nekogal #2", "Panther Warrior", "Wolf Axwielder", "Gate Deeg", "Dark Rabbit", "Firewing Pegasus", "Little Chimera", "The Wicked Worm Beast", "Griffore", "Torike", "Wolf", "Silver Fang", "Mystic Horseman", "Dark Gray", "Sleeping Lion", "Larvas", "Dig Beak", "Lisark", "Synchar", "Fusionist", "Frenzied Panda", "Air Marmot of Nefariousness", "Meotoko", "Master & Expert", "Nekogal #1", "Prevent Rat", "Mystical Sheep #2", "Super War-Lion", "Leogun", "Tatsunootoshigo", "Burglar", "Garvas", "Flower Wolf", "Wilmee", "Milus Radiant", "Togex", "Hane-Hane", "Ancient One of the Deep Forest", "Mon Larvas", "Pale Beast", "Obese Marmot of Nefariousness", "Great Bill", "Armored Rat", "Mystical Sheep #1", "Gazelle the King of Mythical Beasts", "King Tiger Wanghu", "Chimera the Flying Mythical Beast", "Fiend Reflection #2", "Crimson Sunbird", "Niwatori", "Tyhone", "Harpie Lady", "Harpie Lady Sisters", "Spirit of the Books", "Faith Bird", "Droll Bird", "Mavelus", "Kurama", "Wing Eagle", "Punished Eagle", "Skull Red Bird", "Queen Bird", "Peacock", "Skullbird", "Monstrous Bird", "Winged Dragon, Guardian of the Fortress #2", "Crow Goblin", "Takuhee", "Fiend Reflection #1", "Blue-Winged Crown", "Birdface", "Ryu-Kishin", "Feral Imp", "Summoned Skull", "Horn Imp", "Sangan", "Kuriboh", "Castle of Dark Illusions", "Reaper of the Cards", "King of Yamimakai", "Barox", "Dark Chimera", "Metal Guardian", "Crass Clown", "Mask of Darkness", "Job-Change Mirror", "That Which Feeds on Life", "Trial of Nightmare", "Witty Phantom", "Mystery Hand", "The Shadow Who Controls the Dark", "Lord of the Lamp", "Tainted Wisdom", "Lord of Zemia", "Dark King of the Abyss", "Big Eye", "Dark Prisoner", "Ancient Brain", "Claw Reacher", "Terra the Terrible", "Mabarrel", "Midnight Fiend", "Madjinn Gunn", "Dark Titan of Terror", "The Drdek", "Candle of Fate", "Meda Bat", "Embryonic Beast", "Wicked Mirror", "Versago the Destroyer", "Megirus Light", "Gorgon Egg", "King Fog", "Mystic Clown", "Dark Artist", "Bio Plant", "Zera The Mant", "Fiend's Mirror", "Ryu-Kishin Powered", "La Jinn the Mystical Genie of the Lamp", "Bickuribox", "Zoa", "Ushi Oni", "Monster Eye", "Soul Hunter", "Needle Ball", "Morinphen", "Dragon Seeker", "Fungi of the Musk", "The Bistro Butcher", "Neck Hunter", "Chakra", "Psycho-Puppet", "Invader from Another Dimension", "Wretched Ghost of the Attic", "Key Mace #2", "Hiro's Shadow Scout", "Whiptail Crow", "Man-Eating Treasure Chest", "Baron of the Fiend Sword", "Wall of Illusion", "Toon Summoned Skull", "Three-Headed Geedo", "Berfomet", "Kryuel", "Dark Shade", "Air Eater", "Gyakutenno Megami", "Goddess with the Third Eye", "Orion the Battle King", "Weather Control", "Mystical Capture Chain", "Spirit of the Harp", "Key Mace", "Happy Lover", "Petit Angel", "Hourglass of Life", "Lunar Queen Elzaim", "Wing Egg Elf", "Ray & Temperature", "Ocubeam", "Goddess of Whim", "Hoshiningen", "Skelengel", "Dark Witch", "Binding Chain", "Muse-A", "Tenderness", "Shining Friendship", "Hourglass of Courage", "Winged Egg of New Life", "Airknight Parshath", "Doma The Angel of Silence", "Dancing Elf", "Spiked Snail", "Big Insect", "Basic Insect", "Hercules Beetle", "Gokibore", "Giant Flea", "Larvae Moth", "Great Moth", "Perfectly Ultimate Great Moth", "Nightmare Scorpion", "Winged Cleaver", "Kumootoko", "Petit Moth", "Jirai Gumo", "Dungeon Worm", "Leghul", "Ganigumo", "Alinsection", "Cockroach Knight", "Kuwagata α", "Korogashi", "Kattapillar", "Man-Eater Bug", "Gale Dogra", "Kwagar Hercules", "Minar", "Kamakiriman", "Javelin Beetle", "Needle Worm", "Giant Scorpion of the Tundra", "Hunter Spider", "Acid Crawler", "Larva of Moth", "Pupa of Moth", "Arsenal Bug", "Killer Needle", "Insect Soldiers of the Sky", "Bladefly", "Sword Arm of Dragon", "Two-Headed King Rex", "Mammoth Graveyard", "Megazowler", "Uraby", "Crawling Dragon #2", "Tomozaurus", "Two-Mouth Darkruler", "Pragtical", "Anthrosaurus", "Trakadon", "Little D", "Bracchio-raidus", "Armored Lizard", "Serpent Marauder", "Yormungarde", "Drooling Lizard", "Beaked Snake", "Ancient Lizard Warrior", "Krokodilus", "Grappler", "Toon Alligator", "Emperor of the Land and Sea", "Sinister Serpent", "Mechaleon", "Serpentine Princess", "Great White", "Rare Fish", "Root Water", "Enchanting Mermaid", "White Dolphin", "Deepsea Shark", "Bottom Dweller", "7 Colored Fish", "Rainbow Marine Mermaid", "Crazy Fish", "Misairuzame", "Tongyo", "Wow Warrior", "Fortress Whale", "Man-eating Black Shark", "Marine Beast", "Amazon of the Seas", "Kairyu-Shin", "Takriminos", "Aqua Dragon", "Sea King Dragon", "Spike Seadra", "Guardian of the Throne Room", "Ancient Tool", "Gatekeeper", "Cyber Soldier of Darkworld", "Megasonic Eye", "Labyrinth Tank", "Pendulum Machine", "Metalzoa", "Saber Slasher", "Yaiba Robo", "Cyber Soldier", "Mechanicalchaser", "Blocker", "Spike Clubber", "Cyber-Stein", "Cyber Commander", "Jinzo #7", "Cannon Soldier", "Brave Scizzar", "Dharma Cannon", "Red-Eyes Black Metal Dragon", "Barrel Dragon", "Mechanical Snail", "Disk Magician", "Slot Machine", "Blast Sphere", "Space Megatron", "Launcher Spider", "Blast Juggler", "Robotic Knight", "Ground Attacker Bugroth", "Holograh", "Steel Scorpion", "Machine King", "Giant Mech-Soldier", "Mechanical Spider", "Giga-tech Wolf", "Shovel Crusher", "Golgoil", "Dice Armadillo", "Cyber Saurus", "Steel Ogre Grotto #1", "Patrol Robo", "Royal Guard", "Machine Attacker", "Steel Ogre Grotto #2", "Gear Golem the Moving Fortress", "Kinetic Soldier", "Metal Dragon", "Bat", "Metal Fish", "Mech Bass", "Oscillo Hero #2", "Sanga of the Thunder", "Thunder Dragon", "The Immortal of Thunder", "Electric Snake", "Twin-Headed Thunder Dragon", "Thunder Nyan Nyan", "Tripwire Beast", "Electric Lizard", "LaLa Li-oon", "Kaminarikozou", "Kaminari Attack", "Mega Thunderball", "Bolt Escargot", "Bolt Penguin", "Fire Kraken", "Boulder Tortoise", "Fiend Kraken", "Jellyfish", "Catapult Turtle", "Octoberser", "Toad Master", "Akihiron", "The Melting Red Shadow", "Monsturtle", "Turtle Tiger", "Arma Knight", "Penguin Knight", "Dorover", "Twin Long Rods #1", "Roaring Ocean Snake", "Hitodenchak", "Water Element", "Water Omotics", "Beastking of the Swamps", "The Furious Sea King", "Wetha", "Change Slime", "Psychic Kappa", "Flying Penguin", "Suijin", "Zone Eater", "Ooguchi", "Water Magician", "Ice Water", "Waterdragon Fairy", "Water Girl", "Turu-Purun", "Guardian of the Sea", "Aqua Snake", "Giant Red Seasnake", "30,000-Year White Turtle", "Kappa Avenger", "Kanikabuto", "Zarigun", "Sea Kamen", "Ameba", "Yado Karu", "Turtle Raccoon", "Turtle Bird", "Star Boy", "Frog The Jam", "Behegon", "Crab Turtle", "Weather Report", "Giant Turtle Who Feeds on Flames", "Violent Rain", "Penguin Soldier", "Liquid Beast", "Twin Long Rods #2", "Armored Starfish", "High Tide Gyojin", "Fairy of the Fountain", "Night Lizard", "Amphibious Bugroth", "Gruesome Goo", "Hyosube", "Red Archery Girl", "Toon Mermaid", "Maiden of The Aqua", "Dragon Piper", "Wings of Wicked Flame", "Charubin the Fire Knight", "Fire Eye", "Hinotama Soul", "Fireyarou", "Vermillion Sparrow", "Flame Cerebrus", "Jigen Bakudan", "Molten Behemoth", "Flame Snake", "Prisman", "Rock Ogre Grotto #1", "Giant Soldier of Stone", "Ancient Jar", "Haniwa", "Dissolverock", "Stone Armadiller", "Rock Ogre Grotto #2", "Stone D.", "Millennium Golem", "Destroyer Golem", "Barrel Rock", "Minomushi Warrior", "Stone Ghost", "The Statue of Easter Island", "Muka Muka", "Sand Stone", "Mystical Sand", "Pot the Trick", "Morphing Jar", "The Thing That Hides in the Mud", "Stone Ogre Grotto", "Stone Statue of the Aztecs", "Dark Plant", "Rose Spectre of Dunn", "Mushroom Man", "Man-Eating Plant", "Firegrass", "Man Eater", "Arlownay", "Yashinoki", "Ancient Tree of Enlightenment", "Green Phantom King", "Rainbow Flower", "Barrel Lily", "Laughing Flower", "Bean Soldier", "Griggle", "Darkworld Thorns", "Abyss Flower", "Living Vase", "Snakeyashi", "Trent", "Queen of Autumn Leaves", "Woodland Sprite", "Tentacle Plant", "Fairy King Truesdale", "Summoned Lord Exodia", "Jowls of Dark Demise", "Souleater", "Slate Warrior", "Shapesnatch", "Carat Idol", "Electromagnetic Bagworm", "Timeater", "Mucus Yolk", "Servant of Catabolism", "Rigras Leever", "Moisture Creature", "Dragon Capture Jar", "Time Seal", "Monster Reborn", "Copycat", "Mimicat", "Graverobber", "Forest", "Wasteland", "Mountain", "Sogen", "Umi", "Yami", "Toon World", "Burning Land", "Labyrinth Wall", "Magical Labyrinth", "Dark Hole", "Raigeki", "Heavy Storm", "Harpie's Feather Duster", "Mooyan Curry", "Red Medicine", "Goblin's Secret Remedy", "Soul of the Pure", "Dian Keto the Cure Master", "Gift of The Mystical Elf", "Sparks", "Hinotama", "Final Flame", "Ookazi", "Tremendous Fire", "Just Desserts", "Swords of Revealing Light", "Dark-Piercing Light", "Darkness Approaches", "The Eye of Truth", "The Inexperienced Spy", "Warrior Elimination", "Eternal Rest", "Stain Storm", "Eradicating Aerosol", "Breath of Light", "Eternal Draught", "Fissure", "Last Day of Witch", "Exile of the Wicked", "Dust Tornado", "Cold Wave", "Fairy Meteor Crush", "Change of Heart", "Brain Control", "Magical Neutralizing Force Field", "Winged Trumpeter", "Shield & Sword", "Yellow Luster Shield", "Limiter Removal", "Rain of Mercy", "Windstorm of Etaqua", "Sebek's Blessing", "Aqua Chorus", "Stop Defense", "Monster Recovery", "Call Of The Haunted", "Shift", "Solomon's Lawbook", "Magic Drain", "Dimensionhole", "Earthshaker", "Creature Swap", "Legendary Sword", "Sword of Dark Destruction", "Dark Energy", "Axe of Despair", "Laser Cannon Armor", "Insect Armor with Laser Cannon", "Elf's Light", "Beast Fangs", "Steel Shell", "Vile Germs", "Black Pendant", "Silver Bow and Arrow", "Horn of Light", "Horn of the Unicorn", "Dragon Treasure", "Electro-Whip", "Cyber Shield", "Mystical Moon", "Malevolent Nuzzler", "Book of Secret Arts", "Violet Crystal", "Invigoration", "Machine Conversion Factory", "Raise Body Heat", "Follow Wind", "Power of Kaishin", "Kunai with Chain", "Salamandra", "Megamorph", "Bright Castle", "Fiend Castle", "Hightide", "Spring of Rebirth", "Gust Fan", "Burning Spear", "7 Completed", "Nails of Bane", "Riryoku", "Multiply", "Sword of Dragon's Soul", "Enchanted Javelin", "Anti-Magic Fragrance", "Crush Card", "Paralyzing Potion", "Cursebreaker", "Elegant Egotist", "Cocoon of Evolution", "Metalmorph", "Insect Imitation", "Spellbinding Circle", "Shadow Spell", "Mesmeric Control", "Tears of the Mermaid", "Infinite Dismissal", "Gravity Bind", "House of Adhesive Tape", "Eatgaboon", "Bear Trap", "Invisible Wire", "Acid Trap Hole", "Widespread Ruin", "Type Zero Magic Crusher", "Goblin Fan", "Bad Reaction to Simochi", "Reverse Trap", "Block Attack", "Shadow of Eyes", "Gorgon's Eye", "Fake Trap", "Anti Raigeki", "Call of the Grave", "Magic Jammer", "White Hole", "Royal Decree", "Seal of the Ancients", "Mirror Force", "Negate Attack", "Mirror Wall", "Curse of Millennium Shield", "Yamadron Ritual", "Gate Guardian Ritual", "Black Luster Ritual", "Zera Ritual", "War-Lion Ritual", "Beastly Mirror Ritual", "Ultimate Dragon", "Commencement Dance", "Hamburger Recipe", "Revival of Sennen Genjin", "Novox's Prayer", "Curse of Tri-Horned Dragon", "Revived Serpent Night Dragon", "Turtle Oath", "Contruct of Mask", "Resurrection of Chakra", "Puppet Ritual", "Javelin Beetle Pact", "Garma Sword Oath", "Cosmo Queen's Prayer", "Revival of Dokurorider", "Fortress Whale's Oath", "Dark Magic Ritual" });
            threeInARow.MinimumWidth = 20;
            threeInARow.Name = "threeInARow";
            // 
            // Reward
            // 
            Reward.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Reward.HeaderText = "Reward";
            Reward.Items.AddRange(new object[] { "Blue-Eyes White Dragon", "Seiyaryu", "Blue-Eyes Ultimate Dragon", "Kaiser Dragon", "Blackland Fire Dragon", "Koumori Dragon", "Curse of Dragon", "Red-Eyes B. Dragon", "Darkfire Dragon", "B. Skull Dragon", "Tri-Horned Dragon", "Serpent Night Dragon", "Mikazukinoyaiba", "Yamadron", "Meteor B. Dragon", "Tyhone #2", "Ryu-Ran", "Manga Ryu-Ran", "Crawling Dragon", "Meteor Dragon", "B. Dragon Jungle King", "Baby Dragon", "Winged Dragon, Guardian of the Fortress #1", "Gaia the Dragon Champion", "Thousand Dragon", "Yamatano Dragon Scroll", "Petit Dragon", "One-Eyed Shield Dragon", "Wicked Dragon with the Ersatz Head", "Parrot Dragon", "Harpie's Pet Dragon", "Sky Dragon", "Lesser Dragon", "Fairy Dragon", "Twin-Headed Behemoth", "Mystical Elf", "Time Wizard", "Rogue Doll", "White Magical Hat", "LaMoon", "Lucky Trinket", "Genin", "Fairy's Gift", "Magician of Faith", "Ancient Elf", "Maha Vailo", "Musician King", "Eldeen", "Lady of Faith", "Ill Witch", "Maiden of the Moonlight", "The Stern Mystic", "Neo the Magic Swordsman", "The Unhappy Maiden", "Right Leg of the Forbidden One", "Left Leg of the Forbidden One", "Right Arm of the Forbidden One", "Left Arm of the Forbidden One", "Exodia the Forbidden One", "Saggi the Dark Clown", "Dark Magician", "Illusionist Faceless Mage", "Curtain of the Dark Ones", "Kamionwizard", "Nemuriko", "Necrolancer the Timelord", "The Bewitching Phantom Thief", "Phantom Dewan", "Akakieisu", "Masked Sorcerer", "Fairywitch", "Ancient Sorcerer", "Sectarian of Secrets", "Mystic Lamp", "Boo Koo", "Skull Knight", "Cosmo Queen", "Mask of Shine & Dark", "Magician of Black Chaos", "Dark Elf", "Witch of the Black Forest", "Witch's Apprentice", "Sorcerer of the Doomed", "Lord of D.", "Invitation to a Dark Sleep", "Hannibal Necromancer", "The Illusory Gentleman", "Dark Magician Girl", "Flame Manipulator", "Dryad", "Tao the Chanter", "Spirit of the Mountain", "Gemini Elf", "Leo Wizard", "Rock Spirit", "Injection Fairy Lily", "Spirit of the Winds", "Djinn the Watcher of the Wind", "Hurricail", "Kazejin", "Aqua Madoor", "Shadow Specter", "Skull Servant", "Zombie Warrior", "The Snake Hair", "Armored Zombie", "Dragon Zombie", "Clown Zombie", "Pumpking the King of Ghosts", "Graveyard and the Hand of Invitation", "The 13th Grave", "Fiend's Hand", "Blue-Eyed Silver Zombie", "Temple of Skulls", "Dokuroizo the Grim Reaper", "Fire Reaper", "Mech Mole Zombie", "Phantom Ghost", "Flame Ghost", "Wood Remains", "Dark Assailant", "Yaranzo", "Three-Legged Zombies", "Shadow Ghoul", "Magical Ghost", "Corroding Shark", "Skelgon", "Bone Mouse", "Dokurorider", "The Wandering Doomed", "Great Mammoth of Goldfine", "Ghoul with an Appetite", "Patrician of Darkness", "Moon Envoy", "Giltia the D. Knight", "Skull Guardian", "Luminous Soldier", "Kageningen", "Masked Clown", "Fiend Sword", "Skull Stalker", "Vishwar Randi", "Unknown Warrior of Fiend", "Black Luster Soldier", "Wall Shadow", "Gate Guardian", "Swordstalker", "Hungry Burger", "Garma Sword", "Greenkappa", "Succubus Knight", "Flame Swordsman", "Tactical Warrior", "Swamp Battleguard", "Judge Man", "Gaia The Fierce Knight", "Celtic Guardian", "Karbonala Warrior", "Kojikocy", "Axe Raider", "Zanki", "Battle Warrior", "Hero of the East", "Supporter in the Shadows", "Dream Clown", "Ansatsu", "Dragon Statue", "Monster Egg", "Rhaimundos of the Red Sword", "Hard Armor", "M-Warrior #1", "M-Warrior #2", "The Judgement Hand", "Mysterious Puppeteer", "Armaill", "Eyearmor", "Doron", "Kagemusha of the Blue Flame", "Trap Master", "Wood Clown", "Beautiful Headhuntress", "Wodan the Resident of the Forest", "Guardian of the Labyrinth", "Dimensional Warrior", "Protector of the Throne", "Masaki the Legendary Swordsman", "Sonic Maid", "Kanan the Swordmistress", "Stuffed Animal", "Millennium Shield", "Monster Tamer", "Swordsman from a Foreign Land", "Beautiful Beast Trainer", "Armed Ninja", "D. Human", "Performance of Sword", "Mushroom Man #2", "Lava Battleguard", "Oscillo Hero", "Empress Judge", "Warrior of Tradition", "Queen's Double", "Invader of the Throne", "Hibikime", "Princess of Tsurugi", "Dragoness the Wicked Knight", "Hyo", "The Little Swordsman of Aile", "Garoozis", "Hitotsu-Me Giant", "Battle Steer", "Battle Ox", "Beaver Warrior", "Mountain Warrior", "Tiger Axe", "Rabid Horseman", "Solitude", "One Who Hunts Souls", "Ogre of the Black Shadow", "Rude Kaiser", "Sengenjin", "Nekogal #2", "Panther Warrior", "Wolf Axwielder", "Gate Deeg", "Dark Rabbit", "Firewing Pegasus", "Little Chimera", "The Wicked Worm Beast", "Griffore", "Torike", "Wolf", "Silver Fang", "Mystic Horseman", "Dark Gray", "Sleeping Lion", "Larvas", "Dig Beak", "Lisark", "Synchar", "Fusionist", "Frenzied Panda", "Air Marmot of Nefariousness", "Meotoko", "Master & Expert", "Nekogal #1", "Prevent Rat", "Mystical Sheep #2", "Super War-Lion", "Leogun", "Tatsunootoshigo", "Burglar", "Garvas", "Flower Wolf", "Wilmee", "Milus Radiant", "Togex", "Hane-Hane", "Ancient One of the Deep Forest", "Mon Larvas", "Pale Beast", "Obese Marmot of Nefariousness", "Great Bill", "Armored Rat", "Mystical Sheep #1", "Gazelle the King of Mythical Beasts", "King Tiger Wanghu", "Chimera the Flying Mythical Beast", "Fiend Reflection #2", "Crimson Sunbird", "Niwatori", "Tyhone", "Harpie Lady", "Harpie Lady Sisters", "Spirit of the Books", "Faith Bird", "Droll Bird", "Mavelus", "Kurama", "Wing Eagle", "Punished Eagle", "Skull Red Bird", "Queen Bird", "Peacock", "Skullbird", "Monstrous Bird", "Winged Dragon, Guardian of the Fortress #2", "Crow Goblin", "Takuhee", "Fiend Reflection #1", "Blue-Winged Crown", "Birdface", "Ryu-Kishin", "Feral Imp", "Summoned Skull", "Horn Imp", "Sangan", "Kuriboh", "Castle of Dark Illusions", "Reaper of the Cards", "King of Yamimakai", "Barox", "Dark Chimera", "Metal Guardian", "Crass Clown", "Mask of Darkness", "Job-Change Mirror", "That Which Feeds on Life", "Trial of Nightmare", "Witty Phantom", "Mystery Hand", "The Shadow Who Controls the Dark", "Lord of the Lamp", "Tainted Wisdom", "Lord of Zemia", "Dark King of the Abyss", "Big Eye", "Dark Prisoner", "Ancient Brain", "Claw Reacher", "Terra the Terrible", "Mabarrel", "Midnight Fiend", "Madjinn Gunn", "Dark Titan of Terror", "The Drdek", "Candle of Fate", "Meda Bat", "Embryonic Beast", "Wicked Mirror", "Versago the Destroyer", "Megirus Light", "Gorgon Egg", "King Fog", "Mystic Clown", "Dark Artist", "Bio Plant", "Zera The Mant", "Fiend's Mirror", "Ryu-Kishin Powered", "La Jinn the Mystical Genie of the Lamp", "Bickuribox", "Zoa", "Ushi Oni", "Monster Eye", "Soul Hunter", "Needle Ball", "Morinphen", "Dragon Seeker", "Fungi of the Musk", "The Bistro Butcher", "Neck Hunter", "Chakra", "Psycho-Puppet", "Invader from Another Dimension", "Wretched Ghost of the Attic", "Key Mace #2", "Hiro's Shadow Scout", "Whiptail Crow", "Man-Eating Treasure Chest", "Baron of the Fiend Sword", "Wall of Illusion", "Toon Summoned Skull", "Three-Headed Geedo", "Berfomet", "Kryuel", "Dark Shade", "Air Eater", "Gyakutenno Megami", "Goddess with the Third Eye", "Orion the Battle King", "Weather Control", "Mystical Capture Chain", "Spirit of the Harp", "Key Mace", "Happy Lover", "Petit Angel", "Hourglass of Life", "Lunar Queen Elzaim", "Wing Egg Elf", "Ray & Temperature", "Ocubeam", "Goddess of Whim", "Hoshiningen", "Skelengel", "Dark Witch", "Binding Chain", "Muse-A", "Tenderness", "Shining Friendship", "Hourglass of Courage", "Winged Egg of New Life", "Airknight Parshath", "Doma The Angel of Silence", "Dancing Elf", "Spiked Snail", "Big Insect", "Basic Insect", "Hercules Beetle", "Gokibore", "Giant Flea", "Larvae Moth", "Great Moth", "Perfectly Ultimate Great Moth", "Nightmare Scorpion", "Winged Cleaver", "Kumootoko", "Petit Moth", "Jirai Gumo", "Dungeon Worm", "Leghul", "Ganigumo", "Alinsection", "Cockroach Knight", "Kuwagata α", "Korogashi", "Kattapillar", "Man-Eater Bug", "Gale Dogra", "Kwagar Hercules", "Minar", "Kamakiriman", "Javelin Beetle", "Needle Worm", "Giant Scorpion of the Tundra", "Hunter Spider", "Acid Crawler", "Larva of Moth", "Pupa of Moth", "Arsenal Bug", "Killer Needle", "Insect Soldiers of the Sky", "Bladefly", "Sword Arm of Dragon", "Two-Headed King Rex", "Mammoth Graveyard", "Megazowler", "Uraby", "Crawling Dragon #2", "Tomozaurus", "Two-Mouth Darkruler", "Pragtical", "Anthrosaurus", "Trakadon", "Little D", "Bracchio-raidus", "Armored Lizard", "Serpent Marauder", "Yormungarde", "Drooling Lizard", "Beaked Snake", "Ancient Lizard Warrior", "Krokodilus", "Grappler", "Toon Alligator", "Emperor of the Land and Sea", "Sinister Serpent", "Mechaleon", "Serpentine Princess", "Great White", "Rare Fish", "Root Water", "Enchanting Mermaid", "White Dolphin", "Deepsea Shark", "Bottom Dweller", "7 Colored Fish", "Rainbow Marine Mermaid", "Crazy Fish", "Misairuzame", "Tongyo", "Wow Warrior", "Fortress Whale", "Man-eating Black Shark", "Marine Beast", "Amazon of the Seas", "Kairyu-Shin", "Takriminos", "Aqua Dragon", "Sea King Dragon", "Spike Seadra", "Guardian of the Throne Room", "Ancient Tool", "Gatekeeper", "Cyber Soldier of Darkworld", "Megasonic Eye", "Labyrinth Tank", "Pendulum Machine", "Metalzoa", "Saber Slasher", "Yaiba Robo", "Cyber Soldier", "Mechanicalchaser", "Blocker", "Spike Clubber", "Cyber-Stein", "Cyber Commander", "Jinzo #7", "Cannon Soldier", "Brave Scizzar", "Dharma Cannon", "Red-Eyes Black Metal Dragon", "Barrel Dragon", "Mechanical Snail", "Disk Magician", "Slot Machine", "Blast Sphere", "Space Megatron", "Launcher Spider", "Blast Juggler", "Robotic Knight", "Ground Attacker Bugroth", "Holograh", "Steel Scorpion", "Machine King", "Giant Mech-Soldier", "Mechanical Spider", "Giga-tech Wolf", "Shovel Crusher", "Golgoil", "Dice Armadillo", "Cyber Saurus", "Steel Ogre Grotto #1", "Patrol Robo", "Royal Guard", "Machine Attacker", "Steel Ogre Grotto #2", "Gear Golem the Moving Fortress", "Kinetic Soldier", "Metal Dragon", "Bat", "Metal Fish", "Mech Bass", "Oscillo Hero #2", "Sanga of the Thunder", "Thunder Dragon", "The Immortal of Thunder", "Electric Snake", "Twin-Headed Thunder Dragon", "Thunder Nyan Nyan", "Tripwire Beast", "Electric Lizard", "LaLa Li-oon", "Kaminarikozou", "Kaminari Attack", "Mega Thunderball", "Bolt Escargot", "Bolt Penguin", "Fire Kraken", "Boulder Tortoise", "Fiend Kraken", "Jellyfish", "Catapult Turtle", "Octoberser", "Toad Master", "Akihiron", "The Melting Red Shadow", "Monsturtle", "Turtle Tiger", "Arma Knight", "Penguin Knight", "Dorover", "Twin Long Rods #1", "Roaring Ocean Snake", "Hitodenchak", "Water Element", "Water Omotics", "Beastking of the Swamps", "The Furious Sea King", "Wetha", "Change Slime", "Psychic Kappa", "Flying Penguin", "Suijin", "Zone Eater", "Ooguchi", "Water Magician", "Ice Water", "Waterdragon Fairy", "Water Girl", "Turu-Purun", "Guardian of the Sea", "Aqua Snake", "Giant Red Seasnake", "30,000-Year White Turtle", "Kappa Avenger", "Kanikabuto", "Zarigun", "Sea Kamen", "Ameba", "Yado Karu", "Turtle Raccoon", "Turtle Bird", "Star Boy", "Frog The Jam", "Behegon", "Crab Turtle", "Weather Report", "Giant Turtle Who Feeds on Flames", "Violent Rain", "Penguin Soldier", "Liquid Beast", "Twin Long Rods #2", "Armored Starfish", "High Tide Gyojin", "Fairy of the Fountain", "Night Lizard", "Amphibious Bugroth", "Gruesome Goo", "Hyosube", "Red Archery Girl", "Toon Mermaid", "Maiden of The Aqua", "Dragon Piper", "Wings of Wicked Flame", "Charubin the Fire Knight", "Fire Eye", "Hinotama Soul", "Fireyarou", "Vermillion Sparrow", "Flame Cerebrus", "Jigen Bakudan", "Molten Behemoth", "Flame Snake", "Prisman", "Rock Ogre Grotto #1", "Giant Soldier of Stone", "Ancient Jar", "Haniwa", "Dissolverock", "Stone Armadiller", "Rock Ogre Grotto #2", "Stone D.", "Millennium Golem", "Destroyer Golem", "Barrel Rock", "Minomushi Warrior", "Stone Ghost", "The Statue of Easter Island", "Muka Muka", "Sand Stone", "Mystical Sand", "Pot the Trick", "Morphing Jar", "The Thing That Hides in the Mud", "Stone Ogre Grotto", "Stone Statue of the Aztecs", "Dark Plant", "Rose Spectre of Dunn", "Mushroom Man", "Man-Eating Plant", "Firegrass", "Man Eater", "Arlownay", "Yashinoki", "Ancient Tree of Enlightenment", "Green Phantom King", "Rainbow Flower", "Barrel Lily", "Laughing Flower", "Bean Soldier", "Griggle", "Darkworld Thorns", "Abyss Flower", "Living Vase", "Snakeyashi", "Trent", "Queen of Autumn Leaves", "Woodland Sprite", "Tentacle Plant", "Fairy King Truesdale", "Summoned Lord Exodia", "Jowls of Dark Demise", "Souleater", "Slate Warrior", "Shapesnatch", "Carat Idol", "Electromagnetic Bagworm", "Timeater", "Mucus Yolk", "Servant of Catabolism", "Rigras Leever", "Moisture Creature", "Dragon Capture Jar", "Time Seal", "Monster Reborn", "Copycat", "Mimicat", "Graverobber", "Forest", "Wasteland", "Mountain", "Sogen", "Umi", "Yami", "Toon World", "Burning Land", "Labyrinth Wall", "Magical Labyrinth", "Dark Hole", "Raigeki", "Heavy Storm", "Harpie's Feather Duster", "Mooyan Curry", "Red Medicine", "Goblin's Secret Remedy", "Soul of the Pure", "Dian Keto the Cure Master", "Gift of The Mystical Elf", "Sparks", "Hinotama", "Final Flame", "Ookazi", "Tremendous Fire", "Just Desserts", "Swords of Revealing Light", "Dark-Piercing Light", "Darkness Approaches", "The Eye of Truth", "The Inexperienced Spy", "Warrior Elimination", "Eternal Rest", "Stain Storm", "Eradicating Aerosol", "Breath of Light", "Eternal Draught", "Fissure", "Last Day of Witch", "Exile of the Wicked", "Dust Tornado", "Cold Wave", "Fairy Meteor Crush", "Change of Heart", "Brain Control", "Magical Neutralizing Force Field", "Winged Trumpeter", "Shield & Sword", "Yellow Luster Shield", "Limiter Removal", "Rain of Mercy", "Windstorm of Etaqua", "Sebek's Blessing", "Aqua Chorus", "Stop Defense", "Monster Recovery", "Call Of The Haunted", "Shift", "Solomon's Lawbook", "Magic Drain", "Dimensionhole", "Earthshaker", "Creature Swap", "Legendary Sword", "Sword of Dark Destruction", "Dark Energy", "Axe of Despair", "Laser Cannon Armor", "Insect Armor with Laser Cannon", "Elf's Light", "Beast Fangs", "Steel Shell", "Vile Germs", "Black Pendant", "Silver Bow and Arrow", "Horn of Light", "Horn of the Unicorn", "Dragon Treasure", "Electro-Whip", "Cyber Shield", "Mystical Moon", "Malevolent Nuzzler", "Book of Secret Arts", "Violet Crystal", "Invigoration", "Machine Conversion Factory", "Raise Body Heat", "Follow Wind", "Power of Kaishin", "Kunai with Chain", "Salamandra", "Megamorph", "Bright Castle", "Fiend Castle", "Hightide", "Spring of Rebirth", "Gust Fan", "Burning Spear", "7 Completed", "Nails of Bane", "Riryoku", "Multiply", "Sword of Dragon's Soul", "Enchanted Javelin", "Anti-Magic Fragrance", "Crush Card", "Paralyzing Potion", "Cursebreaker", "Elegant Egotist", "Cocoon of Evolution", "Metalmorph", "Insect Imitation", "Spellbinding Circle", "Shadow Spell", "Mesmeric Control", "Tears of the Mermaid", "Infinite Dismissal", "Gravity Bind", "House of Adhesive Tape", "Eatgaboon", "Bear Trap", "Invisible Wire", "Acid Trap Hole", "Widespread Ruin", "Type Zero Magic Crusher", "Goblin Fan", "Bad Reaction to Simochi", "Reverse Trap", "Block Attack", "Shadow of Eyes", "Gorgon's Eye", "Fake Trap", "Anti Raigeki", "Call of the Grave", "Magic Jammer", "White Hole", "Royal Decree", "Seal of the Ancients", "Mirror Force", "Negate Attack", "Mirror Wall", "Curse of Millennium Shield", "Yamadron Ritual", "Gate Guardian Ritual", "Black Luster Ritual", "Zera Ritual", "War-Lion Ritual", "Beastly Mirror Ritual", "Ultimate Dragon", "Commencement Dance", "Hamburger Recipe", "Revival of Sennen Genjin", "Novox's Prayer", "Curse of Tri-Horned Dragon", "Revived Serpent Night Dragon", "Turtle Oath", "Contruct of Mask", "Resurrection of Chakra", "Puppet Ritual", "Javelin Beetle Pact", "Garma Sword Oath", "Cosmo Queen's Prayer", "Revival of Dokurorider", "Fortress Whale's Oath", "Dark Magic Ritual" });
            Reward.MinimumWidth = 20;
            Reward.Name = "Reward";
            // 
            // tbEditMap
            // 
            tbEditMap.Controls.Add(scEditMapMain);
            tbEditMap.Location = new Point(4, 32);
            tbEditMap.Name = "tbEditMap";
            tbEditMap.Padding = new Padding(3);
            tbEditMap.Size = new Size(1008, 671);
            tbEditMap.TabIndex = 3;
            tbEditMap.Text = "Edit Map";
            tbEditMap.UseVisualStyleBackColor = true;
            // 
            // scEditMapMain
            // 
            scEditMapMain.Dock = DockStyle.Fill;
            scEditMapMain.Location = new Point(3, 3);
            scEditMapMain.Name = "scEditMapMain";
            // 
            // scEditMapMain.Panel1
            // 
            scEditMapMain.Panel1.Controls.Add(scEditMapToSelect);
            // 
            // scEditMapMain.Panel2
            // 
            scEditMapMain.Panel2.BackColor = Color.LightGray;
            scEditMapMain.Panel2.Controls.Add(lblMapSideWhite);
            scEditMapMain.Panel2.Controls.Add(lblMapSideRed);
            scEditMapMain.Panel2.Controls.Add(lblMapName);
            scEditMapMain.Panel2.Paint += scEditMapMain_Panel2_Paint;
            scEditMapMain.Panel2.MouseDown += scEditMapMain_Panel2_MouseDown;
            scEditMapMain.Panel2.MouseMove += scEditMapMain_Panel2_MouseMove;
            scEditMapMain.Panel2.MouseUp += scEditMapMain_Panel2_MouseUp;
            scEditMapMain.Size = new Size(1002, 665);
            scEditMapMain.SplitterDistance = 481;
            scEditMapMain.TabIndex = 0;
            // 
            // scEditMapToSelect
            // 
            scEditMapToSelect.Dock = DockStyle.Fill;
            scEditMapToSelect.Location = new Point(0, 0);
            scEditMapToSelect.Name = "scEditMapToSelect";
            // 
            // scEditMapToSelect.Panel1
            // 
            scEditMapToSelect.Panel1.BackColor = Color.LightGray;
            scEditMapToSelect.Panel1.Controls.Add(lblMapToSelect);
            scEditMapToSelect.Panel1.Controls.Add(lbMapSelection);
            // 
            // scEditMapToSelect.Panel2
            // 
            scEditMapToSelect.Panel2.Controls.Add(scEditMapTiles);
            scEditMapToSelect.Size = new Size(481, 665);
            scEditMapToSelect.SplitterDistance = 159;
            scEditMapToSelect.TabIndex = 0;
            // 
            // lblMapToSelect
            // 
            lblMapToSelect.AutoSize = true;
            lblMapToSelect.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMapToSelect.Location = new Point(15, 19);
            lblMapToSelect.Name = "lblMapToSelect";
            lblMapToSelect.Size = new Size(122, 25);
            lblMapToSelect.TabIndex = 1;
            lblMapToSelect.Text = "Map To Select";
            lblMapToSelect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMapSelection
            // 
            lbMapSelection.FormattingEnabled = true;
            lbMapSelection.ItemHeight = 20;
            lbMapSelection.Items.AddRange(new object[] { "Tutorial", "Seto", "Weevil", "Rex", "Keith", "Ishtar", "Necromancer", "Darkness-ruler", "Labyrinth-ruler", "Pegasus", "Richard", "Tea", "Tristan", "Mai", "Mako", "Joey", "Shadi", "Jasper", "Bakura", "Yugi", "Skull Knight", "Chakra", "Default Map 00", "Default Map 01", "Default Map 02", "Default Map 03", "Default Map 04", "Default Map 05", "Default Map 06", "Default Map 07", "Default Map 08", "Default Map 09", "Default Map 10", "Default Map 11", "Default Map 12", "Default Map 13", "Default Map 14", "Default Map 15", "Default Map 16", "Default Map 17", "Default Map 18", "Default Map 19", "Default Map 20", "Default Map 21", "Default Map 22", "Default Map 23" });
            lbMapSelection.Location = new Point(5, 56);
            lbMapSelection.Name = "lbMapSelection";
            lbMapSelection.Size = new Size(150, 604);
            lbMapSelection.TabIndex = 0;
            lbMapSelection.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // scEditMapTiles
            // 
            scEditMapTiles.Dock = DockStyle.Fill;
            scEditMapTiles.Location = new Point(0, 0);
            scEditMapTiles.Name = "scEditMapTiles";
            scEditMapTiles.Orientation = Orientation.Horizontal;
            // 
            // scEditMapTiles.Panel1
            // 
            scEditMapTiles.Panel1.BackColor = Color.LightGray;
            scEditMapTiles.Panel1.Controls.Add(label3);
            scEditMapTiles.Panel1.Controls.Add(LklblGithub);
            scEditMapTiles.Panel1.Controls.Add(lblMapCurrentISOResult);
            scEditMapTiles.Panel1.Controls.Add(lblMapCurrentlyLoadedISO);
            scEditMapTiles.Panel1.Controls.Add(btnSaveMap);
            scEditMapTiles.Panel1.Controls.Add(btnMapLoadISo);
            // 
            // scEditMapTiles.Panel2
            // 
            scEditMapTiles.Panel2.BackColor = Color.Gainsboro;
            scEditMapTiles.Panel2.Controls.Add(pbSelectedTile);
            scEditMapTiles.Panel2.Controls.Add(lblSelectedTile);
            scEditMapTiles.Panel2.Controls.Add(tbPallete);
            scEditMapTiles.Size = new Size(318, 665);
            scEditMapTiles.SplitterDistance = 164;
            scEditMapTiles.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Location = new Point(20, 9);
            label3.Name = "label3";
            label3.Size = new Size(141, 50);
            label3.TabIndex = 5;
            label3.Text = "Ported version of the DOTR Map by: ";
            // 
            // LklblGithub
            // 
            LklblGithub.AutoSize = true;
            LklblGithub.Location = new Point(177, 19);
            LklblGithub.Name = "LklblGithub";
            LklblGithub.Size = new Size(115, 20);
            LklblGithub.TabIndex = 4;
            LklblGithub.TabStop = true;
            LklblGithub.Text = "rjoken/Thotsicle";
            LklblGithub.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblMapCurrentISOResult
            // 
            lblMapCurrentISOResult.AutoEllipsis = true;
            lblMapCurrentISOResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMapCurrentISOResult.Location = new Point(143, 102);
            lblMapCurrentISOResult.Name = "lblMapCurrentISOResult";
            lblMapCurrentISOResult.Size = new Size(171, 57);
            lblMapCurrentISOResult.TabIndex = 3;
            lblMapCurrentISOResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMapCurrentlyLoadedISO
            // 
            lblMapCurrentlyLoadedISO.AutoSize = true;
            lblMapCurrentlyLoadedISO.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMapCurrentlyLoadedISO.Location = new Point(177, 72);
            lblMapCurrentlyLoadedISO.Name = "lblMapCurrentlyLoadedISO";
            lblMapCurrentlyLoadedISO.Size = new Size(108, 25);
            lblMapCurrentlyLoadedISO.TabIndex = 2;
            lblMapCurrentlyLoadedISO.Text = "Current ISO:";
            // 
            // btnSaveMap
            // 
            btnSaveMap.Location = new Point(30, 107);
            btnSaveMap.Name = "btnSaveMap";
            btnSaveMap.Size = new Size(94, 52);
            btnSaveMap.TabIndex = 1;
            btnSaveMap.Text = "Save Maps to ISO";
            btnSaveMap.UseVisualStyleBackColor = true;
            btnSaveMap.Click += btnSaveMapsToISO;
            // 
            // btnMapLoadISo
            // 
            btnMapLoadISo.Location = new Point(30, 72);
            btnMapLoadISo.Name = "btnMapLoadISo";
            btnMapLoadISo.Size = new Size(94, 29);
            btnMapLoadISo.TabIndex = 0;
            btnMapLoadISo.Text = "Load ISO";
            btnMapLoadISo.UseVisualStyleBackColor = true;
            btnMapLoadISo.Click += btnMapLoadISo_Click;
            // 
            // pbSelectedTile
            // 
            pbSelectedTile.Image = (Image)resources.GetObject("pbSelectedTile.Image");
            pbSelectedTile.Location = new Point(14, 199);
            pbSelectedTile.Name = "pbSelectedTile";
            pbSelectedTile.Size = new Size(88, 86);
            pbSelectedTile.SizeMode = PictureBoxSizeMode.Zoom;
            pbSelectedTile.TabIndex = 2;
            pbSelectedTile.TabStop = false;
            // 
            // lblSelectedTile
            // 
            lblSelectedTile.AutoSize = true;
            lblSelectedTile.Location = new Point(14, 173);
            lblSelectedTile.Name = "lblSelectedTile";
            lblSelectedTile.Size = new Size(90, 20);
            lblSelectedTile.TabIndex = 1;
            lblSelectedTile.Text = "SelectedTile";
            // 
            // tbPallete
            // 
            tbPallete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbPallete.ColumnCount = 2;
            tbPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPallete.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbPallete.Controls.Add(pbCrush, 1, 4);
            tbPallete.Controls.Add(pbLab, 0, 4);
            tbPallete.Controls.Add(pbNormal, 1, 3);
            tbPallete.Controls.Add(pbToon, 0, 3);
            tbPallete.Controls.Add(pbYami, 1, 2);
            tbPallete.Controls.Add(pbSea, 0, 2);
            tbPallete.Controls.Add(pbMountain, 0, 1);
            tbPallete.Controls.Add(pbForest, 0, 0);
            tbPallete.Controls.Add(pbMeadow, 1, 1);
            tbPallete.Controls.Add(pbWasteland, 1, 0);
            tbPallete.Location = new Point(118, 12);
            tbPallete.Name = "tbPallete";
            tbPallete.RowCount = 5;
            tbPallete.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPallete.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPallete.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPallete.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPallete.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tbPallete.Size = new Size(196, 463);
            tbPallete.TabIndex = 0;
            // 
            // pbCrush
            // 
            pbCrush.Dock = DockStyle.Fill;
            pbCrush.Image = Properties.Resources.CRUSH;
            pbCrush.Location = new Point(101, 371);
            pbCrush.Name = "pbCrush";
            pbCrush.Size = new Size(92, 89);
            pbCrush.SizeMode = PictureBoxSizeMode.Zoom;
            pbCrush.TabIndex = 9;
            pbCrush.TabStop = false;
            pbCrush.Click += pbCrush_Click;
            // 
            // pbLab
            // 
            pbLab.Dock = DockStyle.Fill;
            pbLab.Image = Properties.Resources.LABYRINTH;
            pbLab.Location = new Point(3, 371);
            pbLab.Name = "pbLab";
            pbLab.Size = new Size(92, 89);
            pbLab.SizeMode = PictureBoxSizeMode.Zoom;
            pbLab.TabIndex = 8;
            pbLab.TabStop = false;
            pbLab.Click += pbLab_Click;
            // 
            // pbNormal
            // 
            pbNormal.Dock = DockStyle.Fill;
            pbNormal.Image = Properties.Resources.NORMAL;
            pbNormal.Location = new Point(101, 279);
            pbNormal.Name = "pbNormal";
            pbNormal.Size = new Size(92, 86);
            pbNormal.SizeMode = PictureBoxSizeMode.Zoom;
            pbNormal.TabIndex = 7;
            pbNormal.TabStop = false;
            pbNormal.Click += pbNormal_Click;
            // 
            // pbToon
            // 
            pbToon.Dock = DockStyle.Fill;
            pbToon.Image = Properties.Resources.TOON;
            pbToon.Location = new Point(3, 279);
            pbToon.Name = "pbToon";
            pbToon.Size = new Size(92, 86);
            pbToon.SizeMode = PictureBoxSizeMode.Zoom;
            pbToon.TabIndex = 6;
            pbToon.TabStop = false;
            pbToon.Click += pbToon_Click;
            // 
            // pbYami
            // 
            pbYami.Dock = DockStyle.Fill;
            pbYami.Image = Properties.Resources.DARK;
            pbYami.Location = new Point(101, 187);
            pbYami.Name = "pbYami";
            pbYami.Size = new Size(92, 86);
            pbYami.SizeMode = PictureBoxSizeMode.Zoom;
            pbYami.TabIndex = 5;
            pbYami.TabStop = false;
            pbYami.Click += pbYami_Click;
            // 
            // pbSea
            // 
            pbSea.Dock = DockStyle.Fill;
            pbSea.Image = Properties.Resources.SEA;
            pbSea.Location = new Point(3, 187);
            pbSea.Name = "pbSea";
            pbSea.Size = new Size(92, 86);
            pbSea.SizeMode = PictureBoxSizeMode.Zoom;
            pbSea.TabIndex = 4;
            pbSea.TabStop = false;
            pbSea.Click += pbSea_Click;
            // 
            // pbMountain
            // 
            pbMountain.Dock = DockStyle.Fill;
            pbMountain.Image = Properties.Resources.MOUNTAIN;
            pbMountain.Location = new Point(3, 95);
            pbMountain.Name = "pbMountain";
            pbMountain.Size = new Size(92, 86);
            pbMountain.SizeMode = PictureBoxSizeMode.Zoom;
            pbMountain.TabIndex = 2;
            pbMountain.TabStop = false;
            pbMountain.Click += pbMountain_Click;
            // 
            // pbForest
            // 
            pbForest.Dock = DockStyle.Fill;
            pbForest.Image = (Image)resources.GetObject("pbForest.Image");
            pbForest.Location = new Point(3, 3);
            pbForest.Name = "pbForest";
            pbForest.Size = new Size(92, 86);
            pbForest.SizeMode = PictureBoxSizeMode.Zoom;
            pbForest.TabIndex = 0;
            pbForest.TabStop = false;
            pbForest.Click += pbForest_Click;
            // 
            // pbMeadow
            // 
            pbMeadow.Dock = DockStyle.Fill;
            pbMeadow.Image = Properties.Resources.MEADOW;
            pbMeadow.Location = new Point(101, 95);
            pbMeadow.Name = "pbMeadow";
            pbMeadow.Size = new Size(92, 86);
            pbMeadow.SizeMode = PictureBoxSizeMode.Zoom;
            pbMeadow.TabIndex = 3;
            pbMeadow.TabStop = false;
            pbMeadow.Click += pbMeadow_Click;
            // 
            // pbWasteland
            // 
            pbWasteland.Image = Properties.Resources.WASTELAND;
            pbWasteland.Location = new Point(101, 3);
            pbWasteland.Name = "pbWasteland";
            pbWasteland.Size = new Size(92, 86);
            pbWasteland.SizeMode = PictureBoxSizeMode.Zoom;
            pbWasteland.TabIndex = 1;
            pbWasteland.TabStop = false;
            pbWasteland.Click += pbWasteland_Click;
            // 
            // lblMapSideWhite
            // 
            lblMapSideWhite.AutoSize = true;
            lblMapSideWhite.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMapSideWhite.Location = new Point(213, 72);
            lblMapSideWhite.Name = "lblMapSideWhite";
            lblMapSideWhite.Size = new Size(97, 25);
            lblMapSideWhite.TabIndex = 2;
            lblMapSideWhite.Text = "White Side";
            // 
            // lblMapSideRed
            // 
            lblMapSideRed.AutoSize = true;
            lblMapSideRed.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMapSideRed.Location = new Point(213, 618);
            lblMapSideRed.Name = "lblMapSideRed";
            lblMapSideRed.Size = new Size(81, 25);
            lblMapSideRed.TabIndex = 1;
            lblMapSideRed.Text = "Red Side";
            // 
            // lblMapName
            // 
            lblMapName.AutoSize = true;
            lblMapName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMapName.Location = new Point(114, 19);
            lblMapName.Name = "lblMapName";
            lblMapName.Size = new Size(72, 31);
            lblMapName.TabIndex = 0;
            lblMapName.Text = "Map: ";
            lblMapName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RefreshEditor
            // 
            RefreshEditor.Tick += RefreshEditor_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 736);
            Controls.Add(tcMaster);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "DOTR Memory Patcher";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_LpCap).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Terrain).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Reincarnation).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tcMaster.ResumeLayout(false);
            tbFusions.ResumeLayout(false);
            tbFusions.PerformLayout();
            tabSlotRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SlotRewardsDataGridView).EndInit();
            tbEditMap.ResumeLayout(false);
            scEditMapMain.Panel1.ResumeLayout(false);
            scEditMapMain.Panel2.ResumeLayout(false);
            scEditMapMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scEditMapMain).EndInit();
            scEditMapMain.ResumeLayout(false);
            scEditMapToSelect.Panel1.ResumeLayout(false);
            scEditMapToSelect.Panel1.PerformLayout();
            scEditMapToSelect.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scEditMapToSelect).EndInit();
            scEditMapToSelect.ResumeLayout(false);
            scEditMapTiles.Panel1.ResumeLayout(false);
            scEditMapTiles.Panel1.PerformLayout();
            scEditMapTiles.Panel2.ResumeLayout(false);
            scEditMapTiles.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scEditMapTiles).EndInit();
            scEditMapTiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSelectedTile).EndInit();
            tbPallete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCrush).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbToon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYami).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSea).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMountain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbForest).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMeadow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWasteland).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitDataGridView()
        {
            SlotRewardsDataGridView.Rows.Add(30);
            for (int i = 0; i < SlotRewardsDataGridView.RowCount; i++)
            {
                SlotRewardsDataGridView.Rows[i].Cells[0].Value = i;
                DataGridViewComboBoxCell threeCell = SlotRewardsDataGridView.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                threeCell.Value = threeCell.Items[671];
                DataGridViewComboBoxCell rewardCell = SlotRewardsDataGridView.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                rewardCell.Value = rewardCell.Items[0];



            }
        }
        private void BindSlotRewards()
        {

            for (int i = 0; i < SlotRewardsDataGridView.RowCount; i++)
            {

                DataGridViewComboBoxCell threeCell = SlotRewardsDataGridView.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                int value = threeCell.Items.IndexOf(threeCell.Value);
                SpecialThreeInARows[i] = value;

                DataGridViewComboBoxCell rewardCell = SlotRewardsDataGridView.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                value = rewardCell.Items.IndexOf(rewardCell.Value);
                SpecialSlotRewards[i] = value;
            }


        }

        #endregion
        private OpenFileDialog openFileDialog2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabControl tcMaster;
        private TabPage tbMain;
        private TabPage tbFusions;
        private Label label2;
        private TabPage tabSlotRewards;
        private DataGridView SlotRewardsDataGridView;
        private DataGridViewColumn index;
        private DataGridViewTextBoxColumn number;
        private DataGridViewComboBoxColumn threeInARow;
        private DataGridViewComboBoxColumn Reward;
        private Button btn_SaveSlots;
        private Panel panel1;
        private NumericUpDown num_LpCap;
        private CheckBox cb_AdditionalSlotRewards;
        private Label lbl_Options;
        private Label label1;
        public Button btn_Start;
        private Label lblTeamFirst;
        public Label CurrentStatus;
        private ComboBox cbo_ForceStartSide;
        private CheckBox cb_RemoveNegetiveExp;
        private CheckBox cb_ForceStartSide;
        private CheckBox cb_LpCap;
        private CheckBox cb_SideFirst;
        private CheckBox cb_RemoveSlotRng;
        private ComboBox cbo_TeamFirstTurn;
        private CheckBox cb_ExpandedZoom;
        private NumericUpDown num_Terrain;
        private CheckBox cb_AllFusions;
        private CheckBox cb_Terrain;
        private CheckBox cb_ChangeMakoBattleTheme;
        private NumericUpDown num_Reincarnation;
        private CheckBox cb_AIPassFix;
        private CheckBox cb_Reincarnation;
        private CheckBox cb_AllowAllDuels;
        private Button btn_DefaultSettings;
        private Button btnSlotDefault;
        private CheckBox cb_fastIntro;
        private TabPage tbEditMap;
        private SplitContainer scEditMapMain;
        private SplitContainer scEditMapToSelect;
        private Label lblMapToSelect;
        private ListBox lbMapSelection;
        private SplitContainer scEditMapTiles;
        private PictureBox pbSelectedTile;
        private Label lblSelectedTile;
        private Button btnSaveMap;
        private Button btnMapLoadISo;
        private Label lblMapCurrentlyLoadedISO;
        private Label lblMapName;
        private Label lblMapCurrentISOResult;
        private TableLayoutPanel tbPallete;
        private PictureBox pbCrush;
        private PictureBox pbLab;
        private PictureBox pbNormal;
        private PictureBox pbToon;
        private PictureBox pbYami;
        private PictureBox pbSea;
        private PictureBox pbMeadow;
        private PictureBox pbMountain;
        private PictureBox pbWasteland;
        private PictureBox pbForest;
        public System.Windows.Forms.Timer RefreshEditor;
        private CheckBox cbCustomMaps;
        private Label lblMapSideRed;
        private Label lblMapSideWhite;
        private LinkLabel LklblGithub;
        private Label label3;
    }
}