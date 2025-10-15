using ProjectCV.DAL;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.BLL
{
    public class ExperienceService
    {
        private readonly ExperienceDal _experienceDal;
        public ExperienceService()
        {
            _experienceDal = new ExperienceDal();
        }
        public List<Experience> GetExperiences()
        {
            return _experienceDal.GetExperiences().ToList();
        }
        public int Update(Experience experience)
        {
            return _experienceDal.Update(experience);
        }
    }
}
