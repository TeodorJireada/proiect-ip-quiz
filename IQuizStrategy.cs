/**************************************************************************
 *                                                                        *
 *  File:        IQuizStrategy.cs                                         *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Defines the strategy interface for quiz initialization   *
 *               and lifecycle control.                                   *
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
    /// Defines a strategy interface for quiz behavior customization.
    /// Enables extending quiz logic without modifying the core form.
    /// </summary>
    public interface IQuizStrategy
    {
        /// <summary>
        /// Prepares the quiz form with necessary data and settings.
        /// </summary>
        /// <param name="form">The main quiz form will use this strategy.</param>
        void InitializeQuiz(FormQuiz form);

        /// <summary>
        /// Called when the quiz starts; used to trigger time or setup logic.
        /// </summary>
        void OnQuizStart();
        /// <summary>
        /// Called when the quiz ends; used to clean up or finalize logic.
        /// </summary>
        void OnQuizEnd();
    }
}
