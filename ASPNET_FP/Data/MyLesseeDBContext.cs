using ASPNET_FP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_FP.Data
{
    public class MyLesseeDBContext : DbContext
    {
        public MyLesseeDBContext(DbContextOptions options) : base(options)
        {

        }

        //Properties are used to access tables

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Image> Images{ get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                       
        }

    }
}
