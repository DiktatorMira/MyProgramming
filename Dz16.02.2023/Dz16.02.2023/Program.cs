using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz16._02._2023 {
    internal class Program {
        public string ToBin() => Convert.ToString(Num, 2);
        static void Main(string[] args) {
            //Vector obj1 = new Vector(4, 5, 6);
            //Vector obj2 = new Vector(9, 8, 7);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
            //Console.WriteLine(obj1.NumberMult(2));
            //Console.WriteLine(obj1.VectorPlus(obj2));
            //Console.WriteLine(obj1.VectorMinus(obj2));
            //DecimalNumber dec = new DecimalNumber(32);
            //Console.WriteLine(dec.ToHexadecimal());
            int Num = 16;
            Program.ToBin(16);
            int R = 255F;
            Console.WriteLine(R);
            Console.ReadKey();
        }
    }
}
