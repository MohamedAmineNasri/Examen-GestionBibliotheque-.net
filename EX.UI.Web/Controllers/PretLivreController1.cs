using EX.Core.Domain;
using EX.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EX.UI.Web.Controllers
{
    public class PretLivreController1 : Controller
    {
        readonly IService<PretLivre> pretLivreservice;
        public PretLivreController1(IService<PretLivre> pretLivreservice)
        {
            this.pretLivreservice = pretLivreservice;
        }
        // GET: PretLivreController1
        public ActionResult Index(string filter1, string filter2)
        {
            if (!string.IsNullOrEmpty(filter1) && !string.IsNullOrEmpty(filter2))
            {
                if (DateTime.TryParse(filter1, out DateTime startDate) && DateTime.TryParse(filter2, out DateTime endDate))
                {
                    // Ensure that the end date is greater than or equal to the start date
                    if (endDate >= startDate)
                    {
                        return View(pretLivreservice.GetAll()
                            .Where(f => f.DateDeubt.Date == startDate.Date && f.DateFin.Date == endDate.Date));
                    }
                }
            }
            return View(pretLivreservice.GetAll());
        }


        // GET: PretLivreController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PretLivreController1/Create
        public ActionResult Create()
        {
            var nasri = pretLivreservice.GetAll();
            ViewBag.abon = new SelectList(nasri, "AbonneFk", "MyAbonne.Nom");
            ViewBag.liv = new SelectList(nasri, "LivreFk", "MyLivre.Titre");
            return View();
        }

        // POST: PretLivreController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, PretLivre nas)
        {
            try
            {
                pretLivreservice.Add(nas);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PretLivreController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PretLivreController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PretLivreController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PretLivreController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
