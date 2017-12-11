using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.BLL
{
   public class Friend
    {
        DAL.Friend f = new DAL.Friend();
        /// <summary>
        /// 添加用户 1成功 0失败
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddFriend(service.Model.Friend u)
        {
            return f.AddFriend(u);
        }
        /// <summary>
        /// 删除好友:好友ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelelteFriendF_ID(int id)
        {
            return f.DeleteFriendF_ID(id);
        }
        /// <summary>
        /// 删除所有好友:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelelteFriendU_ID(int id)
        {
            return f.DeleteFriendU_ID(id);
        }
        /// <summary>
        /// 查询好友:好友ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Friend QueryFriendF_ID(int id)
        {
            return f.QueryFriendF_ID(id);
        }
        /// <summary>
        /// 查询所有好友:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Friend> QueryFriendsU_ID(int id)
        {
            return f.QueryFriendsU_ID(id);
        }
        /// <summary>
        /// 判断用户存在
        /// </summary>
        /// <param name="u_id"></param>
        /// <param name="f_id"></param>
        /// <returns></returns>
        public bool ExistFriend(int u_id, int f_id)
        {
            return f.ExistFriend(u_id,f_id);
        }



    }
}
