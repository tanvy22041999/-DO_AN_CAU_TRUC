using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoVuaGame
{
    public class Bishop : GeneralMethods
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
                int[] A = { -1,-1,-2,-2,-3,-3,-4,-4,-5,-5,-6,-6,-7,-7,-8,-8,1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8};//
                int[] B = { -1, 1,-2, 2,-3, 3,-4,4,-5,5,-6,6,-7,7,-8,8 , -1, 1, -2, 2, -3, 3, -4, 4, -5, 5, -6, 6, -7, 7, -8, 8 };
                for (int i = 0; i < 32; i++)
                {
                    if (point.X + A[i] >= 0 && point.X + A[i] <= 7 && point.Y + B[i] >= 0 && point.Y + B[i] <= 7)
                    {
                        if (Matrix[point.X + A[i]][point.Y + B[i]].Name == "NULL")
                        {
                            Matrix[point.X + A[i]][point.Y + B[i]].BackColor = Color.LightBlue;
                            Matrix[point.X + A[i]][point.Y + B[i]].Name = "A";
                        }
                        else if(IsTeamMate(Matrix[point.X+A[i]][point.Y+B[i]].Name, Matrix[point.X +A[i]][point.Y + B[i]].Name) == false)
                        {
                            Matrix[point.X + A[i]][point.Y + B[i]].BackColor = Color.Red;
                              Matrix[point.X + A[i]][point.Y + B[i]].Name = "K";
                        }
                    }
                    }
                }
            /* int i=1;
             //cheo chinh
             while (i<=7)// sang trai tren
             {
                 if (point.X + i <= 7 && point.Y + i <= 7)
                 {
                     if (Matrix[point.X + i][point.Y + i].Name == "NULL")
                     {
                         //Manager.stackButton.Push(Matrix[point.X + i][point.Y + i], point.X + i, point.Y + i);

                         Matrix[point.X + i][point.Y + i].BackColor = Color.LightBlue;
                         Matrix[point.X + i][point.Y + i].Name = "A";

                     }
                 }
                 if (point.X - i >= 0 && point.Y - i >= 0)
                 {
                     if (Matrix[point.X - i][point.Y - i].Name == "NULL")
                     {
                         //Manager.stackButton.Push(Matrix[point.X - i][point.Y - i], point.X - i, point.Y - i);

                         Matrix[point.X - i][point.Y - i].BackColor = Color.LightBlue;
                         Matrix[point.X - i][point.Y - i].Name = "A";

                     }
                 }
                 if (point.X + i <= 7 && point.Y - i >= 0)
                 {
                     if (Matrix[point.X + i][point.Y - i].Name == "NULL")
                     {
                         //Manager.stackButton.Push(Matrix[point.X + i][point.Y - i], point.X + i, point.Y - i);

                         Matrix[point.X + i][point.Y - i].BackColor = Color.LightBlue;
                         Matrix[point.X + i][point.Y - i].Name = "A";
                     }
                 }
                 if (point.X - i >= 0 && point.Y + i <= 7)
                 {
                     if (Matrix[point.X - i][point.Y + i].Name == "NULL")
                     {
                         //Manager.stackButton.Push(Matrix[point.X - i][point.Y + i], point.X - i, point.Y + i);

                         Matrix[point.X - i][point.Y + i].BackColor = Color.LightBlue;
                         Matrix[point.X - i][point.Y + i].Name = "A";
                     }
                 }
                 i++;
             }*/
        }
    }
