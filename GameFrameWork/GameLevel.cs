using System;
using System.Collections;
using System.Windows.Forms;

namespace GameFrameWork
{
    class GameLevel
    {
        public int Gravity { get; private set; }

        public static ArrayList GameObjects = new ArrayList();

        private static GameLevel gameLevel = null;


        // constructor
        public GameLevel(int gravity)
        {
            Gravity = gravity;
            GameObjects = null;
        }


        // method to get instanse
        public static GameLevel getGameLevelInstance(int gravity)
        {
            if (gameLevel == null)
            {
                gameLevel = new GameLevel(gravity);
            }
            return gameLevel;
        }


        // method to add game objects
        public void AddGameObject(PictureBox pictureBox, int speed, GameObjectMotion motion)
        {
            switch (motion)
            {
                case GameObjectMotion.LeftRight:
                    GameObject gameObjectMovingLeftRight = new GameObjectMovingLeftRight(pictureBox, speed, motion);
                    GameObjects.Add(gameObjectMovingLeftRight);
                    break;
                case GameObjectMotion.Left:
                    GameObject gameObjectMovingLeftOnly = new GameObjectMovingLeftOnly(pictureBox, speed, motion);
                    GameObjects.Add(gameObjectMovingLeftOnly);
                    break;
                case GameObjectMotion.Right:
                    GameObject gameObjectMovingRightOnly = new GameObjectMovingRightOnly(pictureBox, speed, motion);
                    GameObjects.Add(gameObjectMovingRightOnly);
                    break;
                default:
                    break;
            }
        }

        // method to add motionless objects
        public void AddGameObject(PictureBox pictureBox)
        {
            GameObject gameObject = new GameObject();
            gameObject.PictureBox = pictureBox;
            GameObjects.Add(gameObject);
        }


        // to run game
        public void Update()
        {
            foreach (GameObject gameObject in GameObjects)
            {
                gameObject.updatePosition(Gravity);
            }
        }


        // method to check if enemy bounds with ground
        public static bool IsBoumdsWithGround(PictureBox pictureBox)
        {
            foreach (GameObject gameObject in GameObjects)
            {
                if(pictureBox.Bounds.IntersectsWith(gameObject.PictureBox.Bounds) && (string)gameObject.PictureBox.Tag == GameObjectTag.Platform)
                {
                    return true;
                }
            }
            return false;
        }


        // method to get picture box which with enemy / player bounds
        public static PictureBox GetPictureBox(PictureBox pictureBox)
        {
            PictureBox pictureBox1 = null;
            foreach (GameObject gameObject in GameObjects)
            {
                if(pictureBox.Bounds.IntersectsWith(gameObject.PictureBox.Bounds) && (string)gameObject.PictureBox.Tag == GameObjectTag.Platform)
                {
                    pictureBox1 = gameObject.PictureBox;
                }
            }
            return pictureBox1;
        }

    }
}
