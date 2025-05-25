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
        public FormFinish(int score)
        {
            InitializeComponent();

            labelFinalScore.Text = score.ToString();
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
    }
}
