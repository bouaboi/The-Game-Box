namespace The_Game_Box
{
    partial class frmLunchGame2
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
            this.nmChooseRounds = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmChooseRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Many Rounds Do You Want To Play ?";
            // 
            // nmChooseRounds
            // 
            this.nmChooseRounds.Location = new System.Drawing.Point(332, 223);
            this.nmChooseRounds.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmChooseRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmChooseRounds.Name = "nmChooseRounds";
            this.nmChooseRounds.Size = new System.Drawing.Size(120, 20);
            this.nmChooseRounds.TabIndex = 1;
            this.nmChooseRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Silver;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(344, 282);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(97, 40);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmLunchGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.nmChooseRounds);
            this.Controls.Add(this.label1);
            this.Name = "frmLunchGame2";
            this.Text = "Rock-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.nmChooseRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmChooseRounds;
        private System.Windows.Forms.Button btnPlay;
    }
}