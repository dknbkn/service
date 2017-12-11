using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.BLL
{
    public class User
    {
        service.DAL.User user = new DAL.User();
        /// <summary>
        /// 添加用户 1成功 0失败
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddUser(service.Model.User u)
        {
            return user.AddUser(u);
        }
        public int DelelteUser(int id)
        {
            return user.DeleteUser(id);
        }
        public int UpdateUserPSWD(int id,string pswd)
        {
            return user.UpdateUserPSWD(id,pswd);
        }
        public int UpdateUserDes(int id,string des)
        {
            return user.UpdateUserDes(id,des);
        }
        public service.Model.User QueryUser(int id)
        {
            return user.QueryUser(id);
        }
        public bool ExistUser(string name)
        {
            return user.ExistUser(name);
        }
        public bool ExistUserPSWD(string name,string pswd)
        {
            return user.ExistUserPSWD(name,pswd);
        }
    }
}