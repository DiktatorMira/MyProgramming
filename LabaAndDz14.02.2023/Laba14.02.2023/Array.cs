using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14._02._2023 {
    internal abstract class MyArray : IOutput, IMath, ISort, ICalc, IUltraOutput, ICalcPro {
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
            Array.Sort(arr);
            Array.Reverse(arr);
        }
        public void SortByParam(bool is_asc) {
            if (is_asc == false) {
                Array.Sort(arr);
                Array.Reverse(arr);
            }
            else Array.Sort(arr);
        }
        public int Less(int value) {
            int less_count = 0;
            foreach(int i in arr)
                if (i < value) less_count++;
            return less_count;
        }
        public int More(int value) {
            int more_count = 0;
            foreach (int i in arr)
                if (i > value) more_count++;
            return more_count;
        }
        public void ShowEven() {
            foreach(int i in arr) {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
        public void ShowOdd() {
            foreach (int i in arr) {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }
        public int UniqueCount() {
            int unique = 0;
            for(int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; i < arr.Length; j++)
                    if (arr[i] != arr[j]) unique++;
            }
            return unique;
        }
        public int EqualToValue(int value) {
            int count = 0;
            foreach(int i in arr)
                if(i == value) count++;
            return count;
        }
    }
}
