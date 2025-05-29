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
    public interface IQuizStrategy
    {
        void InitializeQuiz(FormQuiz Form);
        void OnQuizStart();
        void OnQuizEnd();
    }
}
