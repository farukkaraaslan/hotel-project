using FluentValidation;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Rules.Validaiton;

public class TestimonialValidator : AbstractValidator<Testimonial>
{
    public TestimonialValidator()
    {
        RuleFor(r => r.Title).NotEmpty();
        RuleFor(r => r.Name).NotEmpty();
        RuleFor(r => r.Description).NotEmpty();
    }
}

