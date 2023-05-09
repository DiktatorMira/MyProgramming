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

namespace Minesweeper {
    public partial class Minesweeper : Form {
        int FormWidth, FormHeight;
        int min = 0, sec = 0;
        public string language = "russian", difficult = "middle", size = "10x10";
        public Minesweeper() {
            InitializeComponent();
            Database.InitAudio();
            Database.LoadFromFile(this);
            ChangeLanguage();
            ChangeDifficult();
            ChangeField();
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
        private void SetForm() {
            WindowState = FormWindowState.Maximized;
            smile.FlatAppearance.BorderSize = 0;
            smile.FlatStyle = FlatStyle.Flat;
            smile.BackgroundImage = Image.FromFile("textures/button.png");
            toolMenu1.ForeColor = Color.White;
            toolMenu1.BackColor = Color.Chocolate;
        }
        private void toolMenu1_Click(object sender, EventArgs e) {
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            foreach(var button in MainController.buttons) button.IsActive = true;
            timer1.Start();
            menu22.Enabled = false;
            menu23.Enabled = false;
            toolMenu1.ForeColor = Color.Black;
            toolMenu1.BackColor = Color.White;
            smile.BackgroundImage = Image.FromFile("textures/smile.png");
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
        private async void musicCheck_CheckedChanged(object sender, EventArgs e) {
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/check.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            await Task.Run(() => {
                if (musicCheck.Checked) Database.music.Play();
                else Database.music.Stop();
            });
        }
        private void menu_clicks(object sender, EventArgs e) {
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
        }
        private void LanguageClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            if (menu == menu21_1) language = "russian";
            else if (menu == menu21_2) language = "ukrainian";
            else if (menu == menu21_3) language = "english";
            ChangeLanguage();
        }
        private void DifficultyClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            if (menu == menu22_1) difficult = "easy";
            else if (menu == menu22_2) difficult = "middle";
            else if (menu == menu22_3) difficult = "difficult";
            else if (menu == menu22_4) difficult = "hard";
            ChangeDifficult();
        }
        private void FieldClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            if (menu == menu23_1) size = "5x5";
            else if (menu == menu23_2) size = "10x10";
            else if (menu == menu23_3) size = "14x14";
            else if (menu == menu23_4) size = "30x14";
            ChangeField();
            Application.Restart();
        }
        private void toolMenu4_Click(object sender, EventArgs e) {
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            DialogResult res;
            if (language == "russian") {
                res = MessageBox.Show("Вы уверены что хотите выйти?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.btnClick.Stop();
                Database.btnClickRead = new AudioFileReader("sounds/click.wav");
                Database.btnClick.Init(Database.btnClickRead);
                Database.btnClick.Play();
                if (res == DialogResult.Yes) Close();
            }
            else if(language == "ukrainian") {
                res = MessageBox.Show("Ви впевнені, що хочете вийти?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.btnClick.Stop();
                Database.btnClickRead = new AudioFileReader("sounds/click.wav");
                Database.btnClick.Init(Database.btnClickRead);
                Database.btnClick.Play();
                if (res == DialogResult.Yes) Close();
            }
            else if(language == "english") {
                res = MessageBox.Show("Are you sure you want to leave?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.btnClick.Stop();
                Database.btnClickRead = new AudioFileReader("sounds/click.wav");
                Database.btnClick.Init(Database.btnClickRead);
                Database.btnClick.Play();
                if (res == DialogResult.Yes) Close();
            }
        }
        private void toolMenu3_Click(object sender, EventArgs e) {
            Database.btnClick.Stop();
            Database.btnClickRead = new AudioFileReader("sounds/click.wav");
            Database.btnClick.Init(Database.btnClickRead);
            Database.btnClick.Play();
            if(language == "russian") {
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
                Database.btnClick.Stop();
                Database.btnClickRead = new AudioFileReader("sounds/click.wav");
                Database.btnClick.Init(Database.btnClickRead);
                Database.btnClick.Play();
                if (res == DialogResult.Yes) Application.Restart();
            }
            else if(language == "english") {
                DialogResult res = MessageBox.Show("Are you sure you want to start over?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Database.btnClick.Stop();
                Database.btnClickRead = new AudioFileReader("sounds/click.wav");
                Database.btnClick.Init(Database.btnClickRead);
                Database.btnClick.Play();
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
                    FormWidth = Size.Width * 30 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 19 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "10x10":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = false;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = true;
                    FormWidth = Size.Width * 71 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 42 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "14x14":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = false;
                    menu23_4.Enabled = true;
                    FormWidth = Size.Width * 106 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 59 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
                case "30x14":
                    menu23_1.Enabled = true;
                    menu23_2.Enabled = true;
                    menu23_3.Enabled = true;
                    menu23_4.Enabled = false;
                    FormWidth = Size.Width * 243 / 100;
                    timerBox.Location = new Point(FormWidth, 47);
                    FormWidth = Size.Width * 128 / 100;
                    smile.Location = new Point(FormWidth, 30);
                    break;
            }
        }
    }
}
