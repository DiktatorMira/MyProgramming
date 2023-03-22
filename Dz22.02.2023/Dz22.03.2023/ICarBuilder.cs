using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz22._03._2023 {
    public class Car {
        public string Frame { get; set; }
        public int Engine { get; set; }
        public int Wheels { get; set; }
        public string CPP { get; set; }
        public override string ToString() {
            return $"Корпус: {Frame}\nДвигатель: {Engine}\nКолёса: {Wheels}\nКПП: {CPP}";
        }
    }
    public interface ICarBuilder {
        void CreateFrame();
        void CreateEngine();
        void CreateWheels();
        void CreateCPP();
        Car GetCar();
    }
    public class DaewooLanos : ICarBuilder {
        public Car car { get; set; }
        public DaewooLanos() => car = new Car();
        public void CreateFrame() => car.Frame = "Седан";
        public void CreateEngine() => car.Engine = 98;
        public void CreateWheels() => car.Wheels = 13;
        public void CreateCPP() => car.CPP = "5 Механика";
        public Car GetCar() { return car; }
    }
    public class FordProbe : ICarBuilder {
        public Car car { get; set; }
        public FordProbe() => car = new Car();
        public void CreateFrame() => car.Frame = "Купе";
        public void CreateEngine() => car.Engine = 160;
        public void CreateWheels() => car.Wheels = 14;
        public void CreateCPP() => car.CPP = "4 Автомат";
        public Car GetCar() { return car; }
    }
    public class UazPatriot : ICarBuilder {
        public Car car { get; set; }
        public UazPatriot() => car = new Car();
        public void CreateFrame() => car.Frame = "Универсал";
        public void CreateEngine() => car.Engine = 120;
        public void CreateWheels() => car.Wheels = 16;
        public void CreateCPP() => car.CPP = "4 Механика";
        public Car GetCar() { return car; }
    }
    public class HyundaiGetz : ICarBuilder {
        public Car car { get; set; }
        public HyundaiGetz() => car = new Car();
        public void CreateFrame() => car.Frame = "Хетчбэк";
        public void CreateEngine() => car.Engine = 66;
        public void CreateWheels() => car.Wheels = 13;
        public void CreateCPP() => car.CPP = "4 Автомат";
        public Car GetCar() { return car; }
    }
}
