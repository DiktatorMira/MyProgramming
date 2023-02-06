using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz06._02._2023 {
    internal class Magazine {
        string name, description, telephone, email;
        int year;
        internal string Name {
            get { return name; }
            set { name = value; }
        }
        internal int Year {
            get { return year; }
            set { year = value; }
        }
        internal string Description {
            get { return description; }
            set { description = value; }
        }
        internal string Telephone {
            get { return telephone; }
            set { telephone = value; }
        }
        internal string Email {
            get { return email; }
            set { email = value; }
        }
        internal Magazine() {
            name = description = telephone = email = null;
            year = 0;
        }
        internal void Input() {
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
            Console.WriteLine();
        }
        internal void Print() {
            Console.WriteLine($"Название журнала: {name}");
            Console.WriteLine($"Год выпуска журнала: {year}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Контактный телефон: {telephone}");
            Console.WriteLine($"Контактная почта: {email}");
        }
    }
}
