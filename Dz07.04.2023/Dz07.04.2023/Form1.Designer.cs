namespace Dz07._04._2023
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.context1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.context1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Заправка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Кафе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Посчитать всё";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // context1
            // 
            this.context1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.context1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1});
            this.context1.Name = "context1";
            this.context1.Size = new System.Drawing.Size(123, 28);
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(122, 24);
            this.menu1.Text = "Выход";
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenu1
            // 
            this.stripMenu1.Name = "stripMenu1";
            this.stripMenu1.Size = new System.Drawing.Size(67, 24);
            this.stripMenu1.Text = "Выход";
            this.stripMenu1.Click += new System.EventHandler(this.stripMenu1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 260);
            this.ContextMenuStrip = this.context1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Окко";
            this.context1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip context1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenu1;
    }
}

