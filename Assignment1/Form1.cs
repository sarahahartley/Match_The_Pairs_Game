/*
 * Assignment 1 - Amy Gourlay 170005068, Sarah Hartley 170009427
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Assignment1
{

        public partial class Form1 : Form
        { 
        Button[,] btn = new Button[4, 4];
        PictureBox[,] picBox = new PictureBox[4, 4];
        int[,] PairArray = new int[4, 4]; // 2D array storing the state of each button (clicked, unclicked and invisibe)
        int[,] ImageCompare = new int[4, 4]; // 2D array storing the locations of the images
        int movesCounter = 0;
        int matchesCounter = 0;
        int x = 0;
        int y = 0;
        int tempx = 0;
        int tempy = 0;
        private int timeCounter = 40; //Timer of 40 seconds
        Random rnd = new Random();
        bool timeTrial2;
        bool multi2;
        int P1MatchesCounter = 0;
        int P2MatchesCounter = 0;
        int turn = 1;
        

        //Default constructor
        public Form1()
        {
            this.Visible = false;
            ShowMenu();
        }


        //Time trial constructor
        public Form1(bool timeTrial, bool multi)
        {
            InitializeComponent();
            Init();
            Player1Lbl.Visible = false;
            Player2Lbl.Visible = false;
            P1CircleLbl.Visible = false;
            P2CircleLbl.Visible = false;
            if (timeTrial == true)
            {
                ShowTimer();
                timeTrial2 = timeTrial;
            }
            else if (multi == true)
            {
                multiplayer();
                multi2 = multi;
            }
        }


        //Method to initialise the grid for normal gameplay
        void Init()
        {
            int[] imageCount = new int[8]; //array to store how many times each image has been placed on the grid (0,1 or 2)
            string[] imageLoc = new string[8]; //array to store strings containing the path names to each image

            for (int i = 0; i < 8; i++)
            {
                imageCount[i] = 0;
            }
            
            //storing image pathnames in imageLoc array
            imageLoc[0] = @"Labels\apple.jpg";
            imageLoc[1] = @"Labels\basketball.jpg";
            imageLoc[2] = @"Labels\bee.jpg";
            imageLoc[3] = @"Labels\butterfly.jpg";
            imageLoc[4] = @"Labels\flower.jpg";
            imageLoc[5] = @"Labels\house.jpg";
            imageLoc[6] = @"Labels\moon.jpg";
            imageLoc[7] = @"Labels\shoe.jpg";


            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    PairArray[x, y] = 0; //initialising values of PairArray to 0
                }
            }

            //Places buttons on top of pictures
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].Name = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].SetBounds(100 * x, 100 * y, 70, 70);
                    btn[x, y].BackColor = Color.DarkGray;
                    btn[x, y].Location = new Point((y+1)*80, (x+1)*80);
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    Controls.Add(btn[x, y]);
                }
            }

            //Randomly places pictures on the grid
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    picBox[x, y] = new PictureBox();
                    picBox[x, y].SetBounds(100 * x, 100 * y, 70, 70);
                    picBox[x, y].Location = new Point((y + 1) * 80, (x + 1) * 80);
                    int random = rnd.Next(0, 8);

                    while (imageCount[random] == 2) //check if image has already been placed twice
                    {
                        random = rnd.Next(0, 8); //Generate new random number
                    }

                    if (imageCount[random] == 0) //Image is not on grid
                    {
                        imageCount[random] = 1;
                    }
                    else if (imageCount[random] == 1) //Image appears on grid once
                    {
                        imageCount[random] = 2;
                    }

                    ImageCompare[x, y] = random; //Storing what image has been added at this location
                    
                    picBox[x, y].Image = Image.FromFile(imageLoc[random]);
                    picBox[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(picBox[x, y]);
                }
            }
        }


        //Method to make to make the clicked button invisible, to show the image behind
        async void btnEvent_Click(object sender, EventArgs e)
        {
            
            SoundPlayer swoosh = new SoundPlayer(@"Blop.wav");
            swoosh.Play();
            ((Button)sender).Visible = false; //hide button
            String position = ((Button)sender).Name;
            bool check = false;           

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    if (PairArray[a, b] == 1) // Check if a button has already been clicked
                    {
                        check = true; 
                    }
                }
            }

            if (check == true) //if two pictures been clicked
            {
                movesCounter++;
                MovesUpdater();
                string[] location = position.Split(',');
                tempx = Int32.Parse(location[0])-1;
                tempy = Int32.Parse(location[1])-1;
                PairArray[tempx, tempy] = 1;
            }
            else //This is the first button to be clicked
            {
                string[] location = position.Split(',');
                x = Int32.Parse(location[0])-1;
                y = Int32.Parse(location[1])-1;
                PairArray[x, y] = 1;
            }

            if (check == true) //if two pictures have been clicked
            {
                if (ImageCompare[x, y] == ImageCompare[tempx, tempy]) //if pictures match
                {
                    matchesCounter++;
                    if (multi2 == true)
                    {
                        if (turn == 1)
                        {
                            P1MatchesCounter++;
                        }
                        else
                        {
                            P2MatchesCounter++;
                        }
                    }
                    MatchesUpdater();
                    PairArray[x, y] = 2; //set button state to 2
                    PairArray[tempx, tempy] = 2; //set button state to 2
                    GameState(); //Check if game is over
                }
                else //pictures don't match
                {
                    await Task.Delay(500); //wait half a second

                    PairArray[x, y] = 0; //update button states to unclicked
                    PairArray[tempx, tempy] = 0;

                    btn[x, y].Visible = true; //make buttons visible again
                    btn[tempx, tempy].Visible = true;
                }
            }

            if (multi2 == true)//if playing multiplayer
            {
                if (movesCounter % 2 == 0)
                {
                    turn = 1;
                    P1CircleLbl.Visible = true;
                    P2CircleLbl.Visible = false;
                }
                else
                {
                    turn = 2;
                    P1CircleLbl.Visible = false;
                    P2CircleLbl.Visible = true;
                }
            }
        }


        //Method to show the number of moves a player has made
        void MovesUpdater()
        {
            string count = Convert.ToString(movesCounter);
            MovesLbl.Text = count;
        }


        //Method to show how many matches a player has made
        void MatchesUpdater()
        {
            string count2 = Convert.ToString(matchesCounter);
            MatchLbl.Text = count2;
            if (multi2 == true)
            {
                if (turn == 1)
                {
                    string count3 = Convert.ToString(P1MatchesCounter);
                    P1Matches.Text = count3;
                }
                else
                {
                    string count3 = Convert.ToString(P2MatchesCounter);
                    P2Matches.Text = count3;
                }
            }
        }


        //Method to display success screen if player finds all pairs
        void GameState()
        {
            if (matchesCounter == 8) //If they have matched every pair
            {
                timer1.Stop();
                this.Visible = false; //hide form
                if (timeTrial2 == false && multi2 == false)
                {
                    Form2 score = new Form2(movesCounter);
                    score.ShowDialog(); //display success screen
                }
                else if (timeTrial2 == true)
                {
                    int time = Convert.ToInt32(timerLbl.Text);
                    time = 40 - time;
                    Form2 score = new Form2(time, timeTrial2);
                    score.ShowDialog(); //display success screen
                }
                else if (multi2 == true)
                {
                    Form7 newForm = new Form7(P1MatchesCounter, P2MatchesCounter);
                    newForm.ShowDialog();
                }

                this.Dispose(false);
            }
        }


        //Method to show the menu
        void ShowMenu()
        {
            this.Visible = false;
            Form3 menu = new Form3();
            menu.ShowDialog();
            this.Dispose(false);
        }


        //Method to close the game
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //Method to restart the game
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //code taken from https://stackoverflow.com/questions/15569641/reset-all-the-items-in-a-form
            timer1.Stop();
            if (timeTrial2 == false && multi2 == false)
            {
                Form1 NewForm = new Form1(false, false);
                NewForm.ShowDialog();
            }
            else if (timeTrial2 == true)
            {
                Form1 NewForm = new Form1(true, false);
                NewForm.ShowDialog();
            }
            else if (multi2 == true)
            {
                Form1 NewForm = new Form1(false, true);
                NewForm.ShowDialog();
            }
            this.Dispose(false);
        }


        //Method to display the timer for timetrial game
        void ShowTimer()
        {
            
            TimeTextLbl.Visible = true; //show timer on form
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            timerLbl.Text = timeCounter.ToString();
            //this.Dispose(false);
        }


        //Method to decrease the timer every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCounter--;
            if (timeCounter == 0) //If time has run out
            {
                timer1.Stop();
                this.Visible = false;
                Form5 NewForm = new Form5();
                NewForm.ShowDialog(); //Show failure screen
                this.Dispose(false);
            }
            timerLbl.Text = timeCounter.ToString();
        }

        void multiplayer()
        {
            Player1Lbl.Visible = true;
            Player2Lbl.Visible = true;
            P1CircleLbl.Visible = true;
            P2CircleLbl.Visible = false;
            MatchesTextLbl.Visible = false;
            MovesTextLbl.Visible = false;
            MovesLbl.Visible = false;
            MatchLbl.Visible = false;
            OutOfEightLbl.Visible = false;

            

        }


        //Method to reset the form to display the menu again
        private void MenuBtn1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            Form1 NewForm = new Form1();
            NewForm.ShowDialog();
            this.Dispose(false);
        }


        private void TitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void MatchLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MovesTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void MovesLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

