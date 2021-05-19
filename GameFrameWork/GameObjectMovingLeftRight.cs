using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrameWork
{
    class GameObjectMovingLeftRight: GameObject
    {
        private GameObjectMotion currentMotion = GameObjectMotion.Left;
        public GameObjectMovingLeftRight(PictureBox pictureBox, int speed, GameObjectMotion objectMotion)
        {
            PictureBox = pictureBox;
            Speed = speed;
            ObjectMotion = objectMotion;
        }

        public override void updatePosition(int gravity)
        {
            if (GameLevel.IsBoumdsWithGround(PictureBox))
            {
                PictureBox ground = GameLevel.GetPictureBox(PictureBox);
                if (currentMotion == GameObjectMotion.Left)
                {
                    PictureBox.Left -= Speed;
                }
                if (currentMotion == GameObjectMotion.Right)
                {
                    PictureBox.Left += Speed;
                }
                if(PictureBox.Left == ground.Left)
                {
                    currentMotion = GameObjectMotion.Right;
                }
                if(PictureBox.Left + PictureBox.Width == ground.Left + ground.Width)
                {
                    currentMotion = GameObjectMotion.Left;
                }
            }
        }
    }
}
