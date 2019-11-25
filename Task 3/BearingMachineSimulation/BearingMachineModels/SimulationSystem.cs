using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class SimulationSystem
    {
        #region Inputs
        public int DowntimeCost { get; set; }
        public int RepairPersonCost { get; set; }
        public int BearingCost { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfBearings { get; set; }
        public int RepairTimeForOneBearing { get; set; }
        public int RepairTimeForAllBearings { get; set; }
        public List<TimeDistribution> DelayTimeDistribution { get; set; }
        public List<TimeDistribution> BearingLifeDistribution { get; set; }
        #endregion

        #region Outputs
        public List<CurrentSimulationCase> CurrentSimulationTable { get; set; }
        public PerformanceMeasures CurrentPerformanceMeasures { get; set; }
        public List<ProposedSimulationCase> ProposedSimulationTable { get; set; }
        public PerformanceMeasures ProposedPerformanceMeasures { get; set; }
        #endregion

        #region TempData 
        public List<TimeDistribution> tempDelayTimeDist;
        public List<TimeDistribution> tempBearingLifeDist;
        public List<List<Bearing>> bearings;
        int totalCurrentDelayTime;
        int totalProposedDelayTime;
        int TotalProposedBearings = 0;
        public List<int> bearingMaximumChanges = new List<int>();
        #endregion

        public SimulationSystem()
        {
            DelayTimeDistribution = new List<TimeDistribution>();
            BearingLifeDistribution = new List<TimeDistribution>();

            CurrentSimulationTable = new List<CurrentSimulationCase>();
            CurrentPerformanceMeasures = new PerformanceMeasures();

            ProposedSimulationTable = new List<ProposedSimulationCase>();
            ProposedPerformanceMeasures = new PerformanceMeasures();

            bearingMaximumChanges = new List<int>();
            bearings = new List<List<Bearing>>();
        }

        public void Simulate()
        {
            InitializeDistributions();
            GenerateBearings();
            CurrentSimulation();
            ProposedSimulation();
            proposedMethodPerformance();
            currentMethodPerformance();
        }

        public void InitializeDistributions()
        {
            //Fill Delay Time Distribution
            tempDelayTimeDist = new List<TimeDistribution>();
            tempDelayTimeDist = DelayTimeDistribution;
            HelperFunctions.CalcCummulativeProbability(ref tempDelayTimeDist);
            HelperFunctions.CalcRandomDigitAssignment(ref tempDelayTimeDist);
            DelayTimeDistribution = tempDelayTimeDist;

            //Fill Bearing life distribution
            tempBearingLifeDist = new List<TimeDistribution>();
            tempBearingLifeDist = BearingLifeDistribution;
            HelperFunctions.CalcCummulativeProbability(ref tempBearingLifeDist);
            HelperFunctions.CalcRandomDigitAssignment(ref tempBearingLifeDist);
            BearingLifeDistribution = tempBearingLifeDist;
        }

        public void ProposedSimulation()
        {
            int totalAccumlatedHours = 0;
            int row = 0;

            while (totalAccumlatedHours < NumberOfHours)
            {
                ProposedSimulationCase proposedSimulationCase = new ProposedSimulationCase();
                proposedSimulationCase.FirstFailure = BearingLifeDistribution[BearingLifeDistribution.Count - 1].Time + 100;

                List<Bearing> currentBearings = new List<Bearing>();

                for(int i = 0; i<NumberOfBearings; i++)
                {
                    Bearing bearing = new Bearing();

                    if (row < bearingMaximumChanges[i])
                    {
                        bearing = bearings[i][row];
                    }
                    else
                    {
                        //Generate new bearing
                        bearing.Index = i + 1;
                        Tuple<int, int> lifeHours = HelperFunctions.GetBearingRandomNumbers("Life", BearingLifeDistribution);
                        bearing.RandomHours = lifeHours.Item1;
                        bearing.Hours = lifeHours.Item2;
                    }
                    if (bearing.Hours < proposedSimulationCase.FirstFailure)
                        proposedSimulationCase.FirstFailure = bearing.Hours;
                    currentBearings.Add(bearing);
                }

                proposedSimulationCase.AccumulatedHours += proposedSimulationCase.FirstFailure;
                proposedSimulationCase.Bearings = currentBearings;

                TotalProposedBearings += currentBearings.Count;

                Tuple<int, int> delayVariables = HelperFunctions.GetBearingRandomNumbers("Delay", DelayTimeDistribution);

                proposedSimulationCase.RandomDelay = delayVariables.Item1;
                proposedSimulationCase.Delay = delayVariables.Item2;

                totalProposedDelayTime += proposedSimulationCase.Delay;

                totalAccumlatedHours += proposedSimulationCase.FirstFailure;
                ProposedSimulationTable.Add(proposedSimulationCase);
                row++;
            }
        }

        public void GenerateBearings()
        {
            for (int i = 0; i < NumberOfBearings; i++)
            {
                List<Bearing> currentList = new List<Bearing>();
                int accumulatedHours = 0;
                while (accumulatedHours < NumberOfHours)
                {
                    Bearing currentBering = new Bearing();
                    currentBering.Index = i + 1;
                    Tuple<int, int> lifeHours = HelperFunctions.GetBearingRandomNumbers("Life", BearingLifeDistribution);
                    currentBering.RandomHours = lifeHours.Item1;
                    currentBering.Hours = lifeHours.Item2;
                    currentList.Add(currentBering);
                    accumulatedHours += currentBering.Hours;
                }
                bearings.Add(currentList);
                bearingMaximumChanges.Add(currentList.Count());
            }
        }

        public void CurrentSimulation()
        {
            totalCurrentDelayTime = 0;
            int accumulatedHours;
            for (int i = 0; i < NumberOfBearings; i++)
            {
                accumulatedHours = 0;
                for (int j = 0; j < bearings[i].Count(); j++)
                {
                    CurrentSimulationCase currentCase = new CurrentSimulationCase();
                    currentCase.Bearing.Hours = bearings[i][j].Hours;
                    currentCase.Bearing.RandomHours = bearings[i][j].RandomHours;
                    currentCase.Bearing.Index = bearings[i][j].Index;
                    accumulatedHours += currentCase.Bearing.Hours;
                    currentCase.AccumulatedHours = accumulatedHours;
                    Tuple<int, int> delay = HelperFunctions.GetBearingRandomNumbers("Delay", DelayTimeDistribution);
                    currentCase.RandomDelay = delay.Item1;
                    currentCase.Delay = delay.Item2;
                    CurrentSimulationTable.Add(currentCase);
                    totalCurrentDelayTime += currentCase.Delay;
                }
            }
        }

        public void proposedMethodPerformance()
        {
            ProposedPerformanceMeasures.CalculateBearingCost(TotalProposedBearings, BearingCost);
            ProposedPerformanceMeasures.CalculateDelayCost(totalProposedDelayTime, DowntimeCost);
            ProposedPerformanceMeasures.CalculateDowntimeCost(TotalProposedBearings, RepairTimeForAllBearings, DowntimeCost);
            ProposedPerformanceMeasures.CalculateRepairPersonCost(TotalProposedBearings, RepairTimeForAllBearings, RepairPersonCost);
            ProposedPerformanceMeasures.CalculateTotalCost();
        }

        public void currentMethodPerformance()
        {
            int numOfBearings = CurrentSimulationTable.Count();
            CurrentPerformanceMeasures.CalculateBearingCost(numOfBearings, BearingCost);
            CurrentPerformanceMeasures.CalculateDelayCost(totalCurrentDelayTime, DowntimeCost);
            CurrentPerformanceMeasures.CalculateDowntimeCost(numOfBearings, RepairTimeForOneBearing, DowntimeCost);
            CurrentPerformanceMeasures.CalculateRepairPersonCost(numOfBearings, RepairTimeForOneBearing, RepairPersonCost);
            CurrentPerformanceMeasures.CalculateTotalCost();
        }

    }
}
