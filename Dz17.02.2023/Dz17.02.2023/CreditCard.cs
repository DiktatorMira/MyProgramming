using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz17._02._2023 {
    internal class CreditCard {
        public string FIO { get; set; }
        public string Srok { get; set; }
        public int PIN { get; set; }
        public int Credit { get; set; }
        public int Money { get; set; }
        public CreditCard() :this(null, null, 0, 0, 0) { }
        public CreditCard(string fio, string srok, int pin, int credit, int money) {
            FIO = fio;
            Srok = srok;
            PIN = pin;
            Credit = credit;
            Money = money;
        }
        public void MoneyPlus(int value) => Money += value;
        public void MoneyMinus(int value) => Money -= value;
        public void CreditMoney() {
            if(Money <= 0) {
                Money = 0;
                Console.WriteLine("Старт кредитных денег.");
            }
        }
        public void CheckMoney(int value) {
            if (Money >= value) Console.WriteLine("Вы достигли суммы денег.");
        }
        public void SetNewPin(int value) => PIN = value;
    }
}
