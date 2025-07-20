namespace The_Game_Box
{
    partial class frmGameResults
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
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnlNewGame = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRounds
            // 
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.Black;
            this.lblRounds.Location = new System.Drawing.Point(50, 50);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(250, 30);
            this.lblRounds.TabIndex = 0;
            this.lblRounds.Text = "Total Rounds: 0";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerWins.Location = new System.Drawing.Point(50, 90);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(250, 30);
            this.lblPlayerWins.TabIndex = 1;
            this.lblPlayerWins.Text = "Player Wins: 0";
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.ForeColor = System.Drawing.Color.Black;
            this.lblComputerWins.Location = new System.Drawing.Point(50, 130);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(250, 30);
            this.lblComputerWins.TabIndex = 2;
            this.lblComputerWins.Text = "Computer Wins: 0";
            // 
            // lblDraws
            // 
            this.lblDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraws.ForeColor = System.Drawing.Color.Black;
            this.lblDraws.Location = new System.Drawing.Point(50, 170);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(250, 30);
            this.lblDraws.TabIndex = 3;
            this.lblDraws.Text = "Draws: 0";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Black;
            this.lblWinner.Location = new System.Drawing.Point(50, 210);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(212, 24);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "Overall Winner: None";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(372, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnlNewGame
            // 
            this.btnlNewGame.BackColor = System.Drawing.Color.Silver;
            this.btnlNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlNewGame.Location = new System.Drawing.Point(271, 304);
            this.btnlNewGame.Name = "btnlNewGame";
            this.btnlNewGame.Size = new System.Drawing.Size(100, 40);
            this.btnlNewGame.TabIndex = 5;
            this.btnlNewGame.Text = "New Game";
            this.btnlNewGame.UseVisualStyleBackColor = false;
            this.btnlNewGame.Click += new System.EventHandler(this.btnlNewGame_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Silver;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Location = new System.Drawing.Point(473, 304);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 40);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmGameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlNewGame);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblRounds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGameResults";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnlNewGame;
        private System.Windows.Forms.Button btnMainMenu;
    }
}