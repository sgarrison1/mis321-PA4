using mis321_pa4;
using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Classes

{

    public class CreateSong :  ICreateSongs
    {
        public void CreateSongTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE if not exists songs(songid INTEGER PRIMARY KEY AUTO_INCREMENT, songtitle TEXT, songtimestamp DATETIME, deleted TEXT)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
         public void Create(Song mySong)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm =  @"INSERT INTO songs (songTitle, songTimestamp, deleted, favorited) VALUES(@songTitle, @songTimestamp, @deleted, @favorited)";
            
            using var cmd = new MySqlCommand(stm,con);
            cmd.Parameters.AddWithValue("@songTitle", mySong.SongTitle);
            cmd.Parameters.AddWithValue("@songTimestamp", mySong.SongTimestamp);
            cmd.Parameters.AddWithValue("@deleted", mySong.Deleted);
            cmd.Parameters.AddWithValue("@favorited", mySong.Favorited);
           

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

       
    }
}