using System;
using System.Windows.Forms;

namespace GameFrameWork
{
    public class GameObject
    {
        public PictureBox PictureBox { get; private set; }

        // constructor
        public GameObject(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }
    }
}
