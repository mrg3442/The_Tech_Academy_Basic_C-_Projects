using NewsletterAppMvc.Models;
using NewsletterAppMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signups = db.Signups;
                    var signupVms = new List<SignupVM>();
                    foreach (var signup in signups)
                    {
                        var signupVm = new SignupVM();
                        signupVm.id = signup.id;
                        signupVm.firstName = signup.FirstName;
                        signupVm.lastName = signup.LastName;
                        signupVm.email = signup.EmailAddress;
                        signupVms.Add(signupVm);
                    }
                    return View(signupVms);
                }
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using(NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.Signups.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}