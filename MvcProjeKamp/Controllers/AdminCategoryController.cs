using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        // GET: AdminCategory
        public ActionResult Index()
        {
            var categories = cm.GetList();
            return View(categories);
        }
        [HttpGet]
       public ActionResult addCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addCategory(Category p)
        {
            CategoryValidator categorValidator = new CategoryValidator();
            ValidationResult result = categorValidator.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult updateCategory(int id)
        {
            var categoryValue = cm.getById(id);
            return View(categoryValue);
        }
        
        [HttpPost]
        public ActionResult updateCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }

        public ActionResult deleteCategory(int id)
        {

            var categoryValue = cm.getById(id);
            cm.CategoryDelete(categoryValue);
            return RedirectToAction("Index");
        }
    }
}