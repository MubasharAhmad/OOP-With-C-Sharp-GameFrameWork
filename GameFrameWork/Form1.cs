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

        GameLevel level1 = new GameLevel(5, 5);

        private void Form1_Load(object sender, EventArgs e)
        {
            level1.AddGameObject(player);
            level1.AddGameObject(pictureBox1);
            level1.AddGameObject(pictureBox2);
            level1.AddGameObject(pictureBox3);
            level1.AddGameObject(pictureBox4);
            level1.AddGameObject(pictureBox5);
            level1.AddGameObject(pictureBox6);
            level1.AddGameObject(pictureBox7);
            level1.AddGameObject(pictureBox8);
            level1.AddGameObject(pictureBox9);
            level1.AddGameObject(pictureBox10);
            level1.AddGameObject(pictureBox11);
            level1.AddGameObject(pictureBox12);
            level1.AddGameObject(pictureBox13);
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
