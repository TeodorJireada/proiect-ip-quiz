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
    /// <summary>
    /// Manages countdown timing for a timed quiz, notifying observers of time updates or expiration.
    /// </summary>
    public class QuizTimer
    {
        private Timer _timer;
        private int _timeLeft;
        private List<ITimerObserver> _observers = new List<ITimerObserver>();

        /// <summary>
        /// Initializes the quiz timer with a given starting time in seconds.
        /// </summary>
        /// <param name="initialTime">The number of seconds for the countdown.</param>
        public QuizTimer(int initialTime) 
        {
            _timeLeft = initialTime;
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Decrements the time and notifies observers of changes or expiration.
        /// </summary>
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

        /// <summary>
        /// Subscribes a component to receive timer updates.
        /// </summary>
        public void AddObserver(ITimerObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Removes a previously registered observer.
        /// </summary>
        public void RemoveObserver(ITimerObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Starts the countdown timer and notifies observers of the initial time.
        /// </summary>
        public void Start()
        {
            _timer.Start();
            NotifyTimeUpdated();
        }

        /// <summary>
        /// Stops the countdown timer, halting further updates.
        /// </summary>
        public void Stop()
        {
            _timer.Stop();
        }

        /// <summary>
        /// Notifies all obsertvers of the remaining time.
        /// </summary>
        private void NotifyTimeUpdated()
        {
            foreach (var observer in _observers)
            {
                observer.OnTimeUpdated(_timeLeft);
            }
        }

        /// <summary>
        /// Notifies all observers that the time has expired.
        /// </summary>
        private void NotifyTimeExpired()
        {
            foreach (var observer in _observers)
            {
                observer.OnTimeExpired();
            }
        }
    }
}
