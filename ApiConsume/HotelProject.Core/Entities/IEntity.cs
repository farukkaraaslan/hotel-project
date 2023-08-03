using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Entities;
public class IEntity<TId>
{
    public TId Id { get; set; }
	public IEntity()
	{
		Id = default;
	}
    public IEntity(TId id)
    {
        Id = id;
    }
}
