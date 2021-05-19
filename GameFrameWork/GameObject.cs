using System;
using System.Windows.Forms;

namespace GameFrameWork
{
    class GameObject
    {
        public PictureBox PictureBox;
        public int Speed;
        public GameObjectMotion ObjectMotion = GameObjectMotion.Static;


        public virtual void updatePosition(int gravity)
        {

        }
    }
}
