using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrameWork
{
    class CreateGameObj
    {
        const int length = 20;
        // array to keep how much objects have been created of different types
        int[] array = new int[length];

        private static CreateGameObj createGameObject = null;

        // method to get instance of this class
        public static CreateGameObj GetInstance()
        {
            if(createGameObject == null)
            {
                createGameObject = new CreateGameObj();
            }
            return createGameObject;
        }

        // method to create an object
        public GameObject GetGameObject(PictureBox pictureBox, Movement motion, int speed, GameObjectType gameObjectType)
        {
            array[(int)gameObjectType] += 1;
            GameObject gameObject = new GameObject(pictureBox, motion, speed, gameObjectType);
            return gameObject;
        }

    }
}
