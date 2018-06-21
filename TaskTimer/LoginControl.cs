using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Diagnostics;

namespace TaskTimer
{
    public partial class LoginControl : UserControl
    {
        private string ConnectionString = "datasource=localhost;port=3306;database=tasktimerdb;username=root;password=";

        [Description("MySql Connection String"), Category("DbConnectionString")]
        public string DbConnectionString
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text != "" && UsernameTxtbox.Text != "")
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            var sha1 = new SHA1Managed();
                            string password = BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(PasswordTxtBox.Text))).Replace("-", "");
                            sha1.Dispose();
                            cmd.CommandText = "SELECT * FROM `tbl_users` WHERE `Username` = @username AND `Password` = @password AND `isDeleted` = '0' LIMIT 1;";
                            cmd.Parameters.AddWithValue("@username", UsernameTxtbox.Text);
                            cmd.Parameters.AddWithValue("@password", password);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Login Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    while (reader.Read())
                                    {
                                        LabelGet.Text = reader["ID"].ToString();
                                    }
                                    ClearTxtBoxes();
                                    SendToBack();
                                }
                                else
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is incorrect! Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Debug.WriteLine(password);
                                    ClearTxtBoxes();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Please provide valid credentials!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ClearTxtBoxes()
        {
            UsernameTxtbox.Text = "";
            PasswordTxtBox.Text = "";
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup
            {
                DbConnectionString = ConnectionString
            };
            signup.ShowDialog();
        }
    }
}
