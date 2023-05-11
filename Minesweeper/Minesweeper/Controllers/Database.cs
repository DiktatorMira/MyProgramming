using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Controllers {
    public static class Database {
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
        public async static void SaveToFile(Minesweeper current) {
            await Task.Run(() => {
                using (StreamWriter file = new StreamWriter("info_settings.txt", false)) {
                    file.WriteLine(current.language);
                    if (current.MusicCheck) file.WriteLine("music on");
                    else file.WriteLine("music off");
                    file.WriteLine(current.difficult);
                    file.WriteLine(current.size);
                    file.WriteLine(current.color);
                    file.WriteLine(current.wallpaper);
                }
            });
        }
        public async static void LoadFromFile(Minesweeper current) {
            await Task.Run(() => {
                using (StreamReader file = new StreamReader("info_settings.txt", Encoding.UTF8)) {
                    current.language = file.ReadLine();
                    if (file.ReadLine() == "music on") current.MusicCheck = true;
                    current.difficult = file.ReadLine();
                    current.size = file.ReadLine();
                    current.color = file.ReadLine();
                    current.wallpaper = file.ReadLine();
                }
            });
        }
    }
}
