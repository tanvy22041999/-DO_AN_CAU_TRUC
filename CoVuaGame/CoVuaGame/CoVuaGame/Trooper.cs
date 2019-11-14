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
    class Trooper:GeneralMethods
    {
        int isFirstMove = 2;
        public Trooper()
        {
           
           
        }

        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            if ((point.X == 6 && Matrix[point.X][point.Y].Name == "W_T")|| (point.X == 1 && Matrix[point.X][point.Y].Name == "B_T"))
                isFirstMove = 2;
            else
                isFirstMove = 1;

            if(Matrix[point.X][point.Y].Name=="W_T")
            {
                for (int i = point.X-1; i>=point.X-isFirstMove; i--)
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[i][point.Y].BackColor, Matrix[i][point.Y].Name, i, point.Y);

                        Manager.stackInfo.Push(info);

                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                    else
                        break;
                }
            }
            else if(Matrix[point.X][point.Y].Name == "B_T")
            {
                for (int i = point.X +1 ; i <= point.X+ isFirstMove; i++)
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[i][point.Y].BackColor, Matrix[i][point.Y].Name, i, point.Y);

                        Manager.stackInfo.Push(info);

                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                    else break;
                }
            }
           
        }
        public void CanKill(List<List<Button>> Matrix, Point pointSource)
        {
            if (Matrix[pointSource.X][pointSource.Y].Name == "W_T")
            {
                if (pointSource.Y - 1 >= 0)
                {
                    if (Matrix[pointSource.X - 1][pointSource.Y - 1].BackgroundImage != null)
                    {
                        if (IsTeamMate(Matrix[pointSource.X][pointSource.Y].Name, Matrix[pointSource.X - 1][pointSource.Y - 1].Name) == false)
                        {
                            InfoStack info = new InfoStack(Matrix[pointSource.X - 1][pointSource.Y - 1].BackColor,
                                Matrix[pointSource.X - 1][pointSource.Y - 1].Name , pointSource.X - 1, pointSource.Y - 1);
                          
                            Manager.stackInfo.Push(info);

                            Matrix[pointSource.X - 1][pointSource.Y - 1].BackColor = Color.Red;
                            Matrix[pointSource.X - 1][pointSource.Y - 1].Name = "K";
                        }
                    }
                }
                if (Matrix[pointSource.X - 1][pointSource.Y + 1].BackgroundImage != null)
                {
                    if (IsTeamMate(Matrix[pointSource.X][pointSource.Y].Name, Matrix[pointSource.X - 1][pointSource.Y + 1].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[pointSource.X - 1][pointSource.Y + 1].BackColor,
                           Matrix[pointSource.X - 1][pointSource.Y + 1].Name, pointSource.X - 1, pointSource.Y + 1);

                        Manager.stackInfo.Push(info);

                        Matrix[pointSource.X - 1][pointSource.Y + 1].BackColor = Color.Red;
                        Matrix[pointSource.X - 1][pointSource.Y + 1].Name = "K";
                    }
                }
            }
            if (Matrix[pointSource.X][pointSource.Y].Name == "B_T")
            {
                if (pointSource.Y - 1 >= 0)
                {
                    if (Matrix[pointSource.X + 1][pointSource.Y - 1].BackgroundImage != null)
                    {
                        if (IsTeamMate(Matrix[pointSource.X][pointSource.Y].Name, Matrix[pointSource.X + 1][pointSource.Y - 1].Name) == false)
                        {
                            InfoStack info = new InfoStack(Matrix[pointSource.X + 1][pointSource.Y - 1].BackColor,
                                 Matrix[pointSource.X + 1][pointSource.Y - 1].Name, pointSource.X + 1, pointSource.Y - 1);

                            Manager.stackInfo.Push(info);

                            Matrix[pointSource.X + 1][pointSource.Y - 1].BackColor = Color.Red;
                            Matrix[pointSource.X + 1][pointSource.Y - 1].Name = "K";
                        }
                    }
                }
                if (Matrix[pointSource.X + 1][pointSource.Y + 1].BackgroundImage != null)
                {
                    if (IsTeamMate(Matrix[pointSource.X][pointSource.Y].Name, Matrix[pointSource.X + 1][pointSource.Y + 1].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[pointSource.X + 1][pointSource.Y + 1].BackColor,
                           Matrix[pointSource.X + 1][pointSource.Y + 1].Name, pointSource.X + 1, pointSource.Y + 1);
                        
                        Manager.stackInfo.Push(info);

                        Matrix[pointSource.X + 1][pointSource.Y + 1].BackColor = Color.Red;
                        Matrix[pointSource.X + 1][pointSource.Y + 1].Name = "K";
                    }
                }
            }
        }

    }
}
