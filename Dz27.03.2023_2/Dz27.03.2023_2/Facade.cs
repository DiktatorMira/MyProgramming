using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz27._03._2023_2 {
    public class Facade {
        protected VideoCard card { get; set; }
        protected RAM ram { get; set; }
        protected HDD hdd { get; set; }
        protected DiskReader disk { get; set; }
        protected PowerUnit unit { get; set; }
        protected Sensors sensor { get; set; }
        public Facade(VideoCard card, RAM ram, HDD hdd, DiskReader disk, PowerUnit unit, Sensors sensor) {
            this.card = card;
            this.ram = ram;
            this.hdd = hdd;
            this.disk = disk;
            this.unit = unit;
            this.sensor = sensor;
        }
        public void StartComputer() {
            if (card.Check() == true && ram.Check() == true && hdd.Check() == true && disk.Check() == true &&
                unit.Check() == true && sensor.Check() == true) {
                Console.WriteLine("Запуск выполнен успешно!");
            }
            else Console.WriteLine("Запуск не удался!");
        }
        public void EndComputer() => Console.WriteLine("Компьютер выключен.");
    }
    public class Client {
        public static void ClientCode(Facade facade) {
            Console.WriteLine(facade.StartComputer());
            Console.WriteLine(facade.EndComputer());
        }
    }
    interface IHardware {
        bool Check();
    }
    public class VideoCard : IHardware {
        int Count = 0;
        Random rand = new Random();
        public bool Check() {
            Console.WriteLine("Запуск видеокарты.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка связи с монитором пройдена.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Данные об ОЗУ выведены.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Данные об УЧД выведены.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Данные о жёстком диске выведены.");
            Count += rand.Next(0, 1);
            if (Count == 5) return true;
            else return false;
        }
    }
    public class RAM : IHardware {
        int Count = 0;
        Random rand = new Random();
        public bool Check() {
            Console.WriteLine("Запуск устройств.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Анализ памяти.");
            Count += rand.Next(0, 1);
            if (Count == 2) return true;
            else return false;
        }
    }
    public class HDD : IHardware {
        int Count = 0;
        Random rand = new Random();
        public bool Check() {
            Console.WriteLine("Запуск устройста.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка загрузочного сектора.");
            Count += rand.Next(0, 1);
            if (Count == 2) return true;
            else return false;
        }
    }
    public class DiskReader : IHardware {
        int Count = 0;
        Random rand = new Random();
        public bool Check() {
            Console.WriteLine("Запуск устройста.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка наличия диска.");
            Count += rand.Next(0, 1);
            if (Count == 2) return true;
            else return false;
        }
    }
    public class PowerUnit : IHardware {
        int Count = 0;
        Random rand = new Random();
        public bool Check() {
            Console.WriteLine("Подача питания.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Подача питания на видеокарту.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Подача питания на ОЗУ.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Подача питания на устройство чтения дисков.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Подача питания на жёсткий диск.");
            Count += rand.Next(0, 1);
            if (Count == 5) return true;
            else return false;
        }
    }
    public class Sensors : IHardware {
        int Count = 0;
        Random rand = new Random();
        public bool Check() {
            Console.WriteLine("Проверка напряжения.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка температуры в блоке питания.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка температуры в видеокарте.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка температуры в ОЗУ.");
            Count += rand.Next(0, 1);
            Console.WriteLine("Проверка температуры всей системы.");
            Count += rand.Next(0, 1);
            if (Count == 5) return true;
            else return false;
        }
    }
}
