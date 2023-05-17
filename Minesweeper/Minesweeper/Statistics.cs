using Minesweeper.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper {
    public partial class Statistics : Form {
        public Form MainForm { get; set; }
        public Statistics() {
            InitializeComponent();
            statBox.BorderStyle = BorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ChangeColor();
            ChangeLanguage();
        }
        private void ChangeColor() {
            if (Database.wallpaper == "yes") BackgroundImage = Image.FromFile("textures/themes/" + Database.GetWallpaperPath());
            BackColor = Database.GetColor().Item1;
            ForeColor = Database.GetColor().Item2;
            statBox.BackColor = Database.GetColor().Item1;
            statBox.ForeColor = Database.GetColor().Item2;
        }
        private void ChangeLanguage() {
            switch(Database.language) {
                case "russian":
                    Text = "Статистика";
                    statBox.Text += $"Игр сыграно: {Database.games}\n";
                    statBox.Text += $"Игр выиграно: {Database.games_victory}\n";
                    statBox.Text += $"Поставлено флажков на клетку с бомбой: {Database.flags}\n";
                    statBox.Text += string.Format("Общее время игры: {0:D2}:{1:D2}:{2:D2}", Database.fhour, Database.fmin, Database.fsec);
                    break;
                case "ukrainian":
                    Text = "Статистика";
                    statBox.Text += $"Ігор зіграно: {Database.games}\n";
                    statBox.Text += $"Ігор виграно: {Database.games_victory}\n";
                    statBox.Text += $"Поставлено прапорців на клітку із бомбою: {Database.flags}\n";
                    statBox.Text += string.Format("Загальний час гри: {0:D2}:{1:D2}:{2:D2}", Database.fhour, Database.fmin, Database.fsec);
                    break;
                case "english":
                    Text = "Statistics";
                    statBox.Text += $"Games played: {Database.games}\n";
                    statBox.Text += $"Games won: {Database.games_victory}\n";
                    statBox.Text += $"Flags placed on the cell with a bomb: {Database.flags}\n";
                    statBox.Text += string.Format("Total game time: {0:D2}:{1:D2}:{2:D2}", Database.fhour, Database.fmin, Database.fsec);
                    break;
            }
        }
    }
}
