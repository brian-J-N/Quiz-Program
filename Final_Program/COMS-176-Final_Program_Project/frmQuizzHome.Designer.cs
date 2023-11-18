
namespace COMS_176_Final_Program_Project
{
    partial class frmQuizzHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuizzHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartQuizz = new System.Windows.Forms.Button();
            this.btnEditQuizz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.gbCustomizeQuizz = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWrong3 = new System.Windows.Forms.TextBox();
            this.txtWrong2 = new System.Windows.Forms.TextBox();
            this.txtWrong1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnswere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.lstEditQuestions = new System.Windows.Forms.ListBox();
            this.gbAddUpdate = new System.Windows.Forms.GroupBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddActivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCustomizeQuizz.SuspendLayout();
            this.gbAddUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartQuizz
            // 
            this.btnStartQuizz.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartQuizz.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuizz.Location = new System.Drawing.Point(233, 342);
            this.btnStartQuizz.Name = "btnStartQuizz";
            this.btnStartQuizz.Size = new System.Drawing.Size(309, 89);
            this.btnStartQuizz.TabIndex = 1;
            this.btnStartQuizz.Text = "Take the Quizz";
            this.btnStartQuizz.UseVisualStyleBackColor = false;
            this.btnStartQuizz.Click += new System.EventHandler(this.btnStartQuizz_Click);
            // 
            // btnEditQuizz
            // 
            this.btnEditQuizz.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditQuizz.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuizz.Location = new System.Drawing.Point(233, 471);
            this.btnEditQuizz.Name = "btnEditQuizz";
            this.btnEditQuizz.Size = new System.Drawing.Size(309, 89);
            this.btnEditQuizz.TabIndex = 2;
            this.btnEditQuizz.Text = "Customize Quizz";
            this.btnEditQuizz.UseVisualStyleBackColor = false;
            this.btnEditQuizz.Click += new System.EventHandler(this.btnEditQuizz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = ": Questions";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCount.Location = new System.Drawing.Point(316, 288);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(27, 29);
            this.lblQuestionCount.TabIndex = 4;
            this.lblQuestionCount.Text = "0";
            this.lblQuestionCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // gbCustomizeQuizz
            // 
            this.gbCustomizeQuizz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCustomizeQuizz.BackgroundImage")));
            this.gbCustomizeQuizz.Controls.Add(this.lstEditQuestions);
            this.gbCustomizeQuizz.Controls.Add(this.gbAddUpdate);
            this.gbCustomizeQuizz.Controls.Add(this.btnAddActivate);
            this.gbCustomizeQuizz.Controls.Add(this.btnAdd);
            this.gbCustomizeQuizz.Controls.Add(this.btnExit);
            this.gbCustomizeQuizz.Controls.Add(this.btnDelete);
            this.gbCustomizeQuizz.Controls.Add(this.txtWrong3);
            this.gbCustomizeQuizz.Controls.Add(this.txtWrong2);
            this.gbCustomizeQuizz.Controls.Add(this.txtWrong1);
            this.gbCustomizeQuizz.Controls.Add(this.label4);
            this.gbCustomizeQuizz.Controls.Add(this.txtAnswere);
            this.gbCustomizeQuizz.Controls.Add(this.label3);
            this.gbCustomizeQuizz.Controls.Add(this.txtQuestion);
            this.gbCustomizeQuizz.Controls.Add(this.label2);
            this.gbCustomizeQuizz.Controls.Add(this.lstQuestions);
            this.gbCustomizeQuizz.Location = new System.Drawing.Point(104, 12);
            this.gbCustomizeQuizz.Name = "gbCustomizeQuizz";
            this.gbCustomizeQuizz.Size = new System.Drawing.Size(719, 610);
            this.gbCustomizeQuizz.TabIndex = 5;
            this.gbCustomizeQuizz.TabStop = false;
            this.gbCustomizeQuizz.Text = "Costomize Quizz";
            this.gbCustomizeQuizz.Visible = false;
            this.gbCustomizeQuizz.Enter += new System.EventHandler(this.gbCustomizeQuizz_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(174, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 49);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(477, 541);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 49);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(310, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 49);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(17, 541);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 49);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWrong3
            // 
            this.txtWrong3.Enabled = false;
            this.txtWrong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrong3.Location = new System.Drawing.Point(187, 456);
            this.txtWrong3.Name = "txtWrong3";
            this.txtWrong3.Size = new System.Drawing.Size(398, 34);
            this.txtWrong3.TabIndex = 11;
            // 
            // txtWrong2
            // 
            this.txtWrong2.Enabled = false;
            this.txtWrong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrong2.Location = new System.Drawing.Point(187, 382);
            this.txtWrong2.Name = "txtWrong2";
            this.txtWrong2.Size = new System.Drawing.Size(398, 34);
            this.txtWrong2.TabIndex = 10;
            // 
            // txtWrong1
            // 
            this.txtWrong1.Enabled = false;
            this.txtWrong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrong1.Location = new System.Drawing.Point(187, 305);
            this.txtWrong1.Name = "txtWrong1";
            this.txtWrong1.Size = new System.Drawing.Size(398, 34);
            this.txtWrong1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wrong Answers";
            // 
            // txtAnswere
            // 
            this.txtAnswere.Enabled = false;
            this.txtAnswere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswere.Location = new System.Drawing.Point(187, 186);
            this.txtAnswere.Name = "txtAnswere";
            this.txtAnswere.Size = new System.Drawing.Size(402, 34);
            this.txtAnswere.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(187, 77);
            this.txtQuestion.MaxLength = 51;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(510, 34);
            this.txtQuestion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Question";
            // 
            // lstQuestions
            // 
            this.lstQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 25;
            this.lstQuestions.Location = new System.Drawing.Point(17, 18);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(142, 479);
            this.lstQuestions.TabIndex = 0;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // lstEditQuestions
            // 
            this.lstEditQuestions.FormattingEnabled = true;
            this.lstEditQuestions.ItemHeight = 16;
            this.lstEditQuestions.Location = new System.Drawing.Point(593, 218);
            this.lstEditQuestions.Name = "lstEditQuestions";
            this.lstEditQuestions.Size = new System.Drawing.Size(120, 84);
            this.lstEditQuestions.TabIndex = 6;
            this.lstEditQuestions.Visible = false;
            this.lstEditQuestions.SelectedIndexChanged += new System.EventHandler(this.lstEditQuestions_SelectedIndexChanged);
            // 
            // gbAddUpdate
            // 
            this.gbAddUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAddUpdate.BackgroundImage")));
            this.gbAddUpdate.Controls.Add(this.btnAdd2);
            this.gbAddUpdate.Controls.Add(this.btnBack);
            this.gbAddUpdate.Controls.Add(this.btnUpdate);
            this.gbAddUpdate.Location = new System.Drawing.Point(6, 521);
            this.gbAddUpdate.Name = "gbAddUpdate";
            this.gbAddUpdate.Size = new System.Drawing.Size(599, 83);
            this.gbAddUpdate.TabIndex = 7;
            this.gbAddUpdate.TabStop = false;
            this.gbAddUpdate.Visible = false;
            this.gbAddUpdate.Enter += new System.EventHandler(this.gbAddButton_Enter);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(157, 21);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(111, 49);
            this.btnAdd2.TabIndex = 0;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Visible = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(460, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExitAdd_Click);
            // 
            // btnAddActivate
            // 
            this.btnAddActivate.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddActivate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActivate.Location = new System.Drawing.Point(327, 541);
            this.btnAddActivate.Name = "btnAddActivate";
            this.btnAddActivate.Size = new System.Drawing.Size(106, 49);
            this.btnAddActivate.TabIndex = 16;
            this.btnAddActivate.Text = "Update";
            this.btnAddActivate.UseVisualStyleBackColor = false;
            this.btnAddActivate.Click += new System.EventHandler(this.btnAddActivate_Click);
            // 
            // frmQuizzHome
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 673);
            this.Controls.Add(this.gbCustomizeQuizz);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditQuizz);
            this.Controls.Add(this.btnStartQuizz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmQuizzHome";
            this.Text = "Quizz_Project";
            this.Load += new System.EventHandler(this.frmQuizzHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCustomizeQuizz.ResumeLayout(false);
            this.gbCustomizeQuizz.PerformLayout();
            this.gbAddUpdate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartQuizz;
        private System.Windows.Forms.Button btnEditQuizz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.GroupBox gbCustomizeQuizz;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtWrong3;
        private System.Windows.Forms.TextBox txtWrong2;
        private System.Windows.Forms.TextBox txtWrong1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAddUpdate;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.TextBox txtAnswere;
        public System.Windows.Forms.ListBox lstQuestions;
        public System.Windows.Forms.ListBox lstEditQuestions;
        private System.Windows.Forms.Button btnAddActivate;
    }
}

