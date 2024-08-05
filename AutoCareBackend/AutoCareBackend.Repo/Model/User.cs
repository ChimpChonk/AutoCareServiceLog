using System;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Model
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName {get; set;}
        public string Name {get; set;}
        public Uri ProfilePicture {get; set;}
        public DateTime RegisteredDate {get; set;}
    }
}