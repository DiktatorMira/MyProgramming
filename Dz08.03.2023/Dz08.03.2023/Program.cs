using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using static Dz08._03._2023.Program;
using System.Security.Policy;
using System.IO;


namespace Dz08._03._2023 {
    internal class Program {
        [Serializable]
        [DataContact]
        public class Device {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Firm { get; set; }
            [DataMember]
            public int Price { get; set; }
            public Device() :this(null, null, 0) { }
            public Device(string name, string firm, int price) {
                Name = name;
                Firm = firm;
                Price = price;
            }
        }
        [KnownType(typeof(Device))]
        [XmlInclude(typeof(Device))]
        public class Sort : IEqualityComparer<Device> {
            public bool Equals(Device x, Device y) {
                if (x.Name == y.Name) return true;
                return false;
            }
            public int GetHashCode(Device obj)  { return obj.Name.GetHashCode(); }
        }
        static void Main(string[] args) {
            Device obj1 = new Device("Lumia 1", "Nokia", 1200);
            Device obj2 = new Device("Lumia 3", "Nokia", 1800);
            Device obj3 = new Device("9 pro", "One Plus", 15000);
            Device[] mass1 = { obj1, obj2, obj3 };
            Device obj4 = new Device("X", "Iphone", 20000);
            Device obj5 = new Device("Mi Note 10 lite", "Xiaomi", 8000);
            Device obj6 = new Device("S20", "Samsung", 25000);
            Device[] mass2 = { obj1, obj2, obj3 };
            var MinusArr = mass1.Except(mass2);
            var PeresechArr = mass1.Intersect(mass2);
            var UniteArr = mass1.Union(mass2);
            List<int> l = new List<int>();
            FileStream stream = new FileStream("../../list.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
            serializer.Serialize(stream, l);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
            stream = new FileStream("../../data.json", FileMode.Create);
            Device obj7 = new Device("S20", "Samsung", 25000);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Device));
            jsonFormatter.WriteObject(stream, obj7);
            stream.Close();
            Console.WriteLine("Сериализация успешно выполнена!");
        }
    }
}
