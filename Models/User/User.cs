using System;
using Microsoft.AspNetCore.Identity;

namespace firstWebApi.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Department {get; set;}
        public string Role { get; set; }
        public bool Active { get; set; } = true;
        public DateTime lastAccess { get; set; }
        public DateTime createdAt { get; set;}  
        public DateTime updatedAt { get; set; }
    }
}