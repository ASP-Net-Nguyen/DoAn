using DoAn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TravelModel> TravelModels { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TravelTag> TravelTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TravelTag>().HasKey(protag => new { protag.TravelModelId, protag.TagId });

            //Seeder data tag
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 1,
                Name = "Rẻ"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 2,
                Name = "Ngon"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 3,
                Name = "Bổ Khỏe"
            });
        }
    }
}
