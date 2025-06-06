﻿/**************************************************************************
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
    /// <summary>
    /// The main form that runs the quiz.
    /// </summary>
    public partial class FormQuiz : Form, ITimerObserver
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private int _score = 0;
        private Label[] _progressBar;
        private List<bool> _progressHistory = new List<bool>();

        private IQuizStrategy _quizStrategy;

        /// <summary>
        /// Initializes the quiz form with questions and quiz strategy.
        /// </summary>
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
            _quizStrategy.OnQuizStart();

            LoadQuestion(_currentQuestionIndex);

            _progressBar = new Label[]
            {
                labelProgressBar1, labelProgressBar2, labelProgressBar3, labelProgressBar4, labelProgressBar5,
                labelProgressBar6, labelProgressBar7, labelProgressBar8, labelProgressBar9, labelProgressBar10
            };
            _progressBar[_currentQuestionIndex].ForeColor = Color.Black;
        }

        /// <summary>
        /// Updates the progress bar colors based on the user's answers.
        /// </summary>
        private void UpdateProgressBar()
        {
            for(int i = 0; i<_progressHistory.Count; i++)
            {
                _progressBar[i].ForeColor = _progressHistory[i] ? Color.Green : Color.Red;
            }
            _progressBar[_currentQuestionIndex].ForeColor = Color.Black;
        }

        /// <summary>
        /// Loads the current question and polulates the UI with options.
        /// </summary>
        private void LoadQuestion(int index)
        {
            var q = _questions[index];

            labelQuestionText.Text = $"{_currentQuestionIndex+1}. {q.QuestionText}";
            buttonAnswer1.Text = q.Options[0];
            buttonAnswer2.Text = q.Options[1];
            buttonAnswer3.Text = q.Options[2];
            buttonAnswer4.Text = q.Options[3];   
        }

        /// <summary>
        /// Controls whether the timer label is displayed based on the quiz type.
        /// </summary>
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

        /// <summary>
        /// Updates the countdown timer display and changes color if time is low.
        /// </summary>
        public void OnTimeUpdated(int timeLeft)
        {
            labelTimer.Text = $"Timp rămas: {timeLeft}";
            if (timeLeft < 10)
            {
                labelTimer.ForeColor = Color.Red;
            } 
        }

        /// <summary>
        /// Handles the event when time has expired.
        /// </summary>
        public void OnTimeExpired()
        {
            _quizStrategy.OnQuizEnd();
            ShowFinishForm(true);
        }

        /// <summary>
        /// Displays the finish screen with final results.
        /// </summary>
        public void ShowFinishForm(bool isTimeout)
        {
            FormFinishScreen formFinish = new FormFinishScreen(_score, isTimeout);
            formFinish.Show();
            this.Close();
        }

        /// <summary>
        /// Evaluates the user's answer and updates progress.
        /// </summary>
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

        /// <summary>
        /// Answer button 1 click event handler.
        /// </summary>
        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        /// <summary>
        /// Answer button 2 click event handler.
        /// </summary>
        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        /// <summary>
        /// Answer button 3 click event handler.
        /// </summary>
        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        /// <summary>
        /// Answer button 4 click event handler.
        /// </summary>
        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        /// <summary>
        /// Help button click placeholder.
        /// </summary>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Proiect.chm");
        }

        /// <summary>
        /// Exits the quiz from the active form.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
