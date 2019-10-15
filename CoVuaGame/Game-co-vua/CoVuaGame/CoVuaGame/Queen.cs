using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    class Queen
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            int i;
            //cheo chinh
            for (i = point.X; i >= 0; i--)//R_W di len
            {
                if (Matrix[i][point.Y].Name == "NULL")
                {
                    Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);

                    Matrix[i][point.Y].BackColor = Color.LightBlue;
                    Matrix[i][point.Y].Name = "A";
                }

            }
            for (i = point.X; i <= 7; i++)//R_W di lui
            {
                if (Matrix[i][point.Y].Name == "NULL")
                {
                    Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);
                    Matrix[i][point.Y].BackColor = Color.LightBlue;
                    Matrix[i][point.Y].Name = "A";
                }
            }
            for (int j = point.Y; j >= 0; j--)//R_W di sang trai
            {
                if (Matrix[point.X][j].Name == "NULL")
                {
                    Manager.stackButton.Push(Matrix[point.X][j], point.X, j);

                    Matrix[point.X][j].BackColor = Color.LightBlue;
                    Matrix[point.X][j].Name = "A";
                }

            }
            for (int j = point.Y; j <= 7; j++)//R_W di sang phai
            {
                if (Matrix[point.X][j].Name == "NULL")
                {
                    Manager.stackButton.Push(Matrix[point.X][j], point.X, j);

                    Matrix[point.X][j].BackColor = Color.LightBlue;
                    Matrix[point.X][j].Name = "A";
                }
            }
            i = 1;
            while (i <= 7)// sang trai tren
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
            }

        }
    }
}
