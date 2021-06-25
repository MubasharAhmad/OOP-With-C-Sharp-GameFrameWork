using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Tile
    {
        public PictureBox TileImage { get; set; }
        public String Name { get; set; }
        
        public Tile(PictureBox TileImage, String Name)
        {
            this.TileImage = TileImage;
            this.Name = Name;
        }
    }
}
