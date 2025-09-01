using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectCV.DAL.Context;
using ProjectCV.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV.DAL
{
    public class UserProfileDal
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserProfileDal()
        {
            _context = new DataContext();
        }
        public UserProfile GetUserProfile()
        {
           return _context.UserProfiles.Include(up => up.SocialMedias)
                .FirstOrDefault();
        }

        public UserProfile GetUserProfileById(int id)
        {
            return _context.UserProfiles
                .Include(up => up.SocialMedias)
                 .FirstOrDefault(up => up.Id == id);
        }

        public int UpdateUserProfile(UserProfile UpdateUserProfile)
        {
            var userProfile = _context.UserProfiles.Include(up => up.SocialMedias)
                .FirstOrDefault(up => up.Id == UpdateUserProfile.Id);

            userProfile.Id = UpdateUserProfile.Id;
            userProfile.Name = UpdateUserProfile.Name;
            userProfile.Surname = UpdateUserProfile.Surname;
            userProfile.ProfileImage = UpdateUserProfile.ProfileImage;
            userProfile.BackgroundImage = UpdateUserProfile.BackgroundImage;
            
            return _context.SaveChanges();
        }


        //public void Update(UserProfile updatedProfile)
        //{
        //    var existingProfile = _context.UserProfiles
        //        .Include(up => up.SocialMedias)
        //        .FirstOrDefault(up => up.Id == updatedProfile.Id);

        //    if (existingProfile != null)
        //    {
        //        _mapper.Map(updatedProfile, existingProfile);

        //        _context.SaveChanges();
        //    }
        //}



    }
}
