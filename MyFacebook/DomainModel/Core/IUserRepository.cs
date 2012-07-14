using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Domain;

namespace DomainModel.Core
{
    public interface IUserRepository
    {
        IList<User> GetPossibleFriednsForUserByInterests(int id );

        IList<User> GetPossibleFriednsForUserByFriends(int id);

        User GetUserByLogin(string login);

        bool IsUserExist(string login);

        void CreateUser(string FirstName, string LastName, string Login, DateTime BirthDay, string email);

        void CreateUser(User user);

        IList<User> GetFriendsById(int id);

        User GetUserById(int id);

    }
}
