namespace TaskTimer
{
    partial class ConnectionSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSetup));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataSourceTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PortTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DbnameTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PassTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RegisterBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UsernamedbTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(367, 46);
            this.panel1.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::TaskTimer.Properties.Resources.Delete_34px;
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(330, 5);
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
            this.Label2.Location = new System.Drawing.Point(9, 7);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(252, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "CONNECTION SETUP";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(367, 390);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataSourceTxtBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PortTxtBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DbnameTxtBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PassTxtbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.RegisterBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.UsernamedbTxtBox, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 370);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // DataSourceTxtBox
            // 
            this.DataSourceTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataSourceTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataSourceTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DataSourceTxtBox.ForeColor = System.Drawing.Color.White;
            this.DataSourceTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.DataSourceTxtBox.HintText = "Data Source";
            this.DataSourceTxtBox.isPassword = false;
            this.DataSourceTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.DataSourceTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.DataSourceTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.DataSourceTxtBox.LineThickness = 1;
            this.DataSourceTxtBox.Location = new System.Drawing.Point(14, 22);
            this.DataSourceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DataSourceTxtBox.Name = "DataSourceTxtBox";
            this.DataSourceTxtBox.Size = new System.Drawing.Size(319, 33);
            this.DataSourceTxtBox.TabIndex = 0;
            this.DataSourceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PortTxtBox
            // 
            this.PortTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PortTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PortTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PortTxtBox.ForeColor = System.Drawing.Color.White;
            this.PortTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.PortTxtBox.HintText = "Port";
            this.PortTxtBox.isPassword = false;
            this.PortTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.PortTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.PortTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.PortTxtBox.LineThickness = 1;
            this.PortTxtBox.Location = new System.Drawing.Point(14, 80);
            this.PortTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortTxtBox.Name = "PortTxtBox";
            this.PortTxtBox.Size = new System.Drawing.Size(319, 33);
            this.PortTxtBox.TabIndex = 1;
            this.PortTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DbnameTxtBox
            // 
            this.DbnameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DbnameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DbnameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DbnameTxtBox.ForeColor = System.Drawing.Color.White;
            this.DbnameTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.DbnameTxtBox.HintText = "Database";
            this.DbnameTxtBox.isPassword = false;
            this.DbnameTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.DbnameTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.DbnameTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.DbnameTxtBox.LineThickness = 1;
            this.DbnameTxtBox.Location = new System.Drawing.Point(14, 138);
            this.DbnameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DbnameTxtBox.Name = "DbnameTxtBox";
            this.DbnameTxtBox.Size = new System.Drawing.Size(319, 33);
            this.DbnameTxtBox.TabIndex = 2;
            this.DbnameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PassTxtbox
            // 
            this.PassTxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassTxtbox.ForeColor = System.Drawing.Color.White;
            this.PassTxtbox.HintForeColor = System.Drawing.Color.LightGray;
            this.PassTxtbox.HintText = "Password";
            this.PassTxtbox.isPassword = false;
            this.PassTxtbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.PassTxtbox.LineIdleColor = System.Drawing.Color.LightGray;
            this.PassTxtbox.LineMouseHoverColor = System.Drawing.Color.White;
            this.PassTxtbox.LineThickness = 1;
            this.PassTxtbox.Location = new System.Drawing.Point(14, 254);
            this.PassTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.PassTxtbox.Name = "PassTxtbox";
            this.PassTxtbox.Size = new System.Drawing.Size(319, 33);
            this.PassTxtbox.TabIndex = 4;
            this.PassTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassTxtbox.Enter += new System.EventHandler(this.PassTxtbox_Enter);
            this.PassTxtbox.Leave += new System.EventHandler(this.PassTxtbox_Leave);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Activecolor = System.Drawing.Color.Lime;
            this.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegisterBtn.BackColor = System.Drawing.Color.Lime;
            this.RegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterBtn.BorderRadius = 7;
            this.RegisterBtn.ButtonText = "C R E A T E";
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.DisabledColor = System.Drawing.Color.Gray;
            this.RegisterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.RegisterBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RegisterBtn.Iconimage = null;
            this.RegisterBtn.Iconimage_right = null;
            this.RegisterBtn.Iconimage_right_Selected = null;
            this.RegisterBtn.Iconimage_Selected = null;
            this.RegisterBtn.IconMarginLeft = 0;
            this.RegisterBtn.IconMarginRight = 0;
            this.RegisterBtn.IconRightVisible = true;
            this.RegisterBtn.IconRightZoom = 0D;
            this.RegisterBtn.IconVisible = true;
            this.RegisterBtn.IconZoom = 90D;
            this.RegisterBtn.IsTab = false;
            this.RegisterBtn.Location = new System.Drawing.Point(13, 319);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Normalcolor = System.Drawing.Color.Lime;
            this.RegisterBtn.OnHovercolor = System.Drawing.Color.Lime;
            this.RegisterBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.RegisterBtn.selected = false;
            this.RegisterBtn.Size = new System.Drawing.Size(321, 38);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "C R E A T E";
            this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.RegisterBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // UsernamedbTxtBox
            // 
            this.UsernamedbTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernamedbTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernamedbTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UsernamedbTxtBox.ForeColor = System.Drawing.Color.White;
            this.UsernamedbTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.UsernamedbTxtBox.HintText = "Username";
            this.UsernamedbTxtBox.isPassword = false;
            this.UsernamedbTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.UsernamedbTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.UsernamedbTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.UsernamedbTxtBox.LineThickness = 1;
            this.UsernamedbTxtBox.Location = new System.Drawing.Point(14, 196);
            this.UsernamedbTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernamedbTxtBox.Name = "UsernamedbTxtBox";
            this.UsernamedbTxtBox.Size = new System.Drawing.Size(319, 33);
            this.UsernamedbTxtBox.TabIndex = 3;
            this.UsernamedbTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ConnectionSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectionSetup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        internal Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        internal System.Windows.Forms.Label Label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassTxtbox;
        internal Bunifu.Framework.UI.BunifuFlatButton RegisterBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DataSourceTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PortTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DbnameTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UsernamedbTxtBox;
    }
}