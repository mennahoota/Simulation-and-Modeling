using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
            this.maxCustomers = 100;
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        public int maxCustomers;
        public int endTime;
        public List<List<int>> serverBusyTime = new List<List<int>>();

        private Random rnd = new Random();
        private int maxQueueLength = 0;
        private List<int> waitingQueue = new List<int>();

        public void Simulate() {
            for(int i = 0; i < NumberOfServers; i++) {
                serverBusyTime.Add(new List<int>());
            }
            Prepare_Customers();
            if (SelectionMethod == MultiQueueModels.Enums.SelectionMethod.HighestPriority)
                Serve_Priority();
            else if (SelectionMethod == MultiQueueModels.Enums.SelectionMethod.Random)
                Serve_Random();
            else if (SelectionMethod == MultiQueueModels.Enums.SelectionMethod.LeastUtilization)
                Serve_LU();

            // Calculating average waiting time
            int totalWait = 0;
            for(int i = 0; i < maxCustomers; i++) {
                totalWait += SimulationTable[i].TimeInQueue;
            }
            int customersWaited = waitingQueue.Count();
            PerformanceMeasures.AverageWaitingTime = decimal.Divide(totalWait, maxCustomers);
            PerformanceMeasures.WaitingProbability = decimal.Divide(customersWaited, maxCustomers);

            for(int i = waitingQueue.Count - 1; i > 0; i--) {
                int queueLength = 1;
                for(int j = i - 1; j > 0; j--) {
                    int currentCustomer = waitingQueue[i];
                    int previousCustomer = waitingQueue[j];
                    if (SimulationTable[currentCustomer].ArrivalTime < SimulationTable[previousCustomer].StartTime)
                        queueLength++;
                    else {
                        if(queueLength > maxQueueLength) 
                            maxQueueLength = queueLength;
                        break;
                    }
                }
            }
            PerformanceMeasures.MaxQueueLength = maxQueueLength;

            for(int j = 0; j < Servers.Count; j++) {
                if(Servers[j].NumberOfCustomers != 0)
                    Servers[j].AverageServiceTime = decimal.Divide(Servers[j].TotalWorkingTime, Servers[j].NumberOfCustomers);

                if (StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.SimulationEndTime)
                    endTime = StoppingNumber;
                else
                    endTime = SimulationTable[maxCustomers - 1].EndTime;
                int idleTime = endTime - Servers[j].TotalWorkingTime;
                Servers[j].IdleProbability = decimal.Divide(idleTime, endTime);
                Servers[j].Utilization = decimal.Divide(Servers[j].TotalWorkingTime, endTime);
            }
        }

        private void Prepare_Customers() {
            int lastArrival = 0;

            for (int i = 1; i <= maxCustomers; i++) {
                MultiQueueModels.SimulationCase simCase = new MultiQueueModels.SimulationCase();
                simCase.CustomerNumber = i;

                //Arrival
                if (i == 1) {
                    simCase.RandomInterArrival = 1;
                    simCase.InterArrival = 1;
                    simCase.ArrivalTime = 0;
                }
                else {
                    simCase.RandomInterArrival = rnd.Next(1, 101);
                    for (int j = 0; j < InterarrivalDistribution.Count; j++) {
                        if (simCase.RandomInterArrival >= InterarrivalDistribution[j].MinRange &&
                            simCase.RandomInterArrival <= InterarrivalDistribution[j].MaxRange) {
                            simCase.InterArrival = InterarrivalDistribution[j].Time;
                            simCase.ArrivalTime = lastArrival + simCase.InterArrival;
                            break;
                        }
                    }
                    lastArrival = simCase.ArrivalTime;
                }

                //Service
                simCase.RandomService = rnd.Next(1, 101);

                simCase.TimeInQueue = 0;
                SimulationTable.Add(simCase);
            }
        }

        private void Serve_Priority() {
            for (int i = 0; i < maxCustomers; i++) {
                if (StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.SimulationEndTime) {
                    if (SimulationTable[i].ArrivalTime >= StoppingNumber) {
                        break;
                    }
                }
                bool assigned = false;
                for (int j = 0; j < NumberOfServers; j++) {
                    if (Servers[j].FinishTime <= SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue) {
                        SimulationTable[i].AssignedServer = Servers[j];
                        Servers[j].NumberOfCustomers++;
                        assigned = true;
                        for (int k = 0; k < Servers[j].TimeDistribution.Count; k++) {
                            int minRange = Servers[j].TimeDistribution[k].MinRange;
                            int maxRange = Servers[j].TimeDistribution[k].MaxRange;
                            if (SimulationTable[i].RandomService >= minRange &&
                                SimulationTable[i].RandomService <= maxRange) {
                                SimulationTable[i].ServiceTime = Servers[j].TimeDistribution[k].Time;
                                break;
                            }
                        }
                        SimulationTable[i].StartTime = SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue;
                        Servers[j].FinishTime = SimulationTable[i].StartTime + SimulationTable[i].ServiceTime;
                        SimulationTable[i].EndTime = Servers[j].FinishTime;

                        Servers[j].TotalWorkingTime += SimulationTable[i].ServiceTime;

                        for(int t = SimulationTable[i].StartTime; t <= SimulationTable[i].EndTime; t++) {
                            serverBusyTime[j].Add(t);
                        }
                        break;
                    }
                }
                if (!assigned) {
                    SimulationTable[i].TimeInQueue++;
                    
                    bool found = false;
                    for(int w = 0; w < waitingQueue.Count; w++) {
                        if(waitingQueue[w] == i) {
                            found = true;
                            break;
                        }
                    }
                    if (!found) {
                        waitingQueue.Add(i);
                    }

                    i--;
                }
            }
        }

        private void Serve_Random() {
            if (StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.NumberOfCustomers)
                maxCustomers = StoppingNumber;
            for (int i = 0; i < maxCustomers; i++) {
                if (StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.SimulationEndTime) {
                    if (SimulationTable[i].ArrivalTime >= StoppingNumber) {
                        break;
                    }
                }
                bool assigned = false;
                int trials = 0;
                while (!assigned && trials < NumberOfServers) {
                    int idx = rnd.Next(0, NumberOfServers);
                    trials++;
                    if (Servers[idx].FinishTime <= SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue) {
                        SimulationTable[i].AssignedServer = Servers[idx];
                        assigned = true;
                        for (int k = 0; k < Servers[idx].TimeDistribution.Count; k++) {
                            int minRange = Servers[idx].TimeDistribution[k].MinRange;
                            int maxRange = Servers[idx].TimeDistribution[k].MaxRange;
                            if (SimulationTable[i].RandomService >= minRange &&
                                SimulationTable[i].RandomService <= maxRange) {
                                SimulationTable[i].ServiceTime = Servers[idx].TimeDistribution[k].Time;
                                break;
                            }
                        }
                        SimulationTable[i].StartTime = SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue;
                        Servers[idx].FinishTime = SimulationTable[i].StartTime + SimulationTable[i].ServiceTime;
                        SimulationTable[i].EndTime = Servers[idx].FinishTime;         

                        Servers[idx].TotalWorkingTime += SimulationTable[i].ServiceTime;

                        for (int t = SimulationTable[i].StartTime; t <= SimulationTable[i].EndTime; t++) {
                            serverBusyTime[idx].Add(t);
                        }
                        break;
                    }
                }
                if (!assigned && trials == NumberOfServers) {
                    SimulationTable[i].TimeInQueue++;

                    bool found = false;
                    for (int w = 0; w < waitingQueue.Count; w++) {
                        if (waitingQueue[w] == i) {
                            found = true;
                            break;
                        }
                    }
                    if (!found) {
                        waitingQueue.Add(i);
                    }

                    i--;
                }
            }
        }

        private void Serve_LU() {
            for (int i = 0; i < maxCustomers; i++) {
                if (StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.SimulationEndTime) {
                    if (SimulationTable[i].ArrivalTime >= StoppingNumber) {
                        break;
                    }
                }
                bool assigned = false;
                int leastUsedServer = -1, minUtilization = 10000000;
                for (int j = 0; j < NumberOfServers; j++) {
                    if (Servers[j].TotalWorkingTime < minUtilization &&
                        Servers[j].FinishTime <= SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue) {
                        leastUsedServer = j;
                        minUtilization = Servers[j].TotalWorkingTime;
                        break;
                    }
                }
                if(leastUsedServer != -1) {
                    SimulationTable[i].AssignedServer = Servers[leastUsedServer];
                    Servers[leastUsedServer].NumberOfCustomers++;
                    assigned = true;
                    for (int k = 0; k < Servers[leastUsedServer].TimeDistribution.Count; k++) {
                        int minRange = Servers[leastUsedServer].TimeDistribution[k].MinRange;
                        int maxRange = Servers[leastUsedServer].TimeDistribution[k].MaxRange;
                        if (SimulationTable[i].RandomService >= minRange &&
                            SimulationTable[i].RandomService <= maxRange) {
                            SimulationTable[i].ServiceTime = Servers[leastUsedServer].TimeDistribution[k].Time;
                            break;
                        }
                    }
                    SimulationTable[i].StartTime = SimulationTable[i].ArrivalTime + SimulationTable[i].TimeInQueue;
                    Servers[leastUsedServer].FinishTime = SimulationTable[i].StartTime + SimulationTable[i].ServiceTime;
                    SimulationTable[i].EndTime = Servers[leastUsedServer].FinishTime;

                    Servers[leastUsedServer].TotalWorkingTime += SimulationTable[i].ServiceTime;

                    for (int t = SimulationTable[i].StartTime; t <= SimulationTable[i].EndTime; t++) {
                        serverBusyTime[leastUsedServer].Add(t);
                    }
                }
                if (!assigned) {
                    SimulationTable[i].TimeInQueue++;

                    bool found = false;
                    for (int w = 0; w < waitingQueue.Count; w++) {
                        if (waitingQueue[w] == i) {
                            found = true;
                            break;
                        }
                    }
                    if (!found) {
                        waitingQueue.Add(i);
                    }

                    i--;
                }
            }
        }

    }
}