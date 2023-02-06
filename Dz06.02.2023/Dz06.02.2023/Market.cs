using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz06._02._2023 {
    internal class Market {
        string name, address, description, telephone, email;
        internal string Name {
            get { return name; }
            set { name = value; }
        }
        internal string Address {
            get { return address; }
            set { address = value; }
        }
        internal string Description {
            get { return description; }
            set { description = value; }
        }
        internal string Telephone {
            get { return telephone; }
            set { telephone = value; }
        }
        internal string Email {
            get { return email; }
            set { email = value; }
        }
        internal Market() {
            name = address = description= telephone = email = null;
        }
        internal void Input() {
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
            Console.WriteLine();
        }
        internal void Print() {
            Console.WriteLine($"Название магазина: {name}");
            Console.WriteLine($"Адресс магазина: {address}");
            Console.WriteLine($"Описание профиля магазина: {description}");
            Console.WriteLine($"Контактный телефон: {telephone}");
            Console.WriteLine($"Контактная почта: {email}");
        }
    }
}
