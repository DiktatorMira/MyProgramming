using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz07._04._2023 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            combo1.Items.Add("А-92");
            combo1.Items.Add("Евро А-95");
            combo1.Items.Add("Pulls А-95");
            combo1.Items.Add("А-100");
            combo1.Items.Add("Puls А-100");
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (combo1.SelectedIndex) {
                case 0:
                    textBox1.Text = "43.50";
                    break;
                case 1:
                    textBox1.Text = "49.00";
                    break;
                case 2:
                    textBox1.Text = "51.00";
                    break;
                case 3:
                    textBox1.Text = "55.25";
                    break;
                case 4:
                    textBox1.Text = "57.50";
                    break;
            }
        }
        private void radio11_CheckedChanged(object sender, EventArgs e) {
            if (radio11.Checked) {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }
        private void radio12_CheckedChanged(object sender, EventArgs e) {
            if (radio12.Checked) {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }
        private void check1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                double res = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
                if (textBox2.Enabled) label6.Text = $"{res} грн";
                else label6.Text = $"{textBox3.Text} грн";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {
            radio11.Enabled = true;
            radio12.Enabled = true;
            textBox2.Enabled = true;
            check1.Enabled = true;
            check3.Enabled = true;
        }

        private void check11_CheckedChanged(object sender, EventArgs e) {
            if(check11.Checked) text1.Enabled = true;
            else text1.Enabled = false;
        }
        private void check12_CheckedChanged(object sender, EventArgs e) {
            if (check12.Checked) text2.Enabled = true;
            else text2.Enabled = false;
        }
        private void check13_CheckedChanged(object sender, EventArgs e) {
            if (check13.Checked) text3.Enabled = true;
            else text3.Enabled = false;
        }
        private void check14_CheckedChanged(object sender, EventArgs e) {
            if (check14.Checked) text4.Enabled = true;
            else text4.Enabled = false;
        }
        private void check15_CheckedChanged(object sender, EventArgs e) {
            if (check15.Checked) text5.Enabled = true;
            else text5.Enabled = false;
        }
        private void check16_CheckedChanged(object sender, EventArgs e) {
            if (check16.Checked) text6.Enabled = true;
            else text6.Enabled = false;
        }
        private void check2_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                List<TextBox> quans = new List<TextBox>() { text1, text2, text3, text4, text5, text6 };
                List<TextBox> prices = new List<TextBox>() { text21, text22, text23, text24, text25, text26 };
                double sum = 0;
                for(int i = 0; i < quans.Count; i++) {
                    if (quans[i].Enabled) sum += double.Parse(prices[i].Text) * double.Parse(quans[i].Text);
                }
                label9.Text = $"{sum} грн"; 
            }
        }
        private void check3_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                double res = double.Parse(label6.Text) + double.Parse(label9.Text);
                label10.Text = $"{res} грн";
            }
        }
    }
}
