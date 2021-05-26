using GameFrameWorkLibrary;
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
        GameLevel level1 = new GameLevel(5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            level1.AddGameObject(pictureBox1, new LeftMovement(), 3, GameObjectType.ENEMY);
            level1.AddGameObject(pictureBox2, new FallingMovement(), 2, GameObjectType.ENEMY);
            level1.AddGameObject(pictureBox3, new RightMovement(), 5, GameObjectType.ENEMY);
            level1.AddGameObject(pictureBox4, new KeyboardInputMovement(), 6, GameObjectType.PLAYER);
        }

        private void GameMainTimer_Tick(object sender, EventArgs e)
        {
            level1.Update();
        }
    }
}
