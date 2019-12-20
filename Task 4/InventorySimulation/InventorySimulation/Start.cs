using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;

namespace InventorySimulation
{
    public partial class Start : Form
    {
        public static string testCase;

        public Start() {
            InitializeComponent();
            Program.simulationSystem = new InventoryModels.SimulationSystem();
        }

        private void Start_Load(object sender, EventArgs e) {
            for (int i = 1; i <= 4; i++) {
                FileNames.Items.Add("TestCase" + i.ToString());
            }
            Next.Enabled = false;
        }

        private void Next_Click(object sender, EventArgs e) {
            testCase = FileNames.SelectedItem.ToString();
            try {
                HelperFunctions.ReadInput(testCase, ref Program.simulationSystem);
            }
            catch {
                MessageBox.Show("An Error has occurred");
            }
            SimulationGUI next = new SimulationGUI();
            next.Show();
            this.Hide();
        }

        private void FileNames_SelectedIndexChanged(object sender, EventArgs e) {
            Next.Enabled = true;
        }
    }
}
