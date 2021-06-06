using System;
using System.Collections;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    public class GameLevel
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



        public void AddGameObject(PictureBox pictureBox, int speed, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            CreateGameObject(pictureBox, speed, gameObjectType, motion);
        }


        // default speed will be equal to the gravity
        public void AddGameObject(PictureBox pictureBox, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            CreateGameObject(pictureBox, Gravity, gameObjectType, motion);
        }


        // default motion will be left Movement
        public void AddGameObject(PictureBox pictureBox, int speed, GameObjectType gameObjectType)
        {
            CreateGameObject(pictureBox, speed, gameObjectType, GameObjectMotionType.LEFT);
        }


        // method to create game object from CreateGameObject class
        private void CreateGameObject(PictureBox pictureBox, int speed, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            GameObjectFactory GetGameObj = GameObjectFactory.GetInstance();
            GameObject gameObject = GetGameObj.GetGameObject(pictureBox, speed, gameObjectType, motion);
            GameObjects.Add(gameObject);
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
