using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APISecurity.Models
{
    public class Context : IdentityDbContext<User>
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
