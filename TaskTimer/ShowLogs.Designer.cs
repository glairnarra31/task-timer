namespace TaskTimer
{
    partial class ShowLogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLogs));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApplyFilterBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ToDateDrop = new MetroFramework.Controls.MetroDateTime();
            this.FromDateDrop = new MetroFramework.Controls.MetroDateTime();
            this.TasksDropdown = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TaskLogsTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeAddedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LastUpdatedLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogEnded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskLogsTable)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 46);
            this.panel1.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::TaskTimer.Properties.Resources.Delete_34px;
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(708, 6);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 35);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 5;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(5, 7);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "LOGS";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(749, 521);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.03704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.96296F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 57);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 404);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.15139F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81275F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.13502F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.578947F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Controls.Add(this.TasksDropdown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ToDateDrop, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.FromDateDrop, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ApplyFilterBtn, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(709, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TASKS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ApplyFilterBtn
            // 
            this.ApplyFilterBtn.Activecolor = System.Drawing.Color.Lime;
            this.ApplyFilterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplyFilterBtn.BackColor = System.Drawing.Color.Lime;
            this.ApplyFilterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplyFilterBtn.BorderRadius = 7;
            this.ApplyFilterBtn.ButtonText = "APPLY";
            this.ApplyFilterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyFilterBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ApplyFilterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.ApplyFilterBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ApplyFilterBtn.Iconimage = null;
            this.ApplyFilterBtn.Iconimage_right = null;
            this.ApplyFilterBtn.Iconimage_right_Selected = null;
            this.ApplyFilterBtn.Iconimage_Selected = null;
            this.ApplyFilterBtn.IconMarginLeft = 0;
            this.ApplyFilterBtn.IconMarginRight = 0;
            this.ApplyFilterBtn.IconRightVisible = true;
            this.ApplyFilterBtn.IconRightZoom = 0D;
            this.ApplyFilterBtn.IconVisible = true;
            this.ApplyFilterBtn.IconZoom = 90D;
            this.ApplyFilterBtn.IsTab = false;
            this.ApplyFilterBtn.Location = new System.Drawing.Point(603, 14);
            this.ApplyFilterBtn.Name = "ApplyFilterBtn";
            this.ApplyFilterBtn.Normalcolor = System.Drawing.Color.Lime;
            this.ApplyFilterBtn.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.ApplyFilterBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.ApplyFilterBtn.selected = false;
            this.ApplyFilterBtn.Size = new System.Drawing.Size(95, 29);
            this.ApplyFilterBtn.TabIndex = 7;
            this.ApplyFilterBtn.TabStop = false;
            this.ApplyFilterBtn.Text = "APPLY";
            this.ApplyFilterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyFilterBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.ApplyFilterBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFilterBtn.Click += new System.EventHandler(this.ApplyFilterBtn_Click);
            // 
            // ToDateDrop
            // 
            this.ToDateDrop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ToDateDrop.CustomFormat = "MM/dd/yyyy";
            this.ToDateDrop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateDrop.Location = new System.Drawing.Point(489, 14);
            this.ToDateDrop.MinimumSize = new System.Drawing.Size(0, 29);
            this.ToDateDrop.Name = "ToDateDrop";
            this.ToDateDrop.Size = new System.Drawing.Size(101, 29);
            this.ToDateDrop.TabIndex = 9;
            // 
            // FromDateDrop
            // 
            this.FromDateDrop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FromDateDrop.CustomFormat = "MM/dd/yyyy";
            this.FromDateDrop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateDrop.Location = new System.Drawing.Point(359, 14);
            this.FromDateDrop.MinimumSize = new System.Drawing.Size(0, 29);
            this.FromDateDrop.Name = "FromDateDrop";
            this.FromDateDrop.Size = new System.Drawing.Size(101, 29);
            this.FromDateDrop.TabIndex = 10;
            // 
            // TasksDropdown
            // 
            this.TasksDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TasksDropdown.FormattingEnabled = true;
            this.TasksDropdown.ItemHeight = 23;
            this.TasksDropdown.Items.AddRange(new object[] {
            "All Tasks"});
            this.TasksDropdown.Location = new System.Drawing.Point(62, 14);
            this.TasksDropdown.Name = "TasksDropdown";
            this.TasksDropdown.Size = new System.Drawing.Size(222, 29);
            this.TasksDropdown.TabIndex = 0;
            this.TasksDropdown.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(309, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DATE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TaskLogsTable, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09901F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.90099F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(709, 404);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // TaskLogsTable
            // 
            this.TaskLogsTable.AllowUserToAddRows = false;
            this.TaskLogsTable.AllowUserToDeleteRows = false;
            this.TaskLogsTable.AllowUserToOrderColumns = true;
            this.TaskLogsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.TaskLogsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskLogsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskLogsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.TaskLogsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskLogsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskLogsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TaskLogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TaskLogsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.LogStarted,
            this.LogEnded,
            this.Duration});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskLogsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.TaskLogsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskLogsTable.DoubleBuffered = true;
            this.TaskLogsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TaskLogsTable.EnableHeadersVisualStyles = false;
            this.TaskLogsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.TaskLogsTable.HeaderBgColor = System.Drawing.Color.Lime;
            this.TaskLogsTable.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.TaskLogsTable.Location = new System.Drawing.Point(5, 65);
            this.TaskLogsTable.Margin = new System.Windows.Forms.Padding(5);
            this.TaskLogsTable.MultiSelect = false;
            this.TaskLogsTable.Name = "TaskLogsTable";
            this.TaskLogsTable.ReadOnly = true;
            this.TaskLogsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TaskLogsTable.RowHeadersVisible = false;
            this.TaskLogsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TaskLogsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskLogsTable.Size = new System.Drawing.Size(699, 334);
            this.TaskLogsTable.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.87198F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.29872F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.90612F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78094F));
            this.tableLayoutPanel4.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.StatusLabel, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DateTimeAddedLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LastUpdatedLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TotalTimeLabel, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(703, 54);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(36, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date/Time Added";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DateTimeAddedLabel
            // 
            this.DateTimeAddedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimeAddedLabel.AutoSize = true;
            this.DateTimeAddedLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeAddedLabel.ForeColor = System.Drawing.Color.White;
            this.DateTimeAddedLabel.Location = new System.Drawing.Point(86, 30);
            this.DateTimeAddedLabel.Name = "DateTimeAddedLabel";
            this.DateTimeAddedLabel.Size = new System.Drawing.Size(38, 20);
            this.DateTimeAddedLabel.TabIndex = 5;
            this.DateTimeAddedLabel.Text = "N/A";
            this.DateTimeAddedLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(263, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Last Updated";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LastUpdatedLabel
            // 
            this.LastUpdatedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastUpdatedLabel.AutoSize = true;
            this.LastUpdatedLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUpdatedLabel.ForeColor = System.Drawing.Color.White;
            this.LastUpdatedLabel.Location = new System.Drawing.Point(297, 30);
            this.LastUpdatedLabel.Name = "LastUpdatedLabel";
            this.LastUpdatedLabel.Size = new System.Drawing.Size(38, 20);
            this.LastUpdatedLabel.TabIndex = 7;
            this.LastUpdatedLabel.Text = "N/A";
            this.LastUpdatedLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(461, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.TotalTimeLabel.Location = new System.Drawing.Point(481, 30);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(38, 20);
            this.TotalTimeLabel.TabIndex = 9;
            this.TotalTimeLabel.Text = "N/A";
            this.TotalTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(614, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Status";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(621, 30);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 20);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "N/A";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // LogStarted
            // 
            this.LogStarted.HeaderText = "Log Started";
            this.LogStarted.Name = "LogStarted";
            this.LogStarted.ReadOnly = true;
            // 
            // LogEnded
            // 
            this.LogEnded.HeaderText = "Log Ended";
            this.LogEnded.Name = "LogEnded";
            this.LogEnded.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // ShowLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowLogs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowLogs";
            this.Load += new System.EventHandler(this.ShowLogs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskLogsTable)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        internal Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal Bunifu.Framework.UI.BunifuFlatButton ApplyFilterBtn;
        private MetroFramework.Controls.MetroDateTime ToDateDrop;
        private MetroFramework.Controls.MetroDateTime FromDateDrop;
        private MetroFramework.Controls.MetroComboBox TasksDropdown;
        internal System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid TaskLogsTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label DateTimeAddedLabel;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label StatusLabel;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label LastUpdatedLabel;
        internal System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogEnded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}