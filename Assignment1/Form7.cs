using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//MULTIPLAYER GAME OVER 

namespace Assignment1
{
    public partial class Form7 : Form
    {

        string resultP1;
        string resultP2;


        //Constructor
        public Form7(int P1Matches, int P2Matches)
        {
            InitializeComponent();
            SoundPlayer success = new SoundPlayer(@"TaDa.wav");
            success.Play();
            if (P1Matches > P2Matches) //if player 1 has a higher score
            {
                P2WinsLbl.Visible = false;
                DrawLbl.Visible = false;
                P1WinsLbl.Visible = true;
            }
            else if (P1Matches < P2Matches) //if player 2 has a higher score
            {
                P2WinsLbl.Visible = true;
                DrawLbl.Visible = false;
                P1WinsLbl.Visible = false;
            }
            else //if its a draw
            {
                P2WinsLbl.Visible = false;
                DrawLbl.Visible = true;
                P1WinsLbl.Visible = false;
            }
            resultP1 = Convert.ToString(P1Matches);
            resultP2 = Convert.ToString(P2Matches);
            P1Score.Text = resultP1; //display score
            P2Score.Text = resultP2;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void P1WinsLbl_Click(object sender, EventArgs e)
        {

        }

        private void DrawLbl_Click(object sender, EventArgs e)
        {

        }

        //Method to return to the menu
        private void MenuBtn3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 NewForm = new Form1();
            NewForm.ShowDialog();
            this.Dispose(false);
        }

        //Method to exit the game
        private void ScoreExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
