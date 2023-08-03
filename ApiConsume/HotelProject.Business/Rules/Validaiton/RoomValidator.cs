using FluentValidation;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Rules.Validaiton;

public class RoomValidator : AbstractValidator<Room>
{
    public RoomValidator()
    {
        RuleFor(r => r.Title).NotEmpty();
        RuleFor(r => r.Number).NotEmpty();
        RuleFor(r => r.Price).NotEmpty();
        RuleFor(r => r.BedCount).NotEmpty();
        RuleFor(r => r.BathCount).NotEmpty();
        RuleFor(r => r.Wifi).NotEmpty();
        RuleFor(r => r.Description).NotEmpty();
    }
}
