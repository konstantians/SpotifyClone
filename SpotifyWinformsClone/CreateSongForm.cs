using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyWinformsClone
{
    public partial class CreateSongForm : Form
    {
        private bool closedByButton = false;
        private string fileSourcePath;
        private string fileDestinationPath;
        public CreateSongForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closedByButton = true;

            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            Application.OpenForms[2].Show();
            Application.OpenForms[2].Enabled = true;
            this.Close();
        }

        private void CreateSongForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton) {

                GlobalSpeechEngine.JustEnteredForm = true;
                GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

                Application.OpenForms[2].Show();
                Application.OpenForms[2].Enabled = true;
            }
            
        }

        private void uploadSongButton_Click(object sender, EventArgs e)
        {
            uploadSongDialog.Multiselect = false;
            uploadSongDialog.Filter = "All Media Files|*.wav;*.mp3";
            if (uploadSongDialog.ShowDialog() == DialogResult.OK) {
                List<string> sourcePathList = uploadSongDialog.FileName.Split('\\').ToList();
                StringBuilder sourcePath = new StringBuilder();
                string songName = "";
                for (int i = 0; i < sourcePathList.Count; i++)
                {
                    if (i == sourcePathList.Count - 1) {
                        sourcePath.Append(sourcePathList[i]);
                        songName = sourcePathList[i];
                    }
                    else
                    {
                        sourcePath.Append(sourcePathList[i] + @"\");
                        
                    }              
                }


                List<string> destionationPathList = Application.StartupPath.Split('\\').ToList();
                StringBuilder songsPath = new StringBuilder();

                for(int i = 0; i < destionationPathList.Count - 2; i++)
                {
                    songsPath.Append(destionationPathList[i] + @"\");

                }
                songsPath.Append($@"songs\{songName}");

                fileSourcePath = sourcePath.ToString();
                fileDestinationPath = songsPath.ToString();

                uploadSongTextBox.Text = fileSourcePath;

                GlobalSpeechEngine.SpeechStandardProcedures("Valid song path! Press any enter to continue.");
                MessageBox.Show("Valid song path!");    
            }
        }

        private void CreateSongForm_Load(object sender, EventArgs e)
        {
            uploadSongDialog.InitialDirectory = Application.StartupPath;
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            if (songTitleTextBox.Text == "" || songDescriptionRichTextBox.Text == "" || songPriceTextBox.Text == ""
                || uploadSongLabel.Text == "") {
                GlobalSpeechEngine.SpeechStandardProcedures("All fields must be filled! Press enter to try again.");
                MessageBox.Show("All fields must be filled! Please try again.");
                return;
            }

            if (songDescriptionRichTextBox.Text.Length > 100) {
                GlobalSpeechEngine.SpeechStandardProcedures("The description must be at most 100 words. Press enter to try again.");
                MessageBox.Show("The description must be at most 100 words");
                return;
            }

            SongModel song = DataAccess.GetSong(songTitleTextBox.Text);
            if(song.SongName != null)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("There is another song with the same title. Press enter to try something different.");
                MessageBox.Show("There is another song with the same title, please choose something else");

                return;
            }

            song.SongName = songTitleTextBox.Text;
            song.Description = songDescriptionRichTextBox.Text;
            song.Price = Int32.Parse(songPriceTextBox.Text);
            song.FilePath = fileDestinationPath;

            DataAccess.CreateSong(song);

            //TODO fix the possibility that a file will be deleted if a user adds a file that
            //has the same path
            try
            {
                File.Copy(fileSourcePath, fileDestinationPath, true);

            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            GlobalSpeechEngine.SpeechStandardProcedures("The song was uploaded successfully! Press enter to continue");
            MessageBox.Show("The song was uploaded successfully!");
            closedByButton = true;

            GlobalSpeechEngine.JustEnteredForm = true;
            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();

            //close the form
            Application.OpenForms[2].Enabled = true;
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.EnableOrDisableSpeechEngine();
        }

        private void narratorButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("narrrator button");
        }

        private void songTitleTextBox_Enter(object sender, EventArgs e)
        {
            if (GlobalSpeechEngine.JustEnteredForm)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Create Song Form, here you can upload a new song to the gallery. Song Title textbox, you can type the song's title here.");
                GlobalSpeechEngine.JustEnteredForm = false;
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Song Title textbox, you can type the song's title here.");
            }
        }

        private void songDescriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Song description richtextbox, you can type the song's description here.");
        }

        private void songPriceTextBox_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Price textbox, you can type the song's price here.");
        }

        private void uploadSongButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Song upload button. Press it to upload songs to the system. Make sure to confirm changes in the end");
        }

        private void cancelButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Cancel Button");
        }

        private void addSongButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Add song button. Press this button to add the song to the gallery");
        }
    }
}
