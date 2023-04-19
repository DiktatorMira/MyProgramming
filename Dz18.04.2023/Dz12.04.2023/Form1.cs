using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz12._04._2023 {
    public partial class Form1 : Form {
        string path = "C:\\";
        ImageList image = new ImageList();
        Thread main, thread = null;
        private delegate void InWork(int a);
        string firstPath = Directory.GetCurrentDirectory();
        public Form1() {
            InitializeComponent();
            Directory.SetCurrentDirectory(path);
            comboDisk.Items.Add(Directory.GetCurrentDirectory().ToString());
            image.ColorDepth = ColorDepth.Depth32Bit;
            image.ImageSize = new Size(16, 16);
            Directory.SetCurrentDirectory(firstPath);
            Icon icon = new Icon("folder.ico");
            image.Images.Add(icon);
        }
        private void ThreadWorks(object obj) {
            try {
                Action act1 = delegate
                {
                    fileList.Items.Clear();
                    string[] files = Directory.GetFiles(path);
                    string[] directories = Directory.GetDirectories(path);
                    int count = 0;
                    Icon icon = new Icon("folder.ico");
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].Contains("." + extension.Text)) count++;
                    }
                    label3.Visible = true;
                    if (count == 0)
                    {
                        label3.Text = "Файлов с таким расширением нет.";
                        MessageBox.Show("Файлов с таким расширением нет.", "Увы",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        label3.Text = $"Всего файлов этого типа:  {count}";
                        foreach (string file in files)
                        {
                            icon = Icon.ExtractAssociatedIcon(file);
                            image.Images.Add(icon);
                            if (file.Contains("." + extension.Text)) fileList.Items.Add(file);
                            foreach (string dir in directories)
                            {
                                if (file.Contains("." + extension.Text)) fileList.Items.Add(dir, 0);
                            }
                        }
                    }
                };
                Invoke(act1);
            }
            catch (Exception ex) { }
        }
        public void ThreadSearch(object obj) {
            fileList.Items.Clear();
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            int count = 0;
            Icon icon = new Icon("folder.ico");
            for (int i = 0; i < files.Length; i++) {
                if (files[i].Contains("." + extension.Text)) count++;
            }
            label3.Visible = true;
            if (count == 0) {
                label3.Text = "Файлов с таким расширением нет.";
                MessageBox.Show("Файлов с таким расширением нет.", "Увы",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                label3.Text = $"Всего файлов этого типа:  {count}";
                foreach (string file in files) {
                    icon = Icon.ExtractAssociatedIcon(file);
                    image.Images.Add(icon);
                    if (file.Contains("." + extension.Text)) fileList.Items.Add(file);
                    foreach (string dir in directories) {
                        if (file.Contains("." + extension.Text)) fileList.Items.Add(dir, 0);
                    }
                }
            }
        }
        private void check_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(extension.Text)) {
                MessageBox.Show("Введите расширение файла!", "Это что такое?", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                stop.Enabled = true;
                Thread thread = new Thread(new ParameterizedThreadStart(ThreadWorks));
                main = thread;
                thread.IsBackground = true;
                thread.Start();
            }
        }
        private void find_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowser1.ShowDialog();
            if (result == DialogResult.OK) path = folderBrowser1.SelectedPath;
        }
        private void comboDisk_SelectedIndexChanged(object sender, EventArgs e) => check.Enabled = true;
        private void stop_Click(object sender, EventArgs e) => main.Abort();
    }
}
