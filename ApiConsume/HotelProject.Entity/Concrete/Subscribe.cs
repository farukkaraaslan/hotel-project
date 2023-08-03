using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.Concrete;

public class Subscribe : IEntity<int>
{
    public string Mail { get; set; }
}
