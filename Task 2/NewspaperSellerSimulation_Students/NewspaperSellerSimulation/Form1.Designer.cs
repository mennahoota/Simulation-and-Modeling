﻿namespace NewspaperSellerSimulation
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
            this.txtb_fileName = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_gui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_fileName
            // 
            this.txtb_fileName.Location = new System.Drawing.Point(59, 107);
            this.txtb_fileName.Name = "txtb_fileName";
            this.txtb_fileName.Size = new System.Drawing.Size(257, 20);
            this.txtb_fileName.TabIndex = 0;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(137, 145);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(95, 35);
            this.btn_file.TabIndex = 1;
            this.btn_file.Text = "Open File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_gui
            // 
            this.btn_gui.Location = new System.Drawing.Point(242, 269);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(130, 30);
            this.btn_gui.TabIndex = 2;
            this.btn_gui.Text = "Open Simulation Table";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btn_gui);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.txtb_fileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_fileName;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_gui;
    }
}