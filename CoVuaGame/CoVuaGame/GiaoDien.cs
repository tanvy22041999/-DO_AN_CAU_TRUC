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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void bt_play_Click(object sender, EventArgs e)
        {
            bt_play.Enabled = false;
            Form co = new chonplayer();
            this.Hide();
            co.ShowDialog();
            Application.Exit();
        }

        private void bt_huongdan_Click(object sender, EventArgs e)
        {
            Form b = new luatchoi();
            b.ShowDialog();
            this.Show();
        }
    }
}
