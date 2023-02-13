using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba13._02._2023 {
    internal class Passport {
        internal string FIO { get; set; }
        internal string Country { get; set; }
        internal string Male { get; set; }
        internal string DateOfBirth { get; set; }
        internal Passport() : this(null, null, null, null) { }
        internal Passport(string fio, string coun, string male, string date) {
            FIO = fio;
            Country = coun;
            Male = male;
            DateOfBirth = date;
        }
        internal virtual void Print() => Console.WriteLine($"ФИО: {FIO}\nСтрана: {Country}\n" +
                $"Пол: {Male}]\nДата рождения: {DateOfBirth}\n");
        public override string ToString() { return $"ФИО: {FIO}\nСтрана: {Country}\n" +
                $"Пол: {Male}]\nДата рождения: {DateOfBirth}\n"; }
    }
    internal class ForeignPassport : Passport {
        internal string Visas { get; set; }
        internal int PassNum { get; set; }
        internal ForeignPassport(string fio, string coun, string male, string date, string visas, int num)
            : base(fio, coun, male, date) {
            Visas = visas;
            PassNum = num;
        }
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Визы: {Visas}\nНомер паспорта: {PassNum}");
        }
        public override string ToString() { return base.ToString() + $"Визы: {Visas}\nНомер паспорта: {PassNum}"; }
    }
}
