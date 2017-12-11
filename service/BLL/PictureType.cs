using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.BLL
{
    public class PictureType
    {
        DAL.PictureType pictureType = new DAL.PictureType();
        public int AddPictureType(Model.PictureType ptype)
        {
            return pictureType.AddPictureType(ptype);
        }
        public int DeletePictureType(int id)
        {
            return pictureType.DeletePictureType(id);
        }
        public int updatePictureType(Model.PictureType ptype)
        {
            return pictureType.updatePictureType(ptype);
        }
        public List<Model.PictureType> QueryPictureTypeP_ID(int id)
        {
            return pictureType.QueryPictureTypePtype_ID(id);
        }
        public List<Model.PictureType> QueryPictureTypePtype_ID(int id)
        {
            return pictureType.QueryPictureTypeP_ID(id);
        }

    }
}