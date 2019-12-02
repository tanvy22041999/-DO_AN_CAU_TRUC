namespace CoVuaGame
{
    partial class GiaoDien
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
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_huongdan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_play
            // 
            this.bt_play.BackgroundImage = global::CoVuaGame.Properties.Resources.but;
            this.bt_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_play.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_play.Location = new System.Drawing.Point(87, 176);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(154, 61);
            this.bt_play.TabIndex = 11;
            this.bt_play.Text = "Play Game";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.bt_play_Click);
            // 
            // bt_huongdan
            // 
            this.bt_huongdan.BackgroundImage = global::CoVuaGame.Properties.Resources.but;
            this.bt_huongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_huongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huongdan.ForeColor = System.Drawing.Color.White;
            this.bt_huongdan.Location = new System.Drawing.Point(87, 241);
            this.bt_huongdan.Name = "bt_huongdan";
            this.bt_huongdan.Size = new System.Drawing.Size(154, 61);
            this.bt_huongdan.TabIndex = 12;
            this.bt_huongdan.Text = "Xem Luật Chơi";
            this.bt_huongdan.UseVisualStyleBackColor = true;
            this.bt_huongdan.Click += new System.EventHandler(this.bt_huongdan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::CoVuaGame.Properties.Resources.Chess_BG_3;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Game Chess";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CoVuaGame.Properties.Resources.but;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(87, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoVuaGame.Properties.Resources.backgroud1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_huongdan);
            this.Controls.Add(this.bt_play);
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button bt_huongdan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}