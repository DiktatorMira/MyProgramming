using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz03._04._2023_2 {
    public interface ITransport {
        int Cost { get; set; }
        int Time { get; set; }
        int DriveToAirport(int money);
    }
    public class Bicycle : ITransport {
        public int Cost { get; set; } = 0;
        public int Time { get; set; } = 180;
        public Bicycle() { }
        public int DriveToAirport(int money) {
            if (money < Cost) {
                Console.WriteLine("Недостаточно денег!");
                return money;
            }
            money -= Cost;
            Console.WriteLine($"Вы доехали до аэропорта на велосипеде за {Time} минут, цена {Cost}$");
            return money;
        }
    }
    public class Bus : ITransport {
        public int Cost { get; set; } = 10;
        public int Time { get; set; } = 80;
        public Bus() { }
        public int DriveToAirport(int money) {
            if (money < Cost) {
                Console.WriteLine("Недостаточно денег!");
                return money;
            }
            money -= Cost;
            Console.WriteLine($"Вы доехали до аэропорта на автобусе за {Time} минут, цена {Cost}$");
            return money;
        }
    }
    public class Taxi : ITransport {
        public int Cost { get; set; } = 60;
        public int Time { get; set; } = 30;
        public Taxi() { }
        public int DriveToAirport(int money) {
            if (money < Cost) {
                Console.WriteLine("Недостаточно денег!");
                return money;
            }
            money -= Cost;
            Console.WriteLine($"Вы доехали до аэропорта на такси за {Time} минут, цена {Cost}$");
            return money;
        }
    }
    public class Client {
        public ITransport Transport { get; set; }
        public int Money { get; set; }
        public Client(int money, ITransport transport) {
            Money = money;
            Transport = transport;
        }
        public void GetToAirport() {
            if (Transport == null) Console.WriteLine("Выберите способ передвижения!");
            else Money = Transport.DriveToAirport(Money);
        }
    }
    internal class Program {
        static void Main(string[] args) { 
            Bus bus = new Bus();
            Client client = new Client(5, bus);
            client.GetToAirport();
        }
    }
}
