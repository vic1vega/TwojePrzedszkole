using System;

namespace TwojePrzedszkole.API.Models
{
    public class Child
    {
        public int Id { get; set; }

        //Personal Data
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }

        //Address Data
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNo { get; set; }
        public string PostalCode { get; set; }

        //User/Parent Data
        public User User { get; set; }
        public int UserId { get; set; }
    }
}