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
            return _context.Skills
                .Where(e => ids.Contains(e.Id))
                .ToList();
        }
        public int Update(Skill UpdateSkill)
        {
            var skill = _context.Skills.FirstOrDefault(s => s.Id == UpdateSkill.Id);

            skill.Name = UpdateSkill.Name;
            skill.Rating = UpdateSkill.Rating;

            return _context.SaveChanges();
        }
        public int Create(Skill UpdateSkill)
        {
            return _context.Skills.Add(UpdateSkill).Context.SaveChanges();
        }
        public Skill Find(int id)
        {
             return _context.Skills.Find(id);
        }
        public void Delete(Skill entity)
        {
            _context.Skills.Remove(entity);
            _context.SaveChanges();
        }
    }
}
