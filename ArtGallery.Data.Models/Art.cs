using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Data.Models
{
    public class Art
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public Art() { }
        public Art(string title, string link, int artistId)
        {
            Title = title;
            Link = link;
            ArtistId = artistId;
        }
    }
}
