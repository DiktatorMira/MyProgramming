using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10._02._2023 {
    internal class Matrix {
        int[,] matrix = new int[5, 5];
        internal Matrix() {
            for (short i = 0; i < matrix.GetLength(0); i++) {
                for (short j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = 0;
                }
            }
        }
        internal Matrix(int[,] matrix) {
            Random rand = new Random();
            for (short i = 0; i < matrix.GetLength(0); i++) {
                for (short j = 0; j < matrix.GetLength(1); j++) {
                    this.matrix[i, j] = rand.Next(1, 100);
                }
            }
        }
        internal int Max() {
            int max = matrix[0, 0];
            foreach (int i in matrix)
                if (max < i) max = i;
            return max;
        }
        internal int Min() {
            int min = matrix[0, 0];
            foreach (int i in matrix)
                if (min > i) min = i;
            return min;
        }
        internal void Print() {
            for (short i = 0; i < matrix.GetLength(0); i++) {
                for (short j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public override string ToString() {
            string Text = "";
            foreach (int i in matrix)
                Text += i;
            return $"{Text}";
        }
        public int this[int rows, int cols] {
            get {
                if (rows < 0 && rows >= matrix.GetLength(0)) throw new Exception($"Неправильный индекс {rows}!");
                else if (cols < 0 && cols >= matrix.GetLength(1)) throw new Exception($"Неправильный индекс {rows}!");
                else return matrix[rows, cols];
            }
            set {
                if (rows < 0 && rows >= matrix.GetLength(0)) throw new Exception($"Неправильный индекс {rows}!");
                else if (cols < 0 && cols >= matrix.GetLength(1)) throw new Exception($"Неправильный индекс {rows}!");
                else matrix[rows, cols] = value;
            }
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2) {
            Matrix result = new Matrix();
            for (short i = 0; i < result.matrix.GetLength(0); i++) {
                for (short j = 0; j < result.matrix.GetLength(1); j++) {
                    result.matrix[i, j] = obj1.matrix[i, j] + obj2.matrix[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2) {
            Matrix result = new Matrix();
            for (short i = 0; i < result.matrix.GetLength(0); i++) {
                for (short j = 0; j < result.matrix.GetLength(1); j++) {
                    result.matrix[i, j] = obj1.matrix[i, j] - obj2.matrix[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix obj1, Matrix obj2) {
            Matrix result = new Matrix();
            for (short i = 0; i < result.matrix.GetLength(0); i++) {
                for (short j = 0; j < result.matrix.GetLength(1); j++) {
                    result.matrix[i, j] = obj1.matrix[i, j] * obj2.matrix[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix obj, int value) {
            Matrix result = new Matrix();
            for (short i = 0; i < result.matrix.GetLength(0); i++) {
                for (short j = 0; j < result.matrix.GetLength(1); j++) {
                    result.matrix[i, j] = obj.matrix[i, j] * value;
                }
            }
            return result;
        }
        public static bool operator <(Matrix obj1, Matrix obj2) {
            int MatrixSum1 = 0, MatrixSum2 = 0;
            for (short i = 0; i < obj1.matrix.GetLength(0); i++) {
                for (short j = 0; j < obj1.matrix.GetLength(1); j++) {
                    MatrixSum1 += obj1.matrix[i, j];
                    MatrixSum2 += obj2.matrix[i, j];
                }
            }
            if (MatrixSum1 < MatrixSum2) return true;
            else return false;
        }
        public static bool operator >(Matrix obj1, Matrix obj2) {
            int MatrixSum1 = 0, MatrixSum2 = 0;
            for (short i = 0; i < obj1.matrix.GetLength(0); i++) {
                for (short j = 0; j < obj1.matrix.GetLength(1); j++) {
                    MatrixSum1 += obj1.matrix[i, j];
                    MatrixSum2 += obj2.matrix[i, j];
                }
            }
            if (MatrixSum1 > MatrixSum2) return true;
            else return false;
        }
        public static bool operator ==(Matrix obj1, Matrix obj2) {
            int MatrixSum1 = 0, MatrixSum2 = 0;
            for (short i = 0; i < obj1.matrix.GetLength(0); i++) {
                for (short j = 0; j < obj1.matrix.GetLength(1); j++) {
                    MatrixSum1 += obj1.matrix[i, j];
                    MatrixSum2 += obj2.matrix[i, j];
                }
            }
            if (MatrixSum1 == MatrixSum2) return true;
            else return false;
        }
        public static bool operator !=(Matrix obj1, Matrix obj2) {
            int MatrixSum1 = 0, MatrixSum2 = 0;
            for (short i = 0; i < obj1.matrix.GetLength(0); i++) {
                for (short j = 0; j < obj1.matrix.GetLength(1); j++) {
                    MatrixSum1 += obj1.matrix[i, j];
                    MatrixSum2 += obj2.matrix[i, j];
                }
            }
            if (MatrixSum1 != MatrixSum2) return true;
            else return false;
        }
    }
}
