/**************************************************************************
 *                                                                        *
 *  File:        FormFinishScreen.cs                                      *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Displays the final quiz score and options to exit or     *
 *               restart the quiz.                                        *
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
using System.ComponentModel;
using System.Windows.Forms;

namespace ProiectQuiz
{
    /// <summary>
    /// Displays the final score and message based on user performance or timeout.
    /// </summary>
    public partial class FormFinishScreen : Form
    {
        /// <summary>
        /// Initializes the finish screen and presents a message based on quiz outcome.
        /// </summary>
        /// <param name="score">Final score achieved by the user.</param>
        /// <param name="timeout">Indicates if the quiz ended due to timeout.</param>
        public FormFinishScreen(int score, bool timeout)
        {
            InitializeComponent();

            if (timeout)
            {
                labelFinalScore.Text = $"Timpul s-a scurs!\n Scor: {score}/10";
            }
            else
            {
                if(score < 5)
                {
                    labelFinalScore.Text = $"Oof... Poți mai mult!\n Scor: {score}/10";
                }
                else if(score < 8)
                { 
                    labelFinalScore.Text = $"Bine! Te descurci!\nScor: {score}";
                }
                else if(score < 10)
                {
                    labelFinalScore.Text = $"Felicitări!\nScor: {score}";
                }
                else
                {
                    labelFinalScore.Text = $"UAU! Ești cel mai bun!\nScor: {score}";
                }
            }
        }


        /// <summary>
        /// Handles the exit button click by closing the application.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the play again button click by restarting from the start screen.
        /// </summary>
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            FormStartScreen formStartScreen = new FormStartScreen();
            formStartScreen.Show();
            this.Close();
        }
    }
}
