using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    internal class EngRus {
        public List<Tuple<string, string>> MyDictionary { get; set; }
        public int Count { get; set; }
        public EngRus() {
            MyDictionary = new List<Tuple<string, string>>();
            Count = MyDictionary.Count;
        }
        public Tuple<string, string> GetList(int index) {
            if (index < 0 || index >= Count) throw new Exception("Выход за пределы List!");
            return MyDictionary[index];
        }
        public void AddTranslate(string EngWord, string RusWord) {
            MyDictionary.Add(Tuple.Create(EngWord, RusWord));
            Count = MyDictionary.Count;
        }
        public void Input() {
            bool IsRepeat = false;
            do {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\nДобавьте новое слово в словарь: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string text1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Добавьте вариант(ы) перевода слова: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string text2 = Console.ReadLine();
                if((text1 == "Паляниця" && text2 == "клубника") || (text1 == "Клубника" && text2 == "паляниця")) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t==>|До вас прямує наряд СБУ!");
                }
                for(int i = 0; i < MyDictionary.Count; i++) {
                    if (MyDictionary[i].Item1 == text1) {
                        MyDictionary[i] = Tuple.Create(text1, text2);
                        IsRepeat = true;
                        break;
                    }
                }
                if(IsRepeat == false) MyDictionary.Add(Tuple.Create(text1, text2));
                Count = MyDictionary.Count;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Хотите ли вы продолжить?(0 - нет, 1 - да): ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                int choose = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("  ---> 1");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 2");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 3");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.ResetColor();
                IsRepeat = false;
                if (choose == 0) break;
            } while(true);
        }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n*********************");
            for (int i = 0; i < MyDictionary.Count; i++) Console.WriteLine($"{MyDictionary[i].Item1} - {MyDictionary[i].Item2}");
            Console.WriteLine("*********************\n");
            Console.ResetColor();
        }
        public void SaveToFile(string file_name) {
            StreamWriter file = new StreamWriter(file_name + ".log", false);
            for(int i = 0; i < Count; i++)
                file.WriteLine(MyDictionary[i].Item1 + " - " + MyDictionary[i].Item2);
            file.Close();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Словарь успешно сохранен в файл!\n");
            Console.ResetColor();
        }
        public void LoadFromFile(string file_name) {
            MyDictionary.Clear();
            StreamReader file = new StreamReader(file_name + ".log", Encoding.UTF8);
            while (file.EndOfStream != true) {
                string buff = file.ReadLine();
                string buff2 = buff.Substring(0, buff.IndexOf("-") - 1);
                string buff3 = buff.Substring(buff.IndexOf("-") + 2, buff.Length - (buff.IndexOf("-") + 2));
                MyDictionary.Add(Tuple.Create(buff2, buff3));
            }
            file.Close();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--> Словарь успешно загружен из файла!\n");
            Console.ResetColor();
        }
        public void DeleteWorld(int index) {
            MyDictionary.RemoveAt(index);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*****************************\n");
            Console.WriteLine("Слово и перевод были удалены.\n");
            Console.WriteLine("*****************************\n");
            Console.ResetColor();
        }
        public void EditTranslate(int index) {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Введите новые перевод(ы) слова: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            MyDictionary[index] = Tuple.Create(MyDictionary[index].Item1, Console.ReadLine());
            Console.ResetColor();
        }
        public void EditWord(int index) {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Введите новое слово, которое нужно перевести: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            MyDictionary[index] = Tuple.Create(Console.ReadLine(), MyDictionary[index].Item2);
            Console.ResetColor();
        }
        public void SaveLineToFile(int index, string file_name) {
            StreamWriter file = new StreamWriter(file_name + ".log", false);
            file.WriteLine(MyDictionary[index].Item1 + " - " + MyDictionary[index].Item2);
            file.Close();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-->Файл успешно сохранен!\n");
            Console.ResetColor();
        }
        public void FindByWord(string word) {
            bool IsFind = false;
            for(int i = 0; i < MyDictionary.Count; i++) {
                if (MyDictionary[i].Item1.Contains(word)) {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"\nСлово было найдено под индексом {i}:");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($" {MyDictionary[i].Item1} - {MyDictionary[i].Item2}\n");
                    IsFind = true;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (IsFind == false) Console.WriteLine("\nСлово не было найдено.");
            Console.ResetColor();
        }
        public void FindByTranslate(string word) {
            bool IsFind = false;
            for (int i = 0; i < MyDictionary.Count; i++) {
                if (MyDictionary[i].Item2.Contains(word)) {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"\nПеревод был найден под индексом {i}:");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($" {MyDictionary[i].Item1} - {MyDictionary[i].Item2}\n");
                    IsFind = true;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (IsFind == false) Console.WriteLine("\nПеревод не был найден.");
            Console.ResetColor();
        }
        public IEnumerator GetEnumerator() {
            for(int i = 0; i < MyDictionary.Count; i++)
                yield return MyDictionary[i].Item1 + " - " + MyDictionary[i].Item2;
        }
    }
}
