namespace WindowsFormsApp1
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
            this.start = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.radio13 = new System.Windows.Forms.RadioButton();
            this.radio12 = new System.Windows.Forms.RadioButton();
            this.radio11 = new System.Windows.Forms.RadioButton();
            this.end = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.check26 = new System.Windows.Forms.CheckBox();
            this.check25 = new System.Windows.Forms.CheckBox();
            this.check24 = new System.Windows.Forms.CheckBox();
            this.check23 = new System.Windows.Forms.CheckBox();
            this.check22 = new System.Windows.Forms.CheckBox();
            this.check21 = new System.Windows.Forms.CheckBox();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.radio33 = new System.Windows.Forms.RadioButton();
            this.radio32 = new System.Windows.Forms.RadioButton();
            this.radio31 = new System.Windows.Forms.RadioButton();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.group4 = new System.Windows.Forms.GroupBox();
            this.radio43 = new System.Windows.Forms.RadioButton();
            this.radio42 = new System.Windows.Forms.RadioButton();
            this.radio41 = new System.Windows.Forms.RadioButton();
            this.group5 = new System.Windows.Forms.GroupBox();
            this.radio53 = new System.Windows.Forms.RadioButton();
            this.radio52 = new System.Windows.Forms.RadioButton();
            this.radio51 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.group6 = new System.Windows.Forms.GroupBox();
            this.check64 = new System.Windows.Forms.CheckBox();
            this.check63 = new System.Windows.Forms.CheckBox();
            this.check62 = new System.Windows.Forms.CheckBox();
            this.check61 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.group7 = new System.Windows.Forms.GroupBox();
            this.radio73 = new System.Windows.Forms.RadioButton();
            this.radio72 = new System.Windows.Forms.RadioButton();
            this.radio71 = new System.Windows.Forms.RadioButton();
            this.group8 = new System.Windows.Forms.GroupBox();
            this.radio83 = new System.Windows.Forms.RadioButton();
            this.radio82 = new System.Windows.Forms.RadioButton();
            this.radio81 = new System.Windows.Forms.RadioButton();
            this.group9 = new System.Windows.Forms.GroupBox();
            this.check94 = new System.Windows.Forms.CheckBox();
            this.check93 = new System.Windows.Forms.CheckBox();
            this.check92 = new System.Windows.Forms.CheckBox();
            this.check91 = new System.Windows.Forms.CheckBox();
            this.group10 = new System.Windows.Forms.GroupBox();
            this.radio101 = new System.Windows.Forms.RadioButton();
            this.radio102 = new System.Windows.Forms.RadioButton();
            this.radio103 = new System.Windows.Forms.RadioButton();
            this.start2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.group6.SuspendLayout();
            this.group7.SuspendLayout();
            this.group8.SuspendLayout();
            this.group9.SuspendLayout();
            this.group10.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("Gagalin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(557, 437);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(164, 65);
            this.start.TabIndex = 0;
            this.start.Text = "Начать викторину";
            this.start.UseVisualStyleBackColor = true;
            this.start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start_MouseClick);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.radio13);
            this.group1.Controls.Add(this.radio12);
            this.group1.Controls.Add(this.radio11);
            this.group1.Enabled = false;
            this.group1.Location = new System.Drawing.Point(12, 12);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(195, 111);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Text = "Сколько цветов в системе RGB?";
            // 
            // radio13
            // 
            this.radio13.AutoSize = true;
            this.radio13.Location = new System.Drawing.Point(6, 86);
            this.radio13.Name = "radio13";
            this.radio13.Size = new System.Drawing.Size(49, 20);
            this.radio13.TabIndex = 2;
            this.radio13.TabStop = true;
            this.radio13.Text = "200";
            this.radio13.UseVisualStyleBackColor = true;
            // 
            // radio12
            // 
            this.radio12.AutoSize = true;
            this.radio12.Location = new System.Drawing.Point(6, 60);
            this.radio12.Name = "radio12";
            this.radio12.Size = new System.Drawing.Size(35, 20);
            this.radio12.TabIndex = 1;
            this.radio12.TabStop = true;
            this.radio12.Text = "3";
            this.radio12.UseVisualStyleBackColor = true;
            // 
            // radio11
            // 
            this.radio11.AutoSize = true;
            this.radio11.Location = new System.Drawing.Point(6, 34);
            this.radio11.Name = "radio11";
            this.radio11.Size = new System.Drawing.Size(35, 20);
            this.radio11.TabIndex = 0;
            this.radio11.TabStop = true;
            this.radio11.Text = "2";
            this.radio11.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.end.Enabled = false;
            this.end.Font = new System.Drawing.Font("Gagalin", 10F);
            this.end.Location = new System.Drawing.Point(727, 437);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(164, 65);
            this.end.TabIndex = 2;
            this.end.Text = "Проверить результат";
            this.end.UseVisualStyleBackColor = true;
            this.end.MouseClick += new System.Windows.Forms.MouseEventHandler(this.end_MouseClick);
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.SystemColors.Control;
            this.progress.Enabled = false;
            this.progress.Location = new System.Drawing.Point(719, 408);
            this.progress.MarqueeAnimationSpeed = 10;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(185, 23);
            this.progress.TabIndex = 3;
            // 
            // group2
            // 
            this.group2.Controls.Add(this.check26);
            this.group2.Controls.Add(this.check25);
            this.group2.Controls.Add(this.check24);
            this.group2.Controls.Add(this.check23);
            this.group2.Controls.Add(this.check22);
            this.group2.Controls.Add(this.check21);
            this.group2.Enabled = false;
            this.group2.Location = new System.Drawing.Point(12, 143);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(208, 110);
            this.group2.TabIndex = 4;
            this.group2.TabStop = false;
            this.group2.Text = "Что растет на земле?";
            // 
            // check26
            // 
            this.check26.AutoSize = true;
            this.check26.Location = new System.Drawing.Point(115, 74);
            this.check26.Name = "check26";
            this.check26.Size = new System.Drawing.Size(53, 20);
            this.check26.TabIndex = 5;
            this.check26.Text = "Лук";
            this.check26.UseVisualStyleBackColor = true;
            // 
            // check25
            // 
            this.check25.AutoSize = true;
            this.check25.Location = new System.Drawing.Point(99, 48);
            this.check25.Name = "check25";
            this.check25.Size = new System.Drawing.Size(96, 20);
            this.check25.TabIndex = 4;
            this.check25.Text = "Мандарин";
            this.check25.UseVisualStyleBackColor = true;
            // 
            // check24
            // 
            this.check24.AutoSize = true;
            this.check24.Location = new System.Drawing.Point(99, 22);
            this.check24.Name = "check24";
            this.check24.Size = new System.Drawing.Size(108, 20);
            this.check24.TabIndex = 3;
            this.check24.Text = "Видеокарта";
            this.check24.UseVisualStyleBackColor = true;
            // 
            // check23
            // 
            this.check23.AutoSize = true;
            this.check23.Location = new System.Drawing.Point(7, 74);
            this.check23.Name = "check23";
            this.check23.Size = new System.Drawing.Size(102, 20);
            this.check23.TabIndex = 2;
            this.check23.Text = "Картофель";
            this.check23.UseVisualStyleBackColor = true;
            // 
            // check22
            // 
            this.check22.AutoSize = true;
            this.check22.Location = new System.Drawing.Point(6, 48);
            this.check22.Name = "check22";
            this.check22.Size = new System.Drawing.Size(63, 20);
            this.check22.TabIndex = 1;
            this.check22.Text = "Рыба";
            this.check22.UseVisualStyleBackColor = true;
            // 
            // check21
            // 
            this.check21.AutoSize = true;
            this.check21.Location = new System.Drawing.Point(7, 22);
            this.check21.Name = "check21";
            this.check21.Size = new System.Drawing.Size(86, 20);
            this.check21.TabIndex = 0;
            this.check21.Text = "Морковь";
            this.check21.UseVisualStyleBackColor = true;
            // 
            // group3
            // 
            this.group3.Controls.Add(this.radio33);
            this.group3.Controls.Add(this.radio32);
            this.group3.Controls.Add(this.radio31);
            this.group3.Enabled = false;
            this.group3.Location = new System.Drawing.Point(12, 269);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(200, 100);
            this.group3.TabIndex = 5;
            this.group3.TabStop = false;
            this.group3.Text = "Что такое HDD?";
            // 
            // radio33
            // 
            this.radio33.AutoSize = true;
            this.radio33.Location = new System.Drawing.Point(7, 74);
            this.radio33.Name = "radio33";
            this.radio33.Size = new System.Drawing.Size(166, 20);
            this.radio33.TabIndex = 2;
            this.radio33.TabStop = true;
            this.radio33.Text = "Это типо смайлик XD";
            this.radio33.UseVisualStyleBackColor = true;
            // 
            // radio32
            // 
            this.radio32.AutoSize = true;
            this.radio32.Location = new System.Drawing.Point(7, 48);
            this.radio32.Name = "radio32";
            this.radio32.Size = new System.Drawing.Size(180, 20);
            this.radio32.TabIndex = 1;
            this.radio32.TabStop = true;
            this.radio32.Text = "Эмм ну качество такое";
            this.radio32.UseVisualStyleBackColor = true;
            // 
            // radio31
            // 
            this.radio31.AutoSize = true;
            this.radio31.Location = new System.Drawing.Point(7, 22);
            this.radio31.Name = "radio31";
            this.radio31.Size = new System.Drawing.Size(143, 20);
            this.radio31.TabIndex = 0;
            this.radio31.TabStop = true;
            this.radio31.Text = "Это жёсткий диск";
            this.radio31.UseVisualStyleBackColor = true;
            // 
            // picture1
            // 
            this.picture1.Image = global::WindowsFormsApp1.Properties.Resources.Ps;
            this.picture1.Location = new System.Drawing.Point(161, 21);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(141, 119);
            this.picture1.TabIndex = 6;
            this.picture1.TabStop = false;
            // 
            // group4
            // 
            this.group4.Controls.Add(this.radio43);
            this.group4.Controls.Add(this.radio42);
            this.group4.Controls.Add(this.radio41);
            this.group4.Controls.Add(this.picture1);
            this.group4.Enabled = false;
            this.group4.Location = new System.Drawing.Point(236, 12);
            this.group4.Name = "group4";
            this.group4.Size = new System.Drawing.Size(308, 146);
            this.group4.TabIndex = 7;
            this.group4.TabStop = false;
            this.group4.Text = "Что тут изображено?";
            // 
            // radio43
            // 
            this.radio43.AutoSize = true;
            this.radio43.Location = new System.Drawing.Point(6, 110);
            this.radio43.Name = "radio43";
            this.radio43.Size = new System.Drawing.Size(47, 20);
            this.radio43.TabIndex = 9;
            this.radio43.TabStop = true;
            this.radio43.Text = "Пш";
            this.radio43.UseVisualStyleBackColor = true;
            // 
            // radio42
            // 
            this.radio42.AutoSize = true;
            this.radio42.Location = new System.Drawing.Point(7, 71);
            this.radio42.Name = "radio42";
            this.radio42.Size = new System.Drawing.Size(130, 20);
            this.radio42.TabIndex = 8;
            this.radio42.TabStop = true;
            this.radio42.Text = "Это незаконно!";
            this.radio42.UseVisualStyleBackColor = true;
            // 
            // radio41
            // 
            this.radio41.AutoSize = true;
            this.radio41.Location = new System.Drawing.Point(7, 28);
            this.radio41.Name = "radio41";
            this.radio41.Size = new System.Drawing.Size(131, 20);
            this.radio41.TabIndex = 7;
            this.radio41.TabStop = true;
            this.radio41.Text = "Это... фотошоп?";
            this.radio41.UseVisualStyleBackColor = true;
            // 
            // group5
            // 
            this.group5.Controls.Add(this.radio53);
            this.group5.Controls.Add(this.radio52);
            this.group5.Controls.Add(this.radio51);
            this.group5.Enabled = false;
            this.group5.Location = new System.Drawing.Point(236, 164);
            this.group5.Name = "group5";
            this.group5.Size = new System.Drawing.Size(186, 100);
            this.group5.TabIndex = 8;
            this.group5.TabStop = false;
            this.group5.Text = "Что лучше С# или C++?";
            // 
            // radio53
            // 
            this.radio53.AutoSize = true;
            this.radio53.Location = new System.Drawing.Point(6, 74);
            this.radio53.Name = "radio53";
            this.radio53.Size = new System.Drawing.Size(139, 20);
            this.radio53.TabIndex = 2;
            this.radio53.TabStop = true;
            this.radio53.Text = "Все языки нужны";
            this.radio53.UseVisualStyleBackColor = true;
            // 
            // radio52
            // 
            this.radio52.AutoSize = true;
            this.radio52.Location = new System.Drawing.Point(7, 48);
            this.radio52.Name = "radio52";
            this.radio52.Size = new System.Drawing.Size(54, 20);
            this.radio52.TabIndex = 1;
            this.radio52.TabStop = true;
            this.radio52.Text = "C++!";
            this.radio52.UseVisualStyleBackColor = true;
            // 
            // radio51
            // 
            this.radio51.AutoSize = true;
            this.radio51.Location = new System.Drawing.Point(7, 22);
            this.radio51.Name = "radio51";
            this.radio51.Size = new System.Drawing.Size(47, 20);
            this.radio51.TabIndex = 0;
            this.radio51.TabStop = true;
            this.radio51.Text = "C#!";
            this.radio51.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "0%";
            // 
            // group6
            // 
            this.group6.Controls.Add(this.check64);
            this.group6.Controls.Add(this.check63);
            this.group6.Controls.Add(this.check62);
            this.group6.Controls.Add(this.check61);
            this.group6.Enabled = false;
            this.group6.Location = new System.Drawing.Point(236, 270);
            this.group6.Name = "group6";
            this.group6.Size = new System.Drawing.Size(200, 121);
            this.group6.TabIndex = 11;
            this.group6.TabStop = false;
            this.group6.Text = "Выберите правильное";
            // 
            // check64
            // 
            this.check64.AutoSize = true;
            this.check64.Location = new System.Drawing.Point(6, 95);
            this.check64.Name = "check64";
            this.check64.Size = new System.Drawing.Size(171, 20);
            this.check64.TabIndex = 3;
            this.check64.Text = "Белый гриб съедобен";
            this.check64.UseVisualStyleBackColor = true;
            // 
            // check63
            // 
            this.check63.AutoSize = true;
            this.check63.Location = new System.Drawing.Point(6, 74);
            this.check63.Name = "check63";
            this.check63.Size = new System.Drawing.Size(180, 20);
            this.check63.TabIndex = 2;
            this.check63.Text = "Гриф в зале весит 25кг";
            this.check63.UseVisualStyleBackColor = true;
            // 
            // check62
            // 
            this.check62.AutoSize = true;
            this.check62.Location = new System.Drawing.Point(6, 48);
            this.check62.Name = "check62";
            this.check62.Size = new System.Drawing.Size(174, 20);
            this.check62.TabIndex = 1;
            this.check62.Text = "У человека 28-32 зуба";
            this.check62.UseVisualStyleBackColor = true;
            // 
            // check61
            // 
            this.check61.AutoSize = true;
            this.check61.Location = new System.Drawing.Point(7, 22);
            this.check61.Name = "check61";
            this.check61.Size = new System.Drawing.Size(155, 20);
            this.check61.TabIndex = 0;
            this.check61.Text = "У человека 3 глаза";
            this.check61.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // group7
            // 
            this.group7.Controls.Add(this.radio73);
            this.group7.Controls.Add(this.radio72);
            this.group7.Controls.Add(this.radio71);
            this.group7.Enabled = false;
            this.group7.Location = new System.Drawing.Point(12, 375);
            this.group7.Name = "group7";
            this.group7.Size = new System.Drawing.Size(200, 127);
            this.group7.TabIndex = 12;
            this.group7.TabStop = false;
            this.group7.Text = "Какой город называют жемчужина у моря?";
            // 
            // radio73
            // 
            this.radio73.AutoSize = true;
            this.radio73.Location = new System.Drawing.Point(6, 86);
            this.radio73.Name = "radio73";
            this.radio73.Size = new System.Drawing.Size(85, 20);
            this.radio73.TabIndex = 2;
            this.radio73.TabStop = true;
            this.radio73.Text = "Магадан";
            this.radio73.UseVisualStyleBackColor = true;
            // 
            // radio72
            // 
            this.radio72.AutoSize = true;
            this.radio72.Location = new System.Drawing.Point(7, 62);
            this.radio72.Name = "radio72";
            this.radio72.Size = new System.Drawing.Size(76, 20);
            this.radio72.TabIndex = 1;
            this.radio72.TabStop = true;
            this.radio72.Text = "Одесса";
            this.radio72.UseVisualStyleBackColor = true;
            // 
            // radio71
            // 
            this.radio71.AutoSize = true;
            this.radio71.Location = new System.Drawing.Point(7, 38);
            this.radio71.Name = "radio71";
            this.radio71.Size = new System.Drawing.Size(60, 20);
            this.radio71.TabIndex = 0;
            this.radio71.TabStop = true;
            this.radio71.Text = "Киев";
            this.radio71.UseVisualStyleBackColor = true;
            // 
            // group8
            // 
            this.group8.Controls.Add(this.radio83);
            this.group8.Controls.Add(this.radio82);
            this.group8.Controls.Add(this.radio81);
            this.group8.Enabled = false;
            this.group8.Location = new System.Drawing.Point(557, 12);
            this.group8.Name = "group8";
            this.group8.Size = new System.Drawing.Size(200, 124);
            this.group8.TabIndex = 13;
            this.group8.TabStop = false;
            this.group8.Text = "Какой напиток делаю из винограда?";
            // 
            // radio83
            // 
            this.radio83.AutoSize = true;
            this.radio83.Location = new System.Drawing.Point(6, 92);
            this.radio83.Name = "radio83";
            this.radio83.Size = new System.Drawing.Size(93, 20);
            this.radio83.TabIndex = 2;
            this.radio83.TabStop = true;
            this.radio83.Text = "Медовуха";
            this.radio83.UseVisualStyleBackColor = true;
            // 
            // radio82
            // 
            this.radio82.AutoSize = true;
            this.radio82.Location = new System.Drawing.Point(7, 66);
            this.radio82.Name = "radio82";
            this.radio82.Size = new System.Drawing.Size(68, 20);
            this.radio82.TabIndex = 1;
            this.radio82.TabStop = true;
            this.radio82.Text = "Водка";
            this.radio82.UseVisualStyleBackColor = true;
            // 
            // radio81
            // 
            this.radio81.AutoSize = true;
            this.radio81.Location = new System.Drawing.Point(7, 41);
            this.radio81.Name = "radio81";
            this.radio81.Size = new System.Drawing.Size(61, 20);
            this.radio81.TabIndex = 0;
            this.radio81.TabStop = true;
            this.radio81.Text = "Вино";
            this.radio81.UseVisualStyleBackColor = true;
            // 
            // group9
            // 
            this.group9.Controls.Add(this.check94);
            this.group9.Controls.Add(this.check93);
            this.group9.Controls.Add(this.check92);
            this.group9.Controls.Add(this.check91);
            this.group9.Enabled = false;
            this.group9.Location = new System.Drawing.Point(557, 143);
            this.group9.Name = "group9";
            this.group9.Size = new System.Drawing.Size(200, 89);
            this.group9.TabIndex = 14;
            this.group9.TabStop = false;
            this.group9.Text = "Что из перечисленного мучное?";
            // 
            // check94
            // 
            this.check94.AutoSize = true;
            this.check94.Location = new System.Drawing.Point(101, 59);
            this.check94.Name = "check94";
            this.check94.Size = new System.Drawing.Size(69, 20);
            this.check94.TabIndex = 3;
            this.check94.Text = "Булка";
            this.check94.UseVisualStyleBackColor = true;
            // 
            // check93
            // 
            this.check93.AutoSize = true;
            this.check93.Location = new System.Drawing.Point(98, 33);
            this.check93.Name = "check93";
            this.check93.Size = new System.Drawing.Size(63, 20);
            this.check93.TabIndex = 2;
            this.check93.Text = "Яйца";
            this.check93.UseVisualStyleBackColor = true;
            // 
            // check92
            // 
            this.check92.AutoSize = true;
            this.check92.Location = new System.Drawing.Point(6, 59);
            this.check92.Name = "check92";
            this.check92.Size = new System.Drawing.Size(96, 20);
            this.check92.TabIndex = 1;
            this.check92.Text = "Макароны";
            this.check92.UseVisualStyleBackColor = true;
            // 
            // check91
            // 
            this.check91.AutoSize = true;
            this.check91.Location = new System.Drawing.Point(7, 33);
            this.check91.Name = "check91";
            this.check91.Size = new System.Drawing.Size(61, 20);
            this.check91.TabIndex = 0;
            this.check91.Text = "Хлеб";
            this.check91.UseVisualStyleBackColor = true;
            // 
            // group10
            // 
            this.group10.Controls.Add(this.radio103);
            this.group10.Controls.Add(this.radio102);
            this.group10.Controls.Add(this.radio101);
            this.group10.Enabled = false;
            this.group10.Location = new System.Drawing.Point(469, 260);
            this.group10.Name = "group10";
            this.group10.Size = new System.Drawing.Size(200, 125);
            this.group10.TabIndex = 15;
            this.group10.TabStop = false;
            this.group10.Text = "День независимости Украины";
            // 
            // radio101
            // 
            this.radio101.AutoSize = true;
            this.radio101.Location = new System.Drawing.Point(6, 42);
            this.radio101.Name = "radio101";
            this.radio101.Size = new System.Drawing.Size(109, 20);
            this.radio101.TabIndex = 0;
            this.radio101.TabStop = true;
            this.radio101.Text = "24 июля 1993";
            this.radio101.UseVisualStyleBackColor = true;
            // 
            // radio102
            // 
            this.radio102.AutoSize = true;
            this.radio102.Location = new System.Drawing.Point(6, 68);
            this.radio102.Name = "radio102";
            this.radio102.Size = new System.Drawing.Size(136, 20);
            this.radio102.TabIndex = 1;
            this.radio102.TabStop = true;
            this.radio102.Text = "18 сентября 1991";
            this.radio102.UseVisualStyleBackColor = true;
            // 
            // radio103
            // 
            this.radio103.AutoSize = true;
            this.radio103.Location = new System.Drawing.Point(6, 94);
            this.radio103.Name = "radio103";
            this.radio103.Size = new System.Drawing.Size(128, 20);
            this.radio103.TabIndex = 2;
            this.radio103.TabStop = true;
            this.radio103.Text = "24 августа 1991";
            this.radio103.UseVisualStyleBackColor = true;
            // 
            // start2
            // 
            this.start2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start2.Enabled = false;
            this.start2.Font = new System.Drawing.Font("Gagalin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start2.Location = new System.Drawing.Point(681, 269);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(164, 65);
            this.start2.TabIndex = 16;
            this.start2.Text = "Начать вопросс на время(5 сек)";
            this.start2.UseVisualStyleBackColor = true;
            this.start2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gagalin", 15F);
            this.label2.Location = new System.Drawing.Point(731, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.group10);
            this.Controls.Add(this.group9);
            this.Controls.Add(this.group8);
            this.Controls.Add(this.group7);
            this.Controls.Add(this.group6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group5);
            this.Controls.Add(this.group4);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.end);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Викторина";
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.group7.ResumeLayout(false);
            this.group7.PerformLayout();
            this.group8.ResumeLayout(false);
            this.group8.PerformLayout();
            this.group9.ResumeLayout(false);
            this.group9.PerformLayout();
            this.group10.ResumeLayout(false);
            this.group10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.RadioButton radio11;
        private System.Windows.Forms.RadioButton radio13;
        private System.Windows.Forms.RadioButton radio12;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.CheckBox check24;
        private System.Windows.Forms.CheckBox check23;
        private System.Windows.Forms.CheckBox check22;
        private System.Windows.Forms.CheckBox check21;
        private System.Windows.Forms.CheckBox check25;
        private System.Windows.Forms.CheckBox check26;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.RadioButton radio33;
        private System.Windows.Forms.RadioButton radio32;
        private System.Windows.Forms.RadioButton radio31;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.GroupBox group4;
        private System.Windows.Forms.RadioButton radio43;
        private System.Windows.Forms.RadioButton radio42;
        private System.Windows.Forms.RadioButton radio41;
        private System.Windows.Forms.GroupBox group5;
        private System.Windows.Forms.RadioButton radio53;
        private System.Windows.Forms.RadioButton radio52;
        private System.Windows.Forms.RadioButton radio51;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group6;
        private System.Windows.Forms.CheckBox check64;
        private System.Windows.Forms.CheckBox check63;
        private System.Windows.Forms.CheckBox check62;
        private System.Windows.Forms.CheckBox check61;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox group7;
        private System.Windows.Forms.RadioButton radio73;
        private System.Windows.Forms.RadioButton radio72;
        private System.Windows.Forms.RadioButton radio71;
        private System.Windows.Forms.GroupBox group8;
        private System.Windows.Forms.RadioButton radio83;
        private System.Windows.Forms.RadioButton radio82;
        private System.Windows.Forms.RadioButton radio81;
        private System.Windows.Forms.GroupBox group9;
        private System.Windows.Forms.CheckBox check94;
        private System.Windows.Forms.CheckBox check93;
        private System.Windows.Forms.CheckBox check92;
        private System.Windows.Forms.CheckBox check91;
        private System.Windows.Forms.GroupBox group10;
        private System.Windows.Forms.RadioButton radio101;
        private System.Windows.Forms.RadioButton radio103;
        private System.Windows.Forms.RadioButton radio102;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}

