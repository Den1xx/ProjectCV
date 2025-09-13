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

        public List<Education> GetEducationsByIds(List<int> ids)
        {
            return _context.Educations
                           .Where(e => ids.Contains(e.Id))
                           .ToList();
        }

        public int Update(Education eduUpdate)
        {
            var edu = _context.Educations.FirstOrDefault(x => x.Id == eduUpdate.Id);
            if (edu != null)
            {
                edu.ShcoolName = eduUpdate.ShcoolName;
                edu.StartDate = eduUpdate.StartDate;
                edu.EndDate = eduUpdate.EndDate;
                edu.Degree = eduUpdate.Degree;
                edu.Text = eduUpdate.Text;
                _context.SaveChanges();
            }

            return _context.SaveChanges();
        }
    }
}
