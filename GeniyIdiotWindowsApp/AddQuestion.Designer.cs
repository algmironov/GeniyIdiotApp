namespace GeniyIdiotWindowsApp
{
    partial class AddQuestion
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
            questionTextBox = new RichTextBox();
            exitButton = new Button();
            clearButton = new Button();
            saveButton = new Button();
            answerTextBox = new TextBox();
            addQuestionLabel = new Label();
            inputTextLabel = new Label();
            inputAnswerLabel = new Label();
            SuspendLayout();
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new Point(12, 113);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(400, 96);
            questionTextBox.TabIndex = 0;
            questionTextBox.Text = "";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(289, 299);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(123, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(12, 299);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(114, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Сбросить";
            clearButton.TextAlign = ContentAlignment.TopCenter;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(145, 299);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(128, 23);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(12, 254);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(183, 23);
            answerTextBox.TabIndex = 4;
            // 
            // addQuestionLabel
            // 
            addQuestionLabel.AutoSize = true;
            addQuestionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addQuestionLabel.Location = new Point(55, 22);
            addQuestionLabel.Name = "addQuestionLabel";
            addQuestionLabel.Size = new Size(309, 30);
            addQuestionLabel.TabIndex = 5;
            addQuestionLabel.Text = "Добавление нового вопроса";
            // 
            // inputTextLabel
            // 
            inputTextLabel.AutoSize = true;
            inputTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputTextLabel.Location = new Point(12, 80);
            inputTextLabel.Name = "inputTextLabel";
            inputTextLabel.Size = new Size(175, 21);
            inputTextLabel.TabIndex = 6;
            inputTextLabel.Text = "Введите текст вопроса:";
            // 
            // inputAnswerLabel
            // 
            inputAnswerLabel.AutoSize = true;
            inputAnswerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputAnswerLabel.Location = new Point(12, 230);
            inputAnswerLabel.Name = "inputAnswerLabel";
            inputAnswerLabel.Size = new Size(114, 21);
            inputAnswerLabel.TabIndex = 7;
            inputAnswerLabel.Text = "Введите ответ:";
            inputAnswerLabel.MouseClick += inputAnswerLabel_MouseClick;
            // 
            // AddQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 336);
            Controls.Add(inputAnswerLabel);
            Controls.Add(inputTextLabel);
            Controls.Add(addQuestionLabel);
            Controls.Add(answerTextBox);
            Controls.Add(saveButton);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(questionTextBox);
            Name = "AddQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox questionTextBox;
        private Button exitButton;
        private Button clearButton;
        private Button saveButton;
        private TextBox answerTextBox;
        private Label addQuestionLabel;
        private Label inputTextLabel;
        private Label inputAnswerLabel;
    }
}