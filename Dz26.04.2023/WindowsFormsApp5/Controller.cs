using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.Model;

namespace WindowsFormsApp5 {
    class Controller {
        public string GetBook(string value, bool status) {
            string rez;
            if (!String.IsNullOrEmpty(value)) {
                Database db = new Database();
                if(status) {
                    rez = db.FindByBook(value);
                    if (rez != null) return rez;
                }
                else {
                    rez = db.FindByAuthor(value);
                    if (rez != null) return rez;
                }
            }
            return "Книга не найдена!";
        }
    }
}
