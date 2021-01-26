using DotnetCoreWebAPI.Models;
using System.Collections.Generic;

namespace DotnetCoreWebAPI.Data
{
    public class MockUserRepo : IUserRepo
    {
        public void CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>()
            {
                new User { Id = 0, Name = "ilyas", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress="Ümraniye" },
                new User { Id = 1, Name = "Büşra", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress="Ümraniye" },
                new User { Id = 2, Name = "Atabey", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress="Ümraniye" },
            };

            return users;
        }

        public User GetUserById(int id)
        {
            return new User { Id = 0, Name = "ilyas", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress = "Ümraniye" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
