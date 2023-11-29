using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// allow program to use files

namespace COMS_176_Final_Program_Project
{
    public partial class frmQuizzHome : Form
    {
    
        public frmQuizzHome()
        {
            InitializeComponent();

            // call method to count questions and display to screen
            CountFileLine();
        }

        private void btnEditQuizz_Click(object sender, EventArgs e)
        {
            // load list box with items from file QuizzQuestions.txt

            // call method
            LoadListBox();

            // clear text box in the groupBox
            ClearTextBox();

            // set groupBox to visible
            gbCustomizeQuizz.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // set groupBox to invzisible
            gbCustomizeQuizz.Visible = false;

            // count file
            CountFileLine();
        }

        private void frmQuizzHome_Load(object sender, EventArgs e)
        {
            
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

            // exception handler
            try
            {
                // select item from list both lists simultaniously 
                lstEditQuestions.SelectedIndex = lstQuestions.SelectedIndex;

                if (lstEditQuestions.SelectedIndex > -1)
                { // if statement for error handling
                
                    // get question from list assign to string data type
                    string strQuestion = lstEditQuestions.SelectedItem.ToString();

                    // when item selected display contentes of text file // display only the question
                    txtQuestion.Text = strQuestion.Substring(0, strQuestion.IndexOf(","));

                    // get Answere from list seperated by ","  assign to string data type
                    string strAnswere = strQuestion.Substring(strQuestion.IndexOf(","));                   
                    strAnswere = strAnswere.Substring(1, strAnswere.IndexOf(";"));
                    // display Answere between "," and ";"
                    txtAnswere.Text = strAnswere.Substring(0, strAnswere.IndexOf(";"));

                    // get Wrong answere1 from list seperated by ";"  assign to string data type
                    string strWrong1 = strQuestion.Substring(strQuestion.IndexOf(";"));                   
                    strWrong1 = strWrong1.Substring(1, strWrong1.IndexOf("/"));
                    //Display wrong answere between ";" and "/"
                    txtWrong1.Text = strWrong1.Substring(0, strWrong1.IndexOf("/"));

                    // get Wrong answere2 from list seperated by "/" assign to string data type
                    string strWrong2 = strQuestion.Substring(strQuestion.IndexOf("/"));
                    strWrong2 = strWrong2.Substring(1, strWrong2.IndexOf(":"));
                    //Display wrong answere between ";" and "/"
                    txtWrong2.Text = strWrong2.Substring(0, strWrong2.IndexOf(":"));

                    // get Wrong answere3 from list seperated by ":" assign to string data type
                    string strWrong3 = strQuestion.Substring(strQuestion.IndexOf(":"));
                    txtWrong3.Text = strWrong3.Substring(1);

                }
            }

            catch (Exception ex)
            {
                // Display an Error message.
                MessageBox.Show(ex.Message);
            }

        }


        private void lstEditQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // call function to clear textBoxes
            ClearTextBox();

            // If item slected delete selcted item
            if (lstQuestions.SelectedIndex > -1)
            {
                
                // remove items from list boxes            
                lstEditQuestions.Items.Remove(lstEditQuestions.Items[lstEditQuestions.SelectedIndex]); // must remove first
                lstQuestions.Items.Remove(lstQuestions.Items[lstQuestions.SelectedIndex]);

                //call method
                Update_Delete_Questions_Answers();

                // call method
                LoadListBox();

                // unselect list boxes
                lstEditQuestions.SelectedIndex = -1;
                lstQuestions.SelectedIndex = -1;
            }
       
        }

        private void gbCustomizeQuizz_Enter(object sender, EventArgs e)
        {

        }

        //********************Methods**************************************

        // method to count questions in the file
        private void CountFileLine()
        {
            try
            {
                // inputfile holds the file
                StreamReader inputfile;
                // open file
                inputfile = File.OpenText("QuizzQuestions.txt");
                // count lines in file
                int lineCount = File.ReadLines("QuizzQuestions.txt").Count();
                // close file
                inputfile.Close();
                // Display count to lblQuestions label
                lblQuestionCount.Text = lineCount.ToString();
            }

            // catch error
            catch (Exception ex)
            {                       // display default error 
                MessageBox.Show(ex.ToString());
            }
        }// end method


