using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01._02._2023 {
    internal class Program {
        static int CharToInt( char a) {
            switch (a) {
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case '0': return 0;
            }
            return -1;
        }
        static int StrToInt(string str) {
            int i = 0, mult = 1;
            if (str[0] == '-') {
                i = 1;
                mult = -1;
            }
            int retInt = CharToInt(str[i]);
            i++;
            for(; i < str.Length; i++) {
                retInt *= 10;
                retInt += CharToInt(str[i]);
            }
            retInt *= mult;
            return retInt;
        }
        static void Task1() {
            Console.WriteLine("\tЗадание 1");
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            for (short i = 0; i < A.Length; i++) {
                Console.Write("Введите " + (i + 1) + " число: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in A) {
                Console.Write("{0, 4}", i);
            }
            Console.WriteLine();
            Random rand = new Random();
            for (short i = 0; i < B.GetLength(0); i++) {
                for (short j = 0; j < B.GetLength(1); j++) {
                    B[i, j] = rand.NextDouble() * 10;
                    Console.Write("{0:F2}\t", B[i, j]);
                }
                Console.WriteLine();
            }
            double max = A[0], min = A[0], sum = 0, mult = 0, ChetSum = 0, NechetSum = 0;
            for(int i = 0; i < A.Length; i++) {
                if(max < A[i]) {
                    max = A[i];
                }
                if(min > A[i]){
                    min = A[i];
                }
                sum += A[i];
                mult *= A[i];
                if (A[i] % 2 == 0) {
                    ChetSum += A[i];
                }
            }
            for (short i = 0; i < B.GetLength(0); i++) {
                for (short j = 0; j < B.GetLength(1); j++) {
                    if(max < B[i, j]) {
                        max = B[i, j];
                    }
                    if (min > B[i, j]) {
                        min = A[i];
                    }
                    sum += B[i, j];
                    mult += A[i];
                    if (B[i, j] % 2 != 0){
                        NechetSum+= B[i, j];
                    }
                }
            }
            Console.WriteLine("Общий максимум: " + max + ". Общий минимум: " + min + ".");
            Console.WriteLine("Общая сумма: " + sum + ". Общее произведение: " + mult + ".");
            Console.WriteLine("Сумма четных A: " + ChetSum + ". Сумма нечетных B: " + NechetSum + ".");
            Console.WriteLine();
        }
        static void Task2() {
            Console.WriteLine("\tЗадание 2");
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            for(short i = 0; i < arr.GetLength(0); i++) {
                for(short j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
            int max = arr[0,0], min = arr[0,0], sum = 0;
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    if(max < arr[i, j]) {
                        max = arr[i, j];
                    }
                    if(min > arr[i, j]) {
                        min = arr[i, j];
                    }
                }
            }
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    if (arr[i,j] != max && arr[i,j] != min) {
                        sum += arr[i,j];
                    }
                }
            }
            Console.WriteLine("Сумма без макс и мин: " + sum);
            Console.WriteLine();
        }
        static void Task4() {
            Console.WriteLine("\tЗадание 4");
            int[,] arr = new int[4, 4];
            int[,] arr2 = new int[4, 4];
            int[,] arr3 = new int[4, 4];
            int[,] DopArr1 = new int[4, 4];
            int[,] DopArr2 = new int[4, 4];
            Random rand = new Random();
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] = rand.Next(1, 10);
                    DopArr1[i, j] = rand.Next(1, 10);
                    DopArr2[i, j] = rand.Next(1, 10);
                    Console.Write("{0, 4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Введите число на которое хотите умножить матрицу: ");
            int num1 = int.Parse(Console.ReadLine());
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    arr2[i, j] = arr[i, j];
                }
            }
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] *= num1;
                    Console.Write("{0, 4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    arr3[i, j] = arr2[i, j];
                }
            }
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    arr2[i, j] += DopArr1[i, j];
                    Console.Write("{0, 4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (short i = 0; i < arr.GetLength(0); i++) {
                for (short j = 0; j < arr.GetLength(1); j++) {
                    arr3[i, j] *= DopArr1[i, j];
                    Console.Write("{0, 4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Task5() {
            Console.WriteLine("\tЗадание 5");
            //int[] Arr = new int[6];
            //int Max = 0, count = 0;
            //int result = 0;
            //string znaki = "";
            //string tmp = "";
            //bool Open = false;
            //for (int i = 0; i < 6; i++)
            //    Arr[i] = 0;
            //Console.Write("Пиши: ");
            //string Input = Console.ReadLine();
            //for (int i = 0; i < Input.Length; i++){
            //    if (Open && Input[i] != ')') {
            //        tmp += Input[i];
            //    }
            //    else if (isdigit(Input[i])) {
            //        string tmpstr = "";
            //        while (isdigit(Input[i])) {
            //            tmpstr += Input[i];
            //            i++;
            //        }
            //        i--;
            //        Arr[count] = StrToInt(tmpstr);
            //        count++;
            //    }
            //    else if (Input[i] == '+' || Input[i] == '-' || Input[i] == '*' || Input[i] == '/')
            //    {
            //        znaki += Input[i];
            //    }
            //    else if (Input[i] == '(' || Input[i] == ')')
            //    {
            //        if (Input[i] == ')')
            //        {
            //            Open = false;
            //            Arr[count] = StrToInt(tmp);
            //            count++;
            //            tmp = "";
            //        }
            //        else Open = true;
            //    }

            //}
            //count = 1;
            //result += Arr[0];
            //for (int i = 0; i < znaki.Length; i++)
            //{
            //    if (znaki[i] == '+')
            //    {
            //        result += Arr[count];
            //        count++;
            //    }
            //    else if (znaki[i] == '-')
            //    {
            //        result -= Arr[count];
            //        count++;
            //    }
            //    else if (znaki[i] == '/')
            //    {
            //        result /= Arr[count];
            //        count++;
            //    }
            //    else if (znaki[i] == '*')
            //    {
            //        result *= Arr[count];
            //        count++;
            //    }
            //}
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine();
        }
        static void Task6() {
            //Console.WriteLine("\tЗадание 6");
            //Console.Write("Введите текст: ");
            //string text = Console.ReadLine();
            //for(short i = 0; i <text.Length; i++) {
            //    if (text[i] == '.') {
            //        text[i + 2].ToUpper();
            //    }
            //}
        }
        static void Task7(){
            Console.WriteLine("\tЗадание 7");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string NONO = "die";
            for(short i = 0; i < text.Length; i++) {
                for(short j = 0; j < NONO.Length; j++) {
                    if (text[i] == NONO[j]){
                        text[i] = '*';
                    }
                }
            }
        }
        static void Main(string[] args) {
            //Program.Task1();
            //Program.Task2();
            //Program.Task3();
            //Program.Task4();
            //Program.Task5();
            //Program.Task6();
            //Program.Task7();
        }
    }
}
