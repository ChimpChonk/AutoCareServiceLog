using System;

namespace AutoCareBackend.Repo.Model
{
    public class User
    {
        public string UId { get; set; }
        public string Email { get; set; }
        public string UserName {get; set;}
        public string Name {get; set;}
        public string ProfilePicture {get; set;}
        public DateTime RegisteredDate {get; set;}
    }
}