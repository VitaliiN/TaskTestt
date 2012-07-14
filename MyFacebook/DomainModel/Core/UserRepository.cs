using System;
using System.Collections.Generic;
using DomainModel.Domain;
using System.Linq;
using System.Text;

namespace DomainModel.Core
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext dbContext;
        public UserRepository(DataBaseContext dataBaseContext)
        {
            this.dbContext = dataBaseContext;
        }
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
