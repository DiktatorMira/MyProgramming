using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba28._02._2023 {
    internal class Program {
        static void Laba() {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] TextArr = text.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string str in TextArr) {
                if (dic.ContainsKey(str)) dic[str]++;
                else dic.Add(str, 1);  
            }
            foreach (KeyValuePair<string, int> pair in dic)
                Console.WriteLine($"{pair.Key} — {pair.Value}");
        }
        static void Dz() {
            Dictionary<string, string> EngRus = new Dictionary<string, string>();
            Dictionary<string, string> RusEng = new Dictionary<string, string>();
            EngRus.Add("Australia", "Австралия");
            EngRus.Add("Ukraine", "Украина");
            EngRus.Add("United Kingdom", "Великобритания");
            EngRus.Add("Germany", "Германия");
            EngRus.Add("United States of America", "Соедниенные Штаты Америки");
            RusEng.Add("Австралия", "Australia");
            RusEng.Add("Украина", "Ukraine");
            RusEng.Add("Великобритания", "United Kingdom");
            RusEng.Add("Германия", "Germany");
            RusEng.Add("Соедниенные Штаты Америки", "United States of America");
            int[] choose = new int[2];
            Console.Write("Введите какой перевод выбрать:(1-англ-рус; 2-рус-англ): ");
            choose[0] = int.Parse(Console.ReadLine());
            switch (choose[0]) {
                case 1:
                    foreach (KeyValuePair<string, string> pair in EngRus)
                        Console.WriteLine($"{pair.Key} — {pair.Value}");
                    break;
                case 2:
                    foreach (KeyValuePair<string, string> pair in RusEng)
                        Console.WriteLine($"{pair.Key} — {pair.Value}");
                    break;
                default:
                    Console.WriteLine("Было введено неверное значение!");
                    break;
            }
        }
        static void Main(string[] args) {
            Laba();
            Dz();
            Console.ReadKey();
        }
    }
}
