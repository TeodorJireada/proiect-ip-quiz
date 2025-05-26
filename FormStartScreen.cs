using System;
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
            string category = comboBoxCategory.SelectedItem.ToString().ToLower();
            bool isTimed = checkBoxTimed.Checked;

            IQuestionLoader questionLoader;

            if (string.IsNullOrEmpty(category))
            {
                questionLoader = new NullQuestionLoader();
            }
            else
            {
                questionLoader = new QuestionLoader(category);
            }

            FormQuiz formQuiz = new FormQuiz(questionLoader, isTimed);
            formQuiz.Show();
            this.Hide();
        }
    }
}
