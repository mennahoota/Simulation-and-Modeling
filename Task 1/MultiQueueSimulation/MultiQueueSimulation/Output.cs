using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation {
    public partial class Output : Form {
        public Output() {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e) {
            if(Program.system.endTime == 0)
                Program.system.Simulate();

            dg_output.DataSource = Program.system.SimulationTable;
            dg_output.Show();
        }
    }
}
