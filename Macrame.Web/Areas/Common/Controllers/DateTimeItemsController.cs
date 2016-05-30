namespace Macrame.Web.Areas.Common.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;

    using Macrame.Domain.Entities.Concrete.Items.DateTime;
    using Macrame.Infrastructure.Context.Concrete.EF;

    public class DateTimeItemsController : Controller
    {
        private EfContext db = new EfContext();

        // GET: Common/DateTimeItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Common/DateTimeItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,BeginDate,BeginTime,EndDate,EndTime,UnitDescription")] DateTimeItem dateTimeItem)
        {
            if (ModelState.IsValid)
            {
                dateTimeItem.Id = Guid.NewGuid();
                db.DateTimeItems.Add(dateTimeItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dateTimeItem);
        }

        // GET: Common/DateTimeItems/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DateTimeItem dateTimeItem = db.DateTimeItems.Find(id);
            if (dateTimeItem == null)
            {
                return HttpNotFound();
            }

            return View(dateTimeItem);
        }

        // POST: Common/DateTimeItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            DateTimeItem dateTimeItem = db.DateTimeItems.Find(id);
            db.DateTimeItems.Remove(dateTimeItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Common/DateTimeItems/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DateTimeItem dateTimeItem = db.DateTimeItems.Find(id);
            if (dateTimeItem == null)
            {
                return HttpNotFound();
            }

            return View(dateTimeItem);
        }

        // GET: Common/DateTimeItems/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DateTimeItem dateTimeItem = db.DateTimeItems.Find(id);
            if (dateTimeItem == null)
            {
                return HttpNotFound();
            }

            return View(dateTimeItem);
        }

        // POST: Common/DateTimeItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,BeginDate,BeginTime,EndDate,EndTime,UnitDescription")] DateTimeItem dateTimeItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dateTimeItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dateTimeItem);
        }

        // GET: Common/DateTimeItems
        public ActionResult Index()
        {
            return View(db.DateTimeItems.ToList());
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