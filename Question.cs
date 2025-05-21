using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP_quiz
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public int AnswerIndex { get; set; }
    }
}
