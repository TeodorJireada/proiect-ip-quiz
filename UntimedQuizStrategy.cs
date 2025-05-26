using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP_quiz
{
    public class UntimedQuizStrategy : IQuizStrategy
    {
        public void InitializeQuiz(FormQuiz form)
        {
            form.ShowTimer(false);
        }

        public void OnQuizStart() { }
        public void OnQuizEnd() { }
    }
}
