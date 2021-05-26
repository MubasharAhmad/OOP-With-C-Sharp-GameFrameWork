using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    public class LeftMovement : IMovement
    {
        public void update(PictureBox pictureBox, int speed)
        {
            pictureBox.Left -= speed;
        }
    }
}
