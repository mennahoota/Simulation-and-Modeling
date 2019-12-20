using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        #region Inputs
        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }
        #endregion

        #region Outputs
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        #endregion

        public void Simulate() {
            //Fill Demand Distribution
            List<Distribution> tempDemandDist = new List<Distribution>();
            tempDemandDist = DemandDistribution;
            HelperFunctions.CalcDistributionValues(ref tempDemandDist);
            DemandDistribution = tempDemandDist;

            //Fill Lead Days Distribution
            List<Distribution> tempLeadDaysDist = new List<Distribution>();
            tempLeadDaysDist = LeadDaysDistribution;
            HelperFunctions.CalcDistributionValues(ref tempLeadDaysDist);
            LeadDaysDistribution = tempLeadDaysDist;

            Tuple<decimal, decimal> values = FillSimulationTable();

            MeasurePerformance(values.Item1, values.Item2);
        }

        public Tuple<decimal, decimal> FillSimulationTable() {
            int orderArrival = StartLeadDays + 1, orderQuantity = StartOrderQuantity;
            int lastInventory = StartInventoryQuantity, lastShortage = 0;
            decimal totalEnding = 0, totalShortage = 0;
            for (int i = 0; i < NumberOfDays; i++) {
                SimulationCase Case = new SimulationCase();

                Case.Day = i + 1;

                decimal cycle = decimal.Divide(Case.Day, ReviewPeriod);
                Case.Cycle = Convert.ToInt32(Math.Ceiling(cycle));

                Case.DayWithinCycle = Case.Day % 5;
                if (Case.DayWithinCycle == 0)
                    Case.DayWithinCycle = 5;

                Case.BeginningInventory = lastInventory;
                if (Case.Day == orderArrival)
                    Case.BeginningInventory += orderQuantity;

                Tuple<int, int> demand = HelperFunctions.GetNumber("Demand", DemandDistribution);
                Case.RandomDemand = demand.Item1;
                Case.Demand = demand.Item2;

                Case.EndingInventory = Case.BeginningInventory - Case.Demand;

                if (Case.Day == orderArrival) {
                    Case.EndingInventory -= lastShortage;
                    lastShortage = 0;
                }

                Case.ShortageQuantity = lastShortage;
                if (Case.EndingInventory < 0) {
                    Case.ShortageQuantity -= Case.EndingInventory;
                    Case.EndingInventory = 0;
                }
			
                if (Case.DayWithinCycle == 5) { // Review
					Tuple<int, int> leadDays = HelperFunctions.GetNumber("LeadDays", LeadDaysDistribution);
					Case.RandomLeadDays = leadDays.Item1;
					Case.LeadDays = leadDays.Item2;
                    Case.OrderQuantity = OrderUpTo - Case.EndingInventory + Case.ShortageQuantity;
                    if (Case.OrderQuantity > 0) { // Place order
                        orderArrival = Case.Day + Case.LeadDays + 1;
                        orderQuantity = Case.OrderQuantity;
                    }
                }

                if (orderArrival >= Case.Day + 1)
                    Case.DaysUntilOrderArrives = orderArrival - (Case.Day + 1);

                SimulationTable.Add(Case);

                // Update data
                lastInventory = Case.EndingInventory;
                lastShortage = Case.ShortageQuantity;
                totalEnding += Case.EndingInventory;
                totalShortage += Case.ShortageQuantity;
            }

            return new Tuple<decimal, decimal>(totalEnding, totalShortage);
        }

        public void MeasurePerformance(decimal totalEnding, decimal totalShortage) {
            PerformanceMeasures.EndingInventoryAverage = totalEnding / NumberOfDays;
            PerformanceMeasures.ShortageQuantityAverage = totalShortage / NumberOfDays;
        }
    }
}
