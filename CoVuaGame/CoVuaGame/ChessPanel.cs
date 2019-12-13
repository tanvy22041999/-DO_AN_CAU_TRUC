using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    public partial class ChessPanel : Form
    {
        #region Properties
        Manager ChessBoard;
 
        Form music;

        #endregion
        public ChessPanel()
        {
            InitializeComponent();
            ChessBoard = new Manager(PanelChessBoard,pnlFirstPlayer, pnlSecondPlayer);
            ChessBoard.SizePanel();
            ChessBoard.LocationPanel();
            ChessBoard.DrawPanelChessBoard();
            UndoButton1.Enabled = false;
        }

        private void openMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PlayMusic.isOpenForm==false)
            {
                music = new PlayMusic();
                music.Show();
                PlayMusic.isOpenForm = true;
            }
            else
            {
                music.Show();
                music.MaximizeBox = true;
            }         
        }

        private void ChessPanel_Load(object sender, EventArgs e)
        {
            if (ChessBoard.CurrentPlayer == "W")
            {
                UndoButton1.Enabled = false;
                UndoButton.Enabled = true;
            }
            else
            {
                UndoButton1.Enabled = true;
                UndoButton.Enabled = false;
            }
            if(PanelChessBoard.Enabled==false)
            {
                Form giaodien = new GiaoDien();
                this.Hide();
                giaodien.ShowDialog();
                Application.Exit();
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            ChessBoard.Undo();
            ChessBoard.ChangePlayer();
        }

        private void UndoButton1_Click(object sender, EventArgs e)
        {
            ChessBoard.Undo();
            ChessBoard.ChangePlayer();

        }

        private void PanelChessBoard_Paint(object sender, PaintEventArgs e)
        {
            if (ChessBoard.CurrentPlayer == "W")
            {
                UndoButton1.Enabled = false;
                UndoButton.Enabled = true;
            }
            else
            {
                UndoButton1.Enabled = true;
                UndoButton.Enabled = false;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form giaodien = new GiaoDien();
            this.Hide();
            giaodien.ShowDialog();
            Application.Exit();
        }
    }
}
