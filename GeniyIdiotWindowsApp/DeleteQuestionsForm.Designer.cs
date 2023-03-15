namespace GeniyIdiotWindowsApp
{
    partial class DeleteQuestionsForm
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
            questionsList = new CheckedListBox();
            exitButton = new Button();
            removeButton = new Button();
            deleteQuestionsLabel = new Label();
            SuspendLayout();
            // 
            // questionsList
            // 
            questionsList.FormattingEnabled = true;
            questionsList.Location = new Point(2, 63);
            questionsList.Name = "questionsList";
            questionsList.Size = new Size(659, 490);
            questionsList.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(518, 580);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(133, 40);
            exitButton.TabIndex = 1;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.Location = new Point(366, 580);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(134, 40);
            removeButton.TabIndex = 2;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // deleteQuestionsLabel
            // 
            deleteQuestionsLabel.AutoSize = true;
            deleteQuestionsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteQuestionsLabel.Location = new Point(2, 18);
            deleteQuestionsLabel.Name = "deleteQuestionsLabel";
            deleteQuestionsLabel.Size = new Size(466, 30);
            deleteQuestionsLabel.TabIndex = 3;
            deleteQuestionsLabel.Text = "Выберите вопрос, который хотите удалить:";
            // 
            // DeleteQuestionsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(663, 641);
            Controls.Add(deleteQuestionsLabel);
            Controls.Add(removeButton);
            Controls.Add(exitButton);
            Controls.Add(questionsList);
            MaximizeBox = false;
            Name = "DeleteQuestionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteQuestionsForm";
            Load += DeleteQuestionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox questionsList;
        private Button exitButton;
        private Button removeButton;
        private Label deleteQuestionsLabel;
    }
}