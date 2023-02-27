using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba27._02._2023 {
    internal class Program {
        static void Main(string[] args) {
            Task1_2 obj = new Task1_2();
            Console.WriteLine(obj.MyMax(7, 6, 5));
            Console.WriteLine(obj.MyMin(7, 6, 5));
            Console.ReadKey();
        }
    }
}
