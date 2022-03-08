using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP_T2012E.Data;
using ASP_T2012E.Models;
using ASP_T2012E.Models.ViewModel;

namespace ASP_T2012E.Controllers
{
    public class AdminsController : Controller
    {
        private ASP_T2012EContext db = new ASP_T2012EContext();

        // GET: Admins
        public ActionResult Index()
        {
            return View(db.Admins.Select(a => new AdminViewModel()
            {
                Id = a.Id,
                Username = a.Username,
                Email = a.Email,
                PhoneVietNam = a.PhoneVietNam,
                Status = a.Status
            }).ToList()) ;
        }

        // GET: Admins/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = await db.Admins.FindAsync(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // GET: Admins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Username,Password,ConfirmPassword,Email,PhoneVietNam,Status")] AdminViewModel adminViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Admins.Add(new Admin(adminViewModel));
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(adminViewModel);
        }

        // GET: Admins/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = await db.Admins.FindAsync(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Username,Password,ConfirmPassword,Email,PhoneVietNam,Status")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        // GET: Admins/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = await db.Admins.FindAsync(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Admin admin = await db.Admins.FindAsync(id);
            db.Admins.Remove(admin);
            await db.SaveChangesAsync();
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
