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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            Program.system.ClearSystem();
            string projectPath = System.IO.Directory.GetCurrentDirectory();
            projectPath = projectPath.Remove(projectPath.Length - 10);
            string fileName = txtb_fileName.Text.ToString();
            string[] lines = System.IO.File.ReadAllLines(projectPath + "\\TestCases\\" + fileName + ".txt");

            Program.system.InputData(lines);
            Program.system.Simulate();
            string result = TestingManager.Test(Program.system, fileName + ".txt");
            MessageBox.Show(result);
            
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            SimulationTable ST = new SimulationTable();
            this.Hide();
            ST.ShowDialog();
            this.Close();
        }

    }
}
