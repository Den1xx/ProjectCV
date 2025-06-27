using ProjectCV.DAL;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.BLL
{
    public class UserProfileService
    {
        private readonly UserProfileDal _userProfileDal;
        public UserProfileService()
        {
            _userProfileDal = new UserProfileDal();
        }
        public UserProfile GetUserProfile()
        {
            return _userProfileDal.GetUserProfile();
        }
    }
}
