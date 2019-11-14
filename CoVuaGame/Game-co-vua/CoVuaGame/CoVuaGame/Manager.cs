using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoVuaGame
{
    public class Manager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }


        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private int panelWidth;
        public int PanelWidth
        {
            set { panelWidth = value; }
            get { return panelWidth; }
        }

        private int panelHeight;
        public int PanelHeight
        {
            set { panelHeight = value; }
            get { return panelHeight; }
        }

        public int buttonColor = 1;

        public static StackCoVua<Button> stackButton = new StackCoVua<Button>();
        #endregion

        #region Initialize
        public Manager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        public Button sourceButton;
        public Button desnitationButton;
        #endregion

        #region Methods
        public void DrawPanelChessBoard()
        {
            ChessBoard.Controls.Clear();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < 8; i++)
            {
                buttonColor = (buttonColor == 0) ? 1 : 0;
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 9; j++)
                {
                    Button button = new Button()
                    {
                        Width = 80,
                        Height = 80,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    SetImage(button, i, j);

                    if (buttonColor == 1)
                    {
                        button.BackColor = Color.BurlyWood;
                    }

                    buttonColor = (buttonColor == 0) ? 1 : 0;

                    button.Click += button_Click;

                    ChessBoard.Controls.Add(button);

                    Matrix[i].Add(button);

                    oldButton = button;
                }
                buttonColor = (buttonColor == 0) ? 1 : 0;
                oldButton.Location = new Point(0, oldButton.Location.Y + 80);
                oldButton.Width = 0;
                oldButton.Height = 0;


            }
        }

        public void LocationPanel()
        {
            ChessBoard.Location = new Point(100, 20);
        }

        private Point GetChess(List<List<Button>> Matrix, Button button)
        {
            int row = Convert.ToInt32(button.Tag);
            int col = Matrix[row].IndexOf(button);

            Point point = new Point(row, col);
            return point;
        }

        public void SizePanel()
        {
            PanelHeight = 80 * 9;
            PanelWidth = 80 * 9;

            ChessBoard.Size = new System.Drawing.Size(PanelWidth, PanelHeight);
        }


        public void SetImage(Button button, int i, int j)
        {
            if (i == 0)
            {
                switch (j)
                {
                    case 0:
                        button.BackgroundImage = Properties.Resources.Rook;
                        button.Name = "B_R";
                        break;
                    case 1:
                        button.BackgroundImage = Properties.Resources.Knight;
                        button.Name = "B_N";
                        break;
                    case 2:
                        button.BackgroundImage = Properties.Resources.Bishop;
                        button.Name = "B_B";
                        break;
                    case 3:
                        button.BackgroundImage = Properties.Resources.Queen;
                        button.Name = "B_Q";
                        break;
                    case 4:
                        button.BackgroundImage = Properties.Resources.King;
                        button.Name = "B_K";
                        break;
                    case 5:
                        button.BackgroundImage = Properties.Resources.Bishop;
                        button.Name = "B_B";
                        break;
                    case 6:
                        button.BackgroundImage = Properties.Resources.Knight;
                        button.Name = "B_N";
                        break;

                    case 7:
                        button.BackgroundImage = Properties.Resources.Rook;
                        button.Name = "B_R";
                        break;
                }
            }
            else if (i == 7)
            {
                switch (j)
                {
                    case 0:
                        button.BackgroundImage = Properties.Resources.RookWhite;
                        button.Name = "W_R";
                        break;
                    case 1:
                        button.BackgroundImage = Properties.Resources.KnightWhite;
                        button.Name = "W_N";
                        break;
                    case 2:
                        button.BackgroundImage = Properties.Resources.BishopWhite;
                        button.Name = "W_B";
                        break;
                    case 3:
                        button.BackgroundImage = Properties.Resources.QueenWhite;
                        button.Name = "W_Q";
                        break;
                    case 4:
                        button.BackgroundImage = Properties.Resources.KingWhite;
                        button.Name = "W_K";
                        break;
                    case 5:
                        button.BackgroundImage = Properties.Resources.BishopWhite;
                        button.Name = "W_B";
                        break;
                    case 6:
                        button.BackgroundImage = Properties.Resources.KnightWhite;
                        button.Name = "W_N";
                        break;

                    case 7:
                        button.BackgroundImage = Properties.Resources.RookWhite;
                        button.Name = "W_R";
                        break;
                }
            }
            else if (i == 1)
            {
                button.BackgroundImage = Properties.Resources.Trooper;
                button.Name = "B_T";
            }
            else if (i == 6)
            {
                button.BackgroundImage = Properties.Resources.TrooperWhite;
                button.Name = "W_T";
            }
            else
            {
                button.Name = "NULL";
            }
        }

        public void Move(List<List<Button>> Matrix, Button source, Button Desnitation)
        {
            Point pointSource = GetChess(Matrix, source);
            Point pointDesnitation = GetChess(Matrix, Desnitation);

            Matrix[pointDesnitation.X][pointDesnitation.Y].BackgroundImage = Matrix[pointSource.X][pointSource.Y].BackgroundImage;
            Matrix[pointDesnitation.X][pointDesnitation.Y].Name = Matrix[pointSource.X][pointSource.Y].Name;

            Matrix[pointSource.X][pointSource.Y].BackgroundImage = null;
            Matrix[pointSource.X][pointSource.Y].Name = "NULL";
        }

        public void Kill(List<List<Button>> Matrix, Button btnSource, Button btnDesnitation)
        {
            Point pointSource = GetChess(Matrix, btnSource);
            Point pointDesnitation = GetChess(Matrix, btnDesnitation);

            Matrix[pointDesnitation.X][pointDesnitation.Y].BackgroundImage = Matrix[pointSource.X][pointSource.Y].BackgroundImage;
            Matrix[pointDesnitation.X][pointDesnitation.Y].Name = Matrix[pointSource.X][pointSource.Y].Name;

            Matrix[pointSource.X][pointSource.Y].BackgroundImage = null;
            Matrix[pointSource.X][pointSource.Y].Name = "NULL";
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string btnName = button.Name;

            MoveButton(button, btnName);
        }
        public void MoveButton(Button button,string NameButton)
        {
            switch(NameButton)
            {
                case "W_T":
                case "B_T":
                    Trooper t = new Trooper();
                    while (stackButton.Count > 0)
                    {
                        int X = stackButton.X;
                        int Y = stackButton.Y;
                        Button btn = stackButton.Pop();

                        Matrix[X][Y].BackColor = btn.BackColor;
                        Matrix[X][Y].Name = btn.Name;

                    }
                    sourceButton = button;

                    Point pointTrooper = GetChess(Matrix, button);
                    if (pointTrooper.X == 0 || pointTrooper.X == 7)
                        break;
                    t.CanMove(Matrix, pointTrooper);
                    t.CanKill(Matrix, pointTrooper);
                    break;

                case "B_R":
                case "W_R":
                    Rook r = new Rook();
                    //while (stackButton.Count > 0)
                    //{
                    //    int X = stackButton.X;
                    //    int Y = stackButton.Y;
                    //    Button btn = stackButton.Pop();

                    //    Matrix[X][Y].BackColor = btn.BackColor;
                    //    Matrix[X][Y].Name = btn.Name;

                    //}
                    sourceButton = button;

                    Point pointRook = GetChess(Matrix, button);
                    r.CanMove(Matrix, pointRook);
                   // r.CanKill(Matrix, pointRook);
                    break;

                case "W_B":
                case "B_B":
                    Bishop b = new Bishop();
                    //while (stackButton.Count > 0)
                    //{
                    //    int X = stackButton.X;
                    //    int Y = stackButton.Y;
                    //    Button btn = stackButton.Pop();

                    //    Matrix[X][Y].BackColor = btn.BackColor;
                    //    Matrix[X][Y].Name = btn.Name;

                    //}
                    sourceButton = button;
                    Point pointBishop = GetChess(Matrix, button);
                    b.CanMove(Matrix, pointBishop);
                    // r.CanKill(Matrix, pointRook);
                    break;

                case "B_K":
                case "W_K":
                     King k = new King();
                    //while (stackButton.Count > 0)
                    //{
                    //    int X = stackButton.X;
                    //    int Y = stackButton.Y;
                    //    Button btn = stackButton.Pop();

                    //    Matrix[X][Y].BackColor = btn.BackColor;
                    //    Matrix[X][Y].Name = btn.Name;

                    //}
                    sourceButton = button;

                    Point pointKing = GetChess(Matrix, button);
                    k.CanMove(Matrix, pointKing);
                    // r.CanKill(Matrix, pointRook);
                    break;

                case "B_Q":
                case "W_Q":
                    Queen q = new Queen();
                    //while (stackButton.Count > 0)
                    //{
                    //    int X = stackButton.X;
                    //    int Y = stackButton.Y;
                    //    Button btn = stackButton.Pop();

                    //    Matrix[X][Y].BackColor = btn.BackColor;
                    //    Matrix[X][Y].Name = btn.Name;

                    //}
                    sourceButton = button;

                    Point pointQueen = GetChess(Matrix, button);
                    q.CanMove(Matrix, pointQueen);
                    // r.CanKill(Matrix, pointRook);
                    break;
                case "B_N":
                case "W_N":
                    Knight n = new Knight();
                    //while (stackButton.Count > 0)
                    //{
                    //    int X = stackButton.X;
                    //    int Y = stackButton.Y;
                    //    Button btn = stackButton.Pop();

                    //    Matrix[X][Y].BackColor = btn.BackColor;
                    //    Matrix[X][Y].Name = btn.Name;

                    //}
                    sourceButton = button;

                    Point pointKnight = GetChess(Matrix, button);
                    n.CanMove(Matrix,pointKnight);
                    // r.CanKill(Matrix, pointRook);
                    break;
                case "A":
                    desnitationButton = button;
                    Move(Matrix, sourceButton, desnitationButton);
                    break;
                case "K":
                    desnitationButton = button;
                    Kill(Matrix, sourceButton, desnitationButton);
                    break;
            }
        }

            #endregion
    }
}
