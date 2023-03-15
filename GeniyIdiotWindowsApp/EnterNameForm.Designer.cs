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
            inputUsernameField.Location = new Point(84, 108);
            inputUsernameField.Name = "inputUsernameField";
            inputUsernameField.Size = new Size(148, 23);
            inputUsernameField.TabIndex = 1;
            inputUsernameField.KeyPress += EnterNameForm_KeyPress;
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
            // EnterNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(329, 316);
            Controls.Add(askingLaber);
            Controls.Add(inputUsernameField);
            Controls.Add(sendNameButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnterNameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Как Вас зовут?";
            Load += EnterNameForm_Load;
            KeyPress += EnterNameForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendNameButton;
        private TextBox inputUsernameField;
        private Label askingLaber;
    }
}