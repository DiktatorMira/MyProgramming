namespace Dz12._04._2023
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
            this.extension = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.folderBrowser1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListView();
            this.comboDisk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(704, 9);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(64, 22);
            this.extension.TabIndex = 1;
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Location = new System.Drawing.Point(12, 40);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(129, 47);
            this.check.TabIndex = 4;
            this.check.Text = "Начать поиск";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Расширение:";
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(639, 40);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(129, 47);
            this.stop.TabIndex = 6;
            this.stop.Text = "Остановить поиск";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // fileList
            // 
            this.fileList.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.fileList.AllowColumnReorder = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(12, 111);
            this.fileList.Name = "fileList";
            this.fileList.ShowItemToolTips = true;
            this.fileList.Size = new System.Drawing.Size(756, 515);
            this.fileList.TabIndex = 7;
            this.fileList.UseCompatibleStateImageBehavior = false;
            // 
            // comboDisk
            // 
            this.comboDisk.FormattingEnabled = true;
            this.comboDisk.Location = new System.Drawing.Point(73, 9);
            this.comboDisk.Name = "comboDisk";
            this.comboDisk.Size = new System.Drawing.Size(82, 24);
            this.comboDisk.TabIndex = 8;
            this.comboDisk.SelectedIndexChanged += new System.EventHandler(this.comboDisk_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Диск:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Диск:";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 638);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDisk);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.extension);
            this.Name = "Form1";
            this.Text = "FileStat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox extension;
        public System.Windows.Forms.Button check;
        public System.Windows.Forms.FolderBrowserDialog folderBrowser1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button stop;
        public System.Windows.Forms.ListView fileList;
        public System.Windows.Forms.ComboBox comboDisk;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}

