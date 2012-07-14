using System;
using System.Collections.Generic;

namespace DomainModel.Domain
{
    public class Interest
    {
        public int InterestId { get; set; }

        public String InterestName { get; set; }

        public virtual ICollection<User> Users { get; set; } 
    }
}
