using System.ComponentModel.DataAnnotations.Schema;

namespace Hotelproject.WebUI.Areas.Admin.Models.Testimonial;

public class AddTestimonialModel
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    [NotMapped]
    public IFormFile ImageFile { get; set; }
}
