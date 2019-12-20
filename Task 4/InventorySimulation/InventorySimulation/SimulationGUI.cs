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

namespace InventorySimulation {
    public partial class SimulationGUI : Form {
        public SimulationGUI() {
            InitializeComponent();
        }
        private void SimulationButton_Click(object sender, EventArgs e) {
            Program.simulationSystem.Simulate();
            dgv.DataSource = Program.simulationSystem.SimulationTable;
            txt_endingAvg.Text = Program.simulationSystem.PerformanceMeasures.EndingInventoryAverage.ToString();
            txt_shortageAvg.Text = Program.simulationSystem.PerformanceMeasures.ShortageQuantityAverage.ToString();

            string testingResult = TestingManager.Test(Program.simulationSystem, Start.testCase + ".txt");
            MessageBox.Show(testingResult);
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            this.Close();
            dgv.DataSource = null;
            Start start = new Start();
            start.Show();
        }
    }
}
