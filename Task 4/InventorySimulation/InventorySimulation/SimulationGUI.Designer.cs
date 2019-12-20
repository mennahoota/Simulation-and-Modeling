namespace InventorySimulation {
    partial class SimulationGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SimulationButton = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_shortageAvg = new System.Windows.Forms.TextBox();
            this.txt_endingAvg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(14, 60);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1471, 498);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(638, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simulation Table";
            // 
            // SimulationButton
            // 
            this.SimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulationButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.SimulationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SimulationButton.Location = new System.Drawing.Point(525, 728);
            this.SimulationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimulationButton.Name = "SimulationButton";
            this.SimulationButton.Size = new System.Drawing.Size(207, 53);
            this.SimulationButton.TabIndex = 4;
            this.SimulationButton.Text = "Start Simulation";
            this.SimulationButton.UseVisualStyleBackColor = true;
            this.SimulationButton.Click += new System.EventHandler(this.SimulationButton_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Location = new System.Drawing.Point(738, 728);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(207, 53);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // txt_shortageAvg
            // 
            this.txt_shortageAvg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_shortageAvg.Location = new System.Drawing.Point(797, 673);
            this.txt_shortageAvg.Name = "txt_shortageAvg";
            this.txt_shortageAvg.Size = new System.Drawing.Size(144, 32);
            this.txt_shortageAvg.TabIndex = 37;
            // 
            // txt_endingAvg
            // 
            this.txt_endingAvg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_endingAvg.Location = new System.Drawing.Point(797, 626);
            this.txt_endingAvg.Name = "txt_endingAvg";
            this.txt_endingAvg.Size = new System.Drawing.Size(144, 32);
            this.txt_endingAvg.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(506, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ending Inventory Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(506, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Shortage Quantity Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(589, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Performance Measures";
            // 
            // SimulationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1503, 799);
            this.Controls.Add(this.txt_shortageAvg);
            this.Controls.Add(this.txt_endingAvg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.SimulationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimulationGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulationSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SimulationButton;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_shortageAvg;
        private System.Windows.Forms.TextBox txt_endingAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}