using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Dz03._03._2023 {
    internal class Program {
        static void Task1() {
            string str = "ahb acb aeb aeeb adcb axeb";
            string pattern = @"[a]\w[b]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while(matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task2() {
            string str = "aba aca aea abba adca abea";
            string pattern = @"[a]\w{2}[a]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task3() {
            string str = "aba aca aea abba adca abea";
            string pattern = @"[a]\w[^c][a]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task4() {
            string str = "aa aba abba abbba abca abea";
            string pattern = @"[a][b]+[a]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task5() {
            string str = "aa aba abba abbba abca abea";
            string pattern = @"[a][b]*[a]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task6() {
            string str = "aa aba abba abbba abca abea";
            string pattern = @"[a][b]{0,1}[a]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task7() {
            string str = "aa aba abba abbba abca abea";
            string pattern = @"[a][b]*[a]";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success) {
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Task8() {
            string str = "ab abab abab abababab abea";
            string pattern = @"[ab]+";
            Regex temp = new Regex(pattern);
            Match matches = temp.Match(str);
            while (matches.Success){
                Console.Write(matches.Groups[1].Value + " ");
                Console.Write(matches.Value + " ");
                matches = matches.NextMatch();
            }
        }
        static void Main(string[] args) {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            Console.ReadKey();
        }
    }
}
