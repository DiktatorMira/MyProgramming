using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz04._04._2023 {
    internal class Program {
        public interface IElement {
            void Accept(IVisitor visitor);
        }
        public class House : IElement {
            public void Accept(IVisitor visitor) => visitor.VisitHouse(this);
            public string Show() { return "Дом"; }
        }
        public class Bank : IElement {
            public void Accept(IVisitor visitor) => visitor.VisitBank(this);
            public string Show() { return "Банк"; }
        }
        public class Fabric : IElement {
            public void Accept(IVisitor visitor) => visitor.VisitFabric(this);
            public string Show() { return "Банк"; }
        }
        public interface IVisitor {
            void VisitHouse(House house);
            void VisitBank(Bank bank);
            void VisitFabric(Fabric fabric);
        }
        public class Agent : IVisitor {
            public void VisitHouse(House house) => Console.WriteLine("Оформить медицинску страховку.");
            public void VisitBank(Bank bank) => Console.WriteLine("Оформить страховку от грабежа");
            public void VisitFabric(Fabric fabric) => Console.WriteLine("Оформить страховку от пожара и наводнения");
        }
        public class Client {
            public static void ClientCode(List<IElement> components, IVisitor visitor) {
                foreach (var component in components) component.Accept(visitor);
            }
        }
        static void Main(string[] args) {
            List<IElement> components = new List<IElement> {
                new House(),
                new Bank(),
                new Fabric()
            };
            var visitor1 = new Agent();
            Client.ClientCode(components, visitor1);
            Console.WriteLine();
        }
    }
}
