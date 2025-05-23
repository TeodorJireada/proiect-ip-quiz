﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectIP_quiz
{
    public partial class FormStartScreen: Form
    {
        public FormStartScreen()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Despre aplicație");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategory.SelectedItem.ToString();
            bool isTimed = checkBoxTimed.Checked;

            FormQuiz formQuiz = new FormQuiz(category, isTimed);
            formQuiz.Show();
            this.Hide();
        }
    }
}
