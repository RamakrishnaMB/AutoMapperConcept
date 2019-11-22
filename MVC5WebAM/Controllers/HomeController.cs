using BuisnessLayer.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5WebAM.Controllers
{
    public class HomeController : Controller
    {
        private IDashBoardFeeServices _FeeDetailsService;

        public HomeController(IDashBoardFeeServices FeeDetailsService)
        {
            _FeeDetailsService = FeeDetailsService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetFeeDetails()
        {
            List<FeeDetails> lstFeeDetails = _FeeDetailsService.GetfeeDetails();
            return View(lstFeeDetails);
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