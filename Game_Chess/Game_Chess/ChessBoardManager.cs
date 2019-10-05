using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace chess1
{
    public class ChessBoardManager
    {
        #region Properties
        public Panel chessBoard
        { get; set; }
        #endregion

        #region Initialize
        public void image_chess(Button button, int i, int j)
        {
            if (i == 0)//ban den
            {
                switch (j)
                {
                    case 0:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Rook;
                        button.Name = "R_B";
                        break;
                    case 1:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Knight;
                        button.Name = "N_B";
                        break;
                    case 2:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Bishop;
                        button.Name = "B_B";
                        break;
                    case 3:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Queen;
                        button.Name = "Q_B";
                        break;
                    case 4:
                        button.BackgroundImage = Game_Chess.Properties.Resources.king;
                        button.Name = "K_B";
                        break;
                    case 5:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Bishop;
                        button.Name = "B_B";
                        break;
                    case 6:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Knight;
                        button.Name = "N_B";
                        break;
                    case 7:
                        button.BackgroundImage = Game_Chess.Properties.Resources.Rook;
                        button.Name = "R_B";
                        break;

                }

            }
            else if (i == 1)//hang tot den
            {
                button.BackgroundImage = Game_Chess.Properties.Resources.Trooper;
                button.Name = "T_B";
            }
            else if (i == 6)
            {
                button.BackgroundImage = Game_Chess.Properties.Resources.TrooperWhite;
                button.Name = "T_W";
            }
            else if (i == 7)//ban trang
            {
                switch (j)
                {
                    case 0:
                        button.BackgroundImage = Game_Chess.Properties.Resources.RookWhite;
                        button.Name = "R_W";
                        break;
                    case 1:
                        button.BackgroundImage = Game_Chess.Properties.Resources.KnightWhite;
                        button.Name = "N_W";
                        break;
                    case 2:
                        button.BackgroundImage = Game_Chess.Properties.Resources.BishopWhite;
                        button.Name = "B_W";
                        break;
                    case 3:
                        button.BackgroundImage = Game_Chess.Properties.Resources.QueenWhite;
                        button.Name = "Q_W";
                        break;
                    case 4:
                        button.BackgroundImage = Game_Chess.Properties.Resources.KingWhite;
                        button.Name = "K_W";
                        break;
                    case 5:
                        button.BackgroundImage = Game_Chess.Properties.Resources.BishopWhite;
                        button.Name = "B_W";
                        break;
                    case 6:
                        button.BackgroundImage = Game_Chess.Properties.Resources.KnightWhite;
                        button.Name = "N_W";
                        break;
                    case 7:
                        button.BackgroundImage = Game_Chess.Properties.Resources.RookWhite;
                        button.Name = "R_W";
                        break;

                }
            }
            else
            {
                button.Name = "Null";
            }
        }
        public ChessBoardManager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;
        }
        #endregion

        #region Methods

        public void drawchessboard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Button button = new Button()
                    {
                        Width = 60,
                        Height = 60,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    chessBoard.Controls.Add(button);
                    oldButton = button;
                    if (i == 0 || i == 2 || i == 4 || i == 6)
                    {
                        if (j == 0 || j == 2 || j == 4 || j == 6)
                            button.BackColor = Color.MintCream;
                        else
                            button.BackColor = Color.BurlyWood;
                    }
                    if (i == 1 || i == 3 || i == 5 || i == 7)
                    {
                        if (j == 1 || j == 3 || j == 5 || j == 7)
                            button.BackColor = Color.MintCream;
                        else
                            button.BackColor = Color.BurlyWood;
                    }
                    image_chess(oldButton, i, j);
                }

                oldButton.Location = new Point(0, oldButton.Location.Y + oldButton.Height);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void btn_click(object sender, EventArgs e)
        {

        }

        #endregion}
    }
}
