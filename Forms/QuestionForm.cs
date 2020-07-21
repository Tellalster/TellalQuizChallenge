using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeChallengeJeroen.Questions;

namespace CodeChallengeJeroen.Forms
{
    public partial class QuestionForm : Form
    {
        /// <summary>
        /// The list of questions this form is showing
        /// </summary>
        private List<Question> _questions;
        /// <summary>
        /// The timer to manage the time constraint
        /// </summary>
        private Timer _questionTimer;
        /// <summary>
        /// The tool to iterate over the questions (this starts at -1 because you need to press the next button to start the questions)
        /// </summary>
        private int _questionIterator;
        
        /// <summary>
        /// Construcor of the question form
        /// </summary>
        public QuestionForm()
        {
            InitializeComponent();
            _questionIterator = -1;
            _questionTimer = new Timer();
            _questionTimer.Interval = 1000;
            _questionTimer.Tick += new EventHandler(TimerTick);
        }

        /// <summary>
        /// Set the form up with new questions
        /// </summary>
        /// <param name="questions">the questions to show this time</param>
        public void QuestionSetup(List<Question> questions)
        {
            _questionTimer.Stop();
            _questions = questions;
            lblQuestionNr.Text = "1";
            lblQuestionText.Text = "Hier komen 10 vragen. Klik bij het juiste antwoord op de knop binnen 10 seconden";
            lblAns1.Text = "Antwoord 1";
            lblAns2.Text = "Antwoord 2";
            lblAns3.Text = "Antwoord 3";
            lblAns4.Text = "Antwoord 4";

            _questionIterator = -1;
            ResetColours();
            EnableNextQuestion();
        }

        /// <summary>
        /// What happens every timer tick, if the countdown reaches 0 the questions is answered incorrectly
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        private void TimerTick(Object myObject, EventArgs myEventArgs)
        {
            prbrTimeLeft.Value--;
            
            if (prbrTimeLeft.Value == 0)
            {
               AnswerWrong();
            }
        }

        /// <summary>
        /// The question is answered correctly
        /// </summary>
        private void AnswerCorrect()
        {
            BackgroundForm.Instance.ScoreIncrease();
            ShowCorrectAnswer();
        }

        /// <summary>
        /// the question is answered incorrectly
        /// </summary>
        private void AnswerWrong()
        {
            ShowCorrectAnswer();
        }

        /// <summary>
        /// Prevents more answers to an answered question
        /// </summary>
        private void EnableNextQuestion()
        {
            btnNextQuestion.Enabled = true;
            btnAns1.Enabled = false;
            btnAns2.Enabled = false;
            btnAns3.Enabled = false;
            btnAns4.Enabled = false;
        }

        /// <summary>
        /// Allows the answering of the question and prevents going to the next question while this question is unanswered
        /// </summary>
        private void EnableAnswers()
        {
            btnNextQuestion.Enabled = false;
            btnAns1.Enabled = true;
            btnAns2.Enabled = true;
            btnAns3.Enabled = true;
            btnAns4.Enabled = true;
        }
        
        /// <summary>
        /// Make the backdrop of the correct answer green and the backdrops of answers that are not correct red
        /// </summary>
        private void ShowCorrectAnswer()
        {
            _questionTimer.Stop();

            switch (_questions[_questionIterator].CorrectAnswer)
            {
                case 1:
                    lblAns1.BackColor = Color.Lime;
                    lblAns2.BackColor = Color.Red;
                    lblAns3.BackColor = Color.Red;
                    lblAns4.BackColor = Color.Red;
                    break;
                case 2:
                    lblAns1.BackColor = Color.Red;
                    lblAns2.BackColor = Color.Lime;
                    lblAns3.BackColor = Color.Red;
                    lblAns4.BackColor = Color.Red;
                    break;
                case 3:
                    lblAns1.BackColor = Color.Red;
                    lblAns2.BackColor = Color.Red;
                    lblAns3.BackColor = Color.Lime;
                    lblAns4.BackColor = Color.Red;
                    break;
                case 4:
                    lblAns1.BackColor = Color.Red;
                    lblAns2.BackColor = Color.Red;
                    lblAns3.BackColor = Color.Red;
                    lblAns4.BackColor = Color.Lime;
                    break;
                default:
                    lblAns1.BackColor = Color.Red;
                    lblAns2.BackColor = Color.Red;
                    lblAns3.BackColor = Color.Red;
                    lblAns4.BackColor = Color.Red;
                    break;
            }

            if (_questionIterator == _questions.Count)
            {
                btnNextQuestion.Text = "Naar score!";
            }
            
            EnableNextQuestion();
        }
        
        /// <summary>
        /// what happens if the quit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            BackgroundForm.Instance.BackToMainFromQuestions();
        }

        /// <summary>
        /// reset al the answer backdrops to colourless
        /// </summary>
        private void ResetColours()
        {
            lblAns1.BackColor = Color.Transparent;
            lblAns2.BackColor = Color.Transparent;
            lblAns3.BackColor = Color.Transparent;
            lblAns4.BackColor = Color.Transparent;
        }

        /// <summary>
        /// What happens if the next question button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            ResetColours();
            
            prbrTimeLeft.Value = prbrTimeLeft.Maximum;

            if (_questionIterator < _questions.Count - 1)
            {
                _questionIterator++;
                lblQuestionText.Text = _questions[_questionIterator].QuestionText;
                lblAns1.Text = _questions[_questionIterator].Answer1;
                lblAns2.Text = _questions[_questionIterator].Answer2;
                lblAns3.Text = _questions[_questionIterator].Answer3;
                lblAns4.Text = _questions[_questionIterator].Answer4;
                lblQuestionNr.Text = (_questionIterator + 1).ToString();
            }
            else
            {
                BackgroundForm.Instance.ToScoreScreen();
            }
            
            EnableAnswers();
            _questionTimer.Start();
        }

        /// <summary>
        /// what happens if Answer 1 is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAns1_Click(object sender, EventArgs e)
        {
            if (_questions[_questionIterator].CorrectAnswer == 1)
            {
                AnswerCorrect();
            }
            else
            {
                AnswerWrong();
            }
        }

        /// <summary>
        /// what happens if Answer 2 is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAns2_Click(object sender, EventArgs e)
        {
            if (_questions[_questionIterator].CorrectAnswer == 2)
            {
                AnswerCorrect();
            }
            else
            {
                AnswerWrong();
            }
        }

        /// <summary>
        /// what happens if Answer 3 is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAns3_Click(object sender, EventArgs e)
        {
            if (_questions[_questionIterator].CorrectAnswer == 3)
            {
                AnswerCorrect();
            }
            else
            {
                AnswerWrong();
            }
        }

        /// <summary>
        /// what happens if Answer 4 is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAns4_Click(object sender, EventArgs e)
        {
            if (_questions[_questionIterator].CorrectAnswer == 4)
            {
                AnswerCorrect();
            }
            else
            {
                AnswerWrong();
            }
        }
    }
}
