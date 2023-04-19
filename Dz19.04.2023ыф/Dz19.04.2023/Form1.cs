using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz19._04._2023 {
    public partial class Form1 : Form {
        Thread thread;
        Airport air;
        List<string> finders = new List<string>();
        public Form1() {
            InitializeComponent();
            Passenger pass1 = new Passenger("Сидорович", 5, 45, "25.05.2023", "02:53", 255, "Сахара", "C-201");
            Passenger pass2 = new Passenger("Имануилович", 7, 32, "13.06.2023", "04:28", 118, "Амазонка", "C-202");
            List<Passenger> pass = new List<Passenger> { pass1, pass2 };
            Airport airport = new Airport(pass, "C-202");
            air = airport;
            foreach (Passenger passenger in airport.passengers) finders.Add(passenger.FlightName);
        }
        public void ThreadFunc(object obj) {
            for(int i = 0; i < finders.Count; i++) {
                if (textBox1.Text.Contains(finders[i])) {
                    textBox2.Text = air.passengers[i].Surname;
                    return;
                }
            }
            MessageBox.Show("Не удалось найти рейс.", "(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox1_TextChanged(object sender, EventArgs e) => check.Enabled = true;
        private void check_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(textBox1.Text)) {
                thread = new Thread(ThreadFunc);
                thread.IsBackground = true;
                thread.Start();
            }
            else MessageBox.Show("Введите текст!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
