using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        /*public DbSet<Position> Positions { get; set; }*/
        public DbSet<SellingContents> SellingContents { get; set; }
        public DbSet<Selling> Sellings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=database.sqlite3");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(x => x.EmployeeId)
                .IsUnique();

            /*modelBuilder.Entity<Employee>()
                .HasIndex(x => x.Login)
                .IsUnique();*/

            /*modelBuilder.Entity<Position>()
                .HasIndex(x => x.PositionId)
                .IsUnique();*/

            modelBuilder.Entity<Selling>()
               .HasIndex(x => x.SellingId)
               .IsUnique();

            modelBuilder.Entity<SellingContents>()
               .HasIndex(x => x.SellingContentsId)
               .IsUnique();

            modelBuilder.Entity<Item>()
               .HasIndex(x => x.Id)
               .IsUnique();

         /*   modelBuilder.Entity<Employee>()
               .HasOne(x => x.Position)
               .WithMany(x=> x.Employees);*/

            modelBuilder.Entity<Selling>()
              .HasOne(x => x.Employee)
              .WithMany(x => x.Sellings);

            modelBuilder.Entity<SellingContents>()
              .HasOne(x => x.Selling)
              .WithMany(x => x.SellingContents);

            modelBuilder.Entity<SellingContents>()
             .HasOne(x => x.Item)
             .WithMany(x => x.SellingContents);





        }

    }

   

}
