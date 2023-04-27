using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Controllers {
    public static class MainController {
        public static int map_size = 10, cell_size = 48;
        public static int[,] map = new int[map_size, map_size];
        public static bool IsFirstStep;
        private static int curPicture;

        public static Button[,] buttons = new Button[map_size, map_size];
        private static Image images;
        private static Point firstCord;

        public static AudioFileReader musicRead = new AudioFileReader("sounds/music.wav");
        public static AudioFileReader playRead = new AudioFileReader("sounds/start.wav");
        public static AudioFileReader btnClickRead = new AudioFileReader("sounds/click.wav");
        public static WaveOut music = new WaveOut();
        public static WaveOut play = new WaveOut();
        public static WaveOut btnClick = new WaveOut();
        public static void Init(Form current) {
            IsFirstStep = true;
            curPicture = 0;
            images = Image.FromFile("textures/button.png");
            ConfigMapSize(current);
            InitMap();
            InitButtons(current);
            InitAudio();
        }
        private static void InitAudio() {
            music.Init(musicRead);
            play.Init(playRead);
            btnClick.Init(btnClickRead);
        }
        private static void ConfigMapSize(Form current) {
            current.Width = (map_size * cell_size) + 50;
            current.Height = (map_size * cell_size) + 150;
        }
        private static void InitMap() {
            for (int i = 0; i < map_size; i++) {
                for (int j = 0; j < map_size; j++) map[i, j] = 0;
            }
        }
        private static void InitButtons(Form current) {
            for (int i = 0; i < map_size; i++) {
                for (int j = 0; j < map_size; j++) {
                    Button button = new Button();
                    button.Location = new Point((j * cell_size) + 18, (i * cell_size) + 70);
                    button.Size = new Size(cell_size, cell_size);
                    button.MouseUp += new MouseEventHandler(MouseButtonPressed);
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Image = Image.FromFile("textures/button.png");
                    current.Controls.Add(button);
                    buttons[i, j] = button;
                    buttons[i, j].Enabled = false;
                }
            }
        }
        private static void MouseButtonPressed(object sender, MouseEventArgs e) {
            Button pressButton = (Button)sender;
            switch (e.Button) {
                case MouseButtons.Right:
                    RightButtonPressed(pressButton);
                    break;
                case MouseButtons.Left:
                    LeftButtonPressed(pressButton);
                    break;
            }
        }
        private static void RightButtonPressed(Button presButt) {
            btnClick.Stop();
            btnClickRead = new AudioFileReader("sounds/flag.wav");
            btnClick.Init(btnClickRead);
            btnClick.Play();
            curPicture++;
            curPicture %= 3;
            switch(curPicture) {
                case 0:
                    presButt.Image = Image.FromFile("textures/button.png");
                    break;
                case 1:
                    presButt.Image = Image.FromFile("textures/flag.png");
                    break;
                case 2:
                    presButt.Image = Image.FromFile("textures/question.png");
                    break;
            }
        }
        private static void LeftButtonPressed(Button presButt) {
            btnClick.Stop();
            btnClickRead = new AudioFileReader("sounds/fieldclick.wav");
            btnClick.Init(btnClickRead);
            btnClick.Play();
            presButt.Enabled = false;
            presButt.Image = Image.FromFile("textures/empty.png");
            int xBut = presButt.Location.X / cell_size, yBut = presButt.Location.Y / cell_size;
            if (IsFirstStep) {
                firstCord = new Point(xBut, yBut);
                SeedMap();
                CountBombs();
                IsFirstStep = false;
            }
        }
        private static void SeedMap() {
            Random rand = new Random();
            int num = rand.Next(5, 10);
            for(int i = 0; i < num; i++) {
                int x = rand.Next(0, map_size - 1);
                int y = rand.Next(0, map_size - 1);
                while (map[x, y] == -1 || (Math.Abs(x-firstCord.Y) <= 1 && Math.Abs(y-firstCord.X) <= 1)) {
                    x = rand.Next(0, map_size - 1);
                    y = rand.Next(0, map_size - 1);
                }
                map[x, y] = -1;
            }
        }
        private static void CountBombs() {
            for(int i = 0; i < map_size; i++) {
                for(int j = 0; j < map_size; j++) {
                    if (map[i, j] == -1) {
                        for(int k = i - 1; k < i + 2; k++) {
                            for(int l = j - 1; l < j + 2; l++) {
                                if (!IsInBorder(k, l) || map[k, l] == -1) continue;
                                map[k, l] += 1;
                            }
                        }
                    }
                }
            }
        }
        private static bool IsInBorder(int x, int y) {
            if (x < 0 || y < 0 || y > map_size - 1 || x > map_size - 1) return false;
            return true;
        }
    }
}
