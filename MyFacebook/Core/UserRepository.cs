using System;
using System.Collections.Generic;
using DomainModel.Domain;
using System.Linq;
using System.Text;

namespace DomainModel.Core
{
    public class UserRepository : IUserRepository
    {
        public IList<User> GetPossibleFriednsForUserByInterests(User user)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetPossibleFriednsForUserByFriends(User user)
        {
            throw new NotImplementedException();
        }
    }
}
