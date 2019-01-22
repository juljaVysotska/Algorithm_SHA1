namespace SHA1
{
    partial class StepThree
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbH0 = new System.Windows.Forms.TextBox();
            this.txbH1 = new System.Windows.Forms.TextBox();
            this.txbH2 = new System.Windows.Forms.TextBox();
            this.txbH3 = new System.Windows.Forms.TextBox();
            this.txbH4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tipTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итак, мы имеем итоговые значения после всех вычислений. \r\nКаков конеченый результ" +
    "ат?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "h0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "h1 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "h2 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "h3 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "h4 =";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(285, 168);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(12, 140);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(348, 20);
            this.txbResult.TabIndex = 13;
            // 
            // txbH0
            // 
            this.txbH0.Location = new System.Drawing.Point(44, 41);
            this.txbH0.Name = "txbH0";
            this.txbH0.ReadOnly = true;
            this.txbH0.Size = new System.Drawing.Size(316, 20);
            this.txbH0.TabIndex = 19;
            // 
            // txbH1
            // 
            this.txbH1.Location = new System.Drawing.Point(44, 59);
            this.txbH1.Name = "txbH1";
            this.txbH1.ReadOnly = true;
            this.txbH1.Size = new System.Drawing.Size(316, 20);
            this.txbH1.TabIndex = 20;
            // 
            // txbH2
            // 
            this.txbH2.Location = new System.Drawing.Point(44, 78);
            this.txbH2.Name = "txbH2";
            this.txbH2.ReadOnly = true;
            this.txbH2.Size = new System.Drawing.Size(316, 20);
            this.txbH2.TabIndex = 21;
            // 
            // txbH3
            // 
            this.txbH3.Location = new System.Drawing.Point(44, 98);
            this.txbH3.Name = "txbH3";
            this.txbH3.ReadOnly = true;
            this.txbH3.Size = new System.Drawing.Size(316, 20);
            this.txbH3.TabIndex = 22;
            // 
            // txbH4
            // 
            this.txbH4.Location = new System.Drawing.Point(44, 118);
            this.txbH4.Name = "txbH4";
            this.txbH4.ReadOnly = true;
            this.txbH4.Size = new System.Drawing.Size(316, 20);
            this.txbH4.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(341, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "?";
            this.tipTip.SetToolTip(this.label7, "Подсказка");
            // 
            // tipTip
            // 
            this.tipTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // StepThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 203);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbH4);
            this.Controls.Add(this.txbH3);
            this.Controls.Add(this.txbH2);
            this.Controls.Add(this.txbH1);
            this.Controls.Add(this.txbH0);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StepThree";
            this.Text = "StepThree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbH0;
        private System.Windows.Forms.TextBox txbH1;
        private System.Windows.Forms.TextBox txbH2;
        private System.Windows.Forms.TextBox txbH3;
        private System.Windows.Forms.TextBox txbH4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip tipTip;
    }
}