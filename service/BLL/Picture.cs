using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.BLL
{
    public class Picture
    {
        service.DAL.Picture picture = new DAL.Picture();
        /// <summary>
        /// 添加图片 1成功 0失败
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddPicture(service.Model.Picture p)
        {
            return picture.AddPicture(p);
        }
        /// <summary>
        /// 删除图片:tupaID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePicture(int id)
        {
            return picture.DeletePicture(id);
        }
          public int UpdatePictureName(int id,string name)
        {
            return picture.UpdatePictureName(id, name);
        }
        public int UpdatePictureDescription(int id, string des)
        {
            return picture.UpdatePictureDescription(id, des);
        }
        public int QueryPictureCount()
        {
            return picture.QueryPictureCount();
        }
        public string GetPictureAddress(int id)
        {
            return picture.GetPictureAddress(id);
        }

        public string GetPictureDescription(int id)
        {
            return picture.GetPictureDescription(id);
        }
        /// <summary>
        /// 获得用户的所有图片:用户ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Picture> GetPictureByU_ID(int id)
        {
            return picture.GetPictureByU_ID(id);
        }
        /// <summary>
        /// 获得单个图片:图片ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Picture GetPictureByP_ID(int id)
        {
            return picture.GetPictureByP_ID(id);
        }
        /// <summary>
        /// 获得所有图片
        /// </summary>
        /// <returns></returns>
        public List<Model.Picture> GetPicture()
        {
            return picture.GetPicture();
        }
    }
}