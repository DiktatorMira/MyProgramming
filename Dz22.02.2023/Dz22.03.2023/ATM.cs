using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dz22._03._2023 {
    interface IPrint {
       void Print();
    }
    interface IMoney {
        void Convert(ATM obj1, Person obj2);
    }
    internal class Person : IPrint{
        public double Balance { get; set; }
        public Person() : this(0) { }
        public Person(double balance) => Balance = balance;
        public void Print() => Console.WriteLine($"Ваш баланс: {Balance}₴.");
    }
    internal class ATM : IPrint{
        public double Money { get; set; }
        public ATM() : this(0) { }
        public ATM(double money) => Money = money;
        public void Print() => Console.WriteLine($"Количество денег в банке: {Money}₴.");
        internal int WithdrawMoney(Person obj)  {
            Console.Write("Введите какую сумму денег вы хотите снять: ");
            int quan = int.Parse(Console.ReadLine());
            if (quan > Money) Console.WriteLine("Операция отменена, т.к. в банкомате недостаточно денег!");
            else {
                Money -= quan;
                obj.Balance += quan;
                Console.WriteLine("Вы успешно сняли деньги!");
            }
            return quan;
        }
    }
    internal class ElectroCheck :IPrint {
        public void Print() => Console.WriteLine("Распечатан электрический чек.");
    }
    internal class ViberCheck : IPrint {
        public void Print() => Console.WriteLine("Чек отправлен на вайбер.");
    }
    internal class NoCheck : IPrint {
        public void Print() => Console.WriteLine("Чек не распечатан.");
    }
    internal class Grivna : IMoney {
        public void Convert(ATM obj1, Person obj2) {
            Console.Write($"Ваш баланс: {obj2.Balance}₴, Баланс банкомата:{obj1.Money}₴.");
        }
    }
    internal class Dollar : IMoney {
        public void Convert(ATM obj1, Person obj2) {
            Console.Write($"Ваш баланс: {obj2.Balance * 0.027}$, Баланс банкомата:{obj1.Money * 0.027}$.");
        }
    }
    internal class Euro : IMoney {
        public void Convert(ATM obj1, Person obj2) {
            Console.Write($"Ваш баланс: {obj2.Balance * 0.026}€, Баланс банкомата:{obj1.Money * 0.026}€.");
        }
    }
}
