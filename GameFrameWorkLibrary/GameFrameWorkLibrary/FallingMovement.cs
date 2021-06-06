using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GameFrameWorkLibrary
{
    public class FallingMovement : IMovement
    {
        public Type GetMovementType()
        {
            return this.GetType();
        }

        public void update(PictureBox pictureBox, int gravity)
        {
            pictureBox.Top += gravity;
        }
    }
}
