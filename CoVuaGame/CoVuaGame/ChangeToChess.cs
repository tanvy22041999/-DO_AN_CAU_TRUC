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
    public partial class ChangeToChess : Form
    {
        private string clr = "";
        public ChangeToChess()
        {
            InitializeComponent();
        }

        private void ChangeToChess_Load(object sender, EventArgs e)
        {
            clr = Manager.TypeChess;
            if(clr=="W")
            {
                btnRook.BackgroundImage = Properties.Resources.RookWhite;
                btnQueen.BackgroundImage = Properties.Resources.QueenWhite;
                btnKnight.BackgroundImage = Properties.Resources.KnightWhite;
                btnBishop.BackgroundImage = Properties.Resources.BishopWhite;
            }
            else
            {
                btnRook.BackgroundImage = Properties.Resources.Rook;
                btnQueen.BackgroundImage = Properties.Resources.Queen;
                btnKnight.BackgroundImage = Properties.Resources.Knight;
                btnBishop.BackgroundImage = Properties.Resources.Bishop;
            }
        }

        private void btnQueen_Click(object sender, EventArgs e)
        {
            Manager.TypeChess = clr + "_Q";
        }

        private void btnRook_Click(object sender, EventArgs e)
        {
            Manager.TypeChess = clr + "_R";
        }

        private void btnBishop_Click(object sender, EventArgs e)
        {
            Manager.TypeChess = clr + "_B";
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            Manager.TypeChess = clr + "_N";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
