using System;

namespace firstWebApi.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string department {get; set;}
        public string role { get; set; }
        public bool active { get; set; } = true;
        public DateTime lastAccess { get; set; }
        public DateTime createdAt { get; set;}  
        public DateTime updatedAt { get; set; }
    }
}