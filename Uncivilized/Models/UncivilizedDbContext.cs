using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Uncivilized.Models;

namespace Uncivilized.Models
{
    public class UncivilizedDbContext : IdentityDbContext<User>
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<GameEvent> GameEvents { get; set; }

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

        public DbSet<Uncivilized.Models.GameEvent> GameEvent { get; set; }
    }
}
