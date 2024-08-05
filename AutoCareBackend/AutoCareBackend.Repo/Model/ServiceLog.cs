using System;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Model
{
    public class ServiceLog
    {
        public string Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime dateTime { get; set; }
        public string ServiceType { get; set; }
        public string ServiceLocation { get; set; }
        public int Kilometers { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }   
        public List<Uri> Images { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}