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
    public partial class arriv_dist : Form
    {
        public arriv_dist()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            decimal cum_prob = 0;
            for (int r = 0; r < dg_arriv.Rows.Count - 1; r++) {
                int time = int.Parse(dg_arriv.Rows[r].Cells[0].Value.ToString());
                decimal prob = decimal.Parse(dg_arriv.Rows[r].Cells[1].Value.ToString());

                MultiQueueModels.TimeDistribution ts = new MultiQueueModels.TimeDistribution();
                ts.Time = time;
                ts.Probability = prob;

                decimal minRange = cum_prob * 100 + 1; // minRange = old cum + 1
                ts.MinRange = decimal.ToInt32(minRange);

                cum_prob += prob;   
                ts.CummProbability = cum_prob;

                decimal maxRange = cum_prob * 100; //maxRange = current cum 
                ts.MaxRange = decimal.ToInt32(maxRange);

                Program.system.InterarrivalDistribution.Add(ts);
            }
            this.Close();
        }
    }
}
