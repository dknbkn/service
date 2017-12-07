using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.DAL
{
    public class Picture
    {
        public bool insertPicture()
        {
            return false;
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
        
        public int AddPicture(Model.Picture p)
        {
            string text = "insert into PICTURE(PIC_NAME,PIC_DESCRIPTION,pic_address) values(:name,:description,:address);";
            OracleParameter[] pars = new OracleParameter[3]
            {
                new OracleParameter("name",p.picName),
                new OracleParameter("description",p.picDescription),
                new OracleParameter("address",p.picAddress)
            };
            return OracleHelper.ExecuteNonQuery(text,pars);
        }
        
    }
}