using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class EducationDal
    {
        private readonly DataContext _context;
        public EducationDal()
        {
            _context = new DataContext();
        }
        public List<Education> GetEducation()
        {
            return _context.Educations.ToList();
        }
    }
}
