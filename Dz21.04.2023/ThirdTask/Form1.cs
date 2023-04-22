using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdTask {
    public partial class Form1 : Form {
        List<Student> students;
        int aver = 0;
        public Form1() {
            InitializeComponent();
            Student student1 = new Student("Малик", "RH-212", 8, 6, 9);
            Student student2 = new Student("Алька", "RH-213", 12, 11, 8);
            Student student3 = new Student("Морисей", "HR-111", 12, 12, 12);
            Student student4 = new Student("Настя", "MK-113", 5, 2, 7);
            students = new List<Student> { student1, student2, student3, student4 };
            listView1.Columns.Add("Имя:", 200);
            listView1.Columns.Add("Группа:", 200);
            listView1.Columns.Add("Средний бал:", 200);
        }
        private async void start_Click(object sender, EventArgs e) => await Task.Run(() => TaskRun());
        private void TaskRun() {
            foreach (Student student in students) {
                aver = (student.PhysicMark * student.MathsMark * student.InfoMark) / 3;
                listView1.Items.Add(new ListViewItem() { Text = student.Fio, SubItems = { student.Group, $"{aver}" } });
            }
        }
    }
    public class Student {
        public string Fio { get; set; }
        public string Group { get; set; }
        public int PhysicMark { get; set; }
        public int MathsMark { get; set; }
        public int InfoMark { get; set; }
        public Student() :this(null, null, 0, 0, 0) { }
        public Student(string fio, string group, int physicMark, int mathsMark, int infoMark) {
            Fio = fio;
            Group = group;
            PhysicMark = physicMark;
            MathsMark = mathsMark;
            InfoMark = infoMark;
        }
    }
}
