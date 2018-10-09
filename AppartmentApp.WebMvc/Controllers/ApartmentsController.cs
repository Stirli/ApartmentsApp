using ApartmentApp.Domain;
using ApartmentApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

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
            int size = 5;
            if (Request.Cookies.ContainsKey("pageSize"))
            {
                int.TryParse(Request.Cookies["pageSize"], out size);
            }
            else
            {
                Response.Cookies.Append("pageSize",size.ToString());
            }

            ViewBag.Page = page ?? 1;
            ViewBag.Lastpage = Math.Ceiling((double)apRep.Count / size);
            return View(apRep.EnumerateAll().Skip(size * ((page ?? 1) - 1)).Take(size).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(apRep[id]);
        }

        public ActionResult ChangePageSize(int newSize)
        {
            Response.Cookies.Append("pageSize", newSize.ToString());
            return RedirectToAction("Index");
        }
    }
}