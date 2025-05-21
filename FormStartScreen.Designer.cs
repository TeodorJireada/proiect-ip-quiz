namespace proiectIP_quiz
{
    partial class FormStartScreen
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
            this.labelStartScreenTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStartScreenDesc = new System.Windows.Forms.Label();
            this.labelStartScreenSelect = new System.Windows.Forms.Label();
            this.checkBoxTimed = new System.Windows.Forms.CheckBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStartScreenTitle
            // 
            this.labelStartScreenTitle.AutoSize = true;
            this.labelStartScreenTitle.Font = new System.Drawing.Font("Noto Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartScreenTitle.Location = new System.Drawing.Point(443, 54);
            this.labelStartScreenTitle.Name = "labelStartScreenTitle";
            this.labelStartScreenTitle.Size = new System.Drawing.Size(305, 73);
            this.labelStartScreenTitle.TabIndex = 0;
            this.labelStartScreenTitle.Text = "QUIZ GAME";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(504, 625);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(182, 54);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStartScreenDesc
            // 
            this.labelStartScreenDesc.AutoSize = true;
            this.labelStartScreenDesc.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartScreenDesc.Location = new System.Drawing.Point(478, 149);
            this.labelStartScreenDesc.Name = "labelStartScreenDesc";
            this.labelStartScreenDesc.Size = new System.Drawing.Size(235, 30);
            this.labelStartScreenDesc.TabIndex = 2;
            this.labelStartScreenDesc.Text = "Testează-ți cunoștințele!";
            this.labelStartScreenDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStartScreenSelect
            // 
            this.labelStartScreenSelect.AutoSize = true;
            this.labelStartScreenSelect.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartScreenSelect.Location = new System.Drawing.Point(478, 328);
            this.labelStartScreenSelect.Name = "labelStartScreenSelect";
            this.labelStartScreenSelect.Size = new System.Drawing.Size(108, 30);
            this.labelStartScreenSelect.TabIndex = 3;
            this.labelStartScreenSelect.Text = "Categorie:";
            // 
            // checkBoxTimed
            // 
            this.checkBoxTimed.AutoSize = true;
            this.checkBoxTimed.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTimed.Location = new System.Drawing.Point(495, 467);
            this.checkBoxTimed.Name = "checkBoxTimed";
            this.checkBoxTimed.Size = new System.Drawing.Size(201, 34);
            this.checkBoxTimed.TabIndex = 4;
            this.checkBoxTimed.Text = "Joacă contra timp";
            this.checkBoxTimed.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Matematică",
            "Programare",
            "Literatură",
            "Istorie"});
            this.comboBoxCategory.Location = new System.Drawing.Point(592, 331);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(52, 768);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(173, 47);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Ajutor";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(945, 768);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(203, 47);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Ieșire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.checkBoxTimed);
            this.Controls.Add(this.labelStartScreenSelect);
            this.Controls.Add(this.labelStartScreenDesc);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelStartScreenTitle);
            this.Name = "FormStartScreen";
            this.Text = "Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartScreenTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStartScreenDesc;
        private System.Windows.Forms.Label labelStartScreenSelect;
        private System.Windows.Forms.CheckBox checkBoxTimed;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
    }
}

