using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba09._02._2023 {
    internal class City {
        string city_name;
        string country;
        int habitants;
        string tel_kode;
        string[] city_districts = new string[4];
        internal string CityName
        {
            get { return city_name; }
            set { city_name = value; }
        }
        internal string Country
        {
            get { return country; }
            set { country = value; }
        }
        internal int Habitnats
        {
            get { return habitants; }
            set { habitants = value; }
        }
        internal string TelephoneKode
        {
            get { return tel_kode; }
            set { tel_kode = value; }
        }
        internal City()
        {
            city_name = country = tel_kode = null;
            int habitants = 0;
            for (short i = 0; i < city_districts.Length; i++)
            {
                city_districts[i] = null;
            }
        }
        internal void Input()
        {
            Console.Write("Введите название города: ");
            city_name = Console.ReadLine();
            Console.Write("Введите название cтраны: ");
            country = Console.ReadLine();
            Console.Write("Введите кол-во жителей: ");
            habitants = int.Parse(Console.ReadLine());
            Console.Write("Введите телефонный код: ");
            tel_kode = Console.ReadLine();
            for (short i = 0; i < city_districts.Length; i++)
            {
                Console.Write("Введите {0} район города: ", i);
                city_districts[i] = Console.ReadLine();
            }
            Console.WriteLine();
        }
        internal void Print()
        {
            Console.WriteLine("Город: {0}", city_name);
            Console.WriteLine("Страна: {0}", country);
            Console.WriteLine("Численность населения: {0}", habitants);
            Console.WriteLine("Телефонный код: {0}", tel_kode);
            for (short i = 0; i < city_districts.Length; i++)
                Console.WriteLine("{0} район города: {1}", i, city_districts[i]);
        }
        public static City operator +(City obj1, City obj2) {
            City result = new City();
            result.habitants = obj1.habitants + obj2.habitants;
            return result;
        }
        public static City operator -(City obj1, City obj2) {
            City result = new City();
            result.habitants = obj1.habitants - obj2.habitants;
            return result;
        }
        public static bool operator <(City obj1, City obj2) {
            if (obj1.habitants < obj2.habitants)
                return true;
            else
                return false;
        }
        public static bool operator >(City obj1, City obj2) { return !(obj1.habitants < obj2.habitants); }
        public static bool operator ==(City obj1, City obj2) {
            if (obj1.habitants == obj2.habitants)
                return true;
            else
                return false;
        }
        public static bool operator !=(City obj1, City obj2) { return !(obj1.habitants == obj2.habitants); }
    }
}
