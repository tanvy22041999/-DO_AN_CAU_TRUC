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
    class Knight:GeneralMethods
    {
        public new void CanMove(List<List<Button>> Matrix, Point point)
        {
            int[] A = { 2, 2, 1, 1, -1, -1, -2, -2 };
            int[] B = { -1, 1, -2, 2, -2, 2, - 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (point.X + A[i] >= 0 && point.X + A[i] <= 7 && point.Y +B[i] >= 0 && point.Y + B[i] <= 7)
                {
                    if (Matrix[point.X + A[i]][point.Y + B[i]].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X + A[i]][point.Y + B[i]].BackColor,
                             Matrix[point.X + A[i]][point.Y + B[i]].Name, point.X + A[i], point.Y + B[i]);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X + A[i]][point.Y + B[i]].BackColor = Color.LightBlue;
                        Matrix[point.X + A[i]][point.Y + B[i]].Name = "A";
                    }
                    else if(IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X + A[i]][point.Y + B[i]].Name)==false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X + A[i]][point.Y + B[i]].BackColor,
                                Matrix[point.X + A[i]][point.Y + B[i]].Name, point.X + A[i], point.Y + B[i]);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X + A[i]][point.Y + B[i]].BackColor = Color.Red;
                        Matrix[point.X + A[i]][point.Y + B[i]].Name = "K";
                    }
                }
            }
         }
    }
}
/*Vị Trí 1: X>=2 && Y<=6  (Y+2,X-1)
             * Vị Trí 2: X<=7 && Y<=6 (Y+2,X+1)
             * Vị Trí 3: X>=3 && Y<=7 (Y+1,X-2)
             * Vị Trí 4: X<=6 && Y<=7  (Y+1,X+2)
             * Vị Trí 5: X>=3 && Y>=2   (Y-1,X-2)
             * Vị Trí 6: X<=6 && Y>=2  (Y-1,X+2)
             * Vị Trí 7: X>=2 && Y>=3   (Y-2,X-1)
             * Vị Trí 8: X<=7 && Y>=3  (Y-2,X+1)*/