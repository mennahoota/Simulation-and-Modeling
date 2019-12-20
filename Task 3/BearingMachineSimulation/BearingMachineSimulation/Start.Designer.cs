namespace BearingMachineSimulation
{
    partial class Start
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
            this.LoadTestCase = new System.Windows.Forms.Button();
            this.FileNames = new System.Windows.Forms.ComboBox();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadTestCase
            // 
            this.LoadTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTestCase.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTestCase.Location = new System.Drawing.Point(79, 152);
            this.LoadTestCase.Name = "LoadTestCase";
            this.LoadTestCase.Size = new System.Drawing.Size(127, 43);
            this.LoadTestCase.TabIndex = 0;
            this.LoadTestCase.Text = "Load Testcase";
            this.LoadTestCase.UseVisualStyleBackColor = true;
            this.LoadTestCase.Click += new System.EventHandler(this.LoadTestCase_Click);
            // 
            // FileNames
            // 
            this.FileNames.FormattingEnabled = true;
            this.FileNames.Location = new System.Drawing.Point(47, 71);
            this.FileNames.Name = "FileNames";
            this.FileNames.Size = new System.Drawing.Size(185, 21);
            this.FileNames.TabIndex = 1;
            // 
            // Next
            // 
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(79, 201);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(127, 43);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Testcases";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(285, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.FileNames);
            this.Controls.Add(this.LoadTestCase);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadTestCase;
        private System.Windows.Forms.ComboBox FileNames;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
    }
}