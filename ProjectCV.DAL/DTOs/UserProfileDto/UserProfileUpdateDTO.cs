using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL.DTOs.UserProfileDto
{
    public class UserProfileUpdateDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfileImage { get; set; }
        public string BackgroundImage { get; set; }

        public List<SocialMedia> SocialMedias { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
