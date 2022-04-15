using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mis321_pa4;
using api.Classes;
using api.Models;
using api.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // GET: api/Song
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Song> Get()
        {
            IReadSongs read = new ReadSong();
            return read.GetAll();
        }

        // GET: api/Song
        [EnableCors("OpenPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Song
        [EnableCors("OpenPolicy")]
        [HttpPost(Name = "PostSong")]
        public void Post(Song value)
        {
            ICreateSongs newSong = new CreateSong();
            newSong.Create(value);
        }

        // PUT: api/Song/5
        [EnableCors("OpenPolicy")]
        [HttpPut]
        public void Put([FromBody] Song song)
        {
            IUpdateSongs updateSongs = new UpdateSong();
            updateSongs.Update(song);
        }

        // DELETE: api/Song
        [EnableCors("OpenPolicy")]
        [HttpDelete]
        public void Delete([FromBody] Song song)
        {

            IDeleteSongs newDelete = new DeleteSong();
            newDelete.Delete(song);
        }
    }
}
