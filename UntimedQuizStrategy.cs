namespace ProiectQuiz
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
