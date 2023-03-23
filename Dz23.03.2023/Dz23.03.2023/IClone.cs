using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz23._03._2023 {
    public interface IClone {
        object ShallowCopy();
        object DeepCopy();
    }
    public class Engine : IClone {
        public string engine { get; set; } 
        public Engine() :this(null) { }
        public Engine(string engine) => this.engine = engine;
        public object ShallowCopy() { return (Engine)this.MemberwiseClone(); }
        public object DeepCopy() {
            Engine clone = (Engine)this.MemberwiseClone();
            clone.engine = String.Copy(engine);
            return clone;
        }
    }
    public abstract class Transport : IClone {
        abstract public object ShallowCopy();
        abstract public object DeepCopy();
        abstract public void Show();
    }
    public class Ship : Transport {
        public Engine engine { get; set; }
        public Ship() => engine.engine = "Лопасти снизу";
        public Ship(string engine) => this.engine.engine = engine;
        public override object ShallowCopy() { return (Ship)this.MemberwiseClone(); }
        public override object DeepCopy() {
            Ship clone = (Ship)this.MemberwiseClone();
            clone.engine.engine = String.Copy(engine.engine);
            return clone;
        }
        public override void Show() => Console.WriteLine("Корабль плывёт.");
    }
    public class Car : Transport {
        public Engine engine { get; set; }
        public Car() => engine.engine = "Двигатель от белаза";
        public Car(string engine) => this.engine.engine = engine;
        public override object ShallowCopy() { return (Car)this.MemberwiseClone(); }
        public override object DeepCopy() {
            Car clone = (Car)this.MemberwiseClone();
            clone.engine.engine = String.Copy(engine.engine);
            return clone;
        }
        public override void Show() => Console.WriteLine("Автомобиль едет.");
    }
    public class Plane : Transport {
        public Engine engine { get; set; }
        public Plane() => engine.engine = "Летающий двигатель";
        public Plane(string engine) => this.engine.engine = engine;
        public override object ShallowCopy() { return (Plane)this.MemberwiseClone(); }
        public override object DeepCopy() {
            Plane clone = (Plane)this.MemberwiseClone();
            clone.engine.engine = String.Copy(engine.engine);
            return clone;
        }
        public override void Show() => Console.WriteLine("Самолёт летит.");
    }
}
