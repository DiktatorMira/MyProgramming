using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz30._03._2023 {
    public abstract class Iterator : IEnumerator {
        object IEnumerator.Current => CurElem();
        public abstract int CurKeyElem();
        public abstract object CurElem();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
    public abstract class IteratorAggregate : IEnumerable {
        public abstract IEnumerator GetEnumerator();
    }
    class AttractionsIterator : Iterator {
        private Attractions collection;
        private int position = -1;
        private bool reverse = false;
        public AttractionsIterator(Attractions collection, bool reverse = false) {
            this.collection = collection;
            this.reverse = reverse;
            if (reverse) position = collection.GetItems().Count;
        }
        public override object CurElem() { return collection.GetItems()[position]; }
        public override int CurKeyElem() { return position; }
        public override bool MoveNext() {
            int updatedPosition = position + (reverse ? -1 : 1);
            if (updatedPosition >= 0 && updatedPosition < collection.GetItems().Count) {
                position = updatedPosition;
                return true;
            }
            else return false;
        }
        public override void Reset() => position = reverse ? collection.GetItems().Count - 1 : 0;
    }
    class Attractions : IteratorAggregate {
        List<string> collection = new List<string>();
        bool direction = false;
        public void ReverseDirection() => direction = !direction;
        public List<string> GetItems() { return collection; }
        public void AddItem(string item) => collection.Add(item);
        public override IEnumerator GetEnumerator() { return new AttractionsIterator(this, direction); }
    }
    internal class Program {
        static void Main(string[] args) {
            var collection = new Attractions();
            collection.AddItem("Колизей");
            collection.AddItem("Пантеон");
            collection.AddItem("Музей Ватикана");
            collection.AddItem("Собор Святого Петра");
            collection.AddItem("Римский форум");
            collection.AddItem("Замок святого ангела");
            collection.AddItem("Риские катакомбы");
            collection.AddItem("Вилла Боргезе");
            collection.AddItem("Сады Ватикана");
            collection.AddItem("Ара Пацис");
            Console.WriteLine("   С помощь приложения:");
            foreach (var element in collection) {
                if (element == "Колизей") Console.WriteLine("Вы дошли к колизею, потратии 2 часа и 5 евро.");
            }
            Console.WriteLine("\n   С помощью экскурсовода:");
            collection.ReverseDirection();
            foreach (var element in collection) {
                if (element == "Колизей") Console.WriteLine("Вы дошли к колизею, потратии 30 минут и 30 евро.");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
