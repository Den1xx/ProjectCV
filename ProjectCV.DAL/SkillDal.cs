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
        public Skill GetSkillsById(int id)
        {
            return _context.Skills.FirstOrDefault(s => s.Id == id);
        }
        public int UpdateSkills (Skill UpdateSkill)
        {
            var skill = _context.Skills.FirstOrDefault(s => s.Id == UpdateSkill.Id);

            skill.Name = UpdateSkill.Name;
            skill.Rating = UpdateSkill.Rating;

            return _context.SaveChanges();
        }
    }
}
