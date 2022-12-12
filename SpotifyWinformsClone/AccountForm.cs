using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpotifyWinformsClone
{
    public partial class AccountForm : Form
    {
        public UserModel User { get; set; }
        private bool closedByButton = false;
        private int currentStartingPoint = 0;
        WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
        private List<Node> Nodes { get; set; } = new List<Node>();
        
        private class Node
        {
            public Label SongNameLabel { get; set; }
            public RichTextBox SongRichTextBoxLabel { get; set; }
            public Button SongRefundButton { get; set; }
            public Button SongPlayButton { get; set; }

            public Node(Label songNameLabel, RichTextBox songRichTextBox, Button songRefundButton,
                Button songPlayButton)
            {
                SongNameLabel = songNameLabel;
                SongRichTextBoxLabel = songRichTextBox;
                SongRefundButton = songRefundButton;
                SongPlayButton = songPlayButton;
            }

        }

        public AccountForm(UserModel user)
        {
            InitializeComponent();
            Nodes.Add(new Node(songLabel1, songRichTextBox1, refundButton1, playButton1));
            Nodes.Add(new Node(songLabel2, songRichTextBox2, refundButton2, playButton2));
            Nodes.Add(new Node(songLabel3, songRichTextBox3, refundButton3, playButton3));
            User = user;
            //to solve register issue
            User.Songs = DataAccess.GetUserSongs(User);

            //TODO fix that
            /*if(User.Songs == null)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Account Form. It looks like you do not have any songs yet");
                GlobalSpeechEngine.JustEnteredForm = false;
            }*/

            fillTheListSong(0);

            usernameTextBox.Text = User.Username;
            passwordTextBox.Text = User.Password;
            scoreTextBox.Text = User.Score.ToString();
            
            for (int i = 0; i < resetQuestionComboBox.Items.Count; i++) { 
                if(resetQuestionComboBox.Items[i].ToString() == User.RecoveryQuestion)
                {
                    resetQuestionComboBox.SelectedIndex = i;
                }
            };

            resetAnswerTextBox.Text = User.RecoveryAnswer;
            if (User.UserRole == "user") userRadioButton.Checked = true;
            else adminRadioButton.Checked = true;
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            //stop any song that is playing
            myplayer.controls.stop();

            closedByButton = true;

            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
            GlobalSpeechEngine.JustEnteredForm = true;

            Application.OpenForms[0].Enabled = true;
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton) {

                GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
                GlobalSpeechEngine.JustEnteredForm = true;

                Application.OpenForms[0].Enabled = true;
                Application.OpenForms[0].Show();
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editButton.Text == "EDIT") {
                usernameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                resetQuestionComboBox.Enabled = true;
                resetAnswerTextBox.Enabled = true;
                userRadioButton.Enabled = true;
                adminRadioButton.Enabled = true;

                GlobalSpeechEngine.SpeechStandardProcedures("Edit mode activated. You can edit your account details now.");
                editButton.Text = "CONFIRM";
                return;
            }

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || resetAnswerTextBox.Text == "") {

                GlobalSpeechEngine.SpeechStandardProcedures("Invalid Changes. All fields must be field. press enter to try again.");
                MessageBox.Show("All fields must be filled");
                return;
            }

            UserModel user = DataAccess.GetUser(usernameTextBox.Text);
            if (user.Username != null && user.Username != User.Username) {
                GlobalSpeechEngine.SpeechStandardProcedures("The changes can not be submitted, because there is another user with that username. press enter to try again.");
                MessageBox.Show("The changes can not be submitted, because there is another user with that username.");
                return;
            }

            //update the user in the database and the user here
            User.Password = passwordTextBox.Text;
            User.RecoveryQuestion = resetQuestionComboBox.SelectedItem.ToString();
            User.RecoveryAnswer = resetAnswerTextBox.Text;
            if (userRadioButton.Checked) User.UserRole = "user";
            else User.UserRole = "admin";

            DataAccess.UpdateUserAndUsername(User, usernameTextBox.Text);
            
            User.Username = usernameTextBox.Text;

            //change back to the first state
            usernameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            resetQuestionComboBox.Enabled = false;
            resetAnswerTextBox.Enabled = false;
            userRadioButton.Enabled = false;
            adminRadioButton.Enabled = false;

            hideAll();
            fillTheListSong(currentStartingPoint);

            GlobalSpeechEngine.SpeechStandardProcedures("Edit Mode Deactivated.");
            editButton.Text = "EDIT";
            GlobalSpeechEngine.SpeechStandardProcedures("Account information updated successfully! Press enter to continue.");
            MessageBox.Show("Account information updated successfully!");
            
        }

        private void songGalleryButton_Click(object sender, EventArgs e)
        {
            //stop any song that is playing
            myplayer.controls.stop();

            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
            GlobalSpeechEngine.JustEnteredForm = true;

            SongGalleryForm songGalleryForm = new SongGalleryForm(User);
            songGalleryForm.Show();
            this.Hide();
            this.Enabled = false;
        }

        private void fillTheListSong(int startingPoint)
        {

            int counter = 0;
            for (int i = startingPoint; i < User.Songs.Count; i++)
            {
                if (i == startingPoint + 3) break;
                Nodes[counter].SongNameLabel.Text = User.Songs[i].SongName;
                Nodes[counter].SongRichTextBoxLabel.Text = User.Songs[i].Description;
                
                Nodes[counter].SongNameLabel.Visible = true;
                Nodes[counter].SongRichTextBoxLabel.Visible = true;
                Nodes[counter].SongRefundButton.Visible = true;
                Nodes[counter].SongPlayButton.Visible = true;

                if (User.UserRole == "admin")
                {
                    Nodes[counter].SongRefundButton.Text = "REMOVE";
                }
                else
                {
                    Nodes[counter].SongRefundButton.Text = "REFUND";
                }
                counter++;
            }
        }

        private void hideAll()
        {
            foreach (Node node in Nodes)
            {
                node.SongNameLabel.Visible = false;
                node.SongRichTextBoxLabel.Visible = false;
                node.SongRefundButton.Visible = false;
                node.SongPlayButton.Visible = false;
            }
        }

        private void songListOneButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(0);
            currentStartingPoint = 0;
        }

        private void songListTwoButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(3);
            currentStartingPoint = 3;
        }

        private void songListThreeButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(6);
            currentStartingPoint = 6;
        }

        private void songListFourButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(9);
            currentStartingPoint = 9;
        }

        private void songListFiveButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(12);
            currentStartingPoint = 12;
        }

        private void songListSixButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(15);
            currentStartingPoint = 15;
        }

        private void AccountForm_EnabledChanged(object sender, EventArgs e)
        {
            User = DataAccess.GetUser(User.Username);
            User.Songs = DataAccess.GetUserSongs(User);
            hideAll();
            fillTheListSong(currentStartingPoint);

            scoreTextBox.Text = User.Score.ToString();

            if (this.Enabled) this.ActiveControl = Nodes[0].SongRichTextBoxLabel;
        }

        private void playButton1_Click(object sender, EventArgs e)
        {
            //TODO fix the bug where the button in the next page(for example page 2) also says stop instead of play
            if(Nodes[0].SongPlayButton.Text == "PLAY")
            {
                //reset everything else
                foreach(Node node in Nodes)
                {
                    node.SongPlayButton.Text = "PLAY";
                }

                SongModel song = DataAccess.GetSong(Nodes[0].SongNameLabel.Text);

                myplayer.URL = song.FilePath;
                myplayer.controls.play();
                Nodes[0].SongPlayButton.Text = "STOP";
                return;
            }

            Nodes[0].SongPlayButton.Text = "PLAY";
            myplayer.controls.stop();
        }

        private void playButton2_Click(object sender, EventArgs e)
        {
            
            if (Nodes[1].SongPlayButton.Text == "PLAY")
            {
                //reset everything else
                foreach (Node node in Nodes)
                {
                    node.SongPlayButton.Text = "PLAY";
                }

                SongModel song = DataAccess.GetSong(Nodes[1].SongNameLabel.Text);

                myplayer.URL = song.FilePath;
                myplayer.controls.play();
                Nodes[1].SongPlayButton.Text = "STOP";
                return;
            }

            Nodes[1].SongPlayButton.Text = "PLAY";
            myplayer.controls.stop();
        }

        private void playButton3_Click(object sender, EventArgs e)
        {
            if (Nodes[2].SongPlayButton.Text == "PLAY")
            {
                //reset everything else
                foreach (Node node in Nodes)
                {
                    node.SongPlayButton.Text = "PLAY";
                }

                SongModel song = DataAccess.GetSong(Nodes[2].SongNameLabel.Text);

                myplayer.URL = song.FilePath;
                myplayer.controls.play();
                Nodes[2].SongPlayButton.Text = "STOP";
                return;
            }

            Nodes[2].SongPlayButton.Text = "PLAY";
            myplayer.controls.stop();
        }

        private void refundButton1_Click(object sender, EventArgs e)
        {
            refundOrRemoveStandardProcedures(0);
        }

        private void refundButton2_Click(object sender, EventArgs e)
        {
            refundOrRemoveStandardProcedures(1);
        }

        private void refundButton3_Click(object sender, EventArgs e)
        {
            refundOrRemoveStandardProcedures(2);
        }

        private void refundOrRemoveStandardProcedures(int nodeNumber)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Are you certain that you want to remove the song from your library? If yes press enter," +
                " otherwise press tab and then enter");
            DialogResult dialogResult = MessageBox.Show("Are you certain that you want to remove the song from your library?", "Remove Song", MessageBoxButtons.YesNo);
            //if no return
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            SongModel song = DataAccess.GetSong(Nodes[nodeNumber].SongNameLabel.Text);

            //if the account is a user account refund the amount
            if (User.UserRole == "user")
            {
                User.Score += song.Price;
                DataAccess.UpdateUser(User);
                scoreTextBox.Text = User.Score.ToString();
            }

            DataAccess.RemoveSongFromUser(User, song);

            //refresh the user
            User = DataAccess.GetUser(User.Username);
            //refresh the user songs
            User.Songs = DataAccess.GetUserSongs(User);

            //to solve bug
            if (this.Enabled) this.ActiveControl = userGallerySongLabel;

            //hide all
            hideAll();
            //refill the list
            fillTheListSong(currentStartingPoint);

            myplayer.controls.stop();
        }

        private void narratorButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Narrator Button");
        }

        private void songRichTextBox1_Enter(object sender, EventArgs e)
        {
            if (GlobalSpeechEngine.JustEnteredForm)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Account Form, here you can check out your songs and edit your account. " +
                    $"You are at the first song in the list of page {currentStartingPoint/ 3 + 1}. The name of the song is: {Nodes[0].SongNameLabel.Text} " +
                    $"and the description of the is: {Nodes[0].SongRichTextBoxLabel.Text}.");
                GlobalSpeechEngine.JustEnteredForm = false;
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"You are at the first song in the list of page {currentStartingPoint / 3 + 1}. " +
                    $"The name of the song is: {Nodes[0].SongNameLabel.Text} " +
                    $"and the description of the first song is: {Nodes[0].SongRichTextBoxLabel.Text}.");
            }
        }

        private void refundButton1_Enter(object sender, EventArgs e)
        {
            if(User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"remove song from account button for the {Nodes[0].SongNameLabel.Text} song.");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"refund button for the {Nodes[0].SongNameLabel.Text} song.");
            }
            
        }

        private void playButton1_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"play button for the {Nodes[0].SongNameLabel.Text} song.");
        }

        private void songRichTextBox2_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the second song in the list of page {currentStartingPoint / 3 + 1}. " +
                    $"The name of the song is: {Nodes[1].SongNameLabel.Text} " +
                    $"and the description of the song is: {Nodes[1].SongRichTextBoxLabel.Text}.");
        }

        private void refundButton2_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"remove song from account button for the {Nodes[1].SongNameLabel.Text} song.");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"refund button for the {Nodes[1].SongNameLabel.Text} song.");
            }
        }

        private void playButton2_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"play button for the {Nodes[1].SongNameLabel.Text} song.");
        }

        private void songRichTextBox3_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the third song in the list of page {currentStartingPoint / 3 + 1}. " +
                    $"The name of the song is: {Nodes[2].SongNameLabel.Text} " +
                    $"and the description of the song is: {Nodes[2].SongRichTextBoxLabel.Text}");
        }

        private void refundButton3_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"remove song from account button for the {Nodes[2].SongNameLabel.Text} song.");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"refund button for the {Nodes[2].SongNameLabel.Text} song.");
            }
        }

        private void playButton3_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"play button for the {Nodes[2].SongNameLabel.Text} song.");
        }

        private void songListOneButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"first page button. Click it to get to the first page.");
        }

        private void songListTwoButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"second page button. Click it to get to the second page.");
        }

        private void songListThreeButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"third page button. Click it to get to the third page.");
        }

        private void songListFourButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"fourth page button. Click it to get to the fourth page.");
        }

        private void songListFiveButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"fifth page button. Click it to get to the fifth page.");
        }

        private void songListSixButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"sixth page button. Click it to get to the sixth page.");
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"username textbox, you can type here your updated username. Any changes must be saved to take effect.");
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"password textbox, you can type here your updated password. Any changes must be saved to take effect.");
        }

        private void resetQuestionComboBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Reset question dropdown, you can edit your reset question using the arrow keys. " +
                $"Current reset question choice is: {resetQuestionComboBox.Text}");
        }

        private void resetQuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"Current reset question choice is: {resetQuestionComboBox.Text}");
        }

        private void resetAnswerTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"recovery password answer textbox, you can type here your new recovery password answer. Any changes must be saved to take effect.");
        }

        private void adminRadioButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("admin radio button, " +
                "you can edit your role by swapping between the radio buttons with the arrow keys. Any changes must be saved to take effect.");
        }

        private void userRadioButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("admin radio button, " +
                "you can edit your role by swapping between the radio buttons with the arrow keys. Any changes must be saved to take effect.");
        }

        private void signOutButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("sign out button");
        }

        private void editButton_Enter(object sender, EventArgs e)
        {
            if(editButton.Text == "EDIT")
            {
                GlobalSpeechEngine.SpeechStandardProcedures("edit button");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures("confirm changes button");
            }
        }

        private void songGalleryButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("enter song gallery button");
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.EnableOrDisableSpeechEngine();
        }
    }
}
