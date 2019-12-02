using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVuaGame
{
    public class InfoUndo
    {
        private Image image;
        private string name;
        private int x;
        private int y;

        public InfoUndo(Image ImageButton, string NameButton, int Location_X, int Location_Y)
        {
            this.Image = ImageButton;
            Name = NameButton;
            X = Location_X;
            Y = Location_Y;
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
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
