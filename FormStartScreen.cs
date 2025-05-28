using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProiectQuiz
{
    public partial class FormStartScreen: Form
    {
        public FormStartScreen()
        {
            InitializeComponent();
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Proiect.chm");
        }

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
