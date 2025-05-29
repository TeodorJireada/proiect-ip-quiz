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
