namespace ProiectQuiz
{
    public class TimedQuizStrategy : IQuizStrategy
    {
        private QuizTimer _timer;
        private int _quizTime = 10;

        public void InitializeQuiz(FormQuiz form)
        {
            _timer = new QuizTimer(_quizTime);
            _timer.AddObserver(form);
            form.ShowTimer(true);
        }

        public void OnQuizStart()
        {
            _timer.Start();
        }

        public void OnQuizEnd()
        {
            _timer.Stop();
        }
    }
}
