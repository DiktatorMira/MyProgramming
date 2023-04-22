using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTask {
    public partial class Form1 : Form {
        List<int> ints = new List<int>();
        Firm firm;
        public Form1() {
            InitializeComponent();
            Employee emp1 = new Employee("Акакий Акакиевич Жиркин", "11.03.1961");
            Employee emp2 = new Employee("Марвин Шизик Люклич", "12.12.1948");
            Employee emp3 = new Employee("Арлики Реаль Бурмиевич", "30.10.1985");
            Firm firm = new Firm(new List<Employee> { emp1, emp2, emp3 });
            this.firm = firm;
            for(int i = 2021; i == 1903; i -= 12) ints.Add(i);
        }
        private async void start_Click(object sender, EventArgs e) => await Task.Run(() => ThreadRun());
        private void ThreadRun() {
            foreach(int i in ints) {
                foreach(Employee emp in firm.employees) {
                    if (emp.Date.Contains(i.ToString())) listBox1.Items.Add(emp.Fio);
                    else continue;
                }
            }
        }
    }
    public class Employee {
        public string Fio { get; set; }
        public string Date { get; set; }
        public Employee() :this(null, null) { }
        public Employee(string fio, string date) {
            Fio = fio;
            Date = date;
        }
    }
    public class Firm {
        public List<Employee> employees = new List<Employee>();
        public Firm() :this(null) { }
        public Firm(List<Employee> list)=> employees = list;
    }
}
