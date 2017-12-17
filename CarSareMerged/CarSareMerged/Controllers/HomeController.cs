using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSareMerged.Models;
<<<<<<< HEAD
=======
using CarSareMerged.ViewModels;

>>>>>>> 458104a9a893f02334f0b9637d64cd4d39a60d58

namespace CarSareMerged.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
=======
        private ApplicationDbContext db = new ApplicationDbContext();
>>>>>>> 458104a9a893f02334f0b9637d64cd4d39a60d58

        public ActionResult Index()
        {
            HomePageViewModel indexViewModel = new HomePageViewModel(db.CarTypes.ToList());
            return View(indexViewModel);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Member member)
        {
            if (ModelState.IsValid)
            {
                    var obj = _context.Members.Where(a => a.Email.Equals(member.Email) && a.Password.Equals(member.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.ID.ToString();
                        Session["Email"] = obj.Email.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
            }
            return View(member);
        }
          
        

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    

public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}