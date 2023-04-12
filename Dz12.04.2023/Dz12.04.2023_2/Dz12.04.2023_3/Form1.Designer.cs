namespace Dz12._04._2023_3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.load = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 13);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(114, 42);
            this.load.TabIndex = 0;
            this.load.Text = "Загрузить файл";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Location = new System.Drawing.Point(268, 13);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(114, 42);
            this.change.TabIndex = 1;
            this.change.Text = "Редактировать";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            this.open.Filter = "\"Txt files|*.txt|All files|*.*\"";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(369, 360);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.TextBox textBox1;
    }
}

