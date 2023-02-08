using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz08._02._2023 {
    internal class Logic {
        string text;
        internal Logic() {
            text = null;
        }
        internal void Input() {
            try {
                Console.Write("Введите выражение:");
                text = Console.ReadLine();
                for(short i = 0; i < text.Length; i++) {
                    if (char.IsLetter(text[i])) throw new Exception("Исключение: буквы не доступны в выражении!");
                    break;
                }
            }
            catch(Exception ex1) { Console.WriteLine(ex1); }
        }
        internal void Count() {
            string[] chis1 = new string[text.Length];
            string[] chis2 = new string[text.Length];
            for(short i = 0; i < text.Length; i++){
                if (char.IsNumber(text[i])) chis1[i] = text[i].ToString();
            }
            string TempChis1 = string.Join(" ", chis1);
            int num1 = Convert.ToInt32(TempChis1);
            for (short i = 0; i < text.Length; i++){
                if (!char.IsNumber(text[i]) && char.IsNumber(text[i + 1])) chis2[i] = text[i].ToString();
            }
            string TempChis2 = string.Join(" ", chis2);
            int num2 = Convert.ToInt32(TempChis2);
            if(num1 > num2) {
                Console.WriteLine("Первое число больше второго.");
            }
            else if(num1 < num2) {
                Console.WriteLine("Первое число меньше второго.");
            }
            else if (num1 >= num2){
                Console.WriteLine("Первое число больше либо равно второго.");
            }
            else if (num1 <= num2) {
                Console.WriteLine("Первое число меньше либо равно второго.");
            }
            else if(num1 == num2) {
                Console.WriteLine("Числа равны.");
            }
        }
    }
}
