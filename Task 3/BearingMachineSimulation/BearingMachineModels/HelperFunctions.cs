using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class HelperFunctions
    {
        public static void ReadInput(string testCase, ref SimulationSystem simulationSystem)
        {
            string projectPath = System.IO.Directory.GetCurrentDirectory();
            projectPath = projectPath.Remove(projectPath.Length - 10);
            string[] lines = System.IO.File.ReadAllLines(projectPath + "\\TestCases\\" + testCase + ".txt");
            InputData(lines, ref simulationSystem);
        }

        public static void InputData(string[] lines, ref SimulationSystem simulationSystem)
        {
            int stringType = 0;
            char[] delimiters = { ',', ' ' };
            foreach (string line in lines)
            {
                if (line == "\n" || line.Length == 0) continue;
                switch (line)
                {
                    case "DowntimeCost":
                        stringType = 1;
                        continue;
                    case "RepairPersonCost":
                        stringType = 2;
                        continue;
                    case "BearingCost":
                        stringType = 3;
                        continue;
                    case "NumberOfHours":
                        stringType = 4;
                        continue;
                    case "NumberOfBearings":
                        stringType = 5;
                        continue;
                    case "RepairTimeForOneBearing":
                        stringType = 6;
                        continue;
                    case "RepairTimeForAllBearings":
                        stringType = 7;
                        continue;
                    case "DelayTimeDistribution":
                        stringType = 8;
                        continue;
                    case "BearingLifeDistribution":
                        stringType = 9;
                        continue;
                }

                switch (stringType)
                {
                    case 1:
                        simulationSystem.DowntimeCost = int.Parse(line);
                        break;
                    case 2:
                        simulationSystem.RepairPersonCost = int.Parse(line);
                        break;
                    case 3:
                        simulationSystem.BearingCost = int.Parse(line);
                        break;
                    case 4:
                        simulationSystem.NumberOfHours = int.Parse(line);
                        break;
                    case 5:
                        simulationSystem.NumberOfBearings = int.Parse(line);
                        break;
                    case 6:
                        simulationSystem.RepairTimeForOneBearing = int.Parse(line);
                        break;
                    case 7:
                        simulationSystem.RepairTimeForAllBearings = int.Parse(line);
                        break;
                    default:
                        {
                            string[] distributions = line.Split(delimiters);

                            if (distributions.Length == 2)
                            {
                                TimeDistribution timeDistribution = new TimeDistribution();
                                timeDistribution.Time = int.Parse(distributions[0]);
                                timeDistribution.Probability = decimal.Parse(distributions[1]);

                                switch (stringType)
                                {
                                    case 8:
                                        simulationSystem.BearingLifeDistribution.Add(timeDistribution);
                                        break;
                                    case 9:
                                        simulationSystem.DelayTimeDistribution.Add(timeDistribution);
                                        break;
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
}
