using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChallengeJeroen.Forms
{
    public partial class ResultForm : Form
    {
        /// <summary>
        /// Constructor of the result form
        /// </summary>
        public ResultForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setup this form with the correct score
        /// </summary>
        /// <param name="score">the score to display</param>
        public void SetupScore(int score, int scoremax)
        {
            lblScore.Text = score.ToString() + " Van de " + scoremax.ToString();
            double scorePercentage = (double)score / (double)scoremax;
            
            if (scorePercentage > 0.6)
            {
                lblScore.BackColor = Color.Lime;
            }
            else if (scorePercentage > 0.3)
            {
                lblScore.BackColor = Color.Yellow;
            }
            else
            {
                lblScore.BackColor = Color.Red;
            }

            switch (score)
            {
                case 0:
                    lblScoreCongratulation.Text = "Geen vragen goed, het kan alleen maar beter gaan :)";
                    break;
                case 1:
                    lblScoreCongratulation.Text = "1 vraag goed, slecht gegokt?";
                    break;
                case 2:
                    lblScoreCongratulation.Text = "2 vragen goed, iets beter je best doen";
                    break;
                case 3:
                    lblScoreCongratulation.Text = "3 vragen goed, iets beter je best doen";
                    break;
                case 4:
                    lblScoreCongratulation.Text = "4 vragen goed, iets beter je best doen";
                    break;
                case 5:
                    lblScoreCongratulation.Text = "5 vragen goed, bijna een voldoende";
                    break;
                case 6:
                    lblScoreCongratulation.Text = "6 vragen goed, net een voldoende";
                    break;
                case 7:
                    lblScoreCongratulation.Text = "7 vragen goed, jij weet best wel wat weetjes zo te zien";
                    break;
                case 8:
                    lblScoreCongratulation.Text = "8 vragen goed, jij weet genoeg voor een ruim voldoende";
                    break;
                case 9:
                    lblScoreCongratulation.Text = "Bijna perfect, jij weet heel veel";
                    break;
                case 10:
                    lblScoreCongratulation.Text = "Perfect, jij hebt een goede neus voor techniek";
                    break;
            }
        }

        /// <summary>
        /// what happens if the quit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            BackgroundForm.Instance.QuitProgram();
        }

        /// <summary>
        /// what happens if the back to main button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            BackgroundForm.Instance.BackToMainFromResults();
        }
    }
}
