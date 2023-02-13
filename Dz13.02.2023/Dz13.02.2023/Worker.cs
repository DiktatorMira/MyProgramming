using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13._02._2023 {
    internal abstract class Worker {
        internal abstract void Print();
    }
    internal class President : Worker {
        internal override void Print() => Console.WriteLine("Профессия важная, может поднять или опустить страну. Коррумпированный.");
    }
    internal class Security : Worker {
        internal override void Print() => Console.WriteLine("Защищает того, кто нанял. Но может и воткнуть нож в спину.");
    }
    internal class Manager : Worker {
        internal override void Print() => Console.WriteLine("Конечно важная, но скучная работа.");
    }
    internal class Engineer : Worker {
        internal override void Print() => Console.WriteLine("Грязная работа, но без них ничего бы не работало.");
    }
}
