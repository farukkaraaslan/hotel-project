using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Entities.Concrete;

public class UserOperationClaim :IEntity<int>
{
    public int UserId { get; set; }
    public int ClaimId { get; set; }
}
