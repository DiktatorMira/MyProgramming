using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz24._02._2023 {
    interface IPeople {
        string FIO { get; set; }
        string Male { get; set; }
        string PassportInfo { get; set; }
        string Localization { get; set; }
    }
    internal class Parent : IPeople {
        public string FIO { get; set; }
        public string Male { get; set; }
        public string PassportInfo { get; set; }
        public string Localization { get; set; }
        Student student;
        public bool IsActive { get; set; }
        public Parent() : this(null, null, null, null, null) => IsActive = false;
        public Parent(string fio, string male, string pass, string local, Student obj) {
            FIO = fio;
            Male = male;
            PassportInfo = pass;
            Localization = local;
            student = obj;
            IsActive = true;
        }
    }
    internal class Student : IPeople {
        public string FIO { get; set; }
        public string Male { get; set; }
        public string PassportInfo { get; set; }
        public string Localization { get; set; }
        public string Group { get; set; }
        Parent parents;
        public Student() :this(null, null, null, null, null, null) { }
        public Student(string fio, string male, string pass, string local, string group, Parent obj) {
            FIO = fio;
            Male = male;
            PassportInfo = pass;
            Localization = local;
            Group = group;
            parents = obj;
        }
        public bool GetParents() { return parents.IsActive; }
    }
    internal class Headman : Student {
        public Headman() : this(null, null, null, null, null, null) { }
        public Headman(string fio, string male, string pass, string local, string group, Parent obj) 
        :base(fio, male, pass, local, group, obj) { }
    }
    internal class Teacher : IPeople {
        public string FIO { get; set; }
        public string Male { get; set; }
        public string PassportInfo { get; set; }
        public string Localization { get; set; }
        public string Post { get; set; }
        Department department;
        public Teacher() :this(null, null, null, null, null, null) { }
        public Teacher(string fio, string male, string pass, string local, string post, Department obj) {
            FIO = fio;
            Male = male;
            PassportInfo = pass;
            Localization = local;
            Post = post;
            department = obj;
        }
    }
}
