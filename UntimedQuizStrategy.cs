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
    public class UntimedQuizStrategy : IQuizStrategy
    {
        public void InitializeQuiz(FormQuiz form)
        {
            form.ShowTimer(false);
        }

        public void OnQuizStart() { }
        public void OnQuizEnd() { }
    }
}
