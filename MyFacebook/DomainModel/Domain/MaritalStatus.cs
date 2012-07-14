using System.Collections.Generic;

namespace DomainModel.Domain
{
    public class MaritalStatus
    {
        public int MaritalStatusId { get; set; }

        public string Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
