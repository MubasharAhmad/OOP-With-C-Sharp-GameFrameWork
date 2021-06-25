using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class KeyboardInputMovement : IMovement
    {
        public Type GetMovementType()
        {
            return this.GetType();
        }

        private PictureBox pictureBox;
        private int speed;
        private GameObjectMotionType CurrentMotion;

        public void update(PictureBox pictureBox, int speed)
        {
            this.pictureBox = pictureBox;
            this.speed = speed;
            WindowManager windowManager = WindowManager.GetInstance();
            Form gameWindow = windowManager.GameWindow;
            gameWindow.KeyUp += new KeyEventHandler(GameWindow_Key);
            
        }

        private void GameWindow_Key(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
                pictureBox.Left -= speed;

            if (e.KeyCode == Keys.Right)
                pictureBox.Left += speed;

            if (e.KeyCode == Keys.Up)
                pictureBox.Top -= speed;

            if (e.KeyCode == Keys.Down)
                pictureBox.Top += speed;
        }
    }
}
