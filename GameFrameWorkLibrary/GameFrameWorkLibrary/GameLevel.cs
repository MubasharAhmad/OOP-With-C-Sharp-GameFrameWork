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



        public void AddGameObject(PictureBox pictureBox, IMovement motion, int speed, GameObjectType gameObjectType)
        {
            CreateGameObject(pictureBox, motion, speed, gameObjectType);
        }


        // default speed will be equal to the gravity
        public void AddGameObject(PictureBox pictureBox, IMovement motion, GameObjectType gameObjectType)
        {
            CreateGameObject(pictureBox, motion, Gravity, gameObjectType);
        }


        // default motion will be left Movement
        public void AddGameObject(PictureBox pictureBox, int speed, GameObjectType gameObjectType)
        {
            CreateGameObject(pictureBox, new LeftMovement(), speed, gameObjectType);
        }


        // method to create game object from CreateGameObject class
        private void CreateGameObject(PictureBox pictureBox, IMovement motion, int speed, GameObjectType gameObjectType)
        {
            GameObjectFactory GetGameObj = GameObjectFactory.GetInstance();
            GameObject gameObject = GetGameObj.GetGameObject(pictureBox, motion, speed, gameObjectType);
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
