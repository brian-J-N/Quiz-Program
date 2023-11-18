
namespace COMS_176_Final_Program_Project
{
    partial class frmActiveQuizz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActiveQuizz));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDisplayQuestion = new System.Windows.Forms.Label();
            this.rdioAnswer1 = new System.Windows.Forms.RadioButton();
            this.rdioAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdioAnswer3 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.rdioAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstStart = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblQuestionCountText = new System.Windows.Forms.Label();
            this.lblCorrectAnswerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-67, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDisplayQuestion
            // 
            this.lblDisplayQuestion.AutoSize = true;
            this.lblDisplayQuestion.BackColor = System.Drawing.Color.White;
            this.lblDisplayQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayQuestion.Location = new System.Drawing.Point(34, 150);
            this.lblDisplayQuestion.Name = "lblDisplayQuestion";
            this.lblDisplayQuestion.Size = new System.Drawing.Size(565, 32);
            this.lblDisplayQuestion.TabIndex = 1;
            this.lblDisplayQuestion.Text = "Press Start when you are ready to begin.";
            // 
            // rdioAnswer1
            // 
            this.rdioAnswer1.AutoSize = true;
            this.rdioAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.rdioAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdioAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioAnswer1.Location = new System.Drawing.Point(171, 373);
            this.rdioAnswer1.Name = "rdioAnswer1";
            this.rdioAnswer1.Size = new System.Drawing.Size(136, 36);
            this.rdioAnswer1.TabIndex = 1;
            this.rdioAnswer1.TabStop = true;
            this.rdioAnswer1.Text = "Answer";
            this.rdioAnswer1.UseVisualStyleBackColor = false;
            this.rdioAnswer1.Visible = false;
            // 
            // rdioAnswer2
            // 
            this.rdioAnswer2.AutoSize = true;
            this.rdioAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.rdioAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdioAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioAnswer2.Location = new System.Drawing.Point(171, 439);
            this.rdioAnswer2.Name = "rdioAnswer2";
            this.rdioAnswer2.Size = new System.Drawing.Size(136, 36);
            this.rdioAnswer2.TabIndex = 2;
            this.rdioAnswer2.TabStop = true;
            this.rdioAnswer2.Text = "Answer";
            this.rdioAnswer2.UseVisualStyleBackColor = false;
            this.rdioAnswer2.Visible = false;
            // 
            // rdioAnswer3
            // 
            this.rdioAnswer3.AutoSize = true;
            this.rdioAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.rdioAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdioAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioAnswer3.Location = new System.Drawing.Point(171, 508);
            this.rdioAnswer3.Name = "rdioAnswer3";
            this.rdioAnswer3.Size = new System.Drawing.Size(136, 36);
            this.rdioAnswer3.TabIndex = 3;
            this.rdioAnswer3.TabStop = true;
            this.rdioAnswer3.Text = "Answer";
            this.rdioAnswer3.UseVisualStyleBackColor = false;
            this.rdioAnswer3.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(171, 653);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 64);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(341, 371);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(116, 38);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            this.lblResult.Visible = false;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.White;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(342, 453);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(222, 32);
            this.lblCorrectAnswer.TabIndex = 7;
            this.lblCorrectAnswer.Text = "Correct Answer";
            this.lblCorrectAnswer.Visible = false;
            this.lblCorrectAnswer.Click += new System.EventHandler(this.lblCorrectAnswer_Click);
            // 
            // rdioAnswer4
            // 
            this.rdioAnswer4.AutoSize = true;
            this.rdioAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.rdioAnswer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdioAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioAnswer4.Location = new System.Drawing.Point(171, 573);
            this.rdioAnswer4.Name = "rdioAnswer4";
            this.rdioAnswer4.Size = new System.Drawing.Size(136, 36);
            this.rdioAnswer4.TabIndex = 4;
            this.rdioAnswer4.TabStop = true;
            this.rdioAnswer4.Text = "Answer";
            this.rdioAnswer4.UseVisualStyleBackColor = false;
            this.rdioAnswer4.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(383, 508);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstStart
            // 
            this.lstStart.FormattingEnabled = true;
            this.lstStart.ItemHeight = 16;
            this.lstStart.Location = new System.Drawing.Point(640, 335);
            this.lstStart.Name = "lstStart";
            this.lstStart.Size = new System.Drawing.Size(312, 164);
            this.lstStart.TabIndex = 11;
            this.lstStart.Visible = false;
            this.lstStart.SelectedIndexChanged += new System.EventHandler(this.lstStart_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(438, 653);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(198, 64);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(833, 708);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(113, 24);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "label count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCount.Visible = false;
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(383, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 64);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblQuestionCountText
            // 
            this.lblQuestionCountText.AutoSize = true;
            this.lblQuestionCountText.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCountText.Location = new System.Drawing.Point(736, 675);
            this.lblQuestionCountText.Name = "lblQuestionCountText";
            this.lblQuestionCountText.Size = new System.Drawing.Size(210, 24);
            this.lblQuestionCountText.TabIndex = 15;
            this.lblQuestionCountText.Text = "Questions Remaining";
            this.lblQuestionCountText.Visible = false;
            this.lblQuestionCountText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCorrectAnswerText
            // 
            this.lblCorrectAnswerText.AutoSize = true;
            this.lblCorrectAnswerText.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswerText.Location = new System.Drawing.Point(343, 418);
            this.lblCorrectAnswerText.Name = "lblCorrectAnswerText";
            this.lblCorrectAnswerText.Size = new System.Drawing.Size(161, 25);
            this.lblCorrectAnswerText.TabIndex = 16;
            this.lblCorrectAnswerText.Text = "Correct Answer";
            this.lblCorrectAnswerText.Visible = false;
            this.lblCorrectAnswerText.Click += new System.EventHandler(this.lblCorrectAnswerText_Click);
            // 
            // frmActiveQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(996, 780);
            this.Controls.Add(this.lblCorrectAnswerText);
            this.Controls.Add(this.lblQuestionCountText);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lstStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rdioAnswer4);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdioAnswer3);
            this.Controls.Add(this.rdioAnswer2);
            this.Controls.Add(this.rdioAnswer1);
            this.Controls.Add(this.lblDisplayQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmActiveQuizz";
            this.Text = "Active Quizz";
            this.Load += new System.EventHandler(this.frmActiveQuizz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDisplayQuestion;
        private System.Windows.Forms.RadioButton rdioAnswer1;
        private System.Windows.Forms.RadioButton rdioAnswer2;
        private System.Windows.Forms.RadioButton rdioAnswer3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.RadioButton rdioAnswer4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblQuestionCountText;
        private System.Windows.Forms.Label lblCorrectAnswerText;
    }
}