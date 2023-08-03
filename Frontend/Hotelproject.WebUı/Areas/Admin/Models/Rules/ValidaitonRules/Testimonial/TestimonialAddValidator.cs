using FluentValidation;
using Hotelproject.WebUI.Areas.Admin.Models.Testimonial;

namespace Hotelproject.WebUI.Areas.Admin.Models.Rules.ValidaitonRules.Testimonial
{
    public class TestimonialAddValidator: AbstractValidator<AddTestimonialModel>
    {

        public TestimonialAddValidator() {
            RuleFor(r => r.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(r => r.Title).MinimumLength(2).WithMessage("Başlık alanı en az 2 karakter içermelidir.");
            RuleFor(r => r.Name).NotEmpty().WithMessage("Sosyal Medya alanı boş geçilemez.");
        }
    }
}
