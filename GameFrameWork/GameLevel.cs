using System;
using System.Collections;
using System.Windows.Forms;

namespace GameFrameWork
{
    public class GameLevel
    {
        public int Gravity { get; private set; }
        public int Speed { get; private set; }

        private bool isOnPlatform;

        public ArrayList GameObjects = new ArrayList();


        // constructor
        public GameLevel(int gravity, int speed)
        {
            Gravity = gravity;
            Speed = speed;
        }


        // method to add game objects
        public void AddGameObject(PictureBox pictureBox)
        {
            GameObject gameObject = new GameObject(pictureBox);
            GameObjects.Add(gameObject);
        }


        // to run game
        public void Update()
        {

            // outer loop 
            foreach (GameObject gameObject in GameObjects)
            {
                PictureBox pictureBox = gameObject.PictureBox;

                if ((string)pictureBox.Tag == "player" || (string)pictureBox.Tag == "enemy")
                {
                    isOnPlatform = true;


                    // inner loop
                    foreach (GameObject gameObject1 in GameObjects)
                    {
                        PictureBox picBox = gameObject1.PictureBox;
                        if (pictureBox.Bounds.IntersectsWith(picBox.Bounds) && (string)picBox.Tag == "platform")
                        {
                            pictureBox.Left += Speed;
                            isOnPlatform = false;
                        }
                    }

                    if (isOnPlatform == true)
                        pictureBox.Top += Gravity;
                }
            }
        }

    }
}
