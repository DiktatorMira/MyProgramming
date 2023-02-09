using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz09._02._2023 {
    internal class Magazine {
        string name, description, telephone, email;
        int year, employees;
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal int Year
        {
            get { return year; }
            set { year = value; }
        }
        internal string Description
        {
            get { return description; }
            set { description = value; }
        }
        internal string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        internal string Email
        {
            get { return email; }
            set { email = value; }
        }
        internal int Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        internal Magazine()
        {
            name = description = telephone = email = null;
            year = employees = 0;
        }
        internal void Input()
        {
            Console.Write("Введите название журнала: ");
            name = Console.ReadLine();
            Console.Write("Введите год выпуска журнала: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Введите описание журнала: ");
            description = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            telephone = Console.ReadLine();
            Console.Write("Введите контактную почту: ");
            email = Console.ReadLine();
            Console.Write("Введите кол-во сотрудников: ");
            employees = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        internal void Print()
        {
            Console.WriteLine($"Название журнала: {name}");
            Console.WriteLine($"Год выпуска журнала: {year}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Контактный телефон: {telephone}");
            Console.WriteLine($"Контактная почта: {email}");
            Console.WriteLine($"Количество сотрудников: {employees}");
        }
        public static Magazine operator +(Magazine obj1, int value) {
            Magazine result = new Magazine();
            result.employees = obj1.employees + value;
            return result;
        }
        public static Magazine operator -(Magazine obj1, int value) {
            Magazine result = new Magazine();
            result.employees = obj1.employees - value;
            return result;
        }
        public static bool operator >(Magazine obj1, Magazine obj2) {
            if (obj1.employees > obj2.employees)
                return true;
            else
                return false;
        }
        public static bool operator <(Magazine obj1, Magazine obj2) { return !(obj1.employees > obj2.employees); }
        public static bool operator ==(Magazine obj1, Magazine obj2) {
            if (obj1.employees == obj2.employees)
                return true;
            else
                return false;
        }
        public static bool operator !=(Magazine obj1, Magazine obj2) { return !(obj1.employees == obj2.employees); }
    }
}
