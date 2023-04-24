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
    public partial class Form3 : Form {
        public Form ParentForm { get; set; }
        public Form3() => InitializeComponent();
        private void check11_CheckedChanged_1(object sender, EventArgs e) {
            if (check11.Checked) text1.Enabled = true;
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
        private void check2_Click(object sender, EventArgs e) {
            List<TextBox> quans = new List<TextBox>() { text1, text2, text3, text4, text5, text6 };
            List<TextBox> prices = new List<TextBox>() { text21, text22, text23, text24, text25, text26 };
            double sum = 0, temp = 0, temp2 = 0;
            for (int i = 0; i < quans.Count; i++) {
                //if (quans[i].Enabled) sum += double.Parse(prices[i].Text) * double.Parse(quans[i].Text);
                if (quans[i].Enabled && double.TryParse(prices[i].Text, out temp) && double.TryParse(quans[i].Text, out temp2)) {
                    sum += temp * temp2;
                }
            }
            label9.Text = sum.ToString();
            //label9.Text = $"{sum} грн";
        }
    }
}
