using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ClassNamesController : Controller
  {
    private readonly ProjectNameContext _db;

    public ClassNamesController(ProjectNameContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Category> model = _db.Categories.ToList();
    //   return View(model);
    // }

    // public ActionResult Create()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Category category)
    // {
    //   _db.Categories.Add(category);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   Category thisCategory = _db.Categories
    //                               .Include(category => category.Animals)
    //                               .FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // public ActionResult Edit(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost]
    // public ActionResult Edit(Category category)
    // {
    //   _db.Categories.Update(category);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   _db.Categories.Remove(thisCategory);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}