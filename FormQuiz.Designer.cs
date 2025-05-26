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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionText.Location = new System.Drawing.Point(457, 145);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(123, 31);
            this.labelQuestionText.TabIndex = 0;
            this.labelQuestionText.Text = "Întrebare";
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Location = new System.Drawing.Point(209, 241);
            this.buttonAnswer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(267, 80);
            this.buttonAnswer1.TabIndex = 1;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer1_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Location = new System.Drawing.Point(558, 241);
            this.buttonAnswer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(267, 80);
            this.buttonAnswer2.TabIndex = 2;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Location = new System.Drawing.Point(209, 378);
            this.buttonAnswer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(267, 80);
            this.buttonAnswer3.TabIndex = 3;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer3_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Location = new System.Drawing.Point(558, 378);
            this.buttonAnswer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(267, 80);
            this.buttonAnswer4.TabIndex = 4;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer4_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(874, 611);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(67, 18);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Ajutor";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 675);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}