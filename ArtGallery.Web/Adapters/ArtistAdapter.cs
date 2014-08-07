using ArtGallery.Data;
using ArtGallery.Data.Models;
using ArtGallery.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtGallery.Web.Adapters
{
    public class ArtistAdapter : IArtist
    {
        public List<Artist> GetArtists()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Artists.ToList();
        }

        public Artist GetArtist(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Artists.Where(a => a.Id == id).FirstOrDefault();
        }

        public void DeleteArtist(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Artists.Remove(Db.Artists.Where(a => a.Id == id).FirstOrDefault());
            Db.SaveChanges();
        }

        public void EditArtist(string name, string desc, int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Artist Artist = Db.Artists.Where(a => a.Id == id).FirstOrDefault();
            Artist.Name = name;
            Artist.Desc = desc;
            Db.SaveChanges();
        }

        public Artist AddArtist(string name, string desc)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Artist Artist = Db.Artists.Add(new Artist(name, desc));
            Db.SaveChanges();
            return Artist;
        }
    }
}