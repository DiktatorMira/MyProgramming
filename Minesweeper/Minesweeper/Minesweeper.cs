using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper.Controllers;
using NAudio.Wave;

namespace Minesweeper {
    public partial class Minesweeper : Form {
        int min = 3, sec = 0;
        string language = "russian";
        public Minesweeper() {
            InitializeComponent();
            MainController.Init(this);
        }
        private void toolMenu1_Click(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/click.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
            foreach (var button in MainController.buttons) button.Enabled = true;
            timer1.Start();
            MainController.play.Play();
        }
        private void timer1_Tick(object sender, EventArgs e) {
            sec--;
            if (min == 0 && sec == 0) {
                timerBox.Text = string.Format("{0:D2}:{1:D2}", min, sec);
                timer1.Stop();
                MessageBox.Show("Вы приграли!");
            }
            else if (sec <= 0) {
                min--;
                sec = 59;
            }
            timerBox.Text = string.Format("{0:D2}:{1:D2}", min, sec);
        }
        private void musicCheck_CheckedChanged(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/check.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
            if (musicCheck.Checked) MainController.music.Play();
            else MainController.music.Stop();
        }
        private void menu21_2_Click(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/click.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
            menu21_1.Enabled = true;
            menu21_3.Enabled = true;
            menu21_2.Enabled = false;
            language = "ukrainian";
            musicCheck.Text = "Музика";
            Text = "Сапер v2.0";
            toolMenu1.Text = "Почати гру";
            toolMenu2.Text = "Налаштування";
            menu21.Text = "Мова";
            menu22.Text = "Стиль програми";
            menu22_1.Text = "Класичний";
            menu22_2.Text = "Сучасний";
            toolMenu3.Text = "Про додадок";
            toolMenu4.Text = "Вийти";
        }
        private void menu21_1_Click(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/click.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
            menu21_2.Enabled = true;
            menu21_3.Enabled = true;
            menu21_1.Enabled = false;
            language = "russian";
            musicCheck.Text = "Музыка";
            Text = "Сапёр v2.0";
            toolMenu1.Text = "Начать игру";
            toolMenu2.Text = "Настройки";
            menu21.Text = "Язык";
            menu22.Text = "Стиль приложения";
            menu22_1.Text = "Класический";
            menu22_2.Text = "Современный";
            toolMenu3.Text = "О приложении";
            toolMenu4.Text = "Выйти";
        }
        private void menu21_3_Click(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/click.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
            menu21_1.Enabled = true;
            menu21_2.Enabled = true;
            menu21_3.Enabled = false;
            language = "english";
            musicCheck.Text = "Music";
            Text = "Minesweeper v2.0";
            toolMenu1.Text = "Start game";
            toolMenu2.Text = "Settings";
            menu21.Text = "Language";
            menu22.Text = "App style";
            menu22_1.Text = "Classic";
            menu22_2.Text = "Modern";
            toolMenu3.Text = "About app";
            toolMenu4.Text = "Exit";
        }
        private void toolMenu4_Click(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/click.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
        }
        private void menu_clicks(object sender, EventArgs e) {
            MainController.btnClick.Stop();
            MainController.btnClickRead = new AudioFileReader("sounds/click.wav");
            MainController.btnClick.Init(MainController.btnClickRead);
            MainController.btnClick.Play();
        }
    }
}
