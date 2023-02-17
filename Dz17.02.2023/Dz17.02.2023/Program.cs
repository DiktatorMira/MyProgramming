using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dz17._02._2023.Methods;
using static Dz17._02._2023.MyArray;

namespace Dz17._02._2023
{
    internal class Program {
        static void Main(string[] args) {
            //int[] mass = { 5, 18, 22, 3, 56, 128, 14 };
            //MyArray arr = new MyArray(mass);
            //Functions[] ArrPtr = { arr.EvenNumbers, arr.OddNumbers, arr.SimpleNumbers, arr.FibonacciNumbers };
            //foreach (Functions i in ArrPtr)
            //    i();
            Methods meth = new Methods();
            Time[] MethTime = { meth.NowTime, meth.DayOfWeek };
            Area[] MethArea = { meth.TriangleArea, meth.RectangleArea };
        }
    }
}
