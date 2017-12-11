using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace service
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        #region 用户管理
        [WebMethod(Description = "添加用户")]
        public int AddUser(string name, string password,string description)
        {
            service.Model.User u = new Model.User();
            u.userName = name;
            u.userPassWord = password;
            u.userDescription = description;
            return (new service.BLL.User()).AddUser(u);
        }
        [WebMethod(Description = "删除用户")]
        public int DeleteUser(int id)
        {
            return (new service.BLL.User()).DelelteUser(id);
        }
        [WebMethod(Description = "修改用户:密码")]
        public int UpdateUserPSWD(int id,string pswd)
        {
            return (new service.BLL.User()).UpdateUserPSWD(id, pswd);
        }
        [WebMethod(Description = "修改用户:说明")]
        public int UpdateUserDes(int id, string des)
        {
            return (new service.BLL.User()).UpdateUserDes(id, des);
        }
        [WebMethod(Description = "查询用户:根据ID")]
        public Model.User QueryUser(int id)
        {
            return (new service.BLL.User()).QueryUser(id);
        }
        [WebMethod(Description = "判断存在:用户名")]
        public bool ExistUser(string name)
        {
            return (new service.BLL.User()).ExistUser(name);
        }
        [WebMethod(Description = "判断存在:用户名/密码")]
        public bool ExistUserPSWD(string name,string pswd)
        {
            return (new service.BLL.User()).ExistUserPSWD(name, pswd);
        }
        #endregion
    }
}
