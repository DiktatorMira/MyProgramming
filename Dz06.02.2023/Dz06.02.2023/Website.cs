using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz06._02._2023 {
    public class Website {
        string name, path, description, ip;
        internal string Name{
            get { return name;}
            set { name = value; }
        }
        internal string Path{
            get { return path; }
            set { path = value; }
        }
        internal string Description{
            get { return description; }
            set { description = value; }
        }
        internal string Ip{
            get { return ip; }
            set { ip = value; }
        }
        internal Website() {
            name = path = description = ip = null;
        }
        internal void Input() {
            Console.Write("Введите название сайта: ");
            name = Console.ReadLine();
            Console.Write("Введите путь к сайту: ");
            path = Console.ReadLine();
            Console.Write("Введите описание сайта: ");
            description = Console.ReadLine();
            Console.Write("Введите ip-адресс сайта: ");
            ip = Console.ReadLine();
            Console.WriteLine();
        }
        internal void Print(){
            Console.WriteLine($"Название сайта: {name}");
            Console.WriteLine($"Путь к сайту: {path}");
            Console.WriteLine($"Описание сайта: {description}");
            Console.WriteLine($"Ip-адресс сайта: {ip}");
        }
    }
}
