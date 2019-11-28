namespace Assignment1
{
    partial class Form6
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
            this.MenuBtn3 = new System.Windows.Forms.Button();
            this.ScoreExitBtn = new System.Windows.Forms.Button();
            this.ScoreBoardTextLbl = new System.Windows.Forms.Label();
            this.ScoreListView = new System.Windows.Forms.ListView();
            this.TTScoreBoardLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuBtn3
            // 
            this.MenuBtn3.BackColor = System.Drawing.Color.DarkGray;
            this.MenuBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn3.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MenuBtn3.Location = new System.Drawing.Point(349, 396);
            this.MenuBtn3.Name = "MenuBtn3";
            this.MenuBtn3.Size = new System.Drawing.Size(130, 42);
            this.MenuBtn3.TabIndex = 8;
            this.MenuBtn3.Text = "Menu";
            this.MenuBtn3.UseVisualStyleBackColor = false;
            this.MenuBtn3.Click += new System.EventHandler(this.MenuBtn3_Click);
            // 
            // ScoreExitBtn
            // 
            this.ScoreExitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ScoreExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreExitBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreExitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ScoreExitBtn.Location = new System.Drawing.Point(508, 396);
            this.ScoreExitBtn.Name = "ScoreExitBtn";
            this.ScoreExitBtn.Size = new System.Drawing.Size(130, 42);
            this.ScoreExitBtn.TabIndex = 7;
            this.ScoreExitBtn.Text = "Exit";
            this.ScoreExitBtn.UseVisualStyleBackColor = false;
            this.ScoreExitBtn.Click += new System.EventHandler(this.ScoreExitBtn_Click);
            // 
            // ScoreBoardTextLbl
            // 
            this.ScoreBoardTextLbl.AutoSize = true;
            this.ScoreBoardTextLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBoardTextLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreBoardTextLbl.Location = new System.Drawing.Point(68, 9);
            this.ScoreBoardTextLbl.Name = "ScoreBoardTextLbl";
            this.ScoreBoardTextLbl.Size = new System.Drawing.Size(528, 75);
            this.ScoreBoardTextLbl.TabIndex = 6;
            this.ScoreBoardTextLbl.Text = "SCORE BOARD";
            // 
            // ScoreListView
            // 
            this.ScoreListView.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreListView.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ScoreListView.Location = new System.Drawing.Point(96, 114);
            this.ScoreListView.Name = "ScoreListView";
            this.ScoreListView.Size = new System.Drawing.Size(460, 263);
            this.ScoreListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ScoreListView.TabIndex = 5;
            this.ScoreListView.UseCompatibleStateImageBehavior = false;
            this.ScoreListView.View = System.Windows.Forms.View.Details;
            // 
            // TTScoreBoardLbl
            // 
            this.TTScoreBoardLbl.AutoSize = true;
            this.TTScoreBoardLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTScoreBoardLbl.ForeColor = System.Drawing.Color.White;
            this.TTScoreBoardLbl.Location = new System.Drawing.Point(269, 84);
            this.TTScoreBoardLbl.Name = "TTScoreBoardLbl";
            this.TTScoreBoardLbl.Size = new System.Drawing.Size(100, 23);
            this.TTScoreBoardLbl.TabIndex = 9;
            this.TTScoreBoardLbl.Text = "Time Trial";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.TTScoreBoardLbl);
            this.Controls.Add(this.MenuBtn3);
            this.Controls.Add(this.ScoreExitBtn);
            this.Controls.Add(this.ScoreBoardTextLbl);
            this.Controls.Add(this.ScoreListView);
            this.Name = "Form6";
            this.Text = "Score Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuBtn3;
        private System.Windows.Forms.Button ScoreExitBtn;
        private System.Windows.Forms.Label ScoreBoardTextLbl;
        private System.Windows.Forms.ListView ScoreListView;
        private System.Windows.Forms.Label TTScoreBoardLbl;
    }
}