using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_x.Models
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public AppUser(string name, DateTime dob)
        {
            Name = name;
            DOB = dob;
        }
        public AppUser(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public AppUser() : base()
        {

        }
    }
}
