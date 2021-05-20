using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager( new EfCategoryDal());
        WriterManager writerManager = new WriterManager( new EfWriterDal());
        public ActionResult Index()
        {
            var heading = headingManager.GetList();
            return View(heading);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> categoryValue = (from x in categoryManager.GetList() // DropDownList için kullandık, yeni öğrendiğimiz bir şey, Önemli!!
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName, // Display Number
                                                      Value = x.CategoryID.ToString() // Value Number
                                                  }).ToList();
            List<SelectListItem> writerValue = (from x in writerManager.getList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName + " " + x.WriterSurName,
                                                    Value = x.WriterID.ToString()
                                                }).ToList();

            ViewBag.vlc = categoryValue;
            ViewBag.vlw = writerValue;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            headingManager.HeadingAdd(heading);
            return RedirectToAction("Index");
        }
    }
}