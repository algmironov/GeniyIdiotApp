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
            welcomeLabel = new Label();
            settingsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(224, 167);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(222, 23);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Начать игру";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += StartGameButton_Click;
            // 
            // getResultsButton
            // 
            getResultsButton.Location = new Point(224, 196);
            getResultsButton.Name = "getResultsButton";
            getResultsButton.Size = new Size(222, 23);
            getResultsButton.TabIndex = 1;
            getResultsButton.Text = "Смотреть результаты";
            getResultsButton.UseVisualStyleBackColor = true;
            getResultsButton.Click += getResultsButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(39, 72);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(637, 29);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Добро пожаловать в игру \"Гений или Идиот\"";
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(224, 225);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(222, 23);
            settingsButton.TabIndex = 5;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(224, 254);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(222, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 345);
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(welcomeLabel);
            Controls.Add(getResultsButton);
            Controls.Add(startGameButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений или Идиот";
            FormClosed += MainForm_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameButton;
        private Button getResultsButton;
        private Label welcomeLabel;
        private Button settingsButton;
        private Button exitButton;
    }
}