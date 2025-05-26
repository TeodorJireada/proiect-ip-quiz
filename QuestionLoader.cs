using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proiectIP_quiz
{
    public class QuestionLoader
    {

        public List<Question> Questions { get; set; }
        public QuestionLoader(string category)
        {
            string db = File.ReadAllText("intrebari.json");
            var allQuestionsByCategory = JsonConvert.DeserializeObject<Dictionary<string, List<Question>>>(db);
            Questions = allQuestionsByCategory[category];
        }
    }
}
