using AutoMapper;
using ProjectCV.DAL.DTOs.EducationUpdateDTO;
using ProjectCV.DAL.DTOs.SkillUpdateDTO;
using ProjectCV.DAL.DTOs.UserProfileDto;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserProfileUpdateDTO,UserProfile>().ReverseMap();
            CreateMap<SocialMediaUpdateDTO,SocialMedia>().ReverseMap();
            CreateMap<SkillUpdateDTO,Skill>().ReverseMap();
            CreateMap<EducationUpdateDTO, Education>().ReverseMap();


        }
    }
}
