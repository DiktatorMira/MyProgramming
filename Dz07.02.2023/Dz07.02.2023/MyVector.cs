using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dz07._02._2023 {
    internal class MyVector {
        internal double X { get; set; }
        internal double Y { get; set; }
        internal double Z { get; set; }
        public MyVector() {
            X = Y = Z = 0;
        }
        public MyVector(double x) => X = x;
        public MyVector(double x, double y) : this(x) => Y = y;
        public MyVector(double x, double y, double z) : this(x, y) => Z = z;
        public void Input() {
            Console.Write("Введите кординату Х: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Введите кординату Y: ");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Введите кординату Z: ");
            Z = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public void Print() => Console.WriteLine($"X = {X}, Y = {Y}, Z = {Z}");
        public double VectorLength() {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }
        public void PlusVector(double value) {
            X += value;
            Y += value;
            Z += value;
        }
        public void MinusVector(double value) {
            X -= value;
            Y -= value;
            Z -= value;
        }
        public MyVector Sum(MyVector obj2) {
            MyVector result = new MyVector(X + obj2.X, Y + obj2.Y, Z + obj2.Z);
            return result;
        }
        public MyVector Minus(MyVector obj2) {
            MyVector result = new MyVector(X - obj2.X, Y - obj2.Y, Z - obj2.Z);
            return result;
        }
        public MyVector Mult(MyVector obj2) {
            MyVector result = new MyVector(X * obj2.X, Y * obj2.Y, Z * obj2.Z);
            return result;
        }
        public double ScalMult(MyVector obj2) { return (X * obj2.X) + (Y * obj2.Y) + (Z * obj2.Z); }
        public double CornerCos(MyVector obj2) { return ScalMult(obj2) / (VectorLength() * obj2.VectorLength()); }
        public bool Equals(MyVector obj2) {
            if (X == obj2.X && Y == obj2.Y && Z == obj2.Z) return true;
            else return false;
        }
        public override string ToString() { return $"X = {X}, Y = {Y}, Z = {Z}"; }
    }
}
