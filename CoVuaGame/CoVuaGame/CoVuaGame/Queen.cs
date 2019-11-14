using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    class Queen:GeneralMethods
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            int i;
            if (point.X - 1 >= 0)
            {
                for (i = point.X - 1; i >= 0; i--)//R_W di len
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[i][point.Y].BackColor, Matrix[i][point.Y].Name, i, point.Y);

                        Manager.stackInfo.Push(info);

                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[i][point.Y].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[i][point.Y].BackColor, Matrix[i][point.Y].Name, i, point.Y);

                        Manager.stackInfo.Push(info);

                        Matrix[i][point.Y].BackColor = Color.Red;
                        Matrix[i][point.Y].Name = "K";

                        i = -1;
                    }
                    else { i = -1; }

                }
            }
            if (point.X + 1 <= 7)
            {
                for (i = point.X + 1; i <= 7; i++)//R_W di lui
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[i][point.Y].BackColor, Matrix[i][point.Y].Name, i, point.Y);

                        Manager.stackInfo.Push(info);

                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[i][point.Y].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[i][point.Y].BackColor, Matrix[i][point.Y].Name, i, point.Y);

                        Manager.stackInfo.Push(info);

                        Matrix[i][point.Y].BackColor = Color.Red;
                        Matrix[i][point.Y].Name = "K";

                        i = 8;
                    }
                    else { i = 8; }
                }
            }
            if (point.Y - 1 >= 0)
            {
                for (i = point.Y - 1; i >= 0; i--)//R_W di sang trai
                {
                    if (Matrix[point.X][i].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X][i].BackColor, Matrix[point.X][i].Name, point.X, i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X][i].BackColor = Color.LightBlue;
                        Matrix[point.X][i].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X][i].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X][i].BackColor, Matrix[point.X][i].Name, point.X, i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X][i].BackColor = Color.Red;
                        Matrix[point.X][i].Name = "K";

                        i = -1;
                    }
                    else { i = -1; }
                }
            }
            if (point.Y + 1 <= 7)
            {
                for (i = point.Y + 1; i <= 7; i++)//R_W di sang phai
                {
                    if (Matrix[point.X][i].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X][i].BackColor, Matrix[point.X][i].Name, point.X, i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X][i].BackColor = Color.LightBlue;
                        Matrix[point.X][i].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X][i].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X][i].BackColor, Matrix[point.X][i].Name, point.X, i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X][i].BackColor = Color.Red;
                        Matrix[point.X][i].Name = "K";

                        i = 8;
                    }
                    else { i = 8; }
                }
            }

            i = 1;
            for (i = 1; i <= 7; i++)//len phai
            {
                if (point.X - i >= 0 && point.Y + i <= 7)
                {
                    if (Matrix[point.X - i][point.Y + i].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X - i][point.Y + i].BackColor, Matrix[point.X - i][point.Y + i].Name, point.X - i, point.Y + i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X - i][point.Y + i].BackColor = Color.LightBlue;
                        Matrix[point.X - i][point.Y + i].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X - i][point.Y + i].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X - i][point.Y + i].BackColor, Matrix[point.X - i][point.Y + i].Name, point.X - i, point.Y + i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X - i][point.Y + i].BackColor = Color.Red;
                        Matrix[point.X - i][point.Y + i].Name = "K";

                        i = 8;
                    }
                    else { i = 8; }
                }
                else break;
            }
            for (i = 1; i <= 7; i++)// xuong phai
            {
                if (point.X + i <= 7 && point.Y + i <= 7)
                {
                    if (Matrix[point.X + i][point.Y + i].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X + i][point.Y + i].BackColor, Matrix[point.X + i][point.Y + i].Name, point.X + i, point.Y + i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X + i][point.Y + i].BackColor = Color.LightBlue;
                        Matrix[point.X + i][point.Y + i].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X + i][point.Y + i].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X + i][point.Y + i].BackColor, Matrix[point.X + i][point.Y + i].Name, point.X + i, point.Y + i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X + i][point.Y + i].BackColor = Color.Red;
                        Matrix[point.X + i][point.Y + i].Name = "K";

                        i = 8;
                    }
                    else { i = 8; }
                }
                else break;
            }
            for (i = 1; i <= 7; i++)//Xuong Trai
            {
                if (point.X + i <= 7 && point.Y - i >= 0)
                {
                    if (Matrix[point.X + i][point.Y - i].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X + i][point.Y - i].BackColor, Matrix[point.X + i][point.Y - i].Name, point.X + i, point.Y - i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X + i][point.Y - i].BackColor = Color.LightBlue;
                        Matrix[point.X + i][point.Y - i].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X + i][point.Y - i].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X + i][point.Y - i].BackColor, Matrix[point.X + i][point.Y - i].Name, point.X + i, point.Y - i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X + i][point.Y - i].BackColor = Color.Red;
                        Matrix[point.X + i][point.Y - i].Name = "K";

                        i = 8;
                    }
                    else { i = 8; }
                }
                else break;
            }
            for (i = 1; i <= 7; i++)// Len trai
            {
                if (point.X - i >= 0 && point.Y - i >= 0)
                {
                    if (Matrix[point.X - i][point.Y - i].Name == "NULL")
                    {
                        InfoStack info = new InfoStack(Matrix[point.X - i][point.Y - i].BackColor, Matrix[point.X - i][point.Y - i].Name, point.X - i, point.Y - i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X - i][point.Y - i].BackColor = Color.LightBlue;
                        Matrix[point.X - i][point.Y - i].Name = "A";
                    }
                    else if (IsTeamMate(Matrix[point.X][point.Y].Name, Matrix[point.X - i][point.Y - i].Name) == false)
                    {
                        InfoStack info = new InfoStack(Matrix[point.X - i][point.Y - i].BackColor, Matrix[point.X - i][point.Y - i].Name, point.X - i, point.Y - i);

                        Manager.stackInfo.Push(info);

                        Matrix[point.X - i][point.Y - i].BackColor = Color.Red;
                        Matrix[point.X - i][point.Y - i].Name = "K";

                        i = 8;
                    }
                    else { i = 8; }
                }
                else break;
            }
        }
    }
}
