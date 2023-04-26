using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp5.Model {
    class Database {
        public string buff { get; set; }
        public Database() {
            using (StreamWriter file = new StreamWriter("books.txt", false)) {
                file.WriteLine("Названике книги: CLR via C#\t\t\tАвтор: Jefry Richter");
                file.WriteLine("Названике книги: Эмоциональный интеллект\t\t\tАвтор: Дэниел Гоулман");
                file.WriteLine("Названике книги: С++\t\t\tАвтор: Бьярне Страуструп");
                file.WriteLine("Названике книги: ТРИЗ\t\t\tАвтор: Марк Меерович");
            }
        }
        public string FindByBook(string bookname) {
            if(bookname != null) {
                using (StreamReader file = new StreamReader("books.txt", Encoding.UTF8)) {
                    while (!file.EndOfStream) {
                        buff = file.ReadLine();
                        if (buff.Contains(bookname)) return buff;
                    }
                }
            }
            return null;
        }
        public string FindByAuthor(string authname) {
            if (authname != null) {
                using (StreamReader file = new StreamReader("books.txt", Encoding.UTF8)) {
                    while (!file.EndOfStream) {
                        buff = file.ReadLine();
                        if (buff.Contains(authname)) return buff;
                    }
                }
            }
            return null;
        }
    }
}
