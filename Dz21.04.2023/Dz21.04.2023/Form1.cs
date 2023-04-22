using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz21._04._2023 {
    public partial class Form1 : Form {
        Firm firm;
        public Form1() {
            InitializeComponent();
            Employee emp1 = new Employee("Шихид", "Аргим", "Михайлович", 1992, "02943290", "улица 34", 
                "бейкер стрит", 576, 57);
            Employee emp2 = new Employee("Джирка", "Менд", "Шириевич", 1976, "42342345", "улица 65",
                "мальик", 3, 1);
            Employee emp3 = new Employee("Черемьев", "Архшир", "Мендьевич", 1998, "5534523532", "улица 4",
                "мальик", 47, 31);
            Firm firm1 = new Firm(new List<Employee> { emp1, emp2, emp3 });
            firm = firm1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e) => check.Enabled = true;
        private async void check_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBox1.Text)) await Task.Run(() => ThreadWorker());
            else MessageBox.Show("Введите улицу!", "Дурной(ая)",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void ThreadWorker() {
            int quan = 0, sum = 0;
            foreach (var employee in firm.employees) {
                if (textBox1.Text == employee.Street && employee.HouseNumber % 2 == 0) {
                    listBox1.Items.Add(employee.Surname);
                    listBox2.Items.Add(employee.Telephone);
                    sum += 2023 - employee.Year;
                    quan++;
                }
            }
            if (quan != 0) textBox2.Text = $"{sum / quan}";
            else MessageBox.Show("Нет ни одного сотрудника!");
        }
    }
    public class Employee {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Pathronymic { get; set; }
        public int Year { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public Employee() :this(null, null, null, 0, null, null, null, 0, 0) { }
        public Employee(string surname, string name, string pathronymic, int year, string telephone, 
            string address, string street, int houseNumber, int flatNumber)  {
            Surname = surname;
            Name = name;
            Pathronymic = pathronymic;
            Year = year;
            Telephone = telephone;
            Address = address;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }
    }
    public class Firm {
        public List<Employee> employees = new List<Employee>();
        public Firm() :this(null) { }
        public Firm(List<Employee> list) => employees = list;
    }
}
