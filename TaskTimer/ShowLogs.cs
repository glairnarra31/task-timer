using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class ShowLogs : Form
    {
        public ShowLogs()
        {
            InitializeComponent();
            TasksDropdown.SelectedIndex = 0;
        }

        public int taskCounter = 0;

        private string ConnectionString = "datasource=localhost;port=3306;database=tasktimerdb;username=root;password=";

        [Description("MySql Connection String"), Category("DbConnectionString")]
        public string DbConnectionString
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }

        private string UserID = "";

        [Description("User ID"), Category("User ID")]
        public string SetUserID
        {
            get { return UserID; }
            set { UserID = value; }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLogs_Load(object sender, EventArgs e)
        {
            LoadTask();
            LoadAllLogs();
        }

        private void LoadTask()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM `tbl_tasks` WHERE `userID` = @userid ORDER BY `taskID` DESC;";
                        cmd.Parameters.AddWithValue("@userid", UserID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    TasksDropdown.Items.Add(reader["taskName"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllLogs()
        {
            TaskLogsTable.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT `tbl_tasks`.`userID`,`tbl_tasks`.`taskName`,`tbl_taskslog`.* FROM `tbl_taskslog` INNER JOIN `tbl_tasks` ON `tbl_taskslog`.`taskID` = `tbl_tasks`.`taskID` WHERE `tbl_tasks`.`userID` = @userid AND `tbl_taskslog`.`tasklogTime` IS NOT NULL AND `tbl_taskslog`.`timestampEnded` IS NOT NULL ORDER BY `tbl_taskslog`.`timestampEnded` DESC;";
                        cmd.Parameters.AddWithValue("@userid", UserID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    TaskLogsTable.Rows.Add(new[] { reader["taskName"].ToString(), reader["timestampStarted"].ToString(), reader["timestampEnded"].ToString(), reader["tasklogTime"].ToString() });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultNA()
        {
            DateTimeAddedLabel.Text = "N/A";
            LastUpdatedLabel.Text = "N/A";
            StatusLabel.Text = "N/A";
            TotalTimeLabel.Text = "N/A";
        }

        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {
            TaskLogsTable.Rows.Clear();
            if (TasksDropdown.SelectedIndex == 0)
            {
                try
                {
                    SetDefaultNA();
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT tbl_tasks.userID,tbl_tasks.taskName,tbl_taskslog.* FROM tbl_taskslog INNER JOIN tbl_tasks ON tbl_taskslog.taskID = tbl_tasks.taskID WHERE tbl_tasks.userID = @userid AND tbl_taskslog.tasklogTime IS NOT NULL AND tbl_taskslog.timestampEnded IS NOT NULL AND DATE(tbl_taskslog.`timestampStarted`) >= @fromdate AND DATE(tbl_taskslog.`timestampEnded`) <= @todate ORDER BY tbl_taskslog.timestampEnded DESC;";
                            cmd.Parameters.AddWithValue("@userid", UserID);
                            cmd.Parameters.AddWithValue("@fromdate", FromDateDrop.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@todate", ToDateDrop.Value.ToString("yyyy-MM-dd"));
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        TaskLogsTable.Rows.Add(new[] { reader["taskName"].ToString(), reader["timestampStarted"].ToString(), reader["timestampEnded"].ToString(), reader["tasklogTime"].ToString() });
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM tbl_tasks WHERE tbl_tasks.taskName = @taskname AND tbl_tasks.userID = @userid LIMIT 1;";
                            cmd.Parameters.AddWithValue("@userid", UserID);
                            cmd.Parameters.AddWithValue("@taskname", TasksDropdown.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        DateTimeAddedLabel.Text = reader["timestampAdded"].ToString();
                                        LastUpdatedLabel.Text = reader["timestampUpdated"].ToString();
                                        if (reader["isDone"].ToString() == "True")
                                        {
                                            StatusLabel.Text = "DONE";
                                        }
                                        else
                                        {
                                            StatusLabel.Text = "ON GOING";
                                        }
                                        TotalTimeLabel.Text = reader["totalTime"].ToString();
                                    }
                                }
                            }
                        }
                    }
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT tbl_tasks.userID,tbl_tasks.taskName,tbl_taskslog.* FROM tbl_taskslog INNER JOIN tbl_tasks ON tbl_taskslog.taskID = tbl_tasks.taskID WHERE tbl_tasks.userID = @userid AND tbl_taskslog.taskID = (SELECT tbl_tasks.taskID FROM tbl_tasks WHERE tbl_tasks.taskName = @taskname AND tbl_tasks.userID = @userid LIMIT 1) AND tbl_taskslog.tasklogTime IS NOT NULL AND tbl_taskslog.timestampEnded IS NOT NULL AND DATE(tbl_taskslog.`timestampStarted`) >= @fromdate AND DATE(tbl_taskslog.`timestampEnded`) <= @todate ORDER BY tbl_taskslog.timestampEnded DESC";
                            cmd.Parameters.AddWithValue("@userid", UserID);
                            cmd.Parameters.AddWithValue("@taskname", TasksDropdown.Text);
                            cmd.Parameters.AddWithValue("@fromdate", FromDateDrop.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@todate", ToDateDrop.Value.ToString("yyyy-MM-dd"));
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        TaskLogsTable.Rows.Add(new[] { reader["taskName"].ToString(), reader["timestampStarted"].ToString(), reader["timestampEnded"].ToString(), reader["tasklogTime"].ToString() });
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
