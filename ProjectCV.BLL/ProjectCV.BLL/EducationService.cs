using ProjectCV.DAL;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.BLL
{
    public class EducationService
    {
        private readonly EducationDal _educationDal;
        public EducationService()
        {
            _educationDal = new EducationDal();
        }
        public List<Education> GetEducation()
        {
            return _educationDal.GetEducation();
        }
        public List<Education> GetEducationsByIds(List<int> ids)
        {
            return _educationDal.GetEducationsByIds(ids);
        }
        public int Update(Education eduUpdate)
        {
            return _educationDal.Update(eduUpdate);
        }
    }
}
