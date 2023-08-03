using FluentValidation;
using Hotelproject.WebUI.Areas.Admin.Models.Service;

namespace Hotelproject.WebUI.Areas.Admin.Models.Rules.ValidaitonRules.Service;

public class ServiceAddValidator : AbstractValidator<AddServiceModel>
{
    public ServiceAddValidator()
    {
        RuleFor(r => r.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
        RuleFor(r => r.Title).MinimumLength(2).WithMessage("Başlık alanı en az 2 karakter içermelidir.");
        RuleFor(r => r.Icon).NotEmpty().WithMessage("Icon alanı boş geçilemez.");
        RuleFor(r => r.Decription).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");

    }
}
