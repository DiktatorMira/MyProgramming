using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz15._02._2023 {
    internal class Book : IComparable, ICloneable {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Descripion { get; set; }
        public int Pages { get; set; }
        public Book() :this(null, null, null, 0) { }
        public Book(string name, string author, string desc, int pages) {
            Name = name;
            Author = author;
            Descripion = desc;
            Pages = pages;
        }
        public void Input() {
            Console.Write("Введите название книги: ");
            Name = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            Author = Console.ReadLine();
            Console.Write("Введите описание книги: ");
            Descripion = Console.ReadLine();
            Console.Write("Введите кол-во страниц в книге: ");
            Pages = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public void Print() {
            Console.WriteLine($"Книга: {Name}");
            Console.WriteLine($"Автор книги: {Author}");
            Console.WriteLine($"Описание: {Descripion}");
            Console.WriteLine($"Кол-во страниц: {Pages}");
        }
        public int CompareTo(object obj) {
            if (obj is Book) return Name.CompareTo((obj as Book).Name);
            throw new NotImplementedException();
        }
        public object Clone() { return new Book(Name, Author, Descripion, Pages); }
    }
    internal class SortBookName : IComparer {
        int IComparer.Compare(object obj1, object obj2) {
            if (obj1 is Book && obj2 is Book)  return (obj1 as Book).Name.CompareTo((obj2 as Book).Name);
            throw new NotImplementedException();
        }
    }
}
