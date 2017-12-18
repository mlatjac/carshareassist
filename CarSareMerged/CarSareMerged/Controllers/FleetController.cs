using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSareMerged.Models;


namespace CarSareMerged.Controllers
{
    public class FleetController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Fleet
        public ActionResult Index()
        {
            return View();
        }

        // GET: Map
        public ActionResult Map()
        {
            return View(db.Cars.ToList());
        }
    }
}