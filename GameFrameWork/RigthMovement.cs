using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrameWork
{
    class RigthMovement : Movement
    {
        public void update(PictureBox pictureBox, int speed)
        {
            pictureBox.Left += speed;
        }
    }
}
