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
    public partial class SongGalleryForm : Form
    {
        public UserModel User { get; set; }
        public List<SongModel> Songs { get; set; } 
        private bool closedByButton = false;
        private int currentStartingPoint = 0;
        private List<Node> Nodes { get; set; } = new List<Node>();

        private class Node{
            public Label SongNameLabel { get; set; }
            public RichTextBox SongRichTextBoxLabel { get; set; }
            public Label SongPriceLabel { get; set; }
            public Button SongDeleteButton { get; set; }
            public Button SongBuyButton { get; set; }

            public Node(Label songNameLabel,RichTextBox songRichTextBox,Label songPriceLabel,Button songDeleteButton, 
                Button songBuyButton)
            {
                SongNameLabel = songNameLabel;
                SongRichTextBoxLabel = songRichTextBox;
                SongPriceLabel = songPriceLabel;
                SongDeleteButton = songDeleteButton;
                SongBuyButton = songBuyButton;
            }

        }
        public SongGalleryForm(UserModel user)
        {
            InitializeComponent();
            Nodes.Add(new Node(songLabel1, songRichTextBox1, songPrice1, deleteButton1, buyButton1));
            Nodes.Add(new Node(songLabel2, songRichTextBox2, songPrice2, deleteButton2, buyButton2));
            Nodes.Add(new Node(songLabel3, songRichTextBox3, songPrice3, deleteButton3, buyButton3));
            Nodes.Add(new Node(songLabel4, songRichTextBox4, songPrice4, deleteButton4, buyButton4));
            Nodes.Add(new Node(songLabel5, songRichTextBox5, songPrice5, deleteButton5, buyButton5));
            Nodes.Add(new Node(songLabel6, songRichTextBox6, songPrice6, deleteButton6, buyButton6));
            User = user;
            currentPointsLabel.Text = $"CURRENT POINTS: {User.Score}";
            if (User.UserRole == "admin") addNewSongButton.Enabled = true;

            //get all the songs
            Songs = DataAccess.GetSongs();
            
            //fill the 6 possible songs that need to be filled
            fillTheListSong(0);


            this.ActiveControl = Nodes[currentStartingPoint].SongRichTextBoxLabel;
        }

        private void earnPointsButton_Click(object sender, EventArgs e)
        {
            User.Score += 1;
            DataAccess.UpdateUser(User);
            GlobalSpeechEngine.SpeechStandardProcedures($"You earned 1 point! Current points: {User.Score}");
            currentPointsLabel.Text = $"CURRENT POINTS: {User.Score}";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closedByButton = true;

            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
            GlobalSpeechEngine.JustEnteredForm = true;

            Application.OpenForms[1].Show();
            Application.OpenForms[1].Enabled = true;
            this.Close();
        }

        private void SongGalleryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
            {
                GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
                GlobalSpeechEngine.JustEnteredForm = true;

                Application.OpenForms[1].Show();
                Application.OpenForms[1].Enabled = true;
            }
        }

        private void addNewSongButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;

            GlobalSpeechEngine.SpeechEngine.SpeakAsyncCancelAll();
            GlobalSpeechEngine.JustEnteredForm = true;

            CreateSongForm createSongForm = new CreateSongForm();
            createSongForm.Show();
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
            fillTheListSong(6);
            currentStartingPoint = 6;
        }

        private void songListThreeButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(12);
            currentStartingPoint = 12;
        }

        private void songListFourButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(18);
            currentStartingPoint = 18;
        }

        private void songListFiveButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(24);
            currentStartingPoint = 24;
        }

        private void songListSixButton_Click(object sender, EventArgs e)
        {
            hideAll();
            fillTheListSong(30);
            currentStartingPoint = 30;
        }

        private void fillTheListSong(int startingPoint)
        {
            int counter = 0;
            for(int i = startingPoint; i < Songs.Count; i++)
            {
                if (i == startingPoint + 6) break;
                Nodes[counter].SongNameLabel.Text = Songs[i].SongName;
                Nodes[counter].SongRichTextBoxLabel.Text = Songs[i].Description;
                Nodes[counter].SongPriceLabel.Text = $"PRICE : {Songs[i].Price}";

                Nodes[counter].SongNameLabel.Visible = true;
                Nodes[counter].SongRichTextBoxLabel.Visible = true;
                Nodes[counter].SongPriceLabel.Visible = true;
                Nodes[counter].SongDeleteButton.Visible = true;
                Nodes[counter].SongBuyButton.Visible = true;

                if (User.UserRole == "admin")
                {
                    Nodes[counter].SongDeleteButton.Enabled = true;
                    Nodes[counter].SongBuyButton.Text = "ADD";
                }

                foreach(SongModel song in User.Songs)
                {
                    if(Nodes[counter].SongNameLabel.Text == song.SongName)
                    {
                        Nodes[counter].SongBuyButton.Enabled = false;
                        break;
                    }
                }
                counter++;
            }
        }

        private void hideAll()
        {
            foreach(Node node in Nodes)
            {
                node.SongNameLabel.Visible = false;
                node.SongRichTextBoxLabel.Visible = false;
                node.SongPriceLabel.Visible = false;
                node.SongDeleteButton.Visible = false;
                node.SongBuyButton.Visible = false;
            }
        }

        private void addSongToAccount(string songTitle)
        {
            SongModel song = DataAccess.GetSong(songTitle);

            DataAccess.AddSongToUser(User, song);
            GlobalSpeechEngine.SpeechStandardProcedures("Song succesfully added to your account! Press enter to continue.");
            MessageBox.Show("Song succesfully added to your account!");
        }

        private void buyButton1_Click(object sender, EventArgs e)
        {
            BuyButtonStandardProcedures(0);
        }

        private void buyButton2_Click(object sender, EventArgs e)
        {
            BuyButtonStandardProcedures(1);
        }

        private void buyButton3_Click(object sender, EventArgs e)
        {
            BuyButtonStandardProcedures(2);
        }

        private void buyButton4_Click(object sender, EventArgs e)
        {
            BuyButtonStandardProcedures(3);
        }

        private void buyButton5_Click(object sender, EventArgs e)
        {
            BuyButtonStandardProcedures(4);
        }

        private void buyButton6_Click(object sender, EventArgs e)
        {
            BuyButtonStandardProcedures(5);   
        }

        private void BuyButtonStandardProcedures(int nodeNumber)
        {
            if (User.UserRole != "admin")
            {
                if (User.Score < Int32.Parse(Nodes[nodeNumber].SongPriceLabel.Text.Split(' ').Last()))
                {
                    GlobalSpeechEngine.SpeechStandardProcedures("Transaction Failed. You do not have enough points. Press enter to continue.");
                    MessageBox.Show("Transaction Failed. You do not have enough points");
                    return;
                }

                User.Score -= Int32.Parse(Nodes[nodeNumber].SongPriceLabel.Text.Split(' ').Last());
                DataAccess.UpdateUser(User);
                currentPointsLabel.Text = $"CURRENT POINTS: {User.Score}";
            }
            Nodes[nodeNumber].SongBuyButton.Enabled = false;

            addSongToAccount(Nodes[nodeNumber].SongNameLabel.Text);
        }

        private void SongGalleryForm_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                this.ActiveControl = Nodes[0].SongRichTextBoxLabel;
            }

            Songs = DataAccess.GetSongs();
            fillTheListSong(currentStartingPoint);
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            DeleteSongFromGalleryStandardProcedures(0);
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            DeleteSongFromGalleryStandardProcedures(1);
        }
        
        private void deleteButton3_Click(object sender, EventArgs e)
        {
            DeleteSongFromGalleryStandardProcedures(2);
        }

        private void deleteButton4_Click(object sender, EventArgs e)
        {
            DeleteSongFromGalleryStandardProcedures(3);
        }

        private void deleteButton5_Click(object sender, EventArgs e)
        {
            DeleteSongFromGalleryStandardProcedures(4);
        }

        private void deleteButton6_Click(object sender, EventArgs e)
        {
            DeleteSongFromGalleryStandardProcedures(5);
        }

        private void DeleteSongFromGalleryStandardProcedures(int nodeNumber)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("Are you certain that you want to remove the song from the song library? " +
                "If yes press enter, otherwise press tab + enter");
            DialogResult dialogResult = MessageBox.Show("Are you certain that you want to remove the song from the song library?", "Delete Song", MessageBoxButtons.YesNo);
            //if no return
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            SongModel song = DataAccess.GetSong(Nodes[nodeNumber].SongNameLabel.Text);

            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(song.FilePath)))
                {
                    // If file found, delete it    
                    File.Delete(song.FilePath);
                    GlobalSpeechEngine.SpeechStandardProcedures("Song deleted succesfully from song library. Press enter to continue.");
                    MessageBox.Show("Song deleted succesfully from song library");
                }
                else MessageBox.Show("Something went wrong!");

            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

            DataAccess.RemoveSongFromLibrary(song);

            //refresh all the songs
            Songs = DataAccess.GetSongs();
            //refresh the user
            User = DataAccess.GetUser(User.Username);
            //refresh the user songs
            User.Songs = DataAccess.GetUserSongs(User);

            //to solve bug
            if (this.Enabled) this.ActiveControl = songGalleryLabel;

            //hide all
            hideAll();
            //refill the list
            fillTheListSong(currentStartingPoint);
        }

        private void songRichTextBox1_Enter(object sender, EventArgs e)
        {
            if (GlobalSpeechEngine.JustEnteredForm)
            {
                GlobalSpeechEngine.SpeechStandardProcedures("Song Gallery Form, here you can check out your songs and edit your account. " +
                    $"You are at the first song in the list of page {currentStartingPoint / 6 + 1}. The name of the song is: {Nodes[0].SongNameLabel.Text} " +
                    $"and the description of the is: {Nodes[0].SongRichTextBoxLabel.Text} and the price is: {Nodes[0].SongPriceLabel.Text.Split(' ').Last()} points");
                GlobalSpeechEngine.JustEnteredForm = false;
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"You are at the first song in the list of page {currentStartingPoint / 6 + 1}. " +
                    $"The name of the song is: {Nodes[0].SongNameLabel.Text} " +
                    $"and the description of the first song is: {Nodes[0].SongRichTextBoxLabel.Text} and the price is: {Nodes[0].SongPriceLabel.Text.Split(' ').Last()} points");
            }
        }

        private void deleteButton1_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"delete button for song {Nodes[0].SongNameLabel.Text}. This action will delete the song from the gallery");
        }

        private void buyButton1_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin") {
                GlobalSpeechEngine.SpeechStandardProcedures($"add button to account for song {Nodes[0].SongNameLabel.Text}");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"buy song button for song {Nodes[0].SongNameLabel.Text}");
            }
        }

        private void songRichTextBox2_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the second song in the list of page {currentStartingPoint / 6 + 1}. " +
                    $"The name of the song is: {Nodes[1].SongNameLabel.Text} " +
                    $"and the description of the song is: {Nodes[1].SongRichTextBoxLabel.Text} and the price is: {Nodes[1].SongPriceLabel.Text.Split(' ').Last()} points");
        }

        private void deleteButton2_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"delete button for song {Nodes[1].SongNameLabel.Text}. This action will delete the song from the gallery");
        }

        private void buyButton2_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"add button to account for song {Nodes[1].SongNameLabel.Text}");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"buy song button for song {Nodes[1].SongNameLabel.Text}");
            }
        }

        private void songRichTextBox3_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the third song in the list of page {currentStartingPoint / 6 + 1}. " +
                   $"The name of the song is: {Nodes[2].SongNameLabel.Text} " +
                   $"and the description of the song is: {Nodes[2].SongRichTextBoxLabel.Text} and the price is: {Nodes[2].SongPriceLabel.Text.Split(' ').Last()} points");
        }

        private void deleteButton3_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"delete button for song {Nodes[2].SongNameLabel.Text}. This action will delete the song from the gallery");
        }

        private void buyButton3_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"add button to account for song {Nodes[2].SongNameLabel.Text}");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"buy song button for song {Nodes[2].SongNameLabel.Text}");
            }
        }

        private void songRichTextBox4_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the fourth song in the list of page {currentStartingPoint / 6 + 1}. " +
                   $"The name of the song is: {Nodes[3].SongNameLabel.Text} " +
                   $"and the description of the song is: {Nodes[3].SongRichTextBoxLabel.Text} and the price is: {Nodes[3].SongPriceLabel.Text.Split(' ').Last()} points");
        }

        private void deleteButton4_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"delete button for song {Nodes[3].SongNameLabel.Text}. This action will delete the song from the gallery");
        }

        private void buyButton4_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"add button to account for song {Nodes[3].SongNameLabel.Text}");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"buy song button for song {Nodes[3].SongNameLabel.Text}");
            }
        }

        private void songRichTextBox5_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the fifth song in the list of page {currentStartingPoint / 6 + 1}. " +
                   $"The name of the song is: {Nodes[4].SongNameLabel.Text} " +
                   $"and the description of the song is: {Nodes[4].SongRichTextBoxLabel.Text} and the price is: {Nodes[4].SongPriceLabel.Text.Split(' ').Last()} points"); ;
        }

        private void deleteButton5_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"delete button for song {Nodes[4].SongNameLabel.Text}. This action will delete the song from the gallery");
        }

        private void buyButton5_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"add button to account for song {Nodes[4].SongNameLabel.Text}");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"buy song button for song {Nodes[4].SongNameLabel.Text}");
            }
        }

        private void songRichTextBox6_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"You are at the sixth song in the list of page {currentStartingPoint / 6 + 1}. " +
                   $"The name of the song is: {Nodes[5].SongNameLabel.Text} " +
                   $"and the description of the song is: {Nodes[5].SongRichTextBoxLabel.Text} and the price is: {Nodes[5].SongPriceLabel.Text.Split(' ').Last()} points"); ;
        }

        private void deleteButton6_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"delete button for song {Nodes[5].SongNameLabel.Text}. This action will delete the song from the gallery");
        }

        private void buyButton6_Enter(object sender, EventArgs e)
        {
            if (User.UserRole == "admin")
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"add button to account for song {Nodes[5].SongNameLabel.Text}");
            }
            else
            {
                GlobalSpeechEngine.SpeechStandardProcedures($"buy song button for song {Nodes[5].SongNameLabel.Text}");
            }
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

        private void earnPointsButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures($"earn points button. Press it to enter points. current points: {User.Score}");
        }

        private void cancelButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("cancel button");
        }

        private void addNewSongButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("add new song to gallery button");
        }

        private void narratorButton_Click(object sender, EventArgs e)
        {
            GlobalSpeechEngine.EnableOrDisableSpeechEngine();
        }

        private void narratorButton_Enter(object sender, EventArgs e)
        {
            GlobalSpeechEngine.SpeechStandardProcedures("narrator button");
        }
    }
}
