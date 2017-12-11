using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.DAL
{
    public class PictureCollection
    {
        /// <summary>
        /// 添加图片收藏用户
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int AddPictureCollection(Model.PictureCollection pc)
        {
            string text = "insert into picturecollection(u_id,u_name,p_id) values(:id,:name,p_id)";
            OracleParameter[] pars = new OracleParameter[3]
          {
              new OracleParameter("id",pc.u_id),
              new OracleParameter("name",pc.u_name),
              new OracleParameter("p_id",pc.p_id)
          };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除用户对该图片的收藏:用户ID,图片收藏ID
        /// </summary>
        /// <param name="id">图片收藏ID</param>
        /// <param name="u_id">用户id</param>
        /// <returns></returns>
        public int DeletePictureCollectionPC_ID(int id,int u_id)
        {
            string text = "delete from picturecollection where pc_id=:id and u_id=:u_id";
            OracleParameter[] pars = new OracleParameter[2]
            {
                new OracleParameter("id",id),
                new OracleParameter("u_id",u_id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除用户所有图片的收藏
        /// </summary>
        public int DeletePictureCollectionU_ID(int id)
        {
            string text = "delete from picturecollection where u_id=:id";
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 查询图片收藏数
        /// </summary>
        /// <param name="id">图片ID</param>
        /// <returns></returns>
        public int QueryPictureCollectionNum(int id)
        {
            string text = "select count(*) from picturecollection where p_id=:id";
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
        };
            return int.Parse(OracleHelper.Query(text, pars).ToString());
        }

    }
}
