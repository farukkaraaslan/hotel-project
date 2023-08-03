using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Concrete;

public class Services : IEntity<int>
{
 
    public string Icon { get; set; }
    public string Title { get; set; }
    public string Decription { get; set; }
}
