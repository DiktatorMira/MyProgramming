using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5 {
    public partial class View : Form {
        Controller controller;
        public View() {
            InitializeComponent();
            controller = new Controller();
        }
        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                label1.Text = "Введите название книги для поиска:";
                textBox2.Text = controller.GetBook(textBox1.Text, true);
            }
            else {
                label1.Text = "Введите имя автора книги для поиска:";
                textBox2.Text = controller.GetBook(textBox1.Text, false); 
            }
        }
    }
}
