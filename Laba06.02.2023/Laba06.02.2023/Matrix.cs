using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba06._02._2023 {
    internal class Matrix {
        int[,] matrix = new int[5,5];
        Matrix() {
            for(short i = 0; i < matrix.GetLength(0); i++) {
                for(short j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = 0;
                }
            }
        }
        Matrix(int[,] matrix) {
            Random rand = new Random();
            for (short i = 0; i < matrix.GetLength(0); i++) {
                for (short j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
        }
        internal int Max(){
            int max = matrix[0, 0];
            foreach(int i in matrix) {
                if(max < i) {
                    max = i;
                }
            }
            return max;
        }
        internal int Min(){
            int min = matrix[0, 0];
            foreach (int i in matrix){
                if (min > i) {
                    min = i;
                }
            }
            return min;
        }
        internal void Print(){
            for (short i = 0; i < matrix.GetLength(0); i++) {
                for (short j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public override string ToString() {
            string Text = "";
            foreach(int i in matrix) {
                Text += i;
            }
            return $"{Text}";
        }
    }
}
