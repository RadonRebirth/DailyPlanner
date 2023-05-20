using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DailyPlanner
{
    public partial class StatisticsForm : Form
    {
        private SQLiteConnection connection;

        public StatisticsForm()
        {
            InitializeComponent();

            // Инициализация подключения к базе данных
            connection = new SQLiteConnection("Data Source=daily_planner.db;Version=3;");
            connection.Open();

            // Создание графика статистики
            CreateStatisticsChart();
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрытие подключения к базе данных при закрытии формы
            connection.Close();
        }

        private void CreateStatisticsChart()
        {
            // Создание графика
            Chart chart = new Chart();
            chart.Parent = this;
            chart.Size = new Size(400, 300);
            chart.Location = new Point(20, 20);

            // Создание области диаграммы
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Создание серии данных
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            chart.Series.Add(series);

            // Запрос к базе данных для получения статистики
            string query = "SELECT TaskDate, COUNT(*) AS TaskCount FROM Tasks GROUP BY TaskDate";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string taskDate = reader["TaskDate"].ToString();
                    int taskCount = Convert.ToInt32(reader["TaskCount"]);

                    // Добавление точки данных в серию
                    series.Points.AddXY(taskDate, taskCount);
                }
            }
        }
    }
}
