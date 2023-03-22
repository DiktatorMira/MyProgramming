using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz22._03._2023 {
    internal class Program {
        public class Shop {
            private ICarBuilder builder;
            public Shop(ICarBuilder builder) => this.builder = builder;
            public static Car CreateCar(ICarBuilder builder) {
                builder.CreateFrame();
                builder.CreateEngine();
                builder.CreateWheels();
                builder.CreateCPP();
                return builder.GetCar();
            }
        }
        static void Main(string[] args) {
            Console.WriteLine(Shop.CreateCar(new DaewooLanos()));
        }
    }
}
