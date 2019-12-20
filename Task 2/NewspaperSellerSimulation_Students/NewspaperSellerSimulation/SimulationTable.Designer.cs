namespace NewspaperSellerSimulation
{
    partial class SimulationTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_simulationTable = new System.Windows.Forms.DataGridView();
            this.lbl_excessDemand = new System.Windows.Forms.Label();
            this.lbl_unsoldPapers = new System.Windows.Forms.Label();
            this.lbl_excessDemandNum = new System.Windows.Forms.Label();
            this.lbl_unsoldPapersNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_simulationTable
            // 
            this.dgv_simulationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simulationTable.Location = new System.Drawing.Point(12, 12);
            this.dgv_simulationTable.Name = "dgv_simulationTable";
            this.dgv_simulationTable.Size = new System.Drawing.Size(660, 352);
            this.dgv_simulationTable.TabIndex = 0;
            // 
            // lbl_excessDemand
            // 
            this.lbl_excessDemand.AutoSize = true;
            this.lbl_excessDemand.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_excessDemand.Location = new System.Drawing.Point(12, 378);
            this.lbl_excessDemand.Name = "lbl_excessDemand";
            this.lbl_excessDemand.Size = new System.Drawing.Size(305, 22);
            this.lbl_excessDemand.TabIndex = 1;
            this.lbl_excessDemand.Text = "Number of days with excess demand";
            // 
            // lbl_unsoldPapers
            // 
            this.lbl_unsoldPapers.AutoSize = true;
            this.lbl_unsoldPapers.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unsoldPapers.Location = new System.Drawing.Point(12, 413);
            this.lbl_unsoldPapers.Name = "lbl_unsoldPapers";
            this.lbl_unsoldPapers.Size = new System.Drawing.Size(299, 22);
            this.lbl_unsoldPapers.TabIndex = 2;
            this.lbl_unsoldPapers.Text = "Number of days with unsold papers";
            // 
            // lbl_excessDemandNum
            // 
            this.lbl_excessDemandNum.AutoSize = true;
            this.lbl_excessDemandNum.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_excessDemandNum.Location = new System.Drawing.Point(323, 378);
            this.lbl_excessDemandNum.Name = "lbl_excessDemandNum";
            this.lbl_excessDemandNum.Size = new System.Drawing.Size(0, 22);
            this.lbl_excessDemandNum.TabIndex = 3;
            // 
            // lbl_unsoldPapersNum
            // 
            this.lbl_unsoldPapersNum.AutoSize = true;
            this.lbl_unsoldPapersNum.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unsoldPapersNum.Location = new System.Drawing.Point(317, 413);
            this.lbl_unsoldPapersNum.Name = "lbl_unsoldPapersNum";
            this.lbl_unsoldPapersNum.Size = new System.Drawing.Size(0, 22);
            this.lbl_unsoldPapersNum.TabIndex = 4;
            // 
            // SimulationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lbl_unsoldPapersNum);
            this.Controls.Add(this.lbl_excessDemandNum);
            this.Controls.Add(this.lbl_unsoldPapers);
            this.Controls.Add(this.lbl_excessDemand);
            this.Controls.Add(this.dgv_simulationTable);
            this.Name = "SimulationTable";
            this.Text = "SimulationTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationTable_FormClosed);
            this.Load += new System.EventHandler(this.SimulationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_simulationTable;
        private System.Windows.Forms.Label lbl_excessDemand;
        private System.Windows.Forms.Label lbl_unsoldPapers;
        private System.Windows.Forms.Label lbl_excessDemandNum;
        private System.Windows.Forms.Label lbl_unsoldPapersNum;
    }
}