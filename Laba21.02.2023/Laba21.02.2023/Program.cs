using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Laba21._02._2023 {
    delegate bool MyDelegate1(int num);
    delegate double MyDelegate2(double num);
    delegate int MyDelegate3(int[] arr);
    internal class Program {
        static MyDelegate1 parity = delegate (int num) { return num % 2 == 0; };
        static MyDelegate2 pow = delegate (double num) { return Math.Pow(num, 2); };
        static MyDelegate2 pow2 = (double num) => { return Math.Pow(num, 3); };
        static MyDelegate1 DayProgrammer = (int num) => {
            if (num <= 0 || num >= 365) {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }
            else if (num != 256) return false;
            else return true;
        };
        static MyDelegate3 MaxArr = (int[] arr) => { return arr.Max(); };
        static MyDelegate3 MinArr = (int[] arr) => { return arr.Min(); };
        static MyDelegate3 EvenArrQuan = (int[] arr) => {
            int EvenQuan = 0;
            for(short i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0) EvenQuan++;
            return EvenQuan;
        };
        static void Main(string[] args) {
            Console.WriteLine(parity(11));
        }
    }
}
