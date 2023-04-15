using ASPNET_FP.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore;

namespace ASPNET_FP.Data
{
    public class MyLesseeDBContext : IdentityDbContext
    {
        public MyLesseeDBContext(DbContextOptions options) : base(options)
        {

        }

        // Properties are used to access tables

        public DbSet<Account> Accounts { get; set; }
        //public DbSet<Address> Addresses{ get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Image> Images{ get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }

      
        // initial model data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // house type
            modelBuilder.Entity<HouseType>().HasData(
                new HouseType { HouseTypeId = 1, Type = "Detached House" },
                new HouseType { HouseTypeId = 2, Type = "Semi-Detached House" },
                new HouseType { HouseTypeId = 3, Type = "Townhouse" },
                new HouseType { HouseTypeId = 4, Type = "Bungalow" },
                new HouseType { HouseTypeId = 5, Type = "Split-level House" },
                new HouseType { HouseTypeId = 6, Type = "Cottage" },
                new HouseType { HouseTypeId = 7, Type = "Condominium" },
                new HouseType { HouseTypeId = 8, Type = "Apartment" },
                new HouseType { HouseTypeId = 9, Type = "Others" }
            );

            // listing
            modelBuilder.Entity<Listing>().HasData(
                new Listing {
                    ListingId = 1,
                    HouseTypeId = 1,
                    Address = "1080 Mississauga Road, Mississauga, ON",
                    TotalArea = 240,
                    BedroomNo = 5,
                    WahroomNo = 5,
                    ParkingNo = 3,
                    Description = "Beautiful detached house with simple furniture provided",
                    RentalPrice = 2400
                },
                new Listing
                {
                    ListingId = 2,
                    HouseTypeId = 2,
                    Address = "2072 Dundas Road West, Mississauga, ON",
                    TotalArea = 200,
                    BedroomNo = 5,
                    WahroomNo = 5,
                    ParkingNo = 2,
                    Description = "Beautiful semi-detached house with simple furniture provided",
                    RentalPrice = 2300
                },
                new Listing
                {
                    ListingId = 3,
                    HouseTypeId = 3,
                    Address = "1688 Mississauga Vally, Mississauga, ON",
                    TotalArea = 200,
                    BedroomNo = 5,
                    WahroomNo = 3,
                    ParkingNo = 2,
                    Description = "Beautiful townhouse with simple furniture provided",
                    RentalPrice = 2300
                },
                new Listing
                {
                    ListingId = 4,
                    HouseTypeId = 4,
                    Address = "568 Burnhamthorpe Road West, Mississauga, ON",
                    TotalArea = 180,
                    BedroomNo = 3,
                    WahroomNo = 3,
                    ParkingNo = 1,
                    Description = "Beautiful Bungalow",
                    RentalPrice = 2200
                },
                new Listing
                {
                    ListingId = 5,
                    HouseTypeId = 5,
                    Address = "1266 Erindale Station Road, Mississauga, ON",
                    TotalArea = 170,
                    BedroomNo = 3,
                    WahroomNo = 3,
                    ParkingNo = 1,
                    Description = "Beautiful split-level House",
                    RentalPrice = 2200
                },
                new Listing
                {
                    ListingId = 6,
                    HouseTypeId = 6,
                    Address = "760 Dunlop Street East, Barrie, ON",
                    TotalArea = 160,
                    BedroomNo = 4,
                    WahroomNo = 4,
                    ParkingNo = 2,
                    Description = "Beautiful cottage with a small yard",
                    RentalPrice = 2800
                },
                new Listing
                {
                    ListingId = 7,
                    HouseTypeId = 7,
                    Address = "640 Grand Park Drive, Mississauga, ON",
                    TotalArea = 80,
                    BedroomNo = 2,
                    WahroomNo = 2,
                    ParkingNo = 1,
                    Description = "Beautiful condominium with security",
                    RentalPrice = 1800
                },
                new Listing
                {
                    ListingId = 8,
                    HouseTypeId = 8,
                    Address = "395 Wolfedale Road, Mississauga, ON",
                    TotalArea = 80,
                    BedroomNo = 2,
                    WahroomNo = 2,
                    ParkingNo = 1,
                    Description = "Beautiful apartment",
                    RentalPrice = 1600
                },
                new Listing
                {
                    ListingId = 9,
                    HouseTypeId = 9,
                    Address = "115 Eighth Line, Oakville, ON",
                    TotalArea = 240,
                    BedroomNo = 5,
                    WahroomNo = 5,
                    ParkingNo = 3,
                    Description = "Nothing special",
                    RentalPrice = 2400
                }
            );

        }

    }
}
