using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TaskTimer
{
    public partial class ConnectionSetup : Form
    {
        public ConnectionSetup()
        {
            InitializeComponent();
        }

        private void PassTxtbox_Enter(object sender, EventArgs e)
        {
            PassTxtbox.isPassword = true;
            if (PassTxtbox.Text == "") PassTxtbox.Text = "";
        }

        private void PassTxtbox_Leave(object sender, EventArgs e)
        {
            if (PassTxtbox.Text == "") PassTxtbox.isPassword = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("ConnectionSettings.xml"))
            {
                using (XmlWriter writer = XmlWriter.Create("ConnectionSettings.xml"))
                {
                    writer.WriteStartElement("Connection");
                    writer.WriteElementString("DataSource", DataSourceTxtBox.Text);
                    writer.WriteElementString("Port", PortTxtBox.Text);
                    writer.WriteElementString("DataBase", DbnameTxtBox.Text);
                    writer.WriteElementString("UserName", UsernamedbTxtBox.Text);
                    writer.WriteElementString("Password", PassTxtbox.Text);
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Connection Settings already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
