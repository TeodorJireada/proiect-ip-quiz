/**************************************************************************
 *                                                                        *
 *  File:        QuizTimer.cs                                             *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Manages countdown timing and notifies observers of time  *
 *               updates or expiration.                                   *  
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProiectQuiz
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
