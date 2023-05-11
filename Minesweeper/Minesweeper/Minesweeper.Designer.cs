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
            this.menu22_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu22_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu23_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu24 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu24_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu24_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu25 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu25_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu25_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.musicCheck = new System.Windows.Forms.CheckBox();
            this.smile = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
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
            this.menuStrip1.Size = new System.Drawing.Size(541, 31);
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
            this.menu22,
            this.menu23,
            this.menu24,
            this.menu25});
            this.toolMenu2.Name = "toolMenu2";
            this.toolMenu2.Size = new System.Drawing.Size(107, 27);
            this.toolMenu2.Text = "Настройки";
            this.toolMenu2.Click += new System.EventHandler(this.MenuClicks);
            this.toolMenu2.MouseEnter += new System.EventHandler(this.toolMenu2_MouseEnter);
            this.toolMenu2.MouseLeave += new System.EventHandler(this.toolMenu2_MouseLeave);
            // 
            // menu21
            // 
            this.menu21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu21_1,
            this.menu21_2,
            this.menu21_3});
            this.menu21.Name = "menu21";
            this.menu21.Size = new System.Drawing.Size(240, 28);
            this.menu21.Text = "Язык";
            this.menu21.Click += new System.EventHandler(this.MenuClicks);
            // 
            // menu21_1
            // 
            this.menu21_1.Enabled = false;
            this.menu21_1.Name = "menu21_1";
            this.menu21_1.Size = new System.Drawing.Size(182, 28);
            this.menu21_1.Text = "Русский";
            this.menu21_1.Click += new System.EventHandler(this.LanguageClick);
            // 
            // menu21_2
            // 
            this.menu21_2.Name = "menu21_2";
            this.menu21_2.Size = new System.Drawing.Size(182, 28);
            this.menu21_2.Text = "УкраЇнська";
            this.menu21_2.Click += new System.EventHandler(this.LanguageClick);
            // 
            // menu21_3
            // 
            this.menu21_3.Name = "menu21_3";
            this.menu21_3.Size = new System.Drawing.Size(182, 28);
            this.menu21_3.Text = "English";
            this.menu21_3.Click += new System.EventHandler(this.LanguageClick);
            // 
            // menu22
            // 
            this.menu22.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu22_1,
            this.menu22_2,
            this.menu22_3,
            this.menu22_4});
            this.menu22.Name = "menu22";
            this.menu22.Size = new System.Drawing.Size(240, 28);
            this.menu22.Text = "Сложность";
            this.menu22.ToolTipText = "Отвечает за % минных клеток";
            this.menu22.Click += new System.EventHandler(this.MenuClicks);
            // 
            // menu22_1
            // 
            this.menu22_1.Name = "menu22_1";
            this.menu22_1.Size = new System.Drawing.Size(213, 28);
            this.menu22_1.Text = "Лёгкая";
            this.menu22_1.ToolTipText = "10% минных клеток";
            this.menu22_1.Click += new System.EventHandler(this.DifficultyClick);
            // 
            // menu22_2
            // 
            this.menu22_2.Enabled = false;
            this.menu22_2.Name = "menu22_2";
            this.menu22_2.Size = new System.Drawing.Size(213, 28);
            this.menu22_2.Text = "Средняя";
            this.menu22_2.ToolTipText = "Отвечает за % минных клеток";
            this.menu22_2.Click += new System.EventHandler(this.DifficultyClick);
            // 
            // menu22_3
            // 
            this.menu22_3.Name = "menu22_3";
            this.menu22_3.Size = new System.Drawing.Size(213, 28);
            this.menu22_3.Text = "Сложная";
            this.menu22_3.ToolTipText = "Отвечает за % минных клеток";
            this.menu22_3.Click += new System.EventHandler(this.DifficultyClick);
            // 
            // menu22_4
            // 
            this.menu22_4.Name = "menu22_4";
            this.menu22_4.Size = new System.Drawing.Size(213, 28);
            this.menu22_4.Text = "Экстремальная";
            this.menu22_4.ToolTipText = "Отвечает за % минных клеток";
            this.menu22_4.Click += new System.EventHandler(this.DifficultyClick);
            // 
            // menu23
            // 
            this.menu23.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu23_1,
            this.menu23_2,
            this.menu23_3,
            this.menu23_4,
            this.menu23_5,
            this.menu23_6});
            this.menu23.Name = "menu23";
            this.menu23.Size = new System.Drawing.Size(240, 28);
            this.menu23.Text = "Размер поля";
            // 
            // menu23_1
            // 
            this.menu23_1.Name = "menu23_1";
            this.menu23_1.Size = new System.Drawing.Size(140, 28);
            this.menu23_1.Text = "5х5";
            this.menu23_1.Click += new System.EventHandler(this.FieldClick);
            // 
            // menu23_2
            // 
            this.menu23_2.Name = "menu23_2";
            this.menu23_2.Size = new System.Drawing.Size(140, 28);
            this.menu23_2.Text = "10x5";
            this.menu23_2.Click += new System.EventHandler(this.FieldClick);
            // 
            // menu23_3
            // 
            this.menu23_3.Enabled = false;
            this.menu23_3.Name = "menu23_3";
            this.menu23_3.Size = new System.Drawing.Size(140, 28);
            this.menu23_3.Text = "10х10";
            this.menu23_3.Click += new System.EventHandler(this.FieldClick);
            // 
            // menu23_4
            // 
            this.menu23_4.Name = "menu23_4";
            this.menu23_4.Size = new System.Drawing.Size(140, 28);
            this.menu23_4.Text = "14x10";
            this.menu23_4.Click += new System.EventHandler(this.FieldClick);
            // 
            // menu23_5
            // 
            this.menu23_5.Name = "menu23_5";
            this.menu23_5.Size = new System.Drawing.Size(140, 28);
            this.menu23_5.Text = "14х14";
            this.menu23_5.Click += new System.EventHandler(this.FieldClick);
            // 
            // menu23_6
            // 
            this.menu23_6.Name = "menu23_6";
            this.menu23_6.Size = new System.Drawing.Size(140, 28);
            this.menu23_6.Text = "30x14";
            this.menu23_6.Click += new System.EventHandler(this.FieldClick);
            // 
            // menu24
            // 
            this.menu24.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu24_1,
            this.menu24_2});
            this.menu24.Name = "menu24";
            this.menu24.Size = new System.Drawing.Size(240, 28);
            this.menu24.Text = "Темы оформления";
            this.menu24.Click += new System.EventHandler(this.MenuClicks);
            // 
            // menu24_1
            // 
            this.menu24_1.Enabled = false;
            this.menu24_1.Name = "menu24_1";
            this.menu24_1.Size = new System.Drawing.Size(157, 28);
            this.menu24_1.Text = "Светлая";
            this.menu24_1.Click += new System.EventHandler(this.ColorClick);
            // 
            // menu24_2
            // 
            this.menu24_2.Name = "menu24_2";
            this.menu24_2.Size = new System.Drawing.Size(157, 28);
            this.menu24_2.Text = "Тёмная";
            this.menu24_2.Click += new System.EventHandler(this.ColorClick);
            // 
            // menu25
            // 
            this.menu25.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu25_1,
            this.menu25_2});
            this.menu25.Name = "menu25";
            this.menu25.Size = new System.Drawing.Size(240, 28);
            this.menu25.Text = "Обои";
            this.menu25.Click += new System.EventHandler(this.MenuClicks);
            // 
            // menu25_1
            // 
            this.menu25_1.Enabled = false;
            this.menu25_1.Name = "menu25_1";
            this.menu25_1.Size = new System.Drawing.Size(224, 28);
            this.menu25_1.Text = "Выкл";
            this.menu25_1.Click += new System.EventHandler(this.WallpaperClick);
            // 
            // menu25_2
            // 
            this.menu25_2.Name = "menu25_2";
            this.menu25_2.Size = new System.Drawing.Size(224, 28);
            this.menu25_2.Text = "Вкл";
            this.menu25_2.Click += new System.EventHandler(this.WallpaperClick);
            // 
            // toolMenu3
            // 
            this.toolMenu3.Name = "toolMenu3";
            this.toolMenu3.Size = new System.Drawing.Size(138, 27);
            this.toolMenu3.Text = "Начать заново";
            this.toolMenu3.Click += new System.EventHandler(this.toolMenu3_Click);
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
            this.timerBox.Location = new System.Drawing.Point(399, 35);
            this.timerBox.Name = "timerBox";
            this.timerBox.ReadOnly = true;
            this.timerBox.Size = new System.Drawing.Size(100, 35);
            this.timerBox.TabIndex = 1;
            this.timerBox.Text = "00:00";
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
            this.musicCheck.Location = new System.Drawing.Point(23, 56);
            this.musicCheck.Name = "musicCheck";
            this.musicCheck.Size = new System.Drawing.Size(90, 25);
            this.musicCheck.TabIndex = 2;
            this.musicCheck.Text = "Музыка";
            this.musicCheck.UseVisualStyleBackColor = true;
            this.musicCheck.CheckedChanged += new System.EventHandler(this.musicCheck_CheckedChanged);
            // 
            // smile
            // 
            this.smile.Location = new System.Drawing.Point(215, 57);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(48, 48);
            this.smile.TabIndex = 3;
            this.smile.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 583);
            this.Controls.Add(this.smile);
            this.Controls.Add(this.musicCheck);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("KardinalPro ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Minesweeper";
            this.Text = "Сапёр v2.0 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Minesweeper_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem menu22_3;
        private System.Windows.Forms.ToolStripMenuItem menu23;
        private System.Windows.Forms.ToolStripMenuItem menu23_1;
        private System.Windows.Forms.ToolStripMenuItem menu23_3;
        private System.Windows.Forms.ToolStripMenuItem menu23_5;
        private System.Windows.Forms.ToolStripMenuItem menu23_6;
        private System.Windows.Forms.Button smile;
        private System.Windows.Forms.ToolStripMenuItem menu22_4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem menu23_2;
        private System.Windows.Forms.ToolStripMenuItem menu23_4;
        private System.Windows.Forms.ToolStripMenuItem menu24;
        private System.Windows.Forms.ToolStripMenuItem menu24_1;
        private System.Windows.Forms.ToolStripMenuItem menu24_2;
        private System.Windows.Forms.ToolStripMenuItem menu25;
        private System.Windows.Forms.ToolStripMenuItem menu25_1;
        private System.Windows.Forms.ToolStripMenuItem menu25_2;
    }
}

