using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//SUCCESS PAGE

namespace Assignment1
{
    public partial class Form2 : Form
    {
        string result;
        bool timeTrial2;

        /*
         * Constructor
         * 
         * Parameters:
         * score - an int containing the number of moves it took to match every pair
         */
        public Form2(int score)
        {
            InitializeComponent();
            SoundPlayer success = new SoundPlayer(@"TaDa.wav");
            success.Play();
            result = Convert.ToString(score); 
            SuccessScoreLbl.Text = result; //display score
        }

        public Form2(int time, bool timeTrial)
        {
            InitializeComponent();
            SoundPlayer success = new SoundPlayer(@"TaDa.wav");
            success.Play();
            result = Convert.ToString(time);
            SuccessScoreLbl.Text = result; //display score
            timeTrial2 = timeTrial;
        }


        //Method to close the program
        private void Exit2Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //Method to get the name of the user
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if (EnterNameTxtBox.Text == "")
            {
                MessageBox.Show("Please Enter a name for the scoreboard");
            }
            else
            {
                string name = EnterNameTxtBox.Text;
                if (timeTrial2 == false)
                {
                    SaveToFile(name);
                }
                else
                {
                    TTSaveToFile(name);
                }
            }
        }

        bool TTcheck(bool timeTrial)
        {
            if (timeTrial == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*
         * Method to save the users name and score to a text file
         * 
         * Parameters:
         * name - a string containing the name of the user 
         */
        private void SaveToFile(string name)
        {
            string[] lines = {name, result};
            File.AppendAllLines(@"ScoreBoard.txt", lines); //append lines to the end of the text file
            this.Visible = false;
            Form4 scoreboard = new Form4();
            scoreboard.ShowDialog(); //Show the score board
            this.Dispose(false);
        }

        //Method to save name and score to a text file
        private void TTSaveToFile(string name)
        {
            string[] lines = { name, result };
            File.AppendAllLines(@"TTScoreBoard.txt", lines); //append lines to the end of the text file
            this.Visible = false;
            Form6 scoreboard = new Form6();
            scoreboard.ShowDialog(); //Show the score board
            this.Dispose(false);
        }

        
        //Method to display the scoreboard
        private void ShowScoreBoardBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 scoreboard = new Form4();
            scoreboard.ShowDialog();
            this.Dispose(false);
        }


        //Method to display the menu again
        private void MenuBtn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 NewForm = new Form1();
            NewForm.ShowDialog();
            this.Dispose(false);
        }


        private void EnterNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
