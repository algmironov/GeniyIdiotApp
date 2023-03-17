namespace GeniyIdiotWindowsApp
{
    partial class EnterNameForm
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
            sendNameButton = new Button();
            inputUsernameField = new TextBox();
            askingLaber = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // sendNameButton
            // 
            sendNameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sendNameButton.ForeColor = SystemColors.Highlight;
            sendNameButton.Location = new Point(94, 149);
            sendNameButton.Name = "sendNameButton";
            sendNameButton.Size = new Size(129, 41);
            sendNameButton.TabIndex = 0;
            sendNameButton.Text = "Подтвердить";
            sendNameButton.UseVisualStyleBackColor = true;
            sendNameButton.Click += sendNameButton_Click;
            // 
            // inputUsernameField
            // 
            inputUsernameField.BackColor = SystemColors.Window;
            inputUsernameField.BorderStyle = BorderStyle.FixedSingle;
            inputUsernameField.CausesValidation = false;
            inputUsernameField.Cursor = Cursors.IBeam;
            inputUsernameField.HideSelection = false;
            inputUsernameField.Location = new Point(84, 108);
            inputUsernameField.Name = "inputUsernameField";
            inputUsernameField.Size = new Size(148, 23);
            inputUsernameField.TabIndex = 1;
            // 
            // askingLaber
            // 
            askingLaber.AutoSize = true;
            askingLaber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            askingLaber.Location = new Point(84, 69);
            askingLaber.Name = "askingLaber";
            askingLaber.Size = new Size(148, 19);
            askingLaber.TabIndex = 2;
            askingLaber.Text = "Введите Ваше имя:";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.Highlight;
            exitButton.Location = new Point(94, 205);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(129, 41);
            exitButton.TabIndex = 3;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // EnterNameForm
            // 
            AcceptButton = sendNameButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(329, 279);
            Controls.Add(exitButton);
            Controls.Add(askingLaber);
            Controls.Add(inputUsernameField);
            Controls.Add(sendNameButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnterNameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Как Вас зовут?";
            Load += EnterNameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendNameButton;
        private TextBox inputUsernameField;
        private Label askingLaber;
        private Button exitButton;
    }
}