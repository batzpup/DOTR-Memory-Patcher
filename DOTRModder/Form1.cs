using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Windows.Forms;
using static DOTRModder.Form1;


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
        public static int[] SpecialThreeInARows = Enumerable.Repeat(671, 30).ToArray();
        public static int[] SpecialSlotRewards = Enumerable.Repeat(0, 30).ToArray();
        public static SavedData savedData = new SavedData { };
        public static bool hasSaved = false;

        public static string SaveFilePath = "DOTRModderConfig.json";
        public struct SavedData
        {
            public bool AIPassCheck;
            public bool NegExpCheck;
            public bool SlotRngCheck;
            public bool ZoomCheck;
            public bool AllFusionsCheck;
            public bool MakoThemeCheck;
            public bool CustomDuelsCheck;
            public bool SlotRewardsCheck;
            public bool SideFirstCheck;
            public bool ForceSideStartCheck;
            public bool LpCapCheck;
            public bool ReincarnationCheck;
            public bool TerrainCheck;


            public int SideFirstValue;
            public int ForceSideStartValue;
            public int LpCapValue;
            public int ReincarnationValue;
            public int TerrainValue;

            public int[] SlotThreeInARow;
            public int[] SlotRewards;

            public string LastSaveFilePath;

        }

        public Form1()
        {
            //Mem.AllocConsole();
            InitializeComponent();
            InitDataGridView();
            updateMainlabel = new updateMainLabelDelegate(updateCurrentStatus);
            stopSelectionChanges = new StopSelectionChanges(LockAllSelection);
            CurrentStatus.Text = "Press Start When Ready";

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
                    LoadBoolData();
                    LoadValues();
                    LoadSlotsData();

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
                    SaveBoolData();
                    SaveSlotsData();
                    SaveValues();
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
                    SaveBoolData();
                    SaveSlotsData();
                    SaveValues();
                    string json = JsonConvert.SerializeObject(savedData);
                    File.WriteAllText(SaveFilePath, json);
                }
            }


        }

        void SaveBoolData()
        {
            savedData.AIPassCheck = cb_AIPassFix.Checked;
            savedData.NegExpCheck = cb_RemoveNegetiveExp.Checked;
            savedData.SlotRngCheck = cb_RemoveSlotRng.Checked;
            savedData.ZoomCheck = cb_ExpandedZoom.Checked;
            savedData.AllFusionsCheck = cb_AllFusions.Checked;
            savedData.MakoThemeCheck = cb_ChangeMakoBattleTheme.Checked;
            savedData.CustomDuelsCheck = cb_AllowAllDuels.Checked;
            savedData.SlotRewardsCheck = cb_AdditionalSlotRewards.Checked;
            savedData.SideFirstCheck = cb_SideFirst.Checked;
            savedData.ForceSideStartCheck = cb_ForceStartSide.Checked;
            savedData.LpCapCheck = cb_LpCap.Checked;
            savedData.ReincarnationCheck = cb_Reincarnation.Checked;
            savedData.TerrainCheck = cb_Terrain.Checked;
        }

        void SaveValues()
        {
            savedData.LpCapValue = Convert.ToInt32(num_LpCap.Value);
            savedData.ReincarnationValue = Convert.ToInt32(num_Reincarnation.Value);
            savedData.TerrainValue = Convert.ToInt32(num_Terrain.Value);
            savedData.SideFirstValue = cbo_TeamFirstTurn.SelectedIndex;
            savedData.ForceSideStartValue = cbo_ForceStartSide.SelectedIndex;

        }
        void SaveSlotsData()
        {
            BindSlotRewards();
            savedData.SlotThreeInARow = SpecialThreeInARows;
            savedData.SlotRewards = SpecialSlotRewards;



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

        void LoadValues()
        {
            num_LpCap.Value = savedData.LpCapValue;
            num_Reincarnation.Value = savedData.ReincarnationValue;
            num_Terrain.Value = savedData.TerrainValue;
            cbo_TeamFirstTurn.SelectedIndex = savedData.SideFirstValue;
            cbo_ForceStartSide.SelectedIndex = savedData.ForceSideStartValue;

        }

        private void LoadBoolData()
        {
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

        }
        void updateCurrentStatus(string str)
        {
            CurrentStatus.Text = str;
            Application.DoEvents();
        }




        private void btn_Start_Click(object sender, EventArgs e)
        {
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
            UpdateSimpleBoolCheckbox.Invoke(SimpleModBools.MakoTheme, box.Checked);
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
    }



}

