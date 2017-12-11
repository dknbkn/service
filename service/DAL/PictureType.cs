using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace service.DAL
{
    public class PictureType
    {
        public int AddPictureType(Model.PictureType ptype)
        {
            string text = "insert into picturetype(ptype_id,ptype_name) values(:ptype_id,:ptype_name)";
            OracleParameter[] pars = new OracleParameter[2]
          {
              new OracleParameter("ptype_id",ptype.ptype_ID),
              new OracleParameter("ptype",ptype.ptype_Name)
          };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        public int DeletePictureType(int id)
        {
            string text = "delete from picturetype where ptype_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        public int updatePictureType(Model.PictureType ptype)
        {
            string text = "update picturetype set ptype_name=:name where ptype_id=:id";
            OracleParameter[] pars = new OracleParameter[2]
           {
                new OracleParameter("id",ptype.ptype_ID),
                new OracleParameter("name",ptype.ptype_Name)
       };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 查询图片类别:图片ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.PictureType> QueryPictureTypeP_ID(int id)
        {
            string text = "select * from picturetype where p_id=:id";
            List<Model.PictureType> list = new List<Model.PictureType>();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.PictureType ptype = new Model.PictureType();
                    ptype.ptype_ID = int.Parse(odr["ptype_id"].ToString());
                    ptype.ptype_Name = odr["ptype_name"].ToString();
                    ptype.p_id = int.Parse(odr["p_id"].ToString());
                    list.Add(ptype);
                }
            }
            odr.Close();
            return list;
        }
        /// <summary>
        /// 查询图片类别下所有图片:图片类别ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.PictureType> QueryPictureTypePtype_ID(int id)
        {
            string text = "select * from picturetype where ptype_id=:id";
            List<Model.PictureType> list = new List<Model.PictureType>();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.PictureType ptype = new Model.PictureType();
                    ptype.ptype_ID = int.Parse(odr["ptype_id"].ToString());
                    ptype.ptype_Name = odr["ptype_name"].ToString();
                    ptype.p_id = int.Parse(odr["p_id"].ToString());
                    list.Add(ptype);
                }
            }
            odr.Close();
            return list;
        }

    }
}