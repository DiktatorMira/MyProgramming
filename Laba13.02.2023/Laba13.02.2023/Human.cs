using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba13._02._2023
{
    internal class Human
    {
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal Human() : this("Human", 0) { }
        internal Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        internal virtual void Print() => Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\n");
        public override string ToString() { return $"Имя: {Name}\nВозраст: {Age}\n"; }
    }
    internal class Builder : Human {
        internal string Company { get; set; }
        internal Builder(string name, int age, string comp) : base(name, age) => Company = comp;
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Компания: {Company}\n");
        }
        public override string ToString() { return base.ToString() + $"Компания: {Company}\n"; }
    }
    internal class Sailor : Human {
        internal string Experience { get; set; }
        internal Sailor(string name, int age, string exp) : base(name, age) => Experience = exp;
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Стаж работы: {Experience}\n");
        }
        public override string ToString() { return base.ToString() + $"Стаж работы: {Experience}\n"; }
    }
    internal class Pilot : Human {
        internal int FlightHours { get; set; }
        internal Pilot(string name, int age, int hours) : base(name, age) => FlightHours = hours;
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Часов полета: {FlightHours}\n");
        }
        public override string ToString() { return base.ToString() + $"Часов полета: {FlightHours}\n"; }
    }
}
