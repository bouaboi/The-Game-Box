namespace The_Game_Box
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRSP = new System.Windows.Forms.Button();
            this.btnRandomGame = new System.Windows.Forms.Button();
            this.btnTicTacToe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "[ The Game Box ]";
            // 
            // btnRSP
            // 
            this.btnRSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSP.ForeColor = System.Drawing.Color.Teal;
            this.btnRSP.Image = global::The_Game_Box.Properties.Resources.rps;
            this.btnRSP.Location = new System.Drawing.Point(525, 268);
            this.btnRSP.Name = "btnRSP";
            this.btnRSP.Size = new System.Drawing.Size(141, 140);
            this.btnRSP.TabIndex = 1;
            this.btnRSP.UseVisualStyleBackColor = true;
            this.btnRSP.Click += new System.EventHandler(this.btnRSP_Click);
            // 
            // btnRandomGame
            // 
            this.btnRandomGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandomGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomGame.ForeColor = System.Drawing.Color.Teal;
            this.btnRandomGame.Image = global::The_Game_Box.Properties.Resources.randomgame;
            this.btnRandomGame.Location = new System.Drawing.Point(334, 268);
            this.btnRandomGame.Name = "btnRandomGame";
            this.btnRandomGame.Size = new System.Drawing.Size(141, 140);
            this.btnRandomGame.TabIndex = 1;
            this.btnRandomGame.UseVisualStyleBackColor = true;
            this.btnRandomGame.Click += new System.EventHandler(this.btnRandomGame_Click);
            // 
            // btnTicTacToe
            // 
            this.btnTicTacToe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicTacToe.ForeColor = System.Drawing.Color.Teal;
            this.btnTicTacToe.Image = global::The_Game_Box.Properties.Resources.ttt1;
            this.btnTicTacToe.Location = new System.Drawing.Point(143, 268);
            this.btnTicTacToe.Name = "btnTicTacToe";
            this.btnTicTacToe.Size = new System.Drawing.Size(141, 140);
            this.btnTicTacToe.TabIndex = 1;
            this.btnTicTacToe.UseVisualStyleBackColor = true;
            this.btnTicTacToe.Click += new System.EventHandler(this.btnTicTacToe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "What Do You Want To Play?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRSP);
            this.Controls.Add(this.btnRandomGame);
            this.Controls.Add(this.btnTicTacToe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTicTacToe;
        private System.Windows.Forms.Button btnRSP;
        private System.Windows.Forms.Button btnRandomGame;
        private System.Windows.Forms.Label label2;
    }
}