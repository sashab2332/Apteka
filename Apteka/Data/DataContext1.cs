using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Models;
using Microsoft.EntityFrameworkCore;

namespace Apteka.Data
{
    public class DataContext1: DbContext
    {
        public DbSet<AEmployee> Employees1 { get; set; }
        public DbSet<AItem> Items1 { get; set; }
        /*public DbSet<Position> Positions { get; set; }*/
        public DbSet<ASellingContents> SellingContents1 { get; set; }
        public DbSet<ASelling> Sellings1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite("Data Source=database1.sqlite3");
            base.OnConfiguring(optionsBuilder);
        }

     
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AEmployee>()
                .HasIndex(x => x.EmployeeId1)
                .IsUnique();

            /*modelBuilder.Entity<Employee>()
                .HasIndex(x => x.Login)
                .IsUnique();*/

            /*modelBuilder.Entity<Position>()
                .HasIndex(x => x.PositionId)
                .IsUnique();*/

            modelBuilder.Entity<ASelling>()
               .HasIndex(x => x.SellingId1)
               .IsUnique();

            modelBuilder.Entity<ASellingContents>()
               .HasIndex(x => x.SellingContentsId1)
               .IsUnique();

            modelBuilder.Entity<AItem>()
               .HasIndex(x => x.Id1)
               .IsUnique();

            /*   modelBuilder.Entity<Employee>()
                  .HasOne(x => x.Position)
                  .WithMany(x=> x.Employees);*/

            modelBuilder.Entity<ASelling>()
              .HasOne(x => x.AEmployee1)
              .WithMany(x => x.ASellings1);

            modelBuilder.Entity<ASellingContents>()
              .HasOne(x => x.ASelling1)
              .WithMany(x => x.ASellingContents1);

            modelBuilder.Entity<ASellingContents>()
             .HasOne(x => x.AItem1)
             .WithMany(x => x.ASellingContents1);

        }

    }

   

}
