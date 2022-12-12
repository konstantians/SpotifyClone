
namespace SpotifyWinformsClone
{
    partial class RegisterForm
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
            this.spotifyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pickResetQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.pickResetQuestionLabel = new System.Windows.Forms.Label();
            this.resetAnswerLabel = new System.Windows.Forms.Label();
            this.resetAnswerTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.narratorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // spotifyLogoPictureBox
            // 
            this.spotifyLogoPictureBox.Image = global::SpotifyWinformsClone.Properties.Resources.spotify_logo;
            this.spotifyLogoPictureBox.Location = new System.Drawing.Point(277, 12);
            this.spotifyLogoPictureBox.Name = "spotifyLogoPictureBox";
            this.spotifyLogoPictureBox.Size = new System.Drawing.Size(262, 93);
            this.spotifyLogoPictureBox.TabIndex = 1;
            this.spotifyLogoPictureBox.TabStop = false;
            // 
            // separatorLabel
            // 
            this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorLabel.Location = new System.Drawing.Point(-3, 118);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(815, 2);
            this.separatorLabel.TabIndex = 1;
            this.separatorLabel.Text = "........";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(201, 154);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(188, 22);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "ENTER USERNAME";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(205, 188);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(409, 35);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(201, 272);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(190, 22);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "ENTER PASSWORD";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(205, 306);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(409, 35);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // pickResetQuestionComboBox
            // 
            this.pickResetQuestionComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickResetQuestionComboBox.FormattingEnabled = true;
            this.pickResetQuestionComboBox.Items.AddRange(new object[] {
            "What is your favourite sport?",
            "What is your favourite food?",
            "Who is your best friend?"});
            this.pickResetQuestionComboBox.Location = new System.Drawing.Point(205, 504);
            this.pickResetQuestionComboBox.Name = "pickResetQuestionComboBox";
            this.pickResetQuestionComboBox.Size = new System.Drawing.Size(409, 30);
            this.pickResetQuestionComboBox.TabIndex = 10;
            this.pickResetQuestionComboBox.SelectedIndexChanged += new System.EventHandler(this.pickResetQuestionComboBox_SelectedIndexChanged);
            this.pickResetQuestionComboBox.Enter += new System.EventHandler(this.pickResetQuestionComboBox_Enter);
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(201, 388);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(212, 22);
            this.accountTypeLabel.TabIndex = 6;
            this.accountTypeLabel.Text = "PICK ACCOUNT TYPE";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.Location = new System.Drawing.Point(205, 419);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(69, 22);
            this.adminRadioButton.TabIndex = 7;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.Enter += new System.EventHandler(this.adminRadioButton_Enter);
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Checked = true;
            this.userRadioButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadioButton.Location = new System.Drawing.Point(316, 419);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(60, 22);
            this.userRadioButton.TabIndex = 8;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            this.userRadioButton.Enter += new System.EventHandler(this.userRadioButton_Enter);
            // 
            // pickResetQuestionLabel
            // 
            this.pickResetQuestionLabel.AutoSize = true;
            this.pickResetQuestionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickResetQuestionLabel.Location = new System.Drawing.Point(201, 470);
            this.pickResetQuestionLabel.Name = "pickResetQuestionLabel";
            this.pickResetQuestionLabel.Size = new System.Drawing.Size(231, 22);
            this.pickResetQuestionLabel.TabIndex = 9;
            this.pickResetQuestionLabel.Text = "PICK RESET QUESTION";
            // 
            // resetAnswerLabel
            // 
            this.resetAnswerLabel.AutoSize = true;
            this.resetAnswerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnswerLabel.Location = new System.Drawing.Point(201, 576);
            this.resetAnswerLabel.Name = "resetAnswerLabel";
            this.resetAnswerLabel.Size = new System.Drawing.Size(231, 22);
            this.resetAnswerLabel.TabIndex = 11;
            this.resetAnswerLabel.Text = "ENTER RESET ANSWER";
            // 
            // resetAnswerTextBox
            // 
            this.resetAnswerTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnswerTextBox.Location = new System.Drawing.Point(205, 610);
            this.resetAnswerTextBox.Name = "resetAnswerTextBox";
            this.resetAnswerTextBox.Size = new System.Drawing.Size(409, 35);
            this.resetAnswerTextBox.TabIndex = 12;
            this.resetAnswerTextBox.Enter += new System.EventHandler(this.resetAnswerTextBox_Enter);
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.BackColor = System.Drawing.Color.LimeGreen;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(456, 678);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(158, 40);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "SIGN UP";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.Enter += new System.EventHandler(this.registerButton_Enter);
            this.registerButton.MouseEnter += new System.EventHandler(this.RegisterButton_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.RegisterButton_MouseLeave);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(205, 678);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 40);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.Enter += new System.EventHandler(this.cancelButton_Enter);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // narratorButton
            // 
            this.narratorButton.Image = global::SpotifyWinformsClone.Properties.Resources.small_narrator_image;
            this.narratorButton.Location = new System.Drawing.Point(724, 12);
            this.narratorButton.Name = "narratorButton";
            this.narratorButton.Size = new System.Drawing.Size(73, 62);
            this.narratorButton.TabIndex = 20;
            this.narratorButton.UseVisualStyleBackColor = true;
            this.narratorButton.Click += new System.EventHandler(this.narratorButton_Click);
            this.narratorButton.Enter += new System.EventHandler(this.narratorButton_Enter);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 752);
            this.Controls.Add(this.narratorButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.resetAnswerTextBox);
            this.Controls.Add(this.resetAnswerLabel);
            this.Controls.Add(this.pickResetQuestionLabel);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.pickResetQuestionComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.spotifyLogoPictureBox);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyClone";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spotifyLogoPictureBox;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox pickResetQuestionComboBox;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.Label pickResetQuestionLabel;
        private System.Windows.Forms.Label resetAnswerLabel;
        private System.Windows.Forms.TextBox resetAnswerTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button narratorButton;
    }
}