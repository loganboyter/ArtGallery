using ArtGallery.Data;
using ArtGallery.Data.Models;
using ArtGallery.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtGallery.Web.Adapters
{
    public class ArtAdapter : IArt
    {
        public List<Art> GetArts(int artistId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Arts.Where(a => a.ArtistId == artistId).ToList();
        }

        public Art GetArt(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Arts.Where(a => a.Id == id).FirstOrDefault();
        }

        public void DeleteArt(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Arts.Remove(Db.Arts.Where(a => a.Id == id).FirstOrDefault());
            Db.SaveChanges();
        }

        public void DeleteArts(int artistId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<Art> Arts = Db.Arts.ToList();
            int run = 0;
            if(Arts.Where(a => a.ArtistId == artistId).FirstOrDefault() != null) {run = 1;};
            while (run == 1)
            {
                Arts.Remove(Arts.Where(a => a.ArtistId == artistId).FirstOrDefault());
                if (Arts.Where(a => a.ArtistId == artistId).FirstOrDefault() == null) { run = 0; }
            }
        }

        public void EditArt(string title, string link, int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Art Art = Db.Arts.Where(a => a.Id == id).FirstOrDefault();
            Art.Link = link;
            Art.Title = title;
            Db.SaveChanges();
        }

        public Art AddArt(string title, string link, int artistId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Art Art = new Art(title, link, artistId);
            Db.Arts.Add(Art);
            Db.SaveChanges();
            return Art;
        }
    }
}