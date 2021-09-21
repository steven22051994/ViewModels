using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;
using ViewModels.ViewModel;

namespace ViewModels.Controllers
{
    public class HundController : Controller
    {
        public static List<Hund> HundeListe = new List<Hund>();
        public static List<Fell> FellListe= new List<Fell>();
        public static List<HundUndFellViewModel> HundUndFellViewModels = new List<HundUndFellViewModel>();
        // GET: Fell
        public ActionResult Index()
        {
            //var activeFellLeine = FellListe.Where(fell => fell.Active == true).ToList();

            return View(FellListe.Where(fell => fell.Active == true).ToList());
        }

        // GET: Hund
        public ActionResult Index2()
        {
            //var activeHundeLeine = HundeListe.Where(fell => fell.Active == true).ToList();

            return View(HundeListe.Where(fell => fell.Active == true).ToList());
        }
        
        // GET: Hund
        public ActionResult Index3()
        {

            HundUndFellViewModels.Clear();
            foreach (var item in HundeListe)
            {
                var zeile = new HundUndFellViewModel
                {
                    Hundreferenz = item,
                    Fellreferenz = FellListe.Where(x => x.Id == item.FellId).FirstOrDefault(),
                    TimeStamp = DateTime.Now
                };
                HundUndFellViewModels.Add(zeile);
            }
          
            
            return View(HundUndFellViewModels);
        }

        // GET: Hund/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hund/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hund/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hund/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: Hund/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hund/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hund/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
