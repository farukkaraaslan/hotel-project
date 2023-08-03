using FluentValidation;
using Hotelproject.WebUI.Areas.Admin.Models.Room;

namespace Hotelproject.WebUI.Areas.Admin.Models.Rules.ValidaitonRules.Room
{
    public class RoomAddValidaitor :AbstractValidator<AddRoomModel>
    {
           public RoomAddValidaitor()
        {
            RuleFor(r => r.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(r => r.Title).MinimumLength(2).WithMessage("Başlık alanı en az 2 karakter içermelidir.");
            RuleFor(r => r.Number).NotEmpty().WithMessage("Oda numarası alanı boş geçilemez.");
            RuleFor(r => r.Price).NotEmpty().WithMessage("Ücret alanı boş geçilemez.");
            RuleFor(r => r.BedCount).NotEmpty().WithMessage("Yatak sayısı alanı boş geçilemez.");
            RuleFor(r => r.BathCount).NotEmpty().WithMessage("Banyo sayısı alanı boş geçilemez.");
            RuleFor(r => r.Wifi).NotEmpty().WithMessage("Wifi alanı boş geçilemez.");
            RuleFor(r => r.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(r => r.ImageFile).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
        }
    }
}
