using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//HOW TO PLAY

namespace Assignment1
{
    public partial class Form8 : Form
    {

        //Constructor
        public Form8()
        {
            InitializeComponent();
        }

        //Method to get back to menu
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 NewForm = new Form1();
            NewForm.ShowDialog();
            this.Dispose(false);
        }

        //Method to exit game
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NormalGameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiplayerLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
