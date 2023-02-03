using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dz03._02._2021 {
    internal class Program {
        static void Task1() {
            Console.WriteLine("\tЗадание 1");
            StringBuilder str = new StringBuilder("Отец ушел за хлебом.");
            Console.WriteLine(str);
            Random rand = new Random();
            str = str.Remove(rand.Next(0, str.Length), 1);
            Console.WriteLine(str);
            Console.WriteLine();
        }
        static void Task2() {
            Console.WriteLine("\tЗадание 2");
            StringBuilder str =  new StringBuilder ("Обезъяна упала с крыши.");
            Console.WriteLine(str);
            str = str.Replace("а", "");
            Console.WriteLine(str);
            Console.WriteLine();
        }
        static void Task3() {
            Console.WriteLine("\tЗадание 3");
            StringBuilder str = new StringBuilder("Жираф ударился шеей об дерево.");
            Console.WriteLine(str);
            Random rand = new Random();
            str = str.Insert(rand.Next(0, str.Length), " бывает ");
            Console.WriteLine(str);
            Console.WriteLine();
        }
        static void Task4() {
            Console.WriteLine("\tЗадание 4");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string str2 = "";
            for (short i = 0; i < str.Length; i++) {
                if (str[i] != ' ') {
                    str2 += str[i];
                }
                for (short j = 0; j < str2.Length; j++) {
                    if (str2[j] != str2[str2.Length - j - 1])
                        Console.WriteLine("Слово {0} не полиндром.", str2);
                    else
                        Console.WriteLine("Слово {0} полиндром.", str2);
                    str2 = "";
                }
            }
            Console.WriteLine();
        }
        static void Task5() {
            Console.WriteLine("\tЗадание 5");
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            string[] TextArr = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("В веденном предложении {0} слов.", TextArr.Length);
        }
        static void Task6() {
            Console.WriteLine("\tЗадание 6");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.Write("Введите слово, которое нужно найти в тексте: ");
            string find = Console.ReadLine();
            Console.Write("Введите слово, которым нужно заменить найденое слово: ");
            string change = Console.ReadLine();
            if (text.Contains(find)) {
                text = text.Replace(find, change);
                Console.WriteLine("Результат: {0}", text);
            }
            else
                Console.WriteLine("Слово не было найдено.");
            Console.WriteLine();
        }
        static void Task7() {
            Console.WriteLine("\tЗадание 7");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] TextArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(short i = 0; i < TextArr.Length; i++) {
                (TextArr[i], TextArr[i + 1]) = (TextArr[i+1], TextArr[i]);
                Console.Write(TextArr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Task8() {
            Console.WriteLine("\tЗадание 8");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string glas = "йуеыаоэяию";
            string[] TextArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string temp = "";
            short GlasIndex = 0;
            for(short i = 0; i < TextArr.Length; i++) {
                temp = TextArr[i];
                for(short j = 0; j < glas.Length;j++) {
                    if (temp[temp.Length - 1] == glas[j]) {
                        GlasIndex++;
                    }
                }
            }
            Console.WriteLine("Количество слов занакчивающееся на гласную: {0}", GlasIndex);
            Console.WriteLine();
        }
        static void Main(string[] args) {
            Program.Task1();
            Program.Task2();
            Program.Task3();
            Program.Task4();
            Program.Task5();
            Program.Task6();
            Program.Task7();
            Program.Task8();
            Console.ReadKey();
        }
    }
}
