using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.DAL
{
    public class PictureTalk
    {
        public int AddPictureTalk(Model.PictureTalk pt)
        {
            string text = "insert into picturetalk(p_id,u_id,u_name,u_text,u_date) values(:p_id,:u_id,:name,:text,:date)";
            OracleParameter[] pars = new OracleParameter[5]
          {
              new OracleParameter("p_id",pt.p_id),
              new OracleParameter("name",pt.u_name),
              new OracleParameter("u_id",pt.u_id),
              new OracleParameter("text",pt.u_text),
              new OracleParameter("date",pt.u_date)
          };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除评论:指定用户,图片
        /// </summary>
        /// <param name="u_id"></param>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public int DeletePictureTalkU_ID(int u_id,int p_id)
        {
            string text = "delete from picturetalk where u_id=:u_id and p_id=:p_id";
            OracleParameter[] pars = new OracleParameter[2]
            {
                new OracleParameter("u_id",u_id),
                new OracleParameter("p_id",p_id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除评论:图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePictureTalkP_ID(int id)
        {
            string text = "delete from picturetalk where p_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 查询评论:图片ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.PictureTalk> QueryPictureTalkP_ID(int id)
        {
            string text = "select * from picturetalk where p_id=:id";
            List<Model.PictureTalk> list = new List<Model.PictureTalk>();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.PictureTalk pt = new Model.PictureTalk();
                    pt.pt_id =int.Parse(odr["pt_id"].ToString());
                    pt.p_id = int.Parse(odr["p_id"].ToString());
                    pt.u_id = int.Parse(odr["u_id"].ToString());
                    pt.u_name = odr["u_name"].ToString();
                    pt.u_text = odr["u_text"].ToString();
                    pt.u_date = odr["u_date"].ToString();
                    list.Add(pt);
                }
            }
            odr.Close();
            return list;
        }
        /// <summary>
        /// 查询评论:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.PictureTalk> QueryPictureTalkU_ID(int id)
        {
            string text = "select * from picturetalk where u_id=:id";
            List<Model.PictureTalk> list = new List<Model.PictureTalk>();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.PictureTalk pt = new Model.PictureTalk();
                    pt.pt_id = int.Parse(odr["pt_id"].ToString());
                    pt.p_id = int.Parse(odr["p_id"].ToString());
                    pt.u_id = int.Parse(odr["u_id"].ToString());
                    pt.u_name = odr["u_name"].ToString();
                    pt.u_text = odr["u_text"].ToString();
                    pt.u_date = odr["u_date"].ToString();
                    list.Add(pt);
                }
            }
            odr.Close();
            return list;
        }
    }
}
