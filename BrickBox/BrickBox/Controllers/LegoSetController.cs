using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;
using BrickBox.Models.Business;

namespace BrickBox.Controllers
{
    public class LegoSetController : Controller
    {
        private LegoSetMgr legoSetMgr = new LegoSetMgr();
        //
        // GET: /LegoSet/

        public ActionResult Index()
        {
            LegoSet legoSet = new LegoSet();
            return View(legoSetMgr.getSet(legoSet));
        }

        public ActionResult AddSet()
        {
            ViewBag.Message = "Add new sets to inventory.";

            LegoSet legoSet = new LegoSet();
            //legoSet.setName = setNameTextBox.Text;
            //legoSet.setNumber = setNumberTextBox.Text;
            //legoSet.pieceCount = pieceCountTextBox.Text;
            //legoSet.msrp = msrpTextBox.Text;

            //legoSet.setName = "Peter Pan";
            //legoSet.setNumber = "12";
            //legoSet.pieceCount = 869;
            //legoSet.msrp = 98.78;

            legoSetMgr.addSet(legoSet);
            Session["LegoSet"] = legoSet;

            return View();
        }

        public ActionResult ViewSets()
        {
            ViewBag.Message = "View Lego sets saved in your inventory.";
            //setNameLbl.Text = ((LegoSet)Session["LegoSet"]).setName;
            //setNumberLbl.Text = ((LegoSet)Session["LegoSet"]).setNumber;
            //setCountLbl.Text = ((LegoSet)Session["LegoSet"]).pieceCount;
            //setMsrpLbl.Text = ((LegoSet)Session["LegoSet"]).msrp;

            return View();
        }

        public ActionResult RemoveSet()
        {
            ViewBag.Message = "Are you sure you want to remove this Lego set from your inventory?";

            return View();
        }
    }
}
