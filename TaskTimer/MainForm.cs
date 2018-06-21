using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TaskTimer
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private string datasource = "";
        private string port = "";
        private string database = "";
        private string username = "";
        private string password = "";

        public MainForm()
        {
            InitializeComponent();
            LoginControl1.LabelGet.TextChanged += LabelGetTextChanged;

            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            NotifyIcon.Icon = new Icon("icons8_Punctuality.ico");
            NotifyIcon.Text = "Task Timer";
            NotifyIcon.Visible = false;
            NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            TaskMonitor1.NotifiedLabel.TextChanged += NotifiedLabel_TextChanged;
        }

        private void NotifiedLabel_TextChanged(object sender, EventArgs e)
        {
            if (TaskMonitor1.NotifiedLabel.Text == "True")
            {
                if (Visible == false)
                {
                    this.ShowInTaskbar = true;
                    this.Visible = true;
                    NotifyIcon.Visible = false;
                }
            }
        }

        public void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                this.ShowInTaskbar = true;
                this.Visible = true;
                NotifyIcon.Visible = false;
            }
        }

        private void LabelGetTextChanged(object sender, EventArgs e)
        {
            if (LoginControl1.LabelGet.Text != "notset")
            {
                TaskMonitor1.SetUserID = LoginControl1.LabelGet.Text;
                LogsBtn.Visible = true;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (TaskMonitor1.TaskTable.RowCount > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to exit?", "Proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    Environment.Exit(0);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaskMonitor1.RunAutoSave();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.ShowInTaskbar = false;
            NotifyIcon.Visible = true;
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            ShowLogs showLogs = new ShowLogs
            {
                DbConnectionString = "datasource=" + datasource + ";port=" + port + ";database=" + database + ";username=" + username + ";password=" + password,
                SetUserID = LoginControl1.LabelGet.Text
            };
            showLogs.ShowDialog();
        }

        private void InitializeControlsConnections(string datasource,string port,string database,string username, string password)
        {
            string connectionString = "datasource="+datasource+";port="+port+";database="+database+";username="+username+";password="+password;
            LoginControl1.DbConnectionString = connectionString;
            TaskMonitor1.DbConnectionString = connectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("ConnectionSettings.xml"))
            {
                using (XmlReader reader = new XmlTextReader("ConnectionSettings.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "DataSource") datasource = reader.ReadInnerXml().ToString();
                            if (reader.Name == "Port") port = reader.ReadInnerXml().ToString();
                            if (reader.Name == "DataBase") database = reader.ReadInnerXml().ToString();
                            if (reader.Name == "UserName") username = reader.ReadInnerXml().ToString();
                            if (reader.Name == "Password") password = reader.ReadInnerXml().ToString();
                        }
                    }
                    InitializeControlsConnections(datasource,port,database,username,password);
                }
            }
            else
            {
                ConnectionSetup connectionSetup = new ConnectionSetup();
                connectionSetup.FormClosed += ConnectionSetup_FormClosed;
                connectionSetup.ShowDialog();
            }
        }

        private void ConnectionSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm_Load(sender ,e);
        }
    }
}
