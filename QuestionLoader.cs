/**************************************************************************
 *                                                                        *
 *  File:        QuestionLoader.cs                                        *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Loads and randomizes quiz questions.                     *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProiectQuiz
{
    /// <summary>
    /// Loads and prepares a set of quiz questions from a JSON file based on the selected category.
    /// </summary>
    public class QuestionLoader
    {
        /// <summary>
        /// The list of questions prepared for the current quiz session.
        /// </summary>
        public List<Question> Questions { get; set; }

        /// <summary>
        /// Loads questions, shuffles them, and selects a fixed number for use.
        /// </summary>
        public QuestionLoader(string category)
        {
            string db = File.ReadAllText("intrebari.json");
            var allQuestionsByCategory = JsonConvert.DeserializeObject<Dictionary<string, List<Question>>>(db);
            
            var catQuestions = allQuestionsByCategory[category];
            var rand = new Random();
            catQuestions = catQuestions.OrderBy(q => rand.Next()).ToList();

            Questions = catQuestions.Take(10).ToList();
        }
    }
}
