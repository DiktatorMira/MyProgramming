using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Laba09._02._2023 {
    internal class Employee {
        string name, surname, patronymic, date, telephone, email, post, responsibilities;
        int money;
        internal Employee()
        {
            name = surname = patronymic = date = telephone = email = post = responsibilities = null;
            money = 0;
        }
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        internal string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        internal string Date
        {
            get { return date; }
            set { date = value; }
        }
        internal string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        internal string Email
        {
            get { return email; }
            set { email = value; }
        }
        internal string Post
        {
            get { return post; }
            set { post = value; }
        }
        internal string Responsibilities
        {
            get { return responsibilities; }
            set { responsibilities = value; }
        }
        internal short Money
        {
            get { return money; }
            set { money = value; }
        }
        internal void Input()
        {
            Console.Write("Введите имя сотрудника: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию сотрудника: ");
            surname = Console.ReadLine();
            Console.Write("Введите отчество сотрудника: ");
            patronymic = Console.ReadLine();
            Console.Write("Введите дату рождения сотрудника: ");
            date = Console.ReadLine();
            Console.Write("Введите телефон сотрудника: ");
            telephone = Console.ReadLine();
            Console.Write("Введите почту сотрудника: ");
            email = Console.ReadLine();
            Console.Write("Введите должность сотрудника: ");
            post = Console.ReadLine();
            Console.Write("Введите его обязанности: ");
            responsibilities = Console.ReadLine();
            Console.Write("Введите его ЗП: ");
            money = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        internal void Print()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Отчество: {patronymic}");
            Console.WriteLine($"Дата рождения: {date}");
            Console.WriteLine($"Телефон: {telephone}");
            Console.WriteLine($"Почта: {email}");
            Console.WriteLine($"Должность: {post}");
            Console.WriteLine($"Обязанности: {responsibilities}");
            Console.WriteLine($"Зарлпата: {money}");
        }
        public static Employee operator +(Employee obj1, Employee obj2) {
            Employee result = new Employee();
            result.money = obj1.money + obj2.money;
            return result;
        }
        public static Employee operator -(Employee obj1, Employee obj2) {
            Employee result = new Employee();
            result.money = obj1.money - obj2.money;
            return result;
        }
        public static bool operator <(Employee obj1, Employee obj2) {
            if (obj1.money < obj2.money)
                return true;
            else
                return false;
        }
        public static bool operator >(Employee obj1, Employee obj2) { return !(obj1.money < obj2.money); }
        public static bool operator ==(Employee obj1, Employee obj2) {
            if (obj1.money == obj2.money)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee obj1, Employee obj2) { return !(obj1.money == obj2.money);  }
    }
}
