using System.Net.Sockets;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using api.Interfaces;
using api.Models;
using mis321_pa4;

namespace api.Classes

{
    public class ReadSong : IReadSongs
    {
         public List<Song> GetAll() //timestam Desc
        {
            List<Song> songs =  new List<Song>();    
            Song mySong = new Song();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * from songs ORDER by songtimestamp DESC";
            {
            using var cmd = new MySqlCommand(stm, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                songs.Add(new Song(){
                    SongID = read.GetInt32(0),
                    SongTitle = read.GetString(1),
                    SongTimestamp = read.GetDateTime(2),
                    Deleted = read.GetString(3),
                    Favorited = read.GetString(4),
                });
            }
            }
           return songs;
        }

        public Song GetOne(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}