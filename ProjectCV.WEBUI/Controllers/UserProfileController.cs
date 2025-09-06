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
                cfg.CreateMap<UserProfileUpdateDTO, UserProfile>();
                cfg.CreateMap<UserProfile, UserProfileUpdateDTO>();
            }).CreateMapper();
        }
        public IActionResult Index()
        {
            var user = _userProfileService.GetUserProfile();
            return View(user);
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Invalid user ID.");
            }
            var UserProfile = _userProfileService.GetUserProfile();
            ViewBag.UserProfileSocial = UserProfile.SocialMedias;
            if (UserProfile == null)
            {
                return NotFound("User not found.");
            }
            var userProfileDto = _mapper.Map<UserProfileUpdateDTO>(UserProfile);
            return View(userProfileDto);
        }

        [HttpPost]
        public async Task<ActionResult> Update(UserProfileUpdateDTO model, IFormFile profileFile, IFormFile backgroundFile)
        {
            ModelState.Remove("ProfileImage");
            ModelState.Remove("BackgroundImage");
            if (ModelState.IsValid)
            {
                string newFileName = profileFile.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\img", newFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await profileFile.CopyToAsync(stream);
                }

                model.ProfileImage = newFileName;


                string newFileName2 = backgroundFile.FileName;
                var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\img", newFileName2);

                using (var stream = new FileStream(path2, FileMode.Create))
                {
                    await backgroundFile.CopyToAsync(stream);
                }

                model.BackgroundImage = newFileName2;

                var userProfile = _mapper.Map<UserProfile>(model);

                _userProfileService.Update(userProfile);

                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}
