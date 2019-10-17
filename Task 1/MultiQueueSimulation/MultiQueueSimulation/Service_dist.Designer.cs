namespace MultiQueueSimulation
{
    partial class Service_dist
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
            this.dg_service = new System.Windows.Forms.DataGridView();
            this.Service_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_service)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_service
            // 
            this.dg_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service_Time,
            this.probabilty});
            this.dg_service.Location = new System.Drawing.Point(0, 0);
            this.dg_service.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg_service.Name = "dg_service";
            this.dg_service.Size = new System.Drawing.Size(404, 282);
            this.dg_service.TabIndex = 0;
            // 
            // Service_Time
            // 
            this.Service_Time.HeaderText = "Service Time";
            this.Service_Time.Name = "Service_Time";
            // 
            // probabilty
            // 
            this.probabilty.HeaderText = "Probability";
            this.probabilty.Name = "probabilty";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(387, 299);
            this.btn_Done.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(140, 47);
            this.btn_Done.TabIndex = 4;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(29, 299);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(140, 47);
            this.btn_enter.TabIndex = 6;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // Service_dist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 361);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.dg_service);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Service_dist";
            this.Text = "Service_dist";
            ((System.ComponentModel.ISupportInitialize)(this.dg_service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilty;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_enter;
    }
}