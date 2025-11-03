namespace SignUpForm
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.passwordTextField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usernameTextField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fullnameTextField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // passwordTextField
            // 
            this.passwordTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextField.ForeColor = System.Drawing.Color.White;
            this.passwordTextField.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextField.HintText = "";
            this.passwordTextField.isPassword = false;
            this.passwordTextField.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.passwordTextField.LineIdleColor = System.Drawing.Color.DarkGray;
            this.passwordTextField.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.passwordTextField.LineThickness = 3;
            this.passwordTextField.Location = new System.Drawing.Point(13, 127);
            this.passwordTextField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.Size = new System.Drawing.Size(300, 21);
            this.passwordTextField.TabIndex = 1;
            this.passwordTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.roleComboBox.Location = new System.Drawing.Point(12, 255);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(200, 21);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Enter The Username :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 102);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(196, 21);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Enter The Password :";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Activecolor = System.Drawing.Color.Maroon;
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveBtn.BorderRadius = 7;
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SaveBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Iconimage")));
            this.SaveBtn.Iconimage_right = null;
            this.SaveBtn.Iconimage_right_Selected = null;
            this.SaveBtn.Iconimage_Selected = null;
            this.SaveBtn.IconMarginLeft = 0;
            this.SaveBtn.IconMarginRight = 0;
            this.SaveBtn.IconRightVisible = true;
            this.SaveBtn.IconRightZoom = 0D;
            this.SaveBtn.IconVisible = true;
            this.SaveBtn.IconZoom = 40D;
            this.SaveBtn.IsTab = false;
            this.SaveBtn.Location = new System.Drawing.Point(16, 320);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.SaveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveBtn.selected = false;
            this.SaveBtn.Size = new System.Drawing.Size(76, 33);
            this.SaveBtn.TabIndex = 23;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Textcolor = System.Drawing.Color.Black;
            this.SaveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 176);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(208, 21);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "Enter The Full Name :";
            // 
            // usernameTextField
            // 
            this.usernameTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernameTextField.ForeColor = System.Drawing.Color.White;
            this.usernameTextField.HintForeColor = System.Drawing.Color.Empty;
            this.usernameTextField.HintText = "";
            this.usernameTextField.isPassword = false;
            this.usernameTextField.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.usernameTextField.LineIdleColor = System.Drawing.Color.DarkGray;
            this.usernameTextField.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.usernameTextField.LineThickness = 3;
            this.usernameTextField.Location = new System.Drawing.Point(13, 55);
            this.usernameTextField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.Size = new System.Drawing.Size(300, 21);
            this.usernameTextField.TabIndex = 1;
            this.usernameTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fullnameTextField
            // 
            this.fullnameTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnameTextField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fullnameTextField.ForeColor = System.Drawing.Color.White;
            this.fullnameTextField.HintForeColor = System.Drawing.Color.Empty;
            this.fullnameTextField.HintText = "";
            this.fullnameTextField.isPassword = false;
            this.fullnameTextField.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.fullnameTextField.LineIdleColor = System.Drawing.Color.DarkGray;
            this.fullnameTextField.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.fullnameTextField.LineThickness = 3;
            this.fullnameTextField.Location = new System.Drawing.Point(13, 201);
            this.fullnameTextField.Margin = new System.Windows.Forms.Padding(4);
            this.fullnameTextField.Name = "fullnameTextField";
            this.fullnameTextField.Size = new System.Drawing.Size(300, 21);
            this.fullnameTextField.TabIndex = 1;
            this.fullnameTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(364, 367);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.usernameTextField);
            this.Controls.Add(this.fullnameTextField);
            this.Controls.Add(this.passwordTextField);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextField;
        private System.Windows.Forms.ComboBox roleComboBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton SaveBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTextField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fullnameTextField;
    }
}