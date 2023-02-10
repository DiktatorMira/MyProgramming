using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10._02._2023 {
    internal class BookList {
        Book[] books;
        internal BookList() => books = new Book[0];
        internal BookList(int size) => books = new Book[size];
        internal BookList(params Book[] arr) {
            books = new Book[arr.Length];
            for (short i = 0; i < arr.Length; i++)
                books[i] = arr[i];
        }
        public Book this[int index] {
            get {
                if(index >= 0 && index < books.Length) return books[index];
                else throw new Exception($"Некорректный индекс: {index}!");
            }
            set {
                if (index >= 0 && index < books.Length) books[index] = value;
                else throw new Exception($"Некорректный индекс: {index}!");
            }
        }
        internal void AddBook(Book obj) {
            BookList NewBook = new BookList(books.Length + 1);
            NewBook[books.Length - 1] = obj;
        }
        internal void DelBook(Book obj, int index) {
            for(int i = index; i < books.Length; i++)
                (books[i], books[i + 1]) = (books[i + 1], books[i]);
            books = new Book[books.Length - 1];
        }
        internal bool Find(Book obj, string FindName) {
            if (obj.BookName == FindName) return true;
            else return false;
        }
    }
}
