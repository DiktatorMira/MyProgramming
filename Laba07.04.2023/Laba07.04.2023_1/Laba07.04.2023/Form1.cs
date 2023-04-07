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

namespace Laba07._04._2023
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void strat_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                StreamReader file = new StreamReader("info.txt", false);
                string text = file.ReadToEnd();
                textBox1.Text = text;
                if (progress.Maximum < text.Length) {
                    progress.Maximum = text.Length;
                    label2.Text = progress.Maximum.ToString();
                }
                label3.Text = text.Length.ToString();
                progress.Value = text.Length;
            }
        }
    }
}
