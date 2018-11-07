using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Question
    {
        private String question;
        private String firstAnswer;
        private String secondAnswer;
        private String correctAnswer;

        // Overload constructor
        public Question(String q, String an1, String an2, String corAn)
        {
            question = q;
            firstAnswer = an1;
            secondAnswer = an2;
            correctAnswer = corAn;
        }

        // Get Methods
        public String getQuestion()
        {
            return question;
        }

        public String getFirstAnswer()
        {
            return firstAnswer;
        }

        public String getSecondAnswer()
        {
            return secondAnswer;
        }

        public String getCorrectAnswer()
        {
            return correctAnswer;
        }
        // End of Get Methods
    }
}
