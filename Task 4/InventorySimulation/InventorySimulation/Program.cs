﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySimulation {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static InventoryModels.SimulationSystem simulationSystem = new InventoryModels.SimulationSystem();
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
    }
}
