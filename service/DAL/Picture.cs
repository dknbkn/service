using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace service.DAL
{
    public class Picture
    {
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int AddPicture(Model.Picture p)
        {
            string text = "insert into picture(P_NAME,P_DESCRIPTION,P_ADDRESS) values(:name,:description,:address)";
            OracleParameter[] pars = new OracleParameter[3]
          {
              new OracleParameter("name",p.p_Name),
              new OracleParameter("description",p.p_Description),
              new OracleParameter("address",p.p_Address)
          };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 删除图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePicture(int id)
        {
            string text = "delete from picture where p_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
        };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 修改图片名称
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int UpdatePictureName(int id,string name)
        {
            string text = "update picture set p_name=:name where p_id=:id";
            OracleParameter[] pars = new OracleParameter[2]
           {
                new OracleParameter("id",id),
                new OracleParameter("name",name)
       };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 修改图片说明
        /// </summary>
        /// <param name="id"></param>
        /// <param name="des"></param>
        /// <returns></returns>
        public int UpdatePictureDescription(int id, string des)
        {
            string text = "update picture set p_description=:des where p_id=:id";
            OracleParameter[] pars = new OracleParameter[2]
           {
                new OracleParameter("id",id),
                new OracleParameter("des",des)
       };
            return OracleHelper.ExecuteNonQuery(text, pars);
        }
        /// <summary>
        /// 查询图片个数
        /// </summary>
        /// <returns>图片个数</returns>
        public int QueryPictureCount()
        {
            string test = "select count(*) from picture";
            object obj = OracleHelper.Query(test, null);
            return int.Parse(obj.ToString());
        }
        /// <summary>
        /// 获得图片地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetPictureAddress(int id)
        {
            string text = "select pic_address from picture where pic_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter(":id",id)
            };
           return Convert.ToString(OracleHelper.Query(text,pars));
        }
        /// <summary>
        /// 获得图片说明
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetPictureDescription(int id)
        {
            string text = "select pic_desription from picture where pic_id=:id";
            OracleParameter[] pars = new OracleParameter[1]
            {
                new OracleParameter("id",id)
            };
            return Convert.ToString(OracleHelper.Query(text, pars));
        }
        /// <summary>
        /// 获得用户所有图片:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Picture> GetPictureByU_ID(int id)
        {
            string text = "select * from picture where u_id=:id";
            List<Model.Picture> list = new List<Model.Picture>();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.Picture p = new Model.Picture();
                    p.p_id = int.Parse(odr["P_ID"].ToString());
                    p.p_Name = odr["P_NAME"].ToString();
                    p.p_Description = odr["P_DESCRIPTION"].ToString();
                    p.p_Address = odr["p_address"].ToString();
                    p.u_id = int.Parse(odr["u_id"].ToString());
                    p.u_date = odr["u_date"].ToString();
                    list.Add(p);
                }
            }
            odr.Close();
            return list;
        }
        /// <summary>
        /// 获得图片:图片ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Picture GetPictureByP_ID(int id)
        {
            string text = "select * from picture where p_id=:id";
            Model.Picture p = new Model.Picture();
            OracleParameter[] pars = new OracleParameter[]
            {
                new OracleParameter("id",id)
            };
            OracleDataReader odr = OracleHelper.QueryMore(text, pars);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    p.p_id = int.Parse(odr["P_ID"].ToString());
                    p.p_Name = odr["P_NAME"].ToString();
                    p.p_Description = odr["P_DESCRIPTION"].ToString();
                    p.p_Address = odr["p_address"].ToString();
                    p.u_id = int.Parse(odr["u_id"].ToString());
                    p.u_date = odr["u_date"].ToString();
                }
            }
            odr.Close();
            return p;
        }
        public List<Model.Picture> GetPicture()
        {
            string text = "select * from picture ";
            List<Model.Picture> list = new List<Model.Picture>();
            OracleDataReader odr = OracleHelper.QueryMore(text, null);
            if (odr.HasRows)
            {
                while (odr.Read())
                {
                    Model.Picture p = new Model.Picture();
                    p.p_id = int.Parse(odr["P_ID"].ToString());
                    p.p_Name = odr["P_NAME"].ToString();
                    p.p_Description = odr["P_DESCRIPTION"].ToString();
                    p.p_Address = odr["p_address"].ToString();
                    p.u_id = int.Parse(odr["u_id"].ToString());
                    p.u_date = odr["u_date"].ToString();
                    list.Add(p);
                }
            }
            odr.Close();
            return list;
        }
    }
}