        // method to load list box 
        private void LoadListBox()
        {
            try
            {
                string questions = ""; // test

                int index = 0;
                StreamReader inputfile; // inputfile holds the file

                // Clear list box
                lstQuestions.Items.Clear();
                lstEditQuestions.Items.Clear();

                // open file
                inputfile = File.OpenText("QuizzQuestions.txt");

                // loop through file
                while (!inputfile.EndOfStream)
                {
                    // read file one line at a time

                    // assign item from list to varible// test
                    questions = inputfile.ReadLine();
                    lstEditQuestions.Items.Add(questions);

                    // count items
                    index++;

                    // Display contents of file to list box
                    lstQuestions.Items.Add("Question(" + index + ")");

                }// end while

                // close file
                inputfile.Close();
            }
            // catch error
            catch (Exception ex)
            {                       // display default error 
                MessageBox.Show(ex.ToString());
            }

        }// end method


        // Method to Delete Questions/Answeres

        private void Update_Delete_Questions_Answers()
        {
            try
            {       

                StreamWriter outputFile;
                outputFile = File.CreateText("QuizzQuestions.txt");

                // loop through list add to file
                foreach (var item in lstEditQuestions.Items)
                {
                    outputFile.WriteLine(item);
                }

                // close file
                outputFile.Close();

            }
            catch (Exception ex)
            {
                // Display an Error message.
                MessageBox.Show(ex.Message);
            }

        }// end method

        // method to clear text box
        private void ClearTextBox()
        {
            // clear text boxes from groupBox
            txtQuestion.Clear();
            txtAnswere.Clear();
            txtWrong1.Clear();
            txtWrong2.Clear();
            txtWrong3.Clear();
        }// end method

        // method to append to file

        private void Append(string text)
        {
            try
            {
                StreamWriter outputFile;
                // open file for appending
                outputFile = File.AppendText("QuizzQuestions.txt");
                // append to file
                outputFile.WriteLine(text);
                // close file
                outputFile.Close();
            }
            // catch error
            catch (Exception ex)
            {                       // display default error 
                MessageBox.Show(ex.ToString());
            }

        }// end method

        // method to disable text box in group box
        private void DisableTextBox()
        {
            txtQuestion.Enabled = false;
            txtAnswere.Enabled = false;
            txtWrong1.Enabled = false;
            txtWrong2.Enabled = false;
            txtWrong3.Enabled = false;
        }// end method
        
    // Method to enable text box in group box
    private void EnableTextBox()
        {
            txtQuestion.Enabled = true;
            txtAnswere.Enabled = true;
            txtWrong1.Enabled = true;
            txtWrong2.Enabled = true;
            txtWrong3.Enabled = true;
        }

        // method to check if "," ";" "/" ":" are being used
        public bool CheckTexBox()
        {
            // set check to true
            //bool check = true;

            // check if characters are in the text box
            if (txtQuestion.Text.Contains(",") ||
                txtQuestion.Text.Contains(";") ||
                txtQuestion.Text.Contains("/") ||
                txtQuestion.Text.Contains(":") ||
                txtAnswere.Text.Contains(",") ||
                txtAnswere.Text.Contains(";") ||
                txtAnswere.Text.Contains("/") ||
                txtAnswere.Text.Contains(":") ||
                txtWrong1.Text.Contains(",") ||
                txtWrong1.Text.Contains(";") ||
                txtWrong1.Text.Contains("/") ||
                txtWrong1.Text.Contains(":") ||
                txtWrong2.Text.Contains(",") ||
                txtWrong2.Text.Contains(";") ||
                txtWrong2.Text.Contains("/") ||
                txtWrong2.Text.Contains(":") ||
                txtWrong3.Text.Contains(",") ||
                txtWrong3.Text.Contains(";") ||
                txtWrong3.Text.Contains("/") ||
                txtWrong3.Text.Contains(":"))
            {
                // set check to false
                return false;
            }
            else
            {
                // return check
                return true;
            }
            
        }// end method

        //*****************************************************************************************************

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // clear text boxes
            ClearTextBox();

            // make Group box with add button visible
            gbAddUpdate.Visible = true;

            // make second add button visible
            btnAdd2.Visible = true;

