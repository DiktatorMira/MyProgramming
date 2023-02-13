using System;

namespace Laba13._02._2023 {
    internal class MainClass {
        static void Main(string[] args) {
            Figure[] ptr = new Figure[4];
            ptr[0] = new Rectangle();
            ptr[1] = new Circle();
            ptr[2] = new RightTriangle();
            ptr[3] = new Trapezoid();
        }
    }
}
