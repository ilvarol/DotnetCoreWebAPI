using DotnetCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreWebAPI.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
