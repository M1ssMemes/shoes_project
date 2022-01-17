
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Sex>  Sexes { get; set; }
        public DbSet<Temperament> Temperaments { get; set; }
        public DbSet<CustomType> CustomTypes { get; set; }
        public DbSet<Deformation> Deformations { get; set; }
        public DbSet<TestResults> TestResults { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<BaseModel> BaseModels { get; set; }
        public DbSet<ChosenModel> ChosenModels { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Sex>().ToTable("Sexes");
        }


    }
}
