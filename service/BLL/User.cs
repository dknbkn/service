using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.BLL
{
    public class User
    {
        service.DAL.User user = new DAL.User();
        public int AddUser(service.Model.User u)
        {
            return user.AddUser(u);
        }
    }
}