using DB.Config;
using DB.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class ContextDB : DbContext
    {
        private readonly string _defaultConnect;

        public ContextDB()
        {
            _defaultConnect = DbSetting.Initialization()!.DefaultConnectionDB;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseNpgsql(_defaultConnect);
            }
            catch
            {
                throw new Exception("Failed to connect to database\n\nClick OK to exit!");
            }
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Premium> Premium { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(x => x._Department)
                .WithMany(x => x._Employee)
                .HasForeignKey(x => x.IdDepartment);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x._Position)
                .WithMany(x => x._Employee)
                .HasForeignKey(x => x.IdPosition);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x._Premium)
                .WithMany(x => x._Employee)
                .HasForeignKey(x => x.IdPremium);

            modelBuilder.Entity<Department>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Department>().Property(x => x.Name).HasMaxLength(20);

            modelBuilder.Entity<Position>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Position>().Property(x => x.Name).HasMaxLength(20);

            modelBuilder.Entity<Premium>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Premium>().Property(x => x.Name).HasMaxLength(1);
            modelBuilder.Entity<Premium>().HasIndex(x => x.Value).IsUnique();
            modelBuilder.Entity<Premium>().Property(x => x.Value).HasPrecision(3, 0);

            modelBuilder.Entity<Employee>().HasKey(x => new { x.Code});
            modelBuilder.Entity<Employee>().HasIndex(x => x.Phone).IsUnique();
            modelBuilder.Entity<Employee>().Property(x => x.Salary).HasPrecision(6, 2);
        }
    }
}
