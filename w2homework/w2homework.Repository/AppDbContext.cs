using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using w2homework.Core.Models;

namespace w2homework.Repository
{
    public class AppDbContext : DbContext
    {
        //Context dosyası oluşturuldu

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
