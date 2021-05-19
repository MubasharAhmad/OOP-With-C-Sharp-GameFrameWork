using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrameWork
{
    class GameObjectMovingLeftOnly: GameObject
    {
        public GameObjectMovingLeftOnly(PictureBox pictureBox, int speed, GameObjectMotion objectMotion)
        {
            PictureBox = pictureBox;
            Speed = speed;
            ObjectMotion = objectMotion;
        }

        // method to update position of picture box
        public override void updatePosition(int gravity)
        {
            if (GameLevel.IsBoumdsWithGround(PictureBox))
            {
                PictureBox.Left -= Speed;
            }
            else
            {
                PictureBox.Top += gravity;
            }
        }
    }
}
