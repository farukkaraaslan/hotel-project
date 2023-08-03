using HotelProject.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Concrete;

public class Testimonial : IEntity<int>
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? Image { get; set; }

    [NotMapped]
    public IFormFile ImageFile { get; set; }
}
