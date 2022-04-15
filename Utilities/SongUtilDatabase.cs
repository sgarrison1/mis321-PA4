using System;
using System.Collections.Generic;
using api.Controllers;
using api.Interfaces;
using api.Models;

namespace mis321_pa4.Utilities
{
    public class SongUtilDatabase: ISongUtilities
    {
         public List<Song> playlist { get; set; }
        List<api.Models.Song> ISongUtilities.playlist { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddSong()
        {
            // string song = Console.ReadLine();
            // Song playlist = new Song(){SongTitle = song, SongTimestamp = DateTime.Now, Deleted = "n" };
            // CreateSong newSong = new CreateSong();
            // newSong.Create(playlist);
            // UpdateSong updateSong = new UpdateSong();
            // updateSong.Update(playlist); //save?
            //playlist.Sort();
            
            //add show one song
        
        }

        public void DeleteSong()
        {
            //add get all songs

            // int id = int.Parse(Console.ReadLine());
            // DeleteSong myDelete = new DeleteSong();
            // myDelete.Delete(id);

        }

        public void EditSong()
        {
        //    ReadSong readSong = new ReadSong();//add get all songs
        //    readSong.GetAll();
        //    System.Console.WriteLine("Enter the id of the song you want to edit");
        //    int id = int.Parse(Console.ReadLine());
        //    System.Console.WriteLine("Enter the new song title");
        //    string newTitle = Console.ReadLine();
        //    Song updateSong = new Song(){SongID = id, SongTitle = newTitle};
        //    UpdateSong playlist = new UpdateSong();
        //    playlist.Update(updateSong);
        //    //add show one song
        }

        public void PrintPlaylist()
        {
            // ReadSong readSong = new ReadSong();//add get all songs
            // readSong.GetAll();
        }
    }
}