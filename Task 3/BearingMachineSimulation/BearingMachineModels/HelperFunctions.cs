using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class HelperFunctions
    {
        static Random rnd = new Random();

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

                            if (distributions.Length > 2)
                            {
                                TimeDistribution timeDistribution = new TimeDistribution();
                                timeDistribution.Time = int.Parse(distributions[0]);
                                timeDistribution.Probability = decimal.Parse(distributions[2]);

                                switch (stringType)
                                {
                                    case 8:
                                        simulationSystem.DelayTimeDistribution.Add(timeDistribution);
                                        break;
                                    case 9:
                                        simulationSystem.BearingLifeDistribution.Add(timeDistribution);
                                        break;
                                }
                            }
                            break;
                        }
                }
            }
        }

        public static void CalcCummulativeProbability(ref List<TimeDistribution> timeDistributions)
        {
            for (int i = 0; i < timeDistributions.Count(); i++)
            {
                if (i == 0)
                    timeDistributions[i].CummProbability = timeDistributions[i].Probability;
                else
                {
                    timeDistributions[i].CummProbability = timeDistributions[i - 1].CummProbability + timeDistributions[i].Probability;
                }
            }

        }

        public static void CalcRandomDigitAssignment(ref List<TimeDistribution> timeDistributions)
        {
            for (int i = 0; i < timeDistributions.Count(); i++)
            {
                if (i == 0)
                {
                    timeDistributions[i].MinRange = 1;
                    timeDistributions[i].MaxRange = Decimal.ToInt32(timeDistributions[i].CummProbability * 10);
                }
                else
                {
                    timeDistributions[i].MinRange = timeDistributions[i - 1].MaxRange + 1;
                    timeDistributions[i].MaxRange = Decimal.ToInt32(timeDistributions[i].CummProbability * 10);
                }
            }
        }

        public static int GenerateDelayRandomNumber()
        {
            return rnd.Next(1, 10);
        }

        public static int GenerateBearingRandomNumber()
        {
            return rnd.Next(1, 100);
        }

        public static Tuple<int, int> GetBearingRandomNumbers(string RandomNumberType, List<TimeDistribution> timeDistributions)
        {
            int randomNumber, time = 0;
            switch(RandomNumberType)
            {
                case "Delay":
                    randomNumber = GenerateDelayRandomNumber();
                    break;  
                default:
                    randomNumber = GenerateBearingRandomNumber();
                    break;
            }

            foreach (TimeDistribution timeDistribution in timeDistributions)
            {
                if (randomNumber >= timeDistribution.MinRange && randomNumber <= timeDistribution.MaxRange)
                {
                    time = timeDistribution.Time;
                    break;
                }
            }

            Tuple<int, int> bearingMinutes = new Tuple<int, int>(randomNumber, time);
            return bearingMinutes;
        }
    }
}
