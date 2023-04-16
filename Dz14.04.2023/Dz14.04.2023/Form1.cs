using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Dz14._04._2023 {
    public partial class Form1 : Form {
        AudioFileReader playerReader = new AudioFileReader("sounds/begin.wav");
        AudioFileReader hintsReader = new AudioFileReader("sounds/hint.wav");
        AudioFileReader musicReader = new AudioFileReader("sounds/music.wav");
        WaveOut player = new WaveOut();
        WaveOut music = new WaveOut();
        WaveOut hints = new WaveOut();
        Image img1 = Image.FromFile("images/4.jpg");
        Image img2 = Image.FromFile("images/5.jpg");
        Image img3 = Image.FromFile("images/6.jpg");
        int sec, ques = 1;
        bool h1 = true, h2 = true, h3 = true;
        public Form1() {
            InitializeComponent();
            label5.ForeColor = Color.Aquamarine;
            label10.ForeColor = Color.Aquamarine;
            label15.ForeColor = Color.Gold;
            player.Init(playerReader);
            music.Init(musicReader);
            hints.Init(hintsReader);
        }
        private void strip1_Click(object sender, EventArgs e) {
            List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4, start };
            question.Visible = true;
            foreach (Button button in list) button.Visible = true;
            timerBox.Visible = true;
            player.Play();
        }
        private void start_Click(object sender, EventArgs e) {
            sec = 30;
            start.Enabled = false;
            picture1.Visible = false;
            dialog1.Visible = false;
            picture2.Visible = false;
            dialog2.Visible = false;
            group3.Visible = false;
            List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4 };
            foreach (Button button in list) button.Enabled = true;
            hint1.Enabled = true;
            hint2.Enabled = true; 
            hint3.Enabled = true;
            timerBox.Text = "00:30";
            switch (ques) {
                case 1:
                    question.Text = "Как называется место на берегу, где обитают тюлени?";
                    label1.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    break;
                case 2:
                    answer1.BackColor = Color.Black;
                    question.Text = "Как мировая пресса называла премьер-министра Великобритании Маргарет Тэтчер?";
                    answer1.Text = "А) Железная леди";
                    answer2.Text = "Б) Стальная леди";
                    answer3.Text = "В) Оловянный солдатик";
                    answer4.Text = "Г) Крепкий орешек";
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.Black;
                    break;
                case 3:
                    answer1.BackColor = Color.Black;
                    question.Text = "Какой из этих городов южнее остальных?";
                    answer1.Text = "А) Токио";
                    answer2.Text = "Б) Каир";
                    answer3.Text = "В) Мадрид";
                    answer4.Text = "Г) Сан-Франциско";
                    label3.BackColor = Color.White;
                    label3.ForeColor = Color.Black;
                    break;
                case 4:
                    answer2.BackColor = Color.Black;
                    question.Text = "Через какой город мира проходит нулевой меридиан?";
                    answer1.Text = "А) Гронинген";
                    answer2.Text = "Б) Гринсборо";
                    answer3.Text = "В) Глазго";
                    answer4.Text = "Г) Гринвич";
                    label4.BackColor = Color.White;
                    label4.ForeColor = Color.Black;
                    break;
                case 5:
                    answer4.BackColor = Color.Black;
                    question.Text = "Какая птица является символом Новой Зеландии?";
                    answer1.Text = "А) Эму";
                    answer2.Text = "Б) Казуар";
                    answer3.Text = "В) Киви";
                    answer4.Text = "Г) Жако";
                    label5.BackColor = Color.Aquamarine;
                    label5.ForeColor = Color.Black;
                    break;
                case 6:
                    answer3.BackColor = Color.Black;
                    question.Text = "Какого короля англичане прозвали \"Львиное сердце\"?";
                    answer1.Text = "А) Вильгельм I";
                    answer2.Text = "Б) Ричард I";
                    answer3.Text = "В) Генрих I";
                    answer4.Text = "Г) Георг I";
                    label6.BackColor = Color.White;
                    label6.ForeColor = Color.Black;
                    break;
                case 7:
                    answer2.BackColor = Color.Black;
                    question.Text = "Как в народе называются финансовые институты, обещающие вкладчикам золотые горы?";
                    answer1.Text = "А) Пирамиды";
                    answer2.Text = "Б) Гробницы";
                    answer3.Text = "В) Захоронения";
                    answer4.Text = "Г) Сфинксы";
                    label7.BackColor = Color.White;
                    label7.ForeColor = Color.Black;
                    break;
                case 8:
                    answer1.BackColor = Color.Black;
                    question.Text = "В каком году Россия аннексировала Крым?";
                    answer1.Text = "А) 2022";
                    answer2.Text = "Б) 1991";
                    answer3.Text = "В) 2013";
                    answer4.Text = "Г) 2014";
                    label8.BackColor = Color.White;
                    label8.ForeColor = Color.Black;
                    break;
                case 9:
                    answer4.BackColor = Color.Black;
                    question.Text = "В каком городе родился Вольфганг Амадей Моцарт?";
                    answer1.Text = "А) Веймар";
                    answer2.Text = "Б) Вена";
                    answer3.Text = "В) Зальцбург";
                    answer4.Text = "Г) Прага";
                    label9.BackColor = Color.White;
                    label9.ForeColor = Color.Black;
                    break;
                case 10:
                    answer3.BackColor = Color.Black;
                    question.Text = "Слово \"бинарный код\" относиться к какой системе счисления?";
                    answer1.Text = "А) Десятичной";
                    answer2.Text = "Б) Двоичной";
                    answer3.Text = "В) Восьмеричной";
                    answer4.Text = "Г) Шестнадцатеричной";
                    label10.BackColor = Color.Aquamarine;
                    label10.ForeColor = Color.Black;
                    break;
                case 11:
                    answer2.BackColor = Color.Black;
                    question.Text = "Какая страна является мировым лидером по производству кофе?";
                    answer1.Text = "А) Бразилия";
                    answer2.Text = "Б) Мексика";
                    answer3.Text = "В) Аргентина";
                    answer4.Text = "Г) Венесуэла";
                    label11.BackColor = Color.White;
                    label11.ForeColor = Color.Black;
                    break;
                case 12:
                    answer1.BackColor = Color.Black;
                    question.Text = "Какое органическое вещество отвечает за восттановление мышц?";
                    answer1.Text = "А) Жиры";
                    answer2.Text = "Б) Углеводы";
                    answer3.Text = "В) Эстрогены";
                    answer4.Text = "Г) Белки";
                    label12.BackColor = Color.White;
                    label12.ForeColor = Color.Black;
                    break;
                case 13:
                    answer4.BackColor = Color.Black;
                    question.Text = "Участник какого из перечисленных спортивных состязаний экипирован винтовкой?";
                    answer1.Text = "А) Бейсбол";
                    answer2.Text = "Б) Биатлон";
                    answer3.Text = "В) Бадминтон";
                    answer4.Text = "Г) Бобслей";
                    label13.BackColor = Color.White;
                    label13.ForeColor = Color.Black;
                    break;
                case 14:
                    answer2.BackColor = Color.Black;
                    question.Text = "Какое самое солёное море в мире?";
                    answer1.Text = "А) Чёрное";
                    answer2.Text = "Б) Красное";
                    answer3.Text = "В) Мёртвое";
                    answer4.Text = "Г) Каррибское";
                    label14.BackColor = Color.White;
                    label14.ForeColor = Color.Black;
                    break;
                case 15:
                    answer3.BackColor = Color.Black;
                    question.Text = "Какая компания в Италии выпускает наибольшее количество автомобилей?";
                    answer1.Text = "А) Фиат";
                    answer2.Text = "Б) Феррари";
                    answer3.Text = "В) Ламборгини";
                    answer4.Text = "Г) Мерседес";
                    label15.BackColor = Color.Gold;
                    label15.ForeColor = Color.Black;
                    break;
            }
            player.Stop();
            playerReader = new AudioFileReader("sounds/time.wav");
            player.Init(playerReader);
            player.Play();
            timer1.Start();
        }
        private void answer1_Click(object sender, EventArgs e) {
            List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4 };
            List<Label> labels = new List<Label> { label1, label2, label3, label4, label5, label6, label7, label8, label9,
            label10, label11, label12, label13, label14, label15 };
            timer1.Stop();
            hint1.Enabled = false;
            hint2.Enabled = false;
            hint3.Enabled = false;
            player.Stop();
            playerReader = new AudioFileReader("sounds/gong.wav");
            player.Init(playerReader);
            player.Play();
            Thread.Sleep(2500);
            dialog2.Visible = true;
            picture2.Visible = true;
            switch (ques) {
                case 1:
                case 2:
                case 7:
                case 11:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/true.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Правильно!";
                    answer1.BackColor = Color.Green;
                    foreach (Button button in list) button.Enabled = false;
                    for( int i = 0; i < labels.Count; i++) {
                        labels[i].BackColor = Color.Black;
                        if (i == 4 || i == 9) labels[i].ForeColor = Color.Aquamarine;
                        else if (i == 14) labels[i].ForeColor = Color.Gold;
                        else labels[i].ForeColor = Color.White;
                    }
                    break;
                case 3:
                case 4:
                case 5:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer1.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 0$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                    break;
                case 6:
                case 8:
                case 9:
                case 10:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer1.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res2 = MessageBox.Show("Вы проиграли, ваш зароботок: 1000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res2 == DialogResult.OK) Close();
                    break;
                case 12:
                case 13:
                case 14:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer1.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res3 = MessageBox.Show("Вы проиграли, ваш зароботок: 32000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res3 == DialogResult.OK) Close();
                    break;
                case 15:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/end.wav");
                    dialog2.Text = "Это победа!";
                    player.Init(playerReader);
                    player.Play();
                    answer1.BackColor = Color.Green;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res4 = MessageBox.Show("Вы победили, ответивши на все вопроссы, ваш зароботок: 1000000$", "Поздравляем!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res4 == DialogResult.OK) Close();
                    break;
            }
            start.Enabled = true;
            ques++;
        }
        private void answer2_Click(object sender, EventArgs e) {
            List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4 };
            List<Label> labels = new List<Label> { label1, label2, label3, label4, label5, label6, label7, label8, label9,
            label10, label11, label12, label13, label14, label15 };
            timer1.Stop();
            hint1.Enabled = false;
            hint2.Enabled = false;
            hint3.Enabled = false;
            player.Stop();
            playerReader = new AudioFileReader("sounds/gong.wav");
            player.Init(playerReader);
            player.Play();
            Thread.Sleep(2500);
            picture2.Visible = true;
            dialog2.Visible = true;
            switch (ques) {
                case 1:
                case 2:
                case 4:
                case 5:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer2.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 0$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                    break;
                case 3:
                case 6:
                case 10:
                case 13:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/true.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Правильно!";
                    answer2.BackColor = Color.Green;
                    foreach (Button button in list) button.Enabled = false;
                    for (int i = 0; i < labels.Count; i++) {
                        labels[i].BackColor = Color.Black;
                        if (i == 4 || i == 9) labels[i].ForeColor = Color.Aquamarine;
                        else if (i == 14) labels[i].ForeColor = Color.Gold;
                        else labels[i].ForeColor = Color.White;
                    }
                    break;
                case 7:
                case 8:
                case 9:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer2.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res2 = MessageBox.Show("Вы проиграли, ваш зароботок: 1000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res2 == DialogResult.OK) Close();
                    break;
                case 11:
                case 12:
                case 14:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer2.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res3 = MessageBox.Show("Вы проиграли, ваш зароботок: 32000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res3 == DialogResult.OK) Close();
                    break;
            }
            start.Enabled = true;
            ques++;
        }
        private void answer3_Click(object sender, EventArgs e) {
            List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4 };
            List<Label> labels = new List<Label> { label1, label2, label3, label4, label5, label6, label7, label8, label9,
            label10, label11, label12, label13, label14, label15 };
            timer1.Stop();
            hint1.Enabled = false;
            hint2.Enabled = false;
            hint3.Enabled = false;
            player.Stop();
            playerReader = new AudioFileReader("sounds/gong.wav");
            player.Init(playerReader);
            player.Play();
            Thread.Sleep(2500);
            switch (ques) {
                case 1:
                case 2:
                case 3:
                case 4:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer3.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 0$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                    break;
                case 5:
                case 9:
                case 14:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/true.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Правильно!";
                    answer3.BackColor = Color.Green;
                    foreach (Button button in list) button.Enabled = false;
                    for (int i = 0; i < labels.Count; i++) {
                        labels[i].BackColor = Color.Black;
                        if (i == 4 || i == 9) labels[i].ForeColor = Color.Aquamarine;
                        else if (i == 14) labels[i].ForeColor = Color.Gold;
                        else labels[i].ForeColor = Color.White;
                    }
                    break;
                case 6:
                case 7:
                case 8:
                case 10:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer3.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res2 = MessageBox.Show("Вы проиграли, ваш зароботок: 1000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res2 == DialogResult.OK) Close();
                    break;
                case 11:
                case 12:
                case 13:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer3.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res3 = MessageBox.Show("Вы проиграли, ваш зароботок: 32000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res3 == DialogResult.OK) Close();
                    break;
            }
            start.Enabled = true;
            ques++;
        }
        private void answer4_Click(object sender, EventArgs e) {
            List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4 };
            List<Label> labels = new List<Label> { label1, label2, label3, label4, label5, label6, label7, label8, label9,
            label10, label11, label12, label13, label14, label15 };
            timer1.Stop();
            hint1.Enabled = false;
            hint2.Enabled = false;
            hint3.Enabled = false;
            player.Stop();
            playerReader = new AudioFileReader("sounds/gong.wav");
            player.Init(playerReader);
            player.Play();
            Thread.Sleep(2500);
            switch (ques) {
                case 1:
                case 2:
                case 3:
                case 5:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer4.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 0$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                    break;
                case 4:
                case 8:
                case 12:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/true.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Правильно!";
                    answer4.BackColor = Color.Green;
                    foreach (Button button in list) button.Enabled = false;
                    for (int i = 0; i < labels.Count; i++) {
                        labels[i].BackColor = Color.Black;
                        if (i == 4 || i == 9) labels[i].ForeColor = Color.Aquamarine;
                        else if(i == 14) labels[i].ForeColor = Color.Gold;
                        else labels[i].ForeColor = Color.White;
                    }
                    break;
                case 6:
                case 7:
                case 9:
                case 10:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer4.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res2 = MessageBox.Show("Вы проиграли, ваш зароботок: 1000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res2 == DialogResult.OK) Close();
                    break;
                case 11:
                case 13:
                case 14:
                    player.Stop();
                    playerReader = new AudioFileReader("sounds/false.wav");
                    player.Init(playerReader);
                    player.Play();
                    dialog2.Text = "Неправильно...";
                    answer4.BackColor = Color.Red;
                    foreach (Button button in list) button.Enabled = false;
                    DialogResult res3 = MessageBox.Show("Вы проиграли, ваш зароботок: 32000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res3 == DialogResult.OK) Close();
                    break;
            }
            start.Enabled = true;
            ques++;
        }
        private void but1_Click(object sender, EventArgs e) {
            hints.Stop();
            hintsReader = new AudioFileReader("sounds/hint.wav");
            hints.Init(hintsReader);
            hints.Play();
            DialogResult res = MessageBox.Show("Вы уверены что хотите начат сначало?", "?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) Application.Restart();
        }
        private void but2_Click(object sender, EventArgs e) {
            hints.Stop();
            hintsReader = new AudioFileReader("sounds/hint.wav");
            hints.Init(hintsReader);
            hints.Play();
            DialogResult res = MessageBox.Show("Вы уверены что хотите выйти?", "?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) {
                player.Stop();
                playerReader = new AudioFileReader("sounds/exit.wav");
                player.Init(playerReader);
                player.Play();
                Thread.Sleep(3000);
                Close();
            }
        }
        private void musicBox_CheckedChanged(object sender, EventArgs e) {
            if (musicBox.Checked) music.Play();
            else music.Stop();
        }
        private void hint1_Click(object sender, EventArgs e) {
            if (h1) {
                hints.Stop();
                hintsReader = new AudioFileReader("sounds/hint.wav");
                hints.Init(hintsReader);
                hints.Play();
                Thread.Sleep(1000);
                hints.Stop();
                hintsReader = new AudioFileReader("sounds/50hint.wav");
                hints.Init(hintsReader);
                hints.Play();
                hint1.Image = img1;
                hint1.Enabled = false;
                hint2.Enabled = false;
                hint3.Enabled = false;
                h1 = false;
                List<Button> list;
                int rand, rand2;
                switch (ques) {
                    case 1:
                    case 2:
                    case 7:
                    case 11:
                    case 15:
                        list = new List<Button>() { answer2, answer3, answer4 };
                        rand = new Random().Next(1, 3);
                        rand2 = new Random().Next(1, 3);
                        list[rand].Enabled = false;
                        while (true){
                            if (rand2 == rand) rand2 = new Random().Next(1, 3);
                            else break;
                        }
                        list[rand2].Enabled = false;
                        break;
                    case 3:
                    case 6:
                    case 10:
                    case 13:
                        list = new List<Button>() { answer1, answer3, answer4 };
                        rand = new Random().Next(1, 3);
                        rand2 = new Random().Next(1, 3);
                        list[rand].Enabled = false;
                        while (true) {
                            if (rand2 == rand) rand2 = new Random().Next(1, 3);
                            else break;
                        }
                        list[rand2].Enabled = false;
                        break;
                    case 5:
                    case 9:
                    case 14:
                        list = new List<Button>() { answer1, answer2, answer4 };
                        rand = new Random().Next(1, 3);
                        rand2 = new Random().Next(1, 3);
                        list[rand].Enabled = false;
                        while (true) {
                            if (rand2 == rand) rand2 = new Random().Next(1, 3);
                            else break;
                        }
                        list[rand2].Enabled = false;
                        break;
                    case 4:
                    case 8:
                    case 12:
                        list = new List<Button>() { answer1, answer2, answer3 };
                        rand = new Random().Next(1, 3);
                        rand2 = new Random().Next(1, 3);
                        list[rand].Enabled = false;
                        while (true) {
                            if (rand2 == rand) rand2 = new Random().Next(1, 3);
                            else break;
                        }
                        list[rand2].Enabled = false;
                        break;
                }
            }
        }
        private void hint2_Click(object sender, EventArgs e) {
            if (h2) {
                List<Button> list = new List<Button>() { answer1, answer2, answer3, answer4 };
                hints.Stop();
                hintsReader = new AudioFileReader("sounds/hint.wav");
                hints.Init(hintsReader);
                hints.Play();
                hint2.Image = img2;
                hint1.Enabled = false;
                hint2.Enabled = false;
                hint3.Enabled = false;
                h2 = false;
                hints.Stop();
                player.Pause();
                hintsReader = new AudioFileReader("sounds/telephone.wav");
                hints.Init(hintsReader);
                hints.Play();
                Thread.Sleep(3000);
                hints.Stop();
                player.Resume();
                picture1.Visible = true;
                dialog1.Visible = true;
                dialog1.Text = $"Я полагаю что правильный ответ: {list[new Random().Next(0, 4)].Text}.";
            }
        }
        private void hint3_Click(object sender, EventArgs e) {
            if (h3) {
                hints.Stop();
                hintsReader = new AudioFileReader("sounds/hint.wav");
                hints.Init(hintsReader);
                hints.Play();
                hint3.Image = img3;
                group3.Visible = true;
                hint1.Enabled = false;
                hint2.Enabled = false;
                hint3.Enabled = false;
                h3 = false;
                player.Pause();
                hints.Stop();
                hintsReader = new AudioFileReader("sounds/zal.wav");
                hints.Init(hintsReader);
                hints.Play();
                Thread.Sleep(5000);
                hints.Stop();
                player.Resume();
                int[] rand = new int[4];
                rand[0] = new Random().Next(0, 100);
                rand[1] = new Random().Next(0, rand[0]);
                rand[2] = new Random().Next(0, rand[1]);
                rand[3] = new Random().Next(0, rand[2]);
                progress1.Value = rand[0];
                label31.Text = $"{rand[0]}%";
                progress2.Value = rand[1];
                label32.Text = $"{rand[1]}%";
                progress3.Value = rand[2];
                label33.Text = $"{rand[2]}%";
                progress4.Value = rand[3];
                label34.Text = $"{rand[3]}%";
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            sec--;
            timerBox.Text = string.Format("00:{0:D2}", sec);
            if (sec == 0) {
                timer1.Stop();
                player.Stop();
                playerReader = new AudioFileReader("sounds/endtime.wav");
                player.Init(playerReader);
                player.Play();
                timerBox.Text = "Время вышло!";
                hint1.Enabled = false;
                hint2.Enabled = false;
                hint3.Enabled = false;
                answer1.Enabled = false;
                answer2.Enabled = false;
                answer3.Enabled = false;
                answer4.Enabled = false;
                Task.Delay(1600).GetAwaiter().GetResult();
                player.Stop();
                playerReader = new AudioFileReader("sounds/false.wav");
                player.Init(playerReader);
                player.Play();
                if (ques <= 5) {
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 0$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                }
                else if(ques > 5) {
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 1000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                }
                else {
                    DialogResult res = MessageBox.Show("Вы проиграли, ваш зароботок: 32000$", "Увы",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK) Close();
                }
            }
        }
    }
}
