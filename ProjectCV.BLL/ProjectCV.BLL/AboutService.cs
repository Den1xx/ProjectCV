using ProjectCV.DAL;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.BLL
{
    public class AboutService
    {
        private readonly AboutDal _aboutDal;
        public AboutService()
        {
            _aboutDal = new AboutDal();
        }
        public About GetAbout()
        {
            return _aboutDal.GetAbout();
        }
    }
}
