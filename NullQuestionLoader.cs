using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP_quiz
{
    public class NullQuestionLoader : IQuestionLoader
        {
        public List<Question> GetQuestions()
        {
            return new List<Question>()
            {
                new Question {
                    QuestionText = "Nu există întrebări disponibile pentru această categorie.",
                    Options = new List<string> { "-", "-", "-", "-" },
                    AnswerIndex = 0
                }
            };
        }
    }
}
