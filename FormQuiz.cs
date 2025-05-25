using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectIP_quiz
{
    public partial class FormQuiz : Form
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private bool _isTimed;
        private string _category;
        private int _score = 0;

        public FormQuiz(string category, bool isTimed)
        {
            InitializeComponent();

            _category = category;
            _isTimed = isTimed;
            QuestionLoader ql = new QuestionLoader(_category);
            _questions = ql.Questions;

            LoadQuestion(_currentQuestionIndex);
        }

        private void LoadQuestion(int index)
        {
            //if (index < 0 || index >= _questions.Count) return;

            var q = _questions[index];

            labelQuestionText.Text = q.QuestionText;
            buttonAnswer1.Text = q.Options[0];
            buttonAnswer2.Text = q.Options[1];
            buttonAnswer3.Text = q.Options[2];
            buttonAnswer4.Text = q.Options[3];
        }

        private void CheckAnswer(int selectedIndex)
        {
            var correctIndex = _questions[_currentQuestionIndex].AnswerIndex;

            if(selectedIndex == correctIndex)
            {
                _score++;
            }

            _currentQuestionIndex++;

            if(_currentQuestionIndex < _questions.Count)
            {
                LoadQuestion(_currentQuestionIndex);
            }
            else
            {
                FormFinish formFinish = new FormFinish(_score);
                formFinish.Show();
                this.Hide();
            }
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }
    }
}
