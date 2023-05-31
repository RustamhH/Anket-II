using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_II
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public User(string name, string surname, string fatherName, string country, string city, string phone, DateTime birthday, string gender)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Birthday = birthday;
            Gender = gender;
        }
    }
}
