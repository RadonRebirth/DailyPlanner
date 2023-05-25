namespace DailyPlanner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddTaskButton = new Button();
            ClearButton = new Button();
            statisticsButton = new Button();
            dailyEntryBindingSource = new BindingSource(components);
            Планы = new DataGridViewTextBoxColumn();
            TaskListBox = new ListBox();
            TaskTextBox = new TextBox();
            TaskCalendar = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)dailyEntryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddTaskButton
            // 
            AddTaskButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.Location = new Point(89, 382);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(132, 34);
            AddTaskButton.TabIndex = 2;
            AddTaskButton.Text = "Добавить";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(227, 382);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(123, 34);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // statisticsButton
            // 
            statisticsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statisticsButton.Location = new Point(356, 382);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(136, 34);
            statisticsButton.TabIndex = 5;
            statisticsButton.Text = "Статистика";
            statisticsButton.UseVisualStyleBackColor = true;
            statisticsButton.Click += StatisticsButton_Click;
            // 
            // Планы
            // 
            Планы.HeaderText = "Column1";
            Планы.Name = "Планы";
            // 
            // TaskListBox
            // 
            TaskListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskListBox.FormattingEnabled = true;
            TaskListBox.ItemHeight = 21;
            TaskListBox.Location = new Point(89, 109);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(342, 214);
            TaskListBox.TabIndex = 6;
            // 
            // TaskTextBox
            // 
            TaskTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTextBox.Location = new Point(89, 347);
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.PlaceholderText = "Введите текст";
            TaskTextBox.Size = new Size(261, 29);
            TaskTextBox.TabIndex = 7;
            // 
            // TaskCalendar
            // 
            TaskCalendar.Location = new Point(454, 161);
            TaskCalendar.Name = "TaskCalendar";
            TaskCalendar.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(806, 450);
            Controls.Add(TaskCalendar);
            Controls.Add(TaskTextBox);
            Controls.Add(TaskListBox);
            Controls.Add(statisticsButton);
            Controls.Add(ClearButton);
            Controls.Add(AddTaskButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "DailyPlanner";
            ((System.ComponentModel.ISupportInitialize)dailyEntryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ListBox actionListBox;
        private Button AddTaskButton;
        private Button ClearButton;
        private Button button3;
        private TextBox actionTextBox;
        private Button statisticsButton;
        private DataGridViewTextBoxColumn Планы;
        private BindingSource dailyEntryBindingSource;
        private ListBox TaskListBox;
        private TextBox TaskTextBox;
        private MonthCalendar TaskCalendar;
    }
}