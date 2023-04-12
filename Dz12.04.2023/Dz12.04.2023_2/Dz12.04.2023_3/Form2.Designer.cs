namespace Dz12._04._2023_3 {
    partial class Редактирование {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deny = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 360);
            this.textBox1.TabIndex = 3;
            // 
            // deny
            // 
            this.deny.Location = new System.Drawing.Point(268, 12);
            this.deny.Name = "deny";
            this.deny.Size = new System.Drawing.Size(114, 42);
            this.deny.TabIndex = 5;
            this.deny.Text = "Отменить";
            this.deny.UseVisualStyleBackColor = true;
            this.deny.Click += new System.EventHandler(this.deny_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 42);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Редактирование
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 433);
            this.Controls.Add(this.deny);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox1);
            this.Name = "Редактирование";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deny;
        private System.Windows.Forms.Button save;
    }
}