using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02._03._2023 {
    internal class Poem {
        public string Name { get; set; }
        public string AuthorFIO { get; set; }
        public int Year { get; set; }
        public string Topik { get; set; }
        public string Text { get; set; }
        public Poem() :this(null, null, 0, null) => Text = null;
        public Poem(string name, string fio, int year, string topik) {
            Name = name;
            AuthorFIO = fio;
            Year = year;
            Topik = topik;
            StreamReader file = new StreamReader("Poem.log", Encoding.UTF8);
            Text = file.ReadToEnd();
            file.Close();
        }
        public void NewTextPoem(string text) {
            StreamWriter file = new StreamWriter("Poem.log", false);
            file.Write(text);
            file.Close();
        }
    }
    internal class PoemList {
        Poem[] poems;
        public PoemList() => poems = null;
        public PoemList(Poem[] arr) {
            poems = new Poem[arr.Length];
            for(int i = 0; i < arr.Length; i++) poems[i] = arr[i];
        }
        public void AddPoem(Poem poem) {
            Poem[] temp = poems;
            poems = new Poem[temp.Length + 1];
            for(int i = 0; i < poems.Length; i++) {
                if (i == poems.Length - 1) poems[i] = poem;
                else poems[i] = temp[i];
            }
        }
        public void DeletePoem(int index) {
            poems[index] = null;
            Poem[] temp = poems;
            poems = new Poem[temp.Length - 1];
            for(int i = 0; i < poems.Length; i++) {
                if (temp[i] == null) continue;
                poems[i] = temp[i];
            }
        }
        public void ChangePoem(int index) {
            Console.Write("Введите новое название стиха: ");
            poems[index].Name = Console.ReadLine();
            Console.Write("Введите новое ФИО автора: ");
            poems[index].AuthorFIO = Console.ReadLine();
            Console.Write("Введите новый год написания: ");
            poems[index].Year = int.Parse(Console.ReadLine());
            Console.Write("Введите новую тему стиха: ");
            poems[index].Topik = Console.ReadLine();
            Console.Write("Введите название нового файла текста стиха: ");
            string NewFileName = Console.ReadLine();
            StreamReader file = new StreamReader(NewFileName, Encoding.UTF8);
            poems[index].Text = file.ReadToEnd();
            file.Close();
        }
        public void FindTopikPoem(string topik) {
            bool IsFind = false;
            for(int i = 0; i < poems.Length; i++) {
                if (poems[i].Topik == topik){
                    Console.Write(poems[i].Text);
                    IsFind = true;
                }
            }
            if (IsFind == false) Console.WriteLine("Стихи с заданной темой не найдены.");
        }
        public void SaveToFile() {
            StreamWriter file = new StreamWriter("Poem collections.log", false);
            for(int i = 0; i < poems.Length; i++) {
                file.Write($"Название стиха: {poems[i].Name}\n");
                file.Write($"ФИО автора: {poems[i].AuthorFIO}\n");
                file.Write($"Год написания: {poems[i].Year}\n");
                file.Write($"Тема стиха: {poems[i].Topik}\n");
                file.Write($"Текст стиха:\n {poems[i].Text}\n\n");
            }
            file.Close();
            Console.WriteLine("Коллекция стихов успешно сохранена!");
        }
        public void LoadFromFile() {
            StreamReader file = new StreamReader("\"Poem collections.log", Encoding.UTF8);
            int quan = 0;
            for(int i = 0; i < poems.Length; i++) {
                while(file.Peek() != 0) {
                    poems[i].Name = file.ReadLine();
                    poems[i].AuthorFIO = file.ReadLine();
                    poems[i].Year = int.Parse(file.ReadLine());
                    poems[i].Topik = file.ReadLine();
                    poems[i].Text = file.ReadLine();
                }
                poems[i] = null;
                quan++;
            }
            file.Close();
            Poem[] temp = poems;
            poems = new Poem[temp.Length - quan];
            for(int i = 0; i < poems.Length; i++)
                if (temp[i] != null) poems[i] = temp[i];
        }
    }
}
