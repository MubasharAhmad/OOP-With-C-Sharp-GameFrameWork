using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class WindowManager
    {
        public Form GameWindow { get; set; }
        private Vector2 ScreenSize;
        private String WindowTitle;

        public string PicsFolderPath { get; set; }
        public List<List<string>> gameObjects = new List<List<string>>();
        static public List<Tile> Tiles = new List<Tile>();

        static private WindowManager windowManager = null;

        // method to get instance of the class
        static public WindowManager GetInstance()
        {
            if(windowManager == null)
            {
                windowManager = new WindowManager();
            }
            return windowManager;
        }

        // private constructor so that no instance of thr class could be created outside the class
        private WindowManager() { }

        // method to add Game Window
        public void AddGameWindow(Form GameWindow, Vector2 ScreenSize, String WindowTitle, String MapPath, String PicturesPath)
        {
            this.GameWindow = GameWindow;
            this.ScreenSize = ScreenSize;
            this.WindowTitle = WindowTitle;
            InitializeWindow();
            AddGameMap(MapPath);
            AddPictures(PicturesPath);
            Load();
        }

        // method to initialize GameWindow
        private void InitializeWindow()
        {
            GameWindow.StartPosition = FormStartPosition.CenterScreen;
            GameWindow.Size = new Size(ScreenSize.X, ScreenSize.Y);
            GameWindow.Text = WindowTitle;
            GameWindow.BackColor = Color.LightBlue;
        }

        // method to add game map
        private void AddGameMap(String MapPath)
        {
            string[] lines = File.ReadAllLines(MapPath);
            foreach (string line in lines)
            {
                List<string> Line = new List<string>();
                foreach (char letter in line)
                {
                    Line.Add(letter.ToString());
                }
                gameObjects.Add(Line);
            }
        }

        // method to add pictures path
        private void AddPictures(String PicturesPath)
        {
            PicsFolderPath = PicturesPath;
        }

        // method to load pictures on form
        private void Load()
        { 
            int rows = gameObjects.Count;
            int i = 0;
            foreach (List<string> line in gameObjects)
            {
                int idx = 0;
                int columns = line.Count;
                foreach (string letter in line)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(ScreenSize.X / columns, ScreenSize.Y / rows);
                    pictureBox.Location = new Point(idx * (ScreenSize.X / columns), i * (ScreenSize.Y / rows));
                    try
                    {
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = Image.FromFile($"{PicsFolderPath}{letter}.png");
                        GameWindow.Controls.Add(pictureBox);

                        Tile tile = new Tile(pictureBox, letter);
                        Tiles.Add(tile);
                    }
                    catch
                    {
                        pictureBox.BackColor = Color.LightBlue;
                        GameWindow.Controls.Add(pictureBox);
                        //pictureBox.Dispose();
                    }
                    idx++;
                }
                i++;
            }
        }
    }
}