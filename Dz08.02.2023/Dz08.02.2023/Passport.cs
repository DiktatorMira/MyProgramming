using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz08._02._2023 {
    internal class Passport {
        string pass_num, fio, pass_date;
        internal Passport() => pass_num = fio = pass_date = null;
        internal Passport(Passport obj) {
            pass_num = obj.pass_num;
            fio= obj.fio;
            pass_date= obj.pass_date;
        }
        internal void Input() {
            try {
                string symbols = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ";
                bool avaible = false;
                Console.Write("Введите номер загранпаспорта: ");
                pass_num = Console.ReadLine();
                try {
                    if (char.IsLetter(pass_num[0]) == false || char.IsLetter(pass_num[1]) == false)
                        throw new Exception("Исключение: номер содержит неправильные символы!");
                }
                catch (Exception ex2) { Console.WriteLine(ex2.Message); }
                if (pass_num.Length != 8) throw new Exception("Исключение: номер содержит неправильное кол-во символов!");
            }
            catch (Exception ex1) { Console.WriteLine(ex1.Message); }
            try {
                Console.Write("Введите ФИО: ");
                fio = Console.ReadLine();
                for(short i = 0; i < fio.Length; i++) {
                    if (!char.IsLetter(fio[i])) throw new Exception("Исключение: Недопустимые символы в ФИО!");
                    break;
                }
                try {
                    short probels = 0;
                    for(short i = 0; i < fio.Length; i++) {
                        if (fio[i] == ' ') probels++;
                    }
                    if (probels != 2) throw new Exception("Исключение: Неправильно написанный формат ФИО!");
                }
                catch (Exception ex4) { Console.WriteLine(ex4.Message); }
            }
            catch(Exception ex3) { Console.WriteLine(ex3.Message); }
            try {
                string BanSymbols = "!@#$%^&*()_+-=[]{}\\|/<>\"~`',;:abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ";
                bool avaible = true;
                Console.Write("Введите дату выдачи через точку: ");
                pass_date = Console.ReadLine();
                for (short i = 0; i < pass_date.Length; i++) {
                    for(short j = 0; j < BanSymbols.Length; j++) {
                        if (pass_date[i] == BanSymbols[j]) avaible = false;
                        break;
                    }
                }
                if (avaible == false) throw new Exception("Исключение: Неправильно введен формат даты!");
                try {
                    if (pass_date.Length != 10) throw new Exception("Исключение: Неправильный размер даты!");
                }
                catch(Exception ex6) { Console.WriteLine(ex6.Message); }
                try {
                    short correct = 0;
                    for(short i = 0; i < pass_date.Length; i++)
                        if (pass_date[i] == '.') correct++;
                    if (correct != 2) throw new Exception("Исключение: Неправильный формат даты!");
                }
                catch(Exception ex7) { Console.WriteLine(ex7.Message); }
            }
            catch(Exception ex5) { Console.WriteLine(ex5.Message); }
        }
    }
}
