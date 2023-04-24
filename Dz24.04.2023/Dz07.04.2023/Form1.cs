using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Dz07._04._2023 {
    public partial class Form1 : Form {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Thread thread;
        public int Count { get; set; }
        Mutex m = new Mutex(false, "SYNC_MUTEX");
        public Form1() {
            InitializeComponent();
        }
        public void UpdateOne() {
            for (int i = 0; i < 1000; i++) {
                m.WaitOne();
                ++Count;
                form2 = new Form2();
                form2.ParentForm = this;
                DialogResult res = form2.ShowDialog();
                m.ReleaseMutex();
                form2.Close();
            }
        }
        public void UpdateTwo() {
            for (int i = 0; i < 1000; i++) {
                m.WaitOne();
                ++Count;
                form3 = new Form3();
                form3.ParentForm = this;
                DialogResult res = form3.ShowDialog();
                m.ReleaseMutex();
                form3.Close();
            }
        }
        public void UpdateThree() {
            for (int i = 0; i < 1000; i++) {
                m.WaitOne();
                ++Count;
                form4 = new Form4();
                form4.ParentForm = this;
                DialogResult res = form4.ShowDialog();
                m.ReleaseMutex();
                form4.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            thread = new Thread(UpdateOne);
            thread.Start();
            thread.Join();
        }
        private void button2_Click(object sender, EventArgs e) {
            thread = new Thread(UpdateTwo);
            thread.Start();
            thread.Join();
        }
        private void button3_Click(object sender, EventArgs e) {
            thread = new Thread(UpdateThree);
            thread.Start();
            thread.Join();
        }
        private void menu1_Click(object sender, EventArgs e) => Close();
        private void stripMenu1_Click(object sender, EventArgs e) => Close();
    }
}
