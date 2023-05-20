using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация подключения к базе данных
            connection = new SQLiteConnection("Data Source=daily_planner.db;Version=3;");
            connection.Open();

            // Создание таблицы, если она не существует
            command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Tasks (TaskText TEXT, TaskDate TEXT)", connection);
            command.ExecuteNonQuery();

            // Загрузка записей из базы данных
            LoadTasks();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрытие подключения к базе данных при закрытии формы
            connection.Close();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string taskText = TaskTextBox.Text.Trim();
            string taskDate = TaskCalendar.SelectionStart.ToShortDateString();

            if (!string.IsNullOrEmpty(taskText))
            {
                // Добавление задачи в базу данных
                command = new SQLiteCommand("INSERT INTO Tasks (TaskText, TaskDate) VALUES (@taskText, @taskDate)", connection);
                command.Parameters.AddWithValue("@taskText", taskText);
                command.Parameters.AddWithValue("@taskDate", taskDate);
                command.ExecuteNonQuery();

                // Очистка полей ввода после добавления задачи
                TaskTextBox.Text = "";
                TaskCalendar.SetDate(DateTime.Today);

                // Загрузка обновленного списка задач
                LoadTasks();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Очистка списка задач и базы данных
            command = new SQLiteCommand("DELETE FROM Tasks", connection);
            command.ExecuteNonQuery();

            // Загрузка пустого списка задач
            LoadTasks();
        }

        private void LoadTasks()
        {
            // Загрузка задач из базы данных
            command = new SQLiteCommand("SELECT TaskText, TaskDate FROM Tasks", connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                TaskListBox.Items.Clear();

                while (reader.Read())
                {
                    string taskText = reader["TaskText"].ToString();
                    string taskDate = reader["TaskDate"].ToString();
                    TaskListBox.Items.Add($"Дата: {taskDate} Задача: {taskText}");
                }
            }
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }
    }
}
