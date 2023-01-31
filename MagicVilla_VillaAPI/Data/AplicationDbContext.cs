using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
         : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name= "Royal Villa",
                    Details = "Blazor is a free open-source web framework, enabling developers to create interactive web UIs with C#",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft =550,
                    Amenity ="",
                    CreatedDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa",
                    Details = "Blazor ",
                    ImageUrl = "",
                    Occupancy = 2,
                    Rate = 400,
                    Sqft = 950,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Villa",
                    Details = "Blazor ",
                    ImageUrl = "",
                    Occupancy = 3,
                    Rate = 300,
                    Sqft = 450,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}
