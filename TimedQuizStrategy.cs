/**************************************************************************
 *                                                                        *
 *  File:        TimedQuizStrategy.cs                                     *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Implements timed quiz behavior using a countdown timer.  *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

namespace ProiectQuiz
{
    /// <summary>
    /// Implements the strategy for a timed quiz session.
    /// Uses a countdown timer to limit the duration of the quiz.
    /// </summary>
    public class TimedQuizStrategy : IQuizStrategy
    {
        private QuizTimer _timer;
        private int _quizTime = 10;

        /// <summary>
        /// Initializes the quiz by attaching a timer and enabling the timer display.
        /// </summary>
        /// <param name="form">The quiz form that will observe and display the timer.</param>param> 
        public void InitializeQuiz(FormQuiz form)
        {
            _timer = new QuizTimer(_quizTime);
            _timer.AddObserver(form);
            form.ShowTimer(true);
        }

        /// <summary>
        /// Starts the quiz timer when the quiz begins.
        /// </summary>
        public void OnQuizStart()
        {
            _timer.Start();
        }

        /// <summary>
        /// Stops the countdown when the quiz ends or is intrrupted.
        /// </summary>
        public void OnQuizEnd()
        {
            _timer.Stop();
        }
    }
}
