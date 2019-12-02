namespace CoVuaGame
{
    partial class ChessPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelChessBoard = new System.Windows.Forms.Panel();
            this.pnlFirstPlayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UndoButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSecondPlayer = new System.Windows.Forms.Panel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlPlayer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMusicToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMusicToolStripMenuItem
            // 
            this.openMusicToolStripMenuItem.Name = "openMusicToolStripMenuItem";
            this.openMusicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMusicToolStripMenuItem.Text = "Open Music";
            this.openMusicToolStripMenuItem.Click += new System.EventHandler(this.openMusicToolStripMenuItem_Click);
            // 
            // PanelChessBoard
            // 
            this.PanelChessBoard.BackColor = System.Drawing.Color.White;
            this.PanelChessBoard.Location = new System.Drawing.Point(565, 143);
            this.PanelChessBoard.Name = "PanelChessBoard";
            this.PanelChessBoard.Size = new System.Drawing.Size(200, 200);
            this.PanelChessBoard.TabIndex = 1;
            this.PanelChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChessBoard_Paint);
            // 
            // pnlFirstPlayer
            // 
            this.pnlFirstPlayer.BackColor = System.Drawing.Color.White;
            this.pnlFirstPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFirstPlayer.Location = new System.Drawing.Point(28, 58);
            this.pnlFirstPlayer.Name = "pnlFirstPlayer";
            this.pnlFirstPlayer.Size = new System.Drawing.Size(200, 300);
            this.pnlFirstPlayer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayer1.Controls.Add(this.UndoButton);
            this.pnlPlayer1.Controls.Add(this.label1);
            this.pnlPlayer1.Controls.Add(this.pnlFirstPlayer);
            this.pnlPlayer1.Location = new System.Drawing.Point(0, 40);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(280, 640);
            this.pnlPlayer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.UndoButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlSecondPlayer);
            this.panel1.Location = new System.Drawing.Point(920, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 640);
            this.panel1.TabIndex = 3;
            // 
            // UndoButton1
            // 
            this.UndoButton1.BackgroundImage = global::CoVuaGame.Properties.Resources.undo;
            this.UndoButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UndoButton1.Location = new System.Drawing.Point(120, 378);
            this.UndoButton1.Name = "UndoButton1";
            this.UndoButton1.Size = new System.Drawing.Size(75, 55);
            this.UndoButton1.TabIndex = 3;
            this.UndoButton1.UseVisualStyleBackColor = true;
            this.UndoButton1.Click += new System.EventHandler(this.UndoButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // pnlSecondPlayer
            // 
            this.pnlSecondPlayer.BackColor = System.Drawing.Color.White;
            this.pnlSecondPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecondPlayer.Location = new System.Drawing.Point(43, 58);
            this.pnlSecondPlayer.Name = "pnlSecondPlayer";
            this.pnlSecondPlayer.Size = new System.Drawing.Size(200, 300);
            this.pnlSecondPlayer.TabIndex = 0;
            // 
            // UndoButton
            // 
            this.UndoButton.BackgroundImage = global::CoVuaGame.Properties.Resources.undo;
            this.UndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UndoButton.Location = new System.Drawing.Point(79, 378);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 55);
            this.UndoButton.TabIndex = 2;
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ChessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelChessBoard);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChessPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChessPanel";
            this.Load += new System.EventHandler(this.ChessPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMusicToolStripMenuItem;
        private System.Windows.Forms.Panel PanelChessBoard;
        private System.Windows.Forms.Panel pnlFirstPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSecondPlayer;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button UndoButton1;
    }
}