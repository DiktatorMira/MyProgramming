using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz25._04._2023 {
    public partial class Form1 : Form {
        List<string> words = new List<string>();
        List<Button> buttons;
        public Form1() {
            InitializeComponent();
            using (StreamReader file = new StreamReader("dictionary.txt", Encoding.UTF8)) {
                while (!file.EndOfStream) words.Add(file.ReadLine());
            }
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(richTextBox1.Text)) {
                for (int i = 0; i < richTextBox1.Text.Length; i++) {
                    foreach(string word in words) {
                        if (i != 0 && richTextBox1.Text[i] == word[0] && richTextBox1.Text[i - 1] == ' ') {
                            for (int j = 1; j < word.Length; j++) {
                                richTextBox1.Text += word[j];
                            }
                        }
                    }
                }
            }
        }
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e) {
            foreach (Button button in buttons) button.BackColor = Color.White;
            switch (e.KeyCode) {
                case Keys.F:
                case Keys.Oemcomma:
                case Keys.D:
                case Keys.U:
                    button1.BackColor = Color.Aquamarine;
                    break;
                case Keys.L:
                case Keys.T:
                case Keys.Oemtilde:
                case Keys.Oem1:
                    button2.BackColor = Color.Aquamarine;
                    break;
                case Keys.P:
                case Keys.B:
                case Keys.Q:
                case Keys.R:
                    button3.BackColor = Color.Aquamarine;
                    break;
                case Keys.K:
                case Keys.V:
                case Keys.Y:
                case Keys.J:
                    button4.BackColor = Color.Aquamarine;
                    break;
                case Keys.G:
                case Keys.H:
                case Keys.C:
                case Keys.N:
                    button5.BackColor = Color.Aquamarine;
                    break;
                case Keys.E:
                case Keys.A:
                case Keys.OemOpenBrackets:
                case Keys.W:
                    button6.BackColor = Color.Aquamarine;
                    break;
                case Keys.X:
                case Keys.I:
                case Keys.O:
                case Keys.Oem6:
                    button7.BackColor = Color.Aquamarine;
                    break;
                case Keys.S:
                case Keys.M:
                case Keys.Oem7:
                case Keys.OemPeriod:
                    button8.BackColor = Color.Aquamarine;
                    break;
                case Keys.Z:
                    button9.BackColor = Color.Aquamarine;
                    break;
            }
        }
    }
}
