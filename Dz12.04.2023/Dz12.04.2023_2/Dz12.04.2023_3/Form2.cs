using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz12._04._2023_3 {
    public partial class Редактирование : Form {
        public Form ParentForm { get; set; }
        public Form1 form1 { get; set; }
        string TextBuff = "";
        public string TextBox1 {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public Редактирование() => InitializeComponent();
        private void save_Click(object sender, EventArgs e) {
            form1.TextBox1 = textBox1.Text;
            Close();
        }
        private void deny_Click(object sender, EventArgs e) => textBox1.Text = form1.TextBox1;
    }
}
