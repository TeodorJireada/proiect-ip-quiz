namespace ProiectQuiz
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelProgressBar1 = new System.Windows.Forms.Label();
            this.labelProgressBar2 = new System.Windows.Forms.Label();
            this.labelProgressBar4 = new System.Windows.Forms.Label();
            this.labelProgressBar3 = new System.Windows.Forms.Label();
            this.labelProgressBar8 = new System.Windows.Forms.Label();
            this.labelProgressBar7 = new System.Windows.Forms.Label();
            this.labelProgressBar6 = new System.Windows.Forms.Label();
            this.labelProgressBar5 = new System.Windows.Forms.Label();
            this.labelProgressBar10 = new System.Windows.Forms.Label();
            this.labelProgressBar9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionText.Location = new System.Drawing.Point(174, 134);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(830, 175);
            this.labelQuestionText.TabIndex = 0;
            this.labelQuestionText.Text = "Întrebare";
            this.labelQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer1.Location = new System.Drawing.Point(261, 342);
            this.buttonAnswer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(300, 150);
            this.buttonAnswer1.TabIndex = 1;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer1_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer2.Location = new System.Drawing.Point(618, 342);
            this.buttonAnswer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(300, 150);
            this.buttonAnswer2.TabIndex = 2;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer3.Location = new System.Drawing.Point(261, 536);
            this.buttonAnswer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(300, 150);
            this.buttonAnswer3.TabIndex = 3;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer3_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer4.Location = new System.Drawing.Point(618, 536);
            this.buttonAnswer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(300, 150);
            this.buttonAnswer4.TabIndex = 4;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer4_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(47, 770);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(120, 50);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Ajutor";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(389, 77);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(400, 71);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Timer";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1011, 770);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 50);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Ieșire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelProgressBar1
            // 
            this.labelProgressBar1.AutoSize = true;
            this.labelProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar1.Location = new System.Drawing.Point(382, 724);
            this.labelProgressBar1.Name = "labelProgressBar1";
            this.labelProgressBar1.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar1.TabIndex = 8;
            this.labelProgressBar1.Text = "*";
            // 
            // labelProgressBar2
            // 
            this.labelProgressBar2.AutoSize = true;
            this.labelProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar2.Location = new System.Drawing.Point(424, 724);
            this.labelProgressBar2.Name = "labelProgressBar2";
            this.labelProgressBar2.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar2.TabIndex = 9;
            this.labelProgressBar2.Text = "*";
            // 
            // labelProgressBar4
            // 
            this.labelProgressBar4.AutoSize = true;
            this.labelProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar4.Location = new System.Drawing.Point(508, 724);
            this.labelProgressBar4.Name = "labelProgressBar4";
            this.labelProgressBar4.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar4.TabIndex = 11;
            this.labelProgressBar4.Text = "*";
            // 
            // labelProgressBar3
            // 
            this.labelProgressBar3.AutoSize = true;
            this.labelProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar3.Location = new System.Drawing.Point(466, 724);
            this.labelProgressBar3.Name = "labelProgressBar3";
            this.labelProgressBar3.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar3.TabIndex = 10;
            this.labelProgressBar3.Text = "*";
            // 
            // labelProgressBar8
            // 
            this.labelProgressBar8.AutoSize = true;
            this.labelProgressBar8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar8.Location = new System.Drawing.Point(676, 724);
            this.labelProgressBar8.Name = "labelProgressBar8";
            this.labelProgressBar8.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar8.TabIndex = 15;
            this.labelProgressBar8.Text = "*";
            // 
            // labelProgressBar7
            // 
            this.labelProgressBar7.AutoSize = true;
            this.labelProgressBar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar7.Location = new System.Drawing.Point(634, 724);
            this.labelProgressBar7.Name = "labelProgressBar7";
            this.labelProgressBar7.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar7.TabIndex = 14;
            this.labelProgressBar7.Text = "*";
            // 
            // labelProgressBar6
            // 
            this.labelProgressBar6.AutoSize = true;
            this.labelProgressBar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar6.Location = new System.Drawing.Point(592, 724);
            this.labelProgressBar6.Name = "labelProgressBar6";
            this.labelProgressBar6.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar6.TabIndex = 13;
            this.labelProgressBar6.Text = "*";
            // 
            // labelProgressBar5
            // 
            this.labelProgressBar5.AutoSize = true;
            this.labelProgressBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar5.Location = new System.Drawing.Point(550, 724);
            this.labelProgressBar5.Name = "labelProgressBar5";
            this.labelProgressBar5.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar5.TabIndex = 12;
            this.labelProgressBar5.Text = "*";
            // 
            // labelProgressBar10
            // 
            this.labelProgressBar10.AutoSize = true;
            this.labelProgressBar10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar10.Location = new System.Drawing.Point(760, 724);
            this.labelProgressBar10.Name = "labelProgressBar10";
            this.labelProgressBar10.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar10.TabIndex = 17;
            this.labelProgressBar10.Text = "*";
            // 
            // labelProgressBar9
            // 
            this.labelProgressBar9.AutoSize = true;
            this.labelProgressBar9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProgressBar9.Location = new System.Drawing.Point(718, 724);
            this.labelProgressBar9.Name = "labelProgressBar9";
            this.labelProgressBar9.Size = new System.Drawing.Size(36, 46);
            this.labelProgressBar9.TabIndex = 16;
            this.labelProgressBar9.Text = "*";
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.labelProgressBar10);
            this.Controls.Add(this.labelProgressBar9);
            this.Controls.Add(this.labelProgressBar8);
            this.Controls.Add(this.labelProgressBar7);
            this.Controls.Add(this.labelProgressBar6);
            this.Controls.Add(this.labelProgressBar5);
            this.Controls.Add(this.labelProgressBar4);
            this.Controls.Add(this.labelProgressBar3);
            this.Controls.Add(this.labelProgressBar2);
            this.Controls.Add(this.labelProgressBar1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Controls.Add(this.labelQuestionText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelProgressBar1;
        private System.Windows.Forms.Label labelProgressBar2;
        private System.Windows.Forms.Label labelProgressBar4;
        private System.Windows.Forms.Label labelProgressBar3;
        private System.Windows.Forms.Label labelProgressBar8;
        private System.Windows.Forms.Label labelProgressBar7;
        private System.Windows.Forms.Label labelProgressBar6;
        private System.Windows.Forms.Label labelProgressBar5;
        private System.Windows.Forms.Label labelProgressBar10;
        private System.Windows.Forms.Label labelProgressBar9;
    }
}