namespace Assignment1
{
    partial class Form8
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
            this.DrawLbl = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NormalGameTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrawLbl
            // 
            this.DrawLbl.AutoSize = true;
            this.DrawLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawLbl.ForeColor = System.Drawing.Color.White;
            this.DrawLbl.Location = new System.Drawing.Point(48, 9);
            this.DrawLbl.Name = "DrawLbl";
            this.DrawLbl.Size = new System.Drawing.Size(520, 75);
            this.DrawLbl.TabIndex = 4;
            this.DrawLbl.Text = "HOW TO PLAY";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.DarkGray;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MenuBtn.Location = new System.Drawing.Point(295, 306);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(143, 46);
            this.MenuBtn.TabIndex = 16;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ExitBtn.Location = new System.Drawing.Point(477, 306);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(143, 46);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NormalGameTxt
            // 
            this.NormalGameTxt.BackColor = System.Drawing.Color.Teal;
            this.NormalGameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NormalGameTxt.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalGameTxt.ForeColor = System.Drawing.Color.White;
            this.NormalGameTxt.Location = new System.Drawing.Point(61, 87);
            this.NormalGameTxt.Multiline = true;
            this.NormalGameTxt.Name = "NormalGameTxt";
            this.NormalGameTxt.Size = new System.Drawing.Size(518, 58);
            this.NormalGameTxt.TabIndex = 17;
            this.NormalGameTxt.Text = "Normal Game: Click the cards until you find a pair. Continue until there are no c" +
    "ards left unturned";
            this.NormalGameTxt.TextChanged += new System.EventHandler(this.NormalGameTxt_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(61, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 58);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Time Trial: The same as a normal game, but you\'ve only got 40 seconds!";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(61, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(518, 81);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Multiplayer: Two players take turns. A circle will appear next to your name on yo" +
    "ur turn. Match as many pairs as you can before your opponent.";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NormalGameTxt);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DrawLbl);
            this.Name = "Form8";
            this.Text = "HOW TO PLAY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DrawLbl;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox NormalGameTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}