using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSareMerged.Models;
using System.Data.Entity.Infrastructure;

namespace CarSareMerged.Controllers
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
            var members = _context.Members.ToList();
            return View("List", members);

        }

        [HttpPost]
        [Route("Members/Index/{option}/{search}")]
        public ActionResult Index(string option, string search)
        {
            var members = _context.Members.ToList();
             
            switch (option)
            {
                case "FName":
                    //Index action method will return a view with a member records based on what a user specify the value in textbox  
                    members = _context.Members.Where(m => m.FName == search || search == null).ToList();
                    break;
                case "LName":
                    members = _context.Members.Where(m => m.LName == search || search == null).ToList();
                    break;
                case "Email":
                    members = _context.Members.Where(m => m.Email == search || search == null).ToList();
                    break;
                case "Phone":
                    members = _context.Members.Where(m => m.Phone == search || search == null).ToList();
                    break;
            }
            return View("List", members);

        }

        public ActionResult Details(int id)
        {
            var members = _context.Members.Find(id);
            return View("MemberDetails", members);
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

                memberInDB.FName = member.FName;
                memberInDB.LName = member.LName;
                memberInDB.Email = member.Email;
                memberInDB.Phone = member.Phone;


            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Members");
        }

        public ActionResult Edit(int id)
        {
            var memberInDB = _context.Members.SingleOrDefault(c => c.ID == id);

            if (memberInDB == null)
                return HttpNotFound();



            return View("MembersForm", memberInDB);
        }
        //GET : Members/Delete/1

        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id.HasValue)
            {
                var member = _context.Members.Find(id);

                if (member == null)
                    return HttpNotFound();

                if (saveChangesError.GetValueOrDefault())
                {
                    ViewBag.ErrorMessage = "Delete Failed. Please try again or contact adminstrator";
                }

                return View(member);
            }
            return HttpNotFound();
        }

        //POST= : Members/Delete/1
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var media = _context.Members.Find(id);
                if (media == null)
                    return View("Error");//new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                _context.Members.Remove(media);
                _context.SaveChanges();
            }
            catch (RetryLimitExceededException)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            return RedirectToAction("Index");
        }
    }
}
      