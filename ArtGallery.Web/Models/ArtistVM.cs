using ArtGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtGallery.Web.Models
{
    public class ArtistVM
    {
        public Artist Artist { get; set; }
        public List<Art> Arts { get; set; }
    }
}