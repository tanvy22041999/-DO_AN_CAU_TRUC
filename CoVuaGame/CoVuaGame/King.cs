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
        public override void CanMove(List<List<Button>> Matrix, Point point)
        {
            int dem = 0;
            int[] A = { -1, -2, -3,1,2};
            for (int i = 1; i >= -1; i--)
                {
                    for (int j = 1; j >= -1; j--)
                    {
                        if (point.X + i <= 7 && point.Y + j <= 7 && point.X + i >= 0 && point.Y + j >= 0)
                        {

                             if (Matrix[point.X + i][point.Y + j].Name == "NULL")
                              {
                                       
                                if (point.X == 7||point.X==0)//nhap thanh
                                {

                                     for(int go=0;go<=4;go++)
                                {
                                    InfoStack innt = new InfoStack(Matrix[point.X][point.Y + A[go]].BackColor,
                                     Matrix[point.X][point.Y + A[go]].Name, point.X, point.Y + A[go]);
                                    Manager.stackInfo.Push(innt);
                                    if (point.Y + A[go]<4 && Matrix[point.X][point.Y + A[go]].Name == "NULL")// nhap thanh xa trai
                                    {
                                        dem++;
                                        if (dem == 3 && Matrix[point.X][point.Y - 4].Name== "W_R")
                                        {
                                        
                                            Matrix[point.X][point.Y - 2].BackColor = Color.LightBlue;
                                            Matrix[point.X][point.Y - 2].Name = "A";
                                        }
                                        else if (dem == 3 && Matrix[point.X][point.Y - 4].Name == "B_R")
                                        {

                                            Matrix[point.X][point.Y - 2].BackColor = Color.LightBlue;
                                            Matrix[point.X][point.Y - 2].Name = "A";
                                        }


                                    }
                                    else if (point.Y + A[go]>4 && Matrix[point.X][point.Y + A[go]].Name == "NULL")// nhap thanh gan
                                    {
                                        dem++;
                                        if (dem == 2&& Matrix[point.X][point.Y + 3].Name == "W_R")
                                        {

                                            Matrix[point.X][point.Y + 2].BackColor = Color.LightBlue;
                                            Matrix[point.X][point.Y + 2].Name = "A";
                                        }
                                        else if (dem == 2&&Matrix[point.X][point.Y +3].Name == "B_R")
                                        {

                                            Matrix[point.X][point.Y + 2].BackColor = Color.LightBlue;
                                            Matrix[point.X][point.Y + 2].Name = "A";
                                        }
                                    }


                                }
                                }
                                    InfoStack info = new InfoStack(Matrix[point.X + i][point.Y + j].BackColor,
                                    Matrix[point.X + i][point.Y + j].Name, point.X + i, point.Y + j);
                                Manager.stackInfo.Push(info);

                                Matrix[point.X + i][point.Y + j].BackColor = Color.LightBlue;
                                Matrix[point.X + i][point.Y + j].Name = "A";
                            }
                            else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X + i][point.Y + j].Name) == false)//kill
                            {
                                InfoStack info = new InfoStack(Matrix[point.X + i][point.Y + j].BackColor,
                                    Matrix[point.X + i][point.Y + j].Name, point.X + i, point.Y + j);
                                Manager.stackInfo.Push(info);

                                Matrix[point.X + i][point.Y + j].BackColor = Color.Red;
                                Matrix[point.X + i][point.Y + j].Name = "K";
                            }

                        }

                    }
                }

        } 
    }
 }
