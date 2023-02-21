using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz21._02._2023 {
    delegate void MyDelegate1(int num1, int num2, int num3);
    delegate int MyDelegate2(int[] arr);
    delegate bool MyDelegate3(string text, string find);
    internal class Program {
        static MyDelegate1 rgb = (int num1, int num2, int num3) => {
            Console.WriteLine($"Ваш цвет RGB: {num1} {num2} {num3}");
        };
        static MyDelegate2 task3 = (int[] arr) => {
            int quan = 0;
            for(Int16 i = 0; i < arr.Length; i++)
                if (arr[i] % 7 == 0) quan++;
            return quan;
        };
        static MyDelegate2 task4 = (int[] arr) => {
            int quan = 0;
            for (Int16 i = 0; i < arr.Length; i++)
                if (arr[i] >= 0) quan++;
            return quan;
        };
        static MyDelegate2 task5 = (int[] arr) => {
            int quan = 0;
            for (Int16 i = 0; i < arr.Length; i++)
                if (arr[i] < 0) quan++;
            return quan;
        };
        static MyDelegate3 task6 = (string text, string find) => {
            if (text.Contains(find)) return true;
            else return false;
        };
        static void Main(string[] args) {

        }
    }
}
