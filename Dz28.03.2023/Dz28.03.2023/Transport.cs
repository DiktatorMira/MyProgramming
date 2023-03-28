using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz28._03._2023 {
    public abstract class Transport {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }
        public override abstract string ToString();
    }
    public class LightInfantry : Transport {
        public LightInfantry() {
            Name = "Лёгкая пехота";
            Speed = 20;
            Power = 10;
        }
        public override string ToString() {
            return $"Название транспорта: {Name}\nСкорость: {Speed}\nСила: {Power}";
        }
    }
    public class Vehicles : Transport {
        public Vehicles() {
            Name = "Транспортная автомашина";
            Speed = 70;
            Power = 0;
        }
        public override string ToString()  {
            return $"Название транспорта: {Name}\nСкорость: {Speed}\nСила: {Power}";
        }
    }
    public class HeavyEquipment : Transport {
        public HeavyEquipment() {
            Name = "Тяжелая назменая боевая техника";
            Speed = 15;
            Power = 150;
        }
        public override string ToString() {
            return $"Название транспорта: {Name}\nСкорость: {Speed}\nСила: {Power}";
        }
    }
    public class LightEquipment : Transport {
        public LightEquipment() {
            Name = "Лёгкая назменая боевая техника";
            Speed = 50;
            Power = 30;
        }
        public override string ToString() {
            return $"Название транспорта: {Name}\nСкорость: {Speed}\nСила: {Power}";
        }
    }
    public class Aerotechnics : Transport {
        public Aerotechnics() {
            Name = "Авиатехника";
            Speed = 300;
            Power = 100;
        }
        public override string ToString() {
            return $"Название транспорта: {Name}\nСкорость: {Speed}\nСила: {Power}";
        }
    }
}
