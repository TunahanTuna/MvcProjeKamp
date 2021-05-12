using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();

        public ActionResult Index()
        {
            //Toplam kategori sayısı
            var value1 = context.Categories.Count().ToString();
            ViewBag.value1 = value1;

            
            var value2 = context.Headings.Count(x => x.CategoryID == 11).ToString();
            ViewBag.value2 = value2;

            
            var value3 = context.Writers.Where(n => n.WriterName.Contains("a") || n.WriterName.Contains("A")).Count();
            ViewBag.value3 = value3;

            
            var value4 = context.Categories.Where(u => u.CategoryID == context.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count())
               .Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.value4 = value4;

            
            var value5 = context.Categories.Where(n => n.CategoryStatus == true).Count() - context.Categories.Where(n => n.CategoryStatus == false).Count();
            ViewBag.value5 = value5;
            return View();
        }
    }
}