using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dz20._02._2023 {
    delegate void MyDelegate();
    internal class CreditCard {
        List<MyDelegate> DlgList = new List<MyDelegate>();
        public event MyDelegate evnt {
            add { DlgList.Add(value); }
            remove { DlgList.Remove(value);}
        }
        public string FIO { get; set; }
        public string Srok { get; set; }
        public int Pin { get; set; }
        public int CreditLimit { get; set; }
        public int Money { get; set; }
        public CreditCard() :this(null, null, 0, 0, 0) { }
        public CreditCard(string fio, string srok, int pin, int credit, int money) {
            FIO = fio;
            Srok = srok;
            Pin = pin;
            CreditLimit = credit;
            Money = money;
        }
        internal void Print() {
            Console.WriteLine($"ФИО владельца: {FIO}");
            Console.WriteLine($"Срок действия карты: {Srok}");
            Console.WriteLine($"Пин-код: {Pin}");
            Console.WriteLine($"Кредитный лимит: {CreditLimit}");
            Console.WriteLine($"Баланс: {Money}$");
        }
        public void PlusMoney() {
            Console.Write("Введите сумму, которую хотите добавить: ");
            int value = int.Parse(Console.ReadLine());
            Money += value;
        }
        public void MinusMoney() {
            Console.Write("Ввеите пин-код перед оплатой: ");
            int pin = int.Parse(Console.ReadLine());
            if (pin != Pin) {
                Console.WriteLine("Отказано в доступе(неправильный пин).");
                return;
            }
            Console.Write("Введите сумму, которую хотите расходовать: ");
            int value = int.Parse(Console.ReadLine());
            Money -= value;
        }
        public void StartCredit() => Console.WriteLine("Начало использование кредитного лимита.");
        public void MoneyGoal() {
            Console.Write("Введите сумму для достижения: ");
            int value = int.Parse(Console.ReadLine());
            if (Money < value) Console.WriteLine("Вы не достигли нужной суммы.");
            else Console.WriteLine("Вы достигли суммы!");
        }
        public void ChangePin() {
            Console.Write("Введите старый пин для подтверждения смены: ");
            int check = int.Parse(Console.ReadLine());
            if (check != Pin) {
                Console.WriteLine("Отказано в доступе(неправильный пин).");
                return;
            }
            Console.Write("Введите новый пин: ");
            int value = int.Parse(Console.ReadLine());
            Pin = check;
        }
    }
}
