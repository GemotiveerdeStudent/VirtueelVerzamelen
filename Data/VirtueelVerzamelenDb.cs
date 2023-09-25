namespace VirtueelVerzamelen.Data

{ 
using VirtueelVerzamelen.Models.ClassModels;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
    using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

    public class VirtueelVerzamelenDb : DbContext
    {
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(v => v.Name)
                .HasMaxLength(30);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
    /*        string connection = @"Data Source=.;Initial Catalog=VirtueelVerzamelen;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connection); */
        }

        public VirtueelVerzamelenDb(DbContextOptions<VirtueelVerzamelenDb> contextOptions) : base(contextOptions)
        {

        }
    }
    
}
