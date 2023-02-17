using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba17._02._2023 {
    internal class Arifmetic {
        public int Num { get; set; }
        public Arifmetic() :this(0) { }
        public Arifmetic(int num) => Num = num;
        public bool IsEven() {
            if(Num % 2 == 0) return true;
            else return false;
        }
        public bool IsOdd() {
            if (Num % 2 != 0) return true;
            else return false;
        }
        public bool IsSimple() {
            for(short i = 2; i <= Math.Sqrt(Num); i++)
                if (Num % i == 0) return false; 
            return true;
        }
        public bool IsFibonacci() {
            int y = 1, z = 1, b = 1;
            bool q = false;
            for(short i = 1; i < Num; i++) {
                z = y;
                y = b;
                b = z + y;
                if (b == Num) q = true;
            }
            if (q) return true;
            else return false;
        }
        public delegate bool Func();
    }
}
