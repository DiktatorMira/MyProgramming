using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01._03._2023 {
    internal class Program {
        static void Main(string[] args) {
            Play[] play = new Play[100];
            for(int i = 0; i < play.Length; i++)
                play[i] = new Play("Хуй", "еблан иванович мамка", "рвота", 2077);
            Console.ReadKey();
        }
    }
}
