using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz06._02._2023 {
    internal class Program {
        static void Main(string[] args) {
            Website ObjWeb = new Website();
            ObjWeb.Input();
            ObjWeb.Print();
            Magazine ObjMag = new Magazine();
            ObjMag.Input();
            ObjMag.Print();
            Market ObjMark = new Market();
            ObjMark.Input();
            ObjMark.Print();
            Console.ReadKey();
        }
    }
}
