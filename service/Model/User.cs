using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.Model
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassWord { get; set; }
        public string userDescription { get; set; }

        #region 获得相应ID
        //public int userFriend { get; set; }
        //public int userPictureType { get; set; }
        //public int userTalk { get; set; }
        //public int userPicture { get; set; }
        #endregion

    }
}