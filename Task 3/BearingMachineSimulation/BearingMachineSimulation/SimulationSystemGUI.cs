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
        }
    }
}
