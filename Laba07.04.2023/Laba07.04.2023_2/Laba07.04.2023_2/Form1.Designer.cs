namespace Laba07._04._2023_2
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masked4 = new System.Windows.Forms.MaskedTextBox();
            this.masked3 = new System.Windows.Forms.MaskedTextBox();
            this.masked2 = new System.Windows.Forms.MaskedTextBox();
            this.masked1 = new System.Windows.Forms.MaskedTextBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите фамилию:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите e-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите телефон:";
            // 
            // masked4
            // 
            this.masked4.Location = new System.Drawing.Point(145, 156);
            this.masked4.Mask = "(999) 000-0000";
            this.masked4.Name = "masked4";
            this.masked4.Size = new System.Drawing.Size(190, 22);
            this.masked4.TabIndex = 8;
            // 
            // masked3
            // 
            this.masked3.Location = new System.Drawing.Point(135, 118);
            this.masked3.Name = "masked3";
            this.masked3.Size = new System.Drawing.Size(190, 22);
            this.masked3.TabIndex = 9;
            // 
            // masked2
            // 
            this.masked2.Location = new System.Drawing.Point(149, 85);
            this.masked2.Mask = "????????????????";
            this.masked2.Name = "masked2";
            this.masked2.Size = new System.Drawing.Size(190, 22);
            this.masked2.TabIndex = 10;
            // 
            // masked1
            // 
            this.masked1.Location = new System.Drawing.Point(120, 47);
            this.masked1.Mask = "??????????";
            this.masked1.Name = "masked1";
            this.masked1.Size = new System.Drawing.Size(190, 22);
            this.masked1.TabIndex = 11;
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 16;
            this.list1.Location = new System.Drawing.Point(365, 47);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(147, 132);
            this.list1.TabIndex = 12;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(15, 195);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(161, 47);
            this.add.TabIndex = 13;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_MouseClick);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(182, 195);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(161, 47);
            this.export.TabIndex = 14;
            this.export.Text = "Экспорт в файл";
            this.export.UseVisualStyleBackColor = true;
            this.export.MouseClick += new System.Windows.Forms.MouseEventHandler(this.export_MouseClick);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(351, 195);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(161, 47);
            this.import.TabIndex = 15;
            this.import.Text = "Импорт из файла";
            this.import.UseVisualStyleBackColor = true;
            this.import.MouseClick += new System.Windows.Forms.MouseEventHandler(this.import_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 274);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.add);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.masked1);
            this.Controls.Add(this.masked2);
            this.Controls.Add(this.masked3);
            this.Controls.Add(this.masked4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masked4;
        private System.Windows.Forms.MaskedTextBox masked3;
        private System.Windows.Forms.MaskedTextBox masked2;
        private System.Windows.Forms.MaskedTextBox masked1;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button import;
    }
}

