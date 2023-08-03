using System.ComponentModel.DataAnnotations.Schema;

namespace Hotelproject.WebUI.Areas.Admin.Models.Room;

public class UpdateRoomModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Number { get; set; }
    public int Price { get; set; }
    public int BedCount { get; set; }
    public int BathCount { get; set; }
    public bool Wifi { get; set; }
    public string Description { get; set; }
    public string CoverImage { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
}
