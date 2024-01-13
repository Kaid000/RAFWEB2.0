using Microsoft.EntityFrameworkCore;
using RAFWEB2.Data.Models;
using System.Numerics;

namespace RAFWEB2.Core.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Achivement> Achivements { get; set; }
        public DbSet<Article> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactInfo> Contacts { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<MainPageContent> MainPages { get; set; }
        public DbSet<StudentOrganization> Organizations { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Achivement>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<Achivement>().HasKey(b => b.Id);
            modelBuilder.Entity<Achivement>().HasAlternateKey(b => b.Name);

            modelBuilder.Entity<Article>().HasKey(b => b.Id);
            modelBuilder.Entity<Article>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<Article>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Article>().HasAlternateKey(b => b.Title);

            modelBuilder.Entity<Holiday>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<Holiday>().HasKey(b => b.Id);
            modelBuilder.Entity<Holiday>().Property(b => b.OrganizationName).IsRequired();
            modelBuilder.Entity<Holiday>().Property(b => b.Title).IsRequired();

            modelBuilder.Entity<StudentOrganization>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<StudentOrganization>().Property(b => b.Name).IsRequired();

        }
    }
}
