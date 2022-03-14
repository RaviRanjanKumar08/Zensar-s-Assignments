using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp_Assignment.Context;


namespace Asp_Assignment.Controllers
{
    public class AssignController : Controller
    {
        // GET: Assign
        db_testEntities dbObj=new db_testEntities();
        public ActionResult Assign(tbl_assign obj)
        {
            if(obj!=null)
                return View(obj);
            else
                return View();
        }
        [HttpPost]
        public ActionResult AddAssign(tbl_assign model)
        {
            if (ModelState.IsValid)
            {
                tbl_assign obj = new tbl_assign();
                obj.Name = model.Name;
                obj.FamilyName = model.FamilyName;
                obj.ZipCode = model.ZipCode;
                obj.Phone = model.Phone;
                obj.Email = model.Email;
                obj.Address = model.Address;
                obj.City = model.City;
                dbObj.tbl_assign.Add(obj);
                dbObj.SaveChanges();
            }
            ModelState.Clear();
            return View("Assign");
        }
        public ActionResult AssignList()
        {
            var res = dbObj.tbl_assign.ToList();
            return View(res);
        }
        public ActionResult Delete(string Name)
        {
            var res=dbObj.tbl_assign.Where(x => x.Name == Name).First();
            dbObj.tbl_assign.Remove(res);
            dbObj.SaveChanges();
            var list = dbObj.tbl_assign.ToList();
            return View("AssignList", list);
        }

    }
}