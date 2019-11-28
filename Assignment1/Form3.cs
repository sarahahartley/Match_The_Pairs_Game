using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//MENU

namespace Assignment1
{
    public partial class Form3 : Form
    {

        //Constructor
        public Form3()
        {
            InitializeComponent();
        }

     
        //Method to close the menu
        private void PlayGameBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form1 newForm = new Form1(false, false);
            newForm.ShowDialog();
            this.Dispose(false);
        }


        //Method to run the time trial game
        private void TimeTrialBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 timeTrial = new Form1(true, false); //Call second constructor in form1
            timeTrial.ShowDialog();
            this.Dispose(false);
        }


        //Method to display the scoreboard
        private void ScoreBoardBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 scoreboard = new Form4();
            scoreboard.ShowDialog();
            this.Dispose(false);
        }


        //Method to close the program
        private void Exit3Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //Method to run the multiplayer version of the game
        private void MultiBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 multi = new Form1(false, true); //Call second constructor in form1
            multi.ShowDialog();
            this.Dispose(false);
        }

        //Method to open the rules page
        private void RulesBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 newForm = new Form8(); //Call second constructor in form1
            newForm.ShowDialog();
            this.Dispose(false);
        }
    }
}
