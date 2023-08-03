using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Entities.Concrete;

public class OperationClaim :IEntity<int> 
{
    public string Name { get; set; }
}
