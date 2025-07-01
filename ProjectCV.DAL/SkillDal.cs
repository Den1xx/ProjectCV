using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class SkillDal
    {
        private readonly DataContext _context;
        public SkillDal()
        {
            _context = new DataContext();
        }
        public List<Skill> GetSkills()
        {
            var result = _context.Skills.ToList();
            return result;
        }
    }
}
