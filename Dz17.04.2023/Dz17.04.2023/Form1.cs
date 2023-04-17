using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz17._04._2023 {
    public partial class Form1 : Form {
        ImageList small_icon = new ImageList();
        ImageList big_icon = new ImageList();
        ImageList imageList;
        string path = "C:\\Windows";
        public Form1() {
            InitializeComponent();
            small_icon.ColorDepth = ColorDepth.Depth32Bit;
            small_icon.ImageSize = new Size(16, 16);
            fileList.SmallImageList = small_icon;
            big_icon.ColorDepth = ColorDepth.Depth32Bit;
            big_icon.ImageSize = new Size(32, 32);
            fileList.LargeImageList = big_icon;
            string[] files = Directory.GetFiles(path);
            Icon icon = new Icon("folder.ico");
            small_icon.Images.Add(icon);
            big_icon.Images.Add(icon);
            tree1.Nodes.Add("C:/");
            tree1.ImageList = small_icon;
            foreach (string file in files)  {
                icon = Icon.ExtractAssociatedIcon(file);
                small_icon.Images.Add(icon);
                big_icon.Images.Add(icon);
                tree1.Nodes[0].Nodes.Add(file);
            }
        }
        private void tree1_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode node = tree1.SelectedNode;
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            Icon icon = new Icon("folder.ico");
            foreach (string dir in directories) fileList.Items.Add(dir, 0);
            int index = 1;
            foreach (string file in files) {
                icon = Icon.ExtractAssociatedIcon(file);
                small_icon.Images.Add(icon);
                big_icon.Images.Add(icon);
                fileList.Items.Add(file, index++);
            }
        }
        private void tree1_AfterExpand(object sender, TreeViewEventArgs e) {
            //fileList.Items.Clear();
        }
        private void menuDown1_Click(object sender, EventArgs e) => fileList.View = View.List;
        private void menuDown2_Click(object sender, EventArgs e) => fileList.View = View.Tile;
        private void menuDown3_Click(object sender, EventArgs e) => fileList.View = View.SmallIcon;
        private void menuDown4_Click(object sender, EventArgs e) => fileList.View = View.LargeIcon;
    }
}
