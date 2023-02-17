using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba17._02._2023 {
    internal class Mathematics {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public Mathematics() :this(0, 0) { }
        public Mathematics(int num1, int num2) {
            Num1 = num1;
            Num2 = num2;
        }
        public int Plus() { return Num1 + Num2; }
        public int Minus() { return Num1 - Num2; }
        public int Mult() { return Num1 * Num2; }
        public int Divide() { return Num1 / Num2; }
        public delegate int Functions();
    }
}
