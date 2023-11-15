using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWeb.Models
{
    public class ProductReviews
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }


        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }


        public int Raiting {  get; set; }

        public string Reviews { get; set; }


        public DateTime create_At { get; set; }

        public string ImageReview { get; set; }
    }
}
