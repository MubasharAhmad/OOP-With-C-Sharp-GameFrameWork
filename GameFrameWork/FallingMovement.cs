using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrameWork
{
    class FallingMovement : Movement
    {
        public void update(PictureBox pictureBox, int gravity)
        {
            pictureBox.Top += gravity;
        }
    }
}
