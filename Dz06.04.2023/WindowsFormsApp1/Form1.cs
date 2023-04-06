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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form {
        double quan = 0.0;
        int sec = 0, min = 0, sec2 = 0;
        public Form1() {
            InitializeComponent();
            progress.Value = 0;
        }
        private void start_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                List<GroupBox> list = new List<GroupBox>() { 
                    group1, group2, group3, group4, group5, group6, group7, group8, group9 };
                start.Enabled = false;
                end.Enabled = true;
                progress.Enabled = true;
                start2.Enabled = true;
                timer1.Start();
                foreach (GroupBox obj in list) obj.Enabled = true;
            }
        }
        private void end_MouseClick(object sender, MouseEventArgs e) {
            List<GroupBox> list = new List<GroupBox>() { 
                group1, group2, group3, group4, group5, group6, group7, group8, group9, group10 };
            if (e.Button == MouseButtons.Left) {
                timer1.Stop();
                end.Enabled = false;
                start2.Enabled = false;
                foreach (GroupBox obj in list) obj.Enabled = false;
                #region Условия
                if (radio12.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                if (check21.Checked) {
                    quan += 0.33;
                    progress.Value += 3;
                }
                if (check23.Checked) {
                    quan += 0.33;
                    progress.Value += 3;
                }
                if (check26.Checked) {
                    quan += 0.34;
                    progress.Value += 4;
                }
                if (radio31.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                if (radio43.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                if (radio53.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                if (check62.Checked) {
                    quan += 0.5;
                    progress.Value += 5;
                }
                if (check64.Checked) {
                    quan += 0.5;
                    progress.Value += 5;
                }
                if (radio72.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                if (radio81.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                if (check91.Checked) {
                    quan += 0.33;
                    progress.Value += 3;
                }
                if (check92.Checked) {
                    quan += 0.33;
                    progress.Value += 3;
                }
                if (check94.Checked) {
                    quan += 0.34;
                    progress.Value += 4;
                }
                if (radio103.Checked) {
                    quan++;
                    progress.Value += 10;
                }
                #endregion
                label1.Text = $"{progress.Value}%";
                StreamWriter file = new StreamWriter("Result.txt", false);
                file.WriteLine($"Количество набраных очков: {quan}/10({progress.Value}%)");
                file.Close();
                DialogResult res = MessageBox.Show($"Ваш результат: {quan}/10 очков.\nНа это ушло {min} минут {sec} секунд.\nРезультат будет сохранён в файл.",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK) Application.Exit();
            }
        }
        private void start2_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                start2.Enabled = false;
                group10.Enabled = true;
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e) {
            sec2++;
            label2.Text = string.Format("00:{0:D2}", sec2);
            if (sec2 == 5) {
                group10.Enabled = false;
                timer2.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            sec++;
            if (sec > 59) {
                sec = 0;
                min++;
            }
            Text = string.Format("Викторина {0:D2}:{1:D2}", min, sec);
        }
    }
}
