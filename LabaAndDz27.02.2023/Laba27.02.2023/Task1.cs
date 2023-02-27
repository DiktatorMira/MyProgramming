using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba27._02._2023 {
    internal class Task1_2 {
        public Temp MyMax<Temp>(Temp num1, Temp num2, Temp num3) where Temp : IComparable {
            Temp max = num1;
            if(num2.CompareTo(max) > 0) max = num2;
            if(num3.CompareTo(max) > 0) max = num3;
            return max;
        }
        public Temp MyMin<Temp>(Temp num1, Temp num2, Temp num3) where Temp : IComparable {
            Temp min = num1;
            if (num2.CompareTo(min) < 0) min = num2;
            if (num3.CompareTo(min) < 0) min = num3;
            return min;
        }
    }
    //internal class Task3<Temp> {
    //    public static Task3<Temp> operator+(Temp a, Temp b) { return a + b; }
    //    public Temp ArrSum(Temp[] arr) {
    //        Temp sum = arr[0];
    //        foreach(Temp i in arr) sum = sum + i;
    //        return sum;
    //    }
    //}
    //internal class Task4 {
    //    public Temp MyPop<Temp>(Temp obj) {
    //        return obj[0];
    //    }
    //    public Temp MyPush<Temp>(Temp obj, Temp elem) {
    //        obj = new obj[obj.Length + 1];
    //        obj[obj.Lenght - 1] = elem;
    //        return obj[obj.Length - 1];
    //    }
    //    public Temp MyPeek<Temp>(Temp obj){
    //        return obj[0];
    //    }
    //    public Temp MyCount<Temp>(Temp obj){
    //        return obj.Length;
    //    }
    //}
    //internal class Task5 {
    //    public Temp MyEndQueue<Temp>(Temp obj, Temp elem){
    //        obj = new obj[obj.Length + 1];
    //        obj[obj.Lenght - 1] = elem;
    //        return obj[obj.Length - 1];
    //    }
    //    public Temp MyDequeue<Temp>(Temp obj) {
    //        return obj[0];
    //    }
    //    public Temp MyPeek<Temp>(Temp obj) {
    //        return obj[0];
    //    }
    //    public Temp MyCount<Temp>(Temp obj) {
    //        return obj.Length;
    //    }
    //}
    internal class DzTask1<Temp> {
        public void MySwap(Temp value1, Temp value2) => (value1, value2) = (value2, value1);
    }
    //internal class DzTask2 {
    //    public Temp MyPop<Temp>(Temp obj) {
    //        return obj[0];
    //    }
    //    public Temp MyPush<Temp>(Temp obj, Temp elem) {
    //        obj = new obj[obj.Length + 1];
    //        obj[obj.Lenght - 1] = elem;
    //        return obj[obj.Length - 1];
    //    }
    //    public Temp MyPeek<Temp>(Temp obj){
    //        return obj[0];
    //    }
    //    public Temp MyCount<Temp>(Temp obj){
    //        return obj.Length;
    //    }
    //}
    //internal class DzTask3 {
    //    public Temp MyPop<Temp>(Temp obj) {
    //        return obj[0];
    //    }
    //    public Temp MyPush<Temp>(Temp obj, Temp elem) {
    //        obj = new obj[obj.Length + 1];
    //        obj[obj.Lenght - 1] = elem;
    //        return obj[obj.Length - 1];
    //    }
    //    public Temp MyPeek<Temp>(Temp obj){
    //        return obj[0];
    //    }
    //    public Temp MyCount<Temp>(Temp obj){
    //        return obj.Length;
    //    }
    //}
}
