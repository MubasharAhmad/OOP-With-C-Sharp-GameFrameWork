using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    public class FallingMovement : IMovement
    {
        public void update(PictureBox pictureBox, int gravity)
        {
            pictureBox.Top += gravity;
        }
    }
}
