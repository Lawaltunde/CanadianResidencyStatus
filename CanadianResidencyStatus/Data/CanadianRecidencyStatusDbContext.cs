using Microsoft.EntityFrameworkCore;

namespace CanadianResidencyStatus.Data
{
    public class CanadianRecidencyStatusDbContext : DbContext
    {
        public CanadianRecidencyStatusDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Resident> residents { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<StatusInCanada> statusInCanada { get; set;}
        public DbSet<Job>  jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Country entity
            modelBuilder.Entity<Country>().HasData(new Country
                { 
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "Ng",
                },
                new Country
                {
                    Id = 2,
                    Name = "India",
                    ShortName = "In",
                },
                new Country
                {
                    Id = 3,
                    Name = "China",
                    ShortName = "Ch",
                },
                new Country
                {
                    Id = 4,
                    Name = "Ghana",
                    ShortName = "Gh",
                },
                new Country
                {
                    Id = 5,
                    Name = "United State Of America",
                    ShortName = "USA",
                }
           );

            //Job entity
            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1,
                    JobName = "Software Engineer",
                    Position = "Senior Developer",
                    Status = "Currently Employed",
                    Wages = 500000.00M,
                    DateOfEmployment = DateTime.Now //This could be updated with the real time date
                },
                new Job
                {
                    Id = 2,
                    JobName = "Software Engineer",
                    Position = "CTO",
                    Status = "Currently Employed",
                    Wages = 700000.00M,
                    DateOfEmployment = DateTime.Now //This could be updated with the real time date
                },
                new Job
                {
                    Id = 3,
                    JobName = "Designer",
                    Position = "UI",
                    Status = "Currently Employed",
                    Wages = 400000.00M,
                    DateOfEmployment = DateTime.Now //This could be updated with the real time date
                },
                new Job
                {
                    Id = 4,
                    JobName = "Software Engineer",
                    Position = "Cloud Engineer",
                    Status = "Currently Employed",
                    Wages = 300000.00M,
                    DateOfEmployment = DateTime.Now //This could be updated with the real time date
                },
                new Job
                {
                    Id = 5,
                    JobName = "Software Engineer",
                    Position = "Tester",
                    Status = "Currently Employed",
                    Wages = 200000.00M,
                    DateOfEmployment = DateTime.Now //This could be updated with the real time date
                }
                );
            modelBuilder.Entity<StatusInCanada>().HasData(
                new StatusInCanada
                {
                    Id = 1,
                    StatusName = "Citizen",
                    StatusExpiringDate = DateTime.Now //This is just for example

                },
                 new StatusInCanada
                 {
                     Id = 2,
                     StatusName = "Permanent Resident",
                     StatusExpiringDate = DateTime.Now //This is just for example

                 },
                  new StatusInCanada
                  {
                      Id = 3,
                      StatusName = "Study Permit",
                      StatusExpiringDate = DateTime.Now //This is just for example

                  },
                   new StatusInCanada
                   {
                       Id = 4,
                       StatusName = "Work Permit",
                       StatusExpiringDate = DateTime.Now //This is just for example

                   },
                   new StatusInCanada
                   {
                       Id = 5,
                       StatusName = "Visitor",
                       StatusExpiringDate = DateTime.Now //This is just for example
                   }
                );
            modelBuilder.Entity<Resident>().HasData(
                new Resident
                {
                    Id = 1,
                    Name = "Lawal Hammed",
                    Address = "Woodbine Ave",
                    DateOfEntry = DateTime.Now, // using as an example
                    PostalCode = "P34 678",
                    City = "Sudbury",
                    SIN = "9375683957",
                    Province = "Ontario",
                    CountryId = 1,
                    JobId = 1,
                    StatusId = 1
                },
                new Resident
                {
                    Id = 2,
                    Name = "Anjelo",
                    Address = "King Street Profoundus",
                    DateOfEntry = DateTime.Now, // using as an example
                    PostalCode = "P34 678",
                    City = "Sudbury",
                    SIN = "93756835674",
                    Province = "Ontario",
                    CountryId = 2,
                    StatusId = 2,
                    JobId = 2
                },
                new Resident
                {
                    Id = 3,
                    Name = "Bashiroh",
                    Address = "Toronto",
                    DateOfEntry = DateTime.Now, // using as an example
                    PostalCode = "P34 678",
                    City = "Sudbury",
                    SIN = "9375683294739547",
                    Province = "Ontario",
                    CountryId = 3,
                    StatusId = 3,
                    JobId = 3

                },
                new Resident
                {
                    Id = 4,
                    Name = "Ashish",
                    Address = "Larch",
                    DateOfEntry = DateTime.Now, // using as an example
                    PostalCode = "P5M 678",
                    City = "Sudbury",
                    SIN = "949883957",
                    Province = "Ontario",
                    CountryId = 4,
                    StatusId = 4,
                    JobId = 4
                },
                new Resident
                {
                    Id = 5,
                    Name = "Dade",
                    Address = "Cambrian Residence",
                    DateOfEntry = DateTime.Now, // using as an example
                    PostalCode = "P6B 390",
                    City = "Sudbury",
                    SIN = "99473553957",
                    Province = "Ontario",
                    CountryId = 5,
                    StatusId = 5,
                    JobId = 5,
                }
                );
        }
    }

}
