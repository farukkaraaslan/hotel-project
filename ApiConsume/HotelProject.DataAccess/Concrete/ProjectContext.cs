using HotelProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Concrete;

public class ProjectContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Hotel; Trusted_Connection=True;");
    }
    public DbSet<Room>  Rooms{ get; set; }
    public DbSet<Services>  Services{ get; set; }
    public DbSet<Staff>  Staffs{ get; set; }
    public DbSet<Subscribe>  Subscribes{ get; set; }
    public DbSet<Testimonial>  Testimonials{ get; set; }
}
