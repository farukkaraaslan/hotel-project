using HotelProject.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelProject.Entity.Concrete;

public class Room : IEntity<int>
{

    public string Title { get; set; }
    public int Number { get; set; }
    public string? CoverImage { get; set; }
    public int Price { get; set; }
    public int BedCount { get; set; }
    public int BathCount { get; set; }
    public bool Wifi { get; set; }
    public string Description { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
}
