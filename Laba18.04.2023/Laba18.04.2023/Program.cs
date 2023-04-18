using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba18._04._2023 {
    public class Bank {
        public int Money { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; } 
        public Bank() {
            Money = 100;
            Name = "Артём";
            Percent = 10;
        }
        public static void MoneyPlusChange(object obj) {
            int value = (int)obj;
            Bank bank = (Bank)obj;
            bank.Money += value;
            using (StreamWriter file = new StreamWriter("console.txt", true)) {
                file.WriteLine($"Было добавлено {value} к деньгам.");
            }
        }
        public static void MoneyMinusChange(object obj) {
            int value = (int)obj;
            Bank bank = (Bank)obj;
            bank.Money -= value;
            using (StreamWriter file = new StreamWriter("console.txt", true)) {
                file.WriteLine($"Было отнято {value} к деньгам. Теперь сумма {bank.Money}");
            }
        }
        public static int operator +(Bank obj, int value) {
            Thread thread = new Thread(new ParameterizedThreadStart(MoneyPlusChange));
            thread.IsBackground = true;
            thread.Start();
            return obj.Money += value;
        }
        public static int operator -(Bank obj, int value) {
            Thread thread = new Thread(new ParameterizedThreadStart(MoneyPlusChange));
            thread.IsBackground = true;
            thread.Start();
            return obj.Money -= value;
        }
    }
    internal class Program {
        public static void MyThread() {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++) list.Add(rand.Next(0, 10));
            foreach (int i in list) Console.Write(i.ToString() + " ");
            Console.WriteLine();
        }
        static void Task1() {
            Thread thread1 = new Thread(new ThreadStart(MyThread));
            thread1.IsBackground = true;
            thread1.Start();
        }
        static void Task2()  {
            Bank bank = new Bank();
            bank.Money += 5;
        }
        static void Main(string[] args) {
            //Task1();
            Task2();
            Console.ReadKey();
        }
    }
}
