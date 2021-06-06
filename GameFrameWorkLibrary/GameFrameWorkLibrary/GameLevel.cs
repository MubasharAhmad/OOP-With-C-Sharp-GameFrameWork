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


        // method to add game objects 
        public void addGameObject(GameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }

        // method for collision detection
        public void DetectCollision(GameObject object1, GameObject object2)
        {

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
