using ArtGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Web.Adapters.Interfaces
{
    interface IArtist
    {
        List<Artist> GetArtists();
        Artist GetArtist(int id);
        void DeleteArtist(int id);
        void EditArtist(string name, string desc, int id);
        Artist AddArtist(string name, string desc);
    }
}
