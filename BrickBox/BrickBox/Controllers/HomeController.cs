using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrickBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "To keep track of your collected Lego sets.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information.";

            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Add new sets to inventory.";

            return View();
        }

        public ActionResult ViewSets()
        {
            ViewBag.Message = "View Lego sets saved in your inventory.";

            return View();
        }

        public ActionResult Remove()
        {
            ViewBag.Message = "Are you sure you want to remove this Lego set from your inventory?";

            return View();
        }
    }
}
