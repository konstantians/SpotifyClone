using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyWinformsClone
{
    public partial class RegisterForm : Form
    {
        private bool closedByButton = false;
        public RegisterForm()
        {
            InitializeComponent();
            pickResetQuestionComboBox.SelectedIndex = 0;
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            cancelButton.Location = new Point(cancelButton.Location.X - 3, cancelButton.Location.Y - 3);
            cancelButton.Size = new Size(cancelButton.Size.Width + 6, cancelButton.Size.Height + 6);
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.Location = new Point(cancelButton.Location.X + 3, cancelButton.Location.Y + 3);
            cancelButton.Size = new Size(cancelButton.Size.Width - 6, cancelButton.Size.Height - 6);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void RegisterButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.Location = new Point(registerButton.Location.X - 3, registerButton.Location.Y - 3);
            registerButton.Size = new Size(registerButton.Size.Width + 6, registerButton.Size.Height + 6);
        }

        private void RegisterButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.Location = new Point(registerButton.Location.X + 3, registerButton.Location.Y + 3);
            registerButton.Size = new Size(registerButton.Size.Width - 6, registerButton.Size.Height - 6);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || resetAnswerTextBox.Text == "")
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Invalid input. All fields must be filled. Press enter to try again.");
                MessageBox.Show("All fields must be filled!");
                return;
            }

            if (DataAccess.GetUser(usernameTextBox.Text).Username != null) {
                GlobalSpeechEngine.SpeechStandardProcedures("There is another user with that username. Press enter to try something else");
                MessageBox.Show("There is another user with that username, please choose something else");
                return;
            };

            UserModel user = new UserModel();
            user.Username = usernameTextBox.Text;
            user.Password = passwordTextBox.Text;
            user.RecoveryQuestion = pickResetQuestionComboBox.Text;
            user.RecoveryAnswer = resetAnswerTextBox.Text;
            if (userRadioButton.Checked) user.UserRole = "user";
            else user.UserRole = "admin";
            user.Score = 0;
            
            
            DataAccess.CreateUser(user);
            GlobalSpeechEngine.SpeechStandardProcedures("You have successfully registered a new Account! Press enter to continue.");
            MessageBox.Show("You have successfully registered a new Account!");
            
            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            closedByButton = true;

            Application.OpenForms[0].Enabled = true;
            Application.OpenForms[0].Show();
            this.Close();

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
            {
                GlobalSpeechEngine.JustEnteredForm = true;
                GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

                Application.OpenForms[0].Enabled = true;
                Application.OpenForms[0].Show();
            }
            
        }

        private void narratorButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("narrator button");
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (GlobalSpeechEngine.JustEnteredForm)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Register Form, here you can create a new account. Username textbox, you can type your username here");
                GlobalSpeechEngine.JustEnteredForm = false;
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures("username textbox, you can type your username here");
            }
            
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("password textbox, you can type your password here");
        }

        private void userRadioButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("user radio button, you can swap between radio buttons with the arrow keys");
        }

        private void adminRadioButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("admin radio button, you can swap between radio buttons with the arrow keys");
        }

        private void pickResetQuestionComboBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Reset question dropdown, you can pick your reset question using the arrow keys. " +
                $"Current reset question choice is: {pickResetQuestionComboBox.Text}");
        }

        private void resetAnswerTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Reset answer textbox, you can type your reset answer here");
        }

        private void cancelButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("cancel button");
        }

        private void registerButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("register button");
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.EnableOrDisableSpeechEngine();
        }

        private void pickResetQuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"Current reset question choice is: {pickResetQuestionComboBox.Text}");
        }
    }
}
