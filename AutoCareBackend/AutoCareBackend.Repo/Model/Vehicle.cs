using System;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Model
{
    public class Vehicle
    {
        public string Id {get; set;}
        public User Owner {get; set;}
        public List<User> SharedWithUser {get; set;}
        public string Make {get; set;}
        public string Model {get; set;}
        public DateOnly Year {get; set;}
        public string RegNumber {get; set;}
        public Uri VehicleImage {get; set;}
        public DateTime CreatedAt {get; set;}
    }
}