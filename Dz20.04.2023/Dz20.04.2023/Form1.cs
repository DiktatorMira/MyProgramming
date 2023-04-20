using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz20._04._2023 {
    public partial class Form1 : Form {
        Process[] processes;
        public Form1() {
            InitializeComponent();
            processes = Process.GetProcesses();
            procList.Columns.Add("Имя процесса:", 300);
            procList.Columns.Add("ID:", 250);
            foreach (Process p in processes)
                procList.Items.Add(new ListViewItem { Text = p.ProcessName, SubItems = { p.Id.ToString() } });
        }
        private void update_Click(object sender, EventArgs e) {
            procList.Items.Clear();
            processes = Process.GetProcesses();
            procList.Columns.Add("Имя процесса:", 300);
            procList.Columns.Add("ID:", 250);
            foreach (Process p in processes)
                procList.Items.Add(new ListViewItem { Text = p.ProcessName, SubItems = { p.Id.ToString() } });
        }
        private void close_Click(object sender, EventArgs e) {
            if (procList.It) {
                ListViewItem select = procList.SelectedItems[0];
                processes[select.Index].Close();
            }
        }
    }
}
