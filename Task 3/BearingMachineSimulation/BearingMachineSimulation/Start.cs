using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <4; i++)
            {
                FileNames.Items.Add("TestCase"+i.ToString());
            }
            Next.Enabled = false;
        }

        private void LoadTestCase_Click(object sender, EventArgs e)
        {
            try
            {
                HelperFunctions.ReadInput(FileNames.SelectedItem.ToString(), ref Program.simulationSystem);
                Next.Enabled = true;
            }
            catch
            {
                MessageBox.Show("An Error has occurred");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            SimulationSystemGUI next = new SimulationSystemGUI();
            next.Show();
            this.Hide();
        }
    }
}
