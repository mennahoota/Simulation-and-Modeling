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
    public partial class Output : Form {
        public Output() {
            InitializeComponent();
        }

        private Random rnd = new Random();

        private void Output_Load(object sender, EventArgs e) {
            Program.system.Simulate();

            dg_output.DataSource = Program.system.SimulationTable;
            dg_output.Show();
        }

        private void Prepare_Customers() {
            int lastArrival = 0;

            for (int i = 1; i <= 100; i++) {
                MultiQueueModels.SimulationCase simCase = new MultiQueueModels.SimulationCase();
                simCase.CustomerNumber = i;

                //Arrival
                if (i == 1) {
                    simCase.ArrivalTime = 0;
                }
                else {
                    simCase.RandomInterArrival = rnd.Next(0, 101);
                    for (int j = 0; j < Program.system.InterarrivalDistribution.Count; j++) {
                        if (simCase.RandomInterArrival >= Program.system.InterarrivalDistribution[j].MinRange &&
                            simCase.RandomInterArrival < Program.system.InterarrivalDistribution[j].MaxRange) {
                            simCase.InterArrival = Program.system.InterarrivalDistribution[j].Time;
                            simCase.ArrivalTime = lastArrival + simCase.InterArrival;
                            break;
                        }
                    }
                    lastArrival = simCase.ArrivalTime;
                }

                //Service
                simCase.RandomService = rnd.Next(0, 101);

                simCase.TimeInQueue = 0;
                Program.system.SimulationTable.Add(simCase);
            }
        }

        private void Serve_Priority() {
            int maxCustomers = 100;
            if(Program.system.StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.NumberOfCustomers)
                maxCustomers = Program.system.StoppingNumber;
            for(int i = 0; i < maxCustomers; i++) {
                if(Program.system.StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.SimulationEndTime) {
                    if(Program.system.SimulationTable[i].ArrivalTime >= Program.system.StoppingNumber) {
                        break;
                    }
                }
                bool assigned = false;
                for (int j = 0; j < Program.system.NumberOfServers; j++) {
                    if (Program.system.Servers[j].FinishTime <= Program.system.SimulationTable[i].ArrivalTime + Program.system.SimulationTable[i].TimeInQueue) {
                        Program.system.SimulationTable[i].AssignedServer = Program.system.Servers[j];
                        assigned = true;
                        for(int k = 0; k < Program.system.Servers[j].TimeDistribution.Count; k++) {
                            int minRange = Program.system.Servers[j].TimeDistribution[k].MinRange;
                            int maxRange = Program.system.Servers[j].TimeDistribution[k].MaxRange;
                            if (Program.system.SimulationTable[i].RandomService >= minRange &&
                                Program.system.SimulationTable[i].RandomService <= maxRange) {
                                Program.system.SimulationTable[i].ServiceTime = Program.system.Servers[j].TimeDistribution[k].Time;
                                break;
                            }
                        }
                        Program.system.SimulationTable[i].StartTime = Program.system.SimulationTable[i].ArrivalTime + Program.system.SimulationTable[i].TimeInQueue;
                        Program.system.Servers[j].FinishTime = Program.system.SimulationTable[i].StartTime + Program.system.SimulationTable[i].ServiceTime;
                        Program.system.SimulationTable[i].EndTime = Program.system.Servers[j].FinishTime;
                        break;
                    }
                }
                if (!assigned) {
                    Program.system.SimulationTable[i].TimeInQueue++;
                    i--;
                }
            }
        }

        private void Serve_Random() {
            int maxCustomers = 100;
            if (Program.system.StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.NumberOfCustomers)
                maxCustomers = Program.system.StoppingNumber;
            for (int i = 0; i < maxCustomers; i++) {
                if (Program.system.StoppingCriteria == MultiQueueModels.Enums.StoppingCriteria.SimulationEndTime) {
                    if (Program.system.SimulationTable[i].ArrivalTime >= Program.system.StoppingNumber) {
                        break;
                    }
                }
                bool assigned = false;
                int trials = 0; 
                while (!assigned && trials < Program.system.NumberOfServers) {
                    int idx = rnd.Next(0, Program.system.NumberOfServers);
                    trials++;
                    if(Program.system.Servers[idx].FinishTime <= Program.system.SimulationTable[i].ArrivalTime + Program.system.SimulationTable[i].TimeInQueue) {
                        Program.system.SimulationTable[i].AssignedServer = Program.system.Servers[idx];
                        assigned = true;
                        for (int k = 0; k < Program.system.Servers[idx].TimeDistribution.Count; k++) {
                            int minRange = Program.system.Servers[idx].TimeDistribution[k].MinRange;
                            int maxRange = Program.system.Servers[idx].TimeDistribution[k].MaxRange;
                            if (Program.system.SimulationTable[i].RandomService >= minRange &&
                                Program.system.SimulationTable[i].RandomService <= maxRange) {
                                Program.system.SimulationTable[i].ServiceTime = Program.system.Servers[idx].TimeDistribution[k].Time;
                                break;
                            }
                        }
                        Program.system.SimulationTable[i].StartTime = Program.system.SimulationTable[i].ArrivalTime + Program.system.SimulationTable[i].TimeInQueue;
                        Program.system.Servers[idx].FinishTime = Program.system.SimulationTable[i].StartTime + Program.system.SimulationTable[i].ServiceTime;
                        Program.system.SimulationTable[i].EndTime = Program.system.Servers[idx].FinishTime;
                        break;
                    }
                }
                if(!assigned && trials == Program.system.NumberOfServers) {
                    Program.system.SimulationTable[i].TimeInQueue++;
                    i--;
                }
            }
        }
    }
}
