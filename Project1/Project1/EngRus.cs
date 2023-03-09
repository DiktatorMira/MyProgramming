using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    internal class EngRus {
        public List<Tuple<string, string>> MyDictionary { get; set; }
        public int Count { get; set; }
        public EngRus() {
            MyDictionary = new List<Tuple<string, string>>();
            Count = MyDictionary.Count;
        }
        public Tuple<string, string> GetList(int index) {
            if (index < 0 || index >= Count) throw new Exception("Выход за пределы List!");
            return MyDictionary[index];
        }
        public void AddTranslate(string EngWord, string RusWord) {
            MyDictionary.Add(Tuple.Create(EngWord, RusWord));
            Count = MyDictionary.Count;
        }
        public void Input() {
            do {
                Console.Write("Добавьте новое слово на англ: ");
                string text1 = Console.ReadLine();
                Console.Write("Добавьте вариант переводана русский: ");
                string text2 = Console.ReadLine();
                MyDictionary.Add(Tuple.Create(text1, text2));
                Count = MyDictionary.Count;
                Console.Write("Хотите ли вы продолжить?(0-нет, 1-да): ");
                int choose = int.Parse(Console.ReadLine());
                if(choose == 0) break;
            }while(true);
        }
        public void Show() {
            for(int i = 0; i < MyDictionary.Count; i++) Console.WriteLine($"{MyDictionary[i].Item1} - {MyDictionary[i].Item2}");
        }
        public void SaveToFile() {
            StreamWriter file = new StreamWriter("EngRus.log", false);
            for(int i = 0; i < Count; i++)
                file.WriteLine(MyDictionary[i].Item1 + " - " + MyDictionary[i].Item2);
            file.Close();
        }
        public void LoadFromFile() {
            StreamReader file = new StreamReader("EngRus.log", Encoding.UTF8);
            while (file.EndOfStream != true) {
                string buff = file.ReadLine();
                string buff2 = buff.Substring(0, buff.IndexOf("-") - 1);
                string buff3 = buff.Substring(buff.IndexOf("-") + 2, buff.Length - (buff.IndexOf("-") + 2));
                MyDictionary.Add(Tuple.Create(buff2, buff3));
            }
            file.Close();
        }
        public IEnumerator GetEnumerator() {
            for(int i = 0; i < MyDictionary.Count; i++)
                yield return MyDictionary[i].Item1 + " - " + MyDictionary[i].Item2;
        }
    }
}
