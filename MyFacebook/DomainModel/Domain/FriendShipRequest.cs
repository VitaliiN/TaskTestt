using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Domain
{
    public class FriendShipRequest
    {
        public int FriendShipRequestId { get; set; }

        public virtual User ToUser { get; set; }

        public virtual User FromUser { get; set; }
    }
}
