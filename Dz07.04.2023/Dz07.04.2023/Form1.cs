using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz07._04._2023 {
    public partial class Form1 : Form {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            form2 = new Form2();
            form2.ParentForm = this;
            DialogResult res = form2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e) {
            form3 = new Form3();
            form3.ParentForm = this;
            DialogResult res = form3.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e) {
            form4 = new Form4();
            form4.ParentForm = this;
            DialogResult res = form4.ShowDialog();
        }
        private void menu1_Click(object sender, EventArgs e) => Close();
        private void stripMenu1_Click(object sender, EventArgs e) => Close();
    }
}
