namespace ProiectQuiz
{
    public interface ITimerObserver
    {
        void OnTimeUpdated(int timeLeft);
        void OnTimeExpired();
    }
}