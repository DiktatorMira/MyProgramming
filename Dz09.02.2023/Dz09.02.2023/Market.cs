using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz09._02._2023 {
    internal class Market {
        string name, address, description, telephone, email;
        int square;
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal string Address
        {
            get { return address; }
            set { address = value; }
        }
        internal string Description
        {
            get { return description; }
            set { description = value; }
        }
        internal string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        internal string Email
        {
            get { return email; }
            set { email = value; }
        }
        internal int Square
        {
            get { return square; }
            set { square = value; }
        }
        internal Market()
        {
            name = address = description = telephone = email = null;
            square = 0;
        }
        internal void Input()
        {
            Console.Write("Введите название магазина: ");
            name = Console.ReadLine();
            Console.Write("Введите адресс магазина: ");
            address = Console.ReadLine();
            Console.Write("Введите описание профиля магазина: ");
            description = Console.ReadLine();
            Console.Write("Введите контактный телефон: ");
            telephone = Console.ReadLine();
            Console.Write("Введите контактную почту: ");
            email = Console.ReadLine();
            Console.Write("Введите площадь магазина: ");
            square = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        internal void Print()
        {
            Console.WriteLine($"Название магазина: {name}");
            Console.WriteLine($"Адресс магазина: {address}");
            Console.WriteLine($"Описание профиля магазина: {description}");
            Console.WriteLine($"Контактный телефон: {telephone}");
            Console.WriteLine($"Контактная почта: {email}");
            Console.WriteLine($"Площадь магазина: {square}");
        }
        public static Market operator +(Market obj1, int value) {
            Market result = new Market();
            result.square = obj1.square + value;
            return result;
        }
        public static Market operator -(Market obj1, int value) {
            Market result = new Market();
            result.square = obj1.square - value;
            return result;
        }
        public static bool operator >(Market obj1, Market obj2) {
            if (obj1.square > obj2.square)
                return true;
            else
                return false;
        }
        public static bool operator <(Market obj1, Market obj2) { return!(obj1.square > obj2.square); }
        public static bool operator ==(Market obj1, Market obj2) {
            if (obj1.square == obj2.square)
                return true;
            else
                return false;
        }
        public static bool operator !=(Market obj1, Market obj2) { return !(obj1.square == obj2.square); }
    }
}
