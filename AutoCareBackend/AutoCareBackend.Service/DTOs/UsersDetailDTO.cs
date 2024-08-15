namespace AutoCareBackend.Service.DTOs
{
    public class UserDetailDTO
    {
        public int Id { get; set; }
        public string UserName { get; set;}
        public string Name { get; set;}
        public string ProfilePicture { get; set;}
        public string Email { get; set;}
        public DateTime RegisteredDate { get; set; }
    }
}