using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace service.DAL
{
    public class User
    {
        public int AddUser(service.Model.User u)
        {
            string text = "insert into tb_user(U_NAME,U_PASSWORD,U_DESCRIPTION) values(:name,:pswd,:description)";
            OracleParameter[] pars = new OracleParameter[3]
          {
              new OracleParameter("name",u.userName),
              new OracleParameter("pswd",u.userPassWord),
              new OracleParameter("description",u.userDescription)
          };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
 
    }
}