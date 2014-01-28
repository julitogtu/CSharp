using System;

namespace AutoMapper.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime CreationDate { get; set; }

        public string Password { get; set; }
    }
}