using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para05._04 {
    public partial class Form1 : Form
    {
        public void Task1()
        {
            string text1 = "Имя: Данила";
            string text2 = "Опыта работы: нулевой";
            string text3 = "Требумемая зарплата: 2000$";
            MessageBox.Show(text1, "Страница 1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show(text2, "Страница 2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            string result = text1 + text2 + text3;
            double average = result.Length / 3;
            MessageBox.Show(text3, $"Страница 3, Среднее кол-во символов: {average}",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void Task2()
        {
            do
            {
                int number = new Random().Next(1, 2000);
                int DialogQuan = 1;
                DialogResult result = MessageBox.Show($"Вы загадали число {number}?", "Угадайка",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    while (result != DialogResult.Yes)
                    {
                        number = new Random().Next(1, 2000);
                        result = MessageBox.Show($"Вы загадали число {number}?", "Угадайка",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        DialogQuan++;
                    }
                }
                MessageBox.Show($"На угадывание постребовалось {DialogQuan} диалогов.", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Хотите ли вы выйти?", "?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) break;
            } while (true);
        }
        public void Task3()
        {
            int left = Screen.PrimaryScreen.Bounds.Width - 20;
            int top = Screen.PrimaryScreen.Bounds.Width - 20;
        }
        public Form1() {
            InitializeComponent();
            //Task1();
            //Task2();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(100, 100);
            Task3();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) MessageBox.Show($"Нажата левая кнопка мыши, {e.X} {e.Y}", "инфа",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if(e.Button == MouseButtons.Right) MessageBox.Show($"Нажата правая кнопка мыши, {e.X} {e.Y}", "инфа",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e) => Text = $"X:{e.X}; Y:{e.Y}";
    }
}
