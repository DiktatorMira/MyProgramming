using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz22._03._2023 {
    internal class ATM {
        public double Money { get; set; }
        Person[] human;
        public ATM() : this(0) { }
        public ATM(double money) => Money = money;
        public void ShowMoney() => Console.WriteLine($"Количество денег в банке: {Money} грн.");
    }
    internal class Person :ATM {
        public double Balance { get; set; }
        public Person() :this(0, 0){ }
        public Person(double money, double balance) :base(money) => Balance = balance;
        internal void WithdrawMoney() {
            Console.Write("Введите какую сумму денег вы хотите снять: ");
            int quan = int.Parse(Console.ReadLine());
            if (quan > Money) Console.WriteLine("Операция отменена, т.к. в банкомате недостаточно денег!");
            else {
                Money -= quan;
                Balance += quan;
                Console.WriteLine("Вы успешно сняли деньги!");
            }
            Console.Write("Хотите напечатать чек?(1-да, 0-нет): ");
            short choose = short.Parse(Console.ReadLine());
            switch (choose) {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"Вы сняли {quan} грн. Ваш баланс {Balance} грн.");
                    break;
                default:
                    Console.WriteLine("Ошибка: Было введено не то значение!");
                    break;
            }
        }
        internal void Print() {
            ShowMoney();
            Console.WriteLine($"Ваш баланс: {Balance} грн.");
        }
    }
    internal class Currency : Person {
        public void ChooseCur() {
            Console.WriteLine("Выберите валюту(1-доллары, 2 гривны, 3-евро): ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose) {
                case 1:
                    Console.WriteLine($"Ваш баланс: {Balance * 0,027}$, Баланс банкомата:{Money * 0,027}$.");
                    break;
                case 2:
                    Console.WriteLine($"Ваш баланс: {Balance} грн, Баланс банкомата:{Money} грн.");
                    break;
                case 3:
                    Console.WriteLine($"Ваш баланс: {Balance * 0,026} евро, Баланс банкомата:{Money * 0,026} евро.");
                    break;
                default:
                    Console.WriteLine("Вы выбрали неверное значение!");
                    break;
            }
        }
    }
}
