using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper.Controllers;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Minesweeper {
    public partial class Minesweeper : Form {
        int FormWidth;
        int hour = 0, min = 0, sec = 0;
        public Minesweeper() {
            InitializeComponent();
            Database.InitAudio();
            Database.LoadFromFiles(this);
            ChangeLanguage();
            ChangeDifficult();
            ChangeField();
            ChangeColor();
            MainController.Init(this);
            ChangeWallpaper();
            SetForm();
        }
        public bool MusicCheck {
            set { musicCheck.Checked = value; }
            get { return musicCheck.Checked; }
        }
        public string GetTime() {
            if (Database.language == "english") return $"{hour} hours {min} minutes {sec} seconds";
            else if (Database.language == "ukrainian") return $"{hour} годин {min} хвилин {sec} cекунд";
            return $"{hour} часов {min} минут {sec} cекунд";
        }
        public void SetSmile(Image obj) => smile.BackgroundImage = obj;
        private void SetForm() {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            smile.FlatAppearance.BorderSize = 0;
            smile.FlatStyle = FlatStyle.Flat;
            smile.BackgroundImage = Image.FromFile(Database.GetColorPath() + "button.png");
            timerBox.BorderStyle = BorderStyle.FixedSingle;
            musicCheck.BackColor = Color.Transparent;
            if (MainController.height == 5 && MainController.width == 5) {
                Width = (MainController.width * MainController.cell_size) + 235;
                Height = (MainController.height * MainController.cell_size) + 150;
            }
            MinimumSize = new Size(Width, Height);
        }
        private void toolMenu1_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            foreach (var button in MainController.buttons) button.IsActive = true;
            timer1.Start();
            menu22.Enabled = false;
            menu23.Enabled = false;
            menu24_1.Enabled = false;
            menu24_2.Enabled = false;
            menu24_4.Enabled = false;
            menu24_5.Enabled = false;
            toolMenu5.Enabled = false;
            Database.games++;
            if (Database.color == "white") {
                toolMenu1.ForeColor = Color.Black;
                toolMenu1.BackColor = Color.FromArgb(220, 220, 220);
            }
            else if(Database.color == "black") {
                toolMenu1.ForeColor = Color.FromArgb(240, 240, 240);
                toolMenu1.BackColor = Color.FromArgb(33, 33, 33);
            }
            else if (Database.color == "mono") {
                toolMenu1.ForeColor = Color.FromArgb(64, 60, 36);
                toolMenu1.BackColor = Color.FromArgb(194, 193, 167);
            }
            else if (Database.color == "army") {
                toolMenu1.ForeColor = Color.FromArgb(218, 227, 193);
                toolMenu1.BackColor = Color.FromArgb(54, 77, 44);
            }
            smile.BackgroundImage = Image.FromFile(Database.GetColorPath() + "smile.png");
            Database.play.Play();
        }
        private void timer1_Tick(object sender, EventArgs e) {
            sec++;
            if (sec >= 60) {
                min++;
                sec = 0;
                timerBox.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
            }
            if (min >= 60) {
                hour++;
                min = 0;
                timerBox.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
            }
            timerBox.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }
        public void StopTimer() => timer1.Stop();
        private void Minesweeper_FormClosing(object sender, FormClosingEventArgs e) {
            SaveTime();
            Database.SaveToFiles(this);
        }
        private void musicCheck_CheckedChanged(object sender, EventArgs e) {
            Database.ChangeSound("sounds/check.wav");
            if (musicCheck.Checked) Database.music.Play();
            else Database.music.Stop();
        }
        private void MenuClicks(object sender, EventArgs e) => Database.ChangeSound("sounds/click.wav");
        private void LanguageClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu21_1) Database.language = "russian";
            else if (menu == menu21_2) Database.language = "ukrainian";
            else if (menu == menu21_3) Database.language = "english";
            ChangeLanguage();
        }
        private void DifficultyClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu22_1) Database.difficult = "easy";
            else if (menu == menu22_2) Database.difficult = "middle";
            else if (menu == menu22_3) Database.difficult = "difficult";
            else if (menu == menu22_4) Database.difficult = "hard";
            ChangeDifficult();
        }
        private void FieldClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu23_1) Database.size = "5x5";
            else if (menu == menu23_2) Database.size = "10x5";
            else if (menu == menu23_3) Database.size = "10x10";
            else if (menu == menu23_4) Database.size = "14x10";
            else if (menu == menu23_5) Database.size = "14x14";
            else if (menu == menu23_6) Database.size = "30x14";
            ChangeField();
            Application.Restart();
        }
        private void ColorClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu24_1) Database.color = "white";
            else if (menu == menu24_2) Database.color = "black";
            else if (menu == menu24_4) Database.color = "mono";
            else if (menu == menu24_5) Database.color = "army";
            ChangeColor();
        }
        private void WallpaperClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu24_3_1) Database.wallpaper = "no";
            else if (menu == menu24_3_2) Database.wallpaper = "yes";
            ChangeWallpaper();
        }
        private void toolMenu4_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            MyMessBox frm = null;
            if (Database.language == "russian") frm = new MyMessBox("Вы уверены что хотите выйти?", 2);
            else if (Database.language == "ukrainian") frm = new MyMessBox("Ви впевнені, що хочете вийти?", 2);
            else if (Database.language == "english") frm = new MyMessBox("Are you sure you want to leave?", 2);
            frm.MainForm = this;
            DialogResult res = frm.ShowDialog();
        }
        private void toolMenu3_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            MyMessBox frm = null;
            if (Database.language == "russian") frm = new MyMessBox("Вы уверены что хотите начать заново?", 1);
            else if (Database.language == "ukrainian") frm = new MyMessBox("Ви впевнені, що хочете почати заново?", 1);
            else if (Database.language == "english") frm = new MyMessBox("Are you sure you want to start over?", 1);
            frm.MainForm = this;
            DialogResult res = frm.ShowDialog();
        }
        private void toolMenu5_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            Statistics frm = new Statistics();
            frm.MainForm = this;
            DialogResult res = frm.ShowDialog();
        }
        private async void SaveTime() {
            await Task.Run(() => {
                Database.fsec += sec;
                if (Database.fsec >= 60) {
                    Database.fsec -= 60;
                    Database.fmin++;
                }
                Database.fmin += min;
                if (Database.fmin >= 60) {
                    Database.fmin -= 60;
                    Database.fhour++;
                }
                Database.fhour += hour;
            });
        }
        private void ChangeLanguage() {
            switch (Database.language) {
                case "russian":
                    menu21_2.Enabled = true;
                    menu21_3.Enabled = true;
                    menu21_1.Enabled = false;
                    musicCheck.Text = "Музыка";
                    Text = "Сапёр v2.3.0";
                    toolMenu1.Text = "Начать игру";
                    toolMenu2.Text = "Настройки";
                    menu21.Text = "Язык";
                    menu22.Text = "Сложность";
                    menu22.ToolTipText = "Настраивает % минных клеток";
                    menu22_1.Text = "Лёгкая";
                    menu22_1.ToolTipText = "10% минных клеток";
                    menu22_2.Text = "Средняя";
                    menu22_2.ToolTipText = "17,5% минных клеток";
                    menu22_3.Text = "Сложная";
                    menu22_3.ToolTipText = "25% минных клеток";
                    menu22_4.Text = "Экстремальная";
                    menu22_4.ToolTipText = "30% минных клеток";
                    menu23.Text = "Размер поля";
                    menu24.Text = "Тема оформления";
                    menu24_1.Text = "Светлая";
                    menu24_2.Text = "Тёмная";
                    menu24_3.Text = "Обои";
                    menu24_3_1.Text = "Выкл";
                    menu24_3_2.Text = "Вкл";
                    menu24_4.Text = "Монохромная";
                    menu24_5.Text = "Военная";
                    toolMenu3.Text = "Начать заново";
                    toolMenu4.Text = "Выйти";
                    toolMenu5.Text = "Статистика";
                    break;
                case "ukrainian":
                    menu21_1.Enabled = true;
                    menu21_3.Enabled = true;
                    menu21_2.Enabled = false;
                    musicCheck.Text = "Музика";
                    Text = "Сапер v2.3.0";
                    toolMenu1.Text = "Почати гру";
                    toolMenu2.Text = "Налаштування";
                    menu21.Text = "Мова";
                    menu22.Text = "Складність";
                    menu22.ToolTipText = "Налаштовує % мінних клітин";
                    menu22_1.Text = "Легка";
                    menu22_1.ToolTipText = "10% мінних клітин";
                    menu22_2.Text = "Середня";
                    menu22_2.ToolTipText = "17,5% мінних клітин";
                    menu22_3.Text = "Складна";
                    menu22_3.ToolTipText = "25% мінних клітин";
                    menu22_4.Text = "Естремальна";
                    menu22_4.ToolTipText = "30% мінних клітин";
                    menu23.Text = "Розмір поля";
                    menu24.Text = "Тема оформлення";
                    menu24_1.Text = "Світла";
                    menu24_2.Text = "Темна";
                    menu24_3.Text = "Шпалери";
                    menu24_3_1.Text = "Вимк";
                    menu24_3_2.Text = "Увімк";
                    menu24_4.Text = "Монохромна";
                    menu24_5.Text = "Військова";
                    toolMenu3.Text = "Почати заново";
                    toolMenu4.Text = "Вийти";
                    toolMenu5.Text = "Статистика";
                    break;
                case "english":
                    menu21_1.Enabled = true;
                    menu21_2.Enabled = true;
                    menu21_3.Enabled = false;
                    musicCheck.Text = "Music";
                    Text = "Minesweeper v2.3.0";
                    toolMenu1.Text = "Start game";
                    toolMenu2.Text = "Settings";
                    menu21.Text = "Language";
                    menu22.Text = "Difficulty";
                    menu22.ToolTipText = "Customizes % mine cells";
                    menu22_1.Text = "Easy";
                    menu22_1.ToolTipText = "10% mine cells";
                    menu22_2.Text = "Middle";
                    menu22_2.ToolTipText = "17,5% mine cells";
                    menu22_3.Text = "Difficult";
                    menu22_3.ToolTipText = "25% mine cells";
                    menu22_4.Text = "Hard";
                    menu22_4.ToolTipText = "30% mine cells";
                    menu23.Text = "Field size";
                    menu24.Text = "Theme";
                    menu24_1.Text = "Light";
                    menu24_2.Text = "Dark";
                    menu24_3.Text = "Wallpaper";
                    menu24_3_1.Text = "Off";
                    menu24_3_2.Text = "On";
                    menu24_4.Text = "Monochrome";
                    menu24_5.Text = "Military";
                    toolMenu3.Text = "Start over";
                    toolMenu4.Text = "Exit";
                    toolMenu5.Text = "Statistics";
                    break;
            }
        }
        private async void ChangeDifficult() {
            await Task.Run(() => {
                switch (Database.difficult) {
                    case "easy":
                        menu22_1.Enabled = false;
                        menu22_2.Enabled = true;
                        menu22_3.Enabled = true;
                        menu22_4.Enabled = true;
                        MainController.bomb_persent = 10;
                        break;
                    case "middle":
                        menu22_1.Enabled = true;
                        menu22_2.Enabled = false;
                        menu22_3.Enabled = true;
                        menu22_4.Enabled = true;
                        MainController.bomb_persent = 17.5;
                        break;
                    case "difficult":
                        menu22_1.Enabled = true;
                        menu22_2.Enabled = true;
                        menu22_3.Enabled = false;
                        menu22_4.Enabled = true;
                        MainController.bomb_persent = 25;
                        break;
                    case "hard":
                        menu22_1.Enabled = true;
                        menu22_2.Enabled = true;
                        menu22_3.Enabled = true;
                        menu22_4.Enabled = false;
                        MainController.bomb_persent = 30;
                        break;
                }
            });
        }
        public void ChangeField() {
            switch (Database.size) {
                case "5x5":
                    menu23_1.Enabled = false;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 42 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 32 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    FormWidth = Size.Width * 17 / 100;
                    musicCheck.Location = new Point(FormWidth, 60);
                    break;
                case "10x5":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = false;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 63 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 37 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "10x10":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = false;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 63 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 37 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "14x10":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = false;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 93 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 52 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "14x14":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = false;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 93 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 52 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "30x14":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = false;
                    FormWidth = Size.Width * 214 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 113 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
            }
        }
        public void ChangeColor() {
            switch (Database.color) {
                case "white":
                    menu24_1.Enabled = false;
                    menu24_2.Enabled = true;
                    menu24_4.Enabled = true;
                    menu24_5.Enabled = true;
                    menuStrip1.BackColor = Color.FromArgb(220, 220, 220);
                    menuStrip1.ForeColor = Color.Black;
                    toolMenu1.BackColor = Color.Chocolate;
                    toolMenu1.ForeColor = Color.FromArgb(240, 240, 240);
                    break;
                case "black":
                    menu24_1.Enabled = true;
                    menu24_2.Enabled = false;
                    menu24_4.Enabled = true;
                    menu24_5.Enabled = true;
                    menuStrip1.BackColor = Color.FromArgb(33, 33, 33);
                    menuStrip1.ForeColor = Color.FromArgb(240, 240, 240);
                    toolMenu1.BackColor = Color.FromArgb(122, 106, 78);
                    toolMenu1.ForeColor = Color.Black;
                    break;
                case "mono":
                    menu24_1.Enabled = true;
                    menu24_2.Enabled = true;
                    menu24_4.Enabled = false;
                    menu24_5.Enabled = true;
                    menuStrip1.BackColor = Color.FromArgb(194, 193, 167);
                    menuStrip1.ForeColor = Color.Black;
                    toolMenu1.BackColor = Color.FromArgb(156, 145, 82);
                    toolMenu1.ForeColor = Color.FromArgb(240, 240, 240);
                    break;
                case "army":
                    menu24_1.Enabled = true;
                    menu24_2.Enabled = true;
                    menu24_4.Enabled = true;
                    menu24_5.Enabled = false;
                    menuStrip1.BackColor = Color.FromArgb(54, 77, 44);
                    menuStrip1.ForeColor = Color.FromArgb(240, 240, 240);
                    toolMenu1.BackColor = Color.FromArgb(156, 145, 82);
                    toolMenu1.ForeColor = Color.FromArgb(240, 240, 240);
                    break;
            }
            smile.BackgroundImage = Image.FromFile(Database.GetColorPath() + "button.png");
            if (Database.wallpaper == "yes") BackgroundImage = Image.FromFile("textures/themes/" + Database.GetWallpaperPath());
            BackColor = Database.GetColor().Item1;
            ForeColor = Database.GetColor().Item2;
            timerBox.BackColor = Database.GetColor().Item1;
            timerBox.ForeColor = Database.GetColor().Item2;
            toolMenu2.ForeColor = Database.GetColor().Item2;
            menu21.BackColor = Database.GetColor().Item1;
            menu21.ForeColor = Database.GetColor().Item2;
            menu21_1.BackColor = Database.GetColor().Item1;
            menu21_1.ForeColor = Database.GetColor().Item2;
            menu21_2.BackColor = Database.GetColor().Item1;
            menu21_2.ForeColor = Database.GetColor().Item2;
            menu21_3.BackColor = Database.GetColor().Item1;
            menu21_3.ForeColor = Database.GetColor().Item2;
            menu22.BackColor = Database.GetColor().Item1;
            menu22.ForeColor = Database.GetColor().Item2;
            menu22_1.BackColor = Database.GetColor().Item1;
            menu22_1.ForeColor = Database.GetColor().Item2;
            menu22_2.BackColor = Database.GetColor().Item1;
            menu22_2.ForeColor = Database.GetColor().Item2;
            menu22_3.BackColor = Database.GetColor().Item1;
            menu22_3.ForeColor = Database.GetColor().Item2;
            menu22_4.BackColor = Database.GetColor().Item1;
            menu22_4.ForeColor = Database.GetColor().Item2;
            menu23.BackColor = Database.GetColor().Item1;
            menu23.ForeColor = Database.GetColor().Item2;
            menu23_1.BackColor = Database.GetColor().Item1;
            menu23_1.ForeColor = Database.GetColor().Item2;
            menu23_2.BackColor = Database.GetColor().Item1;
            menu23_2.ForeColor = Database.GetColor().Item2;
            menu23_3.BackColor = Database.GetColor().Item1;
            menu23_3.ForeColor = Database.GetColor().Item2;
            menu23_4.BackColor = Database.GetColor().Item1;
            menu23_4.ForeColor = Database.GetColor().Item2;
            menu23_5.BackColor = Database.GetColor().Item1;
            menu23_5.ForeColor = Database.GetColor().Item2;
            menu23_6.BackColor = Database.GetColor().Item1;
            menu23_6.ForeColor = Database.GetColor().Item2;
            menu24.BackColor = Database.GetColor().Item1;
            menu24.ForeColor = Database.GetColor().Item2;
            menu24_1.BackColor = Database.GetColor().Item1;
            menu24_1.ForeColor = Database.GetColor().Item2;
            menu24_2.BackColor = Database.GetColor().Item1;
            menu24_2.ForeColor = Database.GetColor().Item2;
            menu24_3.BackColor = Database.GetColor().Item1;
            menu24_3.ForeColor = Database.GetColor().Item2;
            menu24_3_1.BackColor = Database.GetColor().Item1;
            menu24_3_1.ForeColor = Database.GetColor().Item2;
            menu24_3_2.BackColor = Database.GetColor().Item1;
            menu24_3_2.ForeColor = Database.GetColor().Item2;
            menu24_4.BackColor = Database.GetColor().Item1;
            menu24_4.ForeColor = Database.GetColor().Item2;
            menu24_5.BackColor = Database.GetColor().Item1;
            menu24_5.ForeColor = Database.GetColor().Item2;
            toolMenu3.ForeColor = Database.GetColor().Item2;
            toolMenu4.ForeColor = Database.GetColor().Item2;
            toolMenu5.ForeColor = Database.GetColor().Item2;
            MainController.ChangeButtonsColor();
        }
        public async void ChangeWallpaper() {
            await Task.Run(() => {
                switch (Database.wallpaper) {
                    case "no":
                        menu24_3_1.Enabled = false;
                        menu24_3_2.Enabled = true;
                        BackgroundImage = null;
                        break;
                    case "yes":
                        menu24_3_1.Enabled = true;
                        menu24_3_2.Enabled = false;
                        BackgroundImage = Image.FromFile("textures/themes/" + Database.GetWallpaperPath());
                        break;
                }
            });
        }
    }
}
