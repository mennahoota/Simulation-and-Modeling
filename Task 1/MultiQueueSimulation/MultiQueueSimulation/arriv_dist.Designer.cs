namespace MultiQueueSimulation
{
    partial class arriv_dist
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
            this.dg_arriv = new System.Windows.Forms.DataGridView();
            this.Interarrival_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_arriv)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_arriv
            // 
            this.dg_arriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_arriv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interarrival_Time,
            this.probability});
            this.dg_arriv.Location = new System.Drawing.Point(0, 0);
            this.dg_arriv.Name = "dg_arriv";
            this.dg_arriv.Size = new System.Drawing.Size(346, 229);
            this.dg_arriv.TabIndex = 0;
            // 
            // Interarrival_Time
            // 
            this.Interarrival_Time.HeaderText = "Interarrival Time";
            this.Interarrival_Time.Name = "Interarrival_Time";
            // 
            // probability
            // 
            this.probability.HeaderText = "Probability";
            this.probability.Name = "probability";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(332, 243);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(120, 38);
            this.btn_Done.TabIndex = 4;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // arriv_dist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 293);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.dg_arriv);
            this.Name = "arriv_dist";
            this.Text = "arriv_dist";
            ((System.ComponentModel.ISupportInitialize)(this.dg_arriv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_arriv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interarrival_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability;
        private System.Windows.Forms.Button btn_Done;
    }
}