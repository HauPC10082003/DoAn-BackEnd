using Microsoft.AspNetCore.Identity;

namespace DoAnWeb.Models
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }


        public DateTime Birthday { get; set; }
    }
}
