using FluentValidation;
using Hotelproject.WebUI.Areas.Admin.Models.Staff;

namespace Hotelproject.WebUI.Areas.Admin.Models.Rules.ValidaitonRules.Staff;

public class StaffAddValidator: AbstractValidator<AddStaffViewModel>
{
    public StaffAddValidator()
    {
        RuleFor(r => r.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
        RuleFor(r => r.Title).MinimumLength(2).WithMessage("Başlık alanı en az 2 karakter içermelidir.");
        RuleFor(r => r.SocialMedia1).NotEmpty().WithMessage("Sosyal Medya alanı boş geçilemez.");
        RuleFor(r => r.SocialMedia2).NotEmpty().WithMessage("Sosyal Medya alanı boş geçilemez.");
        RuleFor(r => r.SocialMedia3).NotEmpty().WithMessage("Sosyal Medya alanı boş geçilemez.");
    }
}
