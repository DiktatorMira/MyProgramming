using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba09._02._2023 {
    internal class CreditCard {
        string card_num, name, surname, pathronymic, card_date, cvc;
        int money;
        internal CreditCard() {
            card_num = name = surname = pathronymic = cvc = null;
            money = 0;
        }
        internal CreditCard(CreditCard obj)
        {
            card_num = obj.card_num;
            name = obj.name;
            surname = obj.surname;
            pathronymic = obj.pathronymic;
            cvc = obj.cvc;
            money = obj.money;
        }
        internal void Input()
        {
            try
            {
                Console.Write("Введите номер карты: ");
                card_num = Console.ReadLine();
                if (card_num.Length != 16)
                {
                    throw new Exception("Исключение: Введена неправильная длина номера карты.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите имя владельца: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию владельца: ");
            surname = Console.ReadLine();
            Console.Write("Введите отчество владельца: ");
            pathronymic = Console.ReadLine();
            try
            {
                Console.Write("Введите cvc-код: ");
                cvc = Console.ReadLine();
                if (cvc.Length != 3)
                {
                    throw new Exception("Исключение: Введена неправильная длина CVC-кода.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите дату окончания работы карты: ");
            card_date = Console.ReadLine();
            Console.Write("Введите кол-во денег на карте: ");
            money = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public static CreditCard operator +(CreditCard obj1, int value) {
            CreditCard result = new CreditCard();
            result.money = obj1.money + value;
            return result;
        }
        public static CreditCard operator -(CreditCard obj1, int value) {
            CreditCard result = new CreditCard();
            result.money = obj1.money - value;
            return result;
        }
        public static bool operator ==(CreditCard obj1, CreditCard obj2) {
            if (obj1.cvc == obj2.cvc)
                return true;
            else
                return false;
        }
        public static bool operator !=(CreditCard obj1, CreditCard obj2) { return !(obj1.cvc == obj2.cvc); }
        public static bool operator >(CreditCard obj1, CreditCard obj2){
            if (obj1.money > obj2.money)
                return true;
            else
                return false;
        }
        public static bool operator <(CreditCard obj1, CreditCard obj2) { return !(obj1.money > obj2.money); }
    }
}
