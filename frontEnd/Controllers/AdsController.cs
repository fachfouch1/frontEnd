using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.AdAppointment;
using frontEnd.Data;
using Service;

namespace frontEnd.Controllers
{
    public class AdsController : Controller
    {
        AdService adService = new AdService();

        // GET: Ads
        public ActionResult Index()
        {
            return View(adService.GetAllAds());
        }

        // GET: Ads/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ad ad = adService.getbyId(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            return View(ad);
        }

        // GET: Ads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,price_per_day,price_per_month,price,type,etat,governorate,delegation,surface,nbrpieces,rooms,image,piscine,description,taux_reduction")] Ad ad)
        {
            long idu = 1;

            if (ModelState.IsValid)
            {
                adService.AjouterAd(ad, idu);
               
                return RedirectToAction("Index");
            }

            return View(ad);
        }

        // GET: Ads/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ad ad = adService.getbyId(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            return View(ad);
        }

        // POST: Ads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,price_per_day,price_per_month,price,type,etat,governorate,delegation,surface,nbrpieces,rooms,image,piscine,description,taux_reduction")] Ad ad,int id)
        {
            if (ModelState.IsValid)
            {
                adService.updateAd(ad, id);
                return RedirectToAction("Index");
            }
            return View(ad);
        }

        // GET: Ads/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ad ad = adService.getbyId(id);
            if (ad == null)
            {
                return HttpNotFound();
            }
            return View(ad);
        }

        // POST: Ads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            Ad ad = adService.getbyId(id);
            adService.DeleteAd(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
