using DotnetCoreWebAPI.Models;
using System.Collections.Generic;

namespace DotnetCoreWebAPI.Data
{
    public class MockUserRepo : IUserRepo
    {
        public void CreateUser(User user)
        {
            new User { Id = 4, Name = user.Name, Surname = user.Surname, Blood = user.Blood, Cellphone = user.Cellphone, Adress = user.Adress };
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>()
            {
                new User { Id = 1, Name = "ilyas", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress="Ümraniye" },
                new User { Id = 2, Name = "Büşra", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress="Ümraniye" },
                new User { Id = 3, Name = "Atabey", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress="Ümraniye" },
            };

            return users;
        }

        public User GetUserById(int id)
        {
            return new User { Id = 1, Name = "ilyas", Surname = "varol", Blood = Blood.ABRhDpositive, Cellphone = "5307767295", Adress = "Ümraniye" };
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateUser(User user)
        {

        }
    }
}
