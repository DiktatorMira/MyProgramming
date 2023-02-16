using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba16._02._2023 {
    struct ComplexNumber {
        public int Number { get; set; }
        public int ImaginaryNumber { get; set; }
        public ComplexNumber(int number, int imn) {
            Number = number;
            ImaginaryNumber = imn;
        }
        internal ComplexNumber Plus(ComplexNumber obj) {
            ComplexNumber result = new ComplexNumber();
            result.Number = Number + obj.Number;
            result.ImaginaryNumber = ImaginaryNumber + obj.ImaginaryNumber;
            return result;
        }
        internal ComplexNumber Minus(ComplexNumber obj) {
            ComplexNumber result = new ComplexNumber();
            result.Number = Number - obj.Number;
            result.ImaginaryNumber = ImaginaryNumber - obj.ImaginaryNumber;
            return result;
        }
        internal ComplexNumber Mult(ComplexNumber obj) {
            ComplexNumber result = new ComplexNumber();
            result.Number = Number * obj.Number;
            result.ImaginaryNumber = ImaginaryNumber * obj.ImaginaryNumber;
            return result;
        }
        internal ComplexNumber Divide(ComplexNumber obj) {
            ComplexNumber result = new ComplexNumber();
            result.Number = Number / obj.Number;
            result.ImaginaryNumber = ImaginaryNumber / obj.ImaginaryNumber;
            return result;
        }
        public override string ToString() {
            return $"{Number} + {ImaginaryNumber}i";
        }
    }
}
