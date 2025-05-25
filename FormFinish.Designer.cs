namespace proiectIP_quiz
{
    partial class FormFinish
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
            this.labelFinalMessage1 = new System.Windows.Forms.Label();
            this.labelFinalMessage2 = new System.Windows.Forms.Label();
            this.labelFinalScore = new System.Windows.Forms.Label();
            this.buttonPlayagain = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFinalMessage1
            // 
            this.labelFinalMessage1.AutoSize = true;
            this.labelFinalMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalMessage1.Location = new System.Drawing.Point(255, 196);
            this.labelFinalMessage1.Name = "labelFinalMessage1";
            this.labelFinalMessage1.Size = new System.Drawing.Size(289, 37);
            this.labelFinalMessage1.TabIndex = 0;
            this.labelFinalMessage1.Text = "Felicitări! Ai obținut";
            // 
            // labelFinalMessage2
            // 
            this.labelFinalMessage2.AutoSize = true;
            this.labelFinalMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalMessage2.Location = new System.Drawing.Point(695, 196);
            this.labelFinalMessage2.Name = "labelFinalMessage2";
            this.labelFinalMessage2.Size = new System.Drawing.Size(122, 37);
            this.labelFinalMessage2.TabIndex = 1;
            this.labelFinalMessage2.Text = "puncte!";
            // 
            // labelFinalScore
            // 
            this.labelFinalScore.AutoSize = true;
            this.labelFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalScore.Location = new System.Drawing.Point(589, 196);
            this.labelFinalScore.Name = "labelFinalScore";
            this.labelFinalScore.Size = new System.Drawing.Size(46, 37);
            this.labelFinalScore.TabIndex = 2;
            this.labelFinalScore.Text = "nr";
            // 
            // buttonPlayagain
            // 
            this.buttonPlayagain.Location = new System.Drawing.Point(483, 430);
            this.buttonPlayagain.Name = "buttonPlayagain";
            this.buttonPlayagain.Size = new System.Drawing.Size(181, 66);
            this.buttonPlayagain.TabIndex = 3;
            this.buttonPlayagain.Text = "Joacă din nou";
            this.buttonPlayagain.UseVisualStyleBackColor = true;
            this.buttonPlayagain.Click += new System.EventHandler(this.buttonPlayagain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(483, 582);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(181, 71);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Ieșire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayagain);
            this.Controls.Add(this.labelFinalScore);
            this.Controls.Add(this.labelFinalMessage2);
            this.Controls.Add(this.labelFinalMessage1);
            this.Name = "FormFinish";
            this.Text = "FormFinish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFinalMessage1;
        private System.Windows.Forms.Label labelFinalMessage2;
        private System.Windows.Forms.Label labelFinalScore;
        private System.Windows.Forms.Button buttonPlayagain;
        private System.Windows.Forms.Button buttonExit;
    }
}