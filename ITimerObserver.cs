/**************************************************************************
 *                                                                        *
 *  File:        ITimerObserver.cs                                        *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Defines methods for receiving timer updates and          *
 *               expiration events.                                       *
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
    /// Defines a contract for components that react to timer events in a quiz.
    /// </summary>
    public interface ITimerObserver
    {
        /// <summary>
        /// Called whenever the remaining time is updated.
        /// </summary>
        /// <param name="timeLeft">The number of seconds left in the quiz timer.</param>
        void OnTimeUpdated(int timeLeft);

        /// <summary>
        /// Called when the timer has expired and the quiz should end.
        /// </summary>
        void OnTimeExpired();
    }
}