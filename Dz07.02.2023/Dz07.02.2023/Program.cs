using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz07._02._2023 {
    internal class Program {
        static void Main(string[] args) {
            MyVector obj1 = new MyVector();
            obj1.Input();
            MyVector obj2 = new MyVector();
            obj2.Input();
            Console.WriteLine("Длина 1 вектора: {0:F3}", obj1.VectorLength());
            Console.WriteLine("Сумма векторов: " + obj1.Sum(obj2));
            Console.WriteLine("Разность векторов: " + obj1.Minus(obj2));
            Console.WriteLine("Произведение векторов: " + obj1.Mult(obj2));
            Console.WriteLine("Скалярное произведение векторов: " + obj1.ScalMult(obj2));
            Console.WriteLine("Косинус угла между векторами: {0:F3}", obj1.CornerCos(obj2));
            if (obj1.Equals(obj2))
                Console.WriteLine("Векторы равны.");
            else
                Console.WriteLine("Векторы не равны.");
            Console.ReadKey();
        }
    }
}
