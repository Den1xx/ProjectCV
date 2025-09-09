using ProjectCV.DAL;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.BLL
{
    public class SkillService
    {
        private readonly SkillDal _skillDal;
        public SkillService()
        {
            _skillDal = new SkillDal();
        }
        public List<Skill> GetSkills()
        {
            return _skillDal.GetSkills().ToList();
        }
        public void Update(Skill UpdateSkill)
        {
            _skillDal.UpdateSkills(UpdateSkill);
        }
    }
}
