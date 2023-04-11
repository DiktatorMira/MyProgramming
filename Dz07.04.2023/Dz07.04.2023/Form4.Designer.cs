namespace Dz07._04._2023
{
    partial class Form4
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
            this.group6 = new System.Windows.Forms.GroupBox();
            this.check3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.group6.SuspendLayout();
            this.SuspendLayout();
            // 
            // group6
            // 
            this.group6.Controls.Add(this.check3);
            this.group6.Controls.Add(this.label10);
            this.group6.Location = new System.Drawing.Point(51, 32);
            this.group6.Name = "group6";
            this.group6.Size = new System.Drawing.Size(230, 71);
            this.group6.TabIndex = 3;
            this.group6.TabStop = false;
            this.group6.Text = "Всего к оплате:";
            // 
            // check3
            // 
            this.check3.Location = new System.Drawing.Point(24, 21);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(100, 38);
            this.check3.TabIndex = 30;
            this.check3.Text = "Посчитать";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.Click += new System.EventHandler(this.check3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(139, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "0 грн";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 141);
            this.Controls.Add(this.group6);
            this.Name = "Form4";
            this.Text = "Итог";
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group6;
        private System.Windows.Forms.Button check3;
        private System.Windows.Forms.Label label10;
    }
}