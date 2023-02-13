using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13._02._2023 {
    internal abstract class Device {
        internal abstract void Show();
        internal abstract void Desc();
        internal abstract void Sound();
    }
    internal class Kettle : Device {
        internal override void Show() => Console.WriteLine("Чайник");
        internal override void Desc() => Console.WriteLine("Описание: Позволяет кипятить воду.");
        internal override void Sound() => Console.WriteLine("шшшшшшш-шшшшшшш");
    }
    internal class Car : Device {
        internal override void Show() => Console.WriteLine("Автомобиль");
        internal override void Desc() => Console.WriteLine("Описание: Довезет в любую точку, даже в могилу.");
        internal override void Sound() => Console.WriteLine("брх-рррр-крх");
    }
    internal class Steamer : Device {
        internal override void Show() => Console.WriteLine("Пароход");
        internal override void Desc() => Console.WriteLine("Описание: Рассекает водную гладь планеты Земля.");
        internal override void Sound() => Console.WriteLine("тууууууууу");
    }
}
