using System.Diagnostics;
using System.Drawing;
using System.Threading;
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
        public Form1()
        {
            InitializeComponent();

            updateMainlabel = new updateMainLabelDelegate(updateCurrentStatus);
            stopSelectionChanges = new StopSelectionChanges(LockAllSelection);
            CurrentStatus.Text = "Press Start When Ready";

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Main.Preload();
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

        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numReincarnation_ValueChanged(object sender, EventArgs e)
        {
            if (cbReincarnation.Checked)
            {

                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.Reincarnation, true, Convert.ToInt32(numReincarnation.Value));
            }
        }

        private void cbReincarnation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.Reincarnation, cbReincarnation.Checked, Convert.ToInt32(numReincarnation.Value));
        }

        private void cboTeamFirstTurn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeamFirstTurn.Checked)
            {
                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.FirstTurnTeam, true, cboTeamFirstTurn.SelectedIndex);
            }
        }

        private void cbTeamFirstTurn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.FirstTurnTeam, cbTeamFirstTurn.Checked, cboTeamFirstTurn.SelectedIndex);
        }

        private void cbTeamStart_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.ForceStartTeam, cbTeamStart.Checked, cbo_ForceStartSide.SelectedIndex);
        }

        private void cbo_ForceStartSide_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeamStart.Checked)
            {
                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.ForceStartTeam, true, cbo_ForceStartSide.SelectedIndex);
            }
        }

        private void numTerrain_ValueChanged(object sender, EventArgs e)
        {
            if (cbTerrain.Checked)
            {
                UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.TerrainBuff, true, Convert.ToInt32(numTerrain.Value));
            }
        }

        private void cbTerrain_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox.Invoke(ModBoolsIntPair.TerrainBuff, cbTerrain.Checked, Convert.ToInt32(numTerrain.Value));
        }

        private void cb_LpCap_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBoolAndIntCheckbox(ModBoolsIntPair.LPCap, cb_LpCap.Checked, Convert.ToInt32(num_LpCap.Value));
        }


        private void LpCapNumericInput_ValueChanged(object sender, EventArgs e)
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
    }



}

