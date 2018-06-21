using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace TaskTimer
{
    public partial class TaskMonitor : UserControl
    {
        public int taskCounter = 0;

        private string ConnectionString = "datasource=localhost;port=3306;database=tasktimerdb;username=root;password=";

        [Description("MySql Connection String"), Category("DbConnectionString")]
        public string DbConnectionString
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }

        public TaskMonitor()
        {
            InitializeComponent();
        }       

        internal string SetUserID
        {
            set { SetUser.Text = value; }
        }

        private void DynamicCreateTask(string rowtoname, string texttodisplay, string isHaveSavedID = "", string elapsedTime = "00:00:00")
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Edit", new EventHandler(Edit_Click));
            cm.MenuItems.Add("Delete", new EventHandler(Delete_Click));

            var TaskLabel = new System.Windows.Forms.Label()
            {
                Name = "TaskName" + rowtoname,
                Text = texttodisplay,
                Tag = isHaveSavedID,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Century Gothic", 11, FontStyle.Regular),
                BackColor = System.Drawing.Color.FromArgb(8, 11, 46),
                Cursor =  Cursors.Default,
                Anchor = AnchorStyles.Left,
                AutoSize = true
            };
            TaskLabel.ContextMenu = cm;
            //TaskLabel.Click += TaskLabel_Click;

            var TimerLabel = new System.Windows.Forms.Label()
            {
                Name = "TimerLabel" + rowtoname,
                Text = elapsedTime,
                Tag = elapsedTime,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Century Gothic", 10, FontStyle.Regular),
                BackColor = System.Drawing.Color.FromArgb(8, 11, 46),
                Cursor = Cursors.Default,
                Anchor = AnchorStyles.None,
                AutoSize = true
            };

            var PlayPauseButton = new Bunifu.Framework.UI.BunifuImageButton()
            {
                Name = "PlayPauseButton" + rowtoname,
                Tag = "Stopped",
                ForeColor = Color.White,
                BackColor = System.Drawing.Color.FromArgb(8, 11, 46),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.None,
                Image = new Bitmap(Properties.Resources.CircledPlay_34px),
                Size = new Size(34, 34)
            };

            PlayPauseButton.Click += PlayPauseButton_Click;

            var DoneButton = new Bunifu.Framework.UI.BunifuImageButton()
            {
                Name = "DoneButton" + rowtoname,
                Tag = isHaveSavedID,
                ForeColor = Color.White,
                BackColor = System.Drawing.Color.FromArgb(8, 11, 46),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.None,
                Image = new Bitmap(Properties.Resources.Ok_34px),
                Size = new Size(34, 34)
            };

            DoneButton.Click += DoneButton_Click;

            int tableToPlaceIndex = TaskTable.RowCount-2;
            TaskTable.Controls.Add(TaskLabel, 0, tableToPlaceIndex);
            TaskTable.Controls.Add(TimerLabel, 1, tableToPlaceIndex);
            TaskTable.Controls.Add(PlayPauseButton, 2, tableToPlaceIndex);
            TaskTable.Controls.Add(DoneButton, 3, tableToPlaceIndex);
            TaskTable.RowCount = TaskTable.RowCount + 1;
            TaskTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                ContextMenu menu = menuItem.GetContextMenu();
                Control sourceControl = menu.SourceControl;

                try
                {
                    int getRowDelete = TaskTable.GetRow(sourceControl);
                    var getControl1 = TaskTable.GetControlFromPosition(0, getRowDelete);
                    var getControl2 = TaskTable.GetControlFromPosition(1, getRowDelete);
                    var getControl3 = TaskTable.GetControlFromPosition(2, getRowDelete);
                    var getControl4 = TaskTable.GetControlFromPosition(3, getRowDelete);

                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM `tbl_taskslog` WHERE `taskID` = (SELECT `taskID` FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid LIMIT 1);";
                            cmd.Parameters.AddWithValue("@taskname", sourceControl.Text);
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Close();
                                    if (MetroFramework.MetroMessageBox.Show(this, "There are logs associated with the task, are you sure you want to delete it? logs will also be deleted and it is irrevocable!", "Are you sure?!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        using (MySqlCommand cmd1 = conn.CreateCommand())
                                        {
                                            cmd1.CommandText = "DELETE FROM `tbl_taskslog` WHERE `taskID` = (SELECT `taskID` FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid); DELETE FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid LIMIT 1;";
                                            cmd1.Parameters.AddWithValue("@userid", SetUser.Text);
                                            cmd1.Parameters.AddWithValue("@taskname", sourceControl.Text);
                                            if (cmd1.ExecuteNonQuery() == 0)
                                            {
                                                MetroFramework.MetroMessageBox.Show(this, "Cannot delete the task! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                TaskTable.RowStyles[getRowDelete].Height = 0F;
                                                getControl1.Dispose();
                                                getControl2.Dispose();
                                                getControl3.Dispose();
                                                getControl4.Dispose();
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    reader.Close();
                                    using (MySqlCommand cmd1 = conn.CreateCommand())
                                    {
                                        cmd1.CommandText = "DELETE FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid LIMIT 1;";
                                        cmd1.Parameters.AddWithValue("@userid", SetUser.Text);
                                        cmd1.Parameters.AddWithValue("@taskname", sourceControl.Text);
                                        if (cmd1.ExecuteNonQuery() == 0)
                                        {
                                            MetroFramework.MetroMessageBox.Show(this, "Cannot delete the task! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            TaskTable.RowStyles[getRowDelete].Height = 0F;
                                            getControl1.Dispose();
                                            getControl2.Dispose();
                                            getControl3.Dispose();
                                            getControl4.Dispose();
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                       MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                ContextMenu menu = menuItem.GetContextMenu();
                Control sourceControl = menu.SourceControl;

                TaskTxtbox.Text = sourceControl.Text;
                TaskTxtbox.Tag = sourceControl.Text;
                AddTaskBtn.Text = "UPDATE TASK";
                AddTaskBtn.Tag = sourceControl.Name;
            }
        }

        private void TaskLabel_Click(object sender, EventArgs e)
        {
            Label selectedLabel = (Label)sender;
            TaskTxtbox.Text = selectedLabel.Text;
            TaskTxtbox.Tag = selectedLabel.Text;
            AddTaskBtn.Text = "UPDATE TASK";
            AddTaskBtn.Tag = selectedLabel.Name;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Are you sure task is done? This action is irrevocable and it will remove the task from the list..","Proceed?",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Bunifu.Framework.UI.BunifuImageButton selecteddonebutton = (Bunifu.Framework.UI.BunifuImageButton)sender;
                int getRowDone = TaskTable.GetRow(selecteddonebutton);
                var getPlayPauseButton = (Bunifu.Framework.UI.BunifuImageButton)TaskTable.GetControlFromPosition(2, getRowDone);
                if (getPlayPauseButton.Tag.ToString() == "Played")
                {
                    PlayPauseButton_Click(getPlayPauseButton, e);
                }
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        var getTaskLabelText = (Label)TaskTable.GetControlFromPosition(0, getRowDone);

                        cmd.CommandText = "UPDATE `tbl_tasks` SET `isDone` = '1', `timestampUpdated` = NOW() WHERE `taskName` = @taskname AND `userID` = @userid AND `isDone` = '0' LIMIT 1;";
                        cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                        cmd.Parameters.AddWithValue("@taskname", getTaskLabelText.Text);
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            getPlayPauseButton.Tag = "Stopped";
                            getPlayPauseButton.Image = new Bitmap(Properties.Resources.CircledPlay_34px);
                            TaskTable.RowStyles[getRowDone].Height = 0F;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Cannot set the task to done! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton selectedplaypausebutton = (Bunifu.Framework.UI.BunifuImageButton)sender;

            if (selectedplaypausebutton.Tag.ToString() == "Stopped")
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            int getRowPlayPause = TaskTable.GetRow(selectedplaypausebutton);
                            var getTaskLabelText = (Label)TaskTable.GetControlFromPosition(0, getRowPlayPause);
                            
                            cmd.CommandText = "INSERT INTO `tbl_taskslog` (`taskID`,`timestampStarted`) VALUES ((SELECT `taskID` FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid),NOW());";
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            cmd.Parameters.AddWithValue("@taskname", getTaskLabelText.Text);
                            if (cmd.ExecuteNonQuery() != 0)
                            {
                                selectedplaypausebutton.Tag = "Played";
                                selectedplaypausebutton.Image = new Bitmap(Properties.Resources.PauseButtonLIGHt_34px);
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cannot resume tasks! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedplaypausebutton.Tag.ToString() == "Played")
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            int getRowPlayPause = TaskTable.GetRow(selectedplaypausebutton);
                            var getTaskLabelText = (Label)TaskTable.GetControlFromPosition(0, getRowPlayPause);
                            var SessionTime = (Label)TaskTable.GetControlFromPosition(1, getRowPlayPause);

                            cmd.CommandText = "UPDATE `tbl_taskslog` SET `tasklogTime` = @tasklogtime, `timestampEnded` = NOW() WHERE `tasklogTime` IS NULL AND `timestampEnded` IS NULL AND `taskID` = (SELECT `taskID` FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid);";
                            cmd.Parameters.AddWithValue("@tasklogtime", TimeSpan.Parse(SessionTime.Text).Subtract(TimeSpan.Parse(SessionTime.Tag.ToString())).ToString());
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            cmd.Parameters.AddWithValue("@taskname", getTaskLabelText.Text);
                            if (cmd.ExecuteNonQuery() != 0)
                            {
                                using (MySqlCommand cmd1 = conn.CreateCommand())
                                {
                                    cmd1.CommandText = "UPDATE `tbl_tasks` SET `totalTime` = @tasklogtime, `timestampUpdated` = NOW() WHERE `taskName` = @taskname AND `userID` = @userid;";
                                    cmd1.Parameters.AddWithValue("@tasklogtime", SessionTime.Text);
                                    cmd1.Parameters.AddWithValue("@userid", SetUser.Text);
                                    cmd1.Parameters.AddWithValue("@taskname", getTaskLabelText.Text);
                                    if (cmd1.ExecuteNonQuery() != 0)
                                    {
                                        selectedplaypausebutton.Tag = "Stopped";
                                        selectedplaypausebutton.Image = new Bitmap(Properties.Resources.CircledPlay_34px);
                                    }
                                    else
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Cannot update parent task! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cannot pause tasks! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM `tbl_tasks` WHERE `userID` = @userid AND `isDone` = '0';";
                        cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    DynamicCreateTask(taskCounter++.ToString(), reader["taskName"].ToString(), reader["taskID"].ToString(),reader["totalTime"].ToString());
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

        private void SetDefaultControlsOnTxtBoxAndBtnTask()
        {
            AddTaskBtn.Text = "ADD TASK";
            AddTaskBtn.Tag = "";
            TaskTxtbox.Text = "";
            TaskTxtbox.Tag = "";
        }

        private void TaskTxtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (TaskTxtbox.Text == "")
            {
                SetDefaultControlsOnTxtBoxAndBtnTask();
            }
        }


        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (AddTaskBtn.Text == "UPDATE TASK" && TaskTxtbox.Text != "" && TaskTxtbox.Tag != null)
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid;";
                            cmd.Parameters.AddWithValue("@taskname", TaskTxtbox.Text);
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "You already have that task. Kindly check first your task list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    SetDefaultControlsOnTxtBoxAndBtnTask();
                                    return;
                                }
                            }
                        }
                    }

                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {                                                                               
                            cmd.CommandText = "UPDATE `tbl_tasks` SET `taskName` = @newtaskname WHERE `taskName` = @oldtaskName AND `userID` = @userid;";
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            cmd.Parameters.AddWithValue("@newtaskname", TaskTxtbox.Text);
                            cmd.Parameters.AddWithValue("@oldtaskName", TaskTxtbox.Tag);
                            if (cmd.ExecuteNonQuery() != 0)
                            {
                                var selectedLabel = (Label)TaskTable.Controls[AddTaskBtn.Tag.ToString()];
                                selectedLabel.Text = TaskTxtbox.Text;
                                MetroFramework.MetroMessageBox.Show(this, "Task successfully updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                SetDefaultControlsOnTxtBoxAndBtnTask();
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "There was an error encountered with the Database! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error Encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(TaskTxtbox.Text != "" && AddTaskBtn.Text == "ADD TASK")
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid;";
                            cmd.Parameters.AddWithValue("@taskname", TaskTxtbox.Text);
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "You already have that task. Kindly check first your task list or rename the task.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    SetDefaultControlsOnTxtBoxAndBtnTask();
                                    return;
                                }
                            }
                        }
                    }

                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO `tbl_tasks` (`userID`,`taskName`) VALUES (@userid,@taskname);";
                            cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                            cmd.Parameters.AddWithValue("@taskname", TaskTxtbox.Text);
                            if (cmd.ExecuteNonQuery() != 0)
                            {
                                DynamicCreateTask(taskCounter++.ToString(), TaskTxtbox.Text);
                                MetroFramework.MetroMessageBox.Show(this, "Task successfully added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                SetDefaultControlsOnTxtBoxAndBtnTask();
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "There was an error encountered with the Database! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this,ex.ToString(),"Error Encountered!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please provide a task name first...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private bool notified = false;
        private DateTime currentDate = DateTime.Today;

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Today, currentDate) > 0 && notified == true)
            {
                notified = false;
                NotifiedLabel.Text = "False";
                currentDate = DateTime.Now.Date;
            }
            if (TaskTable.RowCount > 0)
            {
                bool isthereRunning = false;
                for (int i = 0; i < TaskTable.RowCount - 2; i++)
                {
                    var onPlayedIncrement = (Bunifu.Framework.UI.BunifuImageButton)TaskTable.GetControlFromPosition(2, i);
                    if (onPlayedIncrement != null)
                    {
                        if (onPlayedIncrement.Tag.ToString() == "Played")
                        {
                            isthereRunning = true;
                            var incrementTimer = (Label)TaskTable.GetControlFromPosition(1, i);
                            incrementTimer.Text = TimeSpan.Parse(incrementTimer.Text).Add(TimeSpan.FromSeconds(1)).ToString();
                        }
                    }
                }

                if (DateTime.Compare(DateTime.Now, Convert.ToDateTime("17:30:00")) >= 0 && DateTime.Compare(DateTime.Now, Convert.ToDateTime("17:30:02")) <= 0 && notified == false && isthereRunning == true)
                {
                    notified = true;
                    NotifiedLabel.Text = "True";
                    RunAutoSave();
                    MetroFramework.MetroMessageBox.Show(this, "Time is already 5:30, Auto pause task executed.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void RunAutoSave()
        {
            if (TaskTable.RowCount > 0)
            {
                for (int i = 0; i < TaskTable.RowCount - 2; i++)
                {
                    var autoSaveButton = (Bunifu.Framework.UI.BunifuImageButton)TaskTable.GetControlFromPosition(2, i);
                    if (autoSaveButton != null)
                    {
                        if (autoSaveButton.Tag.ToString() == "Played")
                        {
                            try
                            {
                                using (var conn = new MySqlConnection(ConnectionString))
                                {
                                    conn.Open();
                                    using (MySqlCommand cmd = conn.CreateCommand())
                                    {
                                        int getRowPlayPause = TaskTable.GetRow(autoSaveButton);
                                        var getTaskLabelText = (Label)TaskTable.GetControlFromPosition(0, getRowPlayPause);
                                        var SessionTime = (Label)TaskTable.GetControlFromPosition(1, getRowPlayPause);

                                        cmd.CommandText = "UPDATE `tbl_taskslog` SET `tasklogTime` = @tasklogtime, `timestampEnded` = NOW() WHERE `tasklogTime` IS NULL AND `timestampEnded` IS NULL AND `taskID` = (SELECT `taskID` FROM `tbl_tasks` WHERE `taskName` = @taskname AND `userID` = @userid);";
                                        cmd.Parameters.AddWithValue("@tasklogtime", TimeSpan.Parse(SessionTime.Text).Subtract(TimeSpan.Parse(SessionTime.Tag.ToString())).ToString());
                                        cmd.Parameters.AddWithValue("@userid", SetUser.Text);
                                        cmd.Parameters.AddWithValue("@taskname", getTaskLabelText.Text);
                                        if (cmd.ExecuteNonQuery() != 0)
                                        {
                                            using (MySqlCommand cmd1 = conn.CreateCommand())
                                            {
                                                cmd1.CommandText = "UPDATE `tbl_tasks` SET `totalTime` = @tasklogtime, `timestampUpdated` = NOW() WHERE `taskName` = @taskname AND `userID` = @userid;";
                                                cmd1.Parameters.AddWithValue("@tasklogtime", SessionTime.Text);
                                                cmd1.Parameters.AddWithValue("@userid", SetUser.Text);
                                                cmd1.Parameters.AddWithValue("@taskname", getTaskLabelText.Text);
                                                if (cmd1.ExecuteNonQuery() != 0)
                                                {
                                                    autoSaveButton.Tag = "Stopped";
                                                    autoSaveButton.Image = new Bitmap(Properties.Resources.CircledPlay_34px);
                                                }
                                                else
                                                {
                                                    MetroFramework.MetroMessageBox.Show(this, "Cannot update parent task! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MetroFramework.MetroMessageBox.Show(this, "Cannot pause tasks! Please check db connection and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

    }
}
