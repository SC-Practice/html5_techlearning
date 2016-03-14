using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTML5_TechLearning.Models.TeamMember
{
    public class MemberInfo
    {
        /// <summary>
        /// 照片檔案名稱.
        /// </summary>
        public string ImageFileName { get; set; }

        /// <summary>
        /// 中文姓名.
        /// </summary>
        public string ChineseName { get; set; }

        /// <summary>
        /// 英文暱稱.
        /// </summary>
        public string NickName { get; set; }
    }
}
