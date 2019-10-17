namespace MultiQueueSimulation
{
    partial class Form1
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
            this.txt_num_servers = new System.Windows.Forms.TextBox();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_Inter_Arrival = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stop = new System.Windows.Forms.TextBox();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.txt_stop_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_charts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_num_servers
            // 
            this.txt_num_servers.Location = new System.Drawing.Point(202, 76);
            this.txt_num_servers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_num_servers.Name = "txt_num_servers";
            this.txt_num_servers.Size = new System.Drawing.Size(116, 24);
            this.txt_num_servers.TabIndex = 0;
            // 
            // btn_service
            // 
            this.btn_service.Location = new System.Drawing.Point(70, 324);
            this.btn_service.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(140, 47);
            this.btn_service.TabIndex = 1;
            this.btn_service.Text = "Service Time Dist.";
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // btn_Inter_Arrival
            // 
            this.btn_Inter_Arrival.Location = new System.Drawing.Point(273, 324);
            this.btn_Inter_Arrival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Inter_Arrival.Name = "btn_Inter_Arrival";
            this.btn_Inter_Arrival.Size = new System.Drawing.Size(140, 47);
            this.btn_Inter_Arrival.TabIndex = 2;
            this.btn_Inter_Arrival.Text = "Inter Arrival Time Dist.";
            this.btn_Inter_Arrival.UseVisualStyleBackColor = true;
            this.btn_Inter_Arrival.Click += new System.EventHandler(this.btn_Inter_Arrival_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(421, 30);
            this.btn_Done.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(140, 47);
            this.btn_Done.TabIndex = 3;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Servers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stopping Condition";
            // 
            // txt_stop
            // 
            this.txt_stop.Location = new System.Drawing.Point(202, 203);
            this.txt_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stop.Name = "txt_stop";
            this.txt_stop.Size = new System.Drawing.Size(116, 24);
            this.txt_stop.TabIndex = 9;
            // 
            // txt_method
            // 
            this.txt_method.Location = new System.Drawing.Point(202, 149);
            this.txt_method.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(116, 24);
            this.txt_method.TabIndex = 10;
            // 
            // txt_stop_num
            // 
            this.txt_stop_num.Location = new System.Drawing.Point(202, 259);
            this.txt_stop_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stop_num.Name = "txt_stop_num";
            this.txt_stop_num.Size = new System.Drawing.Size(116, 24);
            this.txt_stop_num.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stopping Number";
            // 
            // btn_charts
            // 
            this.btn_charts.Location = new System.Drawing.Point(421, 137);
            this.btn_charts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_charts.Name = "btn_charts";
            this.btn_charts.Size = new System.Drawing.Size(140, 47);
            this.btn_charts.TabIndex = 13;
            this.btn_charts.Text = "Charts";
            this.btn_charts.UseVisualStyleBackColor = true;
            this.btn_charts.Visible = false;
            this.btn_charts.Click += new System.EventHandler(this.btn_charts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 406);
            this.Controls.Add(this.btn_charts);
            this.Controls.Add(this.txt_stop_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.txt_stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_Inter_Arrival);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.txt_num_servers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num_servers;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_Inter_Arrival;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stop;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.TextBox txt_stop_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_charts;
    }
}

