using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class FallingMovement : IMovement
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
