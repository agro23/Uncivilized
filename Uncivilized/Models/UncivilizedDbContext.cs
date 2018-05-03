using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Uncivilized.Models
{
    public class UncivilizedDbContext : IdentityDbContext<User>
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Nation> Nations { get; set; }

        public UncivilizedDbContext(DbContextOptions options) : base(options)
        {
        }

        public UncivilizedDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=uncivilized;uid=root;pwd=root;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
