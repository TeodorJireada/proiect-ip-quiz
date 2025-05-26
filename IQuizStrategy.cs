using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP_quiz
{
    public interface IQuizStrategy
    {
        void InitializeQuiz(FormQuiz Form);
        void OnQuizStart();
        void OnQuizEnd();
    }
}
