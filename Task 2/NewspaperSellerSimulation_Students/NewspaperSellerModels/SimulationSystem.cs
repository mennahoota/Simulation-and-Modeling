using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions  = new List<DemandDistribution>();
            SimulationTable      = new List<SimulationCase>();
            PerformanceMeasures  = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution>  DemandDistributions { get; set; }

        ///////////// DIFINED VARIABLES /////////////
        private Random rnd = new Random();

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
       
        public void InputData(string[] lines)
        {
            int stringType = 0;
            char[] delimiters = { ',', ' ' };
            foreach (string line in lines) {
                if (line == "\n" || line.Length == 0) continue;
                switch (line)
                {
                    case "NumOfNewspapers":
                        stringType = 1;
                        continue;
                    case "NumOfRecords":
                        stringType = 2;
                        continue;
                    case "PurchasePrice":
                        stringType = 3;
                        continue;
                    case "ScrapPrice":
                        stringType = 4;
                        continue;
                    case "SellingPrice":
                        stringType = 5;
                        continue;
                    case "DayTypeDistributions":
                        stringType = 6;
                        continue;
                    case "DemandDistributions":
                        stringType = 7;
                        continue;
                }

                switch (stringType)
                {
                    case 1:
                        NumOfNewspapers = int.Parse(line);
                        break;
                    case 2:
                        NumOfRecords = int.Parse(line);
                        break;
                    case 3:
                        PurchasePrice = decimal.Parse(line);
                        break;
                    case 4:
                        ScrapPrice = decimal.Parse(line);
                        break;
                    case 5:
                        SellingPrice = decimal.Parse(line);
                        break;
                    case 6:
                        string[] distributions = line.Split(delimiters);
                        int type = 0;
                        decimal cummProb = 0;
                        foreach (string distribution in distributions)
                        {
                            if (distribution.Length == 0) 
                                continue;
                            DayTypeDistribution DTD = new DayTypeDistribution();
                            DTD.DayType = (Enums.DayType)type;
                            DTD.Probability = decimal.Parse(distribution);
                            DTD.MinRange = decimal.ToInt32(cummProb * 100 + 1);
                            cummProb += DTD.Probability;
                            DTD.MaxRange = decimal.ToInt32(cummProb * 100);
                            DTD.CummProbability = cummProb;
                            type += 1;

                            DayTypeDistributions.Add(DTD);
                        }
                        break;
                    case 7:
                        string[] numbers = line.Split(delimiters);
                        int typeCase7 = 0;
                        bool flag = false;
                        DemandDistribution DD = new DemandDistribution();
                        foreach (string number in numbers)
                        {
                            if (number.Length == 0)
                                continue;
                            if (flag)
                            {
                                DayTypeDistribution DTD = new DayTypeDistribution();
                                DTD.DayType = (Enums.DayType)typeCase7;
                                DTD.Probability = decimal.Parse(number);
                                typeCase7 += 1;

                                DD.DayTypeDistributions.Add(DTD);
                            }
                            else
                            {
                                flag = true;
                                DD.Demand = int.Parse(number);
                            }
                        }
                        DemandDistributions.Add(DD);
                        break;
                }
            }

            decimal[] cummSum = { 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < DemandDistributions.Count; j++)
                {
                    DemandDistributions[j].DayTypeDistributions[i].MinRange = decimal.ToInt32(cummSum[i] * 100 + 1);
                    cummSum[i] += DemandDistributions[j].DayTypeDistributions[i].Probability;
                    DemandDistributions[j].DayTypeDistributions[i].MaxRange = decimal.ToInt32(cummSum[i] * 100);
                    DemandDistributions[j].DayTypeDistributions[i].CummProbability = cummSum[i];
                }
            }

            UnitProfit = SellingPrice - PurchasePrice;
        }

        public void Simulate()
        {
            PerformanceMeasures.DaysWithMoreDemand = 0;
            PerformanceMeasures.DaysWithUnsoldPapers = 0;
            PerformanceMeasures.TotalCost = 0;
            PerformanceMeasures.TotalLostProfit = 0;
            PerformanceMeasures.TotalNetProfit = 0;
            PerformanceMeasures.TotalSalesProfit = 0;
            PerformanceMeasures.TotalScrapProfit = 0;

            for (int i = 1; i <= NumOfRecords; i++) {
                SimulationCase sc = new SimulationCase();
                sc.DayNo = i;

                sc.RandomNewsDayType = rnd.Next(1, 101);
                foreach (DayTypeDistribution DTD in DayTypeDistributions) {
                    if (sc.RandomNewsDayType >= DTD.MinRange && sc.RandomNewsDayType <= DTD.MaxRange)
                        sc.NewsDayType = DTD.DayType;
                }

                sc.RandomDemand = rnd.Next(1, 101);
                foreach (DemandDistribution DD in DemandDistributions) {
                    if (sc.RandomDemand >= DD.DayTypeDistributions[(int)sc.NewsDayType].MinRange && sc.RandomDemand <= DD.DayTypeDistributions[(int)sc.NewsDayType].MaxRange)
                        sc.Demand = DD.Demand;
                }

                sc.SalesProfit = Math.Min(NumOfNewspapers, sc.Demand) * SellingPrice;
                PerformanceMeasures.TotalSalesProfit += sc.SalesProfit;

                sc.ScrapProfit = Math.Max(0, NumOfNewspapers - sc.Demand) * ScrapPrice;
                PerformanceMeasures.TotalScrapProfit += sc.ScrapProfit;
                PerformanceMeasures.DaysWithUnsoldPapers += (sc.ScrapProfit > 0)? 1: 0;

                sc.LostProfit = Math.Max(0, sc.Demand - NumOfNewspapers) * UnitProfit;
                PerformanceMeasures.TotalLostProfit += sc.LostProfit;
                PerformanceMeasures.DaysWithMoreDemand += (sc.LostProfit > 0) ? 1 : 0;

                sc.DailyCost = NumOfNewspapers * PurchasePrice;
                PerformanceMeasures.TotalCost += sc.DailyCost;

                sc.DailyNetProfit = sc.SalesProfit - sc.DailyCost - sc.LostProfit + sc.ScrapProfit;
                PerformanceMeasures.TotalNetProfit += sc.DailyNetProfit;

                SimulationTable.Add(sc);
            }
        }

        public void ClearSystem()
        {
            DayTypeDistributions.Clear();
            DemandDistributions.Clear(); 
            SimulationTable.Clear();      
        }
    }
}
