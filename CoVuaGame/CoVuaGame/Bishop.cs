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
        public override void CanMove(List<List<Button>> Matrix, Point point)
        {
            int i;
            for (i = 1; i <=7; i++)//len phai
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
                if (point.X + i <= 7 && point.Y + i <=7)
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
      