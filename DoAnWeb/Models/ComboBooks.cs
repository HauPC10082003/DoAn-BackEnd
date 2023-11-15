using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWeb.Models
{
    public class ComboBooks
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int ComboId { get; set; }

        [ForeignKey("ComboId")]
        public Combo Combo { get; set; }

        public int Quantity { get; set; }
    }
}
