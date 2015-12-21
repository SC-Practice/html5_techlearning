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
            TeamMemberViewModel model = new TeamMemberViewModel() {
                PageTitle = "TW B2B TEAM",
                Groups = new List<GroupInfo>()
            };

            var group1 = new GroupInfo() {
                Title = "3W",
                Members = new List<MemberInfo>()
            };

            group1.Members.Add(new MemberInfo() {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });

            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });

            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });

            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });

            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });

            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });

            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "陳瑩聰",
                ImageFileName = "Daniel.jpg",
                NickName = "Daniel"
            });
            
            group1.Members.Add(new MemberInfo()
            {
                ChineseName = "童俊傑",
                ImageFileName = "comingsoon.png",
                NickName = "Jerry"
            });

            model.Groups.Add(group1);

            var group2 = new GroupInfo()
            {
                Title = "SSL",
                Members = new List<MemberInfo>()
            };

            group2.Members.Add(new MemberInfo()
            {
                ChineseName = "陳智興",
                ImageFileName = "comingsoon.png",
                NickName = "Sean"
            });

            group2.Members.Add(new MemberInfo()
            {
                ChineseName = "林承翰",
                ImageFileName = "comingsoon.png",
                NickName = "Sin"
            });

            model.Groups.Add(group2);

            var group3 = new GroupInfo()
            {
                Title = "Testing",
                Members = new List<MemberInfo>()
            };

            group3.Members.Add(new MemberInfo()
            {
                ChineseName = "林炘慧",
                ImageFileName = "comingsoon.png",
                NickName = "Orange"
            });

            group3.Members.Add(new MemberInfo()
            {
                ChineseName = "沈介民",
                ImageFileName = "comingsoon.png",
                NickName = "Jonathan"
            });

            model.Groups.Add(group3);

            var group4 = new GroupInfo()
            {
                Title = "PM",
                Members = new List<MemberInfo>()
            };

            group4.Members.Add(new MemberInfo()
            {
                ChineseName = "陳旭超",
                ImageFileName = "comingsoon.png",
                NickName = "Super"
            });

            model.Groups.Add(group4);

            return View(model);
        }
    }
}