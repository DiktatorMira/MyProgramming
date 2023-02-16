using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz16._02._2023 {
    struct Vector {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vector(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }
        internal Vector NumberMult(double value) {
            Vector result = new Vector(X * value, Y * value, Z * value);
            return result;
        }
        internal Vector VectorPlus(Vector obj) {
            Vector result = new Vector(X + obj.X, Y + obj.Y, Z + obj.Z);
            return result;
        }
        internal Vector VectorMinus(Vector obj) {
            Vector result = new Vector(X - obj.X, Y - obj.Y, Z - obj.Z);
            return result;
        }
        public override string ToString() { return $"X: {X}|Y: {Y}|Z: {Z}"; }
    }
}
