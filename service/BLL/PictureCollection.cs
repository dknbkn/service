using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.BLL
{
    public class PictureCollection
    {
        DAL.PictureCollection pc = new DAL.PictureCollection();
        public int AddPictureCollection(Model.PictureCollection p)
        {
            return pc.AddPictureCollection(p);
        }
        /// <summary>
        /// 删除用户对该图片的收藏
        /// </summary>
        /// <param name="id"></param>
        /// <param name="u_id"></param>
        /// <returns></returns>
        public int DeletePictureCollectionPC_ID(int id, int u_id)
        {
            return pc.DeletePictureCollectionPC_ID(id, u_id);
        }
        /// <summary>
        ///  删除用户所有图片的收藏
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePictureCollectionU_ID(int id)
        {
            return pc.DeletePictureCollectionU_ID(id);
        }
        /// <summary>
        ///  查询图片收藏数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int QueryPictureCollectionNum(int id)
        {
            return pc.QueryPictureCollectionNum(id);
        }
    }
}
