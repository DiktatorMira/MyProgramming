namespace Minesweeper
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.statBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // statBox
            // 
            this.statBox.Font = new System.Drawing.Font("KardinalPro ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.statBox.Location = new System.Drawing.Point(33, 12);
            this.statBox.Name = "statBox";
            this.statBox.ReadOnly = true;
            this.statBox.Size = new System.Drawing.Size(478, 383);
            this.statBox.TabIndex = 0;
            this.statBox.Text = "";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 432);
            this.Controls.Add(this.statBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox statBox;
    }
}