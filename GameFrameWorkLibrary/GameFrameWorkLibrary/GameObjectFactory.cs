using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    internal class GameObjectFactory
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

        // method to create an object
        public GameObject GetGameObject(PictureBox pictureBox, IMovement motion, int speed, GameObjectType gameObjectType)
        {
            array[(int)gameObjectType] += 1;
            GameObject gameObject = new GameObject(pictureBox, motion, speed, gameObjectType);
            return gameObject;
        }

    }
}
