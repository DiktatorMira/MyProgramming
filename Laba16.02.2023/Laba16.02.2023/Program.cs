using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba16._02._2023 {
    internal class Program {
        static void Main(string[] args) {
            //Fractional obj1 = new Fractional(4,5);
            //Fractional obj2 = new Fractional(3,4);
            //Console.WriteLine("Сложение: " + obj1.Plus(obj2));
            //Console.WriteLine("Вычитание: " + obj1.Minus(obj2));
            //Console.WriteLine("Умножение: " + obj1.Mult(obj2));
            //Console.WriteLine("Деление: " + obj1.Divide(obj2));
            DateOfBirth date = new DateOfBirth(2004, 8, 13);
            Console.WriteLine(date.CheckDayOfWeek());
            Console.WriteLine(date.DaysToBirthday());
            Console.ReadKey();
        }
    }
}
