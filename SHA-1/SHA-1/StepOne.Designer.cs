﻿namespace SHA1
{
    partial class StepOne
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSymbols = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.txbTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(285, 168);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имеем входное сообщение. \r\nПутём добавления битов, доведите сообщение до состояни" +
    "я, \r\nготового к работе с ним:";
            // 
            // lbSymbols
            // 
            this.lbSymbols.AutoSize = true;
            this.lbSymbols.Location = new System.Drawing.Point(9, 173);
            this.lbSymbols.Name = "lbSymbols";
            this.lbSymbols.Size = new System.Drawing.Size(70, 13);
            this.lbSymbols.TabIndex = 5;
            this.lbSymbols.Text = "Символов: 0";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(12, 77);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(348, 85);
            this.rtbResult.TabIndex = 6;
            this.rtbResult.Text = "";
            this.rtbResult.TextChanged += new System.EventHandler(this.rtbResult_TextChanged);
            // 
            // txbTask
            // 
            this.txbTask.Location = new System.Drawing.Point(12, 51);
            this.txbTask.Name = "txbTask";
            this.txbTask.ReadOnly = true;
            this.txbTask.Size = new System.Drawing.Size(348, 20);
            this.txbTask.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(341, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "?";
            this.tipTip.SetToolTip(this.label2, "Подсказка");
            // 
            // tipTip
            // 
            this.tipTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // StepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTask);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lbSymbols);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textBox1);
            this.Name = "StepOne";
            this.Text = "StepOne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSymbols;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.TextBox txbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tipTip;
    }
}