using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chughesit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Contact(ContactViewModel contact)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}