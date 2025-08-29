using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.UserProfileDto;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly UserProfileService _userProfileService;
        private readonly IMapper _mapper;
        public UserProfileController()
        {
            _userProfileService = new UserProfileService();
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserProfile, UserProfile>();
            }).CreateMapper();
        }
        public IActionResult Index()
        {
            var user = _userProfileService.GetUserProfile();
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest("Invalid user ID.");
            }
            var UserProfile = _userProfileService.GetUserProfile();
            if (UserProfile == null)
            {
                return NotFound("User not found.");
            }
            var userProfileDto = _mapper.Map<UserProfileUpdateDTO>(UserProfile);
            return View(userProfileDto);
        }
        
    }
}
