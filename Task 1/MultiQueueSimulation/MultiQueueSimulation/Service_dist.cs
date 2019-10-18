using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Service_dist : Form
    {
        public Service_dist()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if(currentServer != Program.system.NumberOfServers) {
                MessageBox.Show("Please enter Time Distributions of remaining servers.");
                return;
            }
            this.Close();
        }

        private static int currentServer = 0;

        private void btn_enter_Click(object sender, EventArgs e) {
            if (currentServer == Program.system.NumberOfServers) {
                MessageBox.Show("Already entered Time Distributions of all servers.");
                return;
            }

            MultiQueueModels.Server server = new MultiQueueModels.Server();
            decimal cum_prob = 0;
            for (int r = 0; r < dg_service.Rows.Count - 1; r++) {
                int time = int.Parse(dg_service.Rows[r].Cells[0].Value.ToString());
                decimal prob = decimal.Parse(dg_service.Rows[r].Cells[1].Value.ToString());

                MultiQueueModels.TimeDistribution ts = new MultiQueueModels.TimeDistribution();
                ts.Time = time;
                ts.Probability = prob;

                decimal minRange;
                if (r == 0)
                    minRange = 1;
                else
                    minRange = cum_prob * 100 + 1; // minRange = old cum + 1
                ts.MinRange = decimal.ToInt32(minRange);

                cum_prob += prob;
                ts.CummProbability = cum_prob;

                decimal maxRange = cum_prob * 100; //maxRange = current cum 
                ts.MaxRange = decimal.ToInt32(maxRange);

                server.TimeDistribution.Add(ts);
            }
            server.ID = currentServer + 1;
            server.FinishTime = 0;
            server.TotalWorkingTime = 0;
            server.NumberOfCustomers = 0;
            Program.system.Servers.Add(server);

            currentServer++;
            dg_service.Rows.Clear();
        }
    }
}
