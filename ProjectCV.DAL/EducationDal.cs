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
        public int Create(Education edu)
        {
            _context.Educations.Add(edu);
            return _context.SaveChanges();
        }

        public int Update(Education eduUpdate)
        {
            var edu = _context.Educations.FirstOrDefault(x => x.Id == eduUpdate.Id);
            if (edu != null)
            {
                edu.SchoolName = eduUpdate.SchoolName;
                edu.StartDate = eduUpdate.StartDate;
                edu.EndDate = eduUpdate.EndDate;
                edu.Degree = eduUpdate.Degree;
                edu.Text = eduUpdate.Text;
                
            }
            return _context.SaveChanges();
        }
        public Education Find(int id)
        {
            return _context.Educations.Find(id);
        }
        public void Delete(Education entity)
        {
            _context.Educations.Remove(entity);
            _context.SaveChanges();
        }
    }
}
