using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz13._04._2023 {
    public partial class Form1 : Form {
        int quan = 0, value = 0;
        RadioButton radio213, radio221, radio232;
        GroupBox group21, group22, group23, group31, group32, group33;
        public Form1() {
            InitializeComponent();
            tab1.Controls[0].Text = "Страница 1";
        }
        private void next_Click(object sender, EventArgs e) {
            switch (value) {
                case 0:
                    next.Enabled = false;
                    check.Enabled = true;
                    TabPage page2 = new TabPage("Страница 2");
                    group21 = new GroupBox();
                    group21.Location = new Point(6, 6);
                    group21.Size = new Size(170, 118);
                    group21.Text = "В каком году основали Microsoft?";
                    page2.Controls.Add(group21);
                    RadioButton radio211 = new RadioButton();
                    radio211.Location = new Point(7, 36);
                    radio211.Size = new Size(56, 20);
                    radio211.Text = "1969";
                    group21.Controls.Add(radio211);
                    RadioButton radio212 = new RadioButton();
                    radio212.Location = new Point(7, 62);
                    radio212.Size = new Size(56, 20);
                    radio212.Text = "1984";
                    group21.Controls.Add(radio212);
                    radio213 = new RadioButton();
                    radio213.Location = new Point(7, 88);
                    radio213.Size = new Size(56, 20);
                    radio213.Text = "1975";
                    group21.Controls.Add(radio213);
                    radio213.CheckedChanged += new EventHandler(radio213_CheckedChanged);
                    group22 = new GroupBox();
                    group22.Location = new Point(190, 6);
                    group22.Size = new Size(190, 118);
                    group22.Text = "Какая валюта у Великобритании?";
                    page2.Controls.Add(group22);
                    radio221 = new RadioButton();
                    radio221.Location = new Point(7, 36);
                    radio221.Size = new Size(110, 20);
                    radio221.Text = "Фунт-стерлинг";
                    radio221.CheckedChanged += new EventHandler(radio221_CheckedChanged);
                    group22.Controls.Add(radio221);
                    RadioButton radio222 = new RadioButton();
                    radio222.Location = new Point(7, 62);
                    radio222.Size = new Size(90, 20);
                    radio222.Text = "Гривна";
                    group22.Controls.Add(radio222);
                    RadioButton radio223 = new RadioButton();
                    radio223.Location = new Point(7, 88);
                    radio223.Size = new Size(90, 20);
                    radio223.Text = "Форинт";
                    group22.Controls.Add(radio223);
                    group23 = new GroupBox();
                    group23.Location = new Point(105, 127);
                    group23.Size = new Size(190, 118);
                    group23.Text = "Как называется пост премьер-министра в Германии?";
                    page2.Controls.Add(group23);
                    RadioButton radio231 = new RadioButton();
                    radio231.Location = new Point(7, 36);
                    radio231.Size = new Size(70, 20);
                    radio231.Text = "Кайзер";
                    group23.Controls.Add(radio231);
                    radio232 = new RadioButton();
                    radio232.Location = new Point(7, 62);
                    radio232.Size = new Size(75, 20);
                    radio232.Text = "Канцлер";
                    group23.Controls.Add(radio232);
                    radio232.CheckedChanged += new EventHandler(radio232_CheckedChanged);
                    RadioButton radio233 = new RadioButton();
                    radio233.Location = new Point(7, 88);
                    radio233.Size = new Size(75, 20);
                    radio233.Text = "Вермахт";
                    group23.Controls.Add(radio233);
                    tab1.Controls.Add(page2);
                    value++;
                    break;
                case 1:
                    next.Enabled = false;
                    check.Enabled = true;
                    TabPage page3 = new TabPage("Страница 3");
                    group31 = new GroupBox();

                    tab1.Controls.Add(page3);
                    value++;
                    break;
            }
        }
        private void check_Click(object sender, EventArgs e) {
            switch (value) {
                case 0:
                    List<GroupBox> list1 = new List<GroupBox>() { group11, group12, group13 };
                    progressBar1.Value = quan;
                    label1.Text = $"{quan}/9";
                    foreach (GroupBox group in list1) group.Enabled = false;
                    next.Enabled = true;
                    check.Enabled = false;
                    break;
                case 1:
                    List<GroupBox> list2 = new List<GroupBox>() { group21, group22, group23 };
                    progressBar1.Value = quan;
                    label1.Text = $"{quan}/9";
                    foreach (GroupBox group in list2) group.Enabled = false;
                    next.Enabled = true;
                    check.Enabled = false;
                    break;
            }
        }
        private void radio12_CheckedChanged(object sender, EventArgs e) {
            if (radio12.Checked) quan++;
        }
        private void radio21_CheckedChanged(object sender, EventArgs e) {
            if (radio21.Checked) quan++;
        }
        private void radio33_CheckedChanged(object sender, EventArgs e) {
            if (radio33.Checked) quan++;
        }
        private void radio213_CheckedChanged(object sender, EventArgs e) {
            if (radio213.Checked) quan++;
        }
        private void radio221_CheckedChanged(object sender, EventArgs e) {
            if (radio221.Checked) quan++;
        }
        private void radio232_CheckedChanged(object sender, EventArgs e) {
            if (radio232.Checked) quan++;
        }
    }
}
