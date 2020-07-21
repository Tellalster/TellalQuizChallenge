using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeJeroen.Questions
{
    public class Question
    {
        /// <summary>
        /// the number of this question to prevent duplicate questions
        /// </summary>
        public int QuestionNr { get; private set; }
        
        /// <summary>
        /// The text of the question
        /// </summary>
        public String QuestionText { get; private set; }
        
        /// <summary>
        /// The answer to go in slot 1
        /// </summary>
        public String Answer1 { get; private set; }
        
        /// <summary>
        /// The answer to go in slot 2
        /// </summary>
        public String Answer2 { get; private set; }
        
        /// <summary>
        /// The answer to go in slot 3
        /// </summary>
        public String Answer3 { get; private set; }
        
        /// <summary>
        /// The answer to go in slot 4
        /// </summary>
        public String Answer4 { get; private set; }
        
        /// <summary>
        /// This slot has the correct answer
        /// </summary>
        public int CorrectAnswer { get; private set; }

        /// <summary>
        /// Constructor of the question
        /// </summary>
        /// <param name="questionNr">To prevent duplicate questions</param>
        /// <param name="thequestion">Text of the question</param>
        /// <param name="answer1">First answer</param>
        /// <param name="answer2">Second answer</param>
        /// <param name="answer3">Third answer</param>
        /// <param name="answer4">Fourth answer</param>
        /// <param name="correctAnswer">Which answer is correct (1-4)</param>
        public Question(int questionNr, String thequestion, String answer1, String answer2, String answer3, String answer4, int correctAnswer)
        {
            QuestionNr = questionNr;
            QuestionText = thequestion;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            CorrectAnswer = correctAnswer;
        }
    }
}
