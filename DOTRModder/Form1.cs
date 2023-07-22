using DOTRModder.MapRelated;
using Newtonsoft.Json;
using System.Diagnostics;
using NAudio.Wave;
using System.Reflection;

using CheckBox = System.Windows.Forms.CheckBox;
using System.Windows.Forms;
using DOTRModder.Properties;

namespace DOTRModder
{
    public partial class Form1 : Form
    {
        Process process;

        public delegate void updateMainLabelDelegate(String labelString); // delegate type 
        public updateMainLabelDelegate updateMainlabel;

        public delegate void StopSelectionChanges();
        public StopSelectionChanges stopSelectionChanges;

        public static event Action<SimpleModBools, bool> UpdateSimpleBoolCheckbox;
        public static event Action<ModBoolsIntPair, bool, int> UpdateBoolAndIntCheckbox;
        public static event Action<int[], int[]> SaveSlots;
        public static event Action<int[], int[]> SaveMusic;
        public static int[] SpecialThreeInARows = Enumerable.Repeat(671, 30).ToArray();
        public static int[] SpecialSlotRewards = Enumerable.Repeat(0, 30).ToArray();
        public static SavedData savedData = new SavedData { Checkboxes = new Dictionary<string, bool>(), Values = new Dictionary<string, int>() };
        public static bool hasSaved = false;
        private WaveOutEvent waveOut;
        private Mp3FileReader mp3Reader;
        private bool isMusicPlaying = false;
        private string CurrentSongSelected;
        private int CurrentDuelistMusicSelected;

        public static string SaveFilePath = "DOTRModderConfig.json";
        public struct SavedData
        {
            public Dictionary<string, bool> Checkboxes;
            public Dictionary<string, int> Values;
            public Dictionary<int, string> DuelistMusic;
            public int[] SlotThreeInARow;
            public int[] SlotRewards;
            public string LastSaveFilePath;
            public DotrMap map;
        }
        public DotrMap[] maps = new DotrMap[46];
        DotrMap currentMap = new DotrMap();
        byte[] EditMapFileIso;
        public string editMapISOPath = string.Empty;
        Terrain selectedTile = Terrain.NORMAL;
        private bool isClickAndDrag = false;
        public Dictionary<int, string> DuelistMusic = new Dictionary<int, string>();



        public Form1()
        {
            //Mem.AllocConsole();
            InitializeComponent();
            InitDataGridView();
            updateMainlabel = new updateMainLabelDelegate(updateCurrentStatus);
            stopSelectionChanges = new StopSelectionChanges(LockAllSelection);
            CurrentStatus.Text = "Press Start When Ready";
            scEditMapMain.IsSplitterFixed = true;
            scEditMapTiles.IsSplitterFixed = true;
            scEditMapToSelect.IsSplitterFixed = true;
            RefreshEditor.Interval = 1000 / 60;
            RefreshEditor.Enabled = true;
            SetDoubleBuffered(scEditMapMain);
            SetDoubleBuffered(scEditMapMain.Panel2);
            UpdateStyles();
            LoadDefaultMaps();
            MakeFusionsSortable();
            LoadDefaultMusic();
            waveOut = new WaveOutEvent();
            waveOut.Volume = 0.1f;
            lbMusicNum.Enabled = false;




        }



        public void MakeFusionsSortable()
        {
            foreach (var item in dgvFusions.Columns)
            {
                DataGridViewColumn column = item as DataGridViewColumn;
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

        }
        public void SetTabsEnabled(bool enabled)
        {
            foreach (TabPage tabPage in tcMaster.TabPages)
            {
                tabPage.Enabled = enabled;
            }
        }
        public void LoadData()
        {
            this.ActiveControl = null;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Json files (*.json)|*.json";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    string json = File.ReadAllText(filePath);
                    savedData = JsonConvert.DeserializeObject<SavedData>(json);
                    LoadGenericData();
                    LoadSlotsData();
                    LoadMusicData();

                }

            }
        }


