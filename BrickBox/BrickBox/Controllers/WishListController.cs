using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrickBox.Models.Domain;

namespace BrickBox.Controllers
{
    public class WishListController : Controller
    {
        private BrickBoxContext db = new BrickBoxContext();

        //
        // GET: /WishList/
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Wishlists.ToList());
        }

        //
        // GET: /WishList/Details/5

        public ActionResult Details(int id = 0)
        {
            WishList wishlist = db.Wishlists.Find(id);
            if (wishlist == null)
            {
                return HttpNotFound();
            }
            return View(wishlist);
        }

        //
        // GET: /WishList/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /WishList/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WishList wishlist)
        {
            if (ModelState.IsValid)
            {
                db.Wishlists.Add(wishlist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wishlist);
        }

        //
        // GET: /WishList/Edit/5

        public ActionResult Edit(int id = 0)
        {
            WishList wishlist = db.Wishlists.Find(id);
            if (wishlist == null)
            {
                return HttpNotFound();
            }
            return View(wishlist);
        }

        //
        // POST: /WishList/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WishList wishlist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wishlist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wishlist);
        }

        //
        // GET: /WishList/Delete/5

        public ActionResult Delete(int id = 0)
        {
            WishList wishlist = db.Wishlists.Find(id);
            if (wishlist == null)
            {
                return HttpNotFound();
            }
            return View(wishlist);
        }

        //
        // POST: /WishList/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WishList wishlist = db.Wishlists.Find(id);
            db.Wishlists.Remove(wishlist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}