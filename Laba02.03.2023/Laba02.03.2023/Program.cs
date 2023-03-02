using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Laba02._03._2023 {
    internal class Program {
        static void Task1() {
            int[] Nums = new int[100];
            Random rand = new Random();
            for(int i = 0; i < Nums.Length; i++)
                Nums[i] = rand.Next(1, 100);
            StreamWriter file1 = new StreamWriter("Simple numbers.log", false);
            foreach(int i in Nums) {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0) break;
                    else file1.Write(i + " ");
            }
            file1.Close();
            StreamWriter file2 = new StreamWriter("Fibonacci numbers.log", false);
            foreach(int i in Nums) {
                int j, y, z, b;
                y = z = b = 1;
                bool q = false;
                for(int k = 0; k < Nums[i]; k++) {
                    z = y;
                    y = b;
                    b = z + y;
                    if (b == Nums[i]) q = true;
                }
                if(q) file2.Write(i + " ");
            }
            file2.Close();
            foreach(int i in Nums) Console.Write(i + " ");
        }
        static void Task2() {
            StreamReader file = new StreamReader("Text.txt", Encoding.UTF8);
            Console.Write("Введите слово для поиска в файле: ");
            string find = Console.ReadLine();
            Console.Write("Введите слово для подмены: ");
            string change = Console.ReadLine();
            string text = "";
            while(file.Peek() >= 0) {
                Console.WriteLine(file.ReadLine());
                text += file.ReadLine();
            }
            file.Close();
            text = text.Replace(find, change);
            Console.WriteLine(text);
        }
        static void Task3() {
            StreamReader modfile = new StreamReader("Moder.txt", Encoding.UTF8);
            string moder = modfile.ReadLine();
            string[] ModWords = moder.Split(new char[] { ' ' });
            StreamReader file = new StreamReader("Text2.txt", Encoding.UTF8);
            string result = file.ReadToEnd();
            modfile.Close();
            file.Close();
            string zvezd = "";
            for(int i = 0; i < ModWords[0].Length; i++) zvezd += "*";
            for(int i = 0; i < result.Length; i++)  {
                if (result.Contains(ModWords[0]))
                    result = result.Replace(ModWords[0], zvezd);
            }
            zvezd = string.Empty;
            for (int i = 0; i < ModWords[1].Length; i++) zvezd += "*";
            for (int i = 0; i < result.Length; i++) {
                if (result.Contains(ModWords[1]))
                    result = result.Replace(ModWords[1], zvezd);
            }
            Console.WriteLine(result);
        }
        static void Task4() {
            StreamReader file = new StreamReader("Text3.txt", Encoding.UTF8);
            string text = file.ReadLine();
            file.Close();
            Console.WriteLine(text);
            string result = new string(text.ToCharArray().Reverse().ToArray());
            Console.WriteLine(result);
            StreamWriter reverse = new StreamWriter("Reverse.log", false);
            reverse.WriteLine(result);
            reverse.Close();
        }
        static void Task5() {
            StreamWriter file = new StreamWriter("Numbers.log", false);
            Random rand = new Random();
            for(int i = 0; i <= 100000; i++) file.Write(rand.Next(-99999, 99999) + " ");
            file.Close();
            StreamReader nums = new StreamReader("Numbers.log", Encoding.UTF8);
            StreamWriter pos = new StreamWriter("Positive numbers.log", false);
            StreamWriter neg = new StreamWriter("Negative numbers.log", false);
            StreamWriter two = new StreamWriter("Two-digit numbers.log", false);
            StreamWriter five = new StreamWriter("Five-digit numbers.log", false);
            string numbers = nums.ReadToEnd();
            nums.Close();
            string[] NumArr = numbers.Split(new char[] { ' ' });
            long[] Numbers = new long[NumArr.Length];
            long positive = 0, negative = 0, two_digit = 0, five_digit = 0;
            for (int i = 0; i < NumArr.Length; i++) {
                Numbers[i] = Convert.ToInt64(Numbers[i]);
                if (Numbers[i] > 0) {
                    pos.Write(Numbers[i] + " ");
                    positive++;
                }
                if (Numbers[i] < 0) {
                    neg.Write(Numbers[i] + " ");
                    negative++;
                }
                if (Numbers[i] >= 10 && Numbers[i] <= 99 && Numbers[i] >= -99 && Numbers[i] <= -10) {
                    two.Write(Numbers[i] + " ");
                    two_digit++;
                }
                if (Numbers[i] >= 10000 && Numbers[i] <= 99999 && Numbers[i] >= -99999 && Numbers[i] <= -10000) {
                    five.Write(Numbers[i] + " ");
                    five_digit++;
                }
            }
            pos.Close();
            neg.Close();
            two.Close();
            five.Close();
            Console.WriteLine($"Количество положительный чисел: {positive}");
            Console.WriteLine($"Количество отрицательных чисел: {negative}");
            Console.WriteLine($"Количество двузначных чисел: {two_digit}");
            Console.WriteLine($"Количество пятизначных чисел: {five_digit}");
        }
        static void Main(string[] args) {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
            Console.ReadKey();
        }
    }
}
