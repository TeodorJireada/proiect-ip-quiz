using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProiectQuiz
{
    public class QuestionLoader
    {

        public List<Question> Questions { get; set; }
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
