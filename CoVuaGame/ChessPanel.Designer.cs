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
            this.PanelChessBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelChessBoard
            // 
            this.PanelChessBoard.Location = new System.Drawing.Point(332, 0);
            this.PanelChessBoard.Name = "PanelChessBoard";
            this.PanelChessBoard.Size = new System.Drawing.Size(262, 12);
            this.PanelChessBoard.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.openMusicToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openMusicToolStripMenuItem.Text = "Open Music";
            this.openMusicToolStripMenuItem.Click += new System.EventHandler(this.openMusicToolStripMenuItem_Click);
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayer1.Location = new System.Drawing.Point(0, 40);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(280, 640);
            this.pnlPlayer1.TabIndex = 2;
            // 
            // ChessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.PanelChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChessPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChessPanel";
            this.Load += new System.EventHandler(this.ChessPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelChessBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMusicToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPlayer1;
    }
}