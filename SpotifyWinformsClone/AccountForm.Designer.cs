
namespace SpotifyWinformsClone
{
    partial class AccountForm
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
            this.accountLabel = new System.Windows.Forms.Label();
            this.songPanel = new System.Windows.Forms.Panel();
            this.songPanel1 = new System.Windows.Forms.Panel();
            this.playButton1 = new System.Windows.Forms.Button();
            this.refundButton1 = new System.Windows.Forms.Button();
            this.songRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.songLabel1 = new System.Windows.Forms.Label();
            this.songPanel2 = new System.Windows.Forms.Panel();
            this.playButton2 = new System.Windows.Forms.Button();
            this.refundButton2 = new System.Windows.Forms.Button();
            this.songRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.songLabel2 = new System.Windows.Forms.Label();
            this.songPanel3 = new System.Windows.Forms.Panel();
            this.playButton3 = new System.Windows.Forms.Button();
            this.refundButton3 = new System.Windows.Forms.Button();
            this.songRichTextBox3 = new System.Windows.Forms.RichTextBox();
            this.songLabel3 = new System.Windows.Forms.Label();
            this.userGallerySongLabel = new System.Windows.Forms.Label();
            this.songListOneButton = new System.Windows.Forms.Button();
            this.songListTwoButton = new System.Windows.Forms.Button();
            this.songListFourButton = new System.Windows.Forms.Button();
            this.songListThreeButton = new System.Windows.Forms.Button();
            this.songListFiveButton = new System.Windows.Forms.Button();
            this.songListSixButton = new System.Windows.Forms.Button();
            this.accountDetailsLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.resetQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.resetQuestionLabel = new System.Windows.Forms.Label();
            this.resetAnswerTextBox = new System.Windows.Forms.TextBox();
            this.resetAnswerLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.signOutButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.songGalleryButton = new System.Windows.Forms.Button();
            this.narratorButton = new System.Windows.Forms.Button();
            this.songPanel.SuspendLayout();
            this.songPanel1.SuspendLayout();
            this.songPanel2.SuspendLayout();
            this.songPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // separatorLabel
            // 
            this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorLabel.Location = new System.Drawing.Point(0, 69);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(1000, 2);
            this.separatorLabel.TabIndex = 8;
            this.separatorLabel.Text = "........";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(385, 9);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(188, 41);
            this.accountLabel.TabIndex = 1;
            this.accountLabel.Text = "ACCOUNT";
            // 
            // songPanel
            // 
            this.songPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.songPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songPanel.Controls.Add(this.songPanel1);
            this.songPanel.Controls.Add(this.songPanel2);
            this.songPanel.Controls.Add(this.songPanel3);
            this.songPanel.Location = new System.Drawing.Point(0, 121);
            this.songPanel.Name = "songPanel";
            this.songPanel.Size = new System.Drawing.Size(941, 309);
            this.songPanel.TabIndex = 3;
            // 
            // songPanel1
            // 
            this.songPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.songPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songPanel1.Controls.Add(this.playButton1);
            this.songPanel1.Controls.Add(this.refundButton1);
            this.songPanel1.Controls.Add(this.songRichTextBox1);
            this.songPanel1.Controls.Add(this.songLabel1);
            this.songPanel1.Location = new System.Drawing.Point(39, 26);
            this.songPanel1.Name = "songPanel1";
            this.songPanel1.Size = new System.Drawing.Size(259, 250);
            this.songPanel1.TabIndex = 4;
            // 
            // playButton1
            // 
            this.playButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.playButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton1.Location = new System.Drawing.Point(150, 188);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(95, 40);
            this.playButton1.TabIndex = 8;
            this.playButton1.Text = "PLAY";
            this.playButton1.UseVisualStyleBackColor = false;
            this.playButton1.Visible = false;
            this.playButton1.Click += new System.EventHandler(this.playButton1_Click);
            this.playButton1.Enter += new System.EventHandler(this.playButton1_Enter);
            // 
            // refundButton1
            // 
            this.refundButton1.BackColor = System.Drawing.SystemColors.ControlText;
            this.refundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.refundButton1.Location = new System.Drawing.Point(13, 188);
            this.refundButton1.Name = "refundButton1";
            this.refundButton1.Size = new System.Drawing.Size(95, 40);
            this.refundButton1.TabIndex = 7;
            this.refundButton1.Text = "REFUND";
            this.refundButton1.UseVisualStyleBackColor = false;
            this.refundButton1.Visible = false;
            this.refundButton1.Click += new System.EventHandler(this.refundButton1_Click);
            this.refundButton1.Enter += new System.EventHandler(this.refundButton1_Enter);
            // 
            // songRichTextBox1
            // 
            this.songRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songRichTextBox1.Location = new System.Drawing.Point(13, 51);
            this.songRichTextBox1.Name = "songRichTextBox1";
            this.songRichTextBox1.ReadOnly = true;
            this.songRichTextBox1.Size = new System.Drawing.Size(232, 116);
            this.songRichTextBox1.TabIndex = 6;
            this.songRichTextBox1.Text = "";
            this.songRichTextBox1.Visible = false;
            this.songRichTextBox1.Enter += new System.EventHandler(this.songRichTextBox1_Enter);
            // 
            // songLabel1
            // 
            this.songLabel1.AutoSize = true;
            this.songLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel1.Location = new System.Drawing.Point(9, 16);
            this.songLabel1.Name = "songLabel1";
            this.songLabel1.Size = new System.Drawing.Size(112, 22);
            this.songLabel1.TabIndex = 5;
            this.songLabel1.Text = "SONG ONE";
            this.songLabel1.Visible = false;
            // 
            // songPanel2
            // 
            this.songPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.songPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songPanel2.Controls.Add(this.playButton2);
            this.songPanel2.Controls.Add(this.refundButton2);
            this.songPanel2.Controls.Add(this.songRichTextBox2);
            this.songPanel2.Controls.Add(this.songLabel2);
            this.songPanel2.Location = new System.Drawing.Point(339, 26);
            this.songPanel2.Name = "songPanel2";
            this.songPanel2.Size = new System.Drawing.Size(259, 250);
            this.songPanel2.TabIndex = 9;
            // 
            // playButton2
            // 
            this.playButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton2.BackColor = System.Drawing.Color.LimeGreen;
            this.playButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton2.Location = new System.Drawing.Point(150, 188);
            this.playButton2.Name = "playButton2";
            this.playButton2.Size = new System.Drawing.Size(95, 40);
            this.playButton2.TabIndex = 13;
            this.playButton2.Text = "PLAY";
            this.playButton2.UseVisualStyleBackColor = false;
            this.playButton2.Visible = false;
            this.playButton2.Click += new System.EventHandler(this.playButton2_Click);
            this.playButton2.Enter += new System.EventHandler(this.playButton2_Enter);
            // 
            // refundButton2
            // 
            this.refundButton2.BackColor = System.Drawing.SystemColors.ControlText;
            this.refundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.refundButton2.Location = new System.Drawing.Point(13, 188);
            this.refundButton2.Name = "refundButton2";
            this.refundButton2.Size = new System.Drawing.Size(95, 40);
            this.refundButton2.TabIndex = 12;
            this.refundButton2.Text = "REFUND";
            this.refundButton2.UseVisualStyleBackColor = false;
            this.refundButton2.Visible = false;
            this.refundButton2.Click += new System.EventHandler(this.refundButton2_Click);
            this.refundButton2.Enter += new System.EventHandler(this.refundButton2_Enter);
            // 
            // songRichTextBox2
            // 
            this.songRichTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songRichTextBox2.Location = new System.Drawing.Point(13, 51);
            this.songRichTextBox2.Name = "songRichTextBox2";
            this.songRichTextBox2.ReadOnly = true;
            this.songRichTextBox2.Size = new System.Drawing.Size(232, 116);
            this.songRichTextBox2.TabIndex = 11;
            this.songRichTextBox2.Text = "";
            this.songRichTextBox2.Visible = false;
            this.songRichTextBox2.Enter += new System.EventHandler(this.songRichTextBox2_Enter);
            // 
            // songLabel2
            // 
            this.songLabel2.AutoSize = true;
            this.songLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel2.Location = new System.Drawing.Point(9, 16);
            this.songLabel2.Name = "songLabel2";
            this.songLabel2.Size = new System.Drawing.Size(112, 22);
            this.songLabel2.TabIndex = 10;
            this.songLabel2.Text = "SONG ONE";
            this.songLabel2.Visible = false;
            // 
            // songPanel3
            // 
            this.songPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.songPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songPanel3.Controls.Add(this.playButton3);
            this.songPanel3.Controls.Add(this.refundButton3);
            this.songPanel3.Controls.Add(this.songRichTextBox3);
            this.songPanel3.Controls.Add(this.songLabel3);
            this.songPanel3.Location = new System.Drawing.Point(638, 26);
            this.songPanel3.Name = "songPanel3";
            this.songPanel3.Size = new System.Drawing.Size(259, 250);
            this.songPanel3.TabIndex = 14;
            // 
            // playButton3
            // 
            this.playButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton3.BackColor = System.Drawing.Color.LimeGreen;
            this.playButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton3.Location = new System.Drawing.Point(150, 188);
            this.playButton3.Name = "playButton3";
            this.playButton3.Size = new System.Drawing.Size(95, 40);
            this.playButton3.TabIndex = 18;
            this.playButton3.Text = "PLAY";
            this.playButton3.UseVisualStyleBackColor = false;
            this.playButton3.Visible = false;
            this.playButton3.Click += new System.EventHandler(this.playButton3_Click);
            this.playButton3.Enter += new System.EventHandler(this.playButton3_Enter);
            // 
            // refundButton3
            // 
            this.refundButton3.BackColor = System.Drawing.SystemColors.ControlText;
            this.refundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundButton3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundButton3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.refundButton3.Location = new System.Drawing.Point(13, 188);
            this.refundButton3.Name = "refundButton3";
            this.refundButton3.Size = new System.Drawing.Size(95, 40);
            this.refundButton3.TabIndex = 17;
            this.refundButton3.Text = "REFUND";
            this.refundButton3.UseVisualStyleBackColor = false;
            this.refundButton3.Visible = false;
            this.refundButton3.Click += new System.EventHandler(this.refundButton3_Click);
            this.refundButton3.Enter += new System.EventHandler(this.refundButton3_Enter);
            // 
            // songRichTextBox3
            // 
            this.songRichTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songRichTextBox3.Location = new System.Drawing.Point(13, 51);
            this.songRichTextBox3.Name = "songRichTextBox3";
            this.songRichTextBox3.ReadOnly = true;
            this.songRichTextBox3.Size = new System.Drawing.Size(232, 116);
            this.songRichTextBox3.TabIndex = 16;
            this.songRichTextBox3.Text = "";
            this.songRichTextBox3.Visible = false;
            this.songRichTextBox3.Enter += new System.EventHandler(this.songRichTextBox3_Enter);
            // 
            // songLabel3
            // 
            this.songLabel3.AutoSize = true;
            this.songLabel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel3.Location = new System.Drawing.Point(11, 16);
            this.songLabel3.Name = "songLabel3";
            this.songLabel3.Size = new System.Drawing.Size(112, 22);
            this.songLabel3.TabIndex = 15;
            this.songLabel3.Text = "SONG ONE";
            this.songLabel3.Visible = false;
            // 
            // userGallerySongLabel
            // 
            this.userGallerySongLabel.AutoSize = true;
            this.userGallerySongLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGallerySongLabel.Location = new System.Drawing.Point(401, 81);
            this.userGallerySongLabel.Name = "userGallerySongLabel";
            this.userGallerySongLabel.Size = new System.Drawing.Size(148, 24);
            this.userGallerySongLabel.TabIndex = 2;
            this.userGallerySongLabel.Text = "YOUR SONGS";
            // 
            // songListOneButton
            // 
            this.songListOneButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.songListOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songListOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songListOneButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListOneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songListOneButton.Location = new System.Drawing.Point(340, 448);
            this.songListOneButton.Name = "songListOneButton";
            this.songListOneButton.Size = new System.Drawing.Size(28, 29);
            this.songListOneButton.TabIndex = 19;
            this.songListOneButton.Text = "1";
            this.songListOneButton.UseVisualStyleBackColor = false;
            this.songListOneButton.Click += new System.EventHandler(this.songListOneButton_Click);
            this.songListOneButton.Enter += new System.EventHandler(this.songListOneButton_Enter);
            // 
            // songListTwoButton
            // 
            this.songListTwoButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.songListTwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songListTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songListTwoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListTwoButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songListTwoButton.Location = new System.Drawing.Point(390, 448);
            this.songListTwoButton.Name = "songListTwoButton";
            this.songListTwoButton.Size = new System.Drawing.Size(28, 29);
            this.songListTwoButton.TabIndex = 20;
            this.songListTwoButton.Text = "2";
            this.songListTwoButton.UseVisualStyleBackColor = false;
            this.songListTwoButton.Click += new System.EventHandler(this.songListTwoButton_Click);
            this.songListTwoButton.Enter += new System.EventHandler(this.songListTwoButton_Enter);
            // 
            // songListFourButton
            // 
            this.songListFourButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.songListFourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songListFourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songListFourButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListFourButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songListFourButton.Location = new System.Drawing.Point(490, 448);
            this.songListFourButton.Name = "songListFourButton";
            this.songListFourButton.Size = new System.Drawing.Size(28, 29);
            this.songListFourButton.TabIndex = 22;
            this.songListFourButton.Text = "4";
            this.songListFourButton.UseVisualStyleBackColor = false;
            this.songListFourButton.Click += new System.EventHandler(this.songListFourButton_Click);
            this.songListFourButton.Enter += new System.EventHandler(this.songListFourButton_Enter);
            // 
            // songListThreeButton
            // 
            this.songListThreeButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.songListThreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songListThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songListThreeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListThreeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songListThreeButton.Location = new System.Drawing.Point(440, 448);
            this.songListThreeButton.Name = "songListThreeButton";
            this.songListThreeButton.Size = new System.Drawing.Size(28, 29);
            this.songListThreeButton.TabIndex = 21;
            this.songListThreeButton.Text = "3";
            this.songListThreeButton.UseVisualStyleBackColor = false;
            this.songListThreeButton.Click += new System.EventHandler(this.songListThreeButton_Click);
            this.songListThreeButton.Enter += new System.EventHandler(this.songListThreeButton_Enter);
            // 
            // songListFiveButton
            // 
            this.songListFiveButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.songListFiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songListFiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songListFiveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListFiveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songListFiveButton.Location = new System.Drawing.Point(540, 448);
            this.songListFiveButton.Name = "songListFiveButton";
            this.songListFiveButton.Size = new System.Drawing.Size(28, 29);
            this.songListFiveButton.TabIndex = 23;
            this.songListFiveButton.Text = "5";
            this.songListFiveButton.UseVisualStyleBackColor = false;
            this.songListFiveButton.Click += new System.EventHandler(this.songListFiveButton_Click);
            this.songListFiveButton.Enter += new System.EventHandler(this.songListFiveButton_Enter);
            // 
            // songListSixButton
            // 
            this.songListSixButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.songListSixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songListSixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songListSixButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListSixButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.songListSixButton.Location = new System.Drawing.Point(590, 448);
            this.songListSixButton.Name = "songListSixButton";
            this.songListSixButton.Size = new System.Drawing.Size(28, 29);
            this.songListSixButton.TabIndex = 24;
            this.songListSixButton.Text = "6";
            this.songListSixButton.UseVisualStyleBackColor = false;
            this.songListSixButton.Click += new System.EventHandler(this.songListSixButton_Click);
            this.songListSixButton.Enter += new System.EventHandler(this.songListSixButton_Enter);
            // 
            // accountDetailsLabel
            // 
            this.accountDetailsLabel.AutoSize = true;
            this.accountDetailsLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountDetailsLabel.Location = new System.Drawing.Point(368, 503);
            this.accountDetailsLabel.Name = "accountDetailsLabel";
            this.accountDetailsLabel.Size = new System.Drawing.Size(205, 24);
            this.accountDetailsLabel.TabIndex = 25;
            this.accountDetailsLabel.Text = "ACCOUNT DETAILS";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(36, 546);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(118, 22);
            this.usernameLabel.TabIndex = 26;
            this.usernameLabel.Text = "USERNAME";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(40, 580);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(260, 35);
            this.usernameTextBox.TabIndex = 27;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(364, 580);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(260, 35);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(360, 546);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 22);
            this.passwordLabel.TabIndex = 28;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Enabled = false;
            this.scoreTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(688, 580);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(210, 35);
            this.scoreTextBox.TabIndex = 31;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(684, 546);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(78, 22);
            this.scoreLabel.TabIndex = 30;
            this.scoreLabel.Text = "SCORE";
            // 
            // resetQuestionComboBox
            // 
            this.resetQuestionComboBox.Enabled = false;
            this.resetQuestionComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuestionComboBox.FormattingEnabled = true;
            this.resetQuestionComboBox.Items.AddRange(new object[] {
            "What is your favourite sport?",
            "What is your favourite food?",
            "Who is your best friend?"});
            this.resetQuestionComboBox.Location = new System.Drawing.Point(40, 676);
            this.resetQuestionComboBox.Name = "resetQuestionComboBox";
            this.resetQuestionComboBox.Size = new System.Drawing.Size(260, 30);
            this.resetQuestionComboBox.TabIndex = 36;
            this.resetQuestionComboBox.SelectedIndexChanged += new System.EventHandler(this.resetQuestionComboBox_SelectedIndexChanged);
            this.resetQuestionComboBox.Enter += new System.EventHandler(this.resetQuestionComboBox_Enter);
            // 
            // resetQuestionLabel
            // 
            this.resetQuestionLabel.AutoSize = true;
            this.resetQuestionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuestionLabel.Location = new System.Drawing.Point(36, 641);
            this.resetQuestionLabel.Name = "resetQuestionLabel";
            this.resetQuestionLabel.Size = new System.Drawing.Size(180, 22);
            this.resetQuestionLabel.TabIndex = 37;
            this.resetQuestionLabel.Text = "RESET QUESTION";
            // 
            // resetAnswerTextBox
            // 
            this.resetAnswerTextBox.Enabled = false;
            this.resetAnswerTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnswerTextBox.Location = new System.Drawing.Point(364, 676);
            this.resetAnswerTextBox.Name = "resetAnswerTextBox";
            this.resetAnswerTextBox.Size = new System.Drawing.Size(260, 35);
            this.resetAnswerTextBox.TabIndex = 38;
            this.resetAnswerTextBox.Enter += new System.EventHandler(this.resetAnswerTextBox_Enter);
            // 
            // resetAnswerLabel
            // 
            this.resetAnswerLabel.AutoSize = true;
            this.resetAnswerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnswerLabel.Location = new System.Drawing.Point(360, 641);
            this.resetAnswerLabel.Name = "resetAnswerLabel";
            this.resetAnswerLabel.Size = new System.Drawing.Size(161, 22);
            this.resetAnswerLabel.TabIndex = 39;
            this.resetAnswerLabel.Text = "RESET ANSWER";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(684, 641);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(162, 22);
            this.accountTypeLabel.TabIndex = 40;
            this.accountTypeLabel.Text = "ACCOUNT TYPE";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Enabled = false;
            this.adminRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.Location = new System.Drawing.Point(688, 685);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(67, 20);
            this.adminRadioButton.TabIndex = 41;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.Enter += new System.EventHandler(this.adminRadioButton_Enter);
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Enabled = false;
            this.userRadioButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadioButton.Location = new System.Drawing.Point(777, 684);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(60, 22);
            this.userRadioButton.TabIndex = 42;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            this.userRadioButton.Enter += new System.EventHandler(this.userRadioButton_Enter);
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.signOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signOutButton.Location = new System.Drawing.Point(120, 745);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(158, 40);
            this.signOutButton.TabIndex = 43;
            this.signOutButton.Text = "SIGN OUT";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            this.signOutButton.Enter += new System.EventHandler(this.signOutButton_Enter);
            // 
            // editButton
            // 
            this.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton.BackColor = System.Drawing.Color.LimeGreen;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(405, 745);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(158, 40);
            this.editButton.TabIndex = 44;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.Enter += new System.EventHandler(this.editButton_Enter);
            // 
            // songGalleryButton
            // 
            this.songGalleryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.songGalleryButton.BackColor = System.Drawing.Color.LimeGreen;
            this.songGalleryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songGalleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songGalleryButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songGalleryButton.Location = new System.Drawing.Point(688, 745);
            this.songGalleryButton.Name = "songGalleryButton";
            this.songGalleryButton.Size = new System.Drawing.Size(158, 40);
            this.songGalleryButton.TabIndex = 45;
            this.songGalleryButton.Text = "SONG GALLERY";
            this.songGalleryButton.UseVisualStyleBackColor = false;
            this.songGalleryButton.Click += new System.EventHandler(this.songGalleryButton_Click);
            this.songGalleryButton.Enter += new System.EventHandler(this.songGalleryButton_Enter);
            // 
            // narratorButton
            // 
            this.narratorButton.Image = global::SpotifyWinformsClone.Properties.Resources.small_narrator_image;
            this.narratorButton.Location = new System.Drawing.Point(855, 4);
            this.narratorButton.Name = "narratorButton";
            this.narratorButton.Size = new System.Drawing.Size(73, 62);
            this.narratorButton.TabIndex = 46;
            this.narratorButton.UseVisualStyleBackColor = true;
            this.narratorButton.Click += new System.EventHandler(this.narratorButton_Click);
            this.narratorButton.Enter += new System.EventHandler(this.narratorButton_Enter);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 803);
            this.Controls.Add(this.narratorButton);
            this.Controls.Add(this.songGalleryButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.resetAnswerLabel);
            this.Controls.Add(this.resetAnswerTextBox);
            this.Controls.Add(this.resetQuestionLabel);
            this.Controls.Add(this.resetQuestionComboBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.accountDetailsLabel);
            this.Controls.Add(this.songListSixButton);
            this.Controls.Add(this.songListFiveButton);
            this.Controls.Add(this.songListThreeButton);
            this.Controls.Add(this.songListFourButton);
            this.Controls.Add(this.songListTwoButton);
            this.Controls.Add(this.songListOneButton);
            this.Controls.Add(this.userGallerySongLabel);
            this.Controls.Add(this.songPanel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.separatorLabel);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyClone";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountForm_FormClosed);
            this.EnabledChanged += new System.EventHandler(this.AccountForm_EnabledChanged);
            this.songPanel.ResumeLayout(false);
            this.songPanel1.ResumeLayout(false);
            this.songPanel1.PerformLayout();
            this.songPanel2.ResumeLayout(false);
            this.songPanel2.PerformLayout();
            this.songPanel3.ResumeLayout(false);
            this.songPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Panel songPanel;
        private System.Windows.Forms.Label userGallerySongLabel;
        private System.Windows.Forms.Button songListOneButton;
        private System.Windows.Forms.Button songListTwoButton;
        private System.Windows.Forms.Button songListFourButton;
        private System.Windows.Forms.Button songListThreeButton;
        private System.Windows.Forms.Button songListFiveButton;
        private System.Windows.Forms.Button songListSixButton;
        private System.Windows.Forms.Label accountDetailsLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.ComboBox resetQuestionComboBox;
        private System.Windows.Forms.Label resetQuestionLabel;
        private System.Windows.Forms.TextBox resetAnswerTextBox;
        private System.Windows.Forms.Label resetAnswerLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button songGalleryButton;
        private System.Windows.Forms.Panel songPanel3;
        private System.Windows.Forms.Panel songPanel1;
        private System.Windows.Forms.Panel songPanel2;
        private System.Windows.Forms.Label songLabel1;
        private System.Windows.Forms.RichTextBox songRichTextBox1;
        private System.Windows.Forms.Button refundButton1;
        private System.Windows.Forms.Button playButton1;
        private System.Windows.Forms.Button playButton2;
        private System.Windows.Forms.Button refundButton2;
        private System.Windows.Forms.RichTextBox songRichTextBox2;
        private System.Windows.Forms.Label songLabel2;
        private System.Windows.Forms.Button playButton3;
        private System.Windows.Forms.Button refundButton3;
        private System.Windows.Forms.RichTextBox songRichTextBox3;
        private System.Windows.Forms.Label songLabel3;
        private System.Windows.Forms.Button narratorButton;
    }
}