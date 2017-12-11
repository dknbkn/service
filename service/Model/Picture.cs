using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.Model
{
    public class Picture
    {
        public string p_Name { get; set; }
        public string p_Description { get; set; }
        public string p_Address { get; set; }
        public object picture { get; set; }
        public int p_id { get; set; }

        public int u_id { get; set; }
        public string u_date { get; set; }
    }
}