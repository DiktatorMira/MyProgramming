using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10._02._2023 {
    internal class Book {
        string book_name, author_name;
        int pages;
        public string BookName {
            get { return book_name; }
            set { book_name = value; }
        }
        public string AuthorName {
            get { return author_name; }
            set { author_name = value; }
        }
        public int Pages {
            get { return pages; }
            set { pages = value; }
        }
        internal Book() {
            book_name = author_name = null;
            pages = 0;
        }
        internal Book(Book obj) {
            book_name = obj.book_name;
            author_name = obj.author_name;
            pages = obj.pages;
        }
        internal void Input() {
            Console.Write("Введите название книги: ");
            book_name = Console.ReadLine();
            Console.Write("Введите ФИО автора книги: ");
            author_name = Console.ReadLine();
            Console.Write("Введите кол-во страниц в книге: ");
            pages = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        internal void Print() {
            Console.WriteLine($"Название книги: {book_name}");
            Console.WriteLine($"Имя автора книги: {author_name}");
            Console.WriteLine($"Кол-во страниц: {pages}");
        }
        public override string ToString() {
            return $"Название книги: {book_name}\nИмя автора книги: {author_name}\nКол-во страниц: {pages}";
        }
    }
}
