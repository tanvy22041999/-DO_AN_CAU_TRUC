namespace CoVuaGame
{
    partial class chonplayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_playlai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_2player = new System.Windows.Forms.Button();
            this.bt_1play = new System.Windows.Forms.Button();
            this.tt_1player = new System.Windows.Forms.ToolTip(this.components);
            this.tt_2player = new System.Windows.Forms.ToolTip(this.components);
            this.tt_quaylai = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_playlai
            // 
            this.bt_playlai.BackgroundImage = global::CoVuaGame.Properties.Resources.quaylai;
            this.bt_playlai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_playlai.Location = new System.Drawing.Point(277, 297);
            this.bt_playlai.Name = "bt_playlai";
            this.bt_playlai.Size = new System.Drawing.Size(96, 44);
            this.bt_playlai.TabIndex = 6;
            this.bt_playlai.UseVisualStyleBackColor = true;
            this.bt_playlai.Click += new System.EventHandler(this.bt_playlai_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CoVuaGame.Properties.Resources.covua;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(307, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 54);
            this.panel2.TabIndex = 4;
            // 
            // bt_2player
            // 
            this.bt_2player.BackgroundImage = global::CoVuaGame.Properties.Resources.button;
            this.bt_2player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_2player.Location = new System.Drawing.Point(351, 228);
            this.bt_2player.Name = "bt_2player";
            this.bt_2player.Size = new System.Drawing.Size(96, 44);
            this.bt_2player.TabIndex = 5;
            this.bt_2player.UseVisualStyleBackColor = true;
            this.bt_2player.Click += new System.EventHandler(this.bt_2player_Click);
            // 
            // bt_1play
            // 
            this.bt_1play.BackgroundImage = global::CoVuaGame.Properties.Resources.oneplayer;
            this.bt_1play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_1play.Location = new System.Drawing.Point(351, 165);
            this.bt_1play.Name = "bt_1play";
            this.bt_1play.Size = new System.Drawing.Size(96, 44);
            this.bt_1play.TabIndex = 3;
            this.bt_1play.UseVisualStyleBackColor = true;
            // 
            // tt_1player
            // 
            this.tt_1player.ToolTipTitle = "Chọn 1 Người Chơi";
            // 
            // tt_2player
            // 
            this.tt_2player.ToolTipTitle = "Chọn 2 Người Chơi";
            // 
            // tt_quaylai
            // 
            this.tt_quaylai.ToolTipTitle = "Quay lại menu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CoVuaGame.Properties.Resources.nhac;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(427, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 44);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chonplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoVuaGame.Properties.Resources.Chess_BG_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_playlai);
            this.Controls.Add(this.bt_2player);
            this.Controls.Add(this.bt_1play);
            this.Controls.Add(this.panel2);
            this.Name = "chonplayer";
            this.Text = "chonplayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_playlai;
        private System.Windows.Forms.Button bt_2player;
        private System.Windows.Forms.Button bt_1play;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip tt_1player;
        private System.Windows.Forms.ToolTip tt_2player;
        private System.Windows.Forms.ToolTip tt_quaylai;
        private System.Windows.Forms.Button button1;
    }
}