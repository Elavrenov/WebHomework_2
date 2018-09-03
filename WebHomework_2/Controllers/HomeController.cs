using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHomework_2.DAL;
using WebHomework_2.Models;

namespace WebHomework_2.Controllers
{
    public class HomeController : Controller
    {
        GalleryContext db = new GalleryContext();
        public ActionResult Index()
        {
            //var photos = db.Photos;
            //ViewBag.Photos = photos;

            return View(db.Photos);
        }

        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return View();
        //}
        //public ActionResult Index(string filter = null, int page = 1, int pageSize = 20)
        //{
        //    var records = new PagedList<Photo>();
        //    ViewBag.filter = filter;

        //    records.Content = db.Photos
        //        .Where(x => filter == null || (x.Description.Contains(filter)))
        //        .OrderByDescending(x => x.PhotoId)
        //        .Skip((page - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToList();
        //    ViewBag.Photos = records;

        //    // Count
        //    records.TotalRecords = db.Photos.Count(x => filter == null || (x.Description.Contains(filter)));

        //    records.CurrentPage = page;
        //    records.PageSize = pageSize;


        //    return View(records);
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}