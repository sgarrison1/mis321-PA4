using api.Classes;
using api.Controllers;
using api.Models;

namespace api.Interfaces
{
    public interface ICreateSongs
    {
         void Create(Song song);
    }
}