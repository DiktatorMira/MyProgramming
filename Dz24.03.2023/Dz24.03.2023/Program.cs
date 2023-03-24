using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz24._03._2023 {
    internal class Program {
        public abstract class Component {
            public Component() {
            
            }
            public virtual void Add(Component obj) { }
            public virtual void Remove(Component obj) { }
            public virtual int GetPrice() { return 0; }
        }
        public class Leaf : Component {
            public string Name { get; set; }
            public int Price { get; set; }
            public Leaf() :this(null, 0) { }
            public Leaf(string name, int price) {
                Name = name;
                Price = price;
            }
            public override int GetPrice() { return Price; }
        }
        public class Composite : Component {
            protected List<Component> objects = new List<Component>();
            public string Name { get; set; }
            public Composite(string name) => Name = name;
            public override void Add(Component obj) => objects.Add(obj);
            public override void Remove(Component obj) => objects.Remove(obj);
            public override int GetPrice() {
                int SumPrice = 0;
                for(int i = 0; i < objects.Count; i++) SumPrice += objects[i].GetPrice();
                return SumPrice;
            }
        }
        public class Client {
            public void ClientCode(Component leaf) => Console.WriteLine($"Цена: {leaf.GetPrice()}\n");
        }
        static void Main(string[] args) {
            Composite Reception = new Composite("Приёмная");
            Reception.Add(new Leaf("Тёплые тона", 150));
            Console.WriteLine(Reception.GetPrice());
        }
    }
}
