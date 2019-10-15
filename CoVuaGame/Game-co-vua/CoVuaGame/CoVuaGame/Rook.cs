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
    class Rook:GeneralMethods
    { 
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
                for (int i = point.X; i >= 0; i--)//R_W di len
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);

                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                    
                }
                for (int i = point.X; i <=7; i++)//R_W di lui
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);
                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                }
                for (int j = point.Y; j >=0; j--)//R_W di sang trai
                {
                    if (Matrix[point.X][j].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X][j],point.X,j);

                        Matrix[point.X][j].BackColor = Color.LightBlue;
                        Matrix[point.X][j].Name = "A";
                    }
                    
                }
                for (int j = point.Y; j <= 7; j++)//R_W di sang phai
                {
                    if (Matrix[point.X][j].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X][j],point.X,j);

                        Matrix[point.X][j].BackColor = Color.LightBlue;
                        Matrix[point.X][j].Name = "A";
                    }
                }
        }

    }
}
