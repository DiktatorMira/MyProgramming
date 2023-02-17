using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz17._02._2023 {
    internal class Methods {
        public void NowTime() => Console.WriteLine(DateTime.Now.ToString());
        public void DayOfWeek() {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek.ToString());
        }
        public double TriangleArea(int a, int b) {
            return 0.5 * a * b * Math.Sin(a) * Math.Sin(b);
        }
        public double RectangleArea(int a, int b) {
            return a * b;
        }
        public delegate void Time();
        public delegate double Area(int a, int b);
    }
}
