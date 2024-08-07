using System;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Model
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string UserName {get; set;}

        [FirestoreProperty]
        public string Name {get; set;}

        [FirestoreProperty]
        public string ProfilePicture {get; set;}

        [FirestoreProperty]
        public DateTime RegisteredDate {get; set;}
    }
}