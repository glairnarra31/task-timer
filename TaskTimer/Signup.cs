using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class Signup : Form
    {
        private string ConnectionString = "datasource=localhost;port=3306;database=tasktimerdb;username=root;password=";

        [Description("MySql Connection String"), Category("DbConnectionString")]
        public string DbConnectionString
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }

        public Signup()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordTxtBox_Enter(object sender, EventArgs e)
        {
            PasswordTxtBox.isPassword = true;
            if (PasswordTxtBox.Text == "") PasswordTxtBox.Text = "";
        }

        private void PasswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text == "") PasswordTxtBox.isPassword = false;
        }

        private void ConfirmPassTxtbox_Enter(object sender, EventArgs e)
        {
            ConfirmPassTxtbox.isPassword = true;
            if (ConfirmPassTxtbox.Text == "") ConfirmPassTxtbox.Text = "";
        }

        private void ConfirmPassTxtbox_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassTxtbox.Text == "") ConfirmPassTxtbox.isPassword = false;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (NameTxtBox.Text != "" || UsernameTxtBox.Text != "" || PasswordTxtBox.Text != "" || ConfirmPassTxtbox.Text != "" || PositionTxtBox.Text != "")
            {
                if (PasswordTxtBox.Text == ConfirmPassTxtbox.Text)
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
                            cmd.CommandText = "INSERT INTO `tbl_users` (`Name`,`Username`,`Password`,`Position`) VALUES (@name,@username,@password,@position);";
                            cmd.Parameters.AddWithValue("@name", NameTxtBox.Text);
                            cmd.Parameters.AddWithValue("@username", UsernameTxtBox.Text);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@position", PositionTxtBox.Text);
                            if (cmd.ExecuteNonQuery() != 0)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                this.Close();
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "There was an error encountered or username is already used!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Passwords entered do not match! Try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordTxtBox.Text = "";
                    ConfirmPassTxtbox.Text = "";
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill up all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
