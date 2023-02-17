using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz17._02._2023 {
    internal class MyArray {
        int[] array;
        public MyArray() => array = null;
        public MyArray(int size) => array = new int[size];
        public MyArray(params int[] arr) {
            for(short i = 0; i < array.Length; i++)
                array[i] = arr[i];
        }
        public void EvenNumbers() {
            foreach(int i in array)
                if(i % 2 == 0) Console.WriteLine(i + " ");
        }
        public void OddNumbers() {
            foreach (int i in array)
                if (i % 2 != 0) Console.WriteLine(i + " ");
        }
        public void SimpleNumbers(){
            foreach (int i in array) {
                for (short j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0) Console.WriteLine(i + " ");
            }
        }
        public void FibonacciNumbers() {
            foreach (int i in array) {
                int y = 1, z = 1, b = 1;
                bool q = false;
                for (short j = 1; j < i; j++) {
                    z = y;
                    y = b;
                    b = z + y;
                    if (b == i) q = true;
                }
                if (q) Console.WriteLine(i + " ");
            }
        }
        public delegate void Functions();
    }
}
