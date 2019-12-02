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
    public partial class chonplayer : Form
    {
        public chonplayer()
        {
            InitializeComponent();
        }

        private void bt_playlai_Click(object sender, EventArgs e)
        {
            Form giaodien = new GiaoDien();
            this.Hide();
             giaodien.ShowDialog();
            Application.Exit();
        }

        private void bt_2player_Click(object sender, EventArgs e)
        {
            Form game = new ChessPanel();
            this.Hide();
            game.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form b = new PlayMusic();
            b.ShowDialog();
            this.Show();
        }
    }
}
