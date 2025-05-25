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
    public partial class FormFinish : Form
    {
        public FormFinish(int score, bool timeout)
        {
            InitializeComponent();

            if (timeout)
            {
                labelFinalScore.Text = "Nu ai răspuns la timp la întrebări";
            }
            else
            {
                labelFinalScore.Text = $"Felicitări! Scorul tău este: {score}";
            }
            
        }

        private void buttonPlayagain_Click(object sender, EventArgs e)
        {
            FormStartScreen formStartScreen = new FormStartScreen();
            formStartScreen.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelFinalScore_Click(object sender, EventArgs e)
        {

        }
    }
}
