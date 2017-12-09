using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class UserTalk
    {
        public int ut_id { get; set; }   //用户评论表ID
        public int u_id { get; set; }    //用户ID
        public int pt_id { get; set; } //用户评论ID
        public string pt_text { get; set; }//用户评论的内容
    }
}
