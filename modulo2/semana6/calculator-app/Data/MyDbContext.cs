using reactnet.Models;
using IdentityServer4.EntityFramework.Options;
using Microsft.EntityFrameworkCore;
using Microsft.Extensions.Options;
using System.Linq;

namespace reactnet.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<DbContext> Options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}