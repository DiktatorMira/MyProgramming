using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz31._03._2023_1 {
    public interface IBuyer {
        void Update(IMarker subject);
    }
    public interface IMarker {
        void Connect(IBuyer observer);
        void Disconnect(IBuyer observer);
        void Notify();
    }
    public class Market : IMarker {
        public int State { get; set; } = 0;
        private List<IBuyer> buyers = new List<IBuyer>();
        public void Connect(IBuyer buyer) => buyers.Add(buyer); 
        public void Disconnect(IBuyer buyer) => buyers.Remove(buyer);
        public void Notify() { foreach (var buyer in buyers) buyer.Update(this); }
        public void SomeBusinessLogic() {
            State = 1;
            Thread.Sleep(15);
            Notify();
        }
    }
    public class Buyer1 : IBuyer {
        public void Update(IMarker subject) {
            if ((subject as Market).State == 1) Console.WriteLine("Новый товар!");
        }
    }
    public class Buyer2 : IBuyer {
        public void Update(IMarker subject) {
            if ((subject as Market).State == 1) Console.WriteLine("Новый товар!");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            var subject = new Market();
            var observerA = new Buyer1();
            subject.Connect(observerA);
            var observerB = new Buyer2();
            subject.Connect(observerB);
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.Disconnect(observerB);
            subject.SomeBusinessLogic();
        }
    }
}
