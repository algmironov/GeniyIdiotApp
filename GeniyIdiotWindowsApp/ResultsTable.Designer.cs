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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            labelText = new Label();
            dataGridView1 = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            correctAnswersCount = new DataGridViewTextBoxColumn();
            diagnose = new DataGridViewTextBoxColumn();
            backButton = new Button();
            resultsTableMenuBar = new MenuStrip();
            menu = new ToolStripMenuItem();
            очиститьТаблицуToolStripMenuItem = new ToolStripMenuItem();
            вернутьсяВГлавноеМенюToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзПриложенияToolStripMenuItem = new ToolStripMenuItem();
            removeLine = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            resultsTableMenuBar.SuspendLayout();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(42, 31);
            labelText.Name = "labelText";
            labelText.Size = new Size(232, 30);
            labelText.TabIndex = 0;
            labelText.Text = "Последние результаты";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, correctAnswersCount, diagnose });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(313, 358);
            dataGridView1.TabIndex = 2;
            // 
            // username
            // 
            username.HeaderText = "Имя";
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 56;
            // 
            // correctAnswersCount
            // 
            correctAnswersCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            correctAnswersCount.HeaderText = "Правильные ответы";
            correctAnswersCount.Name = "correctAnswersCount";
            correctAnswersCount.ReadOnly = true;
            correctAnswersCount.Width = 131;
            // 
            // diagnose
            // 
            diagnose.HeaderText = "Диагноз";
            diagnose.Name = "diagnose";
            diagnose.ReadOnly = true;
            diagnose.Width = 77;
            // 
            // backButton
            // 
            backButton.Location = new Point(165, 387);
            backButton.Name = "backButton";
            backButton.Size = new Size(136, 23);
            backButton.TabIndex = 3;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // resultsTableMenuBar
            // 
            resultsTableMenuBar.GripStyle = ToolStripGripStyle.Visible;
            resultsTableMenuBar.Items.AddRange(new ToolStripItem[] { menu });
            resultsTableMenuBar.Location = new Point(0, 0);
            resultsTableMenuBar.Name = "resultsTableMenuBar";
            resultsTableMenuBar.RenderMode = ToolStripRenderMode.System;
            resultsTableMenuBar.Size = new Size(313, 24);
            resultsTableMenuBar.TabIndex = 4;
            resultsTableMenuBar.Text = "menuStrip1";
            // 
            // menu
            // 
            menu.DropDownItems.AddRange(new ToolStripItem[] { очиститьТаблицуToolStripMenuItem, вернутьсяВГлавноеМенюToolStripMenuItem, выйтиИзПриложенияToolStripMenuItem });
            menu.Name = "menu";
            menu.Size = new Size(53, 20);
            menu.Text = "Меню";
            // 
            // очиститьТаблицуToolStripMenuItem
            // 
            очиститьТаблицуToolStripMenuItem.Name = "очиститьТаблицуToolStripMenuItem";
            очиститьТаблицуToolStripMenuItem.Size = new Size(221, 22);
            очиститьТаблицуToolStripMenuItem.Text = "Очистить таблицу";
            очиститьТаблицуToolStripMenuItem.Click += очиститьТаблицуToolStripMenuItem_Click;
            // 
            // вернутьсяВГлавноеМенюToolStripMenuItem
            // 
            вернутьсяВГлавноеМенюToolStripMenuItem.Name = "вернутьсяВГлавноеМенюToolStripMenuItem";
            вернутьсяВГлавноеМенюToolStripMenuItem.Size = new Size(221, 22);
            вернутьсяВГлавноеМенюToolStripMenuItem.Text = "Вернуться в главное меню";
            вернутьсяВГлавноеМенюToolStripMenuItem.Click += вернутьсяВГлавноеМенюToolStripMenuItem_Click;
            // 
            // выйтиИзПриложенияToolStripMenuItem
            // 
            выйтиИзПриложенияToolStripMenuItem.Name = "выйтиИзПриложенияToolStripMenuItem";
            выйтиИзПриложенияToolStripMenuItem.Size = new Size(221, 22);
            выйтиИзПриложенияToolStripMenuItem.Text = "Выйти из приложения";
            выйтиИзПриложенияToolStripMenuItem.Click += выйтиИзПриложенияToolStripMenuItem_Click;
            // 
            // removeLine
            // 
            removeLine.Location = new Point(12, 387);
            removeLine.Name = "removeLine";
            removeLine.Size = new Size(136, 23);
            removeLine.TabIndex = 5;
            removeLine.Text = "Удалить запись";
            removeLine.UseVisualStyleBackColor = true;
            removeLine.Click += removeLine_Click;
            // 
            // resultsTable1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(313, 422);
            Controls.Add(removeLine);
            Controls.Add(resultsTableMenuBar);
            Controls.Add(backButton);
            Controls.Add(dataGridView1);
            Controls.Add(labelText);
            MainMenuStrip = resultsTableMenuBar;
            Name = "resultsTable1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Таблица результатов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            resultsTableMenuBar.ResumeLayout(false);
            resultsTableMenuBar.PerformLayout();
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
        private MenuStrip resultsTableMenuBar;
        private ToolStripMenuItem menu;
        private ToolStripMenuItem очиститьТаблицуToolStripMenuItem;
        private ToolStripMenuItem вернутьсяВГлавноеМенюToolStripMenuItem;
        private ToolStripMenuItem выйтиИзПриложенияToolStripMenuItem;
        private Button removeLine;
    }
}