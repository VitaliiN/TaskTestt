using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Domain;

namespace DomainModel.Core
{
    public interface IUserRepository
    {
        IList<User> GetPossibleFriednsForUserByInterests(User user );

        IList<User> GetPossibleFriednsForUserByFriends(User user);



    }
}
