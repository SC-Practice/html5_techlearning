using HTML5_TechLearning.Models.TeamMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML5_TechLearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Daniel()
        {
            return View();
        }

        public ActionResult TeamMember()
        {
            TeamMemberViewModel model = new TeamMemberViewModel();

            // 獲取測試用的資料.
            model.GetTestData();

            return View(model);
        }

        public ActionResult WebWorker()
        {
            return View();
        }

    }
}