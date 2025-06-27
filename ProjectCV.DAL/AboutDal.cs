using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class AboutDal
    {
        private readonly DataContext _context;
        public AboutDal()
        {
            _context = new DataContext();
        }
        public About GetAbout()
        {
            return _context.Abouts.FirstOrDefault();
        }
    }
}
