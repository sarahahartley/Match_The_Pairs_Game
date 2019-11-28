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

//FAILURE SCREEN

namespace Assignment1
{
    public partial class Form5 : Form
    {

        //Constructor
        public Form5()
        {
            InitializeComponent();
            SoundPlayer failure = new SoundPlayer(@"Fail.wav");
            failure.Play();

        }


        //Method to close the program
        private void LoseExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //Method to display the menu
        private void MenuBtn4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 NewForm = new Form1();
            NewForm.ShowDialog();
            this.Dispose(false);
        }
    }
}
