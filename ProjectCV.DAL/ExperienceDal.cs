using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class ExperienceDal
    {
        private readonly DataContext _context;
        public ExperienceDal()
        {
            _context = new DataContext();
        }
        public List<Experience> GetExperiences()
        {
            return _context.Experiances.ToList();
        }
        public int Update(Experience experience)
        {
            var exp = _context.Experiances.FirstOrDefault(x => x.Id == experience.Id);
            if (exp != null)
            {
                exp.CompanyName = experience.CompanyName;
                exp.StartDate = experience.StartDate;
                exp.EndDate = experience.EndDate;
                exp.Title = experience.Title;
                exp.Text = experience.Text;
            }
            return _context.SaveChanges();
        }
    }
}
