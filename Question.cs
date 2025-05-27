using System.Collections.Generic;

namespace ProiectQuiz
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public int AnswerIndex { get; set; }
    }
}
