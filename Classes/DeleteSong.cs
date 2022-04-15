using api.Interfaces;
using MySql.Data.MySqlClient;
using mis321_pa4;
using api.Models;
using System;

namespace api.Classes

{
    public class DeleteSong: IDeleteSongs
    {

        public void DropSongTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS song";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
            
        }
        public void Delete(Song song)
        {
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DELETE FROM songs where songid = @songid";
            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@songid", song.SongID);
            
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

    }
}