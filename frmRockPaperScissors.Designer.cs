namespace The_Game_Box
{
    partial class frmRockPaperScissors
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Image = global::The_Game_Box.Properties.Resources.paper1;
            this.button4.Location = new System.Drawing.Point(515, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 94);
            this.button4.TabIndex = 1;
            this.button4.Tag = "paper";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Image = global::The_Game_Box.Properties.Resources.Scissors3;
            this.button3.Location = new System.Drawing.Point(343, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 94);
            this.button3.TabIndex = 1;
            this.button3.Tag = "scissors";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.Color.Teal;
            this.btn2.Image = global::The_Game_Box.Properties.Resources.QSM;
            this.btn2.Location = new System.Drawing.Point(439, 110);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(111, 91);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "rock";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Image = global::The_Game_Box.Properties.Resources.QSM;
            this.button2.Location = new System.Drawing.Point(259, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 94);
            this.button2.TabIndex = 1;
            this.button2.Tag = "rock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Image = global::The_Game_Box.Properties.Resources.rock1;
            this.button1.Location = new System.Drawing.Point(158, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 94);
            this.button1.TabIndex = 1;
            this.button1.Tag = "rock";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 24);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 46);
            this.lblResult.TabIndex = 2;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock-Paper-Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblResult;
    }
}