using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWeb.Models
{
    public class Images
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public string Image { get; set; }

    }
}
