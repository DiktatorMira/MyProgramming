using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz20._03._2023 {
    internal class Program {
        abstract class LogisticsApp {
            public abstract ITransport FactoryMethod();
        }
        class RoadLogistics : LogisticsApp {
            public override ITransport FactoryMethod() {
                return new Truck();
            }
        }
        class SeaLogistics : LogisticsApp {
            public override ITransport FactoryMethod() {
                return new Ship();
            }
        }
        class AirLogistics : LogisticsApp {
            public override ITransport FactoryMethod() {
                return new Plane();
            }
        }
        interface ITransport {
            int FuelCol { get; set; }
            int DeliveryCost { get; set; }
            void CreateTransport();
        }
        public class Truck : ITransport {
            public int FuelCol { get; set; }
            public int DeliveryCost { get; set;}
            public Truck() :this(5000, 220) { }
            public Truck(int fuel, int delivery) {
                FuelCol = fuel;
                DeliveryCost = delivery;
            }
            public void CreateTransport() => Console.WriteLine("Грузовик создан.");
        }
        public class Plane : ITransport {
            public int FuelCol { get; set; }
            public int DeliveryCost { get; set; }
            public Plane() : this(10000, 1000) { }
            public Plane(int fuel, int delivery) {
                FuelCol = fuel;
                DeliveryCost = delivery;
            }
            public void CreateTransport() => Console.WriteLine("Самолёт создан.");
        }
        public class Ship : ITransport {
            public int FuelCol { get; set; }
            public int DeliveryCost { get; set;}
            public Ship() :this(1000, 50) { }
            public Ship(int fuel, int delivery) {
                FuelCol = fuel;
                DeliveryCost = delivery;
            }
            public void CreateTransport() => Console.WriteLine("Корабль создан.");
        }
        static void Main(string[] args) {
            
        }
    }
}
