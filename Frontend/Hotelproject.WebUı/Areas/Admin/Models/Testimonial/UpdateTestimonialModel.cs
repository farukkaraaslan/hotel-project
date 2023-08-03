using System.ComponentModel.DataAnnotations.Schema;

namespace Hotelproject.WebUI.Areas.Admin.Models.Testimonial
{
    public class UpdateTestimonialModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
