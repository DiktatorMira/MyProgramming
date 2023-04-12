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

namespace Dz12._04._2023 {
    public partial class Form1 : Form {
        string path = "C:\\";
        public Form1() => InitializeComponent();
        private void check_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(extension.Text)) {
                MessageBox.Show("Введите расширение файла!", "Это что такое?", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                fileInfo.Items.Clear();
                pathText.Text = path;
                string[] files = Directory.GetFiles(path);
                int count = 0;
                for (int i = 0; i < files.Length; i++) {
                    if (files[i].Contains("." + extension.Text)) count++;
                }
                if (count == 0) fileInfo.Items.Add("Файлов с таким расширением нет.");
                else {
                    fileInfo.Items.Add("Всего файлов этого типа: " + count);
                    fileInfo.Items.Add("\n");
                    foreach (string file in files) {
                        if (file.Contains("." + extension.Text)) fileInfo.Items.Add(file);
                    }
                }
            }
        }
        private void find_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowser1.ShowDialog();
            if (result == DialogResult.OK) path = folderBrowser1.SelectedPath;
        }
    }
}
