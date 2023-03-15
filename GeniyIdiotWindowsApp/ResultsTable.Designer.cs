namespace GeniyIdiotWindowsApp
{
    partial class resultsTable1
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
            labelText = new Label();
            dataGridView1 = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            correctAnswersCount = new DataGridViewTextBoxColumn();
            diagnose = new DataGridViewTextBoxColumn();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(43, 7);
            labelText.Name = "labelText";
            labelText.Size = new Size(232, 30);
            labelText.TabIndex = 0;
            labelText.Text = "Последние результаты";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, correctAnswersCount, diagnose });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(313, 380);
            dataGridView1.TabIndex = 2;
            // 
            // username
            // 
            username.HeaderText = "Имя";
            username.Name = "username";
            username.Width = 56;
            // 
            // correctAnswersCount
            // 
            correctAnswersCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            correctAnswersCount.HeaderText = "Правильные ответы";
            correctAnswersCount.Name = "correctAnswersCount";
            correctAnswersCount.Width = 131;
            // 
            // diagnose
            // 
            diagnose.HeaderText = "Диагноз";
            diagnose.Name = "diagnose";
            diagnose.Width = 77;
            // 
            // backButton
            // 
            backButton.Location = new Point(87, 387);
            backButton.Name = "backButton";
            backButton.Size = new Size(136, 23);
            backButton.TabIndex = 3;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // resultsTable1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(313, 422);
            Controls.Add(backButton);
            Controls.Add(dataGridView1);
            Controls.Add(labelText);
            Name = "resultsTable1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Таблица результатов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn correctAnswersCount;
        private DataGridViewTextBoxColumn diagnose;
        private Button backButton;
    }
}