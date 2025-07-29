namespace SignUpForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lablePassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lableConfirmPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.confirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lableConfirm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.iconConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lablePassword
            // 
            this.lablePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lablePassword.AutoSize = true;
            this.lablePassword.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lablePassword.Location = new System.Drawing.Point(190, 110);
            this.lablePassword.Name = "lablePassword";
            this.lablePassword.Size = new System.Drawing.Size(235, 25);
            this.lablePassword.TabIndex = 0;
            this.lablePassword.Text = "Enter the Password :";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(353, 393);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(86, 46);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(292, 60);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(243, 65);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Sign Up";
            // 
            // lableConfirmPassword
            // 
            this.lableConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lableConfirmPassword.AutoSize = true;
            this.lableConfirmPassword.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableConfirmPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lableConfirmPassword.Location = new System.Drawing.Point(190, 249);
            this.lableConfirmPassword.Name = "lableConfirmPassword";
            this.lableConfirmPassword.Size = new System.Drawing.Size(261, 25);
            this.lableConfirmPassword.TabIndex = 0;
            this.lableConfirmPassword.Text = "Confirm the Password :";
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
            this.exitButton.Iconimage = global::SignUpForm.Properties.Resources.logout;
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
            this.exitButton.Location = new System.Drawing.Point(709, 14);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(76, 43);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Textcolor = System.Drawing.Color.MediumAquamarine;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.HintText = "";
            this.passwordTextBox.isPassword = false;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.White;
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.passwordTextBox.LineThickness = 4;
            this.passwordTextBox.Location = new System.Drawing.Point(195, 160);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(428, 67);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.Black;
            this.confirmPassword.HintForeColor = System.Drawing.Color.Empty;
            this.confirmPassword.HintText = "";
            this.confirmPassword.isPassword = false;
            this.confirmPassword.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.confirmPassword.LineIdleColor = System.Drawing.Color.White;
            this.confirmPassword.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.confirmPassword.LineThickness = 4;
            this.confirmPassword.Location = new System.Drawing.Point(195, 299);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(6);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(428, 67);
            this.confirmPassword.TabIndex = 10;
            this.confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lableConfirm
            // 
            this.lableConfirm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lableConfirm.AutoSize = true;
            this.lableConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lableConfirm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lableConfirm.Location = new System.Drawing.Point(726, 97);
            this.lableConfirm.Name = "lableConfirm";
            this.lableConfirm.Size = new System.Drawing.Size(22, 18);
            this.lableConfirm.TabIndex = 11;
            this.lableConfirm.Text = "H";
            // 
            // iconConfirm
            // 
            this.iconConfirm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconConfirm.BackColor = System.Drawing.Color.Transparent;
            this.iconConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconConfirm.Location = new System.Drawing.Point(662, 337);
            this.iconConfirm.Name = "iconConfirm";
            this.iconConfirm.Size = new System.Drawing.Size(100, 50);
            this.iconConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconConfirm.TabIndex = 12;
            this.iconConfirm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.iconConfirm);
            this.Controls.Add(this.lableConfirm);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.lableConfirmPassword);
            this.Controls.Add(this.lablePassword);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.exitButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.iconConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel lableConfirmPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lablePassword;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel lableConfirm;
        private System.Windows.Forms.PictureBox iconConfirm;
    }
}

