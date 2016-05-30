using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Macrame.Domain.Entities.Concrete.Items.Additional;
using Macrame.Infrastructure.Context.Concrete.EF;

namespace Macrame.Web.Areas.Common.Controllers
{
    public class CategoryItemsController : Controller
    {
        private EfContext db = new EfContext();

        // GET: Common/CategoryItems
        public ActionResult Index()
        {
            return View(db.CategoryItems.ToList());
        }

        // GET: Common/CategoryItems/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryItem categoryItem = db.CategoryItems.Find(id);
            if (categoryItem == null)
            {
                return HttpNotFound();
            }
            return View(categoryItem);
        }

        // GET: Common/CategoryItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Common/CategoryItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] CategoryItem categoryItem)
        {
            if (ModelState.IsValid)
            {
                categoryItem.Id = Guid.NewGuid();
                db.CategoryItems.Add(categoryItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryItem);
        }

        // GET: Common/CategoryItems/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryItem categoryItem = db.CategoryItems.Find(id);
            if (categoryItem == null)
            {
                return HttpNotFound();
            }
            return View(categoryItem);
        }

        // POST: Common/CategoryItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] CategoryItem categoryItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryItem);
        }

        // GET: Common/CategoryItems/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryItem categoryItem = db.CategoryItems.Find(id);
            if (categoryItem == null)
            {
                return HttpNotFound();
            }
            return View(categoryItem);
        }

        // POST: Common/CategoryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CategoryItem categoryItem = db.CategoryItems.Find(id);
            db.CategoryItems.Remove(categoryItem);
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
