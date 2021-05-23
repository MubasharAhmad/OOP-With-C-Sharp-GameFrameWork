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



        public void AddGameObject(PictureBox pictureBox, Movement motion, int speed)
        {
            CreateGameObject(pictureBox, motion, speed);
        }


        // default speed will be equal to the gravity
        public void AddGameObject(PictureBox pictureBox, Movement motion)
        {
            CreateGameObject(pictureBox, motion, Gravity);
        }
        

        // default motion will be left Movement
        public void AddGameObject(PictureBox pictureBox, int speed)
        {
            CreateGameObject(pictureBox, CreateMovement.MoveLeft(), speed);
        }


        private void CreateGameObject(PictureBox pictureBox, Movement motion, int speed)
        {
            GameObject gameObject = new GameObject(pictureBox, motion, speed);
        }


        // to run game
        public void Update()
        {
            foreach (GameObject gameObject in GameObjects)
            {
                gameObject.updatePosition();
            }
        }


    }
}
