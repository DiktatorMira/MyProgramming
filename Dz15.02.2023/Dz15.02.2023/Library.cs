using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz15._02._2023 {
    internal class Library {
        Book[] books;
        int position = -1;
        public Library() => books = null;
        public Library(Book[] books) {
            books = new Book[books.Length];
            for (short i = 0; i < books.Length; i++)
                books[i] = new Book(books[i].Name, books[i].Author, books[i].Descripion, books[i].Pages);
        }
        public void InputBooks() {
            for (short i = 0; i < books.Length; i++) books[i].Input();
        }
        public void PrintBooks() {
            for (int i = 0; i < books.Length; i++) books[i].Print();
        }
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < books.Length; i++) yield return books[i];
        }
    }
}
