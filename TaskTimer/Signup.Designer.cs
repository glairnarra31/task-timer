namespace TaskTimer
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmPassTxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RegisterBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NameTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UsernameTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PositionTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.Label2.Size = new System.Drawing.Size(119, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "REGISTER";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 390);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(367, 390);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ConfirmPassTxtbox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.RegisterBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.NameTxtBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UsernameTxtBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTxtBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PositionTxtBox, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ConfirmPassTxtbox
            // 
            this.ConfirmPassTxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPassTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassTxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ConfirmPassTxtbox.ForeColor = System.Drawing.Color.White;
            this.ConfirmPassTxtbox.HintForeColor = System.Drawing.Color.LightGray;
            this.ConfirmPassTxtbox.HintText = "Confirm Password";
            this.ConfirmPassTxtbox.isPassword = false;
            this.ConfirmPassTxtbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.ConfirmPassTxtbox.LineIdleColor = System.Drawing.Color.LightGray;
            this.ConfirmPassTxtbox.LineMouseHoverColor = System.Drawing.Color.White;
            this.ConfirmPassTxtbox.LineThickness = 1;
            this.ConfirmPassTxtbox.Location = new System.Drawing.Point(14, 196);
            this.ConfirmPassTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPassTxtbox.Name = "ConfirmPassTxtbox";
            this.ConfirmPassTxtbox.Size = new System.Drawing.Size(319, 33);
            this.ConfirmPassTxtbox.TabIndex = 3;
            this.ConfirmPassTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ConfirmPassTxtbox.Enter += new System.EventHandler(this.ConfirmPassTxtbox_Enter);
            this.ConfirmPassTxtbox.Leave += new System.EventHandler(this.ConfirmPassTxtbox_Leave);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Activecolor = System.Drawing.Color.Lime;
            this.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegisterBtn.BackColor = System.Drawing.Color.Lime;
            this.RegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterBtn.BorderRadius = 7;
            this.RegisterBtn.ButtonText = "R E G I S T E R";
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
            this.RegisterBtn.TabIndex = 0;
            this.RegisterBtn.TabStop = false;
            this.RegisterBtn.Text = "R E G I S T E R";
            this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.RegisterBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTxtBox.ForeColor = System.Drawing.Color.White;
            this.NameTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.NameTxtBox.HintText = "Name";
            this.NameTxtBox.isPassword = false;
            this.NameTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.NameTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.NameTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.NameTxtBox.LineThickness = 1;
            this.NameTxtBox.Location = new System.Drawing.Point(14, 22);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(319, 33);
            this.NameTxtBox.TabIndex = 0;
            this.NameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UsernameTxtBox.ForeColor = System.Drawing.Color.White;
            this.UsernameTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.UsernameTxtBox.HintText = "Username";
            this.UsernameTxtBox.isPassword = false;
            this.UsernameTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.UsernameTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.UsernameTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.UsernameTxtBox.LineThickness = 1;
            this.UsernameTxtBox.Location = new System.Drawing.Point(14, 80);
            this.UsernameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(319, 33);
            this.UsernameTxtBox.TabIndex = 1;
            this.UsernameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.PasswordTxtBox.HintText = "Password";
            this.PasswordTxtBox.isPassword = false;
            this.PasswordTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.PasswordTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.PasswordTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.PasswordTxtBox.LineThickness = 1;
            this.PasswordTxtBox.Location = new System.Drawing.Point(14, 138);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(319, 33);
            this.PasswordTxtBox.TabIndex = 2;
            this.PasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTxtBox.Enter += new System.EventHandler(this.PasswordTxtBox_Enter);
            this.PasswordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
            // 
            // PositionTxtBox
            // 
            this.PositionTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PositionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PositionTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PositionTxtBox.ForeColor = System.Drawing.Color.White;
            this.PositionTxtBox.HintForeColor = System.Drawing.Color.LightGray;
            this.PositionTxtBox.HintText = "Job Description";
            this.PositionTxtBox.isPassword = false;
            this.PositionTxtBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.PositionTxtBox.LineIdleColor = System.Drawing.Color.LightGray;
            this.PositionTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.PositionTxtBox.LineThickness = 1;
            this.PositionTxtBox.Location = new System.Drawing.Point(14, 254);
            this.PositionTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PositionTxtBox.Name = "PositionTxtBox";
            this.PositionTxtBox.Size = new System.Drawing.Size(319, 33);
            this.PositionTxtBox.TabIndex = 4;
            this.PositionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(14)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(367, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label Label2;
        internal Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UsernameTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PositionTxtBox;
        internal Bunifu.Framework.UI.BunifuFlatButton RegisterBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ConfirmPassTxtbox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}