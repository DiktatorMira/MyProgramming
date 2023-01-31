using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz31._01._2023
{
    internal class Program
    {
        static void Task1()
        {
            Console.Write("Введите число от 1 до 100: ");
            int chis;
            do
            {
                chis = int.Parse(Console.ReadLine());
                if (chis < 0 && chis > 100)
                {
                    Console.WriteLine("Неправильное число!");
                    Console.Clear();
                }
                else
                {
                    break;
                }
            } while (true);
            if (chis % 3  == 0 && chis % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (chis % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (chis % 3 != 0 && chis % 5 != 0) {
                Console.WriteLine(chis);
            }
            else if (chis % 3 != 0 && chis % 5 == 0) {
                Console.WriteLine(chis);
            }
        }
        static void Task2()
        {
            Console.Write("Введите 1 число: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            float num2 = float.Parse(Console.ReadLine());
            num2 /= 100;
            float res = num1 * num2;
            Console.WriteLine("Ваш ответ: " + res);
        }
        static void Task3()
        {
            Console.Write("Введите 1 число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Введите 4 число: ");
            int num4 = int.Parse(Console.ReadLine());
            int[] number = new int[4] { num1, num2, num3, num4 };
            for(short i = 0; i <number.Length; i++)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
        static void Task4()
        {
            Console.Write("Введите шестизначное число: ");
            int SixNum = int.Parse(Console.ReadLine());
            int FirstChif = SixNum / 100000;
            int SecondChif = SixNum / 10000 % 10;
            int ThirdChif = SixNum / 1000 % 10;
            int FourthChif = SixNum / 100 % 10;
            int FifthChif = SixNum % 100 / 10;
            int SixthChif = SixNum % 10;
            Console.Write("Введите какие цифры в числе хотите поменять(1 - 6): ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int[] number = new int[6] { FirstChif, SecondChif, ThirdChif, FourthChif, FifthChif, SixthChif };
            int temp = number[num1 - 1];
            number[num1 - 1] = number[num2 - 1];
            number[num2 - 1] = temp;
            for (short i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
        static void Task5()
        {
            Console.Write("Введите месяц(1-12): ");
            int date = int.Parse(Console.ReadLine());
            if(date == 12 && date == 1 && date == 2)
            {
                Console.WriteLine("Зима");
            }
            else if(date >= 3 && date <= 5)
            {
                Console.WriteLine("Весна");
            }
            else if(date >=6 && date <= 8)
            {
                Console.WriteLine("Лето");
            }
            else if (date >= 9 && date <= 11)
            {
                Console.WriteLine("Осень");
            }
        }
        static void Task6()
        {
            Console.Write("Введите значение температуры: ");
            double temp = double.Parse(Console.ReadLine());
            Console.Write("Введите 1 - цельсии; 2 - фаренгейты: ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    temp = temp * 1.8 + 32;
                    break;
                case 2:
                    temp = (temp - 32) * 5 / 9;
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение!");
                    break;
            }
            Console.WriteLine("Ответ: " + temp);
        }
        static void Task7()
        {
            Console.Write("Введите 1е число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2е число: ");
            int num2 = int.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                int k = num1;
                num1 = num2;
                num2 = k;
            }
            int[] mass = new int[num2 - num1 + 1];
            for(int i = 0; i < mass.Length; i++)
            {
                mass[i] = 11 + i;
                if (mass[i] % 2 == 0)
                {
                    Console.Write(mass[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Program.Task1();
            //Program.Task2();
            //Program.Task3();
            //Program.Task4();
            //Program.Task5();
            //Program.Task6();
            //Program.Task7();
        }
    }
}
