using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Dz28._03._2023 {
    public class TransportFactory {
        private List<Transport> transports = new List<Transport>();
        public void GetTransport(Transport type) {
            if(!transports.Contains(type)) transports.Add(type);
            transports.Where(t => t == type).FirstOrDefault().ToString();
        }
    }
    internal class Program {
        static void Main(string[] args) {
            TransportFactory factory = new TransportFactory();
            LightInfantry tr = new LightInfantry();
            Console.WriteLine(factory.GetTransport(tr));
        }
    }
}
