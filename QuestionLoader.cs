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
    public class QuestionLoader : IQuestionLoader
    {
        private readonly string _category;

        public QuestionLoader(string category)
        {
            _category = category;
        }

        public List<Question> GetQuestions()
        {
            try
            {
                string db = File.ReadAllText("intrebari.json");
                var allQuestionsByCategory = JsonConvert.DeserializeObject<Dictionary<string, List<Question>>>(db);

                if (allQuestionsByCategory.ContainsKey(_category))
                    return allQuestionsByCategory[_category];
            }
            catch (Exception ex)
            {

            }

            return new List<Question>();
        }
    }
}
