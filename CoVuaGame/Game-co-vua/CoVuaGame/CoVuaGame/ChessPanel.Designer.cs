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
            this.SuspendLayout();
            // 
            // PanelChessBoard
            // 
            this.PanelChessBoard.Location = new System.Drawing.Point(166, 12);
            this.PanelChessBoard.Name = "PanelChessBoard";
            this.PanelChessBoard.Size = new System.Drawing.Size(792, 554);
            this.PanelChessBoard.TabIndex = 0;
            // 
            // ChessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 723);
            this.Controls.Add(this.PanelChessBoard);
            this.Name = "ChessPanel";
            this.Text = "ChessPanel";
            this.Load += new System.EventHandler(this.ChessPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChessBoard;
    }
}