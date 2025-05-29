/**************************************************************************
 *                                                                        *
 *  File:        FormStartScreen.cs                                       *
 *  Copyright:   (c) 2025, J.Teodor  C.Dragos  E.Robert  R.Ioan           *
 *  E-mail:      teodor.jireada@student.tuiasi.ro                         *
 *  Description: Initializes and handles the quiz screen UI.              *
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

namespace ProiectQuiz
{
    public partial class FormStartScreen: Form
    {

        /// <summary>
        /// Initializes the start screen form.
        /// </summary>
        public FormStartScreen()
        {
            InitializeComponent();
            //Sets a default category to avoid null selection
            comboBoxCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the exit button click event to close the application.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        /// <summary>
        /// Displays help information.
        /// </summary>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Proiect.chm");
        }


        /// <summary>
        /// Starts the quiz using the selected category and timed option.
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                string category = comboBoxCategory.SelectedItem.ToString();
                bool isTimed = checkBoxTimed.Checked;

                QuestionLoader questionLoader = new QuestionLoader(category);

                FormQuiz formQuiz = new FormQuiz(questionLoader, isTimed);
                formQuiz.Show();
                this.Hide();

            } catch (Exception ex) {
                MessageBox.Show("Opțiune invalidă! Alege o opțiune din cele existente!");
                comboBoxCategory.SelectedIndex = 0;
            }
        } 
    }
}
