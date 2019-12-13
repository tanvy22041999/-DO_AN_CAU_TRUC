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

        private Panel pnlPlayer1;
        public Panel PnlPlayer1
        {
            get { return pnlPlayer1; }
            set { pnlPlayer1 = value; }
        }

        private Panel pnlPlayer2;
        public Panel PnlPlayer2
        {
            get { return pnlPlayer2; }
            set { pnlPlayer2 = value; }
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

        private  string currentPlayer = "W";
        public  string CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public int buttonColor = 1;

        public static StackCoVua<InfoStack> stackInfo = new StackCoVua<InfoStack>();
        public static StackCoVua<InfoUndo> stackUndo = new StackCoVua<InfoUndo>();

        public static string TypeChess;

        //Kiểm xoát tọa độ thêm ảnh của 2 panel
        private Point pointP1 = new Point(0, 0);
        private Point pointP2 = new Point(0, 0);
        private int indexp1 = -1;
        private int indexp2 = -1;
        private Point CurrentPoint;
        #endregion

        #region Initialize
        public Manager(Panel chessBoard, Panel pnlEr1, Panel pnlEr2)
        {
            this.ChessBoard = chessBoard;
            this.PnlPlayer1 = pnlEr1;
            this.PnlPlayer2 = pnlEr2;
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
                    else
                        button.BackColor = Color.White;

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
            ChessBoard.Location = new Point(280, 40);
        }

        private Point GetChess(List<List<Button>> Matrix, Button button)//lu giu toa do ban co
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

        public void SetImage(Button button)
        {  switch(button.Name)
            {
                case "W_Q":
                    button.BackgroundImage = Properties.Resources.QueenWhite;
                    break;
                case "W_R":
                    button.BackgroundImage = Properties.Resources.RookWhite;
                    break;
                case "W_N":
                    button.BackgroundImage = Properties.Resources.KnightWhite;
                    break;
                case "W_B":
                    button.BackgroundImage = Properties.Resources.BishopWhite;
                    break;
                case "B_Q":
                    button.BackgroundImage = Properties.Resources.Queen;
                    break;
                case "B_R":
                    button.BackgroundImage = Properties.Resources.Rook;
                    break;
                case "B_N":
                    button.BackgroundImage = Properties.Resources.Knight;
                    break;
                case "B_B":
                    button.BackgroundImage = Properties.Resources.Bishop;
                    break;
            }
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

            //Change r if that is Trooper
            if (Matrix[pointDesnitation.X][pointDesnitation.Y].Name.Substring(2, 1) == "T")
            {
                ChangeChess(Matrix[pointDesnitation.X][pointDesnitation.Y], pointDesnitation.X);
            }
        }

        public void Kill(List<List<Button>> Matrix, Button btnSource, Button btnDesnitation)
        {
            Point pointSource = GetChess(Matrix, btnSource);
            Point pointDesnitation = GetChess(Matrix, btnDesnitation);

            Matrix[pointDesnitation.X][pointDesnitation.Y].BackgroundImage = Matrix[pointSource.X][pointSource.Y].BackgroundImage;
            Matrix[pointDesnitation.X][pointDesnitation.Y].Name = Matrix[pointSource.X][pointSource.Y].Name;

            Matrix[pointSource.X][pointSource.Y].BackgroundImage = null;
            Matrix[pointSource.X][pointSource.Y].Name = "NULL";

            //Change chess if that is Trooper
            if (Matrix[pointDesnitation.X][pointDesnitation.Y].Name.Substring(2, 1) == "T")
            {
                ChangeChess(Matrix[pointDesnitation.X][pointDesnitation.Y], pointDesnitation.X);
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Name.Substring(0, 1) == CurrentPlayer)
            {

                string btnName = button.Name;
                while (stackInfo.Count > 0)
                {
                    InfoStack info = stackInfo.Pop();

                    Matrix[info.X][info.Y].BackColor = info.Color;
                    Matrix[info.X][info.Y].Name = info.Name;

                }

                MoveButton(button, btnName);
            }
            else if ((button.Name == "A") || (button.Name == "K"))
            {
                string btnName = button.Name;
                while (stackInfo.Count > 0)
                {
                    InfoStack info = stackInfo.Pop();

                    Matrix[info.X][info.Y].BackColor = info.Color;
                    Matrix[info.X][info.Y].Name = info.Name;

                }

                MoveButton(button, btnName);

                ChangePlayer();
            }
        }

        public string ChangePlayer()//ham xet xen ke cua nguoi choi
        {
            CurrentPlayer = (CurrentPlayer == "W") ? "B" : "W";
            return CurrentPlayer;
        }

        public void ChangeChess(Button button,int Location_X)
        {
            if (Location_X == 0 || Location_X == 7)
            {
                TypeChess = button.Name.Substring(0, 1);
                Form changeChess = new ChangeToChess();
                if(changeChess.ShowDialog()==DialogResult.OK)
                {
                    button.Name = TypeChess;
                    SetImage(button);

                    TypeChess = "";
                }
            }
        }

        public void MoveButton(Button button,string NameButton)
        {
            switch(NameButton)
            {
                case "W_T":
                case "B_T":
                    Trooper t = new Trooper();
                    sourceButton = button;

                    Point pointTrooper = GetChess(Matrix, button);
          
                    t.CanMove(Matrix, pointTrooper);
                    t.CanKill(Matrix, pointTrooper);
                    break;

                case "B_R":
                case "W_R":
                    Rook r = new Rook();
                    sourceButton = button;

                    Point pointRook = GetChess(Matrix, button);
                    r.CanMove(Matrix, pointRook);
                    //r.CanKill(Matrix, pointRook);
                    break;

                case "W_B":
                case "B_B":
                    Bishop b = new Bishop();

                    sourceButton = button;
                    Point pointBishop = GetChess(Matrix, button);
                    b.CanMove(Matrix, pointBishop);
                    //r.CanKill(Matrix, pointRook);
                    break;

                case "W_K":
                case "B_K":
                    King k = new King();
                    King go = new King();
                    sourceButton = button;
                    Point pointKing = GetChess(Matrix, button);
                    k.CanMove(Matrix, pointKing);
                    //r.CanKill(Matrix, pointRook);
                    break;

                case "W_Q":
                case "B_Q":
                    Queen q = new Queen();
                   
                    sourceButton = button;
                    Point pointQueen = GetChess(Matrix, button);
                    q.CanMove(Matrix, pointQueen);

                    break;
                case "W_N":
                case "B_N":
                    Knight n = new Knight();
                
                    sourceButton = button;
                    Point pointKnight = GetChess(Matrix, button);
                    n.CanMove(Matrix, pointKnight);
                    break;

                case "A":
                    desnitationButton = button;

                    Point pointDes = GetChess(Matrix, desnitationButton);
                    Point pointSrc = GetChess(Matrix, sourceButton);
                    InfoUndo infoUndoDes = new InfoUndo(button.BackgroundImage, button.Name, pointDes.X, pointDes.Y);
                    InfoUndo infoUndoSrc = new InfoUndo(sourceButton.BackgroundImage, sourceButton.Name, pointSrc.X, pointSrc.Y);

                    stackUndo.Push(infoUndoSrc);
                    stackUndo.Push(infoUndoDes);

                    int x = GetChess(Matrix, sourceButton).Y - GetChess(Matrix, desnitationButton).Y;
                    Move(Matrix, sourceButton, desnitationButton);

                    
                    if (x==2 && (desnitationButton.Name=="B_K" || desnitationButton.Name=="W_K"))
                    {
                        Point point = new Point();

                        point = GetChess(Matrix, desnitationButton);
                        
                        Move(Matrix, Matrix[point.X][point.Y-2],Matrix[point.X][point.Y+1]);
                    }
                    else if(x==-2&& (desnitationButton.Name == "B_K" || desnitationButton.Name == "W_K"))
                    {
                        Point point = new Point();

                        point = GetChess(Matrix, desnitationButton);

                        Move(Matrix, Matrix[point.X][point.Y+1], Matrix[point.X][point.Y - 1]);
                    }
                    break;
                case "K":
                    //Gán đích chuẩn bị thay thế
                    desnitationButton = button;

                    Point pointDess = GetChess(Matrix, desnitationButton);
                    Point pointSrcs = GetChess(Matrix, sourceButton);

                    InfoUndo infoUndoDess = new InfoUndo(button.BackgroundImage, button.Name, pointDess.X, pointDess.Y);
                    InfoUndo infoUndoSrcs = new InfoUndo(sourceButton.BackgroundImage, sourceButton.Name, pointSrcs.X, pointSrcs.Y);

                    stackUndo.Push(infoUndoSrcs);
                    stackUndo.Push(infoUndoDess);

                    //Lấy ảnh đưa vào panel
                    if (button.Name.Substring(0, 1) == "W")
                    {
                        CurrentPoint = pointP2;
                    }
                    else
                    {
                        CurrentPoint = pointP1;
                    }

                    PictureBox picture = new PictureBox()
                    {
                        Width = 50,
                        Height = 50,
                        BackgroundImage = button.BackgroundImage,
                        Location = new Point(CurrentPoint.X, CurrentPoint.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        BorderStyle = BorderStyle.Fixed3D,
                        Name = button.Name
                       };
                    if (picture.Name.Substring(0,1)=="B")
                    {
                        PnlPlayer1.Controls.Add(picture);
                        indexp1 += 1;
                        IncreaseLocation(ref pointP1);
                        if (Matrix[pointDess.X][pointDess.Y].Name == "B_K")
                        {
                            indexp1 = -9;
                        }
                        
                    }
                    else
                    {
                        PnlPlayer2.Controls.Add(picture);
                        indexp2 += 1;
                        IncreaseLocation(ref pointP2);
                        if (Matrix[pointDess.X][pointDess.Y].Name == "W_K")
                        {
                            indexp2 = -10;
                            indexp1 = -9;
                        }
                    }

                    Kill(Matrix, sourceButton, desnitationButton);
                    if (indexp1 == -9)
                    {
                        MessageBox.Show("Player 1 You Win ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ChessBoard.Enabled = false;
                    }
                    else if (indexp2 == -10 && indexp1 == -9)
                    {
                        MessageBox.Show("Player 2 You Win ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ChessBoard.Enabled = false;
                    }
                    break;
                default:
                    
                    break;
            }      
        }
        private void IncreaseLocation(ref Point point)
        {
            if(point.X >=150)
            {
                point.X = 0;
                point.Y += 50;
            }
            else
            {
                point.X += 50;
            }
   
        }
        public void DecreaseLocation(ref Point point)
        {
            if(point.X ==0 )
            {
                if(point.Y != 0)
                {
                    point.X = 150;
                    point.Y -= 50;
                }
            }
            else if (point.X !=0)
            {
                point.X -= 50;
            }
            
        }
        public bool Undo()
        {
            if(stackUndo.Count<=0)
            {
                MessageBox.Show("Bàn cờ chưa được đi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            InfoUndo infoUndoDes = stackUndo.Pop();
            InfoUndo infoUndoSrc = stackUndo.Pop();

            Matrix[infoUndoSrc.X][infoUndoSrc.Y].BackgroundImage = Matrix[infoUndoDes.X][infoUndoDes.Y].BackgroundImage;
            Matrix[infoUndoSrc.X][infoUndoSrc.Y].Name = Matrix[infoUndoDes.X][infoUndoDes.Y].Name;

            Matrix[infoUndoDes.X][infoUndoDes.Y].BackgroundImage = infoUndoDes.Image;
            Matrix[infoUndoDes.X][infoUndoDes.Y].Name = infoUndoDes.Name;

            if (infoUndoDes.Image != null)
            {
                if (infoUndoDes.Name.Substring(0, 1) == "W")
                {
                    if (indexp2 > -1)
                    {
                        PnlPlayer2.Controls.RemoveAt(indexp2);
                        indexp2--;
                        DecreaseLocation(ref pointP2);
                    }
                }
                else
                {
     
                    if (indexp1 > -1)
                    {
                        PnlPlayer1.Controls.RemoveAt(indexp1);
                        indexp1--;
                        DecreaseLocation(ref pointP1);
                    }
                }
               

            }
            return true;
        }

        #endregion
    }
}
