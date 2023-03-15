namespace GeniyIdiotWindowsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startGameButton = new Button();
            getResultsButton = new Button();
            addQuestionButton = new Button();
            deleteQuestionButton = new Button();
            welcomeLabel = new Label();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(331, 154);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(222, 23);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Начать игру";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += StartGameButton_Click;
            // 
            // getResultsButton
            // 
            getResultsButton.Location = new Point(331, 206);
            getResultsButton.Name = "getResultsButton";
            getResultsButton.Size = new Size(222, 23);
            getResultsButton.TabIndex = 1;
            getResultsButton.Text = "Смотреть результаты";
            getResultsButton.UseVisualStyleBackColor = true;
            getResultsButton.Click += getResultsButton_Click;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Location = new Point(331, 260);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(222, 23);
            addQuestionButton.TabIndex = 2;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Location = new Point(331, 315);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(222, 23);
            deleteQuestionButton.TabIndex = 3;
            deleteQuestionButton.Text = "Удалить вопрос";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(164, 83);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(550, 29);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Добро пожаловать в игру Гений Идиот";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 514);
            Controls.Add(welcomeLabel);
            Controls.Add(deleteQuestionButton);
            Controls.Add(addQuestionButton);
            Controls.Add(getResultsButton);
            Controls.Add(startGameButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений Идиот";
            FormClosed += MainForm_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameButton;
        private Button getResultsButton;
        private Button addQuestionButton;
        private Button deleteQuestionButton;
        private Label welcomeLabel;
    }
}