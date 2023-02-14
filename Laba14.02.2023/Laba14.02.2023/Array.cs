using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14._02._2023 {
    internal abstract class MyArray : IOutput, IMath, ISort {
        int[] arr;
        internal MyArray() => arr = null;
        internal MyArray(int size) => arr = new int[size];
        internal MyArray(params int[] mass) { 
            for(short i = 0; i < arr.Length; i++)
                arr[i] = mass[i];
        }
        public void Show() {
            foreach(int i in arr)
                Console.Write(i + " ");
        }
        public void Show(string info) {
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine($"\n{info}");
        }
        public int Max() { return arr.Max(); }
        public int Min() { return arr.Min(); }
        public double Avg() { return arr.Average(); }
        public bool Search(int find) { return (Array.BinarySearch(arr, find) > 0) ? true : false; }
        public void SortAsc() => Array.Sort(arr);
        public void SortDesc() {
            for(int i = 0; i < arr.Length; i++) {
                for(int j = i + 1; j < arr.Length - 1; j++) {
                    if (arr[j] < arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }      
                }
            }
        }
        public void SortByParam(bool is_asc) {
            if (is_asc == false) {
                for (int i = 0; i < arr.Length; i++) {
                    for (int j = i + 1; j < arr.Length - 1; j++) {
                        if (arr[j] < arr[j + 1]) {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            else Array.Sort(arr);
        }
    }
}
