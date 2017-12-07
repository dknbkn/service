using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.Model
{
    public class Picture
    {
        public string picName { get; set; }
        public string picDescription { get; set; }
        public string picAddress { get; set; }
        public object picture { get; set; }
        public int picGoodNum { get; set; }
        public int picTalk { get; set; }
    }
}