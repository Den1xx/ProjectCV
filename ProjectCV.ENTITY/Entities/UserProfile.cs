namespace ProjectCV.ENTITY.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfileImage { get; set; }
        public string BackgroundImage { get; set; }

        public List<SocialMedia> SocialMedias { get; set; }
    }
}
