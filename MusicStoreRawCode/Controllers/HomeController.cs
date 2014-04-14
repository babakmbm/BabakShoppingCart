using MusicStoreMVC3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreMVC3.Controllers
{
    public class HomeController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }

        public ActionResult Search(string sq)
        {
            var nist = "NoResult";
            var albums = storeDB.Albums
                                .Include("Artist")
                                .Where(a => a.Title.Contains(sq))
                                .Take(10);
            if (albums.Any())
            {
                return View(albums);
            }
            else return View(nist);
        }


        private List<Album> GetTopSellingAlbums(int count)
        {
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}
