namespace CodeChallengeJeroen.Forms
{
    partial class QuestionForm
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblQuestionNr = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.lblAns4 = new System.Windows.Forms.Label();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.prbrTimeLeft = new System.Windows.Forms.ProgressBar();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuestionText.Location = new System.Drawing.Point(171, 61);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(617, 46);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Tekst van de vraag";
            // 
            // lblQuestionNr
            // 
            this.lblQuestionNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuestionNr.Location = new System.Drawing.Point(139, 64);
            this.lblQuestionNr.Name = "lblQuestionNr";
            this.lblQuestionNr.Size = new System.Drawing.Size(26, 23);
            this.lblQuestionNr.TabIndex = 1;
            this.lblQuestionNr.Text = "10";
            // 
            // lblAns2
            // 
            this.lblAns2.Location = new System.Drawing.Point(233, 168);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(283, 39);
            this.lblAns2.TabIndex = 3;
            this.lblAns2.Text = "Antwoord B";
            // 
            // lblAns3
            // 
            this.lblAns3.Location = new System.Drawing.Point(233, 213);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(283, 39);
            this.lblAns3.TabIndex = 4;
            this.lblAns3.Text = "Antwoord C";
            // 
            // lblAns4
            // 
            this.lblAns4.Location = new System.Drawing.Point(233, 258);
            this.lblAns4.Name = "lblAns4";
            this.lblAns4.Size = new System.Drawing.Size(283, 39);
            this.lblAns4.TabIndex = 5;
            this.lblAns4.Text = "Antwoord D";
            // 
            // btnAns1
            // 
            this.btnAns1.Location = new System.Drawing.Point(119, 123);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(75, 39);
            this.btnAns1.TabIndex = 6;
            this.btnAns1.Text = "Antwoord A";
            this.btnAns1.UseVisualStyleBackColor = true;
            this.btnAns1.Click += new System.EventHandler(this.btnAns1_Click);
            // 
            // btnAns2
            // 
            this.btnAns2.Location = new System.Drawing.Point(119, 168);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(75, 39);
            this.btnAns2.TabIndex = 7;
            this.btnAns2.Text = "Antwoord B";
            this.btnAns2.UseVisualStyleBackColor = true;
            this.btnAns2.Click += new System.EventHandler(this.btnAns2_Click);
            // 
            // btnAns3
            // 
            this.btnAns3.Location = new System.Drawing.Point(119, 213);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(75, 39);
            this.btnAns3.TabIndex = 8;
            this.btnAns3.Text = "Antwoord C";
            this.btnAns3.UseVisualStyleBackColor = true;
            this.btnAns3.Click += new System.EventHandler(this.btnAns3_Click);
            // 
            // btnAns4
            // 
            this.btnAns4.Location = new System.Drawing.Point(119, 258);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(75, 39);
            this.btnAns4.TabIndex = 9;
            this.btnAns4.Text = "Antwoord D";
            this.btnAns4.UseVisualStyleBackColor = true;
            this.btnAns4.Click += new System.EventHandler(this.btnAns4_Click);
            // 
            // prbrTimeLeft
            // 
            this.prbrTimeLeft.Location = new System.Drawing.Point(298, 35);
            this.prbrTimeLeft.Maximum = 10;
            this.prbrTimeLeft.Name = "prbrTimeLeft";
            this.prbrTimeLeft.Size = new System.Drawing.Size(218, 23);
            this.prbrTimeLeft.TabIndex = 10;
            this.prbrTimeLeft.Value = 10;
            // 
            // lblAns1
            // 
            this.lblAns1.Location = new System.Drawing.Point(233, 123);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(283, 39);
            this.lblAns1.TabIndex = 2;
            this.lblAns1.Text = "Antwoord A";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTime.Location = new System.Drawing.Point(392, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 23);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Tijd";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuestion.Location = new System.Drawing.Point(79, 61);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(54, 23);
            this.lblQuestion.TabIndex = 14;
            this.lblQuestion.Text = "Vraag";
            // 
            // BtnQuit
            // 
            this.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnQuit.Location = new System.Drawing.Point(12, 342);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(121, 64);
            this.BtnQuit.TabIndex = 15;
            this.BtnQuit.Text = "Terug naar begin\r\n";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(667, 342);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 64);
            this.btnNextQuestion.TabIndex = 16;
            this.btnNextQuestion.Text = "Volgende vraag";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.prbrTimeLeft);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Controls.Add(this.lblAns4);
            this.Controls.Add(this.lblAns3);
            this.Controls.Add(this.lblAns2);
            this.Controls.Add(this.lblAns1);
            this.Controls.Add(this.lblQuestionNr);
            this.Controls.Add(this.lblQuestionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.ShowIcon = false;
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.Label lblAns4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNr;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar prbrTimeLeft;

        #endregion
    }
}