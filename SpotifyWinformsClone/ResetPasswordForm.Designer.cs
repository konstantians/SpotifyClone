
namespace SpotifyWinformsClone
{
    partial class ResetPasswordForm
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
            this.separatorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetAnswerTextBox = new System.Windows.Forms.TextBox();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.resetQuestionLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.spotifyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.narratorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.usernameLabel.Size = new System.Drawing.Size(118, 22);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "USERNAME";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(205, 188);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(409, 35);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(201, 373);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(238, 22);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "ENTER NEW PASSWORD";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(205, 412);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(409, 35);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(205, 606);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(161, 40);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.Enter += new System.EventHandler(this.cancelButton_Enter);
            // 
            // resetAnswerTextBox
            // 
            this.resetAnswerTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnswerTextBox.Location = new System.Drawing.Point(205, 292);
            this.resetAnswerTextBox.Name = "resetAnswerTextBox";
            this.resetAnswerTextBox.Size = new System.Drawing.Size(409, 35);
            this.resetAnswerTextBox.TabIndex = 5;
            this.resetAnswerTextBox.Enter += new System.EventHandler(this.resetAnswerTextBox_Enter);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetPasswordButton.BackColor = System.Drawing.Color.LimeGreen;
            this.resetPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.Location = new System.Drawing.Point(441, 606);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(173, 40);
            this.resetPasswordButton.TabIndex = 11;
            this.resetPasswordButton.Text = "RESET PASSWORD";
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            this.resetPasswordButton.Enter += new System.EventHandler(this.resetPasswordButton_Enter);
            // 
            // resetQuestionLabel
            // 
            this.resetQuestionLabel.AutoSize = true;
            this.resetQuestionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuestionLabel.Location = new System.Drawing.Point(201, 267);
            this.resetQuestionLabel.Name = "resetQuestionLabel";
            this.resetQuestionLabel.Size = new System.Drawing.Size(16, 22);
            this.resetQuestionLabel.TabIndex = 4;
            this.resetQuestionLabel.Text = "-";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordLabel.Location = new System.Drawing.Point(201, 495);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(250, 22);
            this.repeatPasswordLabel.TabIndex = 8;
            this.repeatPasswordLabel.Text = "REPEAT NEW PASSWORD";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(205, 531);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(409, 35);
            this.repeatPasswordTextBox.TabIndex = 9;
            this.repeatPasswordTextBox.Enter += new System.EventHandler(this.repeatPasswordTextBox_Enter);
            // 
            // spotifyLogoPictureBox
            // 
            this.spotifyLogoPictureBox.Image = global::SpotifyWinformsClone.Properties.Resources.spotify_logo;
            this.spotifyLogoPictureBox.Location = new System.Drawing.Point(277, 12);
            this.spotifyLogoPictureBox.Name = "spotifyLogoPictureBox";
            this.spotifyLogoPictureBox.Size = new System.Drawing.Size(262, 93);
            this.spotifyLogoPictureBox.TabIndex = 2;
            this.spotifyLogoPictureBox.TabStop = false;
            // 
            // narratorButton
            // 
            this.narratorButton.Image = global::SpotifyWinformsClone.Properties.Resources.small_narrator_image;
            this.narratorButton.Location = new System.Drawing.Point(724, 12);
            this.narratorButton.Name = "narratorButton";
            this.narratorButton.Size = new System.Drawing.Size(73, 62);
            this.narratorButton.TabIndex = 26;
            this.narratorButton.UseVisualStyleBackColor = true;
            this.narratorButton.Click += new System.EventHandler(this.narratorButton_Click);
            this.narratorButton.Enter += new System.EventHandler(this.narratorButton_Enter);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 682);
            this.Controls.Add(this.narratorButton);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.resetQuestionLabel);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.resetAnswerTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.spotifyLogoPictureBox);
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyClone";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResetPasswordForm_FormClosed);
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox resetAnswerTextBox;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.Label resetQuestionLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Button narratorButton;
    }
}