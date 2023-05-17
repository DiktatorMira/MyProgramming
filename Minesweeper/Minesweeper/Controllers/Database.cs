using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Controllers {
    public static class Database {
        public static string language, difficult, size, color, wallpaper;
        public static int games, games_victory, flags, fsec, fmin, fhour;
        public static AudioFileReader musicRead = new AudioFileReader("sounds/music.wav");
        public static AudioFileReader playRead = new AudioFileReader("sounds/start.wav");
        public static AudioFileReader btnClickRead = new AudioFileReader("sounds/click.wav");
        public static WaveOut music = new WaveOut();
        public static WaveOut play = new WaveOut();
        public static WaveOut btnClick = new WaveOut();
        public static void InitAudio() {
            music.Init(musicRead);
            play.Init(playRead);
            btnClick.Init(btnClickRead);
        }
        public static void ChangeSound(string path) {
            btnClick.Stop();
            btnClickRead = new AudioFileReader(path);
            btnClick.Init(btnClickRead);
            btnClick.Play();
        }
        public static string GetColorPath() {
            switch (color) {
                case "white":
                    return "textures/light/";
                case "black":
                    return "textures/dark/";
                case "mono":
                    return "textures/mono/";
                case "army":
                    return "textures/army/";
            }
            return null;
        }
        public static string GetWallpaperPath() {
            switch (color) {
                case "white":
                    return "classicwhite.png";
                case "black":
                    return "classicblack.png";
                case "mono":
                    return "classicmono.png";
                case "army":
                    return "classicarmy.png";
            }
            return null;
        }
        public static Tuple<Color, Color> GetColor() {
            switch(color) {
                case "white":
                    return Tuple.Create(Color.FromArgb(240, 240, 240), Color.Black);
                case "black":
                    return Tuple.Create(Color.FromArgb(40, 40, 40), Color.FromArgb(240, 240, 240));
                case "mono":
                    return Tuple.Create(Color.FromArgb(212, 211, 182), Color.FromArgb(64, 60, 36));
                case "army":
                    return Tuple.Create(Color.FromArgb(59, 84, 48), Color.FromArgb(218, 227, 193));
            }
            return Tuple.Create(Color.White, Color.White);
        }
        public static void ChangeField() {
            switch (size) {
                case "5x5":
                    MainController.height = 5;
                    MainController.width = 5;
                    break;
                case "10x5":
                    MainController.height = 5;
                    MainController.width = 10;
                    break;
                case "10x10":
                    MainController.height = 10;
                    MainController.width = 10;
                    break;
                case "14x10":
                    MainController.height = 10;
                    MainController.width = 14;
                    break;
                case "14x14":
                    MainController.height = 14;
                    MainController.width = 14;
                    break;
                case "30x14":
                    MainController.height = 14;
                    MainController.width = 30;
                    break;
            }
        }
        public async static void SaveToFiles(Minesweeper current) {
            await Task.Run(() => {
                using (StreamWriter file = new StreamWriter("textfiles/settings.txt", false)) {
                    file.WriteLine(language);
                    if (current.MusicCheck) file.WriteLine("music on");
                    else file.WriteLine("music off");
                    file.WriteLine(difficult);
                    file.WriteLine(size);
                    file.WriteLine(color);
                    file.WriteLine(wallpaper);
                }
                using (StreamWriter file = new StreamWriter("textfiles/statistics.txt", false)) {
                    file.WriteLine(games.ToString());
                    file.WriteLine(games_victory.ToString());
                    file.WriteLine(flags.ToString());
                    file.WriteLine(fsec.ToString());
                    file.WriteLine(fmin.ToString());
                    file.WriteLine(fhour.ToString());
                }
            });
        }
        public static void LoadFromFiles(Minesweeper current) {
            using (StreamReader file = new StreamReader("textfiles/settings.txt", Encoding.UTF8)) {
                language = file.ReadLine();
                if (file.ReadLine() == "music on") current.MusicCheck = true;
                difficult = file.ReadLine();
                size = file.ReadLine();
                color = file.ReadLine();
                wallpaper = file.ReadLine();
            }
            using (StreamReader file = new StreamReader("textfiles/statistics.txt", Encoding.UTF8)) {
                games = int.Parse(file.ReadLine());
                games_victory = int.Parse(file.ReadLine());
                flags = int.Parse(file.ReadLine());
                fsec = int.Parse(file.ReadLine());
                fmin = int.Parse(file.ReadLine());
                fhour = int.Parse(file.ReadLine());
            }
        }
    }
}
