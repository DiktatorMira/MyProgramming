using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laba01._02._2023 {
    internal class Program {
        static void PredTask() {
            Console.WriteLine("\tПодзадание");
            int[] arr = new int[10];
            Random rand = new Random();
            for (short i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 20);
            foreach (int i in arr)
                Console.Write("{0, 4}", i);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Task1() {
            Console.WriteLine("\tЗадание 1");
            int[] arr = new int[10];
            Random rand = new Random();
            for (short i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 20);
            foreach(int i in arr) {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            Console.Write("Четные числа массива: ");
            foreach (int i in arr) {
                if (i % 2 == 0) {
                    Console.Write("{0, 4}", i);
                }
            }
            Console.WriteLine();
            Console.Write("Нечетные числа массива: ");
            foreach (int i in arr) {
                if (i % 2 != 0) {
                    Console.Write("{0, 4}", i);
                }
            }
            Console.WriteLine();
            Console.Write("Уникальные числа массива: ");
            for (short i = 0; i < arr.Length; i++) {
                int elem = arr[i];
                bool Equal = false;
                for(short j = 0; j < arr.Length; j++) {
                    if(i == j) {
                        continue;
                    }
                    if(elem == arr[j] && i != j) {
                        Equal = true;
                    }
                }
                if (Equal == false) {
                    Console.Write("{0, 4}", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Task2() {
            Console.WriteLine("\tЗадание 2");
            int[] arr = new int[10];
            Random rand = new Random();
            for (short i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 20);
            Console.Write("Введите кол-во элементов для вывода 1-10!: ");
            int size = int.Parse(Console.ReadLine());
            if(size <= 10 && size >= 1) {
                for(short i = 0; i < size; i++)
                    Console.Write("{0, 4}", arr[i]);
                Console.WriteLine();
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Молодец, ты ввел неправильное число.");
                Console.WriteLine();
            }
        }
        static void Task3() {
            Console.WriteLine("\tЗадание 3");
            Console.Write("Введите 1 число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int num3 = int.Parse(Console.ReadLine());

            int[] arr = new int[10];
            Random rand = new Random();
            for (short i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 20);
            int kol = 0;
            for(short i = 0; i < arr.Length; i++) {
                if (num1 == arr[i] && num2 == arr[i + 1] && num3 == arr[i + 2]){
                    kol++;
                }
            }
            Console.WriteLine("Введенные числа встречались " + kol + " раз подряд.");
            Console.WriteLine();
        }
        static void Task4() {
            Console.WriteLine("\tЗадание 4");
            int[] arr1 = new int[10];
            int[] arr2 = new int[20];
            int[] arr3 = new int[10];
            Random rand = new Random();
            for (short i = 0; i < arr1.Length; i++)
                arr1[i] = rand.Next(1, 20);
            for (short i = 0; i < arr2.Length; i++)
                arr2[i] = rand.Next(1, 20);
            for(short i = 0; i < arr2.Length; i++) {
                for(short j = 0; j < arr1.Length; j++) {
                    if (arr2[i] == arr1[j]) {
                        arr3[j] = arr1[j];
                        Console.Write("{0, 4}", arr3[j]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Task5() {
            Console.WriteLine("\tЗадание 5");
            int[,] arr = new int[10, 5];
            Random rand = new Random();
            for (short i = 0; i < arr.GetLength(0); i++) {
                for(short j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] = rand.Next(1, 20);
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            int min = arr[0, 0], max = arr[0, 0];
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    if (min > arr[i, j]) {
                        min = arr[i, j];
                    }
                    if(max < arr[i, j]) {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимум массива:" + min);
            Console.WriteLine("Минимум массива:" + min);
            Console.WriteLine();
        }
        static void Task6() {
            Console.WriteLine("\tЗадание 6");
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            int words = 1;
            for (short i = 0; i < text.Length; i++) {
                if (text[i] == ' ') {
                    words++;
                }
            }
            Console.WriteLine("В веденном предложении " + words + " слов(а)(о).");
            Console.WriteLine();
        }
        static void Task7() {
            Console.WriteLine("\tЗадание 7");
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            string text2 = "";
            for(int i = text.Length - 1; i >= 0; i--)
                text2 += text[i];
            Console.WriteLine("Результат: " + text2);
            Console.WriteLine();
        }
        static void Task8() {
            Console.WriteLine("\tЗадание 8");
            string RusGlas = "аоиынэяюй";
            int GlasCol = 0;
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            for(short i = 0; i < text.Length; i++) {
                for(short j = 0; j < RusGlas.Length; j++) {
                    if (text[i] == RusGlas[j]) {
                        GlasCol++;
                    }
                }
            }
            Console.WriteLine("Кол-во гласных букв в тексте: " + GlasCol);
            Console.WriteLine();
        }
        static void Task9() {
            Console.WriteLine("\tЗадание 6");
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            Console.Write("Введите слово для поиска в предложении: ");
            string find = Console.ReadLine();
            string[] TextArr = new string[text.Length];
            for(short i = 0; i < text.Length; i++){
                TextArr[i] = text;
            }
            Console.WriteLine("Искомое слово находится на " + Array.BinarySearch(TextArr, find) + " позиции");
        }
        static void Main(string[] args) {
            Program.PredTask();
            Program.Task1();
            Program.Task2();
            Program.Task3();
            Program.Task4();
            Program.Task5();
            Program.Task6();
            Program.Task7();
            Program.Task8();
            Program.Task9();
        }
    }
}
