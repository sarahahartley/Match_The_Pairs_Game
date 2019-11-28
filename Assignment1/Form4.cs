using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//SCORE BOARD

namespace Assignment1
{
    public partial class Form4 : Form
    {
        //Constructor
        public Form4()
        {
            InitializeComponent();
            AddText();
        }

        
        //Read in results from text file and display them in the listView
        void AddText()
        {
            string[] lines = File.ReadAllLines(@"ScoreBoard.txt"); //store each line of text in an array called lines
            string[] str = new string[2];
            ScoreListView.Columns.Add("Score", 155, HorizontalAlignment.Left); //Create columns
            ScoreListView.Columns.Add("Name", 300, HorizontalAlignment.Left);
            
            for (int i = 0; i < lines.Length; i++) //For each line in the text file
            {
                str[0] = lines[i + 1];
                str[1] = lines[i];
                i++;
                ListViewItem itm = new ListViewItem(str); 
                ScoreListView.Items.Add(itm); //Add name and score to list
            }
        }


        //Method to close the program
        private void ScoreExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //Method to show the menu
        private void MenuBtn3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 NewForm = new Form1();
            NewForm.ShowDialog();
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 NewForm = new Form6();
            NewForm.ShowDialog();
            this.Dispose(false);
        }
    }
}
