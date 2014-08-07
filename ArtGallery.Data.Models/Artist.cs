using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Data.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public Artist() { }
        public Artist(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }
    }
}
