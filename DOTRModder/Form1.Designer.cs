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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tcMaster = new TabControl();
            tbMain = new TabPage();
            label1 = new Label();
            lblTeamFirst = new Label();
            cbo_ForceStartSide = new ComboBox();
            cbTeamStart = new CheckBox();
            cbTeamFirstTurn = new CheckBox();
            cboTeamFirstTurn = new ComboBox();
            numTerrain = new NumericUpDown();
            cbTerrain = new CheckBox();
            numReincarnation = new NumericUpDown();
            cbReincarnation = new CheckBox();
            num_LpCap = new NumericUpDown();
            cb_AllowAllDuels = new CheckBox();
            cb_AIPassFix = new CheckBox();
            cb_ChangeMakoBattleTheme = new CheckBox();
            cb_AllFusions = new CheckBox();
            cb_ExpandedZoom = new CheckBox();
            cb_RemoveSlotRng = new CheckBox();
            lbl_Options = new Label();
            cb_LpCap = new CheckBox();
            cb_RemoveNegetiveExp = new CheckBox();
            CurrentStatus = new Label();
            btn_Start = new Button();
            tbFusions = new TabPage();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            tcMaster.SuspendLayout();
            tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTerrain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReincarnation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_LpCap).BeginInit();
            tbFusions.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1016, 28);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.ShowShortcutKeys = false;
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Import";
            openToolStripMenuItem.Click += ImportToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.ShowShortcutKeys = false;
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Export";
            saveToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit Program";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tcMaster
            // 
            tcMaster.Controls.Add(tbMain);
            tcMaster.Controls.Add(tbFusions);
            tcMaster.Location = new Point(0, 30);
            tcMaster.Name = "tcMaster";
            tcMaster.SelectedIndex = 0;
            tcMaster.Size = new Size(1016, 707);
            tcMaster.TabIndex = 24;
            // 
            // tbMain
            // 
            tbMain.BackColor = Color.Gainsboro;
            tbMain.Controls.Add(label1);
            tbMain.Controls.Add(lblTeamFirst);
            tbMain.Controls.Add(cbo_ForceStartSide);
            tbMain.Controls.Add(cbTeamStart);
            tbMain.Controls.Add(cbTeamFirstTurn);
            tbMain.Controls.Add(cboTeamFirstTurn);
            tbMain.Controls.Add(numTerrain);
            tbMain.Controls.Add(cbTerrain);
            tbMain.Controls.Add(numReincarnation);
            tbMain.Controls.Add(cbReincarnation);
            tbMain.Controls.Add(num_LpCap);
            tbMain.Controls.Add(cb_AllowAllDuels);
            tbMain.Controls.Add(cb_AIPassFix);
            tbMain.Controls.Add(cb_ChangeMakoBattleTheme);
            tbMain.Controls.Add(cb_AllFusions);
            tbMain.Controls.Add(cb_ExpandedZoom);
            tbMain.Controls.Add(cb_RemoveSlotRng);
            tbMain.Controls.Add(lbl_Options);
            tbMain.Controls.Add(cb_LpCap);
            tbMain.Controls.Add(cb_RemoveNegetiveExp);
            tbMain.Controls.Add(CurrentStatus);
            tbMain.Controls.Add(btn_Start);
            tbMain.Location = new Point(4, 29);
            tbMain.Name = "tbMain";
            tbMain.Padding = new Padding(3);
            tbMain.Size = new Size(1008, 674);
            tbMain.TabIndex = 0;
            tbMain.Text = "Main";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 171);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 44;
            label1.Text = "For new games";
            // 
            // lblTeamFirst
            // 
            lblTeamFirst.AutoSize = true;
            lblTeamFirst.Location = new Point(452, 65);
            lblTeamFirst.Name = "lblTeamFirst";
            lblTeamFirst.Size = new Size(238, 20);
            lblTeamFirst.TabIndex = 43;
            lblTeamFirst.Text = "Leave unchecked to always go first";
            // 
            // cbo_ForceStartSide
            // 
            cbo_ForceStartSide.FormattingEnabled = true;
            cbo_ForceStartSide.Items.AddRange(new object[] { "Red", "White" });
            cbo_ForceStartSide.Location = new Point(452, 227);
            cbo_ForceStartSide.Name = "cbo_ForceStartSide";
            cbo_ForceStartSide.Size = new Size(151, 28);
            cbo_ForceStartSide.TabIndex = 42;
            cbo_ForceStartSide.Text = "Red";
            cbo_ForceStartSide.SelectedIndexChanged += cbo_ForceStartSide_SelectedIndexChanged;
            // 
            // cbTeamStart
            // 
            cbTeamStart.AutoSize = true;
            cbTeamStart.Location = new Point(452, 197);
            cbTeamStart.Name = "cbTeamStart";
            cbTeamStart.Size = new Size(136, 24);
            cbTeamStart.TabIndex = 41;
            cbTeamStart.Text = "Force Rose Side";
            cbTeamStart.UseVisualStyleBackColor = true;
            cbTeamStart.CheckedChanged += cbTeamStart_CheckedChanged;
            // 
            // cbTeamFirstTurn
            // 
            cbTeamFirstTurn.AutoSize = true;
            cbTeamFirstTurn.Location = new Point(452, 97);
            cbTeamFirstTurn.Name = "cbTeamFirstTurn";
            cbTeamFirstTurn.Size = new Size(173, 24);
            cbTeamFirstTurn.TabIndex = 40;
            cbTeamFirstTurn.Text = "Which Side Goes First";
            cbTeamFirstTurn.UseVisualStyleBackColor = true;
            cbTeamFirstTurn.CheckedChanged += cbTeamFirstTurn_CheckedChanged;
            // 
            // cboTeamFirstTurn
            // 
            cboTeamFirstTurn.FormattingEnabled = true;
            cboTeamFirstTurn.Items.AddRange(new object[] { "Red", "White" });
            cboTeamFirstTurn.Location = new Point(452, 127);
            cboTeamFirstTurn.Name = "cboTeamFirstTurn";
            cboTeamFirstTurn.Size = new Size(151, 28);
            cboTeamFirstTurn.TabIndex = 39;
            cboTeamFirstTurn.Text = "Red";
            cboTeamFirstTurn.SelectedIndexChanged += cboTeamFirstTurn_SelectedIndexChanged;
            // 
            // numTerrain
            // 
            numTerrain.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numTerrain.Location = new Point(762, 322);
            numTerrain.Maximum = new decimal(new int[] { 9900, 0, 0, 0 });
            numTerrain.Name = "numTerrain";
            numTerrain.Size = new Size(150, 27);
            numTerrain.TabIndex = 38;
            numTerrain.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numTerrain.ValueChanged += numTerrain_ValueChanged;
            // 
            // cbTerrain
            // 
            cbTerrain.AutoSize = true;
            cbTerrain.Location = new Point(762, 292);
            cbTerrain.Name = "cbTerrain";
            cbTerrain.Size = new Size(138, 24);
            cbTerrain.TabIndex = 37;
            cbTerrain.Text = "TerrainBuff/Nerf";
            cbTerrain.UseVisualStyleBackColor = true;
            cbTerrain.CheckedChanged += cbTerrain_CheckedChanged;
            // 
            // numReincarnation
            // 
            numReincarnation.Location = new Point(762, 227);
            numReincarnation.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numReincarnation.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numReincarnation.Name = "numReincarnation";
            numReincarnation.Size = new Size(150, 27);
            numReincarnation.TabIndex = 36;
            numReincarnation.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numReincarnation.ValueChanged += numReincarnation_ValueChanged;
            // 
            // cbReincarnation
            // 
            cbReincarnation.AutoSize = true;
            cbReincarnation.Location = new Point(762, 197);
            cbReincarnation.Name = "cbReincarnation";
            cbReincarnation.Size = new Size(219, 24);
            cbReincarnation.TabIndex = 35;
            cbReincarnation.Text = "Change Reincarnation Count";
            cbReincarnation.UseVisualStyleBackColor = true;
            cbReincarnation.CheckedChanged += cbReincarnation_CheckedChanged;
            // 
            // num_LpCap
            // 
            num_LpCap.Location = new Point(762, 127);
            num_LpCap.Maximum = new decimal(new int[] { 65000, 0, 0, 0 });
            num_LpCap.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_LpCap.Name = "num_LpCap";
            num_LpCap.Size = new Size(150, 27);
            num_LpCap.TabIndex = 34;
            num_LpCap.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            num_LpCap.ValueChanged += LpCapNumericInput_ValueChanged;
            // 
            // cb_AllowAllDuels
            // 
            cb_AllowAllDuels.AutoSize = true;
            cb_AllowAllDuels.Location = new Point(27, 371);
            cb_AllowAllDuels.Name = "cb_AllowAllDuels";
            cb_AllowAllDuels.Size = new Size(186, 24);
            cb_AllowAllDuels.TabIndex = 33;
            cb_AllowAllDuels.Text = "Allow All Custom Duels";
            cb_AllowAllDuels.UseVisualStyleBackColor = true;
            cb_AllowAllDuels.CheckedChanged += cb_AllowAllDuels_CheckedChanged;
            // 
            // cb_AIPassFix
            // 
            cb_AIPassFix.AutoSize = true;
            cb_AIPassFix.Location = new Point(27, 113);
            cb_AIPassFix.Name = "cb_AIPassFix";
            cb_AIPassFix.Size = new Size(335, 24);
            cb_AIPassFix.TabIndex = 32;
            cb_AIPassFix.Text = "AI Passes instead of double X (recommended)";
            cb_AIPassFix.UseVisualStyleBackColor = true;
            cb_AIPassFix.CheckedChanged += cb_AIPassFix_CheckedChanged;
            // 
            // cb_ChangeMakoBattleTheme
            // 
            cb_ChangeMakoBattleTheme.AutoSize = true;
            cb_ChangeMakoBattleTheme.Location = new Point(27, 327);
            cb_ChangeMakoBattleTheme.Name = "cb_ChangeMakoBattleTheme";
            cb_ChangeMakoBattleTheme.Size = new Size(214, 24);
            cb_ChangeMakoBattleTheme.TabIndex = 31;
            cb_ChangeMakoBattleTheme.Text = "Change Mako Battle Theme";
            cb_ChangeMakoBattleTheme.UseVisualStyleBackColor = true;
            cb_ChangeMakoBattleTheme.CheckedChanged += cb_ChangeMakoBattleTheme_CheckedChanged;
            // 
            // cb_AllFusions
            // 
            cb_AllFusions.AutoSize = true;
            cb_AllFusions.Location = new Point(27, 283);
            cb_AllFusions.Name = "cb_AllFusions";
            cb_AllFusions.Size = new Size(208, 24);
            cb_AllFusions.TabIndex = 30;
            cb_AllFusions.Text = "Allow non-monster fusions\r\n";
            cb_AllFusions.UseVisualStyleBackColor = true;
            cb_AllFusions.CheckedChanged += cb_AllFusions_CheckedChanged;
            // 
            // cb_ExpandedZoom
            // 
            cb_ExpandedZoom.AutoSize = true;
            cb_ExpandedZoom.Location = new Point(27, 243);
            cb_ExpandedZoom.Name = "cb_ExpandedZoom";
            cb_ExpandedZoom.Size = new Size(141, 24);
            cb_ExpandedZoom.TabIndex = 29;
            cb_ExpandedZoom.Text = "Expanded Zoom";
            cb_ExpandedZoom.UseVisualStyleBackColor = true;
            cb_ExpandedZoom.CheckedChanged += cb_ExpandedZoom_CheckedChanged;
            // 
            // cb_RemoveSlotRng
            // 
            cb_RemoveSlotRng.AutoSize = true;
            cb_RemoveSlotRng.Location = new Point(27, 201);
            cb_RemoveSlotRng.Name = "cb_RemoveSlotRng";
            cb_RemoveSlotRng.Size = new Size(189, 24);
            cb_RemoveSlotRng.TabIndex = 28;
            cb_RemoveSlotRng.Text = "Remove RNG from slots";
            cb_RemoveSlotRng.UseVisualStyleBackColor = true;
            cb_RemoveSlotRng.CheckedChanged += cb_RemoveSlotRng_CheckedChanged;
            // 
            // lbl_Options
            // 
            lbl_Options.AutoSize = true;
            lbl_Options.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Options.Location = new Point(27, 60);
            lbl_Options.Name = "lbl_Options";
            lbl_Options.Size = new Size(161, 25);
            lbl_Options.TabIndex = 27;
            lbl_Options.Text = "Modding Options";
            // 
            // cb_LpCap
            // 
            cb_LpCap.AutoSize = true;
            cb_LpCap.Location = new Point(762, 97);
            cb_LpCap.Name = "cb_LpCap";
            cb_LpCap.Size = new Size(130, 24);
            cb_LpCap.TabIndex = 26;
            cb_LpCap.Text = "Change LP Cap";
            cb_LpCap.UseVisualStyleBackColor = true;
            cb_LpCap.CheckedChanged += cb_LpCap_CheckedChanged;
            // 
            // cb_RemoveNegetiveExp
            // 
            cb_RemoveNegetiveExp.AutoSize = true;
            cb_RemoveNegetiveExp.Location = new Point(27, 156);
            cb_RemoveNegetiveExp.Name = "cb_RemoveNegetiveExp";
            cb_RemoveNegetiveExp.Size = new Size(177, 24);
            cb_RemoveNegetiveExp.TabIndex = 25;
            cb_RemoveNegetiveExp.Text = "Remove Negetive Exp";
            cb_RemoveNegetiveExp.UseVisualStyleBackColor = true;
            cb_RemoveNegetiveExp.CheckedChanged += cb_RemoveNegetiveExp_CheckedChanged;
            // 
            // CurrentStatus
            // 
            CurrentStatus.AutoSize = true;
            CurrentStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentStatus.Location = new Point(802, 449);
            CurrentStatus.Name = "CurrentStatus";
            CurrentStatus.Size = new Size(127, 25);
            CurrentStatus.TabIndex = 24;
            CurrentStatus.Text = "Current Status:";
            // 
            // btn_Start
            // 
            btn_Start.BackColor = Color.White;
            btn_Start.Location = new Point(802, 569);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(127, 44);
            btn_Start.TabIndex = 23;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // tbFusions
            // 
            tbFusions.Controls.Add(label2);
            tbFusions.Location = new Point(4, 29);
            tbFusions.Name = "tbFusions";
            tbFusions.Padding = new Padding(3);
            tbFusions.Size = new Size(1008, 674);
            tbFusions.TabIndex = 1;
            tbFusions.Text = "Fusions";
            tbFusions.UseVisualStyleBackColor = true;
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
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tcMaster.ResumeLayout(false);
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTerrain).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReincarnation).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_LpCap).EndInit();
            tbFusions.ResumeLayout(false);
            tbFusions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private Label lblTeamFirst;
        private ComboBox cbo_ForceStartSide;
        private CheckBox cbTeamStart;
        private CheckBox cbTeamFirstTurn;
        private ComboBox cboTeamFirstTurn;
        private NumericUpDown numTerrain;
        private CheckBox cbTerrain;
        private NumericUpDown numReincarnation;
        private CheckBox cbReincarnation;
        private NumericUpDown num_LpCap;
        private CheckBox cb_AllowAllDuels;
        private CheckBox cb_AIPassFix;
        private CheckBox cb_ChangeMakoBattleTheme;
        private CheckBox cb_AllFusions;
        private CheckBox cb_ExpandedZoom;
        private CheckBox cb_RemoveSlotRng;
        private Label lbl_Options;
        private CheckBox cb_LpCap;
        private CheckBox cb_RemoveNegetiveExp;
        public Label CurrentStatus;
        public Button btn_Start;
        private TabPage tbFusions;
        private Label label2;
    }
}