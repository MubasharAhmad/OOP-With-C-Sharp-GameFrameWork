using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Vector2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Vector2( int X, int Y )
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