            // enable text box in goup box
            EnableTextBox();
         
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // check if all text boxes are filled
            if (txtAnswere.Text.Length == 0 || txtQuestion.Text.Length == 0
                || txtWrong1.Text.Length == 0 || txtWrong2.Text.Length == 0
                || txtWrong3.Text.Length == 0)
            {
                MessageBox.Show("Pease fill in all boxes.");
            }

            // call CheckTexBox method    
            else if (CheckTexBox() == false)
            {
                // display message to user
                MessageBox.Show("Quesions and answers cannot caontain these characters( ,  ;   /  : )");
             
            }
          
            else
            {
                // format Questions and Answere assin to local variable
                string strQuestAnswer = txtQuestion.Text + "," + txtAnswere.Text + 
                    ";" + txtWrong1.Text + "/" + txtWrong2.Text + ":" + txtWrong3.Text;

                // Append strQuestionAnswer to file
                Append(strQuestAnswer);
               
                // clear text boxes
                ClearTextBox();

                // set focus
                txtQuestion.Focus();

                // load list box
                LoadListBox();
            }
        }

        private void gbAddButton_Enter(object sender, EventArgs e)
        {

        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            // make group box invisible
            gbAddUpdate.Visible = false;

            // clear text box
            ClearTextBox();

            // disable text boxs
            DisableTextBox();

            // set second add button to invisble
            btnAdd2.Visible = false;

            // set update button to invislbe
            btnUpdate.Visible = false;

            // unselect list boxes
            lstEditQuestions.SelectedIndex = -1;
            lstQuestions.SelectedIndex = -1;



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if item from list box is selected
            if (lstEditQuestions.SelectedIndex > -1)
            {
                // check if all text boxes are filled
                if (txtAnswere.Text.Length == 0 || txtQuestion.Text.Length == 0
                    || txtWrong1.Text.Length == 0 || txtWrong2.Text.Length == 0
                    || txtWrong3.Text.Length == 0)
                {
                    MessageBox.Show("Pease fill in all boxes.");
                }// end if

                // call CheckTexBox method    
                else if (CheckTexBox() == false)
                {
                    // display message to user
                    MessageBox.Show("Quesions and answers cannot caontain these characters( ,  ;   /  : )");
                  
                }

                else
                {// set variable to selected index
                    int index = lstEditQuestions.SelectedIndex;
                    // set local variable 
                    string strQuestAnswer = txtQuestion.Text + "," + txtAnswere.Text + ";" +
                        txtWrong1.Text + "/" + txtWrong2.Text + ":" + txtWrong3.Text;

                    // remove item
                    lstEditQuestions.Items.RemoveAt(index);
                    // insert new item
                    lstEditQuestions.Items.Insert(index, strQuestAnswer);

                    // update listbox
                    Update_Delete_Questions_Answers();

                    // load listbox
                    LoadListBox();

                    // clear text box
                    ClearTextBox();

                    // disable text box
                    DisableTextBox();

                    // make groupbox invisible
                    gbAddUpdate.Visible = false;

                    // make update button invisible
                    btnUpdate.Visible = false;

                }//end else

            }
            else
            {
                // tell user to select a question from listBox
                MessageBox.Show("Please select a question.");
            }
        }

        private void btnStartQuizz_Click(object sender, EventArgs e)
        {
            // check if there are any quesions to answer
            if (lblQuestionCount.Text != "0")
            { // create instence from of second form
                frmActiveQuizz StartQuizz = new frmActiveQuizz();
                // display second form
                StartQuizz.ShowDialog();

                // load Listbox
                LoadListBox();// dont know if i need this????
            }// end if
            else
            {
                MessageBox.Show("There are no questions to answer!");

            }// end if
        }

        private void btnAddActivate_Click(object sender, EventArgs e)
        {
            // check if item from list box is selected
            if (lstEditQuestions.SelectedIndex > -1)
            {
                // set variable to selected index
                int index = lstEditQuestions.SelectedIndex;
                // set local variable 
                string strQuestAnswer = txtQuestion.Text + "," + txtAnswere.Text + ";" +
                    txtWrong1.Text + "/" + txtWrong2.Text + ":" + txtWrong3.Text;

                // enable textbox
                EnableTextBox();

                // show group box
                gbAddUpdate.Visible = true;

                // show update button
                btnUpdate.Visible = true;

            }
            else
            {
                // tell user to select a question from listBox
                MessageBox.Show("Please select a question.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
