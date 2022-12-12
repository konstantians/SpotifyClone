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

namespace SpotifyWinformsClone
{
    public partial class ResetPasswordForm : Form
    {
        private UserModel User { get; set; }
        private bool closedByButton = false;
        public ResetPasswordForm(UserModel user)
        {
            InitializeComponent();
            User = user;
            usernameTextBox.Text = user.Username;
            resetQuestionLabel.Text = user.RecoveryQuestion;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //initialize the global speech for the form
            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            //show login form
            Application.OpenForms[0].Show();
            //close this and the small UsernameDialogForm
            Application.OpenForms[1].Close();
            closedByButton = true;
            this.Close();
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            //if the user has not filled some of the fields
            if (resetAnswerTextBox.Text == "" || passwordTextBox.Text == "" || repeatPasswordTextBox.Text == "") {
                GlobalSpeechEngine.SpeechStandardProcedures("Please fill all the fields. Press enter to try again.");
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            //check if the user answered correctly
            if (resetAnswerTextBox.Text != User.RecoveryAnswer) 
            {
                GlobalSpeechEngine.SpeechStandardProcedures("This is not the correct Answer for the Recovery Question. " +
                    "Press enter to try again.");
                MessageBox.Show("This is not the correct Answer For The Recovery Question.\nPlease try again.");
                resetAnswerTextBox.Text = "";
                return;
            }

            //check if the 2 passwords match(the password and the repeat password)
            if (passwordTextBox.Text != repeatPasswordTextBox.Text) {
                GlobalSpeechEngine.SpeechStandardProcedures("The repeat password and the password do not match." +
                    "Press enter to try again");
                MessageBox.Show("The repeat password and the password do not match.");
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";
                return;
            }

            User.Password = passwordTextBox.Text;
            DataAccess.UpdateUser(User);
            GlobalSpeechEngine.SpeechStandardProcedures("The password has been succesfully reset. Press enter to continue");
            MessageBox.Show("The password has been succesfully reset");

            //initialize the global speech for the form
            GlobalSpeechEngine.JustEnteredForm = true;
            //show the login form
            Application.OpenForms[0].Show();
            //close this and the small UsernameDialogForm
            Application.OpenForms[1].Close();
            closedByButton = true;
            this.Close();
        }

        //default actions when the form is closing
        private void ResetPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByButton) return;

            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            //show the login form
            Application.OpenForms[0].Show();
            //close the small UsernameDialogForm
            Application.OpenForms[1].Close();
        }

        private void resetAnswerTextBox_Enter(object sender, EventArgs e)
        {
            if (GlobalSpeechEngine.JustEnteredForm)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Reset Password Form, here you can reset the password of your account. Reset Answer textbox, type your reset answer for the reset " +
                    $"question: {resetQuestionLabel.Text}");
                GlobalSpeechEngine.JustEnteredForm = false;
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"Reset Answer textbox, type your reset answer for the reset question: {resetQuestionLabel.Text}");
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Password textbox, you can type your new password here");
            
        }

        private void repeatPasswordTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Repeat Password textbox, please type your new password here again");
        }

        private void cancelButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Cancel Button");
        }

        private void resetPasswordButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Reset Password Button");
        }

        private void narratorButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Narrator Button");
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.EnableOrDisableSpeechEngine();
        }
    }
}
