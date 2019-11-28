namespace Assignment1
{
    partial class Form5
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
            this.LoseLbl = new System.Windows.Forms.Label();
            this.LoserTextLbl = new System.Windows.Forms.Label();
            this.LoseExitBtn = new System.Windows.Forms.Button();
            this.MenuBtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoseLbl
            // 
            this.LoseLbl.AutoSize = true;
            this.LoseLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseLbl.ForeColor = System.Drawing.Color.White;
            this.LoseLbl.Location = new System.Drawing.Point(38, 29);
            this.LoseLbl.Name = "LoseLbl";
            this.LoseLbl.Size = new System.Drawing.Size(508, 113);
            this.LoseLbl.TabIndex = 0;
            this.LoseLbl.Text = "Time\'s Up!";
            // 
            // LoserTextLbl
            // 
            this.LoserTextLbl.AutoSize = true;
            this.LoserTextLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoserTextLbl.ForeColor = System.Drawing.Color.White;
            this.LoserTextLbl.Location = new System.Drawing.Point(50, 174);
            this.LoserTextLbl.Name = "LoserTextLbl";
            this.LoserTextLbl.Size = new System.Drawing.Size(308, 38);
            this.LoserTextLbl.TabIndex = 1;
            this.LoserTextLbl.Text = "Better luck next time.";
            // 
            // LoseExitBtn
            // 
            this.LoseExitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.LoseExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoseExitBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseExitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LoseExitBtn.Location = new System.Drawing.Point(445, 315);
            this.LoseExitBtn.Name = "LoseExitBtn";
            this.LoseExitBtn.Size = new System.Drawing.Size(118, 45);
            this.LoseExitBtn.TabIndex = 2;
            this.LoseExitBtn.Text = "Exit";
            this.LoseExitBtn.UseVisualStyleBackColor = false;
            this.LoseExitBtn.Click += new System.EventHandler(this.LoseExitBtn_Click);
            // 
            // MenuBtn4
            // 
            this.MenuBtn4.BackColor = System.Drawing.Color.DarkGray;
            this.MenuBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn4.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MenuBtn4.Location = new System.Drawing.Point(291, 315);
            this.MenuBtn4.Name = "MenuBtn4";
            this.MenuBtn4.Size = new System.Drawing.Size(118, 45);
            this.MenuBtn4.TabIndex = 3;
            this.MenuBtn4.Text = "Menu";
            this.MenuBtn4.UseVisualStyleBackColor = false;
            this.MenuBtn4.Click += new System.EventHandler(this.MenuBtn4_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(591, 386);
            this.Controls.Add(this.MenuBtn4);
            this.Controls.Add(this.LoseExitBtn);
            this.Controls.Add(this.LoserTextLbl);
            this.Controls.Add(this.LoseLbl);
            this.Name = "Form5";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoseLbl;
        private System.Windows.Forms.Label LoserTextLbl;
        private System.Windows.Forms.Button LoseExitBtn;
        private System.Windows.Forms.Button MenuBtn4;
    }
}