using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    interface IMovement
    {
        void update(PictureBox pictureBox, int speed);
        Type GetMovementType();
    }
}
