using service;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.DAL
{
   public class Friend
    {
        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddFriend(Model.Friend f)
        {
            string text = "insert into friend(F_NAME,U_ID,F_DESCRIPTION) values(:name,:u_id,:description)";
            OracleParameter[] pars = new OracleParameter[3]
          {
              new OracleParameter("name",f.name),
              new OracleParameter("u_id",f.userId),
              new OracleParameter("description",f.desctiption)
          };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除好友:好友ID
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int DeleteFriendF_ID(int id)
        {
            string text = "delete from friend where f_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除所有好友:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteFriendU_ID(int id)
        {
            string text = "delete from friend where u_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 查询好友:好友ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Friend QueryFriendF_ID(int id)
            {
            string text = "select * from tb_user where f_id=:id";
            Model.Friend friend = new Model.Friend();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    friend.id = int.Parse(odr["f_id"].ToString());
                    friend.userId = int.Parse(odr["U_ID"].ToString());
                    friend.name = odr["f_NAME"].ToString();
                    friend.desctiption = odr["f_description"].ToString();

                }
            }
            odr.Close();
            return friend;
        }
        /// <summary>
        /// 查询所有好友:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Friend> QueryFriendsU_ID(int id)
        {
            string text = "select * from tb_user where u_id=:id";
            List<Model.Friend> list = new List<Model.Friend>();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.Friend friend = new Model.Friend();
                    friend.id = int.Parse(odr["f_id"].ToString());
                    friend.userId = int.Parse(odr["U_ID"].ToString());
                    friend.name = odr["f_NAME"].ToString();
                    friend.desctiption = odr["f_description"].ToString();
                    list.Add(friend);
                }
            }
            odr.Close();
            return list;
        }
        /// <summary>
        /// 判断好友存在
        /// </summary>
        /// <param name="u_id"></param>
        /// <param name="f_id"></param>
        /// <returns></returns>
        public bool ExistFriend(int u_id,int f_id)
        {
            string text = "select count(1) as num from friend where u_id =:u_id and f_id=:f_id";
            Model.User user = new service.Model.User();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("u_id",u_id),
                new OracleParameter("f_id",f_id)
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
