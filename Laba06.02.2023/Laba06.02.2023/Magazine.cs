using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba06._02._2023 {
    internal class Plane {
        string name, name2, type;
        int year;
        internal string Name {
            get { return name; }
            set { name = value; }
        }
        internal string Name2 {
            get { return name2; }
            set { name2 = value; }
        }
        internal string Type {
            get { return type; }
            set { type = value; }
        }
        internal int Year {
            get { return year; }
            set { year = value; }
        }
        internal Plane() {
            name = name2 = type = null;
            year = 0;
        }
        internal void Input() {
            Console.Write("Введите название cамолета: ");
            name = Console.ReadLine();
            Console.Write("Введите название производителя самолета: ");
            name2 = Console.ReadLine();
            Console.Write("Введите год выпуска самолета: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Введите тип самолета: ");
            type = Console.ReadLine();
        }
        internal void Print() {
            Console.WriteLine($"Название самолета: {name}");
            Console.WriteLine($"Название производителя самолета: {name2}");
            Console.WriteLine($"Год выпуска самолета: {year}");
            Console.WriteLine($"Тип самолета: {type}");
        }
        public override string ToString() {
            return $"Название самолета: {name}\nНазвание производителя самолета: {name2}\nГод выпуска самолета: {year}" +
                $"\nТип самолета: {type}";
        }
    }
}
