using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace service.DAL
{
    public class User
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddUser(Model.User u)
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
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int DeleteUser(int id)
        {
            string text = "delete from tb_user where u_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int UpdateUserPSWD(int id,string pswd)
        {
            string text = "update tb_user set u_password=:pswd where u_id=:id";
            OracleParameter[] pars = new OracleParameter[2]
            {
                new OracleParameter("id",id),
                new OracleParameter("pswd",pswd)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        public int UpdateUserDes(int id,string des)
        {
            string text = "update tb_user set u_description=:des where u_id=:id";
            OracleParameter[] pars = new OracleParameter[2]
            {
                new OracleParameter("id",id),
                new OracleParameter("des",des)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 查找用户:根据用户ID
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public Model.User QueryUser(int id)
        {
            string text = "select * from tb_user where u_id=:id";
            Model.User user = new Model.User();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if(odr.HasRows)
            {
                while(odr.Read())
                {
                    user.userId= int.Parse(odr["U_ID"].ToString());
                    user.userName = odr["U_NAME"].ToString();
                    user.userPassWord = odr["U_PASSWORD"].ToString();
                   
                }
            }
            odr.Close();
            return user;
        }
        /// <summary>
        /// 判断用户存在
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool ExistUser(string name)
        {
            string text = "select count(1) as num from tb_user where u_name =:name";
            Model.User user = new service.Model.User();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("name",name)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    if (int.Parse(odr["num"].ToString()) == 1)
                    {
                        odr.Close();
                        return true;
                    }
                }
            }
            odr.Close();
            return false;
        }    
        /// <summary>
        /// 判断用户存在:根据用户名和密码
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool ExistUserPSWD(string name,string pswd)
        {
            string text = "select count(1) as num from tb_user where u_name =:name and u_password=:pswd";
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("name",name),
                 new OracleParameter("pswd",pswd)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    if (int.Parse(odr["num"].ToString()) == 1)
                    {
                        odr.Close();
                        return true;
                    }
                }
            }
            odr.Close();
            return false;
        }

    }

}