using System;
using System.Windows.Forms;

namespace GameFrameWork
{
    class GameObject
    {
        public PictureBox PictureBox;
        public int Speed;
        public Movement ObjectMotion;
        public GameObjectType objectType;


        public GameObject(PictureBox pictureBox, Movement motion, int speed, GameObjectType gameObjectType)
        {
            PictureBox = pictureBox;
            ObjectMotion = motion;
            Speed = speed;
            objectType = gameObjectType;
        }

        public virtual void updatePosition()
        {
            ObjectMotion.update(PictureBox, Speed);
        }
    }
}
