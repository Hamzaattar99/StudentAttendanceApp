namespace SignUpForm
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
            this.contextMenuUserLabel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFullnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.usernameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.accountLogo = new System.Windows.Forms.Button();
            this.SettingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuUserLabel.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 345);
            this.panel1.TabIndex = 23;
            // 
            // contextMenuUserLabel
            // 
            this.contextMenuUserLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuUserLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.contextMenuUserLabel.Name = "contextMenuUserLabel";
            this.contextMenuUserLabel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuUserLabel.Size = new System.Drawing.Size(127, 70);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem,
            this.changeFullnameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changeNameToolStripMenuItem.Text = "Change name";
            // 
            // changeFullnameToolStripMenuItem
            // 
            this.changeFullnameToolStripMenuItem.Name = "changeFullnameToolStripMenuItem";
            this.changeFullnameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changeFullnameToolStripMenuItem.Text = "Change fullname";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.usernameLabel);
            this.bunifuGradientPanel2.Controls.Add(this.accountLogo);
            this.bunifuGradientPanel2.Controls.Add(this.SettingsBtn);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 392);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(906, 47);
            this.bunifuGradientPanel2.TabIndex = 22;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.ContextMenuStrip = this.contextMenuUserLabel;
            this.usernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(58, 16);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(44, 22);
            this.usernameLabel.TabIndex = 23;
            this.usernameLabel.Text = "User";
            // 
            // accountLogo
            // 
            this.accountLogo.BackColor = System.Drawing.Color.Transparent;
            this.accountLogo.BackgroundImage = global::SignUpForm.Properties.Resources.icons8_user_100;
            this.accountLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountLogo.FlatAppearance.BorderSize = 0;
            this.accountLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountLogo.Location = new System.Drawing.Point(12, 3);
            this.accountLogo.Name = "accountLogo";
            this.accountLogo.Size = new System.Drawing.Size(40, 41);
            this.accountLogo.TabIndex = 22;
            this.accountLogo.UseVisualStyleBackColor = false;
            this.accountLogo.Click += new System.EventHandler(this.accountLogo_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Activecolor = System.Drawing.Color.Maroon;
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsBtn.BorderRadius = 7;
            this.SettingsBtn.ButtonText = "Settings";
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Iconimage")));
            this.SettingsBtn.Iconimage_right = null;
            this.SettingsBtn.Iconimage_right_Selected = null;
            this.SettingsBtn.Iconimage_Selected = null;
            this.SettingsBtn.IconMarginLeft = 0;
            this.SettingsBtn.IconMarginRight = 0;
            this.SettingsBtn.IconRightVisible = true;
            this.SettingsBtn.IconRightZoom = 0D;
            this.SettingsBtn.IconVisible = true;
            this.SettingsBtn.IconZoom = 40D;
            this.SettingsBtn.IsTab = false;
            this.SettingsBtn.Location = new System.Drawing.Point(765, 8);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.SettingsBtn.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.SettingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsBtn.selected = false;
            this.SettingsBtn.Size = new System.Drawing.Size(105, 33);
            this.SettingsBtn.TabIndex = 21;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Textcolor = System.Drawing.Color.Black;
            this.SettingsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnHome);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(906, 47);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.Maroon;
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.BorderRadius = 7;
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 40D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(15, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(87, 33);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.Black;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton3.BorderRadius = 7;
            this.bunifuFlatButton3.ButtonText = "Attendance";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 40D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(143, 6);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(115, 33);
            this.bunifuFlatButton3.TabIndex = 21;
            this.bunifuFlatButton3.Text = "Attendance";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Students";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(302, 6);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(107, 33);
            this.bunifuFlatButton2.TabIndex = 21;
            this.bunifuFlatButton2.Text = "Students";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton5.BorderRadius = 7;
            this.bunifuFlatButton5.ButtonText = "Reports";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 40D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(645, 6);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(105, 33);
            this.bunifuFlatButton5.TabIndex = 21;
            this.bunifuFlatButton5.Text = "Reports";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Subjects";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(469, 6);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(105, 33);
            this.bunifuFlatButton1.TabIndex = 21;
            this.bunifuFlatButton1.Text = "Subjects";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Activecolor = System.Drawing.Color.Maroon;
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.BorderRadius = 7;
            this.exitButton.ButtonText = "Exit";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledColor = System.Drawing.Color.Gray;
            this.exitButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitButton.Iconimage")));
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconMarginLeft = 0;
            this.exitButton.IconMarginRight = 0;
            this.exitButton.IconRightVisible = true;
            this.exitButton.IconRightZoom = 0D;
            this.exitButton.IconVisible = true;
            this.exitButton.IconZoom = 40D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(815, 5);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(76, 33);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Textcolor = System.Drawing.Color.Black;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(906, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuUserLabel.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button accountLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel usernameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuUserLabel;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFullnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}