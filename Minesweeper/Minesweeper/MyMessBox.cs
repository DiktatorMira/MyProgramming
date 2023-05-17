using Minesweeper.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper {
    public partial class MyMessBox : Form {
        public int Value { get; set; }
        public Form MainForm { get; set; }
        public MyMessBox(string vtext, int value) {
            InitializeComponent();
            text.Text = vtext;
            Value = value;
            SetForm();
            ChangeLanguage();
            ChangeColor();
        }
        private void SetForm() {
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            text.Anchor = AnchorStyles.None;
            text.TextAlign = ContentAlignment.MiddleCenter;
            text.Parent = this;
            text.BackColor = Color.Transparent;
            no.FlatAppearance.BorderSize = 0;
            no.FlatStyle = FlatStyle.Flat;
            no.BackgroundImage = Image.FromFile(Database.GetColorPath() + "longbutton.png");
            yes.FlatAppearance.BorderSize = 0;
            yes.FlatStyle = FlatStyle.Flat;
            yes.BackgroundImage = Image.FromFile(Database.GetColorPath() + "longbutton.png");
            yes.Select();
            if(Value == 3) text.Location = new Point(text.Location.X + 33, text.Location.Y - 15);
            else if (Value == 2) text.Location = new Point(text.Location.X + 20, text.Location.Y);
        }
        private void ChangeLanguage() {
            switch(Database.language) {
                case "russian":
                    Text = "Сапёр";
                    no.Text = "Нет";
                    yes.Text = "Да";
                    break;
                case "ukrainian":
                    Text = "Cапер";
                    no.Text = "Ні";
                    yes.Text = "Так";
                    break;
                case "english":
                    Text = "Minesweeper";
                    no.Text = "No";
                    yes.Text = "Yes";
                    break;
            }
        }
        private void ChangeColor() {
            if (Database.wallpaper == "yes") BackgroundImage = Image.FromFile("textures/themes/" + Database.GetWallpaperPath());
            BackColor = Database.GetColor().Item1;
            ForeColor = Database.GetColor().Item2;
        }
        private void no_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            if (Value == 3 || Value == 4) Application.Exit();
            Close();
        }
        private void yes_Click(object sender, EventArgs e) {
            Database.ChangeSound("sounds/click.wav");
            switch (Value) {
                case 1:
                case 3:
                case 4:
                    Application.Restart();
                    break;
                case 2:
                    Application.Exit();
                    break;
            }
            Close();
        }
    }
}
