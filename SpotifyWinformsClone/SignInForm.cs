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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            GlobalSpeechEngine.SpeechStandardProcedures("Login Form, You can login here");
        }

        private void logInButton_MouseEnter(object sender, EventArgs e)
        {
            logInButton.Location = new Point(logInButton.Location.X  - 3, logInButton.Location.Y - 3);
            logInButton.Size = new Size(logInButton.Size.Width + 6, logInButton.Size.Height + 6);
        }

        private void logInButton_MouseLeave(object sender, EventArgs e)
        {
            logInButton.Location = new Point(logInButton.Location.X + 3, logInButton.Location.Y + 3);
            logInButton.Size = new Size(logInButton.Size.Width - 6, logInButton.Size.Height - 6);
        }

        private void signUpButton_MouseEnter(object sender, EventArgs e)
        {
            signUpButton.Location = new Point(signUpButton.Location.X - 3, signUpButton.Location.Y - 3);
            signUpButton.Size = new Size(signUpButton.Size.Width + 6, signUpButton.Size.Height + 6);
        }

        private void signUpButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.Location = new Point(signUpButton.Location.X + 3, signUpButton.Location.Y + 3);
            signUpButton.Size = new Size(signUpButton.Size.Width - 6, signUpButton.Size.Height - 6);
        }

        private void resetPasswordButton_MouseEnter(object sender, EventArgs e)
        {
            resetPasswordButton.BackColor = Color.LimeGreen;
            resetPasswordButton.ForeColor = Color.Black;

        }

        private void resetPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            resetPasswordButton.BackColor = Color.Black;
            resetPasswordButton.ForeColor = Color.White;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
            
            this.Hide();
            this.Enabled = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "") {
                GlobalSpeechEngine.SpeechStandardProcedures("Login failed, all fields must be filled. Press enter to try again.");
                MessageBox.Show("Login failed, please fill all the fields");
                return;
            }

            UserModel user = DataAccessLayer.DataAccess.GetUser(usernameTextBox.Text);
           
            if (user.Password != passwordTextBox.Text) {
                GlobalSpeechEngine.SpeechStandardProcedures("Wrong password or the user does not exist or wrong account type(admin or user). Press enter to try again.");
                MessageBox.Show("Wrong password or the user does not exist or wrong account type(admin or user), please try again");
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                return;
            }

            //user radio button is checked
            if (userRadioButton.Checked) {
                //but the account type is admin
                if(userRadioButton.Text.ToLower() != user.UserRole)
                {
                    GlobalSpeechEngine.SpeechStandardProcedures("Wrong password or the user does not exist or wrong account type(admin or user). Press enter to try again.");
                    MessageBox.Show("Wrong password or the user does not exist or wrong account type(admin or user), please try again");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    return;
                } 
            }
            //admin radio button is checked
            else
            {
                //but the account type is user
                if (adminRadioButton.Text.ToLower() != user.UserRole)
                {
                    GlobalSpeechEngine.SpeechStandardProcedures("Wrong password or the user does not exist or wrong account type(admin or user). Press enter to try again.");
                    MessageBox.Show("Wrong password or the user does not exist or wrong account type(admin or user), please try again");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    return;
                }
            }

            //get user songs
            user.Songs = DataAccess.GetUserSongs(user);

            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            AccountForm accountForm = new AccountForm(user);
            accountForm.Show();
            this.Hide();
            this.Enabled = false;
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            userRadioButton.Checked = true;
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            SmallUsernameDialogForm smallUsernameDialogForm = new SmallUsernameDialogForm();
            smallUsernameDialogForm.Show();
            this.Enabled = false;
        }

        private void narratorButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Narrator Button");
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (GlobalSpeechEngine.JustEnteredForm)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Login Form, here you can log in to your account. Username textbox, you can type your username here");
                GlobalSpeechEngine.JustEnteredForm = false;
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures("username textbox, you can type your username here");
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Password textbox, you can type your password here");
        }

        private void adminRadioButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("admin radio button, you can swap between radio buttons with the arrow keys");
        }

        private void userRadioButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("user radio button, you can swap between radio buttons with the arrow keys");
        }

        private void logInButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("login button");
        }

        private void signUpButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("sign up button");
        }

        private void resetPasswordButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("reset password button");
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.EnableOrDisableSpeechEngine();
        }

        private void SignInForm_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                this.ActiveControl = usernameTextBox;
            }
        }
    }
}
