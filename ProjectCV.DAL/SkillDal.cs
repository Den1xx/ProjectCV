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
        public List<Skill> GetSkillsById(List<int> ids)
        {
            return _context.Skills.Where(e=> ids.Contains(e.Id))
                .ToList();
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
