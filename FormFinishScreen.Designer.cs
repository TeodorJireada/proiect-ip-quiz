namespace proiectIP_quiz
{
    partial class FormFinishScreen
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
            this.buttonPlayagain = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFinalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlayagain
            // 
            this.buttonPlayagain.Location = new System.Drawing.Point(429, 344);
            this.buttonPlayagain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlayagain.Name = "buttonPlayagain";
            this.buttonPlayagain.Size = new System.Drawing.Size(161, 53);
            this.buttonPlayagain.TabIndex = 3;
            this.buttonPlayagain.Text = "Joacă din nou";
            this.buttonPlayagain.UseVisualStyleBackColor = true;
            this.buttonPlayagain.Click += new System.EventHandler(this.buttonPlayagain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(429, 466);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 57);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Ieșire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFinalScore
            // 
            this.labelFinalScore.AutoSize = true;
            this.labelFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalScore.Location = new System.Drawing.Point(336, 221);
            this.labelFinalScore.Name = "labelFinalScore";
            this.labelFinalScore.Size = new System.Drawing.Size(108, 32);
            this.labelFinalScore.TabIndex = 5;
            this.labelFinalScore.Text = "rezultat";
            // 
            // FormFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 675);
            this.Controls.Add(this.labelFinalScore);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayagain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFinish";
            this.Text = "FormFinish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlayagain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFinalScore;
    }
}