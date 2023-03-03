using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Laba03._03._2023 {
    internal class Program {
        static void ExtraTask() {
            Console.Write("Напишите эл. почту: ");
            string text = Console.ReadLine();
            string pattern = @"^(\D)(\d)@gmail.com$";
            Regex temp = new Regex(pattern);
            if (temp.IsMatch(text)) Console.WriteLine("Введено правильно!");
            else Console.WriteLine("Неправильный формат эл. почты!");
            //-------------------------------------------------------
            text = "+38098-499-40-84";
            string text2 = "38098-499-40-84";
            pattern = @"^(+380)(\d{2})(-)(\d{3})(-)(\d{2})(-)(\d{2})";
            temp = new Regex(pattern);
            if (temp.IsMatch(text)) Console.WriteLine("Введено правильно!");
            else Console.WriteLine("Неправильный формат эл. почты!");
        }
        static void Task1() {
            Console.Write("Введите IP: ");
            string ip = Console.ReadLine();
            string pattern = @"(\d{3})([.])(\d{3})([.])(\d{3})([.])(\d{3})";
            Regex temp = new Regex(pattern);
            if (temp.IsMatch(ip)) Console.WriteLine("Правильно.");
            else Console.WriteLine("Неправильно.");
        }
        static void Task2() {
            Console.WriteLine("Введите: ");
            string text = Console.ReadLine();
            string glas = "ЯУЮОЕЁЭИЫяуюоеёэиы";
            int count = 0;
            for(int i = 0; i < text.Length; i++) {
                for(int j = 0; j < glas.Length; j++)
                    if (text[i] == glas[j]) count++;
            }
            Console.WriteLine($"Кол-во гласных букв: {count}.");
        }
        static void Task3() {
            Console.WriteLine("Введите url: ");
            string url = Console.ReadLine();
            string pattern = @"(\w{2,3})([.])(\w+)(\w{2,4})([/])(\w+)([/])(\w+)";
            Regex temp = new Regex(pattern);
            if (temp.IsMatch(url)) Console.WriteLine("Правильно.");
            else Console.WriteLine("Неравильно.");
        }
        static void Task4() {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            string pattern = @"\w+";
            Regex temp = new Regex(pattern);
            if (temp.IsMatch(text)) Console.WriteLine("Правильно.");
            else Console.WriteLine("Неравильно.");
        }
        static void Task5() {
            Console.WriteLine("Введите время: ");
            string time = Console.ReadLine();
            string pattern = @"^(([01][0-9])|([02][0-3]))(:|\.)([0-5][0-9])(:|\.)([0-5][0-9])$";
            Regex temp = new Regex(pattern);
            if (temp.IsMatch(time)) Console.WriteLine("Правильно.");
            else Console.WriteLine("Неравильно.");
        }
        static void Task6() {
            Console.WriteLine("Введите почтовый индекс США: ");
            string index = Console.ReadLine();
            string pattern = @"^(\d{1,5})(-)(\d{1,4})$";
            Regex temp = new Regex(pattern);
            if (temp.IsMatch(index)) Console.WriteLine("Правильно.");
            else Console.WriteLine("Неравильно.");
        }
        static void Main(string[] args) {
            //ExtraTask();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Console.ReadKey();
        }
    }
}
