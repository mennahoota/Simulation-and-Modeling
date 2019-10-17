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
    public partial class Chart : Form {
        public Chart() {
            InitializeComponent();
            for(int i = 0; i < Program.system.NumberOfServers; i++) {
                comboBox1.Items.Add(i + 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            chart1.Series["Busy_Time"].Points.Clear();
            int idx = int.Parse(comboBox1.SelectedItem.ToString()) - 1;
            int busyIdx = 0;
            string x, y;
            for(int i = 1; i < Program.system.endTime; i++) {
                while(busyIdx < Program.system.serverBusyTime[idx].Count &&
                    i < Program.system.serverBusyTime[idx][busyIdx]) {
                    x = i.ToString();
                    y = "0";
                    chart1.Series["Busy_Time"].Points.AddXY(x, y);
                    i++;
                }
                x = i.ToString();
                y = "1";
                chart1.Series["Busy_Time"].Points.AddXY(x, y);
                busyIdx++;
            }
        }
    }
}
