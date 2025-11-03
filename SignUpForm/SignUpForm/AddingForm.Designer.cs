namespace SignUpForm
{
    partial class AddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingForm));
            this.titleLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.majorLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.levelLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.subjectLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupLable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createRadioButton = new System.Windows.Forms.RadioButton();
            this.openRadioButton = new System.Windows.Forms.RadioButton();
            this.nextButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLable.Location = new System.Drawing.Point(219, 30);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(389, 65);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Adding Table";
            // 
            // majorComboBox
            // 
            this.majorComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.majorComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(273, 175);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(446, 33);
            this.majorComboBox.TabIndex = 2;
            // 
            // levelComboBox
            // 
            this.levelComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(273, 246);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(446, 33);
            this.levelComboBox.TabIndex = 3;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(273, 309);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(446, 33);
            this.subjectComboBox.TabIndex = 4;
            // 
            // groupComboBox
            // 
            this.groupComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(273, 370);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(446, 33);
            this.groupComboBox.TabIndex = 5;
            // 
            // majorLable
            // 
            this.majorLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.majorLable.AutoSize = true;
            this.majorLable.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLable.ForeColor = System.Drawing.SystemColors.Control;
            this.majorLable.Location = new System.Drawing.Point(27, 156);
            this.majorLable.Name = "majorLable";
            this.majorLable.Size = new System.Drawing.Size(107, 36);
            this.majorLable.TabIndex = 6;
            this.majorLable.Text = "Major";
            // 
            // levelLable
            // 
            this.levelLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.levelLable.AutoSize = true;
            this.levelLable.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLable.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLable.Location = new System.Drawing.Point(27, 227);
            this.levelLable.Name = "levelLable";
            this.levelLable.Size = new System.Drawing.Size(98, 36);
            this.levelLable.TabIndex = 7;
            this.levelLable.Text = "Level";
            // 
            // subjectLable
            // 
            this.subjectLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectLable.AutoSize = true;
            this.subjectLable.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLable.ForeColor = System.Drawing.SystemColors.Control;
            this.subjectLable.Location = new System.Drawing.Point(27, 290);
            this.subjectLable.Name = "subjectLable";
            this.subjectLable.Size = new System.Drawing.Size(125, 36);
            this.subjectLable.TabIndex = 8;
            this.subjectLable.Text = "Subject";
            // 
            // groupLable
            // 
            this.groupLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupLable.AutoSize = true;
            this.groupLable.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLable.ForeColor = System.Drawing.SystemColors.Control;
            this.groupLable.Location = new System.Drawing.Point(12, 353);
            this.groupLable.Name = "groupLable";
            this.groupLable.Size = new System.Drawing.Size(239, 36);
            this.groupLable.TabIndex = 9;
            this.groupLable.Text = "Group Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.openRadioButton);
            this.groupBox1.Controls.Add(this.createRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(288, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 288);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // createRadioButton
            // 
            this.createRadioButton.AutoSize = true;
            this.createRadioButton.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createRadioButton.Location = new System.Drawing.Point(18, 56);
            this.createRadioButton.Name = "createRadioButton";
            this.createRadioButton.Size = new System.Drawing.Size(316, 42);
            this.createRadioButton.TabIndex = 0;
            this.createRadioButton.TabStop = true;
            this.createRadioButton.Text = "Create New Table";
            this.createRadioButton.UseVisualStyleBackColor = true;
            // 
            // openRadioButton
            // 
            this.openRadioButton.AutoSize = true;
            this.openRadioButton.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.openRadioButton.Location = new System.Drawing.Point(18, 126);
            this.openRadioButton.Name = "openRadioButton";
            this.openRadioButton.Size = new System.Drawing.Size(390, 42);
            this.openRadioButton.TabIndex = 1;
            this.openRadioButton.TabStop = true;
            this.openRadioButton.Text = "Open an Existent File";
            this.openRadioButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.ActiveBorderThickness = 1;
            this.nextButton.ActiveCornerRadius = 20;
            this.nextButton.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.nextButton.ActiveForecolor = System.Drawing.Color.White;
            this.nextButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.ButtonText = "Next";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleBorderThickness = 1;
            this.nextButton.IdleCornerRadius = 20;
            this.nextButton.IdleFillColor = System.Drawing.Color.White;
            this.nextButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.Location = new System.Drawing.Point(61, 197);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(287, 69);
            this.nextButton.TabIndex = 11;
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::SignUpForm.Properties.Resources.button_copy_51x51;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(711, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 44);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupLable);
            this.Controls.Add(this.subjectLable);
            this.Controls.Add(this.levelLable);
            this.Controls.Add(this.majorLable);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.majorComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel titleLable;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private Bunifu.Framework.UI.BunifuCustomLabel majorLable;
        private Bunifu.Framework.UI.BunifuCustomLabel levelLable;
        private Bunifu.Framework.UI.BunifuCustomLabel subjectLable;
        private Bunifu.Framework.UI.BunifuCustomLabel groupLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 nextButton;
        private System.Windows.Forms.RadioButton openRadioButton;
        private System.Windows.Forms.RadioButton createRadioButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}