using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba16._02._2023 {
    struct Fractional {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fractional(int numer, int denom) {
            Numerator= numer;
            Denominator = denom;
        }
        internal Fractional Plus(Fractional obj) {
            Fractional result = new Fractional();
            if (Denominator == obj.Denominator) {
                result.Numerator = Numerator + obj.Numerator;
                result.Denominator = Denominator;
            }
            else {
                result.Denominator = Denominator * obj.Denominator;
                result.Numerator = (Numerator * obj.Denominator) + (obj.Numerator * Denominator);
            }
            return result;
        }
        internal Fractional Minus(Fractional obj) {
            Fractional result = new Fractional();
            if (Denominator == obj.Denominator) {
                result.Numerator = Numerator - obj.Numerator;
                result.Denominator = Denominator;
            }
            else {
                result.Denominator = Denominator * obj.Denominator;
                result.Numerator = (Numerator * obj.Denominator) - (obj.Numerator * Denominator);
            }
            return result;
        }
        internal Fractional Mult(Fractional obj) {
            Fractional result = new Fractional();
            result.Numerator = Numerator * obj.Numerator;
            result.Denominator = Denominator * obj.Denominator;
            return result;
        }
        internal Fractional Divide(Fractional obj) {
            Fractional result = new Fractional();
            result.Numerator = Numerator * obj.Denominator;
            result.Denominator = Denominator * obj.Numerator;
            return result;
        }
        public override string ToString() { return $"{Numerator}/{Denominator}"; }
    }
}
