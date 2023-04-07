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

namespace Laba07._04._2023_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void add_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && !string.IsNullOrEmpty(masked1.Text)) {
                if (list1.Items.Contains(masked1.Text)) MessageBox.Show("Пользователь с таким именем уже существует!");
                else list1.Items.Add(masked1.Text);
            }
        }
        private void export_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                using (StreamWriter file = new StreamWriter("information.txt", Enabled)) {
                    for(int i = 0; i < list1.Items.Count; i++) file.Write(list1.Items[i] + "\n");
                }
            }
        }
        private void import_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                list1.Items.Clear();
                using (StreamReader file = new StreamReader("information.txt", false)) {
                    while (!file.EndOfStream) list1.Items.Add(file.ReadLine());
                }
            }
        }
    }
}
