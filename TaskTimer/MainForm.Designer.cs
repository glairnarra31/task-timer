namespace TaskTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginControl1 = new TaskTimer.LoginControl();
            this.TaskMonitor1 = new TaskTimer.TaskMonitor();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.LogsBtn);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.BunifuImageButton1);
            this.panel1.Controls.Add(this.BunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 42);
            this.panel1.TabIndex = 0;
            // 
            // LogsBtn
            // 
            this.LogsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.LogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsBtn.Image = global::TaskTimer.Properties.Resources.BulletedList_34px;
            this.LogsBtn.ImageActive = null;
            this.LogsBtn.Location = new System.Drawing.Point(636, 4);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Size = new System.Drawing.Size(34, 35);
            this.LogsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogsBtn.TabIndex = 3;
            this.LogsBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.LogsBtn, "Logs");
            this.LogsBtn.Visible = false;
            this.LogsBtn.Zoom = 5;
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = global::TaskTimer.Properties.Resources.MinimizeWindow_34px;
            this.MinimizeBtn.ImageActive = null;
            this.MinimizeBtn.Location = new System.Drawing.Point(674, 4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(34, 34);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 3;
            this.MinimizeBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.MinimizeBtn, "Minimize");
            this.MinimizeBtn.Zoom = 5;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::TaskTimer.Properties.Resources.Delete_34px;
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(711, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 35);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.CloseBtn, "Close");
            this.CloseBtn.Zoom = 5;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // BunifuImageButton1
            // 
            this.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.BunifuImageButton1.Image = global::TaskTimer.Properties.Resources.Punctuality_38px;
            this.BunifuImageButton1.ImageActive = null;
            this.BunifuImageButton1.Location = new System.Drawing.Point(5, 4);
            this.BunifuImageButton1.Name = "BunifuImageButton1";
            this.BunifuImageButton1.Size = new System.Drawing.Size(28, 35);
            this.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton1.TabIndex = 1;
            this.BunifuImageButton1.TabStop = false;
            this.BunifuImageButton1.Zoom = 0;
            // 
            // BunifuCustomLabel1
            // 
            this.BunifuCustomLabel1.AutoSize = true;
            this.BunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Lime;
            this.BunifuCustomLabel1.Location = new System.Drawing.Point(31, 5);
            this.BunifuCustomLabel1.Name = "BunifuCustomLabel1";
            this.BunifuCustomLabel1.Size = new System.Drawing.Size(158, 32);
            this.BunifuCustomLabel1.TabIndex = 2;
            this.BunifuCustomLabel1.Text = "TASK TIMER";
            this.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.LoginControl1);
            this.panel2.Controls.Add(this.TaskMonitor1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 525);
            this.panel2.TabIndex = 1;
            // 
            // LoginControl1
            // 
            this.LoginControl1.DbConnectionString = "datasource=localhost;port=3306;database=tasktimerdb;username=root;password=";
            this.LoginControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginControl1.Location = new System.Drawing.Point(0, 0);
            this.LoginControl1.Name = "LoginControl1";
            this.LoginControl1.Size = new System.Drawing.Size(749, 525);
            this.LoginControl1.TabIndex = 0;
            // 
            // TaskMonitor1
            // 
            this.TaskMonitor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            this.TaskMonitor1.DbConnectionString = "datasource=localhost;port=3306;database=tasktimerdb;username=root;password=";
            this.TaskMonitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskMonitor1.Location = new System.Drawing.Point(0, 0);
            this.TaskMonitor1.Name = "TaskMonitor1";
            this.TaskMonitor1.Size = new System.Drawing.Size(749, 525);
            this.TaskMonitor1.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.BunifuCustomLabel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.BunifuImageButton1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 567);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        internal Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private LoginControl LoginControl1;
        private TaskMonitor TaskMonitor1;
        internal Bunifu.Framework.UI.BunifuImageButton MinimizeBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        internal Bunifu.Framework.UI.BunifuImageButton LogsBtn;
    }
}

