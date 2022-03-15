using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        private MoviedatabaseEntities db = new MoviedatabaseEntities();

        // GET: Movie
        public ActionResult Index()
        {
            return View(db.Movietables.ToList());
        }
        [HttpGet]
        public async Task<ActionResult> Index(string mvsearch)
        {
            ViewData["mid"]= mvsearch;
            var mvquery = from x in db.Movietables select x;
            if(!string.IsNullOrEmpty(mvsearch))
            {
                mvquery = mvquery.Where(x => x.moviename.Contains(mvsearch));
            }
            return View(await mvquery.AsNoTracking().ToListAsync());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movietable movietable = db.Movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mid,moviename,dateofrelease")] Movietable movietable)
        {
            if (ModelState.IsValid)
            {
                db.Movietables.Add(movietable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movietable);
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movietable movietable = db.Movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mid,moviename,dateofrelease")] Movietable movietable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movietable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movietable);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movietable movietable = db.Movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movietable movietable = db.Movietables.Find(id);
            db.Movietables.Remove(movietable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
