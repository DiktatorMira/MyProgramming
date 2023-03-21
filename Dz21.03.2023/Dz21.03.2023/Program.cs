using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Dz21._03._2023 {
    internal class Program {
        public interface IContinent {
            IHerbivore CreateHerbivore();
            ICarnivorous CreateCarnivorous();
        }
        internal class Africa : IContinent {
            public IHerbivore CreateHerbivore() { return new Wildebeest(); }
            public ICarnivorous CreateCarnivorous() { return new Lion(); }
        }
        internal class NorthAmerica : IContinent {
            public IHerbivore CreateHerbivore() { return new Bison(); }
            public ICarnivorous CreateCarnivorous() { return new Wolf(); }
        }
        internal class Eurasia : IContinent {
            public IHerbivore CreateHerbivore() { return new Elk(); }
            public ICarnivorous CreateCarnivorous() { return new Tiger(); }
        }
        public interface IHerbivore {
            int Weight { get; set; }
            void Eat();
            bool IsLife();
        }
        internal class Wildebeest : IHerbivore {
            public int Weight { get; set; }
            public Wildebeest() => Weight = 45;
            public void Eat() {
                Weight += 10;
                Console.WriteLine("Антилопа Гну поела.");
            }
            public bool IsLife() {
                if(Weight <= 0) return false;
                else return true;
            }
        }
        internal class Bison : IHerbivore {
            public int Weight { get; set; }
            public Bison() => Weight = 100;
            public void Eat() {
                Weight += 10;
                Console.WriteLine("Бизон поел.");
            }
            public bool IsLife() {
                if (Weight <= 0) return false;
                else return true;
            }
        }
        internal class Elk : IHerbivore {
            public int Weight { get; set; }
            public Elk() => Weight = 75;
            public void Eat() {
                Weight += 10;
                Console.WriteLine("Лось поел.");
            }
            public bool IsLife() {
                if (Weight <= 0) return false;
                else return true;
            }
        }
        public interface ICarnivorous {
            int Power { get; set; }
            void Eat(IHerbivore obj);
            bool IsLife();
        }
        internal class Lion : ICarnivorous {
            public int Power { get; set; }
            public Lion() => Power = 120;
            public void Eat(IHerbivore obj) {
                if (obj.Weight > Power) {
                    Power -= 10;
                    Console.WriteLine("Лев не смог съесть травоядного.");
                } else {
                    Power += 10;
                    Console.WriteLine("Лев cъел травоядного.");
                    obj.Weight = 0;
                }
            }
            public bool IsLife() {
                if(Power <= 0) return false;
                else return true;
            }
        }
        internal class Wolf : ICarnivorous {
            public int Power { get; set; }
            public Wolf() => Power = 70;
            public void Eat(IHerbivore obj) {
                if (obj.Weight > Power) {
                    Power -= 10;
                    Console.WriteLine("Волк не смог съесть травоядного.");
                } else {
                    Power += 10;
                    Console.WriteLine("Волк cъел травоядного.");
                    obj.Weight = 0;
                }
            }
            public bool IsLife() {
                if (Power <= 0) return false;
                else return true;
            }
        }
        internal class Tiger : ICarnivorous {
            public int Power { get; set; }
            public Tiger() => Power = 110;
            public void Eat(IHerbivore obj) {
                if (obj.Weight > Power) {
                    Power -= 10;
                    Console.WriteLine("Тигр не смог съесть травоядного.");
                }
                else {
                    Power += 10;
                    Console.WriteLine("Тигр cъел травоядного.");
                    obj.Weight = 0;
                }
            }
            public bool IsLife() {
                if (Power <= 0) return false;
                else return true;
            }
        }
        internal class AnimalWord {
            public void MealsHerbivores(IContinent obj) {
                var herbivore = obj.CreateHerbivore();
                var carnivorous = obj.CreateCarnivorous();
            }
        }
        static void Main(string[] args) {

        }
    }
}
