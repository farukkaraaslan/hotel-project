namespace Hotelproject.WebUI.Areas.Admin.Models.Auth
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
