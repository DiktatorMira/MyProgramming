using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Controllers {
    public class MyButton : Button {
        public bool IsBomb { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsFlagCheck { get; set; } = false;
        public bool IsOpened { get; set; } = false;
        public bool IsEmpty { get; set; } = false;
        public int CurrentPircture { get; set; } = 0;
        public int X { get; set; }
        public int Y { get; set; }
    }
    public static class MainController {
        public static int height, width, cell_size = 48, bombs_count = 0, flag_bombs = 0;
        public static double bomb_persent;
        public static bool IsFirstStep = true;
        public static MyButton[,] buttons;
        public static Form form;
        public static Minesweeper form1;
        public static void Init(Form current) {
            form = current;
            form1 = (Minesweeper)current;
            ChangeField();
            buttons = new MyButton[height, width];
            InitMap(current);
            InitButtons(current);
        }
        private static void ChangeField() {
            switch (form1.size) {
                case "5x5":
                    height = 5;
                    width = 5;
                    break;
                case "10x5":
                    height = 5;
                    width = 10;
                    break;
                case "10x10":
                    height = 10;
                    width = 10;
                    break;
                case "14x10":
                    height = 10;
                    width = 14;
                    break;
                case "14x14":
                    height = 14;
                    width = 14;
                    break;
                case "30x14":
                    height = 14;
                    width = 30;
                    break;
            }
        }
        private static void InitMap(Form current) {
            current.Width = (width * cell_size) + 50;
            current.Height = (height * cell_size) + 150;
        }
        private static void InitButtons(Form current) {
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    MyButton button = new MyButton();
                    button.Location = new Point((j * cell_size) + 18, (i * cell_size) + 90);
                    button.Size = new Size(cell_size, cell_size);
                    button.MouseUp += new MouseEventHandler(MouseButtonPressed);
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackgroundImage = Image.FromFile("textures/light/button.png");
                    current.Controls.Add(button);
                    button.Y = i;
                    button.X = j;
                    buttons[i, j] = button;
                }
            }
        }
        private static void MouseButtonPressed(object sender, MouseEventArgs e) {
            MyButton button = (MyButton)sender;
            switch (e.Button) {
                case MouseButtons.Right:
                    RightButtonPressed(button);
                    break;
                case MouseButtons.Left:
                    LeftButtonPressed(button);
                    break;
            }
        }
        private static void RightButtonPressed(MyButton button) {
            if (button.IsActive && !IsFirstStep) {
                Database.ChangeSound("sounds/flag.wav");
                switch (button.CurrentPircture) {
                    case 0:
                        button.BackgroundImage = Image.FromFile("textures/light/flag.png");
                        button.CurrentPircture++;
                        button.IsFlagCheck = true;
                        if(button.IsBomb) flag_bombs++;
                        break;
                    case 1:
                        button.BackgroundImage = Image.FromFile("textures/light/question.png");
                        button.CurrentPircture++;
                        if (button.IsBomb) flag_bombs--;
                        break;
                    case 2:
                        button.BackgroundImage = Image.FromFile("textures/light/button.png");
                        button.CurrentPircture = 0;
                        button.IsFlagCheck = false;
                        break;
                }
                if (flag_bombs == bombs_count) Victory();
            }
        }
        private static void LeftButtonPressed(MyButton button) {
            if (button.IsActive && !button.IsFlagCheck) {
                Database.ChangeSound("sounds/fieldclick.wav");
                if (IsFirstStep) {
                    IsFirstStep = false;
                    GenerateField(button);
                }
                button.IsActive = false;
                if (button.IsBomb) Explosion(button);
                else OpenRegion(button);
            }
        }
        private static void GenerateField(MyButton button) {
            Random rand = new Random();
            bombs_count = (int)Math.Round(height * width * bomb_persent * 0.01);
            button.IsEmpty = true;
            for (int x = button.Y - 1; x <= button.Y + 1; x++) {
                for (int y = button.X - 1; y <= button.X + 1; y++) {
                    if (x >= 0 && x < height && y >= 0 && y < width) buttons[x,y].IsEmpty = true;
                }
            }
            int quan = 0, i, j;
            while (quan != bombs_count) {
                i = rand.Next(0, height);
                j = rand.Next(0, width);
                if (!buttons[i, j].IsBomb && !buttons[i, j].IsEmpty) {
                    buttons[i,j].IsBomb = true;
                    quan++;
                }
            }
        }
        private static void Explosion(MyButton button) {
            Database.music.Stop();
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    if (buttons[i, j].IsBomb) {
                        if (buttons[i, j].IsFlagCheck) buttons[i, j].Image = Image.FromFile("textures/light/flag.png");
                        else buttons[i, j].Image = Image.FromFile("textures/light/bomb.png");
                        buttons[i, j].IsActive = false;
                    }
                    else if (!buttons[i, j].IsBomb && buttons[i, j].IsFlagCheck) buttons[i, j].Image = Image.FromFile("textures/light/incflag.png");
                }
            }
            button.Image = Image.FromFile("textures/light/clickbomb.png");
            form1.SetSmile(Image.FromFile("textures/light/smile1.png"));
            form1.StopTimer();
            Database.ChangeSound("sounds/bomb.wav");
            if(form1.language == "russian") {
                DialogResult res = MessageBox.Show("Вы проиграли! Хотите начать заново?",
                "Смэрть", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
                else form1.Close();
            }
            else if(form1.language == "ukrainian") {
                DialogResult res = MessageBox.Show("Ви програли! Бажаєте почати заново?",
               "Помер", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
                else form1.Close();
            }
            else if(form1.language == "english") {
                DialogResult res = MessageBox.Show("You lose! Wanna start over?",
               "Eh...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
                else form1.Close();
            }
        }
        private static void Victory() {
            Database.ChangeSound("sounds/victory.wav");
            form1.StopTimer();
            form1.SetSmile(Image.FromFile("textures/light/smile2.png"));
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    MakeImage(buttons[i, j], CountBombs(i, j));
                    if (buttons[i, j].IsBomb) buttons[i, j].Image = Image.FromFile("textures/light/flag.png");
                    buttons[i, j].IsActive = false;
                }
            }
            if (form1.language == "russian") {
                DialogResult res = MessageBox.Show($"Вы выиграли! Ваше время: {form1.GetTime()}. Хотите начать заново?",
                "Поздравляем!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
                else form1.Close();
            }
            else if(form1.language == "ukrainian") {
                DialogResult res = MessageBox.Show($"Ви виграли! Ваш час: {form1.GetTime()}. Бажаєте почати заново?",
                "Вітаємо!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
                else form1.Close();
            }
            else if (form1.language == "english") {
                DialogResult res = MessageBox.Show($"You have won! Your time: {form1.GetTime()}. Wanna start over?",
                "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Database.ChangeSound("sounds/click.wav");
                if (res == DialogResult.Yes) Application.Restart();
                else form1.Close();
            }
        }
        private static void OpenRegion(MyButton button) {
            Queue<MyButton> queue = new Queue<MyButton>();
            queue.Enqueue(button);
            while(queue.Count > 0) {
                MyButton curBut = queue.Dequeue();
                if (!curBut.IsFlagCheck) {
                    MakeImage(curBut, CountBombs(curBut.Y, curBut.X));
                    button.IsActive = false;
                }
                if (CountBombs(curBut.Y, curBut.X) == 0) {
                    for (int y = curBut.X - 1; y <= curBut.X + 1; y++) {
                        for (int x = curBut.Y - 1; x <= curBut.Y + 1; x++) {
                            if (x >= 0 && y >= 0 && x < height && y < width) {
                                if (!buttons[x, y].IsOpened) {
                                    queue.Enqueue(buttons[x, y]);
                                    buttons[x, y].IsOpened = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        private static int CountBombs(int xBut, int yBut) {
            int count_bombs = 0;
            for (int x = xBut - 1; x <= xBut + 1; x++) {
                for (int y = yBut - 1; y <= yBut + 1; y++) {
                    if (x >= 0 && x < height && y >= 0 && y < width) if (buttons[x, y].IsBomb) count_bombs++;
                }
            }
            return count_bombs;
        }
        private static void MakeImage(MyButton button, int value) {
            switch (value) {
                case 0:
                    button.Image = Image.FromFile("textures/light/empty.png");
                    break;
                case 1:
                    button.Image = Image.FromFile("textures/light/one.png");
                    break;
                case 2:
                    button.Image = Image.FromFile("textures/light/two.png");
                    break;
                case 3:
                    button.Image = Image.FromFile("textures/light/three.png");
                    break;
                case 4:
                    button.Image = Image.FromFile("textures/light/four.png");
                    break;
                case 5:
                    button.Image = Image.FromFile("textures/light/five.png");
                    break;
                case 6:
                    button.Image = Image.FromFile("textures/light/six.png");
                    break;
                case 7:
                    button.Image = Image.FromFile("textures/light/seven.png");
                    break;
                case 8:
                    button.Image = Image.FromFile("textures/light/eight.png");
                    break;
            }
        }
    }
}
