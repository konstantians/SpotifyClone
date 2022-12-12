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
    public partial class SmallUsernameDialogForm : Form
    {
        public SmallUsernameDialogForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Enabled = true;
            this.Close();
        }

        private void SmallUsernameDialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Enabled = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "") {
                MessageBox.Show("Please fill the username field");
                return;
            }

            UserModel userModel = DataAccess.GetUser(usernameTextBox.Text);
            if(userModel.Username == null)
            {
                MessageBox.Show("There is no user with the given username!");
                usernameTextBox.Text = "";
                return;
            }

            ResetPasswordForm resetPasswordForm = new ResetPasswordForm(userModel);
            resetPasswordForm.Show();

            this.Hide();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Please enter in the textbox the username of the account you want to reset the password");
        }

        private void cancelButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Cancel Button");
        }

        private void confirmButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Confirm Button");
        }
    }
}
