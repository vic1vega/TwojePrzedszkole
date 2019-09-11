using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TwojePrzedszkole.API.Models
{
    public class User
    {
        //Credential Data
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        //Personal Data
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public List<UserGroup> GroupName { get; set; }

        //Address Data
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNo { get; set; }
        public string PostalCode { get; set; }

        //Children Data
        public Collection<Child> Children { get; set; }
    }
}