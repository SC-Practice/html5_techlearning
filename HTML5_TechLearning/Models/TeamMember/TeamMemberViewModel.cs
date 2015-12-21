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
    }
}