using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class DetectCollission
    {
        private List<PictureBox> FirstGameObjects = new List<PictureBox>();
        private List<PictureBox> SecondGameObjects = new List<PictureBox>();

        private static DetectCollission detectCollission = null;

        // to get instance of the class 
        public static DetectCollission GetInstance()
        {
            if (detectCollission == null)
                detectCollission = new DetectCollission();
            return detectCollission;
        }

        // method to add game objects for collision detection
        public void add(String object1, String object2)
        {
            foreach (Tile tile in WindowManager.Tiles)
            {
                if(tile.Name == object1)
                {
                    FirstGameObjects.Add(tile.TileImage);
                }
                if (tile.Name == object2)
                {
                    SecondGameObjects.Add(tile.TileImage);
                }
            }
            //FirstGameObjects.Add(object1);
            //SecondGameObjects.Add(object2);
        }

        public void CheckCollision()
        {
            for (int i = 0; i < FirstGameObjects.Count; i++)
            {
                PictureBox firstTile = FirstGameObjects[i];
                PictureBox secondTile = SecondGameObjects[i];
                if (firstTile.Left == secondTile.Left &&
                    firstTile.Top == secondTile.Top)
                {
                    secondTile.Visible = false;
                    secondTile.Dispose(); // dispose method will release all the resourses used
                    SecondGameObjects.RemoveAt(i);
                }
            }
        }
    }
}
