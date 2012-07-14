using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DomainModel.Domain
{
     public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "First Name required")]
        public string FirstName { get; set; }

         [Required(ErrorMessage = "Last Name required")]
        public string LastName { get; set; }
       
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public string PhotoPath { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$",ErrorMessage = "Fill correct Email")]
        public string Email { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual MaritalStatus MaritalStatus { get; set; }

        public virtual ICollection<Interest> Interests { get; set; }

        public virtual ICollection<User> Friends { get; set; }



    }
}
