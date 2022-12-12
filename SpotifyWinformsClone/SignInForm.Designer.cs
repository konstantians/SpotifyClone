
namespace SpotifyWinformsClone
{
    partial class SignInForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.logInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.spotifyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.narratorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(201, 154);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 22);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
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
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(201, 272);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 22);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
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
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.Location = new System.Drawing.Point(205, 414);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(67, 20);
            this.adminRadioButton.TabIndex = 7;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.Enter += new System.EventHandler(this.adminRadioButton_Enter);
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(201, 383);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(136, 19);
            this.accountTypeLabel.TabIndex = 6;
            this.accountTypeLabel.Text = "ACCOUNT TYPE";
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Checked = true;
            this.userRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadioButton.Location = new System.Drawing.Point(324, 414);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(54, 20);
            this.userRadioButton.TabIndex = 8;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            this.userRadioButton.Enter += new System.EventHandler(this.userRadioButton_Enter);
            // 
            // logInButton
            // 
            this.logInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInButton.BackColor = System.Drawing.Color.LimeGreen;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(205, 463);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(158, 40);
            this.logInButton.TabIndex = 9;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            this.logInButton.Enter += new System.EventHandler(this.logInButton_Enter);
            this.logInButton.MouseEnter += new System.EventHandler(this.logInButton_MouseEnter);
            this.logInButton.MouseLeave += new System.EventHandler(this.logInButton_MouseLeave);
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpButton.BackColor = System.Drawing.Color.LimeGreen;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(456, 463);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(158, 40);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            this.signUpButton.Enter += new System.EventHandler(this.signUpButton_Enter);
            this.signUpButton.MouseEnter += new System.EventHandler(this.signUpButton_MouseEnter);
            this.signUpButton.MouseLeave += new System.EventHandler(this.signUpButton_MouseLeave);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.Location = new System.Drawing.Point(202, 544);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(348, 16);
            this.forgotPasswordLabel.TabIndex = 11;
            this.forgotPasswordLabel.Text = "Forgot Password, Click The Button Below To Reset It :";
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.resetPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resetPasswordButton.Location = new System.Drawing.Point(277, 583);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(275, 46);
            this.resetPasswordButton.TabIndex = 12;
            this.resetPasswordButton.Text = "RESET PASSWORD";
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            this.resetPasswordButton.Enter += new System.EventHandler(this.resetPasswordButton_Enter);
            this.resetPasswordButton.MouseEnter += new System.EventHandler(this.resetPasswordButton_MouseEnter);
            this.resetPasswordButton.MouseLeave += new System.EventHandler(this.resetPasswordButton_MouseLeave);
            // 
            // spotifyLogoPictureBox
            // 
            this.spotifyLogoPictureBox.Image = global::SpotifyWinformsClone.Properties.Resources.spotify_logo;
            this.spotifyLogoPictureBox.Location = new System.Drawing.Point(277, 12);
            this.spotifyLogoPictureBox.Name = "spotifyLogoPictureBox";
            this.spotifyLogoPictureBox.Size = new System.Drawing.Size(262, 93);
            this.spotifyLogoPictureBox.TabIndex = 0;
            this.spotifyLogoPictureBox.TabStop = false;
            // 
            // narratorButton
            // 
            this.narratorButton.Image = global::SpotifyWinformsClone.Properties.Resources.small_narrator_image;
            this.narratorButton.Location = new System.Drawing.Point(724, 12);
            this.narratorButton.Name = "narratorButton";
            this.narratorButton.Size = new System.Drawing.Size(73, 62);
            this.narratorButton.TabIndex = 13;
            this.narratorButton.UseVisualStyleBackColor = true;
            this.narratorButton.Click += new System.EventHandler(this.narratorButton_Click);
            this.narratorButton.Enter += new System.EventHandler(this.narratorButton_Enter);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 659);
            this.Controls.Add(this.narratorButton);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.spotifyLogoPictureBox);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyClone";
            this.EnabledChanged += new System.EventHandler(this.SignInForm_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spotifyLogoPictureBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.Button narratorButton;
    }
}

