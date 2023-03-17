namespace GeniyIdiotWindowsApp
{
    partial class SettingsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            questionsCount = new Label();
            timeForQuestionTextBox = new TextBox();
            addQuestionButton = new Button();
            removeQuestionButton = new Button();
            saveSettingsButton = new Button();
            cancelButton = new Button();
            backButton = new Button();
            timeForOneQuestion = new Label();
            questionsCountTextBox = new TextBox();
            settingsLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.Controls.Add(questionsCount, 0, 0);
            tableLayoutPanel1.Controls.Add(timeForQuestionTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(addQuestionButton, 0, 2);
            tableLayoutPanel1.Controls.Add(removeQuestionButton, 1, 2);
            tableLayoutPanel1.Controls.Add(saveSettingsButton, 0, 3);
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 3);
            tableLayoutPanel1.Controls.Add(backButton, 2, 3);
            tableLayoutPanel1.Controls.Add(timeForOneQuestion, 0, 1);
            tableLayoutPanel1.Controls.Add(questionsCountTextBox, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Size = new Size(446, 224);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // questionsCount
            // 
            questionsCount.Anchor = AnchorStyles.Left;
            questionsCount.AutoSize = true;
            questionsCount.Location = new Point(3, 12);
            questionsCount.Name = "questionsCount";
            questionsCount.Size = new Size(131, 30);
            questionsCount.TabIndex = 0;
            questionsCount.Text = "Количество вопросов в игре";
            // 
            // timeForQuestionTextBox
            // 
            timeForQuestionTextBox.Anchor = AnchorStyles.Left;
            timeForQuestionTextBox.BorderStyle = BorderStyle.FixedSingle;
            timeForQuestionTextBox.Location = new Point(143, 66);
            timeForQuestionTextBox.Name = "timeForQuestionTextBox";
            timeForQuestionTextBox.Size = new Size(26, 23);
            timeForQuestionTextBox.TabIndex = 3;
            timeForQuestionTextBox.TextChanged += timeForQuestionTextBox_TextChanged;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Location = new Point(3, 103);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(134, 21);
            addQuestionButton.TabIndex = 4;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Location = new Point(143, 103);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(134, 21);
            removeQuestionButton.TabIndex = 5;
            removeQuestionButton.Text = "Удалить вопрос";
            removeQuestionButton.UseVisualStyleBackColor = true;
            removeQuestionButton.Click += removeQuestionButton_Click;
            // 
            // saveSettingsButton
            // 
            saveSettingsButton.Anchor = AnchorStyles.None;
            saveSettingsButton.Location = new Point(3, 164);
            saveSettingsButton.Name = "saveSettingsButton";
            saveSettingsButton.Size = new Size(134, 23);
            saveSettingsButton.TabIndex = 6;
            saveSettingsButton.Text = "Сохранить";
            saveSettingsButton.UseVisualStyleBackColor = true;
            saveSettingsButton.Click += saveSettingsButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(143, 164);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(134, 23);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Отменить изменения";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.None;
            backButton.Location = new Point(295, 164);
            backButton.Name = "backButton";
            backButton.Size = new Size(136, 23);
            backButton.TabIndex = 7;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // timeForOneQuestion
            // 
            timeForOneQuestion.Anchor = AnchorStyles.Left;
            timeForOneQuestion.AutoSize = true;
            timeForOneQuestion.Location = new Point(3, 70);
            timeForOneQuestion.Name = "timeForOneQuestion";
            timeForOneQuestion.Size = new Size(90, 15);
            timeForOneQuestion.TabIndex = 1;
            timeForOneQuestion.Text = "Время на ответ";
            // 
            // questionsCountTextBox
            // 
            questionsCountTextBox.Anchor = AnchorStyles.Left;
            questionsCountTextBox.BorderStyle = BorderStyle.FixedSingle;
            questionsCountTextBox.Location = new Point(143, 16);
            questionsCountTextBox.Name = "questionsCountTextBox";
            questionsCountTextBox.Size = new Size(26, 23);
            questionsCountTextBox.TabIndex = 2;
            questionsCountTextBox.TextChanged += questionsCountTextBox_TextChanged;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            settingsLabel.Location = new Point(164, 9);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(116, 30);
            settingsLabel.TabIndex = 1;
            settingsLabel.Text = "Настройки";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 291);
            Controls.Add(settingsLabel);
            Controls.Add(tableLayoutPanel1);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label questionsCount;
        private Label timeForOneQuestion;
        private TextBox questionsCountTextBox;
        private TextBox timeForQuestionTextBox;
        private Button addQuestionButton;
        private Button removeQuestionButton;
        private Button saveSettingsButton;
        private Button cancelButton;
        private Button backButton;
        private Label settingsLabel;
    }
}