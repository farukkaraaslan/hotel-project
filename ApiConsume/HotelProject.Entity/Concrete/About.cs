using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Concrete;

public class About : IEntity<int>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int RoomCount { get; set; }
    public int StaffCount { get; set; }
    public int ClientCount { get; set; }

    public About()
    {
    }
}
