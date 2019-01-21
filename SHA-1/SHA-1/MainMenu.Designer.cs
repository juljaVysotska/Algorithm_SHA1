namespace SHA1
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
            this.btnLab = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуй!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сегодня мы изучим алгоритм хеширования.\r\nА именно - SHA-1. Что же, приступим! ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTheory
            // 
            this.btnTheory.Location = new System.Drawing.Point(173, 93);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(144, 33);
            this.btnTheory.TabIndex = 2;
            this.btnTheory.Text = "Теория";
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnTheory_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(173, 132);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(144, 33);
            this.btnPractice.TabIndex = 3;
            this.btnPractice.Text = "Тестирование";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(202, 249);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(89, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "О программе";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLab
            // 
            this.btnLab.Location = new System.Drawing.Point(173, 171);
            this.btnLab.Name = "btnLab";
            this.btnLab.Size = new System.Drawing.Size(144, 33);
            this.btnLab.TabIndex = 6;
            this.btnLab.Text = "Лабораторная работа";
            this.btnLab.UseVisualStyleBackColor = true;
            this.btnLab.Click += new System.EventHandler(this.btnLab_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(173, 210);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(144, 33);
            this.btnHash.TabIndex = 7;
            this.btnHash.Text = "Хешировать любой текст";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 281);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnLab);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnTheory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnLab;
        private System.Windows.Forms.Button btnHash;
    }
}

