using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz07._02._2023 {
    internal class Program {
        class Firm {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Profile { get; set; }
            public string DirectroFIO { get; set; }
            public int EmployeeCount { get; set; }
            public string Address { get; set; }
            public Employee Employee { get; set; }
            public Firm() :this(null, 0, null, null, 0, null, null) { }
            public Firm(string name, int year, string profile, string fio, int count, string address, Employee emp) {
                Name = name;
                Year = year;
                Profile = profile;
                DirectroFIO = fio;
                EmployeeCount = count;
                Address = address;
                Employee = emp;
            }
        }
        class Employee {
            public string FIO { get; set; }
            public string State { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }
            public int Money { get; set; }
            public Employee() :this(null, null, null, null, 0) {}
            public Employee(string fio, string state, string telephone, string email, int money) {
                FIO = fio;
                State = state;
                Telephone = telephone;
                Email = email;
                Money = money;
            }
        }
        static void Main(string[] args) {
            Employee first = new Employee("Ганов Шиш Аыф", "говночист", "e2323", "arab@ok.com", 100);
            Employee second = new Employee("Ирб Ажк Мышь", "Дворник", "3234", "maman@tvorog.com", 250);
            Employee third = new Employee("Жибин Арх Чичев", "Бизнесмен", "2343", "gigachas@sigma.com", 100000);
            Firm obj1 = new Firm("Food Core", 1999, "ok", "Иван Робин Бобин", 26, "ивив", first);
            Firm obj2 = new Firm("DOND Tech", 2022, "моя фирма", "Данила Юрьевич Червоный", 4, "радужный", second);
            Firm obj3 = new Firm("Vantus", 1976, "yes sir", "Джон Сина", 4, "addr", third);
            Firm[] Farr = { obj1, obj2, obj3 };
            var Firms = from a in Farr select a.Name;
            var FirmsFood = from food in Farr
                            where food.Name.Contains("Food")
                            select food.Name;
            var FirmsFood2 = Farr.Where(i => i.Name.Contains("Food"));
            var FirmCount = from emp in Farr
                            where emp.EmployeeCount > 100
                            select emp;
            var FirmCount12 = Farr.Where(i => i.EmployeeCount > 100);
            var FirmCount2 = from emp in Farr
                            where emp.EmployeeCount >= 100 && emp.EmployeeCount <= 300
                            select emp;
            var FirmCount22 = Farr.Where(i => i.EmployeeCount >= 100 && i.EmployeeCount <= 300);
            var FirmAddr = from addr in Farr
                             where addr.Address.Contains("Лондон")
                             select addr;
            var FirmAddr2 = Farr.Where(i => i.Address.Contains("Лондон"));
            var FirmSurn = from sur in Farr
                           where sur.DirectroFIO.Contains("White")
                           select sur;
            var FirmSurn2 = Farr.Where(i => i.DirectroFIO.Contains("White"));
            var FirmYear = from year in Farr
                           where year.Year <= 2023 - 12
                           select year;
            var FirmYear2 = Farr.Where(i => i.Year <= 2023 - 12);
            var FirmDir = from dir in Farr
                           where dir.DirectroFIO.Contains("Black") && dir.Name.Contains("White")
                          select dir;
            var FirmDir2 = Farr.Where(i => i.DirectroFIO.Contains("Black") && i.Name.Contains("White"));
            var EmpFIO = from emp in Farr
                          select emp.Employee.FIO;
            var EmpMoney = from emp in Farr
                          where emp.Employee.Money > 110
                          select emp.Employee;
            var EmpState = from emp in Farr
                           where emp.Employee.State.Contains("Менеджер")
                           select emp.Employee;
            var EmpTel = from emp in Farr
                         where emp.Employee.Telephone.StartsWith("23")
                         select emp.Employee;
            var EmpEmail = from emp in Farr
                         where emp.Employee.Email.StartsWith("di")
                         select emp.Employee;
            var EmpName = from emp in Farr
                          where emp.Employee.FIO.Contains("Lionel")
                          select emp.Employee;
        }
    }
}
