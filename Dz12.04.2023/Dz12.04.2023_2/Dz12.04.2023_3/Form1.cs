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

namespace Dz12._04._2023_3 {
    public partial class Form1 : Form {
        public Редактирование ChildForm { get; set; }
        public Form1() => InitializeComponent();
        public string TextBox1 {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        private void load_Click(object sender, EventArgs e) {
            open.FileName = null;
            open.InitialDirectory = "c:\\";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK) {
                using(StreamReader file =  new StreamReader(open.FileName, false)) {
                    while (!file.EndOfStream) textBox1.Text = file.ReadLine() + "\n";
                }
            }
            change.Enabled = true;
        }
        private void change_Click(object sender, EventArgs e) {
            if(ChildForm != null) {
                ChildForm.Activate();
                return;
            }
            ChildForm = new Редактирование();
            ChildForm.ParentForm = this;
            ChildForm.form1 = this;
            ChildForm.Show();
            ChildForm.TextBox1 = textBox1.Text;
        }
    }
}
