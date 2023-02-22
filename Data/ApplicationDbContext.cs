using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web_1670.Models;

namespace Web_1670.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Web_1670.Models.Book> Book { get; set; }
        public DbSet<Web_1670.Models.Order> Order { get; set; }
        public DbSet<Web_1670.Models.User> User { get; set; }
        public DbSet<Web_1670.Models.Category> Category { get; set; }
    }
}