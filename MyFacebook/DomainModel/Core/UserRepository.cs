using System;
using System.Collections.Generic;
using System.Data;
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
        public IList<User> GetPossibleFriednsForUserByInterests(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetPossibleFriednsForUserByFriends(int id)
        {
            List<User> result = new List<User>();
            IEnumerable<User> users = dbContext.Users.Where(x => x.UserId != id);
            IList<User> myfriends = GetFriendsById(id);

           

            return result;



        }


        public User GetUserByLogin(string login)
        {
            return this.dbContext.Users.Single(x => x.Login == login);
        }

        public User GetUserById(int id)
        {
            return this.dbContext.Users.Single(x => x.UserId == id);
        }



        public bool IsUserExist(string login)
        {
            User user = dbContext.Users.SingleOrDefault(x => x.Login == login);
            return user != null ? true : false;
        }

        public void CreateUser(string FirstName,string LastName,string Login,DateTime BirthDay,string email)
        {
            User user = new User
                            {
                                BirthDate = BirthDay,
                                Email = email,
                                FirstName = FirstName,
                                LastName = LastName,
                                Login = Login
                            };
            this.dbContext.Entry(user).State = EntityState.Added;
            this.dbContext.SaveChanges();
        }

        public void CreateUser(User user)
        {
            this.dbContext.Entry(user).State = EntityState.Added;
            this.dbContext.SaveChanges();
        }

        public IList<User> GetFriendsById(int id)
        {
            User user = dbContext.Users.Single(x => x.UserId == id);
            return user.Friends.ToList();
        }
    }
}
