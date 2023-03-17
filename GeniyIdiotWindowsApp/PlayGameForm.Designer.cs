namespace GeniyIdiotWindowsApp
{
    partial class PlayGameForm
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
            components = new System.ComponentModel.Container();
            sendAnswerButton = new Button();
            progressBar1 = new ProgressBar();
            answerInputTextBox = new TextBox();
            questionNumberText = new Label();
            questionTextField = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // sendAnswerButton
            // 
            sendAnswerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendAnswerButton.Location = new Point(27, 226);
            sendAnswerButton.Name = "sendAnswerButton";
            sendAnswerButton.Size = new Size(227, 53);
            sendAnswerButton.TabIndex = 0;
            sendAnswerButton.Text = "Ответить";
            sendAnswerButton.UseVisualStyleBackColor = true;
            sendAnswerButton.Click += sendAnswerButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 29);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            progressBar1.Value = 1;
            // 
            // answerInputTextBox
            // 
            answerInputTextBox.BackColor = SystemColors.ControlLightLight;
            answerInputTextBox.BorderStyle = BorderStyle.FixedSingle;
            answerInputTextBox.Cursor = Cursors.IBeam;
            answerInputTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            answerInputTextBox.Location = new Point(27, 178);
            answerInputTextBox.Name = "answerInputTextBox";
            answerInputTextBox.PlaceholderText = "Введите число";
            answerInputTextBox.Size = new Size(221, 27);
            answerInputTextBox.TabIndex = 2;
            // 
            // questionNumberText
            // 
            questionNumberText.AutoSize = true;
            questionNumberText.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            questionNumberText.Location = new Point(27, 72);
            questionNumberText.Name = "questionNumberText";
            questionNumberText.Size = new Size(112, 25);
            questionNumberText.TabIndex = 3;
            questionNumberText.Text = "Вопрос №";
            questionNumberText.TextAlign = ContentAlignment.BottomLeft;
            // 
            // questionTextField
            // 
            questionTextField.AutoSize = true;
            questionTextField.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextField.Location = new Point(27, 128);
            questionTextField.Name = "questionTextField";
            questionTextField.Size = new Size(59, 23);
            questionTextField.TabIndex = 4;
            questionTextField.Text = "label2";
            questionTextField.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PlayGameForm
            // 
            AcceptButton = sendAnswerButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(566, 383);
            Controls.Add(questionTextField);
            Controls.Add(questionNumberText);
            Controls.Add(answerInputTextBox);
            Controls.Add(progressBar1);
            Controls.Add(sendAnswerButton);
            Name = "PlayGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendAnswerButton;
        private ProgressBar progressBar1;
        private TextBox answerInputTextBox;
        private Label questionNumberText;
        private Label questionTextField;
        private System.Windows.Forms.Timer timer;
    }
}