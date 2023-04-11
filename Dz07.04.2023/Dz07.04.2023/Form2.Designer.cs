namespace Dz07._04._2023
{
    partial class Form2
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
            this.group1 = new System.Windows.Forms.GroupBox();
            this.check1 = new System.Windows.Forms.Button();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.radio12 = new System.Windows.Forms.RadioButton();
            this.radio11 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.Controls.Add(this.check1);
            this.group1.Controls.Add(this.group3);
            this.group1.Controls.Add(this.label4);
            this.group1.Controls.Add(this.label5);
            this.group1.Controls.Add(this.textBox3);
            this.group1.Controls.Add(this.textBox2);
            this.group1.Controls.Add(this.group2);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.textBox1);
            this.group1.Controls.Add(this.combo1);
            this.group1.Controls.Add(this.label1);
            this.group1.Location = new System.Drawing.Point(22, 21);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(200, 304);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Text = "Заправка";
            // 
            // check1
            // 
            this.check1.Enabled = false;
            this.check1.Location = new System.Drawing.Point(51, 187);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(104, 44);
            this.check1.TabIndex = 10;
            this.check1.Text = "Посчитать";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.Click += new System.EventHandler(this.check1_Click);
            // 
            // group3
            // 
            this.group3.Controls.Add(this.label6);
            this.group3.Location = new System.Drawing.Point(10, 231);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(180, 67);
            this.group3.TabIndex = 9;
            this.group3.TabStop = false;
            this.group3.Text = "К оплате:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(89, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "0 грн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "л";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "грн";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(108, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0,0";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(108, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0.0";
            // 
            // group2
            // 
            this.group2.Controls.Add(this.radio12);
            this.group2.Controls.Add(this.radio11);
            this.group2.Location = new System.Drawing.Point(6, 94);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(96, 87);
            this.group2.TabIndex = 4;
            this.group2.TabStop = false;
            // 
            // radio12
            // 
            this.radio12.AutoSize = true;
            this.radio12.Enabled = false;
            this.radio12.Location = new System.Drawing.Point(3, 49);
            this.radio12.Name = "radio12";
            this.radio12.Size = new System.Drawing.Size(71, 20);
            this.radio12.TabIndex = 1;
            this.radio12.TabStop = true;
            this.radio12.Text = "Сумма";
            this.radio12.UseVisualStyleBackColor = true;
            this.radio12.CheckedChanged += new System.EventHandler(this.radio12_CheckedChanged_1);
            // 
            // radio11
            // 
            this.radio11.AutoSize = true;
            this.radio11.Checked = true;
            this.radio11.Enabled = false;
            this.radio11.Location = new System.Drawing.Point(3, 21);
            this.radio11.Name = "radio11";
            this.radio11.Size = new System.Drawing.Size(72, 20);
            this.radio11.TabIndex = 0;
            this.radio11.TabStop = true;
            this.radio11.Text = "Объём";
            this.radio11.UseVisualStyleBackColor = true;
            this.radio11.CheckedChanged += new System.EventHandler(this.radio11_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "грн";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // combo1
            // 
            this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(87, 28);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(84, 24);
            this.combo1.TabIndex = 1;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Топливо";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 351);
            this.Controls.Add(this.group1);
            this.Name = "Form2";
            this.Text = "Заправка";
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Button check1;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.RadioButton radio12;
        private System.Windows.Forms.RadioButton radio11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label label1;
    }
}