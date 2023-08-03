using System.ComponentModel.DataAnnotations.Schema;

namespace Hotelproject.WebUI.Areas.Admin.Models.Room;

public class AddRoomModel
{
    public string Title { get; set; }
    public int Number { get; set; }
    public int Price { get; set; }
    public int BedCount { get; set; }
    public int BathCount { get; set; }
    public bool Wifi { get; set; }
    public string Description { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
}
