using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz21._02._2023 {
    delegate void MyDlg(string new_item, MyDlg dlg);
    internal class Backpack {
        public string Color { get; set; }
        public string Firma { get; set; }
        public string Cloth { get; set; }
        public string Weight { get; set; }
        public string Capacity { get; set; }
        public string[] Content { get; set; }
        public Backpack():this(null, null, null, null, null, null) { }
        public Backpack(string color, string firma, string cloth, string weight, string capacity, string[] content) {
            Color = color;
            Firma = firma;
            Cloth = cloth;
            Weight = weight;
            Capacity = capacity;
            for(short i = 0; i < content.Length; i++)
                Content[i] = content[i];
        }
        public void AddObject(string new_item, MyDlg dlg) {
            string[] temp = new string[Content.Length];
            for(short i = 0; i < Content.Length; i++)
                temp[i] = Content[i];
            Content = new string[Content.Length + 1];
            for (short i = 0; i < Content.Length; i++) {
                if (i == Content.Length - 1) Content[i] = new_item;
                Content[i] = temp[i];
            }
        }
    }
}
