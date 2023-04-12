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
            this.pathText = new System.Windows.Forms.TextBox();
            this.extension = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.fileInfo = new System.Windows.Forms.ListBox();
            this.check = new System.Windows.Forms.Button();
            this.folderBrowser1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(12, 12);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(246, 22);
            this.pathText.TabIndex = 0;
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(379, 12);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(64, 22);
            this.extension.TabIndex = 1;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(314, 40);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(129, 47);
            this.find.TabIndex = 2;
            this.find.Text = "Обзор";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // fileInfo
            // 
            this.fileInfo.FormattingEnabled = true;
            this.fileInfo.ItemHeight = 16;
            this.fileInfo.Location = new System.Drawing.Point(12, 93);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Size = new System.Drawing.Size(431, 244);
            this.fileInfo.TabIndex = 3;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 40);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(129, 47);
            this.check.TabIndex = 4;
            this.check.Text = "Просмотреть список файлов";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Расширение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.fileInfo);
            this.Controls.Add(this.find);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.pathText);
            this.Name = "Form1";
            this.Text = "FileStat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.TextBox extension;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.ListBox fileInfo;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser1;
        private System.Windows.Forms.Label label1;
    }
}

