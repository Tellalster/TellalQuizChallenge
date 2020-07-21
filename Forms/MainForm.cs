using CodeChallengeJeroen.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeChallengeJeroen.Forms;

namespace CodeChallengeJeroen
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor of the main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the start button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            BackgroundForm.Instance.StartQuestions();
        }

        /// <summary>
        /// When the quit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            BackgroundForm.Instance.QuitProgram();
        }
    }
}
