using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class SimulationTable : Form
    {
        public SimulationTable()
        {
            InitializeComponent();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            SimulationCase sc = new SimulationCase();
            sc.DailyCost = Program.system.PerformanceMeasures.TotalCost;
            sc.SalesProfit = Program.system.PerformanceMeasures.TotalSalesProfit;
            sc.LostProfit = Program.system.PerformanceMeasures.TotalLostProfit;
            sc.ScrapProfit = Program.system.PerformanceMeasures.TotalScrapProfit;
            sc.DailyNetProfit = Program.system.PerformanceMeasures.TotalNetProfit;
            Program.system.SimulationTable.Add(sc);

            dgv_simulationTable.DataSource = Program.system.SimulationTable;

            lbl_excessDemandNum.Text = Program.system.PerformanceMeasures.DaysWithMoreDemand.ToString();
            lbl_unsoldPapersNum.Text = Program.system.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
        }
    }
}
