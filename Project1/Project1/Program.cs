using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    internal class Program {
        static void Main(string[] args) {
            EngRus obj = new EngRus();
            obj.LoadFromFile();
            obj.Show();
            //obj.Input();
            //obj.SaveToFile();
            Console.ReadKey();
        }
    }
}
