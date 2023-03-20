using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    internal class Program {
        static void Main(string[] args) {
            Slovar obj = new Slovar();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("Здравия желаю, перед вами приложение\n\"Словарь\"разработанное @diktator_mira");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Выберите какой словарь вы хотите(Он будет автоматически загружен из файла): ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********************************");
            Console.WriteLine("1 - Англо-русский\n2 - Русско-английский\n3 - Украино-русский\n4 - Русско-украинский");
            Console.WriteLine("********************************\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Введите действие: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int choose = int.Parse(Console.ReadLine());
            do {
                bool Znach = false;
                switch (choose) {
                    case 1:
                        obj.LoadFromFile("EngRus");
                        Znach = true;
                        break;
                    case 2:
                        obj.LoadFromFile("RusEng");
                        Znach = true;
                        break;
                    case 3:
                        obj.LoadFromFile("UkrRus");
                        Znach = true;
                        break;
                    case 4:
                        obj.LoadFromFile("RusUkr");
                        Znach = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Введено неправильное значение!");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("  ---> 1");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 2");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 3");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                if (Znach == true) break;
            } while (true);
            do {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tВыберите действие: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("********************************");
                Console.WriteLine("1 - Показать словарь в консоли");
                Console.WriteLine("2 - Добавить новые слова и перевод в словарь");
                Console.WriteLine("3 - Сохранить словарь в файл");
                Console.WriteLine("4 - Загрузить словарь из своего файла");
                Console.WriteLine("5 - Удалить слово и перевод из словаря");
                Console.WriteLine("6 - Изменить перевод в словаре");
                Console.WriteLine("7 - Изменить слово, для перевода, в словаре");
                Console.WriteLine("8 - Сохранить отдельную строчку в словаре в свой файл");
                Console.WriteLine("9 - Найти строчку в словаре по слову");
                Console.WriteLine("10 - Найти строчку в словаре по переводу");
                Console.WriteLine("********************************");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Выберите действие: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                choose = int.Parse(Console.ReadLine());
                switch (choose) {
                    case 1:
                        obj.Show();
                        break;
                    case 2:
                        obj.Input();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите имя файла для сохранения: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.SaveToFile(Console.ReadLine());
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите имя своего файла, для загрузки из него: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.LoadFromFile(Console.ReadLine());
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Введите индекс строчки для удаления: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.DeleteWorld(int.Parse(Console.ReadLine()));
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите индекс строчки для изменения перевода: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.EditTranslate(int.Parse(Console.ReadLine()));
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите индекс строчки для изменения cлова: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.EditWord(int.Parse(Console.ReadLine()));
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите имя файла, для сохранения строчки в файл: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string name = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите индекс строчки для сохранения в файл: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.SaveLineToFile(int.Parse(Console.ReadLine()), name);
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите слово, для поиска строчки: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.FindByWord(Console.ReadLine());
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("Введите перевод, для поиска строчки: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        obj.FindByTranslate(Console.ReadLine());
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Введено неправильное значение!\n");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Хотите ли вы продолжить?(0 - нет, 1 - да): ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                int menu = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("  ---> 1");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 2");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 3");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                if (menu == 0) break;
            } while (true);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
