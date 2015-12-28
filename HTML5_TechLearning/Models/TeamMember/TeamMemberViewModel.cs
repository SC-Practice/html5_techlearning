using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML5_TechLearning.Models.TeamMember
{
    public class TeamMemberViewModel
    {
        /// <summary>
        /// 頁面大標題.
        /// </summary>
        public string PageTitle { get; set; }

        /// <summary>
        /// 部門下的子部門.
        /// </summary>
        public List<GroupInfo> Groups { get; set; }

        /// <summary>
        /// 獲取測試資料.
        /// </summary>
        public void GetTestData()
        {
            this.PageTitle = "TW B2B TEAM";
            this.Groups = new List<GroupInfo>();

            var group1 = new GroupInfo()
            {
                Title = "3W",
                Members = new List<MemberInfo>()
            };

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

            this.Groups.Add(group1);

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

            this.Groups.Add(group2);

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

            this.Groups.Add(group3);

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

            this.Groups.Add(group4);
        }
    }
}