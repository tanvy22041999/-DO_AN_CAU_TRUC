
 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                                //  
                                                          //      
namespace CoVuaGame
    {
        class Knight
        {
            public void CanMove(List<List<Button>> Matrix, Point point)
            {
                int[] A = { 2, 2, 1, 1, -1, -1, -2, -2 };
                int[] B = { -1, 1, -2, 2, -2, 2, -1, 1 };
                for (int i = 0; i < 8; i++)
                {
                    if (point.X + A[i] >= 0 && point.X + A[i] <= 7 && point.Y + B[i] >= 0 && point.Y + B[i] <= 7)
                    {
                        if (Matrix[point.X + A[i]][point.Y + B[i]].Name == "NULL")
                        {
                            Matrix[point.X + A[i]][point.Y + B[i]].BackColor = Color.LightBlue;
                            Matrix[point.X + A[i]][point.Y + B[i]].Name = "A";
                        }
                    }
                }
            }
        }
    }

