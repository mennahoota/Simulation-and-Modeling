using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels {
    public class HelperFunctions {
        static Random rnd = new Random();

        public static void ReadInput(string testCase, ref SimulationSystem simulationSystem) {
            string projectPath = System.IO.Directory.GetCurrentDirectory();
            projectPath = projectPath.Remove(projectPath.Length - 10);
            string[] lines = System.IO.File.ReadAllLines(projectPath + "\\TestCases\\" + testCase + ".txt");
            InputData(lines, ref simulationSystem);
        }

        public static void InputData(string[] lines, ref SimulationSystem simulationSystem) {
            int stringType = 0;
            char[] delimiters = { ',', ' ' };
            foreach (string line in lines) {
                if (line == "\n" || line.Length == 0 || line[0] == ' ') continue;
                switch (line) {
                    case "OrderUpTo":
                        stringType = 1;
                        continue;
                    case "ReviewPeriod":
                        stringType = 2;
                        continue;
                    case "StartInventoryQuantity":
                        stringType = 3;
                        continue;
                    case "StartLeadDays":
                        stringType = 4;
                        continue;
                    case "StartOrderQuantity":
                        stringType = 5;
                        continue;
                    case "NumberOfDays":
                        stringType = 6;
                        continue;
                    case "DemandDistribution":
                        stringType = 7;
                        continue;
                    case "LeadDaysDistribution":
                        stringType = 8;
                        continue;
                }

                switch (stringType) {
                    case 1:
                        simulationSystem.OrderUpTo = int.Parse(line);
                        break;
                    case 2:
                        simulationSystem.ReviewPeriod = int.Parse(line);
                        break;
                    case 3:
                        simulationSystem.StartInventoryQuantity = int.Parse(line);
                        break;
                    case 4:
                        simulationSystem.StartLeadDays = int.Parse(line);
                        break;
                    case 5:
                        simulationSystem.StartOrderQuantity = int.Parse(line);
                        break;
                    case 6:
                        simulationSystem.NumberOfDays = int.Parse(line);
                        break;
                    default: {
                            string[] distributions = line.Split(delimiters);

                            if (distributions.Length > 2) {
                                Distribution distribution = new Distribution();
                                distribution.Value = int.Parse(distributions[0]);
                                distribution.Probability = decimal.Parse(distributions[2]);

                                switch (stringType) {
                                    case 7:
                                        simulationSystem.DemandDistribution.Add(distribution);
                                        break;
                                    case 8:
                                        simulationSystem.LeadDaysDistribution.Add(distribution);
                                        break;
                                }
                            }
                            break;
                        }

                }
            }
        }

        public static void CalcDistributionValues(ref List<Distribution> distributions) {
            for (int i = 0; i < distributions.Count(); i++) {
                if (i == 0) {
                    distributions[i].CummProbability = distributions[i].Probability;
                    distributions[i].MinRange = 1;
                    distributions[i].MaxRange = Convert.ToInt32(distributions[i].CummProbability * 100);
                }
                else {
                    distributions[i].CummProbability = distributions[i - 1].CummProbability + distributions[i].Probability;
                    distributions[i].MinRange = distributions[i - 1].MaxRange + 1;
                    distributions[i].MaxRange = Convert.ToInt32(distributions[i].CummProbability * 100);
                }
            }

        }

        public static int GenerateDemandRandomNumber() {
            return rnd.Next(1, 101);
        }

        public static int GenerateLeadDaysRandomNumber() {
            return rnd.Next(1, 101);
        }

        public static Tuple<int, int> GetNumber(string numberType, List<Distribution> distributions) {
            int randomNumber, actualNumber = 0;
            switch (numberType) {
                case "Demand":
                    randomNumber = GenerateDemandRandomNumber();
                    break;
                default:
                    randomNumber = GenerateLeadDaysRandomNumber();
                    break;
            }

            foreach (Distribution distribution in distributions) {
                if (randomNumber >= distribution.MinRange && randomNumber <= distribution.MaxRange) {
                    actualNumber = distribution.Value;
                    break;
                }
            }

            Tuple<int, int> number = new Tuple<int, int>(randomNumber, actualNumber);
            return number;
        }
    }
}
