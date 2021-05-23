using System;
using System.Windows.Forms;

namespace GameFrameWork
{
    class GameObject
    {
        public PictureBox PictureBox;
        public int Speed;
        public Movement ObjectMotion;


        public GameObject(PictureBox pictureBox, Movement motion, int speed)
        {
            PictureBox = pictureBox;
            ObjectMotion = motion;
            Speed = speed;
        }

        public virtual void updatePosition()
        {
            ObjectMotion.update(PictureBox, Speed);
        }
    }
}
