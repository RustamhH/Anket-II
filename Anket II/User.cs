using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anket_II
{
    internal class User
    {
        private string _email;
        private string _phone;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone 
        { 
            get=>_phone;
            set
            {
                if (!Regex.IsMatch(value, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")) throw new Exception("Invalid Phone");
                else _phone = value;
                
            } 
        }
        public DateTime Birthday { get; set; }
        public string Email 
        {
            get => _email;
            set
            {
                if (!Regex.IsMatch(value, "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+")) throw new Exception("Invalid Email");
                else _email = value;
            }
        }
        public User(string name, string surname, string phone, DateTime birthday, string email)
        {
            Id=Guid.NewGuid();
            Name = name;
            Surname = surname;
            Phone = phone;
            Birthday = birthday;
            Email = email;
        }
    }
}
