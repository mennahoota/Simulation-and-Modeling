namespace MultiQueueSimulation {
    partial class Output {
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
            this.dg_output = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_output)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_output
            // 
            this.dg_output.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_output.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_output.Location = new System.Drawing.Point(0, 0);
            this.dg_output.Name = "dg_output";
            this.dg_output.RowTemplate.Height = 26;
            this.dg_output.Size = new System.Drawing.Size(989, 547);
            this.dg_output.TabIndex = 0;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_output);
            this.Name = "Output";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_output;
    }
}