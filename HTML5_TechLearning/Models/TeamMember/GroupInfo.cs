using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTML5_TechLearning.Models.TeamMember
{
    public class GroupInfo
    {
        /// <summary>
        /// 子部門名稱.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 成員的資料.
        /// </summary>
        public List<MemberInfo> Members { get; set; }
    }
}
