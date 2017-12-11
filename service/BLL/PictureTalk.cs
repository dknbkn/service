using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.BLL
{
  public  class PictureTalk
    {
        DAL.PictureTalk pictureTalk = new DAL.PictureTalk();
        public int AddPictureTalk(Model.PictureTalk pt)
        {
            return pictureTalk.AddPictureTalk(pt);
        }
        /// <summary>
        /// 删除评论:指定用户,图片
        /// </summary>
        /// <param name="u_id"></param>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public int DeletePictureTalkU_ID(int u_id, int p_id)
        {
            return pictureTalk.DeletePictureTalkU_ID(u_id, p_id);
        }
        /// <summary>
        /// 删除评论:指定图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePictureTalkP_ID(int id)
        {
            return pictureTalk.DeletePictureTalkP_ID(id);
        }
        /// <summary>
        /// 查询评论:图片ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.PictureTalk> QueryPictureTalkP_ID(int id)
        {
            return pictureTalk.QueryPictureTalkP_ID(id);
        }
        /// <summary>
        /// 查询评论:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.PictureTalk> QueryPictureTalkU_ID(int id)
        {
            return pictureTalk.QueryPictureTalkU_ID(id);
        }

    }
}
