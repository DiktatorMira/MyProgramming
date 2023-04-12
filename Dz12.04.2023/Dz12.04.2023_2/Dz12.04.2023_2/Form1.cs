using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz12._04._2023_2 {
    public partial class Form1 : Form {
        int sum = 0;
        public Form1() {
            InitializeComponent();
            combo1.Items.Add("Видеокарта");
            combo1.Items.Add("Процессор");
            combo1.Items.Add("ОЗУ");
            combo1.Items.Add("Мышь");
            combo1.Items.Add("Клавиатура");
            combo1.Items.Add("Монитор");
        }
        private void combo1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (combo1.SelectedIndex) {
                case 0:
                    label3.Text = "15250";
                    break;
                case 1:
                    label3.Text = "7620";
                    break;
                case 2:
                    label3.Text = "3265";
                    break;
                case 3:
                    label3.Text = "928";
                    break;
                case 4:
                    label3.Text = "1134";
                    break;
                case 5:
                    label3.Text = "4865";
                    break;
            }
        }
        private void clear_Click(object sender, EventArgs e) => list1.Items.Clear();
        private void add_Click(object sender, EventArgs e) {
            if (list1.Items.Contains(combo1.SelectedItem)) {
                MessageBox.Show("Товар уже выбран!", "Ай-ай-ай!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                list1.Items.Add(combo1.SelectedItem);
                sum += int.Parse(label3.Text);
                label2.Text = $"Общая стоимость: {sum.ToString()} грн";
            }
        }
    }
}
