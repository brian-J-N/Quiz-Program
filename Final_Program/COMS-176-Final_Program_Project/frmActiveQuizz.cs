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
    public partial class frmActiveQuizz : Form
    {
        
        // list to hold file content
        List<string> lstFileContents = new List<string>();

        // list to hold answers
        List<string> lstAnswers = new List<string>();

        // counter variable
        int numCorrect = 0;
        int numWrong = 0;

        // variable for number of questions
        int numQuestion = 0;
            

        public frmActiveQuizz()
        {
            InitializeComponent();
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdioAnswer1.Checked || rdioAnswer2.Checked || rdioAnswer3.Checked ||
             rdioAnswer4.Checked)
            { 
                // check if answer was correct
                if (rdioAnswer1.Checked)
                {
                    if (rdioAnswer1.Text == lblCorrectAnswer.Text)
                    {
                        // show correct 
                        numCorrect += 1;
                        lblCorrectAnswer.Text = "Correct!";
                        lblCorrectAnswer.Visible = true;
                                            
                    }// end if
                    else
                    {
                        // show wrong 
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = "Wrong!";
                        lblResult.Visible = true;
                        lblCorrectAnswer.Visible = true;
                        lblCorrectAnswerText.Visible = true;
                        numWrong +=1;
                    }// end else

                } // end if

                if (rdioAnswer2.Checked)
                {
                    if (rdioAnswer2.Text == lblCorrectAnswer.Text)
                    {
                        // show correct
                        numCorrect += 1;
                        lblCorrectAnswer.Text = "Correct!";
                        lblCorrectAnswer.Visible = true;                       
                    }// end if
                    else
                    {
                        // show wrong 
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = "Wrong!";
                        lblResult.Visible = true;
                        lblCorrectAnswer.Visible = true;
                        lblCorrectAnswerText.Visible = true;
                        numWrong += 1;

                    }// end else
                } // end if

                if (rdioAnswer3.Checked)
                {
                    if (rdioAnswer3.Text == lblCorrectAnswer.Text)
                    {
                        // show results
                        numCorrect += 1;
                        lblCorrectAnswer.Text = "Correct!";
                        lblCorrectAnswer.Visible = true;
                    }// end if
                    else
                    {
                        // show wrong 
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = "Wrong!";
                        lblResult.Visible = true;
                        lblCorrectAnswer.Visible = true;
                        lblCorrectAnswerText.Visible = true;
                        numWrong += 1;

                    }// end else
                }//end if

                if (rdioAnswer4.Checked)
                {
                    if (rdioAnswer4.Text == lblCorrectAnswer.Text)
                    {
                        // show results
                        numCorrect += 1;
                        lblCorrectAnswer.Text = "Correct!";
                        lblCorrectAnswer.Visible = true;
                    }// end if
                    else
                    {
                        // show wrong 
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = "Wrong!";
                        lblResult.Visible = true;
                        lblCorrectAnswer.Visible = true;
                        lblCorrectAnswerText.Visible = true;
                        numWrong += 1;

                    }// end else
                }//end if

                // set next button to visible
                btnNext.Visible = true;

                // disable submit button
                btnSubmit.Enabled = false;

                // set radio button answers to invisible
                // set radio buttons to visible
                rdioAnswer1.Visible = false;
                rdioAnswer2.Visible = false;
                rdioAnswer3.Visible = false;
                rdioAnswer4.Visible = false;

            }// end if
            else
            {
                MessageBox.Show("Please select an answer!");
            }// end else
            
        }

        private void frmActiveQuizz_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            

            // Uncheck radio buttons
            rdioAnswer1.Checked = false;
            rdioAnswer2.Checked = false;
            rdioAnswer3.Checked = false;
            rdioAnswer4.Checked = false;

            // fill list
            LoadList();

            //Select random question // load to listBox
            SelectRandomQuestion();

            // set start button to invisible
            btnStart.Visible = false;

            // set submit button to visible
            btnSubmit.Visible = true;

            // display questions and answers to screen
            DisplayQuestionAnswers();

            // count list box
            lstBoxCount();
            
            // set count label to visible
            lblCount.Visible = true;
            lblQuestionCountText.Visible = true;
            
            // get the count of questions
            numQuestion = Int32.Parse(lblCount.Text); 

            // remove item from list box
            lstStart.Items.Remove(lstStart.Items[0]);

            // set radio buttons to visible
            rdioAnswer1.Visible = true;
            rdioAnswer2.Visible = true;
            rdioAnswer3.Visible = true;
            rdioAnswer4.Visible = true;
        }

        //***************************Methods**********************************
       
        
        // method to load list
        private void LoadList()
        {
            try
            {
                string questions = ""; // test

                int index = 0;
                StreamReader inputfile; // inputfile holds the file

                // open file
                inputfile = File.OpenText("QuizzQuestions.txt");

                // loop through file
                while (!inputfile.EndOfStream)
                {
                    // read file one line at a time
                    // assign item from list to varible// test
                    questions = inputfile.ReadLine();
                    lstFileContents.Add(questions);

                }// end while

                // close file
                inputfile.Close();
            }
            catch (Exception ex)
            {
                // Display an Error message.
                MessageBox.Show(ex.Message);
            }


        }// end method


            // method to randomly select items from the list
            private void SelectRandomQuestion()
        {
            // random number generator
            // variable holds random number
            Random rnd = new Random();

            // loop through list
            while (lstFileContents.Count != 0)
            {
                // get random number between 0 and list item count
                int intRandum = rnd.Next(0, lstFileContents.Count);

                // add item to list box
                lstStart.Items.Add(lstFileContents[intRandum]);

                // remove item from list
                lstFileContents.Remove(lstFileContents[intRandum]);

            }// end while

        }// end method


        // method to display questions and answers to screen
        private void DisplayQuestionAnswers()
        {

            // get question from list assign to string data type
            string strQuestion = lstStart.Items[0].ToString();

            //  Display the question
            lblDisplayQuestion.Text = strQuestion.Substring(0, strQuestion.IndexOf(","));

            // get Answer from list seperated by ","  assign to string data type
            string strAnswer = strQuestion.Substring(strQuestion.IndexOf(","));
            strAnswer = strAnswer.Substring(1, strAnswer.IndexOf(";"));
            // display Answer between "," and ";"
            strAnswer = strAnswer.Substring(0, strAnswer.IndexOf(";"));
           
            // get Wrong answer1 from list seperated by ";"  assign to string data type
            string strWrong1 = strQuestion.Substring(strQuestion.IndexOf(";"));
            strWrong1 = strWrong1.Substring(1, strWrong1.IndexOf("/"));
            //Display wrong answer between ";" and "/"
            strWrong1 = strWrong1.Substring(0, strWrong1.IndexOf("/"));

            // get Wrong answer2 from list seperated by "/" assign to string data type
            string strWrong2 = strQuestion.Substring(strQuestion.IndexOf("/"));
            strWrong2 = strWrong2.Substring(1, strWrong2.IndexOf(":"));
            //Display wrong answer between ";" and "/"
            strWrong2 = strWrong2.Substring(0, strWrong2.IndexOf(":"));

            // get Wrong answer3 from list seperated by ":" assign to string data type
            string strWrong3 = strQuestion.Substring(strQuestion.IndexOf(":"));
            strWrong3 = strWrong3.Substring(1);

            //Add answers to list
            lstAnswers.Add(strAnswer);
            lstAnswers.Add(strWrong1);
            lstAnswers.Add(strWrong2);
            lstAnswers.Add(strWrong3);
            
            // randomize list
            // random number generator
            // variable holds random number
            Random rnd = new Random();

            // variables to hold randomized answers
            string Answer1 = "";
            string Answer2 = "";
            string Answer3 = "";
            string Answer4 = "";

            // loop through list
            while (lstAnswers.Count != 0)
            {
                // get random number between 0 and list item count -1
                int intRandum = rnd.Next(0, lstAnswers.Count);

                // assign variable random answers from list
                Answer1 = (lstAnswers[intRandum]);

                // remove item from list
                lstAnswers.Remove(lstAnswers[intRandum]);

                // get random number between 0 and list item count -1
                 intRandum = rnd.Next(0, lstAnswers.Count);

                // assign variable random answers from list
                Answer2 = (lstAnswers[intRandum]);

                // remove item from list
                lstAnswers.Remove(lstAnswers[intRandum]);

                // get random number between 0 and list item count -1
                intRandum = rnd.Next(0, lstAnswers.Count);

                // assign variable random answers from list
                Answer3 = (lstAnswers[intRandum]);

                // remove item from list
                lstAnswers.Remove(lstAnswers[intRandum]);

                // get random number between 0 and list item count -1
                intRandum = rnd.Next(0, lstAnswers.Count);

                // assign variable random answers from list
                Answer4 = (lstAnswers[intRandum]);

                // remove item from list
                lstAnswers.Remove(lstAnswers[intRandum]);

            }// end while
         
            // display correct answer
            lblCorrectAnswer.Text = strAnswer;

            // display randomized answers 
            rdioAnswer1.Text = Answer1;
            rdioAnswer2.Text = Answer2;
            rdioAnswer3.Text = Answer3;
            rdioAnswer4.Text = Answer4;
            
        }// end method

     // method to count list box
     private void lstBoxCount()
        {
            // count list box items
            int totalItems = lstStart.Items.Count;
            lblCount.Text = totalItems.ToString();

        }


        //*****************************************************************************




        private void lstStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (lstStart.Items.Count != 0)
            {
                // Uncheck radio buttons
                rdioAnswer1.Checked = false;
                rdioAnswer2.Checked = false;
                rdioAnswer3.Checked = false;
                rdioAnswer4.Checked = false;

                // Display next question and answers to screen
                DisplayQuestionAnswers();

                // count list box
                lstBoxCount();

                // remove item from list box
                lstStart.Items.Remove(lstStart.Items[0]);

                // set next button to invisible
                btnNext.Visible = false;

                // set submit button to enabled
                btnSubmit.Enabled = true;

                // set answer lable to invisible
                lblCorrectAnswer.Visible = false;
                lblCorrectAnswerText.Visible = false;

                // set result label to invisible
                lblResult.Visible = false;


                // set radio buttons to visible          
                rdioAnswer1.Visible = true;
                rdioAnswer2.Visible = true;
                rdioAnswer3.Visible = true;
                rdioAnswer4.Visible = true;

            }

            else
            {
                // end of quizz
                
                // show test results
                lblResult.Text = "Test Complete!";
                lblCorrectAnswer.Text = "Score: " + numCorrect + " Out of " + numQuestion 
                    + "\nCorrect: " + numCorrect + "\nWrong: " + numWrong;
                lblResult.ForeColor = Color.Gold;
                lblResult.Visible = true;
                lblDisplayQuestion.Text = "You have completed the test!";

                // set label to invisible
                lblCount.Visible = false;
                lblQuestionCountText.Visible = false;
                lblCorrectAnswerText.Visible = false;

                //set buttons to invisible
                btnSubmit.Visible = false;
                btnNext.Visible = false;

                //set exit button to visible
                btnExit.Visible = true;

            }
                   
        }

        private void lblCorrectAnswer_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCorrectAnswerText_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
