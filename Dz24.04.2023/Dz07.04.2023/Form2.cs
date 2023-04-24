using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz07._04._2023 {
    public partial class Form2 : Form {
        Form1 form1;
        public Form ParentForm { get; set; }
        public Form2() {
            InitializeComponent();
            form1 = new Form1();
            combo1.Items.Add("А-92");
            combo1.Items.Add("Евро А-95");
            combo1.Items.Add("Pulls А-95");
            combo1.Items.Add("А-100");
            combo1.Items.Add("Puls А-100");
        }
        private void combo1_SelectedIndexChanged_1(object sender, EventArgs e) {
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
        private void radio11_CheckedChanged_1(object sender, EventArgs e) {
            if (radio11.Checked) {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }
        private void radio12_CheckedChanged_1(object sender, EventArgs e) {
            if (radio12.Checked)  {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }
        private void check1_Click(object sender, EventArgs e) {
            double temp1 = 0, temp2 = 0;
            string res = null;
            if (double.TryParse(textBox1.Text, out temp1) && double.TryParse(textBox2.Text, out temp2)) {
                res = (temp1 * temp2).ToString();
            }
            //double res = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            if (textBox2.Enabled) label6.Text = $"{res} грн";
            else label6.Text = $"{textBox3.Text} грн";
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e) {
            radio11.Enabled = true;
            radio12.Enabled = true;
            textBox2.Enabled = true;
            check1.Enabled = true;
        }
    }
}
