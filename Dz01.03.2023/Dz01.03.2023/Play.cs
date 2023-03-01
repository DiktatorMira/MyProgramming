using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dz01._03._2023 {
    internal class Play : IDisposable {
        public string Name { get; set; }
        public string AuthorFIO { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public Play() :this(null, null, null, 0) {}
        public Play(string name, string fio, string genre, int year) {
            Name = name;
            AuthorFIO = fio;
            Genre = genre;
            Year = year;
        }
        public void Show() {
            Console.WriteLine($"Имя пьесы: {Name}");
            Console.WriteLine($"ФИО автора: {AuthorFIO}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Год исполнения: {Year}");
        }
        public void Dispose() {
            Console.WriteLine("Произошла очистка полей!");
            Name = AuthorFIO = Genre = null;
            Year = 0;
        }
        ~Play() {
            Console.WriteLine("Поля класса очищены!");
            Name = AuthorFIO = Genre = null;
            Year = 0;
        }
    }
}
