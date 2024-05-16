using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Infrastructure.RichTypesConverters;

namespace Spg.Spengergram.Infrastructure
{
    public class SqLiteDatabase : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public SqLiteDatabase()
        { }
        public SqLiteDatabase(DbContextOptions options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //
            // Owns One
            builder.Entity<User>().OwnsOne(e => e.EMailAddress);
            builder.Entity<User>().OwnsOne(e => e.Username);
            //
            // Owns Many
            builder.Entity<User>().OwnsMany(
                p => p.PhoneNumbers, a =>
                {
                    a.WithOwner().HasForeignKey("UserId");
                    a.Property<int>("Id");
                    a.HasKey("Id");
                });
            //
            // Rich Types
            builder.Entity<User>()
                .Property(p => p.Id)
                .HasConversion(new UserIdValueConverter())
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .IsRequired();
        }
    }
}
