using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db=new StudentContext();
        // GET: Home
        public ActionResult Index(string searchBy, string search)
        {
            if(searchBy=="Name")
            {
                var data=db.Students.Where(model=>model.Name.StartsWith(search)).ToList();
                return View(data);
            }
            else if (searchBy == "Gender")
            {
                var data = db.Students.Where(model => model.Gender == search).ToList();
                return View(data);
            }
            else
            {
                var data = db.Students.ToList();
                return View(data);
            }
        }
        public ActionResult Create()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "<script>alert('Data Inserted !!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted !!')</script>";
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model=>model.Id==id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if(ModelState.IsValid ==true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script> alert('Data Updated !!') </script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.UpdateMessage = "<script> alert('Data Not Updated !!') </script>";
                }
            }
            
            return View();
        }
        public ActionResult Delete(int id)
        {
            var StudentIDRow=db.Students.Where(model=>model.Id==id).FirstOrDefault();
            return View(StudentIDRow);
        }
        [HttpPost]
        public ActionResult Delete(Student s)
        {
            db.Entry(s).State=EntityState.Deleted;
            int a=db.SaveChanges();
            if(a>0)
            {
                TempData["DeleteMessage"] = "<script> alert('Data Deleted !!') </script>";
            }
            else
            {
                TempData["DeleteMessage"] = "<script> alert('Data Deleted !!') </script>";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var DetailsById=db.Students.Where(model=>model.Id==id).FirstOrDefault();
            return View(DetailsById);
        }
    }
}