using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_x.ViewModels
{
    public class AppUserViewModel
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public AppUserViewModel(string name, DateTime dob)
        {
            Name = name;
            DOB = dob;
        }
        public AppUserViewModel(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public AppUserViewModel()
        {

        }
    }
}

