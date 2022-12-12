
namespace SpotifyWinformsClone
{
    partial class CreateSongForm
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
            this.songTitleLabel = new System.Windows.Forms.Label();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.songDescriptionLabel = new System.Windows.Forms.Label();
            this.songDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.songPriceLabel = new System.Windows.Forms.Label();
            this.uploadSongTextBox = new System.Windows.Forms.TextBox();
            this.uploadSongLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.uploadSongButton = new System.Windows.Forms.Button();
            this.songPriceTextBox = new System.Windows.Forms.TextBox();
            this.uploadSongDialog = new System.Windows.Forms.OpenFileDialog();
            this.narratorButton = new System.Windows.Forms.Button();
            this.spotifyLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // separatorLabel
            // 
            this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorLabel.Location = new System.Drawing.Point(-5, 123);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(815, 2);
            this.separatorLabel.TabIndex = 1;
            this.separatorLabel.Text = "........";
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AutoSize = true;
            this.songTitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitleLabel.Location = new System.Drawing.Point(201, 154);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.Size = new System.Drawing.Size(127, 22);
            this.songTitleLabel.TabIndex = 2;
            this.songTitleLabel.Text = "SONG TITLE";
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitleTextBox.Location = new System.Drawing.Point(205, 188);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(409, 35);
            this.songTitleTextBox.TabIndex = 3;
            this.songTitleTextBox.Enter += new System.EventHandler(this.songTitleTextBox_Enter);
            // 
            // songDescriptionLabel
            // 
            this.songDescriptionLabel.AutoSize = true;
            this.songDescriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDescriptionLabel.Location = new System.Drawing.Point(201, 269);
            this.songDescriptionLabel.Name = "songDescriptionLabel";
            this.songDescriptionLabel.Size = new System.Drawing.Size(202, 22);
            this.songDescriptionLabel.TabIndex = 4;
            this.songDescriptionLabel.Text = "SONG DESCRIPTION";
            // 
            // songDescriptionRichTextBox
            // 
            this.songDescriptionRichTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDescriptionRichTextBox.Location = new System.Drawing.Point(205, 303);
            this.songDescriptionRichTextBox.Name = "songDescriptionRichTextBox";
            this.songDescriptionRichTextBox.Size = new System.Drawing.Size(409, 105);
            this.songDescriptionRichTextBox.TabIndex = 5;
            this.songDescriptionRichTextBox.Text = "";
            this.songDescriptionRichTextBox.Enter += new System.EventHandler(this.songDescriptionRichTextBox_Enter);
            // 
            // songPriceLabel
            // 
            this.songPriceLabel.AutoSize = true;
            this.songPriceLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songPriceLabel.Location = new System.Drawing.Point(201, 448);
            this.songPriceLabel.Name = "songPriceLabel";
            this.songPriceLabel.Size = new System.Drawing.Size(129, 22);
            this.songPriceLabel.TabIndex = 6;
            this.songPriceLabel.Text = "SONG PRICE";
            // 
            // uploadSongTextBox
            // 
            this.uploadSongTextBox.Enabled = false;
            this.uploadSongTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadSongTextBox.Location = new System.Drawing.Point(205, 609);
            this.uploadSongTextBox.Name = "uploadSongTextBox";
            this.uploadSongTextBox.Size = new System.Drawing.Size(243, 22);
            this.uploadSongTextBox.TabIndex = 9;
            // 
            // uploadSongLabel
            // 
            this.uploadSongLabel.AutoSize = true;
            this.uploadSongLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadSongLabel.Location = new System.Drawing.Point(201, 561);
            this.uploadSongLabel.Name = "uploadSongLabel";
            this.uploadSongLabel.Size = new System.Drawing.Size(151, 22);
            this.uploadSongLabel.TabIndex = 8;
            this.uploadSongLabel.Text = "UPLOAD SONG";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(205, 669);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 40);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.Enter += new System.EventHandler(this.cancelButton_Enter);
            // 
            // addSongButton
            // 
            this.addSongButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addSongButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addSongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSongButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongButton.Location = new System.Drawing.Point(456, 669);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(158, 40);
            this.addSongButton.TabIndex = 12;
            this.addSongButton.Text = "ADD SONG";
            this.addSongButton.UseVisualStyleBackColor = false;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            this.addSongButton.Enter += new System.EventHandler(this.addSongButton_Enter);
            // 
            // uploadSongButton
            // 
            this.uploadSongButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadSongButton.BackColor = System.Drawing.Color.LimeGreen;
            this.uploadSongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadSongButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadSongButton.Location = new System.Drawing.Point(471, 596);
            this.uploadSongButton.Name = "uploadSongButton";
            this.uploadSongButton.Size = new System.Drawing.Size(143, 35);
            this.uploadSongButton.TabIndex = 10;
            this.uploadSongButton.Text = "UPLOAD SONG";
            this.uploadSongButton.UseVisualStyleBackColor = false;
            this.uploadSongButton.Click += new System.EventHandler(this.uploadSongButton_Click);
            this.uploadSongButton.Enter += new System.EventHandler(this.uploadSongButton_Enter);
            // 
            // songPriceTextBox
            // 
            this.songPriceTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songPriceTextBox.Location = new System.Drawing.Point(205, 483);
            this.songPriceTextBox.Name = "songPriceTextBox";
            this.songPriceTextBox.Size = new System.Drawing.Size(409, 35);
            this.songPriceTextBox.TabIndex = 7;
            this.songPriceTextBox.Enter += new System.EventHandler(this.songPriceTextBox_Enter);
            // 
            // uploadSongDialog
            // 
            this.uploadSongDialog.FileName = "uploadSongDialog";
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
            // spotifyLogoPictureBox
            // 
            this.spotifyLogoPictureBox.Image = global::SpotifyWinformsClone.Properties.Resources.spotify_logo;
            this.spotifyLogoPictureBox.Location = new System.Drawing.Point(277, 12);
            this.spotifyLogoPictureBox.Name = "spotifyLogoPictureBox";
            this.spotifyLogoPictureBox.Size = new System.Drawing.Size(262, 93);
            this.spotifyLogoPictureBox.TabIndex = 1;
            this.spotifyLogoPictureBox.TabStop = false;
            // 
            // CreateSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 741);
            this.Controls.Add(this.narratorButton);
            this.Controls.Add(this.songPriceTextBox);
            this.Controls.Add(this.uploadSongButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.uploadSongLabel);
            this.Controls.Add(this.uploadSongTextBox);
            this.Controls.Add(this.songPriceLabel);
            this.Controls.Add(this.songDescriptionRichTextBox);
            this.Controls.Add(this.songDescriptionLabel);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.songTitleLabel);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.spotifyLogoPictureBox);
            this.Name = "CreateSongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyClone";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateSongForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateSongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spotifyLogoPictureBox;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Label songTitleLabel;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.Label songDescriptionLabel;
        private System.Windows.Forms.RichTextBox songDescriptionRichTextBox;
        private System.Windows.Forms.Label songPriceLabel;
        private System.Windows.Forms.TextBox uploadSongTextBox;
        private System.Windows.Forms.Label uploadSongLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button uploadSongButton;
        private System.Windows.Forms.TextBox songPriceTextBox;
        private System.Windows.Forms.OpenFileDialog uploadSongDialog;
        private System.Windows.Forms.Button narratorButton;
    }
}