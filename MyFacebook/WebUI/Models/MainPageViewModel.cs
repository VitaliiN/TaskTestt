using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomainModel.Domain;

namespace WebUI.Models
{
    public class MainPageViewModel
    {
        public string PhotoPath { get; set; }

        public String FullName { get; set; }

        public ICollection<User> Friends { get; set; }

        public ICollection<User> PossibleFriends { get; set; } 

        public ICollection<Interest> Interests { get; set; } 

    }
}