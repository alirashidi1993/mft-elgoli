using System;

namespace WebApplication2.DataAcessLayer.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CodeMelli { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string CodePosti { get; set; }
        public DateTime Birthdate { get; set; }
        public string ImageUrl { get; set; }
        public string FatherName { get; set; }
    }
}