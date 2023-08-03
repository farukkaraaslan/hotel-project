using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Concrete;

public class ProjectContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DbCon");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("SQL_Connection");
        }

        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Room>  Rooms{ get; set; }
    public DbSet<Services>  Services{ get; set; }
    public DbSet<Staff>  Staffs{ get; set; }
    public DbSet<Subscribe>  Subscribes{ get; set; }
    public DbSet<Testimonial>  Testimonials{ get; set; }
    public DbSet<About> Abouts{ get; set; }
    public DbSet<Booking> Bookings{ get; set; }
    public DbSet<AppUser> Users{ get; set; }
    public DbSet<AppUserOperationClaim> UserOperationClaims{ get; set; }
    public DbSet<AppOperationClaim> OperationClaims{ get; set; }
 
}
