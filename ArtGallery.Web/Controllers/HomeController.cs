using ArtGallery.Data.Models;
using ArtGallery.Web.Adapters;
using ArtGallery.Web.Adapters.Interfaces;
using ArtGallery.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtGallery.Web.Controllers
{
    public class HomeController : Controller
    {
        private IArtist _artistAdapter;
        private IArt _artAdapter;

        public HomeController()
        {
            _artistAdapter = new ArtistAdapter();
            _artAdapter = new ArtAdapter();
        }
        public ActionResult Index()
        {
            return View(_artistAdapter.GetArtists());
        }

        public ActionResult ArtistDetails(int id)
        {
            ArtistVM Bucket = new ArtistVM();
            Bucket.Artist = _artistAdapter.GetArtist(id);
            Bucket.Arts = _artAdapter.GetArts(id);
            return View(Bucket);
        }
        [HttpPost]
        public ActionResult AddArt(string title, string link, int id)
        {
            _artAdapter.AddArt(title, link, id);
            return RedirectToAction("ArtistDetails", new { id = id });
        }
        public ActionResult EditArt(int id)
        {
            return View(_artAdapter.GetArt(id));
        }
        [HttpPost]
        public ActionResult EditArt(string title, string link, int id)
        {
            _artAdapter.EditArt(title, link, id);
            return RedirectToAction("ArtDetails", new { id = id });
        }
        public ActionResult DeleteArt(int id)
        {
            Art Art = _artAdapter.GetArt(id);
            int ArtistId = Art.ArtistId;
            _artAdapter.DeleteArt(id);
            return RedirectToAction("ArtistDetails", new { id = ArtistId });
        }
        public ActionResult AddArtist()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddArtist(string name, string desc)
        {
            Artist Artist = _artistAdapter.AddArtist(name, desc);
            return RedirectToAction("ArtistDetails", new { id = Artist.Id });
        }
        public ActionResult DeleteArtist(int id)
        {
            _artistAdapter.DeleteArtist(id);
            return RedirectToAction("Index");
        }
        public ActionResult EditArtist(int id)
        {
            return View(_artistAdapter.GetArtist(id));
        }
        [HttpPost]
        public ActionResult EditArtist(string name, string desc, int id)
        {
            _artistAdapter.EditArtist(name, desc, id);
            return RedirectToAction("ArtistDetails", new { id = id });
        }
        public ActionResult ArtDetails(int id)
        {
            return View(_artAdapter.GetArt(id));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}