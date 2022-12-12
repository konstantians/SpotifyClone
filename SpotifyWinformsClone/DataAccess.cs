using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        private static SQLiteConnection connection = new SQLiteConnection(ConnectionString);

        public static UserModel GetUser(string username)
        {
            connection.Open();
            string sqlQuery = $"Select * from User where User.username = '{username}'";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            UserModel user = new UserModel();
            
            while (reader.Read())
            {
                user.Id = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.RecoveryQuestion = reader.GetString(3);
                user.RecoveryAnswer = reader.GetString(4);
                user.Score = reader.GetInt32(5);
                user.UserRole = reader.GetString(6);
            }
            connection.Close();

            return user;

        }

        public static SongModel GetSong(string songTitle)
        {
            connection.Open();
            string sqlQuery = $"Select * from Song where Song.songName = '{songTitle}'";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            SongModel song = new SongModel();

            while (reader.Read())
            {
                song.Id = reader.GetInt32(0);
                song.SongName = reader.GetString(1);
                song.Description = reader.GetString(2);
                song.Price = reader.GetInt32(3);
                song.FilePath = reader.GetString(4);
            }
            connection.Close();

            return song;
        }

        public static SongModel GetSongById(int songId)
        {
            connection.Open();
            string sqlQuery = $"Select * from Song where Song.id = {songId}";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            SongModel song = new SongModel();

            while (reader.Read())
            {
                song.Id = reader.GetInt32(0);
                song.SongName = reader.GetString(1);
                song.Description = reader.GetString(2);
                song.Price = reader.GetInt32(3);
                song.FilePath = reader.GetString(4);
            }
            connection.Close();

            return song;
        }

        public static void CreateUser(UserModel user)
        {
            connection.Open();
            string sqlQuery = $"Insert into User(username,password,recoverPasswordQuestion," +
                $"recoverPasswordAnswer,score,userRole) values('{user.Username}','{user.Password}'," +
                $"'{user.RecoveryQuestion}','{user.RecoveryAnswer}',{user.Score},'{user.UserRole}')";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void CreateSong(SongModel song)
        {
            connection.Open();
            string sqlQuery = $"Insert into Song(songName,description,price,filepath) " +
                $"values('{song.SongName}','{song.Description}'," +
                $"{song.Price},'{song.FilePath}')";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateUser(UserModel user) {
            connection.Open();
            string sqlQuery = $"Update User set username = '{user.Username}', password = '{user.Password}',"
                 + $"recoverPasswordQuestion = '{user.RecoveryQuestion}', recoverPasswordAnswer = '{user.RecoveryAnswer}',"
                 + $"score = {user.Score}, userRole = '{user.UserRole}' where username = '{user.Username}'";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateUserAndUsername(UserModel user,string username)
        {
            connection.Open();
            string sqlQuery = $"Update User set username = '{username}', password = '{user.Password}',"
                 + $"recoverPasswordQuestion = '{user.RecoveryQuestion}', recoverPasswordAnswer = '{user.RecoveryAnswer}',"
                 + $"score = {user.Score}, userRole = '{user.UserRole}' where username = '{user.Username}'";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<UserModel> GetUsers() {
            connection.Open();
            string sqlQuery = $"Select * from User";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<UserModel> users = new List<UserModel>();

            while (reader.Read())
            {
                UserModel user = new UserModel();

                user.Id = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.RecoveryQuestion = reader.GetString(3);
                user.RecoveryAnswer = reader.GetString(4);
                user.Score = reader.GetInt32(5);
                user.UserRole = reader.GetString(6);

                users.Add(user);
            }
            connection.Close();

            return users;
        }

        public static List<SongModel> GetSongs()
        {
            connection.Open();
            string sqlQuery = $"Select * from Song";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<SongModel> songs = new List<SongModel>();

            while (reader.Read())
            {
                SongModel song = new SongModel();

                song.Id = reader.GetInt32(0);
                song.SongName = reader.GetString(1);
                song.Description = reader.GetString(2);
                song.Price = reader.GetInt32(3);
                song.FilePath = reader.GetString(4);
                songs.Add(song);
            }
            connection.Close();

            return songs;
        }

        public static void AddSongToUser(UserModel user,SongModel song)
        {
            connection.Open();
            string sqlQuery = $"Insert into user_song(userId,songId) " +
                $"values({user.Id},{song.Id})";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void RemoveSongFromUser(UserModel user,SongModel song)
        {
            connection.Open();
            string sqlQuery = $"Delete from user_song " +
                $"where userId = {user.Id} and songId = {song.Id}";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //removes all references/connections for the song from the table
        private static void RemoveAllSongRefences(SongModel song)
        {
            connection.Open();
            string sqlQuery = $"Delete from user_song " +
                $"where songId = {song.Id}";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //removes the song from the song table
        private static void RemoveSong(SongModel song)
        {
            connection.Open();
            string sqlQuery = $"Delete from Song " +
                $"where id = {song.Id}";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void RemoveSongFromLibrary(SongModel song)
        {
            RemoveAllSongRefences(song);
            RemoveSong(song);
        }

        public static List<SongModel> GetUserSongs(UserModel user)
        {
            connection.Open();
            string sqlQuery = $"Select songId from user_song join user on userId = user.Id where user.Id = {user.Id}";
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<int> songIds = new List<int>();

            while (reader.Read())
            {
                songIds.Add(reader.GetInt32(0));
            }
            connection.Close();

            List<SongModel> songs = new List<SongModel>();
            foreach(int songId in songIds)
            {
                songs.Add(DataAccess.GetSongById(songId));
            }

            return songs;
        }

    }
}
