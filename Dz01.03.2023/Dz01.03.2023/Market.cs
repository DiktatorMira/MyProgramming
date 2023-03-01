using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01._03._2023 {
    internal class Market : IDisposable {
        public string Name { get; set; }
        public string Address { get; set; }
        public enum TypeMarket {
            Продовольственный,
            Хозяйственный,
            Одежды,
            Обувной
        }
        public Market() :this(null, null) { }
        public Market(string name, string addr) {
            Name = name;
            Address = addr;
        }
        public void Show() {
            Console.WriteLine($"Название магазина: {Name}");
            Console.WriteLine($"Местонахождение: {Address}");
        }
        public void Dispose() {
            Console.WriteLine("Произошла очистка полей!");
            Name = Address = null;
        }
        ~Market() {
            Console.WriteLine("Поля класса очищены!");
            Name = Address = null;
        }
    }
}
