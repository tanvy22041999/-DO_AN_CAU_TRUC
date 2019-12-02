namespace CoVuaGame
{
    partial class ChangeToChess
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
            this.btnQueen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRook = new System.Windows.Forms.Button();
            this.btnBishop = new System.Windows.Forms.Button();
            this.btnKnight = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQueen
            // 
            this.btnQueen.BackColor = System.Drawing.Color.Gray;
            this.btnQueen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQueen.Location = new System.Drawing.Point(30, 38);
            this.btnQueen.Name = "btnQueen";
            this.btnQueen.Size = new System.Drawing.Size(100, 100);
            this.btnQueen.TabIndex = 0;
            this.btnQueen.UseVisualStyleBackColor = false;
            this.btnQueen.Click += new System.EventHandler(this.btnQueen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a chess you want to become:";
            // 
            // btnRook
            // 
            this.btnRook.BackColor = System.Drawing.Color.Gray;
            this.btnRook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRook.Location = new System.Drawing.Point(136, 38);
            this.btnRook.Name = "btnRook";
            this.btnRook.Size = new System.Drawing.Size(100, 100);
            this.btnRook.TabIndex = 2;
            this.btnRook.UseVisualStyleBackColor = false;
            this.btnRook.Click += new System.EventHandler(this.btnRook_Click);
            // 
            // btnBishop
            // 
            this.btnBishop.BackColor = System.Drawing.Color.Gray;
            this.btnBishop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBishop.Location = new System.Drawing.Point(30, 144);
            this.btnBishop.Name = "btnBishop";
            this.btnBishop.Size = new System.Drawing.Size(100, 100);
            this.btnBishop.TabIndex = 3;
            this.btnBishop.UseVisualStyleBackColor = false;
            this.btnBishop.Click += new System.EventHandler(this.btnBishop_Click);
            // 
            // btnKnight
            // 
            this.btnKnight.BackColor = System.Drawing.Color.Gray;
            this.btnKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKnight.Location = new System.Drawing.Point(136, 144);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(100, 100);
            this.btnKnight.TabIndex = 4;
            this.btnKnight.UseVisualStyleBackColor = false;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(187, 250);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChangeToChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 284);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnKnight);
            this.Controls.Add(this.btnBishop);
            this.Controls.Add(this.btnRook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQueen);
            this.Name = "ChangeToChess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeToChess";
            this.Load += new System.EventHandler(this.ChangeToChess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQueen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRook;
        private System.Windows.Forms.Button btnBishop;
        private System.Windows.Forms.Button btnKnight;
        private System.Windows.Forms.Button btnOK;
    }
}