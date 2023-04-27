namespace Minesweeper {
    partial class Minesweeper {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minesweeper));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu21 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu21_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu21_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu21_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu22 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu22_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu22_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.musicCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Finlandica SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu1,
            this.toolMenu2,
            this.toolMenu3,
            this.toolMenu4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(448, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolMenu1
            // 
            this.toolMenu1.Name = "toolMenu1";
            this.toolMenu1.Size = new System.Drawing.Size(118, 27);
            this.toolMenu1.Text = "Начать игру";
            this.toolMenu1.Click += new System.EventHandler(this.toolMenu1_Click);
            // 
            // toolMenu2
            // 
            this.toolMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu21,
            this.menu22});
            this.toolMenu2.Name = "toolMenu2";
            this.toolMenu2.Size = new System.Drawing.Size(107, 27);
            this.toolMenu2.Text = "Настройки";
            this.toolMenu2.Click += new System.EventHandler(this.menu_clicks);
            // 
            // menu21
            // 
            this.menu21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu21_1,
            this.menu21_2,
            this.menu21_3});
            this.menu21.Name = "menu21";
            this.menu21.Size = new System.Drawing.Size(242, 28);
            this.menu21.Text = "Язык";
            this.menu21.Click += new System.EventHandler(this.menu_clicks);
            // 
            // menu21_1
            // 
            this.menu21_1.Enabled = false;
            this.menu21_1.Name = "menu21_1";
            this.menu21_1.Size = new System.Drawing.Size(224, 28);
            this.menu21_1.Text = "Русский";
            this.menu21_1.Click += new System.EventHandler(this.menu21_1_Click);
            // 
            // menu21_2
            // 
            this.menu21_2.Name = "menu21_2";
            this.menu21_2.Size = new System.Drawing.Size(224, 28);
            this.menu21_2.Text = "УкраЇнська";
            this.menu21_2.Click += new System.EventHandler(this.menu21_2_Click);
            // 
            // menu21_3
            // 
            this.menu21_3.Name = "menu21_3";
            this.menu21_3.Size = new System.Drawing.Size(224, 28);
            this.menu21_3.Text = "English";
            this.menu21_3.Click += new System.EventHandler(this.menu21_3_Click);
            // 
            // menu22
            // 
            this.menu22.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu22_1,
            this.menu22_2});
            this.menu22.Name = "menu22";
            this.menu22.Size = new System.Drawing.Size(242, 28);
            this.menu22.Text = "Стиль приложения";
            this.menu22.Click += new System.EventHandler(this.menu_clicks);
            // 
            // menu22_1
            // 
            this.menu22_1.Enabled = false;
            this.menu22_1.Name = "menu22_1";
            this.menu22_1.Size = new System.Drawing.Size(224, 28);
            this.menu22_1.Text = "Классический";
            // 
            // menu22_2
            // 
            this.menu22_2.Name = "menu22_2";
            this.menu22_2.Size = new System.Drawing.Size(224, 28);
            this.menu22_2.Text = "Современный";
            // 
            // toolMenu3
            // 
            this.toolMenu3.Name = "toolMenu3";
            this.toolMenu3.Size = new System.Drawing.Size(137, 27);
            this.toolMenu3.Text = "О приложении";
            // 
            // toolMenu4
            // 
            this.toolMenu4.Name = "toolMenu4";
            this.toolMenu4.Size = new System.Drawing.Size(75, 27);
            this.toolMenu4.Text = "Выйти";
            this.toolMenu4.Click += new System.EventHandler(this.toolMenu4_Click);
            // 
            // timerBox
            // 
            this.timerBox.Font = new System.Drawing.Font("KardinalPro ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.timerBox.Location = new System.Drawing.Point(217, 34);
            this.timerBox.Name = "timerBox";
            this.timerBox.ReadOnly = true;
            this.timerBox.Size = new System.Drawing.Size(100, 35);
            this.timerBox.TabIndex = 1;
            this.timerBox.Text = "03:00";
            this.timerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // musicCheck
            // 
            this.musicCheck.AutoSize = true;
            this.musicCheck.Font = new System.Drawing.Font("KardinalPro ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.musicCheck.Location = new System.Drawing.Point(23, 35);
            this.musicCheck.Name = "musicCheck";
            this.musicCheck.Size = new System.Drawing.Size(90, 25);
            this.musicCheck.TabIndex = 2;
            this.musicCheck.Text = "Музыка";
            this.musicCheck.UseVisualStyleBackColor = true;
            this.musicCheck.CheckedChanged += new System.EventHandler(this.musicCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 583);
            this.Controls.Add(this.musicCheck);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("KardinalPro ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Сапёр v2.0 ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolMenu2;
        private System.Windows.Forms.ToolStripMenuItem menu21;
        private System.Windows.Forms.ToolStripMenuItem menu21_1;
        private System.Windows.Forms.ToolStripMenuItem menu21_2;
        private System.Windows.Forms.ToolStripMenuItem menu21_3;
        private System.Windows.Forms.ToolStripMenuItem menu22;
        private System.Windows.Forms.ToolStripMenuItem menu22_1;
        private System.Windows.Forms.ToolStripMenuItem menu22_2;
        private System.Windows.Forms.ToolStripMenuItem toolMenu3;
        private System.Windows.Forms.ToolStripMenuItem toolMenu4;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox musicCheck;
    }
}

