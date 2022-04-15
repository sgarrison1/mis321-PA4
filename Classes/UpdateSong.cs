using mis321_pa4;
using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Classes
{
    public class UpdateSong : IUpdateSongs
    {
        public void Update(Song song)
        {
           ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE songs set favorited = 'y' where songid = @songid";
            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@songid", song.SongID);
            
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}