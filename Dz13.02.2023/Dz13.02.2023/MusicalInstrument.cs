using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz13._02._2023 {
    internal abstract class MusicalInstrument {
        internal abstract void Show();
        internal abstract void Desc();
        internal abstract void Sound();
        internal abstract void History();
    }
    internal class Violin : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Скрипка");
        internal override void Desc() => Console.WriteLine("Описание: В неумелых руках может взорвать перепонки.");
        internal override void Sound() => Console.WriteLine("иииии... *душераздирающий звук*");
        internal override void History() => Console.WriteLine("История: Была создана, по всей видимости, глухим человеком.");
    }
    internal class Trombone : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Тромбон");
        internal override void Desc() => Console.WriteLine("Описание: Нет блин, тампон, кхм... Это музыкальный инструмент... а что?");
        internal override void Sound() => Console.WriteLine("*низкий звук*");
        internal override void History() => Console.WriteLine("История: Нуу... что сказать... его создали.");
    }
    internal class Ukulele : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Укулеле");
        internal override void Desc() => Console.WriteLine("Описание: Смешное название.");
        internal override void Sound() => Console.WriteLine("дрынь");
        internal override void History() => Console.WriteLine("История: судя по названию создан на Гавайях.");
    }
    internal class Cello : MusicalInstrument {
        internal override void Show() => Console.WriteLine("Виолончель");
        internal override void Desc() => Console.WriteLine("Описание: Младшая сестра скрипки.");
        internal override void Sound() => Console.WriteLine("иыиыиыииыыи");
        internal override void History() => Console.WriteLine("История: если б знал - сказал.");
    }
}
