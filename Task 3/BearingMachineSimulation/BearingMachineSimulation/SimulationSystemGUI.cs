using BearingMachineTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BearingMachineSimulation
{
    public partial class SimulationSystemGUI : Form
    {
        public SimulationSystemGUI()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SimulationButton_Click(object sender, EventArgs e)
        {
            Program.simulationSystem.Simulate();

            dataGridView1.DataSource = Program.simulationSystem.CurrentSimulationTable;
            dataGridView2.DataSource = Program.simulationSystem.ProposedSimulationTable;

            totalCurrentCost.Text = Program.simulationSystem.CurrentPerformanceMeasures.TotalCost.ToString();
            totalProposedCost.Text = Program.simulationSystem.ProposedPerformanceMeasures.TotalCost.ToString();
            
            string result = TestingManager.Test(Program.simulationSystem, "TestCase1.txt");
            MessageBox.Show(result);
        }
    }
}
