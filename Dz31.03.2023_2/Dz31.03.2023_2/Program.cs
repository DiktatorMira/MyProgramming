using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Dz31._03._2023_2 {
    public interface ISnap {
        string GetName();
        string GetText();
        DateTime GetDate();
    }
    public class Originator {
        private string Text { get; set; }
        public Originator(string text) => Text = text;
        public string RadnomText(int length) {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = null;
            while (length > 0) {
                result += alphabet[new Random().Next(0, alphabet.Length)];
                Thread.Sleep(10);
                length--;
            }
            return result;
        }
        public ISnap SaveSnap() { return new Snap(Text); }
        public void RestoreSnap(ISnap memento) {
            if (!(memento is Snap)) throw new Exception("Неизвестный класс " + memento.ToString());
            Text = memento.GetText();
        }
    }
    public class Snap : ISnap {
        private string Text { get; set; }
        private DateTime Date { get; set; }
        public Snap(string text) {
            Text = text;
            Date = DateTime.Now;
        }
        public string GetName() { return $"{Date} / ({Text.Substring(0, 9)})..."; }
        public string GetText() { return Text; }
        public DateTime GetDate() { return Date; }
    }
    public class SnapController {
        private List<ISnap> snapshots = new List<ISnap>();
        private Originator originator { get; set; } = null;
        public SnapController(Originator orig) => originator = orig;
        public void Redo() => snapshots.Add(originator.SaveSnap());
        public void Undo() {
            if (snapshots.Count == 0) return;
            else if(snapshots.Count > 256) {
                Console.WriteLine("Лимит в 256 раз исчерпан!");
                return;
            }
            var snap = snapshots.Last();
            snapshots.Remove(snap);
            Console.WriteLine("Восстановлен снимок: " + snap.GetName());
            try { originator.RestoreSnap(snap); }
            catch (Exception) { Undo(); }
        }
        public void ShowHistory() {
            foreach (var snap in this.snapshots) Console.WriteLine(snap.GetName());
        }
    }
    internal class Program {
        static void Main(string[] args) {

        }
    }
}
