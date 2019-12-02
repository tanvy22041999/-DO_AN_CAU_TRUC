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
    public partial class PlayMusic : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        private bool isPlay = false;

        public static bool isOpenForm = false;

        public PlayMusic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3Player.play();
            Button button = sender as Button;
            if (isPlay==false)
            {
                mp3Player.play();

                button.BackgroundImage = Properties.Resources.Pause;
                isPlay = true;
            }
            else
            {
                mp3Player.pause();

                button.BackgroundImage = Properties.Resources.Stop;
                isPlay = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isOpenForm = false;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
