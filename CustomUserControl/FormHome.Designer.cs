namespace CustomUserControl
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ButtonHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.guna2ButtonSetting = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAbout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUsers = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1094, 118);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustomUserControl.Properties.Resources.economy;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ButtonHome
            // 
            this.guna2ButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonHome.Checked = true;
            this.guna2ButtonHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButtonHome.CustomBorderColor = System.Drawing.Color.White;
            this.guna2ButtonHome.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonHome.FillColor = System.Drawing.Color.White;
            this.guna2ButtonHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2ButtonHome.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonHome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonHome.Image = global::CustomUserControl.Properties.Resources.home__1_;
            this.guna2ButtonHome.Location = new System.Drawing.Point(5, 5);
            this.guna2ButtonHome.Name = "guna2ButtonHome";
            this.guna2ButtonHome.Size = new System.Drawing.Size(181, 38);
            this.guna2ButtonHome.TabIndex = 1;
            this.guna2ButtonHome.Text = "   Home";
            this.guna2ButtonHome.Click += new System.EventHandler(this.guna2ButtonHome_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.White;
            this.panelNav.Controls.Add(this.guna2ButtonSetting);
            this.panelNav.Controls.Add(this.guna2ButtonAbout);
            this.panelNav.Controls.Add(this.guna2ButtonUsers);
            this.panelNav.Controls.Add(this.guna2ButtonHome);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 118);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1094, 45);
            this.panelNav.TabIndex = 2;
            // 
            // guna2ButtonSetting
            // 
            this.guna2ButtonSetting.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonSetting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonSetting.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonSetting.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButtonSetting.CustomBorderColor = System.Drawing.Color.White;
            this.guna2ButtonSetting.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSetting.FillColor = System.Drawing.Color.White;
            this.guna2ButtonSetting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2ButtonSetting.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonSetting.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonSetting.Image = global::CustomUserControl.Properties.Resources.settings;
            this.guna2ButtonSetting.Location = new System.Drawing.Point(606, 5);
            this.guna2ButtonSetting.Name = "guna2ButtonSetting";
            this.guna2ButtonSetting.Size = new System.Drawing.Size(181, 38);
            this.guna2ButtonSetting.TabIndex = 1;
            this.guna2ButtonSetting.Text = "   Setting";
            this.guna2ButtonSetting.Click += new System.EventHandler(this.guna2ButtonSetting_Click);
            // 
            // guna2ButtonAbout
            // 
            this.guna2ButtonAbout.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonAbout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonAbout.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonAbout.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButtonAbout.CustomBorderColor = System.Drawing.Color.White;
            this.guna2ButtonAbout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAbout.FillColor = System.Drawing.Color.White;
            this.guna2ButtonAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2ButtonAbout.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonAbout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonAbout.Image = global::CustomUserControl.Properties.Resources.information;
            this.guna2ButtonAbout.Location = new System.Drawing.Point(406, 5);
            this.guna2ButtonAbout.Name = "guna2ButtonAbout";
            this.guna2ButtonAbout.Size = new System.Drawing.Size(181, 38);
            this.guna2ButtonAbout.TabIndex = 1;
            this.guna2ButtonAbout.Text = "   About";
            this.guna2ButtonAbout.Click += new System.EventHandler(this.guna2ButtonAbout_Click);
            // 
            // guna2ButtonUsers
            // 
            this.guna2ButtonUsers.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonUsers.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButtonUsers.CustomBorderColor = System.Drawing.Color.White;
            this.guna2ButtonUsers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonUsers.FillColor = System.Drawing.Color.White;
            this.guna2ButtonUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2ButtonUsers.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonUsers.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ButtonUsers.Image = global::CustomUserControl.Properties.Resources.user;
            this.guna2ButtonUsers.Location = new System.Drawing.Point(208, 5);
            this.guna2ButtonUsers.Name = "guna2ButtonUsers";
            this.guna2ButtonUsers.Size = new System.Drawing.Size(181, 38);
            this.guna2ButtonUsers.TabIndex = 1;
            this.guna2ButtonUsers.Text = "   Users";
            this.guna2ButtonUsers.Click += new System.EventHandler(this.guna2ButtonUsers_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 163);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1094, 514);
            this.panelContainer.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CustomUserControl.Properties.Resources._20190221_183328;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(995, 32);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(56, 52);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(826, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salem Almmari";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1094, 677);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonHome;
        private Panel panelNav;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSetting;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAbout;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUsers;
        private Panel panelContainer;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}