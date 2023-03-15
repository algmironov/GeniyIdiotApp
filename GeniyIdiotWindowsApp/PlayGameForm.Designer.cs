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
            sendAnswerButton = new Button();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            questionNumberText = new Label();
            questionTextField = new Label();
            SuspendLayout();
            // 
            // sendAnswerButton
            // 
            sendAnswerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendAnswerButton.Location = new Point(27, 302);
            sendAnswerButton.Name = "sendAnswerButton";
            sendAnswerButton.Size = new Size(227, 53);
            sendAnswerButton.TabIndex = 0;
            sendAnswerButton.Text = "Ответить";
            sendAnswerButton.UseVisualStyleBackColor = true;
            sendAnswerButton.Click += sendAnswerButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 28);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            progressBar1.Value = 1;
            
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(33, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // questionNumberText
            // 
            questionNumberText.AutoSize = true;
            questionNumberText.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            questionNumberText.Location = new Point(33, 73);
            questionNumberText.Name = "questionNumberText";
            questionNumberText.Size = new Size(122, 25);
            questionNumberText.TabIndex = 3;
            questionNumberText.Text = "Вопрос №";
            questionNumberText.Click += label1_Click;
            // 
            // questionTextField
            // 
            questionTextField.AutoSize = true;
            questionTextField.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextField.Location = new Point(33, 142);
            questionTextField.Name = "questionTextField";
            questionTextField.Size = new Size(59, 23);
            questionTextField.TabIndex = 4;
            questionTextField.Text = "label2";
            // 
            // PlayGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(566, 442);
            Controls.Add(questionTextField);
            Controls.Add(questionNumberText);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label questionNumberText;
        private Label questionTextField;
    }
}