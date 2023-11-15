using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWeb.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }


    }
}
