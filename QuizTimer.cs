using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectIP_quiz
{
    public class QuizTimer
    {
        private Timer _timer;
        private int _timeLeft;
        private List<ITimerObserver> _observers = new List<ITimerObserver>();
        
        public QuizTimer(int initialTime) 
        {
            _timeLeft = initialTime;
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            if (_timeLeft <= 0)
            {
                Stop();
                NotifyTimeExpired();
            }
            else
            {
                NotifyTimeUpdated();
            }
        }

        public void AddObserver(ITimerObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(ITimerObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Start()
        {
            _timer.Start();
            NotifyTimeUpdated();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void NotifyTimeUpdated()
        {
            foreach (var observer in _observers)
            {
                observer.OnTimeUpdated(_timeLeft);
            }
        }

        private void NotifyTimeExpired()
        {
            foreach (var observer in _observers)
            {
                observer.OnTimeExpired();
            }
        }
    }
}
