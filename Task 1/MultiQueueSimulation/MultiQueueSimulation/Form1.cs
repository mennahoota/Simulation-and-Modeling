using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_service_Click(object sender, EventArgs e) {
            if(txt_num_servers.Text.Length == 0) {
                MessageBox.Show("Please enter number of servers first.");
                return;
            }
            Program.system.NumberOfServers = int.Parse(txt_num_servers.Text);
            Service_dist sd = new Service_dist();
            sd.Show();
        }

        private void btn_Inter_Arrival_Click(object sender, EventArgs e) {
            arriv_dist ad = new arriv_dist();
            ad.Show();
        }

        private void btn_Done_Click(object sender, EventArgs e) {
            Enums.SelectionMethod method;
            Enum.TryParse<Enums.SelectionMethod>(txt_method.Text, out method);
            Program.system.SelectionMethod = method;

            Enums.StoppingCriteria stop;
            Enum.TryParse<Enums.StoppingCriteria>(txt_stop.Text, out stop);
            Program.system.StoppingCriteria = stop;

            Program.system.StoppingNumber = int.Parse(txt_stop_num.Text);
            if (txt_stop.Text == "1")
                Program.system.maxCustomers = Program.system.StoppingNumber;

            btn_charts.Visible = true;
            Output output = new Output();
            output.Show();
        }

        private void btn_charts_Click(object sender, EventArgs e) {
            Chart cs = new Chart();
            cs.Show();
        }
    }
}
