using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class GameObjectFactory
    {
        const int length = 20;
        // array to keep how much objects have been created of different types
        int[] array = new int[length];

        private static GameObjectFactory createGameObject = null;

        // method to get instance of this class
        public static GameObjectFactory GetInstance()
        {
            if (createGameObject == null)
            {
                createGameObject = new GameObjectFactory();
            }
            return createGameObject;
        }

        // method to create an GameObject
        public List<GameObject> GetGameObject(String Name, int speed, GameObjectType gameObjectType, GameObjectMotionType motion)
        {
            array[(int)gameObjectType] += 1;

            List<GameObject> GameObjects = new List<GameObject>();   

            foreach (Tile tile in WindowManager.Tiles)
            {
                if(tile.Name == Name)
                {
                    GameObject gameObject = new GameObject(tile, speed, gameObjectType, motion);
                    GameObjects.Add(gameObject);
                }
            }

            return GameObjects;
        }
    }
}
