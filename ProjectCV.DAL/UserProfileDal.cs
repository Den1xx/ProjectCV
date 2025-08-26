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
        public void Update(UserProfile updatedProfile)
        {
            var existingProfile = _context.UserProfiles
                .Include(up => up.SocialMedias)
                .FirstOrDefault(up => up.Id == updatedProfile.Id);

            if (existingProfile != null)
            {
                _mapper.Map(updatedProfile, existingProfile);

                _context.SaveChanges();
            }
        }

    }
}