        public void SaveData(bool showBox)
        {
            this.ActiveControl = null;
            if (showBox)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json files (*.json)|*.json";
                saveFileDialog1.Title = "Save Json Config File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    SaveGenericData();
                    SaveSlotsData();
                    SaveMusicData();
                    SaveFilePath = saveFileDialog1.FileName;
                    savedData.LastSaveFilePath = SaveFilePath;
                    string json = JsonConvert.SerializeObject(savedData);
                    File.WriteAllText(saveFileDialog1.FileName, json);
                    hasSaved = true;

                }
            }
            else
            {
                if (!hasSaved)
                {
                    SaveGenericData();
                    SaveSlotsData();
                    SaveMusicData();
                    string json = JsonConvert.SerializeObject(savedData);
                    File.WriteAllText(SaveFilePath, json);
                }
            }


        }

      

        void SaveGenericData()
        {
            if (tcMaster.Controls[0] is TabPage page)
            {
                var controls = page.Controls;
                foreach (var control in controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        if (!savedData.Checkboxes.TryAdd(checkBox.Name, checkBox.Checked))
                        {
                            savedData.Checkboxes[checkBox.Name] = checkBox.Checked;
                        }

                    }
                    else if (control is NumericUpDown)
                    {
                        NumericUpDown numericUpDown = (NumericUpDown)control;
                        if (!savedData.Values.TryAdd(numericUpDown.Name, Convert.ToInt32(numericUpDown.Value)))
                        {
                            savedData.Values[numericUpDown.Name] = Convert.ToInt32(numericUpDown.Value);
                        }

                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (!savedData.Values.TryAdd(comboBox.Name, comboBox.SelectedIndex))
                        {
                            savedData.Values[comboBox.Name] = comboBox.SelectedIndex;
                        }

                    }

                }
            }
        }


        void SaveSlotsData()
        {
            BindSlotRewards();
            savedData.SlotThreeInARow = SpecialThreeInARows;
            savedData.SlotRewards = SpecialSlotRewards;
        }
        private void SaveMusicData()
        {
            savedData.DuelistMusic = DuelistMusic;
        }

        void LoadSlotsData()
        {
            SpecialThreeInARows = savedData.SlotThreeInARow;
            SpecialSlotRewards = savedData.SlotRewards;
            for (int i = 0; i < 30; i++)
            {
                DataGridViewComboBoxCell threeCell = SlotRewardsDataGridView.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                threeCell.Value = threeCell.Items[SpecialThreeInARows[i]];
                DataGridViewComboBoxCell rewardCell = SlotRewardsDataGridView.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                rewardCell.Value = rewardCell.Items[SpecialSlotRewards[i]];
            }
        }
        void LoadMusicData()
        {
            DuelistMusic = savedData.DuelistMusic;
        }


        private void LoadGenericData()
        {
            if (tcMaster.Controls[0] is TabPage page)
            {
                var controls = page.Controls;
                foreach (var control in controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        if (savedData.Checkboxes.TryGetValue(checkBox.Name, out var value))
                        {
                            checkBox.Checked = value;
                        }

                    }
                    else if (control is NumericUpDown)
                    {
                        NumericUpDown numericUpDown = (NumericUpDown)control;
                        if (savedData.Values.TryGetValue(numericUpDown.Name, out var value))
                        {
                            numericUpDown.Value = value;
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (savedData.Values.TryGetValue(comboBox.Name, out var value))
                        {
                            comboBox.SelectedIndex = value;
                        }
                    }

                }
            }
            /*
            cb_AIPassFix.Checked = savedData.AIPassCheck;
            cb_RemoveNegetiveExp.Checked = savedData.NegExpCheck;
            cb_RemoveSlotRng.Checked = savedData.SlotRngCheck;
            cb_ExpandedZoom.Checked = savedData.ZoomCheck;
            cb_AllFusions.Checked = savedData.AllFusionsCheck;
            cb_ChangeMakoBattleTheme.Checked = savedData.MakoThemeCheck;
            cb_AllowAllDuels.Checked = savedData.CustomDuelsCheck;
            cb_AdditionalSlotRewards.Checked = savedData.SlotRewardsCheck;
            cb_SideFirst.Checked = savedData.SideFirstCheck;
            cb_ForceStartSide.Checked = savedData.ForceSideStartCheck;
            cb_LpCap.Checked = savedData.LpCapCheck;
            cb_Reincarnation.Checked = savedData.ReincarnationCheck;
            cb_Terrain.Checked = savedData.TerrainCheck;
            */
        }

        private Size oldSize;
        private void Form1_Load(object sender, EventArgs e)
        {
            oldSize = base.Size;
            Main.Preload();

        }



        void LockAllSelection()
        {

            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            SetTabsEnabled(false);

        }
        void updateCurrentStatus(string str)
        {
            CurrentStatus.Text = str;
            Application.DoEvents();
        }




        private void btn_Start_Click(object sender, EventArgs e)
        {
            stopSelectionChanges();
            stopMusic();
            CurrentStatus.Text = "Current Status:\nWaiting For Pcsx2";

            btn_Start.Enabled = false;
            Process[] processes = Process.GetProcessesByName("pcsx2");
            while (processes == null || processes.Length < 1)
            {
                //Replace with Text on Form  

                processes = Process.GetProcessesByName("pcsx2");
                Application.DoEvents();

            }
            process = Process.GetProcessesByName("pcsx2")[0];

            Thread thread = new Thread(delegate ()
            {

                Main.Init(process, this);
            });
            thread.IsBackground = true;
            thread.Start();


        }

        

        private void cbCustomMaps_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.UseCustomMaps, box.Checked);

        }
        private void cb_AIPassFix_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.AIInputFix, box.Checked);
        }

        private void cb_RemoveNegetiveExp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.Exp, box.Checked);
        }

        private void cb_ChangeLPCap(object sender, EventArgs e)
        {

            UpdateBoolAndIntCheckbox(ModBoolsIntPair.LPCap, cb_LpCap.Checked, Convert.ToInt32(num_LpCap.Value));
        }

        private void cb_RemoveSlotRng_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.RemoveSlotRng, box.Checked);
        }

        private void cb_ExpandedZoom_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.ExpandZoom, box.Checked);
        }

        private void cb_AllFusions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.AllFusions, box.Checked);
        }

        private void cb_ChangeMakoBattleTheme_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.CustomMusic, box.Checked);
        }

        private void cb_AllowAllDuels_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.AllCustomDuels, box.Checked);


        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }

        private void numReincarnation_ValueChanged(object sender, EventArgs e)
        {
            if (cb_Reincarnation.Checked)
            {

                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.Reincarnation, true, Convert.ToInt32(num_Reincarnation.Value));
            }
        }

        private void cbReincarnation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.Reincarnation, cb_Reincarnation.Checked, Convert.ToInt32(num_Reincarnation.Value));
        }

        private void cboTeamFirstTurn_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_SideFirst.Checked)
            {
                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.FirstTurnTeam, true, cbo_TeamFirstTurn.SelectedIndex);

            }
        }

        private void cbTeamFirstTurn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.FirstTurnTeam, cb_SideFirst.Checked, cbo_TeamFirstTurn.SelectedIndex);
        }

        private void cbTeamStart_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.ForceStartTeam, cb_ForceStartSide.Checked, cbo_ForceStartSide.SelectedIndex);
        }

        private void cbo_ForceStartSide_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_ForceStartSide.Checked)
            {
                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.ForceStartTeam, true, cbo_ForceStartSide.SelectedIndex);
            }
        }

        private void numTerrain_ValueChanged(object sender, EventArgs e)
        {
            if (cb_Terrain.Checked)
            {
                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.TerrainBuff, true, Convert.ToInt32(num_Terrain.Value));
            }
        }

        private void cbTerrain_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.TerrainBuff, cb_Terrain.Checked, Convert.ToInt32(num_Terrain.Value));
        }

        private void cb_LpCap_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox(ModBoolsIntPair.LPCap, cb_LpCap.Checked, Convert.ToInt32(num_LpCap.Value));
        }


        private void num_LpCap_ValueChanged(object sender, EventArgs e)
        {
            if (cb_LpCap.Checked)
            {
                UpdateBoolAndIntCheckbox(ModBoolsIntPair.LPCap, true, Convert.ToInt32(num_LpCap.Value));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }



        private void btn_SaveSlots_Click(object sender, EventArgs e)
        {
            BindSlotRewards();
            SaveSlots.Invoke(SpecialThreeInARows, SpecialSlotRewards);
            MessageBox.Show("Saved Slot Rares");
        }

        private void cb_AdditionalSlotRewards_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.ExtraSlotRewards, box.Checked);

        }

        private void SlotRewardsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            }


        }

        private void cboTeamFirstTurn_Leave(object sender, EventArgs e)
        {
            if (cbo_TeamFirstTurn.SelectedIndex == -1)
            {
                cbo_TeamFirstTurn.SelectedItem = cbo_TeamFirstTurn.Items[0];
            }
        }

        private void cbo_ForceStartSide_Leave(object sender, EventArgs e)
        {
            if (cbo_ForceStartSide.SelectedIndex == -1)
            {
                cbo_ForceStartSide.SelectedItem = cbo_ForceStartSide.Items[0];
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData(false);
            Environment.Exit(Environment.ExitCode);
        }

        private void btn_DefaultSettings_Click(object sender, EventArgs e)
        {
            DefaultCheckBoxValues();
            DefaultValues();

        }

        private void DefaultCheckBoxValues()
        {
            TabPage page = tcMaster.SelectedTab;

            var controls = page.Controls;

            foreach (var control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }

        private void DefaultValues()
        {
            num_LpCap.Value = 9999;
            num_Reincarnation.Value = 5;
            num_Terrain.Value = 500;
            cbo_TeamFirstTurn.SelectedIndex = 0;
            cbo_ForceStartSide.SelectedIndex = 0;
        }

        private void DefaultSlots()
        {
            for (int i = 0; i < 30; i++)
            {
                DataGridViewComboBoxCell threeCell = SlotRewardsDataGridView.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                threeCell.Value = threeCell.Items[671];
                DataGridViewComboBoxCell rewardCell = SlotRewardsDataGridView.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                rewardCell.Value = rewardCell.Items[0];
            }
        }

        private void btnSlotDefault_Click(object sender, EventArgs e)
        {
            DefaultSlots();
        }

        private void FastIntro_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.FastIntro, box.Checked);
        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scEditMapMain_Panel2_Paint(object sender, PaintEventArgs e)
        {
            currentMap.Draw(e.Graphics, 8, 100);
        }

        public void SetDoubleBuffered(Control c)
        {
            PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(c, true, null);
        }




        private void RefreshEditor_Tick(object sender, EventArgs e)
        {
            scEditMapMain.Panel2.Invalidate();
        }



        private void pbForest_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbWasteland_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbMountain_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbMeadow_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbSea_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbYami_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbToon_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbNormal_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbLab_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }

        private void pbCrush_Click(object sender, EventArgs e)
        {
            PictureBox_Click(sender, e);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            TableLayoutPanelCellPosition cellPosition = tbPallete.GetCellPosition(clickedPictureBox);
            int column = cellPosition.Column;
            int row = cellPosition.Row;
            int value = row * tbPallete.ColumnCount + column;
            // Do something with the column and row values, such as displaying them
            ChangeSelectedTile((Terrain)value);
        }

        void ChangeSelectedTile(Terrain terrain)
        {
            selectedTile = terrain;
            pbSelectedTile.Image = MapTile.GetImageFromTerrain(terrain);
        }

        private void scEditMapMain_Panel2_MouseDown(object sender, MouseEventArgs e)
        {

            // Determine the clicked tile based on the mouse position
            for (int i = 0; i < currentMap.tiles.Length; i++)
            {
                MapTile tile = currentMap.tiles[i];
                if (tile.GetRect().Contains(e.Location))
                {
                    isClickAndDrag = true;
                    break;
                }
            }
        }


        private void scEditMapMain_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isClickAndDrag = false;
        }

        private void scEditMapMain_Panel2_MouseMove(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < currentMap.tiles.Length; i++)
            {
                if (currentMap.GetTile(i).GetRect().Contains(e.Location))
                {
                    currentMap.SetTileHovered(i, true);
                }
                else
                {
                    currentMap.SetTileHovered(i, false);
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                if (isClickAndDrag)
                {
                    // Update the image of the tiles as the mouse moves over them
                    for (int i = 0; i < currentMap.tiles.Length; i++)
                    {
                        MapTile tile = currentMap.tiles[i];
                        if (tile.GetRect().Contains(e.Location))
                        {

                            currentMap.SetTile(i, selectedTile);
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (isClickAndDrag)
                {
                    // Update the image of the tiles as the mouse moves over them
                    for (int i = 0; i < currentMap.tiles.Length; i++)
                    {
                        MapTile tile = currentMap.tiles[i];
                        if (tile.GetRect().Contains(e.Location))
                        {

                            currentMap.SetTile(i, Terrain.NORMAL);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentMap = maps[lbMapSelection.SelectedIndex];
            if (lbMapSelection.SelectedIndex != -1) // Check if an item is selected
            {
                string? selectedText = lbMapSelection.Items[lbMapSelection.SelectedIndex].ToString();
                lblMapName.Text = $"Current Map: {selectedText}";
            }



        }
        private void LoadDefaultMusic()
        {
            for (int i = 0; i < 22; i++)
            {
                DuelistMusic.TryAdd(i, lbMusicNum.Items[MusicList.defaultSongs[i] - 1].ToString());
            }
            Debug.WriteLine(DuelistMusic.ToString());
        }

        private void LoadDefaultMaps()
        {
            for (int i = 0; i < maps.Length; i++)
            {
                maps[i] = new DotrMap(VanillaMapBytes.Maps[i]);
            }
            currentMap = maps[0];
            lbMapSelection.SelectedIndex = 0;
        }


        private void LoadMapsFromIso()
        {
            for (int i = 0; i < maps.Length; i++)
            {
                int mapOffset = 0x29EF5C;
                mapOffset += i * 0x31;
                byte[] slusMap = new byte[49];
                for (int j = 0; j < slusMap.Length; j++)
                {

                    slusMap[j] = EditMapFileIso[mapOffset + j];
                }

                maps[i] = new DotrMap(slusMap);
            }
            currentMap = maps[0];
        }

        private void btnMapLoadISo_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "ISO files (*.iso)|*.iso";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        editMapISOPath = ofd.FileName;
                        EditMapFileIso = OpenIso(editMapISOPath, EditMapFileIso);
                        MessageBox.Show(ofd.SafeFileName + " Loaded");
                        lblMapCurrentISOResult.Text = $"{ofd.SafeFileName}";
                        lbMapSelection.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ISO could not be loaded. " + ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
            }
            LoadMapsFromIso();
        }
        private byte[] OpenIso(String path, byte[] memoryIso)
        {

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                memoryIso = new byte[fs.Length];
                int bytesToRead = (int)fs.Length;
                int bytesRead = 0;
                while (bytesToRead > 0)
                {
                    int b = fs.Read(memoryIso, bytesRead, bytesToRead);
                    if (b == 0)
                    {
                        break;
                    }

                    bytesRead += b;
                    bytesToRead -= b;
                }
            }

            return memoryIso;
        }

        private void btnSaveMapsToISO(object sender, EventArgs e)
        {
            if (EditMapFileIso != null)
            {


                for (int i = 0; i < maps.Length; i++)
                {
                    int mapOffset = 0x29EF5C;
                    mapOffset += i * 0x31;
                    DotrMap? map = maps[i];
                    for (int j = 0; j < map.tiles.Length; j++)
                    {

                        EditMapFileIso[mapOffset + j] = map.GetTile(j).GetTerrainAsByte();
                    }
                }
                MessageBox.Show("Written to ISO", "Success", MessageBoxButtons.OK);
                File.WriteAllBytes(editMapISOPath, EditMapFileIso);

                MessageBox.Show("Written to ISO", "Success", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("You need to load an ISO first", "Error", MessageBoxButtons.OK);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/rjoken/DOTRMap");
        }

        private void scrollFusion_Scroll(object sender, ScrollEventArgs e)
        {
            dgvFusions.FirstDisplayedScrollingRowIndex = e.NewValue;
        }


        private void LlblBlayr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/Blayr/DOTR-Modding-Tool");
        }


        private void cb_KeepReincarnatedCard_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.KeepReincarnatedCard, box.Checked);
        }

        private void stopMusic()
        {
            waveOut.Stop();
            mp3Reader?.Dispose();
            btnMusicPlay.Text = "Play";
        }
        private void btnMusicPlay_Click(object sender, EventArgs e)
        {

            if (CurrentSongSelected == null)
            {
                MessageBox.Show("No Music Currently Selected");
                return;
            }
            if (!isMusicPlaying)
            {
                // Open the file dialog to select an MP3 file

                // Load the selected MP3 file
                byte[] mp3Data = Resources.ResourceManager.GetObject(CurrentSongSelected) as byte[];
                if (mp3Data != null)
                {

                    MemoryStream stream = new MemoryStream(mp3Data);
                    mp3Reader = new Mp3FileReader(stream);
                    // Toggle the play state
                    btnMusicPlay.Text = "Stop";
                    // Update the button text
                    // Play or stop the MP3 based on the current state
                    waveOut.Init(mp3Reader);
                    waveOut.Play();

                }
                else
                {
                    MessageBox.Show($"Track {CurrentSongSelected} not Found");
                }


            }
            else
            {
                waveOut.Stop();
                mp3Reader?.Dispose();
                btnMusicPlay.Text = "Play";

            }
            isMusicPlaying = !isMusicPlaying;
        }



        private void tbMusicLevel_ValueChanged(object sender, EventArgs e)
        {
            float volume = tbMusicLevel.Value / 50f; // Convert to a value between 0 and 1
            waveOut.Volume = volume;
        }

        private void lbMusicNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMusicNum.SelectedIndex != -1)
            {
                CurrentSongSelected = lbMusicNum.Items[lbMusicNum.SelectedIndex].ToString();
                lblCurrentMusic.Text = CurrentSongSelected;
                DuelistMusic[CurrentDuelistMusicSelected] = CurrentSongSelected;
                UpdateSelectedMusic();
            }
        }

        private void lbMusicDuelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lbMusicNum.Enabled)
            {
                lbMusicNum.Enabled = true;
            }
            if (lbMusicDuelist.SelectedIndex != -1)
            {
                CurrentDuelistMusicSelected = lbMusicDuelist.SelectedIndex;
                lblCurrentlyPlayingTitle.Text = lbMusicDuelist.Items[lbMusicDuelist.SelectedIndex].ToString() + "'s current music is:";
                CurrentSongSelected = DuelistMusic[CurrentDuelistMusicSelected];
                lblCurrentMusic.Text = CurrentSongSelected;
                lbMusicNum.SelectedIndex = lbMusicNum.Items.IndexOf(CurrentSongSelected);
                UpdateSelectedMusic();
            }

        }

        private void UpdateSelectedMusic()
        {
            waveOut.Stop();
            mp3Reader?.Dispose();
            byte[] mp3Data = Resources.ResourceManager.GetObject(CurrentSongSelected) as byte[];
            if (mp3Data != null)
            {
                isMusicPlaying = true;
                MemoryStream stream = new MemoryStream(mp3Data);
                mp3Reader = new Mp3FileReader(stream);
                // Toggle the play state
                btnMusicPlay.Text = "Stop";
                // Update the button text
                // Play or stop the MP3 based on the current state
                waveOut.Init(mp3Reader);
                waveOut.Play();

            }
        }
    }



}

