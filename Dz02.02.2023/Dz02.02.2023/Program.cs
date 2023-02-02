using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02._02._2023 {
    internal class Program {
        static void Task1() {
            Console.WriteLine("\tЗадание 1");
            Random rand = new Random();
            int[][] arr = new int[rand.Next(3, 8)][];
            int[] ElemArr = new int[arr.Length];
            int ElemMax = 0, ElemMin = 0, max = 0, min = 100;
            for (short i = 0; i < arr.Length; i++) {
                arr[i] = new int[rand.Next(3, 8)];
                ElemArr[i] = arr[i].Length;
                if (max < ElemArr[i]) {
                    max = ElemArr[i];
                    ElemMax = i;
                }
                if(min > ElemArr[i]){
                    min = ElemArr[i];
                    ElemMin = i;
                }
            }
            for(short i = 0; i < arr.Length; i++) {
                for(short j = 0; j < arr[i].Length; j++) {
                    arr[i][j] = rand.Next(1, 100);
                    Console.Write("{0,4}", arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(short i = 0; i < arr.Length; i++){
                if (i == ElemMax) {
                    arr[i] = arr[ElemMin];
                    arr[ElemMin] = arr[ElemMax];
                }
            }
            for (short i = 0; i < arr.Length; i++) {
                for (short j = 0; j < arr[i].Length; j++) {
                    Console.Write("{0,4}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Task2(){
            Console.WriteLine("\tЗадание 2");
            int[][] arr = new int[4][];
            int j = 6;
            for(short i = 0; i < arr.Length; i++, j--) {
                if (i == arr.Length - 1){
                    arr[i] = new int[2];
                }
                else {
                    arr[i] = new int[j];
                }
            }
            Random rand = new Random();
            for(short i = 0; i < arr.Length; i++) {
                for(short k = 0; k < arr[i].Length; k++){
                    arr[i][k] = rand.Next(1, 100);
                    Console.Write(arr[i][k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args) {
            Program.Task1();
            Program.Task2();
        }
    }
}
