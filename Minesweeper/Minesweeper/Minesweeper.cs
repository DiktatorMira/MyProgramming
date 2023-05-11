using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper.Controllers;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minesweeper {
    public partial class Minesweeper : Form {
        int FormWidth, FormHeight;
        int min = 0, sec = 0;
        public string language = "russian", difficult = "middle", size = "10x10", color = "white", wallpaper = "no";
        public Minesweeper() {
            InitializeComponent();
            Database.InitAudio();
            Database.LoadFromFile(this);
            ChangeLanguage();
            ChangeDifficult();
            ChangeField();
            ChangeColor();
            ChangeWallpaper();
            MainController.Init(this);
            SetForm();
        }
        public bool MusicCheck {
            set { musicCheck.Checked = value; }
            get { return musicCheck.Checked; }
        }
        public string GetTime() {
            if (language == "english") return $"{min} minutes {sec} seconds";
            else if (language == "ukrainian") return $"{min} хвилин {sec} cекунд";
            return $"{min} минут {sec} cекунд";
        }
        public void SetSmile(Image obj) => smile.BackgroundImage = obj;
        public void SetTool(string value) => toolMenu1.Text = value;
        private void SetForm() {
            WindowState = FormWindowState.Maximized;
            smile.FlatAppearance.BorderSize = 0;
            smile.FlatStyle = FlatStyle.Flat;
            smile.BackgroundImage = Image.FromFile("textures/light/button.png");
            timerBox.BorderStyle = BorderStyle.FixedSingle;
            musicCheck.BackColor = Color.Transparent;
        }
        private void toolMenu1_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            foreach (var button in MainController.buttons) button.IsActive = true;
            timer1.Start();
            menu22.Enabled = false;
            menu23.Enabled = false;
            menu24.Enabled = false;
            if(color == "white") {
                toolMenu1.ForeColor = Color.Black;
                toolMenu1.BackColor = Color.FromArgb(240, 240, 240);
            }
            else {
                toolMenu1.ForeColor = Color.FromArgb(240, 240, 240);
                toolMenu1.BackColor = Color.FromArgb(40, 40, 40);
            }
            smile.BackgroundImage = Image.FromFile("textures/light/smile.png");
            Database.play.Play();
        }
        private void timer1_Tick(object sender, EventArgs e) {
            sec++;
            if (sec >= 60) {
                min++;
                sec = 0;
                timerBox.Text = string.Format("{0:D2}:{1:D2}", min, sec);
            }
            timerBox.Text = string.Format("{0:D2}:{1:D2}", min, sec);
        }
        public void StopTimer() => timer1.Stop();
        private void Minesweeper_FormClosing(object sender, FormClosingEventArgs e) => Database.SaveToFile(this);
        private void toolMenu2_MouseEnter(object sender, EventArgs e) {
            if (color == "black") toolMenu2.ForeColor = Color.Black;
        }
        private void toolMenu2_MouseLeave(object sender, EventArgs e) {
            if (color == "black") toolMenu2.ForeColor = Color.FromArgb(240,240,240);
        }
        private async void musicCheck_CheckedChanged(object sender, EventArgs e) {
            Database.ChangeSound("sounds/check.wav");
            await Task.Run(() => {
                if (musicCheck.Checked) Database.music.Play();
                else Database.music.Stop();
            });
        }
        private void MenuClicks(object sender, EventArgs e) => Database.ChangeSound("sounds/click.wav");
        private void LanguageClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu21_1) language = "russian";
            else if (menu == menu21_2) language = "ukrainian";
            else if (menu == menu21_3) language = "english";
            ChangeLanguage();
        }
        private void DifficultyClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu22_1) difficult = "easy";
            else if (menu == menu22_2) difficult = "middle";
            else if (menu == menu22_3) difficult = "difficult";
            else if (menu == menu22_4) difficult = "hard";
            ChangeDifficult();
        }
        private void FieldClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu23_1) size = "5x5";
            else if (menu == menu23_2) size = "10x5";
            else if (menu == menu23_3) size = "10x10";
            else if (menu == menu23_4) size = "14x10";
            else if (menu == menu23_5) size = "14x14";
            else if (menu == menu23_6) size = "30x14";
            ChangeField();
            Application.Restart();
        }
        private void ColorClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu24_1) color = "white";
            else if (menu == menu24_2) color = "black";
            ChangeColor();
        }
        private void WallpaperClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.ChangeSound("sounds/click.wav");
            if (menu == menu25_1) wallpaper = "no";
            else if (menu == menu25_2) wallpaper = "yes";
            ChangeWallpaper();
        }
        private void toolMenu4_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            DialogResult res;
            if (language == "russian") {
                res = MessageBox.Show("Вы уверены что хотите выйти?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Close();
            }
            else if(language == "ukrainian") {
                res = MessageBox.Show("Ви впевнені, що хочете вийти?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Close();
            }
            else if(language == "english") {
                res = MessageBox.Show("Are you sure you want to leave?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Close();
            }
        }
        private void toolMenu3_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            if (language == "russian") {
                DialogResult res = MessageBox.Show("Вы уверены что хотите начать заново?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.btnClick.Stop();
                Database.btnClickRead = new AudioFileReader("sounds/click.wav");
                Database.btnClick.Init(Database.btnClickRead);
                Database.btnClick.Play();
                if (res == DialogResult.Yes) Application.Restart();
            }
            else if(language == "ukrainian") {
                DialogResult res = MessageBox.Show("Ви впевнені, що хочете почати заново?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
            }
            else if(language == "english") {
                DialogResult res = MessageBox.Show("Are you sure you want to start over?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
            }
        }
        private async void ChangeLanguage() {
            await Task.Run(() => {
                switch (language) {
                    case "russian":
                        menu21_2.Enabled = true;
                        menu21_3.Enabled = true;
                        menu21_1.Enabled = false;
                        musicCheck.Text = "Музыка";
                        Text = "Сапёр v2.1.1";
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
                        menu25.Text = "Обои";
                        menu25_1.Text = "Выкл";
                        menu25_2.Text = "Вкл";
                        toolMenu3.Text = "Начать заново";
                        toolMenu4.Text = "Выйти";
                        break;
                    case "ukrainian":
                        menu21_1.Enabled = true;
                        menu21_3.Enabled = true;
                        menu21_2.Enabled = false;
                        musicCheck.Text = "Музика";
                        Text = "Сапер v2.1.1";
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
                        menu25.Text = "Шпалери";
                        menu25_1.Text = "Вимк";
                        menu25_2.Text = "Увімк";
                        toolMenu3.Text = "Почати заново";
                        toolMenu4.Text = "Вийти";
                        break;
                    case "english":
                        menu21_1.Enabled = true;
                        menu21_2.Enabled = true;
                        menu21_3.Enabled = false;
                        musicCheck.Text = "Music";
                        Text = "Minesweeper v2.1.1";
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
                        menu25.Text = "Wallpaper";
                        menu25_1.Text = "Off";
                        menu25_2.Text = "On";
                        toolMenu3.Text = "Start over";
                        toolMenu4.Text = "Exit";
                        break;
                }
            });
        }
        private async void ChangeDifficult() {
            await Task.Run(() => {
                switch (difficult) {
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
            switch (size) {
                case "5x5":
                    menu23_1.Enabled = false;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 30 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 19 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "10x5":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = false;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 71 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 42 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "10x10":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = false;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 71 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 42 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "14x10":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = false;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 106 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 59 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "14x14":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = false;
                    menu23_6.Enabled = true;
                    FormWidth = Size.Width * 106 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 59 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "30x14":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    menu23_5.Enabled = true;
                    menu23_6.Enabled = false;
                    FormWidth = Size.Width * 243 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 128 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
            }
        }
        public async void ChangeColor() {
            await Task.Run(() => {
                switch (color) {
                    case "white":
                        menu24_1.Enabled = false;
                        menu24_2.Enabled = true;
                        if (wallpaper == "yes") BackgroundImage = Image.FromFile("textures/themes/classicwhite.png");
                        BackColor = Color.FromArgb(240, 240, 240);
                        ForeColor = Color.Black;
                        timerBox.BackColor = Color.FromArgb(240, 240, 240);
                        timerBox.ForeColor = Color.Black;
                        menuStrip1.BackColor = Color.FromArgb(240, 240, 240);
                        menuStrip1.ForeColor = Color.Black;
                        toolMenu1.BackColor = Color.Chocolate;
                        toolMenu1.ForeColor = Color.FromArgb(240, 240, 240);
                        toolMenu2.ForeColor = Color.Black;
                        menu21.BackColor = Color.FromArgb(240, 240, 240);
                        menu21.ForeColor = Color.Black;
                        menu21_1.BackColor = Color.FromArgb(240, 240, 240);
                        menu21_1.ForeColor = Color.Black;
                        menu21_2.BackColor = Color.FromArgb(240, 240, 240);
                        menu21_2.ForeColor = Color.Black;
                        menu21_3.BackColor = Color.FromArgb(240, 240, 240);
                        menu21_3.ForeColor = Color.Black;
                        menu22.BackColor = Color.FromArgb(240, 240, 240);
                        menu22.ForeColor = Color.Black;
                        menu22_1.BackColor = Color.FromArgb(240, 240, 240);
                        menu22_1.ForeColor = Color.Black;
                        menu22_2.BackColor = Color.FromArgb(240, 240, 240);
                        menu22_2.ForeColor = Color.Black;
                        menu22_3.BackColor = Color.FromArgb(240, 240, 240);
                        menu22_3.ForeColor = Color.Black;
                        menu22_4.BackColor = Color.FromArgb(240, 240, 240);
                        menu22_4.ForeColor = Color.Black;
                        menu23.BackColor = Color.FromArgb(240, 240, 240);
                        menu23.ForeColor = Color.Black;
                        menu23_1.BackColor = Color.FromArgb(240, 240, 240);
                        menu23_1.ForeColor = Color.Black;
                        menu23_2.BackColor = Color.FromArgb(240, 240, 240);
                        menu23_2.ForeColor = Color.Black;
                        menu23_3.BackColor = Color.FromArgb(240, 240, 240);
                        menu23_3.ForeColor = Color.Black;
                        menu23_4.BackColor = Color.FromArgb(240, 240, 240);
                        menu23_4.ForeColor = Color.Black;
                        menu23_5.BackColor = Color.FromArgb(240, 240, 240);
                        menu23_5.ForeColor = Color.Black;
                        menu23_6.BackColor = Color.FromArgb(240, 240, 240);
                        menu23_6.ForeColor = Color.Black;
                        menu24.BackColor = Color.FromArgb(240, 240, 240);
                        menu24.ForeColor = Color.Black;
                        menu24_1.BackColor = Color.FromArgb(240, 240, 240);
                        menu24_1.ForeColor = Color.Black;
                        menu24_2.BackColor = Color.FromArgb(240, 240, 240);
                        menu24_2.ForeColor = Color.Black;
                        menu25.BackColor = Color.FromArgb(240, 240, 240);
                        menu25.ForeColor = Color.Black;
                        menu25_1.BackColor = Color.FromArgb(240, 240, 240);
                        menu25_1.ForeColor = Color.Black;
                        menu25_2.BackColor = Color.FromArgb(240, 240, 240);
                        menu25_2.ForeColor = Color.Black;
                        break;
                    case "black":
                        menu24_1.Enabled = true;
                        menu24_2.Enabled = false;
                        if (wallpaper == "yes") BackgroundImage = Image.FromFile("textures/themes/classicblack.png");
                        BackColor = Color.FromArgb(40, 40, 40);
                        ForeColor = Color.FromArgb(240, 240, 240);
                        BackColor = Color.FromArgb(40, 40, 40);
                        timerBox.BackColor = Color.FromArgb(40, 40, 40);
                        timerBox.ForeColor = Color.FromArgb(240, 240, 240);
                        menuStrip1.BackColor = Color.FromArgb(40, 40, 40);
                        menuStrip1.ForeColor = Color.FromArgb(240, 240, 240);
                        toolMenu1.BackColor = Color.FromArgb(122, 106, 78);
                        toolMenu1.ForeColor = Color.Black;
                        toolMenu2.ForeColor = Color.FromArgb(240, 240, 240);
                        menu21.BackColor = Color.FromArgb(40, 40, 40);
                        menu21.ForeColor = Color.FromArgb(240, 240, 240);
                        menu21_1.BackColor = Color.FromArgb(40, 40, 40);
                        menu21_1.ForeColor = Color.FromArgb(240, 240, 240);
                        menu21_2.BackColor = Color.FromArgb(40, 40, 40);
                        menu21_2.ForeColor = Color.FromArgb(240, 240, 240);
                        menu21_3.BackColor = Color.FromArgb(40, 40, 40);
                        menu21_3.ForeColor = Color.FromArgb(240, 240, 240);
                        menu22.BackColor = Color.FromArgb(40, 40, 40);
                        menu22.ForeColor = Color.FromArgb(240, 240, 240);
                        menu22_1.BackColor = Color.FromArgb(40, 40, 40);
                        menu22_1.ForeColor = Color.FromArgb(240, 240, 240);
                        menu22_2.BackColor = Color.FromArgb(40, 40, 40);
                        menu22_2.ForeColor = Color.FromArgb(240, 240, 240);
                        menu22_3.BackColor = Color.FromArgb(40, 40, 40);
                        menu22_3.ForeColor = Color.FromArgb(240, 240, 240);
                        menu22_4.BackColor = Color.FromArgb(40, 40, 40);
                        menu22_4.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23.BackColor = Color.FromArgb(40, 40, 40);
                        menu23.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23_1.BackColor = Color.FromArgb(40, 40, 40);
                        menu23_1.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23_2.BackColor = Color.FromArgb(40, 40, 40);
                        menu23_2.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23_3.BackColor = Color.FromArgb(40, 40, 40);
                        menu23_3.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23_4.BackColor = Color.FromArgb(40, 40, 40);
                        menu23_4.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23_5.BackColor = Color.FromArgb(40, 40, 40);
                        menu23_5.ForeColor = Color.FromArgb(240, 240, 240);
                        menu23_6.BackColor = Color.FromArgb(40, 40, 40);
                        menu23_6.ForeColor = Color.FromArgb(240, 240, 240);
                        menu24.BackColor = Color.FromArgb(40, 40, 40);
                        menu24.ForeColor = Color.FromArgb(240, 240, 240);
                        menu24_1.BackColor = Color.FromArgb(40, 40, 40);
                        menu24_1.ForeColor = Color.FromArgb(240, 240, 240);
                        menu24_2.BackColor = Color.FromArgb(40, 40, 40);
                        menu24_2.ForeColor = Color.FromArgb(240, 240, 240);
                        menu25.BackColor = Color.FromArgb(40, 40, 40);
                        menu25.ForeColor = Color.FromArgb(240, 240, 240);
                        menu25_1.BackColor = Color.FromArgb(40, 40, 40);
                        menu25_1.ForeColor = Color.FromArgb(240, 240, 240);
                        menu25_2.BackColor = Color.FromArgb(40, 40, 40);
                        menu25_2.ForeColor = Color.FromArgb(240, 240, 240);
                        break;
                }
            });
        }
        public async void ChangeWallpaper() {
            await Task.Run(() => {
                switch (wallpaper) {
                    case "no":
                        menu25_1.Enabled = false;
                        menu25_2.Enabled = true;
                        BackgroundImage = null;
                        break;
                    case "yes":
                        menu25_1.Enabled = true;
                        menu25_2.Enabled = false;
                        if (color == "white") BackgroundImage = Image.FromFile("textures/themes/classicwhite.png");
                        else BackgroundImage = Image.FromFile("textures/themes/classicblack.png");
                        break;
                }
            });
        }
    }
}
