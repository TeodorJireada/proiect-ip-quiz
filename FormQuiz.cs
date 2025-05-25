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

        private Timer _questionTimer;
        private int _timeLeft = 120;

        public FormQuiz(string category, bool isTimed)
        {
            InitializeComponent();

            _category = category;
            _isTimed = isTimed;
            QuestionLoader ql = new QuestionLoader(_category);
            _questions = ql.Questions;

            // Ascundem timerul la început
            label1.Visible = false;

            if (_isTimed)
            {
                _questionTimer = new Timer();
                _questionTimer.Interval = 1000; // 1 secunda
                _questionTimer.Tick += QuestionTimer_Tick;
                label1.Visible = true;
                _timeLeft = 10;
                label1.Text = $"Timp ramas: {_timeLeft} sec.";
                _questionTimer.Start();
            }

            LoadQuestion(_currentQuestionIndex);
        }

        private void LoadQuestion(int index)
        {
            var q = _questions[index];

            labelQuestionText.Text = q.QuestionText;
            buttonAnswer1.Text = q.Options[0];
            buttonAnswer2.Text = q.Options[1];
            buttonAnswer3.Text = q.Options[2];
            buttonAnswer4.Text = q.Options[3];

           
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;

            if (_timeLeft <= 0)
            {
                _questionTimer.Stop();
                ShowFinishFormTimeout();
            }
            else
            {
                label1.Text = $"Timp rămas: {_timeLeft} sec.";
            }
        }

        private void CheckAnswer(int selectedIndex)
        {
           

            var correctIndex = _questions[_currentQuestionIndex].AnswerIndex;

            if (selectedIndex == correctIndex)
            {
                _score++;
            }

            NextQuestion();
        }

        private void NextQuestion()
        {
            _currentQuestionIndex++;

            if (_currentQuestionIndex < _questions.Count)
            {
                LoadQuestion(_currentQuestionIndex);
            }
            else
            {
                
                _questionTimer.Stop();
                FormFinish formFinish = new FormFinish(_score, false);
                formFinish.Show();
                this.Hide();
            }
        }

        private void ShowFinishFormTimeout()
        {
            FormFinish formFinish = new FormFinish(_score, true); // trecem true pentru timeout
            formFinish.Show();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
