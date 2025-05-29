/**************************************************************************
 *                                                                        *
 *  File:        Question.cs                                              *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Represents a quiz question with text, answer options and *
 *               the correct answer index.                                *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System.Collections.Generic;

namespace ProiectQuiz
{
    /// <summary>
    /// Represents a quiz section, including its text, answer options, and the index of the correct answer.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// The text of the question presented to the user.
        /// </summary>
        public string QuestionText { get; set; }

        /// <summary>
        /// A list of possible answer options. Assumes exactly four options.
        /// </summary>
        public List<string> Options { get; set; }

        /// <summary>
        /// The index of the correct answer within the Options list.
        /// </summary>
        public int AnswerIndex { get; set; }
    }
}
