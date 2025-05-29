/**************************************************************************
 *                                                                        *
 *  File:        FormQuiz.cs                                              *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Manages quiz logic, user interaction, and progress       *
 *               tracking during the quiz.                                *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace ProiectQuiz
{
    public partial class FormQuiz : Form, ITimerObserver
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private int _score = 0;
        private Label[] _progressBar;
        private List<bool> _progressHistory = new List<bool>();

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

            _progressBar = new Label[]
            {
                labelProgressBar1, labelProgressBar2, labelProgressBar3, labelProgressBar4, labelProgressBar5,
                labelProgressBar6, labelProgressBar7, labelProgressBar8, labelProgressBar9, labelProgressBar10
            };
            _progressBar[_currentQuestionIndex].ForeColor = Color.Black;
        }

        private void UpdateProgressBar()
        {
            for(int i = 0; i<_progressHistory.Count; i++)
            {
                _progressBar[i].ForeColor = _progressHistory[i] ? Color.Green : Color.Red;
            }
            _progressBar[_currentQuestionIndex].ForeColor = Color.Black;
        }
        private void LoadQuestion(int index)
        {
            var q = _questions[index];

            labelQuestionText.Text = $"{_currentQuestionIndex+1}. {q.QuestionText}";
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
            labelTimer.Text = $"Timp rămas: {timeLeft}";
            if (timeLeft < 10)
            {
                labelTimer.ForeColor = Color.Red;
            } 
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
                _progressHistory.Add(true);
            }
            else
            {   
                _progressHistory.Add(false);
            }

            _currentQuestionIndex++;

            if(_currentQuestionIndex < _questions.Count)
            {
                LoadQuestion(_currentQuestionIndex);
                UpdateProgressBar();
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //TODO help
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
