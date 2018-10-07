using AppartmentApp.Domain;
using AppartmentApp.Domain.Interfaces;
using AppartmentApp.Domain.SimpleRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppartmentApp.WebMvc.Controllers
{
    public class ApartmentsController : Controller
    {
        private IRepository<Apartment> apRep = new Repository();
        // GET: Apartments
        public ActionResult Index(int? page)
        {
            ViewBag.Page = page ?? 1;
            ViewBag.Lastpage = Math.Ceiling((double)apRep.Count / apRep.PageSize);
            return View(apRep.Page(page ?? 1));
        }

        // GET: Apartments/Details/5
        public ActionResult Details(int id)
        {
            return View(apRep[id]);
        }
    }
}