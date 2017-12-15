using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSharing.Models;

namespace CarSharing.Controllers
{
    public class MembersController : Controller
    {

        private ApplicationDbContext _context;

        //Class contructor
        public MembersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Members
        public ActionResult Index()
        {
            return View();
        }

        //Action from Building Form section
        public ActionResult New()
        {

            var member = new Member();
          
            return View("MembersForm", member);
        }

        //Adding a new member -  http post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Member member)
        {
            //Server side validation - start
            if (!ModelState.IsValid)
            {
                return View("MembersForm", member);
            }
            //**********Server side validation - end *********
            if (member.ID == 0)
            {
                _context.Members.Add(member);
            }
            else
            {
                var memberInDB = _context.Members.Single(m => m.ID == member.ID);
                /*
                 * TryUpdateModel(customerinDB);
                 * this is defualt method to update used by MS
                 * It has major security flow.
                 * 
                 * */
                //This manual way to it.
                memberInDB.FName = member.FName;
                memberInDB.LName = member.LName;
                memberInDB.Email = member.Email;
                memberInDB.Phone = member.Phone;
               

            }

            _context.SaveChanges();

            return RedirectToAction("New", "Members");
        }
    }
}