namespace Dz17._04._2023 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tree1 = new System.Windows.Forms.TreeView();
            this.fileList = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuDown1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDown2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDown3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDown4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree1
            // 
            this.tree1.Location = new System.Drawing.Point(0, 76);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(170, 589);
            this.tree1.TabIndex = 0;
            this.tree1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tree1_AfterExpand);
            this.tree1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree1_AfterSelect);
            // 
            // fileList
            // 
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(176, 26);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(1096, 639);
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1272, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolDown
            // 
            this.toolDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDown1,
            this.menuDown2,
            this.menuDown3,
            this.menuDown4});
            this.toolDown.Image = ((System.Drawing.Image)(resources.GetObject("toolDown.Image")));
            this.toolDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDown.Name = "toolDown";
            this.toolDown.Size = new System.Drawing.Size(34, 24);
            this.toolDown.Text = "toolStripDropDownButton1";
            // 
            // menuDown1
            // 
            this.menuDown1.Name = "menuDown1";
            this.menuDown1.Size = new System.Drawing.Size(224, 26);
            this.menuDown1.Text = "Список";
            this.menuDown1.Click += new System.EventHandler(this.menuDown1_Click);
            // 
            // menuDown2
            // 
            this.menuDown2.Name = "menuDown2";
            this.menuDown2.Size = new System.Drawing.Size(224, 26);
            this.menuDown2.Text = "Таблица";
            this.menuDown2.Click += new System.EventHandler(this.menuDown2_Click);
            // 
            // menuDown3
            // 
            this.menuDown3.Name = "menuDown3";
            this.menuDown3.Size = new System.Drawing.Size(224, 26);
            this.menuDown3.Text = "Маленькие значки";
            this.menuDown3.Click += new System.EventHandler(this.menuDown3_Click);
            // 
            // menuDown4
            // 
            this.menuDown4.Name = "menuDown4";
            this.menuDown4.Size = new System.Drawing.Size(224, 26);
            this.menuDown4.Text = "Большие значки";
            this.menuDown4.Click += new System.EventHandler(this.menuDown4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 668);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.tree1);
            this.Name = "Form1";
            this.Text = "Файловый менеджер";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree1;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolDown;
        private System.Windows.Forms.ToolStripMenuItem menuDown1;
        private System.Windows.Forms.ToolStripMenuItem menuDown2;
        private System.Windows.Forms.ToolStripMenuItem menuDown3;
        private System.Windows.Forms.ToolStripMenuItem menuDown4;
    }
}

