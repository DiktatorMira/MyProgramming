namespace Dz12._04._2023_2 {
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
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combo1.Location = new System.Drawing.Point(28, 45);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(297, 24);
            this.combo1.TabIndex = 0;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена:";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(28, 97);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 44);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 16;
            this.list1.Location = new System.Drawing.Point(28, 158);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(297, 244);
            this.list1.TabIndex = 4;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(190, 97);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 44);
            this.clear.TabIndex = 5;
            this.clear.Text = "Сбросить выбранное";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(42, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Общая стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo1);
            this.Name = "Form1";
            this.Text = "Фирма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

