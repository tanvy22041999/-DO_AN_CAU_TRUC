using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    public class InfoStack
    {
        private Color color;
        private string name;
        private int x;
        private int y;

        public InfoStack(Color ColorButton, string NameButton, int Location_X, int Location_Y)
        {
            Color = ColorButton;
            Name = NameButton;
            X = Location_X;
            Y = Location_Y;
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
