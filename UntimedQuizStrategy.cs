/**************************************************************************
 *                                                                        *
 *  File:        UntimedQuizStrategy.cs                                   *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Implements untimed quiz behavior without timer           *
 *               functionality.                                           *
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
    /// Implements the strategy for a quiz session without a timer.
    /// Keeps the quiz focused on content rather than speed.
    /// </summary>
    public class UntimedQuizStrategy : IQuizStrategy
    {
        /// <summary>
        /// Hides the timer since timing is not relevant for this mode.
        /// </summary>
        /// <param name="form"> The quiz form to update UI accordingly.</param>
        public void InitializeQuiz(FormQuiz form)
        {
            form.ShowTimer(false);
        }

        /// <summary>
        /// No special setup needed at the start of an untimed quiz.
        /// </summary>
        public void OnQuizStart() { }

        /// <summary>
        /// No cleanup needed when ending an untimed quiz.
        /// </summary>
        public void OnQuizEnd() { }
    }
}
