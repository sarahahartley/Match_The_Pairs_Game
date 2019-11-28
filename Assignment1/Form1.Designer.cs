namespace Assignment1
{
    partial class Form1
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
            this.MovesLbl = new System.Windows.Forms.Label();
            this.MovesTextLbl = new System.Windows.Forms.Label();
            this.MatchesTextLbl = new System.Windows.Forms.Label();
            this.MatchLbl = new System.Windows.Forms.Label();
            this.OutOfEightLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLbl = new System.Windows.Forms.Label();
            this.TimeTextLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MenuBtn1 = new System.Windows.Forms.Button();
            this.Player1Lbl = new System.Windows.Forms.Label();
            this.Player2Lbl = new System.Windows.Forms.Label();
            this.P1CircleLbl = new System.Windows.Forms.Label();
            this.P2CircleLbl = new System.Windows.Forms.Label();
            this.P1Matches = new System.Windows.Forms.Label();
            this.P2Matches = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovesLbl
            // 
            this.MovesLbl.AutoSize = true;
            this.MovesLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold);
            this.MovesLbl.ForeColor = System.Drawing.Color.Azure;
            this.MovesLbl.Location = new System.Drawing.Point(569, 93);
            this.MovesLbl.Name = "MovesLbl";
            this.MovesLbl.Size = new System.Drawing.Size(0, 25);
            this.MovesLbl.TabIndex = 0;
            this.MovesLbl.Click += new System.EventHandler(this.MovesLbl_Click);
            // 
            // MovesTextLbl
            // 
            this.MovesTextLbl.AutoSize = true;
            this.MovesTextLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovesTextLbl.ForeColor = System.Drawing.Color.Azure;
            this.MovesTextLbl.Location = new System.Drawing.Point(450, 87);
            this.MovesTextLbl.Name = "MovesTextLbl";
            this.MovesTextLbl.Size = new System.Drawing.Size(81, 25);
            this.MovesTextLbl.TabIndex = 1;
            this.MovesTextLbl.Text = "Moves:";
            this.MovesTextLbl.Click += new System.EventHandler(this.MovesTextLbl_Click);
            // 
            // MatchesTextLbl
            // 
            this.MatchesTextLbl.AutoSize = true;
            this.MatchesTextLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchesTextLbl.ForeColor = System.Drawing.Color.Azure;
            this.MatchesTextLbl.Location = new System.Drawing.Point(430, 118);
            this.MatchesTextLbl.Name = "MatchesTextLbl";
            this.MatchesTextLbl.Size = new System.Drawing.Size(98, 25);
            this.MatchesTextLbl.TabIndex = 2;
            this.MatchesTextLbl.Text = "Matches:";
            // 
            // MatchLbl
            // 
            this.MatchLbl.AutoSize = true;
            this.MatchLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold);
            this.MatchLbl.ForeColor = System.Drawing.Color.Azure;
            this.MatchLbl.Location = new System.Drawing.Point(578, 118);
            this.MatchLbl.Name = "MatchLbl";
            this.MatchLbl.Size = new System.Drawing.Size(0, 25);
            this.MatchLbl.TabIndex = 3;
            this.MatchLbl.Click += new System.EventHandler(this.MatchLbl_Click);
            // 
            // OutOfEightLbl
            // 
            this.OutOfEightLbl.AutoSize = true;
            this.OutOfEightLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold);
            this.OutOfEightLbl.ForeColor = System.Drawing.Color.Azure;
            this.OutOfEightLbl.Location = new System.Drawing.Point(594, 118);
            this.OutOfEightLbl.Name = "OutOfEightLbl";
            this.OutOfEightLbl.Size = new System.Drawing.Size(36, 25);
            this.OutOfEightLbl.TabIndex = 4;
            this.OutOfEightLbl.Text = "/8";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ExitBtn.Location = new System.Drawing.Point(455, 379);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(145, 43);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ResetBtn.Location = new System.Drawing.Point(455, 314);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(145, 45);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.ForeColor = System.Drawing.Color.Azure;
            this.timerLbl.Location = new System.Drawing.Point(455, 203);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(0, 34);
            this.timerLbl.TabIndex = 7;
            // 
            // TimeTextLbl
            // 
            this.TimeTextLbl.AutoSize = true;
            this.TimeTextLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTextLbl.ForeColor = System.Drawing.Color.Azure;
            this.TimeTextLbl.Location = new System.Drawing.Point(431, 166);
            this.TimeTextLbl.Name = "TimeTextLbl";
            this.TimeTextLbl.Size = new System.Drawing.Size(143, 19);
            this.TimeTextLbl.TabIndex = 8;
            this.TimeTextLbl.Text = "Time Remaining:";
            this.TimeTextLbl.Visible = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleLbl.Location = new System.Drawing.Point(135, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(387, 43);
            this.TitleLbl.TabIndex = 9;
            this.TitleLbl.Text = "MATCH THE PAIRS";
            this.TitleLbl.Click += new System.EventHandler(this.TitleLbl_Click);
            // 
            // MenuBtn1
            // 
            this.MenuBtn1.BackColor = System.Drawing.Color.DarkGray;
            this.MenuBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MenuBtn1.Location = new System.Drawing.Point(455, 250);
            this.MenuBtn1.Name = "MenuBtn1";
            this.MenuBtn1.Size = new System.Drawing.Size(145, 45);
            this.MenuBtn1.TabIndex = 10;
            this.MenuBtn1.Text = "Menu";
            this.MenuBtn1.UseVisualStyleBackColor = false;
            this.MenuBtn1.Click += new System.EventHandler(this.MenuBtn1_Click);
            // 
            // Player1Lbl
            // 
            this.Player1Lbl.AutoSize = true;
            this.Player1Lbl.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Lbl.ForeColor = System.Drawing.Color.White;
            this.Player1Lbl.Location = new System.Drawing.Point(431, 89);
            this.Player1Lbl.Name = "Player1Lbl";
            this.Player1Lbl.Size = new System.Drawing.Size(110, 28);
            this.Player1Lbl.TabIndex = 11;
            this.Player1Lbl.Text = "Player 1:";
            // 
            // Player2Lbl
            // 
            this.Player2Lbl.AutoSize = true;
            this.Player2Lbl.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Lbl.ForeColor = System.Drawing.Color.White;
            this.Player2Lbl.Location = new System.Drawing.Point(431, 143);
            this.Player2Lbl.Name = "Player2Lbl";
            this.Player2Lbl.Size = new System.Drawing.Size(112, 28);
            this.Player2Lbl.TabIndex = 12;
            this.Player2Lbl.Text = "Player 2:";
            // 
            // P1CircleLbl
            // 
            this.P1CircleLbl.AutoSize = true;
            this.P1CircleLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1CircleLbl.ForeColor = System.Drawing.Color.White;
            this.P1CircleLbl.Location = new System.Drawing.Point(414, 89);
            this.P1CircleLbl.Name = "P1CircleLbl";
            this.P1CircleLbl.Size = new System.Drawing.Size(21, 23);
            this.P1CircleLbl.TabIndex = 13;
            this.P1CircleLbl.Text = "o";
            // 
            // P2CircleLbl
            // 
            this.P2CircleLbl.AutoSize = true;
            this.P2CircleLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2CircleLbl.ForeColor = System.Drawing.Color.White;
            this.P2CircleLbl.Location = new System.Drawing.Point(414, 143);
            this.P2CircleLbl.Name = "P2CircleLbl";
            this.P2CircleLbl.Size = new System.Drawing.Size(21, 23);
            this.P2CircleLbl.TabIndex = 14;
            this.P2CircleLbl.Text = "o";
            // 
            // P1Matches
            // 
            this.P1Matches.AutoSize = true;
            this.P1Matches.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Matches.ForeColor = System.Drawing.Color.White;
            this.P1Matches.Location = new System.Drawing.Point(575, 93);
            this.P1Matches.Name = "P1Matches";
            this.P1Matches.Size = new System.Drawing.Size(0, 23);
            this.P1Matches.TabIndex = 15;
            // 
            // P2Matches
            // 
            this.P2Matches.AutoSize = true;
            this.P2Matches.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Matches.ForeColor = System.Drawing.Color.White;
            this.P2Matches.Location = new System.Drawing.Point(574, 147);
            this.P2Matches.Name = "P2Matches";
            this.P2Matches.Size = new System.Drawing.Size(0, 23);
            this.P2Matches.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(325, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.P2Matches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P1Matches);
            this.Controls.Add(this.P2CircleLbl);
            this.Controls.Add(this.P1CircleLbl);
            this.Controls.Add(this.Player2Lbl);
            this.Controls.Add(this.Player1Lbl);
            this.Controls.Add(this.MenuBtn1);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.TimeTextLbl);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OutOfEightLbl);
            this.Controls.Add(this.MatchLbl);
            this.Controls.Add(this.MatchesTextLbl);
            this.Controls.Add(this.MovesTextLbl);
            this.Controls.Add(this.MovesLbl);
            this.Name = "Form1";
            this.Text = "Match The Pairs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovesLbl;
        private System.Windows.Forms.Label MovesTextLbl;
        private System.Windows.Forms.Label MatchesTextLbl;
        private System.Windows.Forms.Label MatchLbl;
        private System.Windows.Forms.Label OutOfEightLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label TimeTextLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button MenuBtn1;
        private System.Windows.Forms.Label Player1Lbl;
        private System.Windows.Forms.Label Player2Lbl;
        private System.Windows.Forms.Label P1CircleLbl;
        private System.Windows.Forms.Label P2CircleLbl;
        private System.Windows.Forms.Label P1Matches;
        private System.Windows.Forms.Label P2Matches;
        private System.Windows.Forms.Label label3;
    }
}

