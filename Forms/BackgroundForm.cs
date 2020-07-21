using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CodeChallengeJeroen.Questions;

namespace CodeChallengeJeroen.Forms
{
    public partial class BackgroundForm : Form
    {
        /// <summary>
        /// singleton
        /// </summary>
        private static BackgroundForm _instance;
    
        /// <summary>
        /// Create this singleton if it doesn't exist, and return the singleton
        /// </summary>
        public static BackgroundForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BackgroundForm();
                }
                
                return _instance;
            }
        }

        /// <summary>
        /// mainform
        /// </summary>
        private MainForm _mainForm;
        
        /// <summary>
        /// questionform
        /// </summary>
        private QuestionForm _questionForm;
        
        /// <summary>
        /// resultform
        /// </summary>
        private ResultForm _resultForm;
        
        /// <summary>
        /// factory pattern constructor for the questions
        /// </summary>
        private QuestionConstructor _questionConstructor;
        
        /// <summary>
        /// the score to show in the resultform
        /// </summary>
        private int _score;

        /// <summary>
        /// How many questions the quiz has
        /// </summary>
        private int _quizSize;

        /// <summary>
        /// constructor
        /// </summary>
        public BackgroundForm()
        {
            if (_instance == null)
            {
                _instance = this;
                this.Setup();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Setting up this form
        /// </summary>
        private void Setup()
        {
            InitializeComponent();

            _questionConstructor = new QuestionConstructor();
            this._quizSize = 10;
            this._score = 0;
            this._mainForm = new MainForm();
            _questionForm = new QuestionForm();
            _resultForm = new ResultForm();
            
            this._mainForm.Closed += MainFormOnClosed;
            _questionForm.Closed += QuestionFormOnClosed;
            _resultForm.Closed += ResultFormOnClosed;
            
            this._mainForm.Show();
            this.Hide();
        }

        /// <summary>
        /// quit program if the mainform is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormOnClosed(object sender, EventArgs e)
        {
            QuitProgram();
        }

        /// <summary>
        /// quit program if the questionform is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuestionFormOnClosed(object sender, EventArgs e)
        {
            QuitProgram();
        }
        
        /// <summary>
        /// quit program if the resultform is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultFormOnClosed(object sender, EventArgs e)
        {
            QuitProgram();
        }

        /// <summary>
        /// Close all forms and quit the program
        /// </summary>
        public void QuitProgram()
        {
            this._resultForm.Closed -= ResultFormOnClosed;
            this._questionForm.Closed -= QuestionFormOnClosed;
            this._mainForm.Closed -= MainFormOnClosed;
            this._mainForm.Close();
            this._questionForm.Close();
            this._resultForm.Close(); 
            this.Close();
        }

        /// <summary>
        /// Open the questions form, fill it with random questions and reset the score
        /// </summary>
        public void StartQuestions()
        {
            this._score = 0;
            this._questionForm.StartPosition = FormStartPosition.Manual;
            this._questionForm.Location = _mainForm.Location;
            this.Location = this._questionForm.Location;
            this._mainForm.Hide();
            this._resultForm.Hide();
            this.Hide();
            this._questionForm.QuestionSetup(_questionConstructor.GetQuestions(_quizSize));

            this._questionForm.Show();
        }

        /// <summary>
        /// hide questionform and open the main form
        /// </summary>
        public void BackToMainFromQuestions()
        {
            this.Hide();
            this._questionForm.Hide();
            this._mainForm.Location = this._questionForm.Location;
            this._mainForm.Show();
        }
        
        /// <summary>
        /// hide resultform and open the main form
        /// </summary>
        public void BackToMainFromResults()
        {
            this._resultForm.Hide();
            this._mainForm.Location = this._resultForm.Location;
            this._mainForm.Show();
        }

        /// <summary>
        /// hide questionform and show the resultform filled with the score
        /// </summary>
        public void ToScoreScreen()
        {
            this.Hide();
            this._resultForm.StartPosition = FormStartPosition.Manual;
            this._resultForm.Location = _questionForm.Location;
            this._mainForm.Location = _resultForm.Location;
            this.Location = _resultForm.Location;
            this._questionForm.Hide();
            this._resultForm.SetupScore(_score, _quizSize);
            this._resultForm.Show();
        }

        /// <summary>
        /// increase the score
        /// </summary>
        public void ScoreIncrease()
        {
            this._score++;
        }
    }
}