using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
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
        }


        // method to get instanse
        public static GameLevel GetInstance(int gravity)
        {
            if (gameLevel == null)
            {
                gameLevel = new GameLevel(gravity);
            }
            return gameLevel;
        }


        // method to add game objects 
        public void addGameObject(String Name, int speed, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            GameObjectFactory gameObjectFactory = GameObjectFactory.GetInstance();
            List<GameObject> gameObjects = gameObjectFactory.GetGameObject(Name, speed, gameObjectType, motion);

            foreach (GameObject gameObject in gameObjects)
            {
                GameObjects.Add(gameObject);
            }
        }

        // to run game
        public void Update()
        {
            foreach (GameObject gameObject in GameObjects)
            {
                gameObject.updatePosition();
            }
            DetectCollission detectCollission = DetectCollission.GetInstance();
            detectCollission.CheckCollision();
        }
    }
}
