using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz16._02._2023 {
    struct DecimalNumber {
        public int Number { get; set; }
        public DecimalNumber(int num) => Number = num;
        internal string ToBinary() {
            string temp = null;
            int temp2 = 0;
            while (Number > 0) {
                temp2 = Number % 2;
                Number = Number / 2;
                temp += Convert.ToString(temp2);
            }
            char[] temp3 = temp.ToCharArray();
            Array.Reverse(temp3);
            return new string(temp3);
        }
        internal string ToOctal() {
            string temp = null;
            int temp2 = 0;
            while (Number > 0)  {
                temp2 = Number % 8;
                Number = Number / 8;
                temp += Convert.ToString(temp2);
            }
            char[] temp3 = temp.ToCharArray();
            Array.Reverse(temp3);
            return new string(temp3);
        }
        internal string ToHexadecimal() {
            string temp = null;
            int temp2 = 0;
            while (Number > 0) {
                temp2 = Number % 16;
                Number = Number / 16;
                switch (temp2){
                    case 10:
                        temp += "A";
                        break;
                    case 11:
                        temp += "B";
                        break;
                    case 12:
                        temp += "C";
                        break;
                    case 13:
                        temp += "D";
                        break;
                    case 14:
                        temp += "E";
                        break;
                    case 15:
                        temp += "F";
                        break;
                    default:
                        temp += Convert.ToString(temp2);
                        break;
                }
            }
            char[] temp3 = temp.ToCharArray();
            Array.Reverse(temp3);
            return new string(temp3);
        }
    }
}
