using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GameLevel level1 = new GameLevel(5);

        private void Form1_Load(object sender, EventArgs e)
        {
            level1.AddGameObject(pictureBox10, 5, CreateMovement.MoveLeft());
            level1.AddGameObject(pictureBox12, 6, CreateMovement.MoveRight());
            level1.AddGameObject(pictureBox13, 4, CreateMovement.MoveDown());
        }

        private void GameMainTimer_Tick(object sender, EventArgs e)
        {
            level1.Update();
        }


        // method to avoid blinking elements in form
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COPMPOSITED
                return cp;
            }
        }

    }
}
