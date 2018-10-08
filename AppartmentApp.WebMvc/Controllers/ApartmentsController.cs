using ApartmentApp.Domain;
using ApartmentApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using ApartmentApp.Domain.SimpleRepo;

namespace ApartmentApp.WebMvc.Controllers
{
    public class ApartmentsController : Controller
    {
        private IRepository<Apartment> apRep = RepoFactory.DefaultRepo;

        public ApartmentsController(IRepository<Apartment> apRep = null)
        {
            if (apRep != null)
            {
                this.apRep = apRep;
            }
        }

        // GET: Apartments
        public ActionResult Index(int? page)
        {
            ViewBag.Page = page ?? 1;
            ViewBag.PageSize = apRep.PageSize;
            ViewBag.Lastpage = Math.Ceiling((double)apRep.Count / apRep.PageSize);
            return View(apRep.Page(page ?? 1));
        }

        // GET: Apartments/Details/5
        public ActionResult Details(int id)
        {
            return View(apRep[id]);
        }

        public ActionResult ChangePageSize(int newSize)
        {
            apRep.PageSize = newSize;
            return RedirectToAction("Index");
        }
    }
}