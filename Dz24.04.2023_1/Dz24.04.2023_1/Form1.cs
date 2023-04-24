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

namespace Dz24._04._2023_1 {
    public partial class Form1 : Form {
        Thread thread;
        Mutex mutex = new Mutex(false, "FileSearch");
        string path = "C:\\";
        public Form1() => InitializeComponent();
        private void start_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)) {
                thread = new Thread(FileSearchTh);
                thread.Start();
                thread.Join();
            }
            else MessageBox.Show("Введите требуемое!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FileSearchTh() {
            mutex.WaitOne();
            Directory.SetCurrentDirectory(path);
            int count = 0;
            string[] directories = Directory.GetDirectories(textBox2.Text);
            string direct = null;
            foreach(string dir in directories) {
                using (StreamReader file = new StreamReader(dir, Encoding.UTF8)) {
                    if (file.ReadToEnd().Contains(textBox1.Text)) {
                        count++;
                        direct = dir;
                    }
                }
            }
            if(count != 0) {
                listBox1.Items.Add($"Название файла: {direct}");
                listBox1.Items.Add($"Путь к файлу: {Directory.GetDirectories(direct)}");
                listBox1.Items.Add($"Количество слов в файле: {count}");
            }
            mutex.ReleaseMutex();
        }
    }
}
