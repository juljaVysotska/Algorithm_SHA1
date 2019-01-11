namespace SHA_1
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTheory = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, my dear friend!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today you are learning a new crypto algorith.\r\nIt is a SHA-1. So, let\'s go! ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTheory
            // 
            this.btnTheory.Location = new System.Drawing.Point(173, 93);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(144, 33);
            this.btnTheory.TabIndex = 2;
            this.btnTheory.Text = "Theory";
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnTheory_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(173, 132);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(144, 33);
            this.btnPractice.TabIndex = 3;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(208, 184);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 219);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnTheory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "SHA-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnAbout;
    }
}

