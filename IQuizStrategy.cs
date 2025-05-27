namespace ProiectQuiz
{
    public interface IQuizStrategy
    {
        void InitializeQuiz(FormQuiz Form);
        void OnQuizStart();
        void OnQuizEnd();
    }
}
