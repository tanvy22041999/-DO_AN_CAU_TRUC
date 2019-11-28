using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    class King : GeneralMethods
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            for (int i = 1; i >= -1; i--)
            {
                for (int j = 1; j >= -1; j--)
                {
                    if (point.X + i <= 7 && point.Y + j <= 7 && point.X + i >= 0 && point.Y + j >= 0)
                    {
                        if (Matrix[point.X + i][point.Y + j].Name == "NULL")
                        {
                            Matrix[point.X + i][point.Y + j].BackColor = Color.LightBlue;
                            Matrix[point.X + i][point.Y + j].Name = "A";
                        }
                    }

                }
            }

        }
    }
}