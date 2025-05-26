namespace proiectIP_quiz
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionText.Location = new System.Drawing.Point(514, 181);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(144, 37);
            this.labelQuestionText.TabIndex = 0;
            this.labelQuestionText.Text = "Întrebare";
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Location = new System.Drawing.Point(235, 301);
            this.buttonAnswer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(300, 100);
            this.buttonAnswer1.TabIndex = 1;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer1_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Location = new System.Drawing.Point(628, 301);
            this.buttonAnswer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(300, 100);
            this.buttonAnswer2.TabIndex = 2;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Location = new System.Drawing.Point(235, 472);
            this.buttonAnswer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(300, 100);
            this.buttonAnswer3.TabIndex = 3;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer3_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Location = new System.Drawing.Point(628, 472);
            this.buttonAnswer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(300, 100);
            this.buttonAnswer4.TabIndex = 4;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer4_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(983, 764);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 22);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Ajutor";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(164, 200);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(48, 20);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Timer";
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Controls.Add(this.labelQuestionText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuiz";
            this.Text = "Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelTimer;
    }
}