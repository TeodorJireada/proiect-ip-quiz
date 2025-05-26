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
    public partial class FormQuiz : Form, ITimerObserver
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private int _score = 0;
        
        private IQuizStrategy _quizStrategy;

        public FormQuiz(QuestionLoader questionLoader, bool isTimed)
        { 
            InitializeComponent();

            _questions = questionLoader.Questions;

            if (isTimed)
            {
                _quizStrategy = new TimedQuizStrategy();
            }
            else
            {
                _quizStrategy = new UntimedQuizStrategy();
            }

            _quizStrategy.InitializeQuiz(this);

            LoadQuestion(_currentQuestionIndex);
            _quizStrategy.OnQuizStart();
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

        public void ShowTimer(bool isTimed)
        {
            if (isTimed)
            {
                labelTimer.Show();
            }
            else
            {
                labelTimer.Hide();
            }
        }

        public void OnTimeUpdated(int timeLeft)
        {
            labelTimer.Text = $"{timeLeft}";
        }

        public void OnTimeExpired()
        {
            _quizStrategy.OnQuizEnd();
            ShowFinishForm(true);
        }
        public void ShowFinishForm(bool isTimeout)
        {
            FormFinishScreen formFinish = new FormFinishScreen(_score, isTimeout);
            formFinish.Show();
            this.Close();
        }

        private void CheckAnswer(int selectedIndex)
        { 
            var correctIndex = _questions[_currentQuestionIndex].AnswerIndex;

            if (selectedIndex == correctIndex)
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
                _quizStrategy.OnQuizEnd();
                ShowFinishForm(false);
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
