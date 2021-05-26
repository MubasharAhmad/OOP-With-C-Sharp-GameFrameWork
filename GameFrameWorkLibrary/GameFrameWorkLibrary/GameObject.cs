using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    class GameObject
    {
        public PictureBox PictureBox;
        public int Speed;
        public IMovement ObjectMotion;
        public GameObjectType objectType;


        internal GameObject(PictureBox pictureBox, IMovement motion, int speed, GameObjectType gameObjectType)
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
