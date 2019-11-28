namespace BearingMachineSimulation
{
    partial class SimulationSystemGUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SimulationButton = new System.Windows.Forms.Button();
            this.totalCurrentCost = new System.Windows.Forms.TextBox();
            this.totalProposedCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PropBearingTxt = new System.Windows.Forms.TextBox();
            this.PropDelayTxt = new System.Windows.Forms.TextBox();
            this.PropDowntimeTxt = new System.Windows.Forms.TextBox();
            this.PropRepairTxt = new System.Windows.Forms.TextBox();
            this.CurrentBearingCostTxt = new System.Windows.Forms.TextBox();
            this.CurrentDelayCostTxt = new System.Windows.Forms.TextBox();
            this.CurrentDowntimeTxt = new System.Windows.Forms.TextBox();
            this.CurrentRepairPersonTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(386, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(371, 287);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Policy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(383, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proposed Policy";
            // 
            // SimulationButton
            // 
            this.SimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulationButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SimulationButton.Location = new System.Drawing.Point(12, 450);
            this.SimulationButton.Name = "SimulationButton";
            this.SimulationButton.Size = new System.Drawing.Size(127, 43);
            this.SimulationButton.TabIndex = 4;
            this.SimulationButton.Text = "Start Simulation";
            this.SimulationButton.UseVisualStyleBackColor = true;
            this.SimulationButton.Click += new System.EventHandler(this.SimulationButton_Click);
            // 
            // totalCurrentCost
            // 
            this.totalCurrentCost.Location = new System.Drawing.Point(203, 410);
            this.totalCurrentCost.Name = "totalCurrentCost";
            this.totalCurrentCost.Size = new System.Drawing.Size(162, 20);
            this.totalCurrentCost.TabIndex = 5;
            // 
            // totalProposedCost
            // 
            this.totalProposedCost.Location = new System.Drawing.Point(581, 410);
            this.totalProposedCost.Name = "totalProposedCost";
            this.totalProposedCost.Size = new System.Drawing.Size(161, 20);
            this.totalProposedCost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(383, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proposed Policy Total Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Policy Total Cost";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(630, 450);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 43);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Repair Person Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Downtime Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Delay Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bearing Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(383, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bearing Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(382, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Delay Cost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(382, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Downtime Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(383, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Repair Person Cost";
            // 
            // PropBearingTxt
            // 
            this.PropBearingTxt.Location = new System.Drawing.Point(580, 330);
            this.PropBearingTxt.Name = "PropBearingTxt";
            this.PropBearingTxt.Size = new System.Drawing.Size(162, 20);
            this.PropBearingTxt.TabIndex = 20;
            // 
            // PropDelayTxt
            // 
            this.PropDelayTxt.Location = new System.Drawing.Point(580, 350);
            this.PropDelayTxt.Name = "PropDelayTxt";
            this.PropDelayTxt.Size = new System.Drawing.Size(162, 20);
            this.PropDelayTxt.TabIndex = 21;
            // 
            // PropDowntimeTxt
            // 
            this.PropDowntimeTxt.Location = new System.Drawing.Point(580, 370);
            this.PropDowntimeTxt.Name = "PropDowntimeTxt";
            this.PropDowntimeTxt.Size = new System.Drawing.Size(162, 20);
            this.PropDowntimeTxt.TabIndex = 22;
            // 
            // PropRepairTxt
            // 
            this.PropRepairTxt.Location = new System.Drawing.Point(580, 390);
            this.PropRepairTxt.Name = "PropRepairTxt";
            this.PropRepairTxt.Size = new System.Drawing.Size(162, 20);
            this.PropRepairTxt.TabIndex = 23;
            // 
            // CurrentBearingCostTxt
            // 
            this.CurrentBearingCostTxt.Location = new System.Drawing.Point(203, 330);
            this.CurrentBearingCostTxt.Name = "CurrentBearingCostTxt";
            this.CurrentBearingCostTxt.Size = new System.Drawing.Size(162, 20);
            this.CurrentBearingCostTxt.TabIndex = 24;
            // 
            // CurrentDelayCostTxt
            // 
            this.CurrentDelayCostTxt.Location = new System.Drawing.Point(203, 350);
            this.CurrentDelayCostTxt.Name = "CurrentDelayCostTxt";
            this.CurrentDelayCostTxt.Size = new System.Drawing.Size(162, 20);
            this.CurrentDelayCostTxt.TabIndex = 25;
            // 
            // CurrentDowntimeTxt
            // 
            this.CurrentDowntimeTxt.Location = new System.Drawing.Point(203, 370);
            this.CurrentDowntimeTxt.Name = "CurrentDowntimeTxt";
            this.CurrentDowntimeTxt.Size = new System.Drawing.Size(162, 20);
            this.CurrentDowntimeTxt.TabIndex = 26;
            // 
            // CurrentRepairPersonTxt
            // 
            this.CurrentRepairPersonTxt.Location = new System.Drawing.Point(203, 390);
            this.CurrentRepairPersonTxt.Name = "CurrentRepairPersonTxt";
            this.CurrentRepairPersonTxt.Size = new System.Drawing.Size(162, 20);
            this.CurrentRepairPersonTxt.TabIndex = 27;
            // 
            // SimulationSystemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(769, 505);
            this.Controls.Add(this.CurrentRepairPersonTxt);
            this.Controls.Add(this.CurrentDowntimeTxt);
            this.Controls.Add(this.CurrentDelayCostTxt);
            this.Controls.Add(this.CurrentBearingCostTxt);
            this.Controls.Add(this.PropRepairTxt);
            this.Controls.Add(this.PropDowntimeTxt);
            this.Controls.Add(this.PropDelayTxt);
            this.Controls.Add(this.PropBearingTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalProposedCost);
            this.Controls.Add(this.totalCurrentCost);
            this.Controls.Add(this.SimulationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Name = "SimulationSystemGUI";
            this.Text = "SimulationSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SimulationButton;
        private System.Windows.Forms.TextBox totalCurrentCost;
        private System.Windows.Forms.TextBox totalProposedCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PropBearingTxt;
        private System.Windows.Forms.TextBox PropDelayTxt;
        private System.Windows.Forms.TextBox PropDowntimeTxt;
        private System.Windows.Forms.TextBox PropRepairTxt;
        private System.Windows.Forms.TextBox CurrentBearingCostTxt;
        private System.Windows.Forms.TextBox CurrentDelayCostTxt;
        private System.Windows.Forms.TextBox CurrentDowntimeTxt;
        private System.Windows.Forms.TextBox CurrentRepairPersonTxt;
    }
}