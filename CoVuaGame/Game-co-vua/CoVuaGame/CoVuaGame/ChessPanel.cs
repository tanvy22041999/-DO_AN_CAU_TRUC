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

        #endregion
        public ChessPanel()
        {
            InitializeComponent();
            ChessBoard = new Manager(PanelChessBoard);
            ChessBoard.SizePanel();
            ChessBoard.LocationPanel();
            ChessBoard.DrawPanelChessBoard();
        }

        private void ChessPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
