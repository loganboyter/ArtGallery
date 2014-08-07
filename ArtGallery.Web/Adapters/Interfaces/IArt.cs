using ArtGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Web.Adapters.Interfaces
{
    interface IArt
    {
        List<Art> GetArts(int artistId);
        Art GetArt(int id);
        void DeleteArt(int id);
        void DeleteArts(int artistId);
        void EditArt(string title, string link, int id);
        Art AddArt(string title, string link, int artistId);
    }
}
