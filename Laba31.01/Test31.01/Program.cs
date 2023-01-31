using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test31._01 {
    class Program {
        static int Method(int first, int second, int choose){
            int Res = 0;
            switch (choose) {
                case 1:
                    Res = first + second;
                    break;
                case 2:
                    Res = first - second;
                    break;
                case 3:
                    Res = first * second;
                    break;
                case 4:
                    Res = first / second;
                    break;
                default:
                    Console.WriteLine("Введено неправильное число!");
                    break;
            }
            return Res;
        }
        static void Main(string[] args) {
            int Res;
            Console.Write("Введите 1 число: ");
            int FirstNum = int.Parse(Console.ReadLine());

            Console.Write("Введите 2 число: ");
            int SecondNum = int.Parse(Console.ReadLine());

            Console.Write("Введите действие(1 - плюс; 2 - минус; 3 - умножить; 4 - делить): ");
            int Choose = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш ответ: " + Program.Method(FirstNum, SecondNum, Choose));
        }
    }
}
